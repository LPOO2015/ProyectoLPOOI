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
        private int CodigoPeriodo;

        public int CodigoPeriodo1
        {
            get { return CodigoPeriodo; }
            set { CodigoPeriodo = value; }
        }

        private int CodPeriodoABuscar;

        public int CodPeriodo1
        {
            get { return CodPeriodoABuscar; }
            set { CodPeriodoABuscar = value; }
        }
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

            if (CodigoPeriodo < 0)
            {
                TrabajarPeriodos.insertarPeriodo(oPeriodo);
            }
            else {
                TrabajarPeriodos.actualizarPeriodo(oPeriodo);
            }
            this.Dispose();
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

        private void FrmPeriodosAlta_Load(object sender, EventArgs e)
        {
            if (CodigoPeriodo != -1)
            {
                Periodo oPeriodo = TrabajarPeriodos.traerPeriodo(CodPeriodoABuscar);
                txtCodigo.Text = oPeriodo.PerCodigo.ToString();
                txtDescripcion.Text =oPeriodo.PerDescripcion;
                txtCodigo.Enabled = false;
            }
            else
            {
                txtCodigo.Enabled = true;
            }
        }
    }
}
