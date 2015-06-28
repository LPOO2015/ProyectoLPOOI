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
    public partial class FrmTablaPeriodos : Form
    {
        public FrmTablaPeriodos()
        {
            InitializeComponent();
        }

        private void FrmTablaDestinos_Load(object sender, EventArgs e)
        {
            grdPeriodos.DataSource = TrabajarPeriodos.TraerPeriodos();
        }

        private void btnNuevo_Click(object sender, EventArgs e){
            FrmPeriodosAlta frmPeriodoAlta = new FrmPeriodosAlta();
            frmPeriodoAlta.CodigoPeriodo1 = -1;
            frmPeriodoAlta.ShowDialog();
            grdPeriodos.DataSource = TrabajarPeriodos.TraerPeriodos();

        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            if (grdPeriodos.CurrentRow != null) {
                FrmPeriodosAlta frmPeriodosAlta = new FrmPeriodosAlta();

                frmPeriodosAlta.CodPeriodo1 = Convert.ToInt32(grdPeriodos.CurrentRow.Cells[0].Value);
                Console.Write("seleccionado: " + frmPeriodosAlta.CodigoPeriodo1);
                frmPeriodosAlta.ShowDialog();
                grdPeriodos.DataSource = TrabajarPeriodos.TraerPeriodos();
                
            }

            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (grdPeriodos.CurrentRow != null)
            {
                DialogResult result = MessageBox.Show("Desea eliminar el Periodos?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    TrabajarPeriodos.deletePeriodo(Convert.ToInt32(grdPeriodos.CurrentRow.Cells["PerCodigo"].Value));
                    ;
                }
                grdPeriodos.DataSource = TrabajarPeriodos.TraerPeriodos();
            }
        }

      
        
    }
}
