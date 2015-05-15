using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesBase
{
    public class Rol
    {
        private int rolCodigo;
        private string rolDescripcion;

        public Rol()
        {
        }
        public Rol(int rolcodigo,string roldescripcion)
        {
            RolCodigo = rolcodigo;
            RolDescripcion = roldescripcion;
        }
        public int RolCodigo
        {
            get { return rolCodigo; }
            set { rolCodigo = value; }
        }

        public string RolDescripcion
        {
            get { return rolDescripcion; }
            set { rolDescripcion = value; }
        }
    }
}
