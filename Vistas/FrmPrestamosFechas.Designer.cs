namespace Vistas
{
    partial class FrmPrestamosFechas
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
            this.grdPrestamosFechas = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblanulados = new System.Windows.Forms.Label();
            this.lblcancelados = new System.Windows.Forms.Label();
            this.lblpendientes = new System.Windows.Forms.Label();
            this.lblotorgados = new System.Windows.Forms.Label();
            this.lblPAnulado = new System.Windows.Forms.Label();
            this.lblPCancelados = new System.Windows.Forms.Label();
            this.lblPPendientes = new System.Windows.Forms.Label();
            this.lblPOtorgados = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdPrestamosFechas)).BeginInit();
            this.SuspendLayout();
            // 
            // grdPrestamosFechas
            // 
            this.grdPrestamosFechas.AllowUserToAddRows = false;
            this.grdPrestamosFechas.AllowUserToDeleteRows = false;
            this.grdPrestamosFechas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPrestamosFechas.Location = new System.Drawing.Point(14, 87);
            this.grdPrestamosFechas.Name = "grdPrestamosFechas";
            this.grdPrestamosFechas.ReadOnly = true;
            this.grdPrestamosFechas.Size = new System.Drawing.Size(708, 228);
            this.grdPrestamosFechas.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 24);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(84, 17);
            this.lblTitulo.TabIndex = 20;
            this.lblTitulo.Text = "Prestamos";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(511, 48);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(114, 20);
            this.dtpFechaFin.TabIndex = 21;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(312, 48);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(114, 20);
            this.dtpFechaInicio.TabIndex = 22;
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Location = new System.Drawing.Point(241, 54);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(65, 13);
            this.lblFechaInicio.TabIndex = 23;
            this.lblFechaInicio.Text = "Fecha Inicio";
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Location = new System.Drawing.Point(451, 54);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(54, 13);
            this.lblFechaFin.TabIndex = 24;
            this.lblFechaFin.Text = "Fecha Fin";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(647, 45);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 25;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblanulados
            // 
            this.lblanulados.AutoSize = true;
            this.lblanulados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblanulados.Location = new System.Drawing.Point(670, 329);
            this.lblanulados.Name = "lblanulados";
            this.lblanulados.Size = new System.Drawing.Size(14, 13);
            this.lblanulados.TabIndex = 43;
            this.lblanulados.Text = "0";
            // 
            // lblcancelados
            // 
            this.lblcancelados.AutoSize = true;
            this.lblcancelados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcancelados.Location = new System.Drawing.Point(554, 329);
            this.lblcancelados.Name = "lblcancelados";
            this.lblcancelados.Size = new System.Drawing.Size(14, 13);
            this.lblcancelados.TabIndex = 42;
            this.lblcancelados.Text = "0";
            // 
            // lblpendientes
            // 
            this.lblpendientes.AutoSize = true;
            this.lblpendientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpendientes.Location = new System.Drawing.Point(420, 329);
            this.lblpendientes.Name = "lblpendientes";
            this.lblpendientes.Size = new System.Drawing.Size(14, 13);
            this.lblpendientes.TabIndex = 41;
            this.lblpendientes.Text = "0";
            // 
            // lblotorgados
            // 
            this.lblotorgados.AutoSize = true;
            this.lblotorgados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblotorgados.Location = new System.Drawing.Point(287, 329);
            this.lblotorgados.Name = "lblotorgados";
            this.lblotorgados.Size = new System.Drawing.Size(14, 13);
            this.lblotorgados.TabIndex = 40;
            this.lblotorgados.Text = "0";
            // 
            // lblPAnulado
            // 
            this.lblPAnulado.AutoSize = true;
            this.lblPAnulado.Location = new System.Drawing.Point(600, 329);
            this.lblPAnulado.Name = "lblPAnulado";
            this.lblPAnulado.Size = new System.Drawing.Size(64, 13);
            this.lblPAnulado.TabIndex = 39;
            this.lblPAnulado.Text = "P. Anulados";
            // 
            // lblPCancelados
            // 
            this.lblPCancelados.AutoSize = true;
            this.lblPCancelados.Location = new System.Drawing.Point(472, 329);
            this.lblPCancelados.Name = "lblPCancelados";
            this.lblPCancelados.Size = new System.Drawing.Size(76, 13);
            this.lblPCancelados.TabIndex = 38;
            this.lblPCancelados.Text = "P. Cancelados";
            // 
            // lblPPendientes
            // 
            this.lblPPendientes.AutoSize = true;
            this.lblPPendientes.Location = new System.Drawing.Point(341, 329);
            this.lblPPendientes.Name = "lblPPendientes";
            this.lblPPendientes.Size = new System.Drawing.Size(73, 13);
            this.lblPPendientes.TabIndex = 37;
            this.lblPPendientes.Text = "P. Pendientes";
            // 
            // lblPOtorgados
            // 
            this.lblPOtorgados.AutoSize = true;
            this.lblPOtorgados.Location = new System.Drawing.Point(212, 329);
            this.lblPOtorgados.Name = "lblPOtorgados";
            this.lblPOtorgados.Size = new System.Drawing.Size(69, 13);
            this.lblPOtorgados.TabIndex = 36;
            this.lblPOtorgados.Text = "P. Otorgados";
            // 
            // FrmPrestamosFechas
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
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.lblFechaFin);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.grdPrestamosFechas);
            this.Name = "FrmPrestamosFechas";
            this.Text = "Prestamos por Fechas";
            ((System.ComponentModel.ISupportInitialize)(this.grdPrestamosFechas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdPrestamosFechas;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.Button btnConsultar;
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