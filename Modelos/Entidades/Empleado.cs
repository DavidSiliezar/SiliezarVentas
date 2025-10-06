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
    public class Empleado
    {

        private int empleadoID;
        private string nombre;
        private string apellidos;
        private string telefono;
        private string correo;

        public int EmpleadoID { get => empleadoID; set => empleadoID = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Correo { get => correo; set => correo = value; }

        public bool InsertarEmpleado()
        {
            try
            {
                using (SqlConnection con = Conexion.Conectar())
                {
                    if (con == null) return false;

                    string comando = "INSERT INTO Empleados (Nombre, Apellidos, Telefono, Correo) " +
                                     "VALUES (@Nombre, @Apellidos, @Telefono, @Correo);";

                    SqlCommand cmd = new SqlCommand(comando, con);
                    cmd.Parameters.AddWithValue("@Nombre", Nombre);
                    cmd.Parameters.AddWithValue("@Apellidos", Apellidos);
                    cmd.Parameters.AddWithValue("@Telefono", Telefono);
                    cmd.Parameters.AddWithValue("@Correo", string.IsNullOrEmpty(Correo) ? (object)DBNull.Value : Correo);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar empleado: " + ex.Message);
                return false;
            }
        }


        public bool EliminarEmpleado(int id)
        {
            try
            {
                using (SqlConnection conexion = Conexion.Conectar())
                {
                    if (conexion == null) return false;

                    string consultaDelete = "DELETE FROM Empleados WHERE EmpleadoID = @id";
                    SqlCommand delete = new SqlCommand(consultaDelete, conexion);
                    delete.Parameters.AddWithValue("@id", id);

                    return delete.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar empleado: " + ex.Message);
                return false;
            }
        }



        public bool ActualizarEmpleado()
        {
            try
            {
                using (SqlConnection conexion = Conexion.Conectar())
                {
                    if (conexion == null) return false;

                    string consultaUpdate = "UPDATE Empleados SET Nombre = @Nombre, Apellidos = @Apellidos, " +
                                            "Telefono = @Telefono, Correo = @Correo " +
                                            "WHERE EmpleadoID = @EmpleadoID";

                    SqlCommand actualizar = new SqlCommand(consultaUpdate, conexion);
                    actualizar.Parameters.AddWithValue("@Nombre", nombre);
                    actualizar.Parameters.AddWithValue("@Apellidos", apellidos);
                    actualizar.Parameters.AddWithValue("@Telefono", telefono);
                    actualizar.Parameters.AddWithValue("@Correo", string.IsNullOrEmpty(correo) ? (object)DBNull.Value : correo);
                    actualizar.Parameters.AddWithValue("@EmpleadoID", empleadoID);

                    int filasAfectadas = actualizar.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Empleado actualizado correctamente", "Actualizar");
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el empleado para actualizar", "Actualizar");
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar empleado: " + ex.Message);
                return false;
            }
        }




        public static DataTable LeerEmpleados()
        {
            try
            {
                using (SqlConnection conn = Conexion.Conectar())
                {
                    if (conn == null) return null;

                    string comando = "SELECT EmpleadoID, Nombre, Apellidos, Telefono, Correo FROM Empleados";
                    SqlDataAdapter ad = new SqlDataAdapter(comando, conn);

                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer empleados: " + ex.Message);
                return null;
            }
        }




        public static DataTable BuscarEmpleado(string termino)
        {
            try
            {
                using (SqlConnection conn = Conexion.Conectar())
                {
                    if (conn == null) return null;

                    string comando = "SELECT EmpleadoID, Nombre, Apellidos, Telefono, Correo " +
                                     "FROM Empleados " +
                                     "WHERE Nombre LIKE @termino OR Apellidos LIKE @termino OR Telefono LIKE @termino";

                    SqlDataAdapter ad = new SqlDataAdapter(comando, conn);
                    ad.SelectCommand.Parameters.AddWithValue("@termino", $"%{termino}%");

                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar empleados: " + ex.Message);
                return null;
            }
        }






    }
}
