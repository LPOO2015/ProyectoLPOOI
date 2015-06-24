using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarUsuarios
    {

        public static DataTable TraerUsuarios()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "TraerUsuariosSP2";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            return dt;
        }        
        public static DataTable TraerUsuarios(string u)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "TraerUsuariosSP1";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            SqlParameter param;
            param = new SqlParameter("@u",SqlDbType.VarChar);
            param.Direction = ParameterDirection.Input;
            param.Value = u;
            da.SelectCommand.Parameters.Add(param);

            da.Fill(dt);

            return dt;
        }
        /*
        public static DataTable TraerUsuarios(string a,string n)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "TraerUsuariosSP3";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            SqlParameter param;
            param = new SqlParameter("@a", SqlDbType.VarChar);
            param.Direction = ParameterDirection.Input;
            param.Value = a;

            SqlParameter param2;
            param2 = new SqlParameter("@n", SqlDbType.VarChar);
            param2.Direction = ParameterDirection.Input;
            param2.Value = n;

            da.SelectCommand.Parameters.Add(param);
            da.SelectCommand.Parameters.Add(param2);

            da.Fill(dt);

            return dt;
        }
         */

        public static DataTable TraerUsuariosSP1(string a, string u,string o)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "ConsultarUsuario";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@a", "%" + a + "%");
            cmd.Parameters.AddWithValue("@u", "%" + u + "%");
            cmd.Parameters.AddWithValue("@o", o);

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            
            return dt;
        }

        public static Usuario TraerUsuario(string u,string p)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from Usuario where UserName=@u and Password=@p";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@u",u);
            cmd.Parameters.AddWithValue("@p",p);
            cnn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            Usuario oUsuario = null;
            if(reader.Read() ==true)
            {
                oUsuario = new Usuario();
                oUsuario.UserName = (string)reader["UserName"];
                oUsuario.Password = (string)reader["Password"];
                oUsuario.Apellido = (string)reader["Apellido"];
                oUsuario.Nombre = (string)reader["Nombre"];
                oUsuario.RolCodigo = (int)reader["RolCodigo"];
                return oUsuario;

            }
            cnn.Close();
            return oUsuario;
        }
        public static void InsertarUsuario(Usuario oUsuario) 
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insert into Usuario(UserName,Password,Apellido,Nombre,RolCodigo) values(@usu,@pass,@ape,@nom,@rol)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@usu",oUsuario.UserName);
            cmd.Parameters.AddWithValue("@pass",oUsuario.Password);
            cmd.Parameters.AddWithValue("@ape",oUsuario.Apellido);
            cmd.Parameters.AddWithValue("@nom", oUsuario.Nombre);
            cmd.Parameters.AddWithValue("@rol", oUsuario.RolCodigo);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

        }
        public static void ActualizarUsuario(Usuario oUsuario)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "update Usuario set Apellido=@ape,Password=@pass,Nombre=@nom,RolCodigo=@rol where UserName=@usu";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@ape",oUsuario.Apellido);
            cmd.Parameters.AddWithValue("@pass",oUsuario.Password);
            cmd.Parameters.AddWithValue("@usu",oUsuario.UserName);
            cmd.Parameters.AddWithValue("@nom",oUsuario.Nombre);
            cmd.Parameters.AddWithValue("@rol",oUsuario.RolCodigo);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

        }
        public static void EliminarUsuario(string u)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "delete from Usuario where UserName = @usu";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@usu", u);
            cmd.Connection = cnn;
            
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        public static DataTable TraerRoles()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from Rol";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        public static DataTable TraerUsuariosVista2()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "TraerUsuariosVista2";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            return dt;
        }
    }
}
