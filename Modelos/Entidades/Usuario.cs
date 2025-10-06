using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

namespace Modelos.Entidades
{
    public class Usuario
    {

        private int idUsuario;
        private string nombreUsuario;
        private string clave;
        private bool estadoUsuario;
        private int id_Rol;
        private int primerLogin;

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Clave { get => clave; set => clave = value; }
        public bool EstadoUsuario { get => estadoUsuario; set => estadoUsuario = value; }
        public int Id_Rol { get => id_Rol; set => id_Rol = value; }
        public int PrimerLogin { get => primerLogin; set => primerLogin = value; }


        public Usuario() { }

        public bool VerificarLogin(string nombreusuario, string clave)
        {
            try
            {
                string hashEnBaseDeDatos = "";
                SqlConnection con = Conexion.Conectar();
                string query = "Select clave from Usuario Where nombreUsuario = @Usuario";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Usuario", nombreusuario);

                if (cmd.ExecuteScalar() == null)
                {
                    return false;
                }
                else
                {
                    hashEnBaseDeDatos = cmd.ExecuteScalar().ToString();

                    return BCrypt.Net.BCrypt.Verify(clave, hashEnBaseDeDatos);
                }
            }
            catch (Exception)
            {
                return false;
            }
            
        }

        public static int IdentificarRol(string nombreusuario)
        {
            try
            {
                int id_Rol;
                SqlConnection con = Conexion.Conectar();
                string query = "Select id_Rol from Usuario Where nombreUsuario = @Usuario";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Usuario", nombreusuario);
                id_Rol = Convert.ToInt32(cmd.ExecuteScalar());
                return id_Rol;
            }
            catch (Exception)
            {
                return -1;
            }
            
        }

        public static DataTable CargarUsuario()
        {
            SqlConnection conexion = Conexion.Conectar();
            string consultaQuery = "select Usuario.idUsuario As [N°], Usuario.nombreUsuario As [Usuario], Rol.nombreRol As [Rol]," +
                " CASE estadoUsuario\r\nwhen 0 then 'ACTIVO'\r\nwhen 1 then 'INACTIVO'\r\nEND As [Estado]\r\nfrom Usuario" +
                "\r\ninner join\r\nRol On Usuario.id_Rol = Rol.idRol";
            SqlDataAdapter ad = new SqlDataAdapter(consultaQuery, conexion);
            DataTable dt = new DataTable();
            ad.Fill(dt);

            return dt;
        }

        public static void MostrarUsuarioBuscar(DataGridView dgv, string textoBuscar)
        {
            try
            {
                SqlConnection con = Conexion.Conectar();
                string consulta = "SELECT Usuario.idUsuario AS [N°], Usuario.nombreUsuario AS [Usuario], Rol.nombreRol AS [Rol], " +
                                  "CASE estadoUsuario WHEN 0 THEN 'ACTIVO' WHEN 1 THEN 'INACTIVO' END AS [Estado] " +
                                  "FROM Usuario " +
                                  "INNER JOIN Rol ON Usuario.id_Rol = Rol.idRol " +
                                  "WHERE Usuario.nombreUsuario LIKE @buscar";

                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, con);
                adaptador.SelectCommand.Parameters.AddWithValue("@buscar", "%" + textoBuscar + "%");

                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar los usuarios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public bool InsertarUsuario()
        {
            SqlConnection con = Conexion.Conectar();
            string comando = "insert into Usuario(nombreUsuario, clave, estadoUsuario, id_Rol, primerLogin)" + "values (@nombreUsuario, @clave, @estadoUsuario, @id_Rol, @primerLogin);";
            SqlCommand cmd = new SqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
            cmd.Parameters.AddWithValue("@clave", clave);
            cmd.Parameters.AddWithValue("@estadoUsuario", estadoUsuario);
            cmd.Parameters.AddWithValue("@id_Rol", id_Rol);
            cmd.Parameters.AddWithValue("@primerLogin", primerLogin);

            if (cmd.ExecuteNonQuery() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool EliminarUsuario(int id)
        {
            SqlConnection conexion = Conexion.Conectar();
            string colsultaDelete = "Delete from Usuario where idUsuario = @id";
            SqlCommand delete = new SqlCommand(colsultaDelete, conexion);
            delete.Parameters.AddWithValue("@id", id);
            if (delete.ExecuteNonQuery() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ActualizarUsuario()
        {
            try
            {
                SqlConnection conexion = Conexion.Conectar();
                string consultaUpdate = "Update Usuario set nombreUsuario = @nombre, estadoUsuario = @estadoUsuario, id_Rol = @id_Rol where idUsuario = @idUsuario";
                SqlCommand actualizar = new SqlCommand(consultaUpdate, conexion);
                actualizar.Parameters.AddWithValue("@nombre", nombreUsuario);
                actualizar.Parameters.AddWithValue("@estadoUsuario", estadoUsuario);
                actualizar.Parameters.AddWithValue("@id_Rol", id_Rol);
                actualizar.Parameters.AddWithValue("@idUsuario", IdUsuario);
                actualizar.ExecuteNonQuery();
                MessageBox.Show("Datos Actualizados", "Actualizar");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar los datos" + ex);
                return false;
            }
        }

        public static DataTable BuscarUsuario(string termino)
        {
            SqlConnection conn = Conexion.Conectar();
            string comando = $"select Usuario.idUsuario, Usuario.nombreUsuario As [Nombre], Rol.nombreRol As [Rol]," +
                $" Usuario.clave As [Clave],CASE estadoUsuario\r\nwhen 0 then 'ACTIVO'\r\nwhen 1 then 'INACTIVO'\r\nEND As [Estado]" +
                $"from Usuario inner join Rol on Usuario.id_Rol = Rol.idRol " +
                $"where Usuario.nombreUsuario LIKE '%{termino}%';";
            SqlDataAdapter ad = new SqlDataAdapter(comando, conn);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }


        public static string ClaveEnMemoria { get; set; }

        public bool ActualizarClaveUsuario()
        {
            try
            {
                SqlConnection conexion = Conexion.Conectar();
                string consultaUpdate = "Update Usuario set clave = @clave, primerLogin = 1 where nombreUsuario = @nombre";
                SqlCommand actualizar = new SqlCommand(consultaUpdate, conexion);
                actualizar.Parameters.AddWithValue("@nombre", nombreUsuario);
                actualizar.Parameters.AddWithValue("@clave", clave);
                actualizar.ExecuteNonQuery();
                MessageBox.Show("Datos Actualizados", "Actualizar");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar los datos" + ex);
                return false;
            }
        }

        public static int IdentificarPrimerLogin(string usuario)
        {
            try
            {
                int primerLogin;
                SqlConnection con = Conexion.Conectar();
                string query = "Select primerLogin from Usuario Where nombreUsuario = @Usuario";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Usuario", usuario);
                primerLogin = Convert.ToInt32(cmd.ExecuteScalar());
                return primerLogin;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al identificar el inicio de sesión"+ex, "Error");
                return -1;
            }
        }

        public static bool VerificarCorreo(string nombreusuario)
        {
            try
            {
                SqlConnection con = Conexion.Conectar();
                string query = "Select 1 from Usuario Where nombreUsuario = @Usuario";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Usuario", nombreusuario);

                if (cmd.ExecuteScalar() == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }

        }

        public static bool HayUsuariosRegistrados()
        {
            bool existenUsuarios = false;
            try
            {
                using (SqlConnection conn = Conexion.Conectar())
                {
                    if (conn != null)
                    {
                        string query = "SELECT COUNT(*) FROM Usuario";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        int count = (int)cmd.ExecuteScalar();
                        existenUsuarios = count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar usuarios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return existenUsuarios;
        }



        public static int IdentificarEstado(string nombreusuario)
        {
            try
            {
                SqlConnection con = Conexion.Conectar();
                string query = "Select estadoUsuario from Usuario Where nombreUsuario = @Usuario";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Usuario", nombreusuario);

                int estado = Convert.ToInt32(cmd.ExecuteScalar());
                return estado;
            }
            catch (Exception)
            {
                return -1;
            }

        }
    }

    
    }
