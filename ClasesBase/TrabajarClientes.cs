using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarClientes
    {
        public static DataTable TraerClientes()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "TraerClientes";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            return dt;
        }
        public static DataTable TraerClientesSP()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "ConsultarClientes";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
        public static DataTable TraerClientes(string apellido, string nombre)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from Cliente where CliApellido like @apellido and CliNombre like @nombre";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@apellido", "%" + apellido + "%");
            cmd.Parameters.AddWithValue("@nombre", "%" + nombre + "%");
            cmd.Connection = cnn;

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        public static DataTable TraerClientesApellidoNombre()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "ConsultarClienteAyN";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            return dt;
        }

        public static void insertarCliente(Cliente oCliente)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insert into Cliente(CliDni,CliNombre,CliApellido,CliSexo,CliFechaNacimiento,CliIngresos,CliDireccion,cliTelefono)"
            +"values(@dni,@nom,@ape,@sex,@fecnac,@ing,@dir,@tel)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@dni",oCliente.CliDNI);
            cmd.Parameters.AddWithValue("@nom",oCliente.CliNombre);
            cmd.Parameters.AddWithValue("@ape",oCliente.CliApellido);
            cmd.Parameters.AddWithValue("@sex",oCliente.CliSexo);
            cmd.Parameters.AddWithValue("@fecnac",oCliente.CliFechaNacimiento);
            cmd.Parameters.AddWithValue("@ing",oCliente.CliIngresos);
            cmd.Parameters.AddWithValue("@dir",oCliente.CliDireccion);
            cmd.Parameters.AddWithValue("@tel",oCliente.CliTelefono);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

        }
    }
}
