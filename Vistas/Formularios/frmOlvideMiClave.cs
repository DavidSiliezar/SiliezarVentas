using Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas.Formularios
{
    public partial class frmOlvideMiClave : Form
    {

        private ServicioDeRecuperacion servicio;

        public frmOlvideMiClave()
        {
            InitializeComponent();
            servicio = new ServicioDeRecuperacion();
          
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Close();
        }

        private async void btnEnviarCorreo_Click(object sender, EventArgs e)
        {
            string correoUsuario = txtCorreo.Text.Trim();

            if (string.IsNullOrEmpty(correoUsuario))
            {
                MessageBox.Show("Por favor ingresa tu correo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!EsEmailValido(correoUsuario))
            {
                MessageBox.Show("El correo ingresado no tiene un formato válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Usamos la misma instancia para generar el token
                string resultado = servicio.RecuperarContra(correoUsuario);
                MessageBox.Show(resultado, "Recuperación de Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);

              
               
            
               

                   
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private bool EsEmailValido(string email)
        {
            try
            {
                var regex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
                return regex.IsMatch(email);
            }
            catch
            {
                return false;
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string tokenIngresado = txtToken.Text.Trim();

            if (string.IsNullOrEmpty(tokenIngresado))
            {
                MessageBox.Show("Por favor ingrese el token.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 🔹 Usamos la misma instancia para validar
                if (servicio.ValidarToken(tokenIngresado))
                {
                    MessageBox.Show("Exito!", "Bienvenid@");
                    frmCrearNuevaClave fe = new frmCrearNuevaClave();
                    fe.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("El token ingresado es incorrecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCorreo.Text = "";
                    txtToken.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmOlvideMiClave_Load(object sender, EventArgs e)
        {
            lblToken.Visible = true;
            txtToken.Visible = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
