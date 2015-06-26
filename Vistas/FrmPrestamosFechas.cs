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
    public partial class FrmPrestamosFechas : Form
    {
        public FrmPrestamosFechas()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            DateTime fechaIni = dtpFechaInicio.Value;
            DateTime fechaFin = dtpFechaFin.Value;
            CargarGrillaPrestamos(fechaIni, fechaFin);
            ContarPrestamosFechas(fechaIni, fechaFin);

        }
        public void CargarGrillaPrestamos(DateTime fInicio,DateTime fFin)
        {
            grdPrestamosFechas.DataSource = TrabajarPrestamos.TraerPrestamos(fInicio, fFin);
        }

        public void ContarPrestamosFechas(DateTime fi,DateTime ff){

            int ot = 0;
            int pen = 0;
            int can = 0;
            int anu = 0;

            TrabajarPrestamos.ContarPrestamoFechas(fi, ff, ref ot, ref pen, ref can, ref anu);

            lblotorgados.Text = Convert.ToString(ot);
            lblpendientes.Text = Convert.ToString(pen);
            lblcancelados.Text = Convert.ToString(can);
            lblanulados.Text = Convert.ToString(anu);

        }
    }
}
