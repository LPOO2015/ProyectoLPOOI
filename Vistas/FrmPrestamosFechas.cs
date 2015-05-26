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
        }
        public void CargarGrillaPrestamos(DateTime fInicio,DateTime fFin)
        {
            grdPrestamosFechas.DataSource = TrabajarPrestamos.TraerPrestamos(fInicio, fFin);
        }

    }
}
