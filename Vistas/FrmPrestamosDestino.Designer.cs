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
            this.grdPrestamosDestino.Size = new System.Drawing.Size(708, 263);
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
            // FrmPrestamosDestino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 362);
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
    }
}