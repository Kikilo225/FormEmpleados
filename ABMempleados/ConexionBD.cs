using System.Data;
using System.Data.SqlClient;

namespace ABMempleados
{
    public class ConexionBD
    {
        private string CadenaConexion = @"Data Source=DESKTOP-Q6GKN7O\SQLEXPRESS;Initial Catalog=DB_Fashion_World;Integrated Security=True;Trust Server Certificate=True";
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        public ConexionBD()
        {
            conexion = new SqlConnection(CadenaConexion);
        }

        private void Conectar()
        {
            conexion.Open();
            comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
        }
        public void Desconectar()
        {
            conexion.Close();
        }

        public DataTable ConsultarTabla(string nombreTabla)
        {
            DataTable tabla = new DataTable();
            this.Conectar();
            comando.CommandText = "SELECT * FROM " + nombreTabla;
            tabla.Load(comando.ExecuteReader());
            this.Desconectar();
            return tabla;
        }

        public DataTable ConsultarBD(string consultaSQL)
        {
            DataTable tabla = new DataTable();
            this.Conectar();
            comando.CommandText = consultaSQL;
            tabla.Load(comando.ExecuteReader());
            this.Desconectar();
            return tabla;
        }
    }
}
