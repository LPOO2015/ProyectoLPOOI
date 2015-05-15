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
    public partial class FrmPrestamos : Form
    {
        public FrmPrestamos()
        {
            InitializeComponent();
        }
        public void cargarCboClientes()
        {
            cmbClientes.DisplayMember = "CliNombre";
            cmbClientes.ValueMember = "CliDni";
            cmbClientes.DataSource = TrabajarClientes.TraerClientes();
        }
        public void cargarCboDestinos() 
        {
            cmbDestinos.DisplayMember = "DesDescripcion";
            cmbDestinos.ValueMember = "DesCodigo";
            cmbDestinos.DataSource = TrabajarDestinos.TraerDestinos();
        }
        public void cargarCboPeriodos() 
        {
            cmbPeriodos.DisplayMember = "PerDescripcion";
            cmbPeriodos.ValueMember = "PerCodigo";
            cmbPeriodos.DataSource = TrabajarPeriodos.TraerPeriodos();
 
        }
        private void FrmPrestamos_Load(object sender, EventArgs e)
        {
            cargarCboClientes();
            cargarCboDestinos();
            cargarCboPeriodos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Desea Registrar el Prestamo","",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Prestamo oPrestamo = new Prestamo();
                oPrestamo.CliDNI = (string)cmbClientes.SelectedValue;
                oPrestamo.DesCodigo = (int)cmbDestinos.SelectedValue;
                oPrestamo.PerCodigo = (int)cmbPeriodos.SelectedValue;
                oPrestamo.PreFecha = dtpfecha.Value;
                oPrestamo.PreImporte = Convert.ToDecimal(txtImporte.Text);
                oPrestamo.PreCantidadCuotas = Convert.ToInt32(txtCantidadCuotas.Text);
                oPrestamo.PreTasaInteres = Convert.ToDouble(txtTasaInteres.Text);
                oPrestamo.PreEstado = "Iniciado";

                TrabajarPrestamos.InsertarPrestamo(oPrestamo);

                Cuota oCuota=new Cuota();
                oCuota.CuoImporte = (oPrestamo.PreImporte * Convert.ToDecimal(oPrestamo.PreTasaInteres) / 100) + (oPrestamo.PreImporte / oPrestamo.PreCantidadCuotas);
                oCuota.CuoEstado = "No Pagada";
                DateTime fechaActual=oPrestamo.PreFecha;
                
                for (int i = 0; i < oPrestamo.PreCantidadCuotas; i++)
                {
                    oCuota.CuoNumero = i;
                    fechaActual.AddMonths(i);
                    oCuota.CuoVencimiento = fechaActual;
                    TrabajarCuotas.insertarCuota(oCuota);
                }

                MessageBox.Show("Prestamo Registrado","",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Dispose();
            }
        }
    }
}
