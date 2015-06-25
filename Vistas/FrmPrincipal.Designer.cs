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
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPagos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNuevoPago = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRegistroPago = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.mnuPrestamos,
            this.mnuPagos});
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
            this.mnuUsuarios});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // mnuClientes
            // 
            this.mnuClientes.Name = "mnuClientes";
            this.mnuClientes.Size = new System.Drawing.Size(120, 22);
            this.mnuClientes.Text = "Clientes";
            this.mnuClientes.Click += new System.EventHandler(this.mnuClientes_Click);
            // 
            // mnuPeriodos
            // 
            this.mnuPeriodos.Name = "mnuPeriodos";
            this.mnuPeriodos.Size = new System.Drawing.Size(120, 22);
            this.mnuPeriodos.Text = "Periodos";
            // 
            // mnuDestinos
            // 
            this.mnuDestinos.Name = "mnuDestinos";
            this.mnuDestinos.Size = new System.Drawing.Size(120, 22);
            this.mnuDestinos.Text = "Destinos";
            this.mnuDestinos.Click += new System.EventHandler(this.mnuDestinos_Click);
            // 
            // mnuUsuarios
            // 
            this.mnuUsuarios.Name = "mnuUsuarios";
            this.mnuUsuarios.Size = new System.Drawing.Size(120, 22);
            this.mnuUsuarios.Text = "Usuarios";
            this.mnuUsuarios.Click += new System.EventHandler(this.mnuUsuarios_Click);
            // 
            // mnuPrestamos
            // 
            this.mnuPrestamos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNuevoPrestamo,
            this.consultarToolStripMenuItem});
            this.mnuPrestamos.Name = "mnuPrestamos";
            this.mnuPrestamos.Size = new System.Drawing.Size(74, 20);
            this.mnuPrestamos.Text = "Prestamos";
            // 
            // mnuNuevoPrestamo
            // 
            this.mnuNuevoPrestamo.Name = "mnuNuevoPrestamo";
            this.mnuNuevoPrestamo.Size = new System.Drawing.Size(152, 22);
            this.mnuNuevoPrestamo.Text = "Registrar";
            this.mnuNuevoPrestamo.Click += new System.EventHandler(this.mnuNuevoPrestamo_Click_1);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.consultarToolStripMenuItem.Text = "Consultar";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // mnuPagos
            // 
            this.mnuPagos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNuevoPago,
            this.mnuRegistroPago});
            this.mnuPagos.Name = "mnuPagos";
            this.mnuPagos.Size = new System.Drawing.Size(51, 20);
            this.mnuPagos.Text = "Pagos";
            // 
            // mnuNuevoPago
            // 
            this.mnuNuevoPago.Name = "mnuNuevoPago";
            this.mnuNuevoPago.Size = new System.Drawing.Size(152, 22);
            this.mnuNuevoPago.Text = "Registrar";
            this.mnuNuevoPago.Click += new System.EventHandler(this.mnuNuevoPago_Click);
            // 
            // mnuRegistroPago
            // 
            this.mnuRegistroPago.Name = "mnuRegistroPago";
            this.mnuRegistroPago.Size = new System.Drawing.Size(152, 22);
            this.mnuRegistroPago.Text = "Consultar";
            this.mnuRegistroPago.Click += new System.EventHandler(this.mnuRegistroPago_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(65, 239);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(35, 13);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "label1";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUsuario);
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
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuPagos;
        private System.Windows.Forms.ToolStripMenuItem mnuNuevoPago;
        private System.Windows.Forms.ToolStripMenuItem mnuRegistroPago;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label label1;
    }
}