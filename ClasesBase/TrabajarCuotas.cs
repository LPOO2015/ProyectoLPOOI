using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarCuotas
    {
        public static DataTable TraerCuotas(int nroPrestamo)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "ConsultarCuotas";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@nro", nroPrestamo);

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            return dt;
            
        }
     

        public static void insertarCuota(Cuota oCuota) 
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insert into Cuota(CuoNumero,CuoVencimiento,CuoImporte,CuoEstado,PreNumero) values(@numero,@vencimiento,@importe,@estado,@prestamo)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@numero",oCuota.CuoNumero);
            cmd.Parameters.AddWithValue("@vencimiento", oCuota.CuoVencimiento);
            cmd.Parameters.AddWithValue("@importe",oCuota.CuoImporte);
            cmd.Parameters.AddWithValue("@estado",oCuota.CuoEstado);
            cmd.Parameters.AddWithValue("@prestamo",oCuota.PreNumero);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

        }
        public static void ModificarCuota(int nroCuota)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "ActualizarCuota";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@cuota", nroCuota);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

        }
        public static Boolean BuscarCuotaPendiente(int nroPrestamo)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand("consultarCuotas", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nro", nroPrestamo);

            SqlDataReader reader;
            cnn.Open();
            reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            Boolean pendiente = false;
            while (reader.Read() && pendiente==false)
            {
                if(reader["CuoEstado"].ToString() == "PENDIENTE")
                {
                    pendiente = true;
                }
            }
            cmd = null;
            cnn.Close();

            return pendiente;
        }

        public static Boolean BuscarCuotaPagada(int nroPrestamo)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand("consultarCuotas", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nro", nroPrestamo);

            SqlDataReader reader;
            cnn.Open();
            reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            Boolean pagada = false;

            while (reader.Read() && pagada == false)
            {
                if (reader["CuoEstado"].ToString() == "PAGADA")
                {
                    pagada = true;
                }
            }
            cmd = null;
            cnn.Close();

            return pagada;
        }

        public static int cantCuotasPagadas(int nroPrestamo)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand("cuotasPagadas", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nro", nroPrestamo);
            cmd.Parameters.AddWithValue("@estado", "PAGADA");

            SqlParameter param = new SqlParameter("@cant",SqlDbType.Int);
            param.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(param);

            SqlDataReader reader;
            cnn.Open();
            reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            int pagada = Convert.ToInt32(cmd.Parameters["@cant"].Value);

            return pagada;
        }

        public static int cantCuotasPendientes(int nroPrestamo)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand("cuotasPagadas", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nro", nroPrestamo);
            cmd.Parameters.AddWithValue("@estado", "PENDIENTE");

            SqlParameter param = new SqlParameter("@cant", SqlDbType.Int);
            param.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(param);

            SqlDataReader reader;
            cnn.Open();
            reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            int pagada = Convert.ToInt32(cmd.Parameters["@cant"].Value);

            return pagada;
        }

        public static String sumaCuotasPagadas(int nroPrestamo)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand("sumarCuotas", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nro", nroPrestamo);
            cmd.Parameters.AddWithValue("@estado", "PAGADA");

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

        public static String sumaCuotasPendientes(int nroPrestamo)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand("sumarCuotas", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nro", nroPrestamo);
            cmd.Parameters.AddWithValue("@estado", "PENDIENTE");

            SqlParameter param = new SqlParameter("@cant", SqlDbType.Decimal);
            param.Value = "-";
            param.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(param);

            SqlDataReader reader;
            cnn.Open();
            reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            String pendiente = Convert.ToString(cmd.Parameters["@cant"].Value);

            return pendiente;
        }
    }
}
