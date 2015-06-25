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
    public partial class FrmPrestamoNuevo : Form
    {
        public FrmPrestamoNuevo()
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
                oPrestamo.PreEstado = "PENDIENTE";

                int nroPrestamo = TrabajarPrestamos.InsertarPrestamo2(oPrestamo);

                Cuota oCuota = new Cuota();
                oCuota.CuoImporte = (oPrestamo.PreImporte * Convert.ToDecimal(oPrestamo.PreTasaInteres) / 100) + (oPrestamo.PreImporte / oPrestamo.PreCantidadCuotas);
                oCuota.CuoEstado ="PENDIENTE";
                DateTime fechaActual = oPrestamo.PreFecha;
                oCuota.PreNumero = nroPrestamo;
                
                for (int i = 1; i <= oPrestamo.PreCantidadCuotas; i++)
                {
                    oCuota.CuoNumero = i;

                    switch (oPrestamo.PerCodigo)
                    {
                        case 1:
                            oCuota.CuoVencimiento = fechaActual.AddDays(i*7);
                            TrabajarCuotas.insertarCuota(oCuota);
                            break;
                        case 2:
                            oCuota.CuoVencimiento = fechaActual.AddMonths(i);
                            TrabajarCuotas.insertarCuota(oCuota);
                            break;
                        case 3:
                            oCuota.CuoVencimiento = fechaActual.AddYears(i);
                            TrabajarCuotas.insertarCuota(oCuota);
                            break;
                    }
                }

                MessageBox.Show("Prestamo Registrado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
        }
    }
}
