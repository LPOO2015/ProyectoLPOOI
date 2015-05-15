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
    public partial class FrmUsuarioAltaModificacion : Form
    {
        public string username { get; set; }
        public string password { get; set; }
        public FrmUsuarioAltaModificacion()
        {
            InitializeComponent();
        }

        private void FrmUsuarioAltaModificacion_Load(object sender, EventArgs e)
        {
            cargarCboRoles();
            if (username != "" && password != "")
            {
                Usuario oUsuario = TrabajarUsuarios.TraerUsuario(username, password);
                txtUsuario.Text = oUsuario.UserName;
                txtPasword.Text = oUsuario.Password;
                txtApellido.Text = oUsuario.Apellido;
                txtNombre.Text = oUsuario.Nombre;
                cmbRoles.SelectedValue = oUsuario.RolCodigo;

                txtUsuario.Enabled = false;
            }
            else 
            {
                txtUsuario.Enabled = true;
            }
            
        }
        public void cargarCboRoles()
        {
            cmbRoles.DisplayMember = "RolDescripcion";
            cmbRoles.ValueMember = "RolCodigo";
            cmbRoles.DataSource = TrabajarUsuarios.TraerRoles();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("valor " + cmbRoles.SelectedValue);
            Usuario oUsuario = new Usuario();
            oUsuario.UserName = txtUsuario.Text;
            oUsuario.Password = txtPasword.Text;
            oUsuario.Apellido = txtApellido.Text;
            oUsuario.Nombre = txtNombre.Text;
            oUsuario.RolCodigo = (int)cmbRoles.SelectedValue;
            if (username != "")
            {
                TrabajarUsuarios.ActualizarUsuario(oUsuario);
                this.Dispose();
            }
            else
            {
                TrabajarUsuarios.InsertarUsuario(oUsuario);
                this.Dispose();

            }
        }


    }
}
