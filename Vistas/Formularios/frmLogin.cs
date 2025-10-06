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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtClave.Text))
            {
                MessageBox.Show("Por favor, ingrese el usuario y la contraseña.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string clave = txtClave.Text;
            string nombreUsuario = txtUsuario.Text;

            Usuario usuario = new Usuario();

            if (usuario.VerificarLogin(nombreUsuario, clave))
            {
                if (Usuario.IdentificarEstado(nombreUsuario) == 1)
                {
                    MessageBox.Show("Los usuarios inactivos no puden iniciar sesión", "¡Lo sentimos!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (Usuario.IdentificarPrimerLogin(nombreUsuario) == 1)
                {
                    int id_Rol = Usuario.IdentificarRol(nombreUsuario);
                    if (id_Rol == 1)
                    {
                        frmRegistrarVenta fe = new frmRegistrarVenta();
                        fe.Show();
                        this.Hide();
                        MessageBox.Show("Inicio de sesión exitoso", "¡Bienvenido!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (id_Rol == 2)
                    {
                        frmGestionarAlmacenista fe = new frmGestionarAlmacenista();
                        fe.Show();
                        this.Hide();
                        MessageBox.Show("Inicio de sesión exitoso", "¡Bienvenido!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (id_Rol == 3)
                    {
                        frmGestionarAlmacenista fe = new frmGestionarAlmacenista();
                        fe.Show();
                        this.Hide();
                        MessageBox.Show("Inicio de sesión exitoso", "¡Bienvenido!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Lo sentimos, hubo un error al encontrar su rol", "Error");
                    }
                }
                else if (Usuario.IdentificarPrimerLogin(nombreUsuario) == 0)
                {
                    frmCambiarClave fe = new frmCambiarClave();
                    this.Hide();
                    fe.Show();

                    MessageBox.Show("Es su primer inicio de sesión, así que debe cambiar su contraseña temporal por una propia. " +
                        "\n Asegurese de elegir una contraseña que recordará", "¡Bienvenido!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo identificar su inicio de sesión", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("El usuario y/o clave no coinciden", "Datos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }




        #region "Metodo para pintar formularios"
        //Creamos un atributo
        private Form activarForm = null;

        private void abrirForm(Form formularioPintar)
        {
            if (activarForm != null)
            //Si existe un formulario abierto, se cerrará
            {
                activarForm.Close();
            }
            //Le damos todos los permisos que tiene la clase form
            activarForm = formularioPintar;
            //Convertimos a un hijo de tipo de form
            formularioPintar.TopLevel = false;
            //Quitamos los bordes
            formularioPintar.FormBorderStyle = FormBorderStyle.None;
            formularioPintar.Dock = DockStyle.Fill;

            
            formularioPintar.BringToFront();
            formularioPintar.Show();
        }
        #endregion


       
        private void btnOlvideMiClave_Click(object sender, EventArgs e)
        {
            try
            {
                frmOlvideMiClave recuperar = new frmOlvideMiClave();
                recuperar.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el formulario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
