using System.Data;
using System.Data.SqlClient;

namespace Modelos.Entidades
{
    public class Rol
    {

        private int idRol;
        private string nombreRol;

        public int IdRol { get => idRol; set => idRol = value; }
        public string NombreRol { get => nombreRol; set => nombreRol = value; }

        public static DataTable CargarRol()
        {
            SqlConnection conexion = Conexion.Conectar();
            string consultaQuery = "select idRol, nombreRol from Rol;";
            SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
            DataTable virtualTable = new DataTable();
            add.Fill(virtualTable);
            return virtualTable;
        }
    }
}
