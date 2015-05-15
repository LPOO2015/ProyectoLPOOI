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
    }
}
