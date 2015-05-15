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
        public FrmClientesAlta()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Cliente oCliente=new Cliente();
            oCliente.CliApellido = txtApellido.Text;
            oCliente.CliNombre = txtNombre.Text;
            oCliente.CliDireccion = txtDireccion.Text;
            oCliente.CliDNI = txtDni.Text;
            oCliente.CliFechaNacimiento = dtpFechaNac.Value;
            oCliente.CliIngresos = Convert.ToDecimal(txtIngresos.Text);
            oCliente.CliSexo = txtSexo.Text;
            oCliente.CliTelefono = txtTelefono.Text;

            MessageBox.Show("Apellido: "+oCliente.CliApellido+
                            Environment.NewLine+
                            "Nombre: "+oCliente.CliNombre+
                            Environment.NewLine+
                            "Direccion: "+oCliente.CliDireccion+
                            Environment.NewLine+
                            "Dni: "+oCliente.CliNombre+
                            Environment.NewLine+
                            "Fecha de Nacimiento: "+oCliente.CliFechaNacimiento+
                            Environment.NewLine+
                            "Ingresos: "+oCliente.CliIngresos+
                            Environment.NewLine+
                            "Sexo: "+oCliente.CliSexo+
                            Environment.NewLine+
                            "Telefono: "+oCliente.CliTelefono
                            );
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


    }
}
