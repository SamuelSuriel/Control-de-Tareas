using System.Data;
using System.Data.SqlClient;

namespace Control_de_Tareas
{
    public class ControldeTareas_Datos
    {
        private CD_Conexion conexion = new CD_Conexion();

        SqlDataReader leer;
        SqlCommand comando = new SqlCommand();

        public DataTable MostrarTareas(int id)
        {
            CD_Conexion conexion = new CD_Conexion();
            SqlCommand comando = new SqlCommand();
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "prcMostrarTareas";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IdTarea", id);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        public void InsertarTarea(string nombre, string descripcion, DateTime vencimiento, string estado)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "prcInsertarTarea";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@NombreTarea", nombre);
            comando.Parameters.AddWithValue("@DescripcionTarea", descripcion);
            comando.Parameters.AddWithValue("@FechaVencimiento", vencimiento);
            comando.Parameters.AddWithValue("@EstadoTarea", estado);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
            conexion.CerrarConexion();

        }

        public void EditarTarea(int id, string nombre, string descripcion, DateTime vencimiento, string estado)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "prcEditarTarea";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IdTarea", id);
            comando.Parameters.AddWithValue("@NombreTarea", nombre);
            comando.Parameters.AddWithValue("@DescripcionTarea", descripcion);
            comando.Parameters.AddWithValue("@FechaVencimiento", vencimiento);
            comando.Parameters.AddWithValue("@EstadoTarea", estado);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void EliminarTarea(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "prcEliminarTarea";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IdTarea", id);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}
