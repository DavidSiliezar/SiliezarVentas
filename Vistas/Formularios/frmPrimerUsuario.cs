using Modelos;
using Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas.Formularios
{
    public partial class frmPrimerUsuario : Form
    {
        public frmPrimerUsuario()
        {
            InitializeComponent();
        }

        private bool CorreoExiste(string correo)
        {
            using (SqlConnection con = Conexion.Conectar())
            {
                string query = "SELECT COUNT(*) FROM Usuario WHERE nombreUsuario = @correo";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@correo", correo);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        private void EnviarCorreoBienvenida(string correoDestino)
        {
            try
            {
                using (var mailService = new SoporteDeContrasena("noedavidsaraviasiliezar345@gmail.com", "thsuzoavqvnpcjvv"))
                {
                    bool emailEnviado = mailService.EnviarMail(
                        subject: "Bienvenido a Siliezar Ventas",
                        body: $"¡Hola! {correoDestino}\n\nTu cuenta en el sistema Siliezar Ventas ha sido creada correctamente.\n\n¡Bienvenido!",
                        recipientMail: new List<string> { correoDestino }
                    );

                    if (!emailEnviado)
                        MessageBox.Show($"No se pudo enviar el correo de bienvenida a {correoDestino}.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error enviando correo de bienvenida: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                string correo = txtUsuario.Text.Trim();
                string clave = txtClave.Text.Trim();

                if (string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(clave))
                {
                    MessageBox.Show("Debe ingresar un correo y una clave.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (CorreoExiste(correo))
                {
                    MessageBox.Show("El correo ya está registrado en el sistema.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Usuario nuevo = new Usuario
                {
                    NombreUsuario = correo,
                    Clave = BCrypt.Net.BCrypt.HashPassword(clave), // Hasheada por la encriptacion
                    EstadoUsuario = false,
                    Id_Rol = 1,
                    PrimerLogin = 1
                };

                if (nuevo.InsertarUsuario())
                {
                    // Mensaje en pantalla
                    MessageBox.Show($"¡Bienvenido al sistema Siliezar Ventas, {correo}!", "Bienvenida", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Enviar correo de bienvenida
                    EnviarCorreoBienvenida(correo);

                    // Abrir formulario principal
                    frmRegistrarVenta menu = new frmRegistrarVenta();
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("No se pudo registrar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      





        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Close   ();
        }

        private void frmPrimerUsuario_Load(object sender, EventArgs e)
        {

        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir tecla de retroceso (Backspace)
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            // Validar si es letra, número, punto, guion bajo o arroba
            if (!(char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == '_' || e.KeyChar == '@'))
            {
                e.Handled = true; // Bloquea el caracter
                MessageBox.Show("Solo se permiten letras, números, puntos, guion bajo (_) y arroba (@).",
                                "Entrada inválida",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }


        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir tecla de retroceso (Backspace)
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            // Validar si es letra o número
            if (!(char.IsLetterOrDigit(e.KeyChar)))
            {
                e.Handled = true; // Bloquea el caracter
                MessageBox.Show("Solo se permiten letras y números.",
                                "Entrada inválida",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

    }
}
