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
    public partial class FrmPrincipal : Form
    {
        public Usuario usuarioActual { get; set; }

        public FrmPrincipal()
        {
            InitializeComponent();
        }


        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = usuarioActual.UserName;

            Rol oRol = TrabajarRoles.TraerRol(usuarioActual.RolCodigo);
            switch (oRol.RolDescripcion)
            {
                case "Administrador":
                    mnuClientes.Enabled=false;
                    mnuDestinos.Enabled = true;
                    mnuPeriodos.Enabled = true;
                    mnuUsuarios.Enabled = true;
                    mnuPrestamos.Enabled = false;
                    break;
                case "Operador":
                    mnuClientes.Enabled = true;
                    mnuDestinos.Enabled = false;
                    mnuPeriodos.Enabled = false;
                    mnuUsuarios.Enabled = false;
                    mnuPrestamos.Enabled = true;

                    break;
                case "Auditor":
                    mnuClientes.Enabled = true;
                    mnuDestinos.Enabled = true;
                    mnuPeriodos.Enabled = true;
                    mnuUsuarios.Enabled = true;
                    mnuPrestamos.Enabled = true;
                    break;
                default:
                    break;
            }
        }

        private void mnuUsuarios_Click(object sender, EventArgs e)
        {
            FrmUsuarios oFrmUsuarios = new FrmUsuarios();
            oFrmUsuarios.Show();
        }
      
        private void mnuClientes_Click(object sender, EventArgs e)
        {
            FrmClientes oFrmClientes = new FrmClientes();
            oFrmClientes.Show();
        }

        private void mnuDestinos_Click(object sender, EventArgs e)
        {
            FrmTablaDestinos frmTablaDestinos = new FrmTablaDestinos();
            frmTablaDestinos.Show();

        }

        private void mnuNuevoPrestamo_Click(object sender, EventArgs e)
        {
            FrmPrestamoNuevo oFrmPrestamos = new FrmPrestamoNuevo();
            oFrmPrestamos.Show();
        }        

        private void mnuRegistroPago_Click(object sender, EventArgs e)
        {
            FrmPagoRealizadosPorCliente oFrmPagos = new FrmPagoRealizadosPorCliente();
            oFrmPagos.Show();
        }

        private void mnuNuevoPago_Click(object sender, EventArgs e)
        {
            FrmPagosAlta oFrmPago = new FrmPagosAlta();
            oFrmPago.Show();
        }

        private void mnuNuevoPrestamo_Click_1(object sender, EventArgs e)
        {
            FrmPrestamoNuevo oFrmPrestamos = new FrmPrestamoNuevo();
            oFrmPrestamos.Show();
        }

        
        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPrestamosConsulta oFrmPrestamosConsulta = new FrmPrestamosConsulta();
            oFrmPrestamosConsulta.Show();
        }

        private void mnuPeriodos_Click(object sender, EventArgs e)
        {
            FrmTablaPeriodos oFrmTablaPeriodos = new FrmTablaPeriodos();
            oFrmTablaPeriodos.Show();
        }

 
    }
}
