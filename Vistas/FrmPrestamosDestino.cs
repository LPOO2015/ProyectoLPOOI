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
    public partial class FrmPrestamosDestino : Form
    {
        public FrmPrestamosDestino()
        {
            InitializeComponent();
        }

        private void FrmPrestamosDestino_Load(object sender, EventArgs e)
        {
            CargarComboDestino();
        }
        public void CargarComboDestino()
        {
            cmbDestino.DisplayMember = "DesDescripcion";
            cmbDestino.ValueMember = "DesCodigo";
            cmbDestino.DataSource = TrabajarDestinos.TraerDestinos();
        }

        private void cmbDestino_SelectionChangeCommitted(object sender, EventArgs e)
        {
           int destino = (int)cmbDestino.SelectedValue;
           grdPrestamosDestino.DataSource = TrabajarPrestamos.TraerPrestamos(destino);
        }
    }
}
