using Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas.Formularios
{
    public partial class frmCambiarClave : Form
    {
        public frmCambiarClave()
        {
            InitializeComponent();
            txtCorreo.MaxLength = 100;
        }


        private void RedondearPanel(Panel panel, int radio)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, radio, radio), 180, 90);
            path.AddArc(new Rectangle(panel.Width - radio, 0, radio, radio), 270, 90);
            path.AddArc(new Rectangle(panel.Width - radio, panel.Height - radio, radio, radio), 0, 90);
            path.AddArc(new Rectangle(0, panel.Height - radio, radio, radio), 90, 90);
            path.CloseFigure();
            panel.Region = new Region(path);
        }




        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCorreo.Text) || string.IsNullOrEmpty(txtClave.Text) || string.IsNullOrEmpty(txtConfirmarClave.Text))
            {
                MessageBox.Show("Por favor, ingrese el usuario y la contraseña.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string correo = txtCorreo.Text;
            string clave = txtClave.Text;
            string claveconfirmada = txtConfirmarClave.Text;
            if (Usuario.VerificarCorreo(correo) == true)
            {
                if (clave == claveconfirmada)
                {
                    Usuario user = new Usuario();
                    user.NombreUsuario = correo;
                    user.Clave = BCrypt.Net.BCrypt.HashPassword(clave);
                    try
                    {
                        if (user.ActualizarClaveUsuario())
                        {
                            MessageBox.Show("Su contraseña ha sido actualizada con éxito, inicie sesión con ella.", "Felicidades", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            frmLogin fe = new frmLogin();
                            fe.Show();
                            this.Hide();
                        }

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Hubo un error al actualizar su contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("La contraseña es distinta: Verifique que ha escrito bien su nueva contraseña en ambos campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            else
            {
                MessageBox.Show("Por favor, verifique que su correo sea correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Close();
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

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
