namespace Vistas
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPeriodos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDestinos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrestamos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNuevoPrestamo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRegistroPrestamo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPago = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNewPago = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRegPagos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuClientes,
            this.mnuPeriodos,
            this.mnuDestinos,
            this.mnuUsuarios,
            this.mnuPrestamos,
            this.mnuPago});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // mnuClientes
            // 
            this.mnuClientes.Name = "mnuClientes";
            this.mnuClientes.Size = new System.Drawing.Size(152, 22);
            this.mnuClientes.Text = "Clientes";
            this.mnuClientes.Click += new System.EventHandler(this.mnuClientes_Click);
            // 
            // mnuPeriodos
            // 
            this.mnuPeriodos.Name = "mnuPeriodos";
            this.mnuPeriodos.Size = new System.Drawing.Size(152, 22);
            this.mnuPeriodos.Text = "Periodos";
            // 
            // mnuDestinos
            // 
            this.mnuDestinos.Name = "mnuDestinos";
            this.mnuDestinos.Size = new System.Drawing.Size(152, 22);
            this.mnuDestinos.Text = "Destinos";
            this.mnuDestinos.Click += new System.EventHandler(this.mnuDestinos_Click);
            // 
            // mnuUsuarios
            // 
            this.mnuUsuarios.Name = "mnuUsuarios";
            this.mnuUsuarios.Size = new System.Drawing.Size(152, 22);
            this.mnuUsuarios.Text = "Usuarios";
            this.mnuUsuarios.Click += new System.EventHandler(this.mnuUsuarios_Click);
            // 
            // mnuPrestamos
            // 
            this.mnuPrestamos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNuevoPrestamo,
            this.mnuRegistroPrestamo});
            this.mnuPrestamos.Name = "mnuPrestamos";
            this.mnuPrestamos.Size = new System.Drawing.Size(152, 22);
            this.mnuPrestamos.Text = "Prestamos";
            // 
            // mnuNuevoPrestamo
            // 
            this.mnuNuevoPrestamo.Name = "mnuNuevoPrestamo";
            this.mnuNuevoPrestamo.Size = new System.Drawing.Size(117, 22);
            this.mnuNuevoPrestamo.Text = "Nuevo";
            this.mnuNuevoPrestamo.Click += new System.EventHandler(this.mnuNuevoPrestamo_Click);
            // 
            // mnuRegistroPrestamo
            // 
            this.mnuRegistroPrestamo.Name = "mnuRegistroPrestamo";
            this.mnuRegistroPrestamo.Size = new System.Drawing.Size(117, 22);
            this.mnuRegistroPrestamo.Text = "Registro";
            this.mnuRegistroPrestamo.Click += new System.EventHandler(this.mnuRegistroPrestamo_Click);
            // 
            // mnuPago
            // 
            this.mnuPago.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNewPago,
            this.mnuRegPagos});
            this.mnuPago.Name = "mnuPago";
            this.mnuPago.Size = new System.Drawing.Size(152, 22);
            this.mnuPago.Text = "Pagos";
            // 
            // mnuNewPago
            // 
            this.mnuNewPago.Name = "mnuNewPago";
            this.mnuNewPago.Size = new System.Drawing.Size(152, 22);
            this.mnuNewPago.Text = "Nuevo";
            this.mnuNewPago.Click += new System.EventHandler(this.mnuNewPago_Click);
            // 
            // mnuRegPagos
            // 
            this.mnuRegPagos.Name = "mnuRegPagos";
            this.mnuRegPagos.Size = new System.Drawing.Size(152, 22);
            this.mnuRegPagos.Text = "Registro";
            this.mnuRegPagos.Click += new System.EventHandler(this.mnuRegPagos_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuClientes;
        private System.Windows.Forms.ToolStripMenuItem mnuPeriodos;
        private System.Windows.Forms.ToolStripMenuItem mnuDestinos;
        private System.Windows.Forms.ToolStripMenuItem mnuUsuarios;
        private System.Windows.Forms.ToolStripMenuItem mnuPrestamos;
        private System.Windows.Forms.ToolStripMenuItem mnuNuevoPrestamo;
        private System.Windows.Forms.ToolStripMenuItem mnuRegistroPrestamo;
        private System.Windows.Forms.ToolStripMenuItem mnuPago;
        private System.Windows.Forms.ToolStripMenuItem mnuNewPago;
        private System.Windows.Forms.ToolStripMenuItem mnuRegPagos;
    }
}