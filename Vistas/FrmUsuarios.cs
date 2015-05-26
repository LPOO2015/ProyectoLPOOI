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
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }
        public void CargarGrilla() 
        {
            grdUsuarios.DataSource = TrabajarUsuarios.TraerUsuarios();
        }
        public void CargarGrilla(string a,string n,string o)
        {
            grdUsuarios.DataSource = TrabajarUsuarios.TraerUsuariosSP1(a, n, o);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            string ape = txtApellido.Text;
            string nom = txtUsuario.Text;
            string ord;
            if (rdbAscendente.Checked)
            {
                ord = "ASC";
                
            }
            else
            {
                ord = "DESC";
            }

            CargarGrilla(ape, nom,ord);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(grdUsuarios.CurrentRow != null)
            {
                FrmUsuarioAltaModificacion ofrmUsuarioM = new FrmUsuarioAltaModificacion();
                ofrmUsuarioM.username = grdUsuarios.CurrentRow.Cells[0].Value.ToString();
                ofrmUsuarioM.password = grdUsuarios.CurrentRow.Cells[1].Value.ToString();
                ofrmUsuarioM.ShowDialog();
                CargarGrilla();
                
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmUsuarioAltaModificacion ofrmUsuarioA = new FrmUsuarioAltaModificacion();
            ofrmUsuarioA.username = "";
            ofrmUsuarioA.ShowDialog();
            CargarGrilla();
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(grdUsuarios.CurrentRow != null)
            {
                int rol = (int)grdUsuarios.CurrentRow.Cells[4].Value;
                if (rol == 1)
                {
                    MessageBox.Show("No se puede eliminar un Administrador", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else 
                {
                    DialogResult result= MessageBox.Show("Desea Eliminar el registro", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        string username = grdUsuarios.CurrentRow.Cells[0].Value.ToString();
                        TrabajarUsuarios.EliminarUsuario(username);
                        CargarGrilla();
                    }
                }
            }
        }
    }
}
