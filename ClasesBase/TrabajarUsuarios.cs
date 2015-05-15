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
            cmd.CommandText = "select * from Usuario";
            cmd.CommandType = CommandType.Text;
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
            cmd.CommandText = "select * from Usuario where UserName like @u";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@u", "%" + u + "%");
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            return dt;
        }
        public static DataTable TraerUsuarios(string a,string n)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from Usuario where Apellido like @a and Nombre like @n";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@a", "%" + a + "%");
            cmd.Parameters.AddWithValue("@n", "%" + n + "%");

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
    }
}
