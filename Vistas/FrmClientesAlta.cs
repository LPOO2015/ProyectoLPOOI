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
    public partial class FrmClientesAlta : Form
    {
        public string dni { get; set; }
        public Boolean modifica= false;

        public FrmClientesAlta()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea Agregar el cliente", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (result == DialogResult.Yes)
            {
                Cliente oCliente = new Cliente();
                oCliente.CliApellido = txtApellido.Text;
                oCliente.CliNombre = txtNombre.Text;
                oCliente.CliDireccion = txtDireccion.Text;
                oCliente.CliDNI = txtDni.Text;
                oCliente.CliFechaNacimiento = dtpFechaNac.Value;
                oCliente.CliIngresos = Convert.ToDecimal(txtIngresos.Text);
                oCliente.CliSexo = cmbSexo.SelectedItem.ToString();
                oCliente.CliTelefono = txtTelefono.Text;

                if (modifica)
                {
                    TrabajarClientes.modificarCliente(oCliente);
                    this.Dispose();
                }
                else
                {
                    TrabajarClientes.insertarCliente(oCliente);
                    this.Dispose();
                }                
            }
        }

        private void btnAceptar_MouseHover(object sender, EventArgs e)
        {
            this.btnAceptar.ForeColor = Color.Blue;
        }

        private void btnAceptar_MouseLeave(object sender, EventArgs e)
        {
            this.btnAceptar.ForeColor = Color.Black;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSalir_MouseHover(object sender, EventArgs e)
        {
            this.btnSalir.ForeColor = Color.Blue;
        }

        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            this.btnSalir.ForeColor = Color.Black;
        }

        private void FrmClientesAlta_Load(object sender, EventArgs e)
        {
            cmbSexo.Items.Add("Masculino");
            cmbSexo.Items.Add("Femenino");
            cmbSexo.SelectedIndex = 0;

            if (dni!="")
            {                
                Cliente oCliente = TrabajarClientes.TraerCliente(dni);
                txtApellido.Text = oCliente.CliApellido;
                txtNombre.Text = oCliente.CliNombre;
                txtDireccion.Text = oCliente.CliDireccion;
                txtDni.Text = oCliente.CliDNI;                
                dtpFechaNac.Value = oCliente.CliFechaNacimiento;
                txtIngresos.Text = oCliente.CliIngresos.ToString();
                txtTelefono.Text = oCliente.CliTelefono;

                if (oCliente.CliSexo == "Masculino")
                {
                    cmbSexo.SelectedIndex = 0;
                }
                else
                {
                    cmbSexo.SelectedIndex = 1;
                }

                txtDni.Enabled = false;
                modifica = true;
            }
        }
    }
}
