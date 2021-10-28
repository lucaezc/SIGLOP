namespace Siglop
{
    partial class ConsultaFlujoDeCaja
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
            this.gbInicioFlujoCaja = new System.Windows.Forms.GroupBox();
            this.dtpFechaConsulta = new System.Windows.Forms.DateTimePicker();
            this.btConsultar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblIngresos = new System.Windows.Forms.Label();
            this.dgIngresos = new System.Windows.Forms.DataGridView();
            this.IdCajaI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdDetalle1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblEgresos = new System.Windows.Forms.Label();
            this.dgEgresos = new System.Windows.Forms.DataGridView();
            this.IdCaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbInicioFlujoCaja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgIngresos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgEgresos)).BeginInit();
            this.SuspendLayout();
            // 
            // gbInicioFlujoCaja
            // 
            this.gbInicioFlujoCaja.Controls.Add(this.dtpFechaConsulta);
            this.gbInicioFlujoCaja.Controls.Add(this.btConsultar);
            this.gbInicioFlujoCaja.Location = new System.Drawing.Point(26, 9);
            this.gbInicioFlujoCaja.Name = "gbInicioFlujoCaja";
            this.gbInicioFlujoCaja.Size = new System.Drawing.Size(882, 72);
            this.gbInicioFlujoCaja.TabIndex = 39;
            this.gbInicioFlujoCaja.TabStop = false;
            // 
            // dtpFechaConsulta
            // 
            this.dtpFechaConsulta.Location = new System.Drawing.Point(20, 32);
            this.dtpFechaConsulta.Name = "dtpFechaConsulta";
            this.dtpFechaConsulta.Size = new System.Drawing.Size(216, 20);
            this.dtpFechaConsulta.TabIndex = 1;
            // 
            // btConsultar
            // 
            this.btConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConsultar.Location = new System.Drawing.Point(252, 17);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(178, 47);
            this.btConsultar.TabIndex = 0;
            this.btConsultar.Text = "Consultar";
            this.btConsultar.UseVisualStyleBackColor = true;
            this.btConsultar.Click += new System.EventHandler(this.btConsultar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(833, 416);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 41);
            this.btnVolver.TabIndex = 25;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblIngresos
            // 
            this.lblIngresos.AutoSize = true;
            this.lblIngresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresos.Location = new System.Drawing.Point(22, 264);
            this.lblIngresos.Name = "lblIngresos";
            this.lblIngresos.Size = new System.Drawing.Size(79, 20);
            this.lblIngresos.TabIndex = 24;
            this.lblIngresos.Text = "Ingresos";
            // 
            // dgIngresos
            // 
            this.dgIngresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgIngresos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCajaI,
            this.IdDetalle1,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgIngresos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgIngresos.Location = new System.Drawing.Point(28, 286);
            this.dgIngresos.Name = "dgIngresos";
            this.dgIngresos.Size = new System.Drawing.Size(880, 85);
            this.dgIngresos.TabIndex = 23;
            // 
            // IdCajaI
            // 
            this.IdCajaI.HeaderText = "IdCaja";
            this.IdCajaI.Name = "IdCajaI";
            this.IdCajaI.Visible = false;
            // 
            // IdDetalle1
            // 
            this.IdDetalle1.HeaderText = "IdDetalle";
            this.IdDetalle1.Name = "IdDetalle1";
            this.IdDetalle1.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Detalle";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 300;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Observaciones";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 300;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Monto";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // lblEgresos
            // 
            this.lblEgresos.AutoSize = true;
            this.lblEgresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEgresos.Location = new System.Drawing.Point(22, 99);
            this.lblEgresos.Name = "lblEgresos";
            this.lblEgresos.Size = new System.Drawing.Size(75, 20);
            this.lblEgresos.TabIndex = 22;
            this.lblEgresos.Text = "Egresos";
            // 
            // dgEgresos
            // 
            this.dgEgresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEgresos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCaja,
            this.IdDetalle,
            this.Cantidad,
            this.Detalle,
            this.Observaciones,
            this.Monto});
            this.dgEgresos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgEgresos.Location = new System.Drawing.Point(26, 122);
            this.dgEgresos.Name = "dgEgresos";
            this.dgEgresos.Size = new System.Drawing.Size(882, 85);
            this.dgEgresos.TabIndex = 21;
            // 
            // IdCaja
            // 
            this.IdCaja.HeaderText = "IdCaja";
            this.IdCaja.Name = "IdCaja";
            this.IdCaja.Visible = false;
            // 
            // IdDetalle
            // 
            this.IdDetalle.HeaderText = "IdDetalle";
            this.IdDetalle.Name = "IdDetalle";
            this.IdDetalle.Visible = false;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Detalle
            // 
            this.Detalle.HeaderText = "Detalle";
            this.Detalle.Name = "Detalle";
            this.Detalle.Width = 300;
            // 
            // Observaciones
            // 
            this.Observaciones.HeaderText = "Observaciones";
            this.Observaciones.Name = "Observaciones";
            this.Observaciones.Width = 300;
            // 
            // Monto
            // 
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            this.Monto.Width = 125;
            // 
            // ConsultaFlujoDeCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 472);
            this.Controls.Add(this.gbInicioFlujoCaja);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblIngresos);
            this.Controls.Add(this.dgIngresos);
            this.Controls.Add(this.lblEgresos);
            this.Controls.Add(this.dgEgresos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ConsultaFlujoDeCaja";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de flujos de caja históricos";
            this.gbInicioFlujoCaja.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgIngresos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgEgresos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInicioFlujoCaja;
        private System.Windows.Forms.DateTimePicker dtpFechaConsulta;
        private System.Windows.Forms.Button btConsultar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblIngresos;
        private System.Windows.Forms.DataGridView dgIngresos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCajaI;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDetalle1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label lblEgresos;
        private System.Windows.Forms.DataGridView dgEgresos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;

    }
}