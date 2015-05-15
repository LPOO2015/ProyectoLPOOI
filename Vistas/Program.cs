using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using ClasesBase;
namespace Vistas
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FrmLogin());
            
            FrmLogin ofrmLogin = new FrmLogin();
            ofrmLogin.ShowDialog();
            
            if (ofrmLogin.DialogResult == DialogResult.OK)
            {
                FrmPrincipal oFrmPrincipal = new FrmPrincipal();
                oFrmPrincipal.usuarioActual = ofrmLogin.usuarioActual;
                Application.Run(oFrmPrincipal);
            }
            else
            {
                ofrmLogin.Dispose();
            }


        }
    }
}
