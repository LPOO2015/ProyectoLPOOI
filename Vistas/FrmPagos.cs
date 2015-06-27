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
    public partial class FrmPagos : Form
    {
        public FrmPagos()
        {
            InitializeComponent();
        }

        private void FrmPagos_Load(object sender, EventArgs e)
        {
            CargarComboCliente();
        }
        public void CargarComboCliente()
        {
            cmbCliente.ValueMember = "CliDni";
            cmbCliente.DisplayMember = "apenom";
            cmbCliente.DataSource = TrabajarClientes.TraerClientesApellidoNombre();
        }
        public void CargarGrillaPagos(string dni)
        {
            grdPagos.DataSource = TrabajarPagos.TraerPagosCliente(dni);
        }

        private void cmbCliente_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string dni = (string) cmbCliente.SelectedValue;
            CargarGrillaPagos(dni);

        }
    }
}
