using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesBase
{
    public class Pago
    {
        private int pagCodigo;
        private int cuoCodigo;
        private DateTime pagFecha;
        private decimal pagImporte;

        public Pago()
        {
        }

        public Pago(int pagcodigo,int cuocodigo,DateTime pagfecha,decimal pagimporte)
        {
            PagCodigo = pagcodigo;
            CuoCodigo = cuocodigo;
            PagFecha = pagfecha;
            PagImporte=pagimporte;
        }
        public int PagCodigo
        {
            get { return pagCodigo; }
            set { pagCodigo = value; }
        }

        public int CuoCodigo
        {
            get { return cuoCodigo; }
            set { cuoCodigo = value; }
        }

        public DateTime PagFecha
        {
            get { return pagFecha; }
            set { pagFecha = value; }
        }

        public decimal PagImporte
        {
            get { return pagImporte; }
            set { pagImporte = value; }
        }

    }
}
