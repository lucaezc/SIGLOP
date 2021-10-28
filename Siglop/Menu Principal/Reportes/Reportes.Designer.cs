namespace Siglop
{
    partial class Reportes
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
            this.cbStock = new System.Windows.Forms.CheckBox();
            this.cbFlujosDeCaja = new System.Windows.Forms.CheckBox();
            this.gbStockAcciones = new System.Windows.Forms.GroupBox();
            this.cbMateriaPrima = new System.Windows.Forms.CheckBox();
            this.cbProductosTerminados = new System.Windows.Forms.CheckBox();
            this.btGenerarReporte = new System.Windows.Forms.Button();
            this.btVolver = new System.Windows.Forms.Button();
            this.gbFlujosAnual = new System.Windows.Forms.GroupBox();
            this.cmbFlujosAnual = new System.Windows.Forms.ComboBox();
            this.cbFlujosAnual = new System.Windows.Forms.CheckBox();
            this.gbFlujosMensual = new System.Windows.Forms.GroupBox();
            this.cmbFlujosMensual = new System.Windows.Forms.ComboBox();
            this.cbFlujosMensual = new System.Windows.Forms.CheckBox();
            this.gbFlujosDiario = new System.Windows.Forms.GroupBox();
            this.dtpFlujosDiario = new System.Windows.Forms.DateTimePicker();
            this.cbFlujosDiario = new System.Windows.Forms.CheckBox();
            this.gbStock = new System.Windows.Forms.GroupBox();
            this.gbFlujosDeCaja = new System.Windows.Forms.GroupBox();
            this.gbStockAcciones.SuspendLayout();
            this.gbFlujosAnual.SuspendLayout();
            this.gbFlujosMensual.SuspendLayout();
            this.gbFlujosDiario.SuspendLayout();
            this.gbStock.SuspendLayout();
            this.gbFlujosDeCaja.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbStock
            // 
            this.cbStock.AutoSize = true;
            this.cbStock.Location = new System.Drawing.Point(14, 16);
            this.cbStock.MaximumSize = new System.Drawing.Size(70, 80);
            this.cbStock.MinimumSize = new System.Drawing.Size(1, 2);
            this.cbStock.Name = "cbStock";
            this.cbStock.Size = new System.Drawing.Size(54, 17);
            this.cbStock.TabIndex = 1;
            this.cbStock.Text = "Stock";
            this.cbStock.UseVisualStyleBackColor = true;
            this.cbStock.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cbFlujosDeCaja
            // 
            this.cbFlujosDeCaja.AutoSize = true;
            this.cbFlujosDeCaja.Location = new System.Drawing.Point(14, 16);
            this.cbFlujosDeCaja.Name = "cbFlujosDeCaja";
            this.cbFlujosDeCaja.Size = new System.Drawing.Size(92, 17);
            this.cbFlujosDeCaja.TabIndex = 2;
            this.cbFlujosDeCaja.Text = "Flujos de Caja";
            this.cbFlujosDeCaja.UseVisualStyleBackColor = true;
            this.cbFlujosDeCaja.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // gbStockAcciones
            // 
            this.gbStockAcciones.Controls.Add(this.cbMateriaPrima);
            this.gbStockAcciones.Controls.Add(this.cbProductosTerminados);
            this.gbStockAcciones.ForeColor = System.Drawing.Color.Black;
            this.gbStockAcciones.Location = new System.Drawing.Point(14, 39);
            this.gbStockAcciones.Name = "gbStockAcciones";
            this.gbStockAcciones.Size = new System.Drawing.Size(312, 71);
            this.gbStockAcciones.TabIndex = 5;
            this.gbStockAcciones.TabStop = false;
            // 
            // cbMateriaPrima
            // 
            this.cbMateriaPrima.AutoSize = true;
            this.cbMateriaPrima.Location = new System.Drawing.Point(18, 45);
            this.cbMateriaPrima.Name = "cbMateriaPrima";
            this.cbMateriaPrima.Size = new System.Drawing.Size(100, 17);
            this.cbMateriaPrima.TabIndex = 2;
            this.cbMateriaPrima.Text = "Materias Primas";
            this.cbMateriaPrima.UseVisualStyleBackColor = true;
            this.cbMateriaPrima.CheckedChanged += new System.EventHandler(this.cbMateriaPrima_CheckedChanged);
            // 
            // cbProductosTerminados
            // 
            this.cbProductosTerminados.AutoSize = true;
            this.cbProductosTerminados.Location = new System.Drawing.Point(18, 22);
            this.cbProductosTerminados.Name = "cbProductosTerminados";
            this.cbProductosTerminados.Size = new System.Drawing.Size(132, 17);
            this.cbProductosTerminados.TabIndex = 1;
            this.cbProductosTerminados.Text = "Productos Terminados";
            this.cbProductosTerminados.UseVisualStyleBackColor = true;
            this.cbProductosTerminados.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // btGenerarReporte
            // 
            this.btGenerarReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGenerarReporte.Location = new System.Drawing.Point(9, 431);
            this.btGenerarReporte.Name = "btGenerarReporte";
            this.btGenerarReporte.Size = new System.Drawing.Size(234, 50);
            this.btGenerarReporte.TabIndex = 9;
            this.btGenerarReporte.Text = "Generar Reporte";
            this.btGenerarReporte.UseVisualStyleBackColor = true;
            this.btGenerarReporte.Click += new System.EventHandler(this.btGenerarReporte_Click);
            // 
            // btVolver
            // 
            this.btVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVolver.Location = new System.Drawing.Point(249, 431);
            this.btVolver.Name = "btVolver";
            this.btVolver.Size = new System.Drawing.Size(103, 50);
            this.btVolver.TabIndex = 10;
            this.btVolver.Text = "Volver";
            this.btVolver.UseVisualStyleBackColor = true;
            this.btVolver.Click += new System.EventHandler(this.button2_Click);
            // 
            // gbFlujosAnual
            // 
            this.gbFlujosAnual.Controls.Add(this.cmbFlujosAnual);
            this.gbFlujosAnual.Controls.Add(this.cbFlujosAnual);
            this.gbFlujosAnual.ForeColor = System.Drawing.Color.Black;
            this.gbFlujosAnual.Location = new System.Drawing.Point(14, 193);
            this.gbFlujosAnual.Name = "gbFlujosAnual";
            this.gbFlujosAnual.Size = new System.Drawing.Size(312, 75);
            this.gbFlujosAnual.TabIndex = 6;
            this.gbFlujosAnual.TabStop = false;
            // 
            // cmbFlujosAnual
            // 
            this.cmbFlujosAnual.FormattingEnabled = true;
            this.cmbFlujosAnual.Location = new System.Drawing.Point(99, 28);
            this.cmbFlujosAnual.Name = "cmbFlujosAnual";
            this.cmbFlujosAnual.Size = new System.Drawing.Size(196, 21);
            this.cmbFlujosAnual.TabIndex = 4;
            // 
            // cbFlujosAnual
            // 
            this.cbFlujosAnual.AutoSize = true;
            this.cbFlujosAnual.Location = new System.Drawing.Point(18, 30);
            this.cbFlujosAnual.Name = "cbFlujosAnual";
            this.cbFlujosAnual.Size = new System.Drawing.Size(53, 17);
            this.cbFlujosAnual.TabIndex = 1;
            this.cbFlujosAnual.Text = "Anual";
            this.cbFlujosAnual.UseVisualStyleBackColor = true;
            this.cbFlujosAnual.CheckedChanged += new System.EventHandler(this.cbFlujosAnual_CheckedChanged);
            // 
            // gbFlujosMensual
            // 
            this.gbFlujosMensual.Controls.Add(this.cmbFlujosMensual);
            this.gbFlujosMensual.Controls.Add(this.cbFlujosMensual);
            this.gbFlujosMensual.ForeColor = System.Drawing.Color.Black;
            this.gbFlujosMensual.Location = new System.Drawing.Point(14, 116);
            this.gbFlujosMensual.Name = "gbFlujosMensual";
            this.gbFlujosMensual.Size = new System.Drawing.Size(312, 71);
            this.gbFlujosMensual.TabIndex = 7;
            this.gbFlujosMensual.TabStop = false;
            // 
            // cmbFlujosMensual
            // 
            this.cmbFlujosMensual.FormattingEnabled = true;
            this.cmbFlujosMensual.Location = new System.Drawing.Point(99, 28);
            this.cmbFlujosMensual.Name = "cmbFlujosMensual";
            this.cmbFlujosMensual.Size = new System.Drawing.Size(196, 21);
            this.cmbFlujosMensual.TabIndex = 3;
            // 
            // cbFlujosMensual
            // 
            this.cbFlujosMensual.AutoSize = true;
            this.cbFlujosMensual.Location = new System.Drawing.Point(18, 30);
            this.cbFlujosMensual.Name = "cbFlujosMensual";
            this.cbFlujosMensual.Size = new System.Drawing.Size(66, 17);
            this.cbFlujosMensual.TabIndex = 0;
            this.cbFlujosMensual.Text = "Mensual";
            this.cbFlujosMensual.UseVisualStyleBackColor = true;
            this.cbFlujosMensual.CheckedChanged += new System.EventHandler(this.cbFlujosMensual_CheckedChanged);
            // 
            // gbFlujosDiario
            // 
            this.gbFlujosDiario.Controls.Add(this.dtpFlujosDiario);
            this.gbFlujosDiario.Controls.Add(this.cbFlujosDiario);
            this.gbFlujosDiario.ForeColor = System.Drawing.Color.Black;
            this.gbFlujosDiario.Location = new System.Drawing.Point(14, 39);
            this.gbFlujosDiario.Name = "gbFlujosDiario";
            this.gbFlujosDiario.Size = new System.Drawing.Size(312, 71);
            this.gbFlujosDiario.TabIndex = 5;
            this.gbFlujosDiario.TabStop = false;
            // 
            // dtpFlujosDiario
            // 
            this.dtpFlujosDiario.Location = new System.Drawing.Point(99, 28);
            this.dtpFlujosDiario.Name = "dtpFlujosDiario";
            this.dtpFlujosDiario.Size = new System.Drawing.Size(196, 20);
            this.dtpFlujosDiario.TabIndex = 1;
            // 
            // cbFlujosDiario
            // 
            this.cbFlujosDiario.AutoSize = true;
            this.cbFlujosDiario.Location = new System.Drawing.Point(18, 28);
            this.cbFlujosDiario.Name = "cbFlujosDiario";
            this.cbFlujosDiario.Size = new System.Drawing.Size(53, 17);
            this.cbFlujosDiario.TabIndex = 0;
            this.cbFlujosDiario.Text = "Diario";
            this.cbFlujosDiario.UseVisualStyleBackColor = true;
            this.cbFlujosDiario.CheckedChanged += new System.EventHandler(this.cbFlujosDiario_CheckedChanged);
            // 
            // gbStock
            // 
            this.gbStock.Controls.Add(this.gbStockAcciones);
            this.gbStock.Controls.Add(this.cbStock);
            this.gbStock.Location = new System.Drawing.Point(12, 12);
            this.gbStock.Name = "gbStock";
            this.gbStock.Size = new System.Drawing.Size(340, 124);
            this.gbStock.TabIndex = 11;
            this.gbStock.TabStop = false;
            // 
            // gbFlujosDeCaja
            // 
            this.gbFlujosDeCaja.Controls.Add(this.gbFlujosDiario);
            this.gbFlujosDeCaja.Controls.Add(this.cbFlujosDeCaja);
            this.gbFlujosDeCaja.Controls.Add(this.gbFlujosAnual);
            this.gbFlujosDeCaja.Controls.Add(this.gbFlujosMensual);
            this.gbFlujosDeCaja.Location = new System.Drawing.Point(9, 142);
            this.gbFlujosDeCaja.Name = "gbFlujosDeCaja";
            this.gbFlujosDeCaja.Size = new System.Drawing.Size(343, 283);
            this.gbFlujosDeCaja.TabIndex = 12;
            this.gbFlujosDeCaja.TabStop = false;
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 497);
            this.Controls.Add(this.gbFlujosDeCaja);
            this.Controls.Add(this.gbStock);
            this.Controls.Add(this.btGenerarReporte);
            this.Controls.Add(this.btVolver);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Reportes";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.Reportes_Load);
            this.gbStockAcciones.ResumeLayout(false);
            this.gbStockAcciones.PerformLayout();
            this.gbFlujosAnual.ResumeLayout(false);
            this.gbFlujosAnual.PerformLayout();
            this.gbFlujosMensual.ResumeLayout(false);
            this.gbFlujosMensual.PerformLayout();
            this.gbFlujosDiario.ResumeLayout(false);
            this.gbFlujosDiario.PerformLayout();
            this.gbStock.ResumeLayout(false);
            this.gbStock.PerformLayout();
            this.gbFlujosDeCaja.ResumeLayout(false);
            this.gbFlujosDeCaja.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.CheckBox cbStock;
        private System.Windows.Forms.CheckBox cbFlujosDeCaja;
        private System.Windows.Forms.GroupBox gbStockAcciones;
        private System.Windows.Forms.CheckBox cbMateriaPrima;
        private System.Windows.Forms.CheckBox cbProductosTerminados;
        private System.Windows.Forms.Button btGenerarReporte;
        private System.Windows.Forms.Button btVolver;
        private System.Windows.Forms.GroupBox gbFlujosAnual;
        private System.Windows.Forms.ComboBox cmbFlujosAnual;
        private System.Windows.Forms.CheckBox cbFlujosAnual;
        private System.Windows.Forms.GroupBox gbFlujosMensual;
        private System.Windows.Forms.ComboBox cmbFlujosMensual;
        private System.Windows.Forms.CheckBox cbFlujosMensual;
        private System.Windows.Forms.GroupBox gbFlujosDiario;
        private System.Windows.Forms.DateTimePicker dtpFlujosDiario;
        private System.Windows.Forms.CheckBox cbFlujosDiario;
        private System.Windows.Forms.GroupBox gbStock;
        private System.Windows.Forms.GroupBox gbFlujosDeCaja;
    }
}