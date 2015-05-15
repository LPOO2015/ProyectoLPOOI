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
    public partial class FrmPeriodosAlta : Form
    {
        public FrmPeriodosAlta()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Periodo oPeriodo = new Periodo();
            oPeriodo.PerCodigo = Convert.ToInt32(txtCodigo.Text);
            oPeriodo.PerDescripcion = txtDescripcion.Text;
            MessageBox.Show("Codigo: "+
                            oPeriodo.PerCodigo+
                            Environment.NewLine+
                            "Descripcion: "+
                            oPeriodo.PerDescripcion
                            );

        }

        private void btnAgregar_MouseHover(object sender, EventArgs e)
        {
            this.btnAgregar.ForeColor = Color.Blue;
        }

        private void btnSalir_MouseHover(object sender, EventArgs e)
        {
            this.btnSalir.ForeColor = Color.Blue;
        }

        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            this.btnSalir.ForeColor = Color.Black;
        }

        private void btnAgregar_MouseLeave(object sender, EventArgs e)
        {
            this.btnAgregar.ForeColor = Color.Blue;
        }
    }
}
