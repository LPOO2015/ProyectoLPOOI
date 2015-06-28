namespace Vistas
{
    partial class FrmPrestamosVerCuotas
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
            this.grdCuotas = new System.Windows.Forms.DataGridView();
            this.btnAnular = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblPrestamo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCuotasPendientes = new System.Windows.Forms.Label();
            this.lblCuotasPagadas = new System.Windows.Forms.Label();
            this.lblImportePagado = new System.Windows.Forms.Label();
            this.lblImportePendiente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdCuotas)).BeginInit();
            this.SuspendLayout();
            // 
            // grdCuotas
            // 
            this.grdCuotas.AllowUserToAddRows = false;
            this.grdCuotas.AllowUserToDeleteRows = false;
            this.grdCuotas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grdCuotas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdCuotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCuotas.Location = new System.Drawing.Point(12, 83);
            this.grdCuotas.Name = "grdCuotas";
            this.grdCuotas.ReadOnly = true;
            this.grdCuotas.Size = new System.Drawing.Size(601, 201);
            this.grdCuotas.TabIndex = 0;
            // 
            // btnAnular
            // 
            this.btnAnular.Location = new System.Drawing.Point(454, 21);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(116, 23);
            this.btnAnular.TabIndex = 1;
            this.btnAnular.Text = "Anular Prestamo";
            this.btnAnular.UseVisualStyleBackColor = true;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(495, 343);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "DNI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nº Prestamo";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(158, 9);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(13, 13);
            this.lblDNI.TabIndex = 6;
            this.lblDNI.Text = "0";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(158, 31);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(13, 13);
            this.lblCliente.TabIndex = 7;
            this.lblCliente.Text = "0";
            // 
            // lblPrestamo
            // 
            this.lblPrestamo.AutoSize = true;
            this.lblPrestamo.Location = new System.Drawing.Point(158, 56);
            this.lblPrestamo.Name = "lblPrestamo";
            this.lblPrestamo.Size = new System.Drawing.Size(13, 13);
            this.lblPrestamo.TabIndex = 8;
            this.lblPrestamo.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cantidad cuotas pagadas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 374);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Importe pendiente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(91, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Cantidad cuotas pendientes";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(91, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Importe pagado";
            // 
            // lblCuotasPendientes
            // 
            this.lblCuotasPendientes.AutoSize = true;
            this.lblCuotasPendientes.Location = new System.Drawing.Point(273, 323);
            this.lblCuotasPendientes.Name = "lblCuotasPendientes";
            this.lblCuotasPendientes.Size = new System.Drawing.Size(13, 13);
            this.lblCuotasPendientes.TabIndex = 13;
            this.lblCuotasPendientes.Text = "0";
            // 
            // lblCuotasPagadas
            // 
            this.lblCuotasPagadas.AutoSize = true;
            this.lblCuotasPagadas.Location = new System.Drawing.Point(273, 297);
            this.lblCuotasPagadas.Name = "lblCuotasPagadas";
            this.lblCuotasPagadas.Size = new System.Drawing.Size(13, 13);
            this.lblCuotasPagadas.TabIndex = 14;
            this.lblCuotasPagadas.Text = "0";
            // 
            // lblImportePagado
            // 
            this.lblImportePagado.AutoSize = true;
            this.lblImportePagado.Location = new System.Drawing.Point(273, 348);
            this.lblImportePagado.Name = "lblImportePagado";
            this.lblImportePagado.Size = new System.Drawing.Size(13, 13);
            this.lblImportePagado.TabIndex = 15;
            this.lblImportePagado.Text = "0";
            // 
            // lblImportePendiente
            // 
            this.lblImportePendiente.AutoSize = true;
            this.lblImportePendiente.Location = new System.Drawing.Point(273, 374);
            this.lblImportePendiente.Name = "lblImportePendiente";
            this.lblImportePendiente.Size = new System.Drawing.Size(13, 13);
            this.lblImportePendiente.TabIndex = 16;
            this.lblImportePendiente.Text = "0";
            // 
            // FrmPrestamosVerCuotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 410);
            this.Controls.Add(this.lblImportePendiente);
            this.Controls.Add(this.lblImportePagado);
            this.Controls.Add(this.lblCuotasPagadas);
            this.Controls.Add(this.lblCuotasPendientes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPrestamo);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAnular);
            this.Controls.Add(this.grdCuotas);
            this.Name = "FrmPrestamosVerCuotas";
            this.Text = "Estado de Cuotas";
            this.Load += new System.EventHandler(this.FrmPrestamosVerCuotas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdCuotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdCuotas;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblPrestamo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCuotasPendientes;
        private System.Windows.Forms.Label lblCuotasPagadas;
        private System.Windows.Forms.Label lblImportePagado;
        private System.Windows.Forms.Label lblImportePendiente;
    }
}