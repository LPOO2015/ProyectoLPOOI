namespace Vistas
{
    partial class FrmPrestamosDestino
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
            this.grdPrestamosDestino = new System.Windows.Forms.DataGridView();
            this.cmbDestino = new System.Windows.Forms.ComboBox();
            this.lblDestino = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblanulados = new System.Windows.Forms.Label();
            this.lblcancelados = new System.Windows.Forms.Label();
            this.lblpendientes = new System.Windows.Forms.Label();
            this.lblotorgados = new System.Windows.Forms.Label();
            this.lblPAnulado = new System.Windows.Forms.Label();
            this.lblPCancelados = new System.Windows.Forms.Label();
            this.lblPPendientes = new System.Windows.Forms.Label();
            this.lblPOtorgados = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdPrestamosDestino)).BeginInit();
            this.SuspendLayout();
            // 
            // grdPrestamosDestino
            // 
            this.grdPrestamosDestino.AllowUserToAddRows = false;
            this.grdPrestamosDestino.AllowUserToDeleteRows = false;
            this.grdPrestamosDestino.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPrestamosDestino.Location = new System.Drawing.Point(8, 78);
            this.grdPrestamosDestino.Name = "grdPrestamosDestino";
            this.grdPrestamosDestino.ReadOnly = true;
            this.grdPrestamosDestino.Size = new System.Drawing.Size(708, 228);
            this.grdPrestamosDestino.TabIndex = 0;
            // 
            // cmbDestino
            // 
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Location = new System.Drawing.Point(595, 51);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(121, 21);
            this.cmbDestino.TabIndex = 1;
            this.cmbDestino.SelectionChangeCommitted += new System.EventHandler(this.cmbDestino_SelectionChangeCommitted);
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(533, 54);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(43, 13);
            this.lblDestino.TabIndex = 2;
            this.lblDestino.Text = "Destino";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 23);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(84, 17);
            this.lblTitulo.TabIndex = 19;
            this.lblTitulo.Text = "Prestamos";
            // 
            // lblanulados
            // 
            this.lblanulados.AutoSize = true;
            this.lblanulados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblanulados.Location = new System.Drawing.Point(670, 329);
            this.lblanulados.Name = "lblanulados";
            this.lblanulados.Size = new System.Drawing.Size(28, 13);
            this.lblanulados.TabIndex = 35;
            this.lblanulados.Text = "123";
            // 
            // lblcancelados
            // 
            this.lblcancelados.AutoSize = true;
            this.lblcancelados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcancelados.Location = new System.Drawing.Point(554, 329);
            this.lblcancelados.Name = "lblcancelados";
            this.lblcancelados.Size = new System.Drawing.Size(28, 13);
            this.lblcancelados.TabIndex = 34;
            this.lblcancelados.Text = "123";
            // 
            // lblpendientes
            // 
            this.lblpendientes.AutoSize = true;
            this.lblpendientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpendientes.Location = new System.Drawing.Point(420, 329);
            this.lblpendientes.Name = "lblpendientes";
            this.lblpendientes.Size = new System.Drawing.Size(28, 13);
            this.lblpendientes.TabIndex = 33;
            this.lblpendientes.Text = "123";
            // 
            // lblotorgados
            // 
            this.lblotorgados.AutoSize = true;
            this.lblotorgados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblotorgados.Location = new System.Drawing.Point(287, 329);
            this.lblotorgados.Name = "lblotorgados";
            this.lblotorgados.Size = new System.Drawing.Size(28, 13);
            this.lblotorgados.TabIndex = 32;
            this.lblotorgados.Text = "123";
            // 
            // lblPAnulado
            // 
            this.lblPAnulado.AutoSize = true;
            this.lblPAnulado.Location = new System.Drawing.Point(600, 329);
            this.lblPAnulado.Name = "lblPAnulado";
            this.lblPAnulado.Size = new System.Drawing.Size(64, 13);
            this.lblPAnulado.TabIndex = 31;
            this.lblPAnulado.Text = "P. Anulados";
            // 
            // lblPCancelados
            // 
            this.lblPCancelados.AutoSize = true;
            this.lblPCancelados.Location = new System.Drawing.Point(472, 329);
            this.lblPCancelados.Name = "lblPCancelados";
            this.lblPCancelados.Size = new System.Drawing.Size(76, 13);
            this.lblPCancelados.TabIndex = 30;
            this.lblPCancelados.Text = "P. Cancelados";
            // 
            // lblPPendientes
            // 
            this.lblPPendientes.AutoSize = true;
            this.lblPPendientes.Location = new System.Drawing.Point(341, 329);
            this.lblPPendientes.Name = "lblPPendientes";
            this.lblPPendientes.Size = new System.Drawing.Size(73, 13);
            this.lblPPendientes.TabIndex = 29;
            this.lblPPendientes.Text = "P. Pendientes";
            // 
            // lblPOtorgados
            // 
            this.lblPOtorgados.AutoSize = true;
            this.lblPOtorgados.Location = new System.Drawing.Point(212, 329);
            this.lblPOtorgados.Name = "lblPOtorgados";
            this.lblPOtorgados.Size = new System.Drawing.Size(69, 13);
            this.lblPOtorgados.TabIndex = 28;
            this.lblPOtorgados.Text = "P. Otorgados";
            // 
            // FrmPrestamosDestino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 362);
            this.Controls.Add(this.lblanulados);
            this.Controls.Add(this.lblcancelados);
            this.Controls.Add(this.lblpendientes);
            this.Controls.Add(this.lblotorgados);
            this.Controls.Add(this.lblPAnulado);
            this.Controls.Add(this.lblPCancelados);
            this.Controls.Add(this.lblPPendientes);
            this.Controls.Add(this.lblPOtorgados);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.cmbDestino);
            this.Controls.Add(this.grdPrestamosDestino);
            this.Name = "FrmPrestamosDestino";
            this.Text = "FrmPrestamosDestino";
            this.Load += new System.EventHandler(this.FrmPrestamosDestino_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdPrestamosDestino)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdPrestamosDestino;
        private System.Windows.Forms.ComboBox cmbDestino;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblanulados;
        private System.Windows.Forms.Label lblcancelados;
        private System.Windows.Forms.Label lblpendientes;
        private System.Windows.Forms.Label lblotorgados;
        private System.Windows.Forms.Label lblPAnulado;
        private System.Windows.Forms.Label lblPCancelados;
        private System.Windows.Forms.Label lblPPendientes;
        private System.Windows.Forms.Label lblPOtorgados;
    }
}