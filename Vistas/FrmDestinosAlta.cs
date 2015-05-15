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
    public partial class FrmDestinosAlta : Form
    {
        public FrmDestinosAlta()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Destino oDestino = new Destino();
            oDestino.DesCodigo = Convert.ToInt32(txtCodigo.Text);
            oDestino.DesDescripcion = txtDescripcion.Text;
            MessageBox.Show("Codigo: " +
                            oDestino.DesCodigo +
                            Environment.NewLine +
                            "Descripcion: " +
                            oDestino.DesDescripcion
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
            this.btnAgregar.ForeColor = Color.Black;
        }
    }
}
