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
    public class Venta
    {

        private int ventaID;
        private int productoID;
        private int empleadoID;
        private int? clienteID;   
        private int cantidad;
        private DateTime fecha;
        private decimal total;

        public int VentaID { get => ventaID; set => ventaID = value; }
        public int ProductoID { get => productoID; set => productoID = value; }
        public int EmpleadoID { get => empleadoID; set => empleadoID = value; }
        public int? ClienteID { get => clienteID; set => clienteID = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public decimal Total { get => total; set => total = value; }


        public static DataTable MostrarVentasDetalladas()
        {
            try
            {
                using (SqlConnection conn = Conexion.Conectar())
                {
                    if (conn == null) return null;

                    string consulta = @"
                SELECT 
                    V.VentaID,
                    P.Nombre AS Producto,
                    V.Cantidad AS CantidadProducto,
                    E.Nombre + ' ' + E.Apellidos AS Empleado,
                    C.nombreCliente AS Cliente
                FROM Ventas V
                INNER JOIN Productos P ON V.ProductoID = P.ProductoID
                INNER JOIN Empleados E ON V.EmpleadoID = E.EmpleadoID
                LEFT JOIN Cliente C ON V.ClienteID = C.idCliente";

                    SqlDataAdapter ad = new SqlDataAdapter(consulta, conn);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar ventas detalladas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }



        public bool InsertarVenta()
        {
            try
            {
                using (SqlConnection con = Conexion.Conectar())
                {
                    if (con == null) return false;

                    string comando = "INSERT INTO Ventas (ProductoID, EmpleadoID, ClienteID, Cantidad, Total) " +
                                     "VALUES (@ProductoID, @EmpleadoID, @ClienteID, @Cantidad, @Total);";

                    SqlCommand cmd = new SqlCommand(comando, con);
                    cmd.Parameters.AddWithValue("@ProductoID", productoID);
                    cmd.Parameters.AddWithValue("@EmpleadoID", empleadoID);
                    cmd.Parameters.AddWithValue("@ClienteID", clienteID.HasValue ? (object)clienteID.Value : DBNull.Value);
                    cmd.Parameters.AddWithValue("@Cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@Total", total);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar venta: " + ex.Message);
                return false;
            }
        }

        public bool InsertarSoloVenta()
        {
            try
            {
                using (SqlConnection con = Conexion.Conectar())
                {
                    if (con == null) return false;

                    string comando = "INSERT INTO Ventas (ProductoID, EmpleadoID, ClienteID, Cantidad, Total) " +
                                     "VALUES (@ProductoID, @EmpleadoID, @ClienteID, @Cantidad, @Total);";

                    SqlCommand cmd = new SqlCommand(comando, con);
                    cmd.Parameters.AddWithValue("@ProductoID", productoID);
                    cmd.Parameters.AddWithValue("@EmpleadoID", empleadoID);
                    cmd.Parameters.AddWithValue("@ClienteID", clienteID.HasValue ? (object)clienteID.Value : DBNull.Value);
                    cmd.Parameters.AddWithValue("@Cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@Total", total);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar venta: " + ex.Message);
                return false;
            }
        }




        public bool EliminarVenta(int id)
        {
            try
            {
                using (SqlConnection conexion = Conexion.Conectar())
                {
                    if (conexion == null) return false;

                    string consultaDelete = "DELETE FROM Ventas WHERE VentaID = @id";
                    SqlCommand delete = new SqlCommand(consultaDelete, conexion);
                    delete.Parameters.AddWithValue("@id", id);

                    return delete.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la venta: " + ex.Message);
                return false;
            }
        }



        public bool ActualizarVenta()
        {
            try
            {
                using (SqlConnection conexion = Conexion.Conectar())
                {
                    if (conexion == null) return false;

                    string consultaUpdate = "UPDATE Ventas SET ProductoID = @ProductoID, EmpleadoID = @EmpleadoID, " +
                                            "ClienteID = @ClienteID, Cantidad = @Cantidad, Total = @Total " +
                                            "WHERE VentaID = @VentaID";

                    SqlCommand actualizar = new SqlCommand(consultaUpdate, conexion);
                    actualizar.Parameters.AddWithValue("@ProductoID", productoID);
                    actualizar.Parameters.AddWithValue("@EmpleadoID", empleadoID);
                    actualizar.Parameters.AddWithValue("@ClienteID", clienteID.HasValue ? (object)clienteID.Value : DBNull.Value);
                    actualizar.Parameters.AddWithValue("@Cantidad", cantidad);
                    actualizar.Parameters.AddWithValue("@Total", total);
                    actualizar.Parameters.AddWithValue("@VentaID", ventaID);

                    int filasAfectadas = actualizar.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Venta actualizada correctamente", "Actualizar");
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("No se encontró la venta para actualizar", "Actualizar");
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la venta: " + ex.Message);
                return false;
            }
        }


        public static DataTable BuscarVenta(string termino)
        {
            try
            {
                using (SqlConnection conn = Conexion.Conectar())
                {
                    if (conn == null) return null;

                    string comando = "SELECT V.VentaID, P.Nombre AS Producto, E.Nombre + ' ' + E.Apellidos AS Empleado, " +
                                     "C.nombreCliente AS Cliente, V.Cantidad, V.Total, V.Fecha " +
                                     "FROM Ventas V " +
                                     "INNER JOIN Productos P ON V.ProductoID = P.ProductoID " +
                                     "INNER JOIN Empleados E ON V.EmpleadoID = E.EmpleadoID " +
                                     "LEFT JOIN Cliente C ON V.ClienteID = C.idCliente " +
                                     "WHERE P.Nombre LIKE @termino";

                    SqlDataAdapter ad = new SqlDataAdapter(comando, conn);
                    ad.SelectCommand.Parameters.AddWithValue("@termino", $"%{termino}%");

                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar ventas: " + ex.Message);
                return null;
            }
        }










    }
}
