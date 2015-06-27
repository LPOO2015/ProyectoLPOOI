using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ClasesBase;

namespace Vistas
{
    public partial class FrmPrestamosVerCuotas : Form
    {
        public int nroPrestamo { get; set; }
        public Boolean anulado { get; set; }

        public FrmPrestamosVerCuotas()
        {
            InitializeComponent();
        }

        public void cargarGrilla()
        {
            grdCuotas.DataSource = TrabajarCuotas.TraerCuotas(nroPrestamo);
            Cliente oCliente = TrabajarClientes.TraerApeNom(nroPrestamo);
            
            lblCliente.Text = oCliente.CliApellido+", "+oCliente.CliNombre;
            lblDNI.Text = oCliente.CliDNI.ToString();
            lblPrestamo.Text = nroPrestamo.ToString();

            lblCuotasPagadas.Text = TrabajarCuotas.cantCuotasPagadas(nroPrestamo).ToString();
            lblCuotasPendientes.Text = TrabajarCuotas.cantCuotasPendientes(nroPrestamo).ToString();            
            lblImportePagado.Text = TrabajarCuotas.sumaCuotasPagadas(nroPrestamo).ToString();
            lblImportePendiente.Text = TrabajarCuotas.sumaCuotasPendientes(nroPrestamo).ToString();  
        }
               
        
        private void FrmPrestamosVerCuotas_Load(object sender, EventArgs e)
        {
            cargarGrilla();
            if (anulado)
            {
                btnAnular.Enabled = !TrabajarCuotas.BuscarCuotaPagada(nroPrestamo);
            }
            else
            {
                btnAnular.Enabled = false;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            TrabajarPrestamos.AnularPrestamo(nroPrestamo);
            this.Dispose();
        }

        
    }
}
