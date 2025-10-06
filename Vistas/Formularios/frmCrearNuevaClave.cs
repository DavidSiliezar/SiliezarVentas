using Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas.Formularios
{
    public partial class frmCrearNuevaClave : Form
    {
        public frmCrearNuevaClave()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                string correo = txtCorreo.Text.Trim();
                string clave = txtClave.Text.Trim();
                string confirmarClave = txtConfirmarClave.Text.Trim();

                // Validar que los campos no estén vacíos
                if (string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(clave) || string.IsNullOrEmpty(confirmarClave))
                {
                    MessageBox.Show("Por favor completa todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar que las contraseñas coincidan
                if (clave != confirmarClave)
                {
                    MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Crear objeto Usuario y actualizar contraseña
                Usuario user = new Usuario
                {
                    NombreUsuario = correo,
                    Clave = BCrypt.Net.BCrypt.HashPassword(clave)
                };

                if (user.ActualizarClaveUsuario())
                {
                    // Guardar en memoria para uso durante la sesión
                    Usuario.ClaveEnMemoria = user.Clave;

                    // Mensaje de éxito
                    MessageBox.Show("¡Éxito! Cambios guardados.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Abrir frmLogin y cerrar el actual
                    frmLogin login = new frmLogin();
                    login.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al actualizar la contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCrearNuevaClave_Load(object sender, EventArgs e)
        {
            txtCorreo.UseSystemPasswordChar = false;
            txtCorreo.PasswordChar = '\0';
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Close();
        }
    }
}
