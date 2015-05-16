using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
namespace ClasesBase
{
    public class TrabajarDestinos
    {
        public static DataTable TraerDestinos()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select DesCodigo,DesDescripcion from Destino";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            DataTable dtdestino = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dtdestino);
            return dtdestino;
        }

        public static Destino getDestino(int codigo) {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Destino WHERE DesCodigo=@codigo";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@codigo", codigo);
            cnn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            Destino unDestino = new Destino();
            while (dr.Read() == true) { 
                unDestino.DesCodigo = (int) dr[0];
                unDestino.DesDescripcion = (String)dr[1];
            }
            return unDestino;
        }

        public static void insertDestino(Destino destino){
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insert into Destino (DesCodigo, DesDescripcion) values(@cod, @desc)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@cod", destino.DesCodigo);
            cmd.Parameters.AddWithValue("@desc", destino.DesDescripcion);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void updateDestino(Destino destino) {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE Destino SET DesDescripcion=@desc WHERE DesCodigo=@cod";
            cmd.Parameters.AddWithValue("@cod", destino.DesCodigo);
            cmd.Parameters.AddWithValue("@desc", destino.DesDescripcion);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void deleteDestino(int codigo) { 
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM Destino WHERE DesCodigo=@codigo";
            cmd.Parameters.AddWithValue("@codigo",codigo);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
    }
}
