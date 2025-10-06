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
    public class Producto
    {
        private int productoID;
        private string nombreProducto;
        private string descripcionProducto;
        private decimal precioProducto;
        private int cantidadProducto;

        public int ProductoID { get => productoID; set => productoID = value; }
        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public string DescripcionProducto { get => descripcionProducto; set => descripcionProducto = value; }
        public decimal PrecioProducto { get => precioProducto; set => precioProducto = value; }
        public int CantidadProducto { get => cantidadProducto; set => cantidadProducto = value; }


        public static DataTable MostrarVentas()
        {
            try
            {
                using (SqlConnection conexion = Conexion.Conectar())
                {
                    if (conexion == null) return null;

                    string consulta = "SELECT NombreProducto, PrecioProducto, CantidadProducto FROM Productos";

                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);

                    return dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar los productos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }


        public void DataActualizado(DataGridView dgv)
        {
            try
            {
                using (SqlConnection con = Conexion.Conectar())
                {
                    if (con == null) return;

                    // Traemos el ID aunque no se muestre
                    string consulta = "SELECT ProductoID, NombreProducto, PrecioProducto, CantidadProducto FROM Productos;";
                    SqlDataAdapter da = new SqlDataAdapter(consulta, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgv.DataSource = dt;

                    // Ocultar columna ProductoID para que no se vea
                    if (dgv.Columns.Contains("ProductoID"))
                        dgv.Columns["ProductoID"].Visible = false;

                    // Ajustar columnas visibles
                    dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el DataGridView: " + ex.Message);
            }
        }

        public static DataTable MostrarVentasConID()
        {
            try
            {
                using (SqlConnection conexion = Conexion.Conectar())
                {
                    if (conexion == null) return null;

                    string consulta = "SELECT ProductoID, NombreProducto, PrecioProducto, CantidadProducto FROM Productos";
                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar los productos: " + ex.Message);
                return null;
            }
        }






        public bool InsertarProducto()
        {
            try
            {
                using (SqlConnection con = Conexion.Conectar())
                {
                    if (con == null) return false;

                    string comando = "INSERT INTO Productos (NombreProducto, DescripcionProducto, PrecioProducto, CantidadProducto) " +
                                     "VALUES (@NombreProducto, @DescripcionProducto, @PrecioProducto, @CantidadProducto);";

                    SqlCommand cmd = new SqlCommand(comando, con);
                    cmd.Parameters.AddWithValue("@NombreProducto", nombreProducto);
                    cmd.Parameters.AddWithValue("@DescripcionProducto", descripcionProducto ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@PrecioProducto", precioProducto);
                    cmd.Parameters.AddWithValue("@CantidadProducto", cantidadProducto);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar producto: " + ex.Message);
                return false;
            }
        }



        public bool EliminarProducto(int productoID)
        {
            try
            {
                using (SqlConnection con = Conexion.Conectar())
                {
                    if (con == null) return false;

                    string comando = "DELETE FROM Productos WHERE ProductoID = @ProductoID;";
                    SqlCommand cmd = new SqlCommand(comando, con);
                    cmd.Parameters.AddWithValue("@ProductoID", productoID);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar producto: " + ex.Message);
                return false;
            }
        }



        public bool ActualizarProducto()
        {
            try
            {
                using (SqlConnection con = Conexion.Conectar())
                {
                    if (con == null) return false;

                    // Consulta de actualización
                    string comando = @"UPDATE Productos
                               SET NombreProducto = @NombreProducto,
                                   DescripcionProducto = @DescripcionProducto,
                                   PrecioProducto = @PrecioProducto,
                                   CantidadProducto = @CantidadProducto
                               WHERE ProductoID = @ProductoID;";

                    SqlCommand cmd = new SqlCommand(comando, con);

                    // Parámetros
                    cmd.Parameters.AddWithValue("@NombreProducto", NombreProducto);
                    cmd.Parameters.AddWithValue("@DescripcionProducto", DescripcionProducto ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@PrecioProducto", PrecioProducto);
                    cmd.Parameters.AddWithValue("@CantidadProducto", CantidadProducto);
                    cmd.Parameters.AddWithValue("@ProductoID", ProductoID);

                    // Ejecutar y retornar si afectó filas
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        public static DataTable BuscarProducto(string termino)
        {
            try
            {
                using (SqlConnection conn = Conexion.Conectar())
                {
                    if (conn == null) return null;

                    string comando = "SELECT ProductoID, NombreProducto, DescripcionProducto, PrecioProducto, CantidadProducto " +
                                     "FROM Productos " +
                                     "WHERE NombreProducto LIKE @termino";

                    SqlDataAdapter ad = new SqlDataAdapter(comando, conn);
                    ad.SelectCommand.Parameters.AddWithValue("@termino", $"%{termino}%");

                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar productos: " + ex.Message);
                return null;
            }
        }
    }
}
