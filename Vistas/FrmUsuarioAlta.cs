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
    public partial class FrmUsuarioAlta : Form
    {
        public FrmUsuarioAlta()
        {
        }

        private void cmbRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Usuario oUsuario = new Usuario();

            String pass = txtPass.Text;
            String rePass = txtRePass.Text;

            if (pass == rePass)
            {
                oUsuario.UserName = txtUserName.Text;
                oUsuario.Password = pass;
                oUsuario.Apellido = txtApellido.Text;
                oUsuario.Nombre = txtNombre.Text;
                oUsuario.RolCodigo = 1;
                
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden.");
            }

            
            
        }
    }
}
