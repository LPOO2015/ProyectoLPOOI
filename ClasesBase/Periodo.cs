using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesBase
{
    public class Periodo
    {
        private int perCodigo;
        private string perDescripcion;

        public Periodo()
        {
        }
        public Periodo(int percodigo,string perdescripcion)
        {
            PerCodigo = percodigo;
            PerDescripcion = perdescripcion;
        }

        public int PerCodigo
        {
            get { return perCodigo; }
            set { perCodigo = value; }
        }


        public string PerDescripcion
        {
            get { return perDescripcion; }
            set { perDescripcion = value; }
        }
    }
}
