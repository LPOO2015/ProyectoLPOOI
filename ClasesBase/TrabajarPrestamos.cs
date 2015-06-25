using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarPrestamos
    {
        public static DataTable TraerPrestamos()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select PreNumero,Cliente.CliNombre,Destino.DesDescripcion,PreFecha,PreImporte,Periodo.PerDescripcion,PreCantidadCuotas,PreTasaInteres " +
                "from Prestamo,Cliente,Destino,Periodo " +
                "where Prestamo.CliDni = Cliente.CliDni and " +
                "Prestamo.DesCodigo = Destino.DesCodigo and " +
                "Prestamo.PerCodigo = Periodo.PerCodigo";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        public static DataTable TraerPrestamos(string codigo,string nombre)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "ConsultarPrestamoCodigo";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@cli", nombre);
            cmd.Parameters.AddWithValue("@cod", codigo);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            return dt;
        }
        
        
        public static DataTable TraerPrestamos(string dni)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "ConsultarPrestamoCliente";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@cli", dni);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            return dt;
        }
        public static DataTable TraerPrestamos(DateTime fini,DateTime ffin)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "ConsultarPrestamosFechas";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@fechaIni", fini);
            cmd.Parameters.AddWithValue("@fechaFin", ffin);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            return dt;
        }

        public static DataTable TraerPrestamos(int codigoDestino)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "ConsultarPrestamosDestino";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            SqlParameter parameter;
            parameter = new SqlParameter("@destino", SqlDbType.Int);
            parameter.Direction = ParameterDirection.Input;
            parameter.Value = codigoDestino;
            da.SelectCommand.Parameters.Add(parameter);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static void ContarPrestamoEstado(int destino, ref int otorgados, ref int pendientes, ref int cancelados, ref int anulados) {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "ConsultarPrestamoEstado";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@Destino", destino);

            SqlParameter parameter;
            parameter = new SqlParameter("@Otorgados", SqlDbType.Int);
            parameter.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(parameter);

            parameter = new SqlParameter("@Pendientes", SqlDbType.Int);
            parameter.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(parameter);

            parameter = new SqlParameter("@Cancelados", SqlDbType.Int);
            parameter.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(parameter);

            parameter = new SqlParameter("@Anulados", SqlDbType.Int);
            parameter.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(parameter);

            cnn.Open();
            cmd.ExecuteNonQuery();
            otorgados = Convert.ToInt32(cmd.Parameters["@Otorgados"].Value);
            pendientes = Convert.ToInt32(cmd.Parameters["@Pendientes"].Value);
            cancelados = Convert.ToInt32(cmd.Parameters["@Cancelados"].Value);
            anulados = Convert.ToInt32(cmd.Parameters["@Anulados"].Value);

            cnn.Close();

        }
        public static int InsertarPrestamo2(Prestamo oPrestamo) 
        {
            
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"insert into Prestamo(CliDni,DesCodigo,PerCodigo,PreFecha,PreImporte,PreCantidadCuotas,PreTasaInteres,PreEstado) values(@clidni,@destino,@periodo,@fecha,@importe,@cuotas,@interes,@estado); SET @ultimoID = SCOPE_IDENTITY();";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@clidni",oPrestamo.CliDNI);
            cmd.Parameters.AddWithValue("@destino",oPrestamo.DesCodigo);
            cmd.Parameters.AddWithValue("@periodo",oPrestamo.PerCodigo);
            cmd.Parameters.AddWithValue("@fecha",oPrestamo.PreFecha);
            cmd.Parameters.AddWithValue("@importe",oPrestamo.PreImporte);
            cmd.Parameters.AddWithValue("@cuotas",oPrestamo.PreCantidadCuotas);
            cmd.Parameters.AddWithValue("@interes",oPrestamo.PreTasaInteres);
            cmd.Parameters.AddWithValue("@estado",oPrestamo.PreEstado);
            cmd.Parameters.Add("@ultimoID",SqlDbType.Int,0,"PreNumero");
            cmd.Parameters["@ultimoID"].Direction = ParameterDirection.Output;
            cnn.Open();
            cmd.ExecuteNonQuery();
            int nroPrestamo = Convert.ToInt32(cmd.Parameters["@ultimoID"].Value);
            cnn.Close();
            
            return nroPrestamo;
        }

        public static void ModificarPrestamo(int nroPrestamo)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "ActualizarPrestamo";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@nroPrestamo", nroPrestamo);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

        }
    }
}
