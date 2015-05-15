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
    }
}
