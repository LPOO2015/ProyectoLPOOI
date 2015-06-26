using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarPeriodos
    {
        public static DataTable TraerPeriodos()
        { 
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "TraerPeriodos";
            cmd.CommandType=CommandType.StoredProcedure;
            cmd.Connection = cnn;

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
        public static void insertarPeriodo(Periodo periodo)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "InsertarPeriodo";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@cod", periodo.PerCodigo);
            cmd.Parameters.AddWithValue("@dscrpcn",periodo.PerDescripcion);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void deletePeriodo(int perCodigo)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "EliminarPeriodo";
            cmd.Parameters.AddWithValue("@perCdg", perCodigo);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        public static void actualizarPeriodo(Periodo periodo)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ActualizarPeriodo";
            cmd.Parameters.AddWithValue("@cod", periodo.PerCodigo);
            cmd.Parameters.AddWithValue("@desc",periodo.PerDescripcion);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static Periodo traerPeriodo(int codigo)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "TraerPeriodo";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@cod", codigo);
            cnn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            Periodo unPeriodo = new Periodo();
            while (dr.Read() == true)
            {
                unPeriodo.PerCodigo = (int)dr[0];
                unPeriodo.PerDescripcion = (String)dr[1];
            }
            return unPeriodo;
            
        }
    }
}
