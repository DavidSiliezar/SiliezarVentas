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
    public partial class frmCrearUsuario : Form
    {
        public frmCrearUsuario()
        {
            InitializeComponent();
            MostrarUsuario();
            MostrarRol();
            dgvUsuarios.ScrollBars = ScrollBars.Both;
            rbnActivo.Visible = false;
            rbnActivo.Checked = true;
            rbnInactivo.Visible = false;
            lblEstadoUsuario.Visible = false;
        }


        private void MostrarRol()
        {
            cmbRol.DataSource = null;
            cmbRol.DataSource = Rol.CargarRol();
            cmbRol.DisplayMember = "nombreRol";
            cmbRol.ValueMember = "idRol";
            cmbRol.SelectedIndex = -1;
        }


        private void MostrarUsuario()
        {
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = Usuario.CargarUsuario();
        }

        private void frmCrearUsuario_Load(object sender, EventArgs e)
        {
            MostrarUsuario();
        }

       
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                // Contar solo filas de datos reales (excluye la fila "nueva")
                int totalUsuarios = dgvUsuarios.Rows.Cast<DataGridViewRow>().Count(r => !r.IsNewRow);
                if (totalUsuarios <= 1)
                {
                    MessageBox.Show("No se puede eliminar el único usuario del sistema.", "Acción no permitida",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar selección
                if (dgvUsuarios.CurrentRow == null || dgvUsuarios.CurrentRow.IsNewRow)
                {
                    MessageBox.Show("Selecciona un usuario primero.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obtener id y nombre de forma segura
                object idObj = dgvUsuarios.CurrentRow.Cells[0].Value;
                object nombreObj = dgvUsuarios.CurrentRow.Cells[1].Value;
                if (idObj == null || !int.TryParse(idObj.ToString(), out int id))
                {
                    MessageBox.Show("No se pudo determinar el ID del usuario seleccionado.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string registroEliminar = nombreObj?.ToString() ?? "<usuario sin nombre>";

                // (Opcional) Verificar que no sea el último administrador si existe columna "Rol"
                if (dgvUsuarios.Columns.Contains("Rol"))
                {
                    var rolSeleccionado = dgvUsuarios.CurrentRow.Cells["Rol"].Value?.ToString();
                    if (!string.IsNullOrEmpty(rolSeleccionado) &&
                        rolSeleccionado.Equals("Administrador", StringComparison.OrdinalIgnoreCase))
                    {
                        int admins = dgvUsuarios.Rows.Cast<DataGridViewRow>()
                            .Count(r => !r.IsNewRow
                                && r.Cells["Rol"].Value != null
                                && r.Cells["Rol"].Value.ToString().Equals("Administrador", StringComparison.OrdinalIgnoreCase));

                        if (admins <= 1)
                        {
                            MessageBox.Show("No puedes eliminar al último administrador.", "Acción no permitida",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }

                // Confirmar eliminación
                DialogResult respuesta = MessageBox.Show($"¿Quieres eliminar este registro?\n{registroEliminar}",
                    "Eliminando un registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    Usuario usuario = new Usuario();
                    if (usuario.EliminarUsuario(id))
                    {
                        MessageBox.Show("Registro eliminado\n" + registroEliminar, "Eliminado",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        MostrarUsuario();
                        txtUsuario.Clear();
                        txtClave.Clear();
                        rbnActivo.Visible = false;
                        rbnActivo.Checked = true;
                        rbnInactivo.Visible = false;
                        lblEstadoUsuario.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el registro.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Registro no eliminado", "No seleccionado",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el usuario: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (cmbRol.SelectedIndex != -1 && !string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                Usuario usuario = new Usuario();
                usuario.NombreUsuario = txtUsuario.Text;
                usuario.Id_Rol = Convert.ToInt32(cmbRol.SelectedValue);

                if (rbnActivo.Checked == true)
                {
                    usuario.EstadoUsuario = false;
                }
                else
                {
                    usuario.EstadoUsuario = true;
                }
                if (dgvUsuarios.CurrentRow == null)
                {
                    MessageBox.Show("Asegúrese de seleccionar un registro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    usuario.IdUsuario = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells[0].Value.ToString());
                }

                string registroEditar = dgvUsuarios.CurrentRow.Cells[1].Value?.ToString();
                DialogResult respuesta = MessageBox.Show("¿Quieres editar este registro?\n" + registroEditar,
                                                          "Editar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    if (usuario.ActualizarUsuario() == true)
                    {
                        MostrarUsuario();
                        txtUsuario.Clear();
                        txtClave.Clear();
                        
                    }
                    else
                    {
                        MessageBox.Show("No se pudo editar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    return;
                }

            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario.MostrarUsuarioBuscar(dgvUsuarios, txtBuscar.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAjustes_Click(object sender, EventArgs e)
        {

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
            txtClave.Text = "";
            txtBuscar.Text = "";
            cmbRol.SelectedIndex = -1;
            lblEstadoUsuario.Visible = false;
            rbnActivo.Visible = false;
            rbnActivo.Checked = true;
            rbnInactivo.Visible = false;
            txtClave.ReadOnly = false;
        }

        private void btnAgregarUsuario_Click_1(object sender, EventArgs e)
        {
            if (cmbRol.SelectedIndex != -1 && !string.IsNullOrWhiteSpace(txtUsuario.Text) && !string.IsNullOrWhiteSpace(txtClave.Text))
            {
                Usuario user = new Usuario();
                user.NombreUsuario = txtUsuario.Text;
                user.Clave = BCrypt.Net.BCrypt.HashPassword(txtClave.Text);

                if (rbnActivo.Checked == true)
                {
                    user.EstadoUsuario = false;
                }
                else
                {
                    user.EstadoUsuario = true;
                }
                user.Id_Rol = Convert.ToInt32(cmbRol.SelectedValue);
                user.PrimerLogin = 0;

                if (user.InsertarUsuario() == true)
                {

                    MessageBox.Show("El usuario se ha agregado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarUsuario();
                    txtUsuario.Clear();
                    txtClave.Clear();

                }
            }
            else
            {
                MessageBox.Show("Por favor, asegurese de llenar todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void dgvUsuarios_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                txtUsuario.Text = dgvUsuarios.CurrentRow.Cells[1].Value.ToString();
                cmbRol.Text = dgvUsuarios.CurrentRow.Cells[2].Value.ToString();
                lblEstadoUsuario.Visible = true;
                rbnActivo.Visible = true;
                rbnInactivo.Visible = true;
                if (dgvUsuarios.CurrentRow.Cells[3].Value.ToString() == "ACTIVO")
                {
                    rbnActivo.Checked = true;
                }
                else
                {
                    rbnInactivo.Checked = true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Intenta de nuevo!" + ex, "Error");
            }

            txtClave.ReadOnly = true;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscar_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
            txtBuscar.ForeColor = Color.Black;
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Close();
        }
    }
}
