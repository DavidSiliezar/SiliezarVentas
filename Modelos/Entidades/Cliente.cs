using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modelos.Entidades
{
   public class Cliente
    {

        private int idCliente;
        private string nombreCliente;
        private string direccionCliente;
        private string telefonoCliente;

        public int IdCliente { get => idCliente; set => idCliente = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string DireccionCliente { get => direccionCliente; set => direccionCliente = value; }
        public string TelefonoCliente { get => telefonoCliente; set => telefonoCliente = value; }





        public bool InsertarCliente()
        {
            try
            {
                using (SqlConnection con = Conexion.Conectar())
                {
                    if (con == null) return false;

                    string comando = "INSERT INTO Cliente (nombreCliente, direccionCliente, telefonoCliente) " +
                                     "VALUES (@Nombre, @Direccion, @Telefono);";

                    SqlCommand cmd = new SqlCommand(comando, con);
                    cmd.Parameters.AddWithValue("@Nombre", nombreCliente);
                    cmd.Parameters.AddWithValue("@Direccion", direccionCliente);
                    cmd.Parameters.AddWithValue("@Telefono", telefonoCliente);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar cliente: " + ex.Message);
                return false;
            }
        }



        public bool EliminarCliente(int id)
        {
            try
            {
                using (SqlConnection conexion = Conexion.Conectar())
                {
                    if (conexion == null) return false;

                    string consultaDelete = "DELETE FROM Cliente WHERE idCliente = @id";
                    SqlCommand delete = new SqlCommand(consultaDelete, conexion);
                    delete.Parameters.AddWithValue("@id", id);

                    return delete.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el cliente: " + ex.Message);
                return false;
            }
        }

        public bool ActualizarCliente()
        {
            try
            {
                using (SqlConnection conexion = Conexion.Conectar())
                {
                    if (conexion == null) return false;

                    string consultaUpdate = "UPDATE Cliente SET nombreCliente = @Nombre, direccionCliente = @Direccion, " +
                                            "telefonoCliente = @Telefono WHERE idCliente = @IdCliente";

                    SqlCommand actualizar = new SqlCommand(consultaUpdate, conexion);
                    actualizar.Parameters.AddWithValue("@Nombre", nombreCliente);
                    actualizar.Parameters.AddWithValue("@Direccion", direccionCliente);
                    actualizar.Parameters.AddWithValue("@Telefono", telefonoCliente);
                    actualizar.Parameters.AddWithValue("@IdCliente", idCliente);

                    int filasAfectadas = actualizar.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Cliente actualizado correctamente", "Actualizar");
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el cliente para actualizar", "Actualizar");
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el cliente: " + ex.Message);
                return false;
            }
        }



        public static DataTable LeerClientes()
        {
            try
            {
                using (SqlConnection conn = Conexion.Conectar())
                {
                    if (conn == null) return null;

                    string comando = "SELECT idCliente, nombreCliente, direccionCliente, telefonoCliente FROM Cliente";
                    SqlDataAdapter ad = new SqlDataAdapter(comando, conn);

                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer clientes: " + ex.Message);
                return null;
            }
        }


        public static DataTable BuscarCliente(string termino)
        {
            try
            {
                using (SqlConnection conn = Conexion.Conectar())
                {
                    if (conn == null) return null;

                    string comando = "SELECT idCliente, nombreCliente, direccionCliente, telefonoCliente " +
                                     "FROM Cliente " +
                                     "WHERE nombreCliente LIKE @termino OR telefonoCliente LIKE @termino";

                    SqlDataAdapter ad = new SqlDataAdapter(comando, conn);
                    ad.SelectCommand.Parameters.AddWithValue("@termino", $"%{termino}%");

                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar clientes: " + ex.Message);
                return null;
            }
        }









    }
}
