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
    public partial class FrmPagoRealizadosPorCliente : Form
    {
        public FrmPagoRealizadosPorCliente()
        {
            InitializeComponent();
            cargarCboCliente();

        }

       

        public void cargarCboCliente()
        {
            cmbClientesP.DisplayMember = "apenom";
            cmbClientesP.ValueMember = "CliDni";
            cmbClientesP.DataSource = TrabajarClientes.TraerClientesApellidoNombre();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            DateTime fechaIni = dtFechaInicio.Value;
            DateTime fechaHasta = dtFechaHasta.Value;
            string dni = (string)cmbClientesP.SelectedValue;
          
           
            CargarGrillaPagosRealizados(fechaIni, fechaHasta,dni);


        }
        public void CargarGrillaPagosRealizados(DateTime fInicio, DateTime fHasta,string dni)
        {
            grdPagosRealizados.DataSource = TrabajarPagos.TraerPagosRealizados(fInicio, fHasta,dni);
            lblCantidad.Text= Convert.ToString(grdPagosRealizados.RowCount);
            lblTotalPagado.Text = TrabajarPagos.SumarPagosRealizados(fInicio, fHasta, dni);



        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
