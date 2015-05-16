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
    public partial class FrmTablaDestinos : Form
    {
        public FrmTablaDestinos()
        {
            InitializeComponent();
        }

        private void FrmTablaDestinos_Load(object sender, EventArgs e)
        {
            grdDestinos.DataSource = TrabajarDestinos.TraerDestinos();
        }

        private void btnNuevo_Click(object sender, EventArgs e){
            FrmDestinosAlta frmDestinosAlta = new FrmDestinosAlta();
            frmDestinosAlta.CodigoDestino = -1;
            frmDestinosAlta.ShowDialog();
            grdDestinos.DataSource = TrabajarDestinos.TraerDestinos();
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            if (grdDestinos.CurrentRow != null) {
                FrmDestinosAlta frmDestinosAlta = new FrmDestinosAlta();

                frmDestinosAlta.CodigoDestino = Convert.ToInt32(grdDestinos.CurrentRow.Cells[0].Value);
                Console.Write("seleccionado: " + frmDestinosAlta.CodigoDestino);
                frmDestinosAlta.ShowDialog();
                grdDestinos.DataSource = TrabajarDestinos.TraerDestinos();
            }

            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (grdDestinos.CurrentRow != null)
            {
                DialogResult result = MessageBox.Show("Desea eliminar el Destino?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    TrabajarDestinos.deleteDestino(Convert.ToInt32(grdDestinos.CurrentRow.Cells["DesCodigo"].Value));
                    ;
                }
                grdDestinos.DataSource = TrabajarDestinos.TraerDestinos();
            }
        }

      
        
    }
}
