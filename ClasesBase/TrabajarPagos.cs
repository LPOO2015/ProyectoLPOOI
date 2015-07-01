using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarPagos
    {

        public static DataTable TraerPagosCliente(string dni)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "ConsultarPagosCliente";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@dni", dni);

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        public static void InsertarPago(Pago oPago)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "InsertarPago";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@fecha", oPago.PagFecha);
            cmd.Parameters.AddWithValue("@importe", oPago.PagImporte);
            cmd.Parameters.AddWithValue("@codigocuota", oPago.CuoCodigo);
 
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

        }
        public static int CantidadPagos(String dni)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "ContarPagos";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@dni", dni);
            SqlParameter param;
            param = new SqlParameter("@CantidadPagos", SqlDbType.Int);
            param.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(param);
            cnn.Open();
            cmd.ExecuteNonQuery();
            int cantidad = Convert.ToInt32(cmd.Parameters["@CantidadPagos"].Value);
            cnn.Close();
            return cantidad;
        }
        public static decimal ImporteTotal(String dni)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SumarPagos";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@dni", dni);
            SqlParameter param;
            param = new SqlParameter("@total", SqlDbType.Decimal);
            param.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(param);
            cnn.Open();
            cmd.ExecuteNonQuery();
            decimal total;
            if (cmd.Parameters["@total"].Value != DBNull.Value)
            {
                total = Convert.ToDecimal(cmd.Parameters["@total"].Value);
            }
            else
            {
                total = 0;
            }

            cnn.Close();
            return total;
        }

     public static DataTable TraerPagosRealizados(DateTime fechaInicio, DateTime fechaHasta,string  dni) {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "ConsultarPagosFechas";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@fechaIni", fechaInicio);
            cmd.Parameters.AddWithValue("@fechaFin", fechaHasta);
            cmd.Parameters.AddWithValue("@dni", dni);

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

     public static String SumarPagosRealizados(DateTime fechaInicio, DateTime fechaHasta, string dni)
     {
         SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
         SqlCommand cmd = new SqlCommand();
         cmd.CommandText = "SumarPagosFechas";
         cmd.CommandType = CommandType.StoredProcedure;
         cmd.Connection = cnn;
         cmd.Parameters.AddWithValue("@fechaIni", fechaInicio);
         cmd.Parameters.AddWithValue("@fechaFin", fechaHasta);
         cmd.Parameters.AddWithValue("@dni", dni);

         SqlParameter param;
         param = new SqlParameter("@cant", SqlDbType.Decimal);
         param.Value = "-";
         param.Direction = ParameterDirection.Output;
         cmd.Parameters.Add(param);

         SqlDataReader reader;
         cnn.Open();
         reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
         String pagada = Convert.ToString(cmd.Parameters["@cant"].Value);

         return pagada;
     }
}
}
