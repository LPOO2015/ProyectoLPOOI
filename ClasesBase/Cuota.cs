using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesBase
{
    public class Cuota
    {
        private int cuoCodigo;
        private int preNumero;
        private int cuoNumero;
        private DateTime cuoVencimiento;
        private decimal cuoImporte;
        private string cuoEstado;

        public int CuoCodigo
        {
            get { return cuoCodigo; }
            set { cuoCodigo = value; }
        }

        public int PreNumero
        {
            get { return preNumero; }
            set { preNumero = value; }
        }

        public int CuoNumero
        {
            get { return cuoNumero; }
            set { cuoNumero = value; }
        }

        public DateTime CuoVencimiento
        {
            get { return cuoVencimiento; }
            set { cuoVencimiento = value; }
        }

        public decimal CuoImporte
        {
            get { return cuoImporte; }
            set { cuoImporte = value; }
        }

        public string CuoEstado
        {
            get { return cuoEstado; }
            set { cuoEstado = value; }
        }

        public Cuota()
        {
        }

        public Cuota(int cuocodigo,int prenumero,int cuonumero,DateTime cuovencimiento,decimal cuoimporte,string cuoestado)
        {
            CuoCodigo = cuocodigo;
            PreNumero = prenumero;
            CuoNumero = cuonumero;
            CuoVencimiento = cuovencimiento;
            CuoImporte = cuoimporte;
            CuoEstado = cuoestado;

        }
    }
}
