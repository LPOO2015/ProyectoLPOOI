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
    public partial class FrmPrestamosRealizados : Form
    {
        public FrmPrestamosRealizados()
        {
            InitializeComponent();
        }

        private void FrmPrestamosRealizados_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }
        public void CargarGrilla() 
        {
            dataGridView1.DataSource = TrabajarPrestamos.TraerPrestamos();
        }

        private void btnDestinos_Click(object sender, EventArgs e)
        {
            FrmPrestamosDestino oFrmPrestDes = new FrmPrestamosDestino();
            oFrmPrestDes.Show();
        }

        private void btnFechas_Click(object sender, EventArgs e)
        {
            FrmPrestamosFechas oFrmPrestFechas = new FrmPrestamosFechas();
            oFrmPrestFechas.Show();
        }
    }
}
