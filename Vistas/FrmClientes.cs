﻿using System;
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
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }
        public void CargarGrilla()
        {
            //consulta ordanada por apellido
            grdClientes.DataSource = TrabajarClientes.TraerClientesSP();

        }
        public void CargarGrilla(string apellido,string nombre) 
        {
            grdClientes.DataSource = TrabajarClientes.TraerClientes(apellido, nombre);
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string apellido=txtApellido.Text;
            string nombre=txtNombre.Text;
            CargarGrilla(apellido,nombre);

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmClientesAlta oFrmClientesAlta = new FrmClientesAlta();
            oFrmClientesAlta.dni = "";
            oFrmClientesAlta.ShowDialog();
            CargarGrilla();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (grdClientes.CurrentRow != null)
            {
                FrmClientesAlta oFrmClientesAlta = new FrmClientesAlta();
                oFrmClientesAlta.dni = grdClientes.CurrentRow.Cells[0].Value.ToString();
                oFrmClientesAlta.ShowDialog();
                CargarGrilla();
            }
        }        

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (grdClientes.CurrentRow != null)
            {
                DialogResult result = MessageBox.Show("Desea eliminar el Cliente?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    //TrabajarClientes.deleteCliente(Convert.ToInt32(grdClientes.CurrentRow.Cells["CliDni"].Value));
                    Boolean cli;
                    cli = TrabajarClientes.verificarClientePrestamo(Convert.ToString(grdClientes.CurrentRow.Cells["CliDni"].Value));
                    if (cli == true)
                    {
                        MessageBox.Show("tiene prestamos");
                    }
                    else
                    {
                        MessageBox.Show("NO tiene prestamos");
                    }
                }
                CargarGrilla();
            }
        }
    }
}
