using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesBase
{
    public class Prestamo
    {
        private int preNumero;
        private string cliDNI;
        private DateTime preFecha;
        private decimal preImporte;
        private double preTasaInteres;
        private int preCantidadCuotas;
        private string preEstado; 
        private int desCodigo;
        private int perCodigo;


        public int PreNumero
        {
            get { return preNumero; }
            set { preNumero = value; }
        }

        public string CliDNI
        {
            get { return cliDNI; }
            set { cliDNI = value; }
        }

        public DateTime PreFecha
        {
            get { return preFecha; }
            set { preFecha = value; }
        }

        public decimal PreImporte
        {
            get { return preImporte; }
            set { preImporte = value; }
        }

        public double PreTasaInteres
        {
            get { return preTasaInteres; }
            set { preTasaInteres = value; }
        }

        public int PreCantidadCuotas
        {
            get { return preCantidadCuotas; }
            set { preCantidadCuotas = value; }
        }

        public string PreEstado
        {
            get { return preEstado; }
            set { preEstado = value; }
        }
        
        public int DesCodigo
        {
            get { return desCodigo; }
            set { desCodigo = value; }
        }

        public int PerCodigo
        {
            get { return perCodigo; }
            set { perCodigo = value; }
        }

        public Prestamo()
        {
        }

        public Prestamo(int prenumero,string clidni,DateTime prefecha,decimal preimporte,double pretasainteres,int precantidadcuotas,string preestado,int descodigo,int percodigo)
        {
            PreNumero = prenumero;
            CliDNI = clidni;
            PreFecha = prefecha;
            PreImporte = preimporte;
            PreTasaInteres = pretasainteres;
            PreCantidadCuotas = precantidadcuotas;
            PreEstado = preestado;
            DesCodigo = descodigo;
            PerCodigo = percodigo;
        }
    }
}
