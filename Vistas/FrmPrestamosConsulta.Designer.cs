namespace Vistas
{
    partial class FrmPrestamosConsulta
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
            this.grdPrestamos = new System.Windows.Forms.DataGridView();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumPrestamo = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.btnCuotas = new System.Windows.Forms.Button();
            this.btnDestinos = new System.Windows.Forms.Button();
            this.btnFechas = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdPrestamos)).BeginInit();
            this.SuspendLayout();
            // 
            // grdPrestamos
            // 
            this.grdPrestamos.AllowUserToAddRows = false;
            this.grdPrestamos.AllowUserToDeleteRows = false;
            this.grdPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPrestamos.Location = new System.Drawing.Point(12, 57);
            this.grdPrestamos.Name = "grdPrestamos";
            this.grdPrestamos.ReadOnly = true;
            this.grdPrestamos.Size = new System.Drawing.Size(1025, 349);
            this.grdPrestamos.TabIndex = 0;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(866, 15);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 1;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(537, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(706, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cliente";
            // 
            // txtNumPrestamo
            // 
            this.txtNumPrestamo.Location = new System.Drawing.Point(587, 18);
            this.txtNumPrestamo.Name = "txtNumPrestamo";
            this.txtNumPrestamo.Size = new System.Drawing.Size(100, 20);
            this.txtNumPrestamo.TabIndex = 4;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(751, 18);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(100, 20);
            this.txtCliente.TabIndex = 5;
            // 
            // btnCuotas
            // 
            this.btnCuotas.Location = new System.Drawing.Point(375, 422);
            this.btnCuotas.Name = "btnCuotas";
            this.btnCuotas.Size = new System.Drawing.Size(75, 23);
            this.btnCuotas.TabIndex = 6;
            this.btnCuotas.Text = "Ver Detalle";
            this.btnCuotas.UseVisualStyleBackColor = true;
            this.btnCuotas.Click += new System.EventHandler(this.btnCuotas_Click);
            // 
            // btnDestinos
            // 
            this.btnDestinos.Location = new System.Drawing.Point(456, 422);
            this.btnDestinos.Name = "btnDestinos";
            this.btnDestinos.Size = new System.Drawing.Size(75, 23);
            this.btnDestinos.TabIndex = 7;
            this.btnDestinos.Text = "Destino";
            this.btnDestinos.UseVisualStyleBackColor = true;
            this.btnDestinos.Click += new System.EventHandler(this.btnDestinos_Click);
            // 
            // btnFechas
            // 
            this.btnFechas.Location = new System.Drawing.Point(537, 422);
            this.btnFechas.Name = "btnFechas";
            this.btnFechas.Size = new System.Drawing.Size(75, 23);
            this.btnFechas.TabIndex = 8;
            this.btnFechas.Text = "Fechas";
            this.btnFechas.UseVisualStyleBackColor = true;
            this.btnFechas.Click += new System.EventHandler(this.btnFechas_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Prestamos";
            // 
            // FrmPrestamosConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 457);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnFechas);
            this.Controls.Add(this.btnDestinos);
            this.Controls.Add(this.btnCuotas);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.txtNumPrestamo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.grdPrestamos);
            this.Name = "FrmPrestamosConsulta";
            this.Text = "Consulta de Prestamos";
            this.Load += new System.EventHandler(this.FrmPrestamosConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdPrestamos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdPrestamos;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumPrestamo;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Button btnCuotas;
        private System.Windows.Forms.Button btnDestinos;
        private System.Windows.Forms.Button btnFechas;
        private System.Windows.Forms.Label label3;
    }
}