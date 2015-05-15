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

        public static void InsertarPrestamo(Prestamo oPrestamo) 
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insert into Prestamo(CliDni,DesCodigo,PerCodigo,PreFecha,PreImporte,PreCantidadCuotas,PreTasaInteres,PreEstado) values(@clidni,@destino,@periodo,@fecha,@importe,@cuotas,@interes,@estado)";
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
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
    }
}
