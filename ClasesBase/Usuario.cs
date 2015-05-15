using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesBase
{
    public class Usuario
    {
        private string userName;
        private string password;
        private string apellido;
        private string nombre;
        private int rolCodigo;

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }


        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int RolCodigo
        {
            get { return rolCodigo; }
            set { rolCodigo = value; }
        }

        public Usuario()
        {

        }
        public Usuario(string username, string password,string apellido,string nombre,int rolcodigo)
        {
            UserName = username;
            Password = password;
            Apellido = apellido;
            Nombre = nombre;
            rolCodigo = rolcodigo;
        }


    }
}
