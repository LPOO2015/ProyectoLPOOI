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
        private int codigoDestino;

        public int CodigoDestino
        {
          get { return codigoDestino; }
          set { codigoDestino = value; }
        }

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
            if (codigoDestino < 0)
            {
                TrabajarDestinos.insertDestino(oDestino);
            }
            else {
                TrabajarDestinos.updateDestino(oDestino);
            }
            
            this.Dispose();

        }

        private void FrmDestinosAlta_Load(object sender, EventArgs e)
        { 
            Console.Write("alta destino");
            if (this.codigoDestino >= 0)
            {

                Destino unDestino = TrabajarDestinos.getDestino(codigoDestino);
                txtCodigo.Enabled = false;
                txtCodigo.Text = Convert.ToString(unDestino.DesCodigo);
                txtDescripcion.Text = unDestino.DesDescripcion;

                Console.Write("cod: " + unDestino.DesCodigo + " desc: " + unDestino.DesDescripcion);
            }
            else {
                txtCodigo.Enabled = true;
            }
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
