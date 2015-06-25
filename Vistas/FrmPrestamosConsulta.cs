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
    public partial class FrmPrestamosConsulta : Form
    {
        public FrmPrestamosConsulta()
        {
            InitializeComponent();
        }

        public void cargarGrilla()
        {
            grdPrestamos.DataSource = TrabajarPrestamos.TraerPrestamos();
        }

        public void cargarGrilla(string cod, string nombre)
        {
            grdPrestamos.DataSource = TrabajarPrestamos.TraerPrestamos(cod,nombre);
        }

        private void FrmPrestamosConsulta_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string nombre = txtCliente.Text;
            string cod = txtCliente.Text;
            cargarGrilla(cod,nombre);
        }

        private void btnCuotas_Click(object sender, EventArgs e)
        {
            if (grdPrestamos.CurrentRow != null)
            {
                FrmPrestamosVerCuotas oFrmPrestamosVerCuotas = new FrmPrestamosVerCuotas();
                oFrmPrestamosVerCuotas.nroPrestamo = (int)grdPrestamos.CurrentRow.Cells[0].Value;
                if (grdPrestamos.CurrentRow.Cells[8].Value.ToString() == "ANULADO")
                {
                    oFrmPrestamosVerCuotas.anulado = false;
                }
                else
                {
                    oFrmPrestamosVerCuotas.anulado = true;
                }
                oFrmPrestamosVerCuotas.ShowDialog();
                cargarGrilla();
            }
            
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
