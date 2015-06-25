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
            ((System.ComponentModel.ISupportInitialize)(this.grdCuotas)).BeginInit();
            this.SuspendLayout();
            // 
            // grdCuotas
            // 
            this.grdCuotas.AllowUserToAddRows = false;
            this.grdCuotas.AllowUserToDeleteRows = false;
            this.grdCuotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCuotas.Location = new System.Drawing.Point(12, 21);
            this.grdCuotas.Name = "grdCuotas";
            this.grdCuotas.ReadOnly = true;
            this.grdCuotas.Size = new System.Drawing.Size(601, 201);
            this.grdCuotas.TabIndex = 0;
            // 
            // btnAnular
            // 
            this.btnAnular.Location = new System.Drawing.Point(144, 252);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(116, 23);
            this.btnAnular.TabIndex = 1;
            this.btnAnular.Text = "Anular Prestamo";
            this.btnAnular.UseVisualStyleBackColor = true;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(411, 252);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmPrestamosVerCuotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 318);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAnular);
            this.Controls.Add(this.grdCuotas);
            this.Name = "FrmPrestamosVerCuotas";
            this.Text = "Estado de Cuotas";
            this.Load += new System.EventHandler(this.FrmPrestamosVerCuotas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdCuotas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdCuotas;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.Button button2;
    }
}