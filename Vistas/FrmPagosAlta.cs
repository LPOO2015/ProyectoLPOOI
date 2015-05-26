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
    public partial class FrmPagosAlta : Form
    {
        public FrmPagosAlta()
        {
            InitializeComponent();
        }

        private void FrmPagosAlta_Load(object sender, EventArgs e)
        {
            cargarCboCliente();
        }
        public void cargarCboCliente()
        {
            cmbClientes.DisplayMember = "apenom";
            cmbClientes.ValueMember = "CliDni";
            cmbClientes.DataSource = TrabajarClientes.TraerClientesApellidoNombre();
        }

        public void cargarCmbPrestamos(String dni) 
        {
            DataTable dt = new DataTable();
            dt = TrabajarPrestamos.TraerPrestamos(dni);
            if (dt.Rows.Count > 0)
            {
                cmbPrestamos.DisplayMember = "PreImporte";
                cmbPrestamos.ValueMember = "PreNumero";
                cmbPrestamos.DataSource = dt;
            }else{
                cmbPrestamos.DataSource = null;
                grdCuotas.DataSource = null;
            }

        }


        private void btnPagar_Click(object sender, EventArgs e)
        {
            if(grdCuotas.CurrentRow !=null)
            {
                decimal importe = (Decimal)grdCuotas.CurrentRow.Cells[2].Value; 
                string estado = (string)grdCuotas.CurrentRow.Cells[3].Value;
                int codigo = (int)grdCuotas.CurrentRow.Cells[4].Value;
                
                DialogResult respuesta = MessageBox.Show("Desea realizar el pago?","",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    Pago oPago = new Pago();
                    oPago.PagFecha = DateTime.Now;
                    oPago.PagImporte = importe;
                    oPago.CuoCodigo = codigo;
                    //MessageBox.Show("·¡cuota " + cuota);
                    TrabajarPagos.InsertarPago(oPago);

                    TrabajarCuotas.ModificarCuota(codigo);

                    int nro = (int)cmbPrestamos.SelectedValue;
                    grdCuotas.DataSource = TrabajarCuotas.TraerCuotas(nro);

                    MessageBox.Show("Pago Registrado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (TrabajarCuotas.BuscarCuotaPendiente(nro) == false)
                    {
                        TrabajarPrestamos.ModificarPrestamo(nro);
                        MessageBox.Show("Prestamo Cancelado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void cmbClientes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //MessageBox.Show("hola " + cmbClientes.SelectedValue);
            String dni = (String)cmbClientes.SelectedValue;
            cargarCmbPrestamos(dni);
            grdCuotas.DataSource = null;
        }

        private void cmbPrestamos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int nro = (int)cmbPrestamos.SelectedValue;
            grdCuotas.DataSource = TrabajarCuotas.TraerCuotas(nro);
            grdCuotas.Columns[4].Visible = false;
        }

        private void grdCuotas_SelectionChanged(object sender, EventArgs e)
        {
            string estado = (string)grdCuotas.CurrentRow.Cells[3].Value;
            if (estado == "PENDIENTE")
            {
                btnPagar.Enabled = true;
            }
            else
            {
                btnPagar.Enabled = false;
            }
        }


    }
}
