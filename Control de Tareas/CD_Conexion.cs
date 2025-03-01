using System.Data;
using System.Data.SqlClient;

namespace Control_de_Tareas
{
    public class CD_Conexion
    {
        public SqlConnection Conexion = new SqlConnection(@"server=LAP-TIC-CPJ260\SQLEXPRESS; Database=PRUEBAS_DB; integrated security =True; TrustServerCertificate=True");

        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }

        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }

    }
}
