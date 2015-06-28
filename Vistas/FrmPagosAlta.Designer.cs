namespace Vistas
{
    partial class FrmPagosAlta
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
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.cmbPrestamos = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblPrestamos = new System.Windows.Forms.Label();
            this.grdCuotas = new System.Windows.Forms.DataGridView();
            this.btnPagar = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdCuotas)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbClientes
            // 
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(84, 68);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(121, 21);
            this.cmbClientes.TabIndex = 0;
            this.cmbClientes.SelectionChangeCommitted += new System.EventHandler(this.cmbClientes_SelectionChangeCommitted);
            // 
            // cmbPrestamos
            // 
            this.cmbPrestamos.FormattingEnabled = true;
            this.cmbPrestamos.Location = new System.Drawing.Point(293, 68);
            this.cmbPrestamos.Name = "cmbPrestamos";
            this.cmbPrestamos.Size = new System.Drawing.Size(121, 21);
            this.cmbPrestamos.TabIndex = 1;
            this.cmbPrestamos.SelectionChangeCommitted += new System.EventHandler(this.cmbPrestamos_SelectionChangeCommitted);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(26, 71);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(42, 13);
            this.lblCliente.TabIndex = 2;
            this.lblCliente.Text = "Cliente:";
            // 
            // lblPrestamos
            // 
            this.lblPrestamos.AutoSize = true;
            this.lblPrestamos.Location = new System.Drawing.Point(228, 71);
            this.lblPrestamos.Name = "lblPrestamos";
            this.lblPrestamos.Size = new System.Drawing.Size(59, 13);
            this.lblPrestamos.TabIndex = 3;
            this.lblPrestamos.Text = "Prestamos:";
            // 
            // grdCuotas
            // 
            this.grdCuotas.AllowUserToAddRows = false;
            this.grdCuotas.AllowUserToDeleteRows = false;
            this.grdCuotas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grdCuotas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdCuotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCuotas.Location = new System.Drawing.Point(24, 113);
            this.grdCuotas.Name = "grdCuotas";
            this.grdCuotas.ReadOnly = true;
            this.grdCuotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdCuotas.Size = new System.Drawing.Size(542, 210);
            this.grdCuotas.TabIndex = 2;
            this.grdCuotas.SelectionChanged += new System.EventHandler(this.grdCuotas_SelectionChanged);
            // 
            // btnPagar
            // 
            this.btnPagar.Enabled = false;
            this.btnPagar.Location = new System.Drawing.Point(491, 68);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(75, 23);
            this.btnPagar.TabIndex = 3;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(201, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(108, 37);
            this.lblTitle.TabIndex = 37;
            this.lblTitle.Text = "Pagos";
            // 
            // FrmPagosAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 352);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.grdCuotas);
            this.Controls.Add(this.lblPrestamos);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.cmbPrestamos);
            this.Controls.Add(this.cmbClientes);
            this.Name = "FrmPagosAlta";
            this.Text = "Pago";
            this.Load += new System.EventHandler(this.FrmPagosAlta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdCuotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.ComboBox cmbPrestamos;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblPrestamos;
        private System.Windows.Forms.DataGridView grdCuotas;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Label lblTitle;
    }
}