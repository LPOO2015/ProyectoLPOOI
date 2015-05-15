using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarRoles
    {
        public static Rol TraerRol(int rolcodigo)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from Rol where RolCodigo=@rol";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@rol", rolcodigo);
            cmd.Connection = cnn;
            cnn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            Rol oRol = null;
            if (reader.Read() == true)
            {
                oRol = new Rol();
                oRol.RolCodigo = (int)reader["RolCodigo"];
                oRol.RolDescripcion = (string)reader["RolDescripcion"];
                return oRol;
            }

            cnn.Close();
            return oRol;

        }
    }
}
