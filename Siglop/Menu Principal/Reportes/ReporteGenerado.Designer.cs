namespace Siglop
{
    partial class ReporteGenerado
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
            this.dgReporteFlujosCaja = new System.Windows.Forms.DataGridView();
            this.btVolver = new System.Windows.Forms.Button();
            this.lbReporteNombre = new System.Windows.Forms.Label();
            this.dgReporteMateriasPrimas = new System.Windows.Forms.DataGridView();
            this.IdMateriaPrima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockMP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoMovimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgReporteProductos = new System.Windows.Forms.DataGridView();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coleccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Talle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockProductos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgReporteFlujosCaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgReporteMateriasPrimas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgReporteProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgReporteFlujosCaja
            // 
            this.dgReporteFlujosCaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReporteFlujosCaja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCaja,
            this.IdDetalle,
            this.TipoMovimiento,
            this.Cantidad,
            this.Detalle,
            this.Observacion,
            this.Monto});
            this.dgReporteFlujosCaja.Location = new System.Drawing.Point(12, 55);
            this.dgReporteFlujosCaja.Name = "dgReporteFlujosCaja";
            this.dgReporteFlujosCaja.Size = new System.Drawing.Size(714, 308);
            this.dgReporteFlujosCaja.TabIndex = 0;
            // 
            // btVolver
            // 
            this.btVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVolver.Location = new System.Drawing.Point(619, 12);
            this.btVolver.Name = "btVolver";
            this.btVolver.Size = new System.Drawing.Size(107, 37);
            this.btVolver.TabIndex = 1;
            this.btVolver.Text = "Volver";
            this.btVolver.UseVisualStyleBackColor = true;
            this.btVolver.Click += new System.EventHandler(this.btVolver_Click);
            // 
            // lbReporteNombre
            // 
            this.lbReporteNombre.AutoSize = true;
            this.lbReporteNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReporteNombre.Location = new System.Drawing.Point(9, 19);
            this.lbReporteNombre.Name = "lbReporteNombre";
            this.lbReporteNombre.Size = new System.Drawing.Size(0, 16);
            this.lbReporteNombre.TabIndex = 2;
            // 
            // dgReporteMateriasPrimas
            // 
            this.dgReporteMateriasPrimas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReporteMateriasPrimas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdMateriaPrima,
            this.Descripcion,
            this.StockMP});
            this.dgReporteMateriasPrimas.Location = new System.Drawing.Point(12, 55);
            this.dgReporteMateriasPrimas.Name = "dgReporteMateriasPrimas";
            this.dgReporteMateriasPrimas.Size = new System.Drawing.Size(714, 308);
            this.dgReporteMateriasPrimas.TabIndex = 3;
            // 
            // IdMateriaPrima
            // 
            this.IdMateriaPrima.HeaderText = "IdMateriaPrima";
            this.IdMateriaPrima.Name = "IdMateriaPrima";
            this.IdMateriaPrima.ReadOnly = true;
            this.IdMateriaPrima.Visible = false;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Materia Prima";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 200;
            // 
            // StockMP
            // 
            this.StockMP.HeaderText = "Stock";
            this.StockMP.Name = "StockMP";
            this.StockMP.ReadOnly = true;
            this.StockMP.Width = 150;
            // 
            // IdCaja
            // 
            this.IdCaja.HeaderText = "IdCaja";
            this.IdCaja.Name = "IdCaja";
            this.IdCaja.ReadOnly = true;
            this.IdCaja.Visible = false;
            // 
            // IdDetalle
            // 
            this.IdDetalle.HeaderText = "IdDetalle";
            this.IdDetalle.Name = "IdDetalle";
            this.IdDetalle.ReadOnly = true;
            this.IdDetalle.Visible = false;
            // 
            // TipoMovimiento
            // 
            this.TipoMovimiento.HeaderText = "Tipo Movimiento";
            this.TipoMovimiento.Name = "TipoMovimiento";
            this.TipoMovimiento.ReadOnly = true;
            this.TipoMovimiento.Width = 75;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 60;
            // 
            // Detalle
            // 
            this.Detalle.HeaderText = "Detalle";
            this.Detalle.Name = "Detalle";
            this.Detalle.ReadOnly = true;
            this.Detalle.Width = 150;
            // 
            // Observacion
            // 
            this.Observacion.HeaderText = "Observación";
            this.Observacion.Name = "Observacion";
            this.Observacion.ReadOnly = true;
            this.Observacion.Width = 250;
            // 
            // Monto
            // 
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            // 
            // dgReporteProductos
            // 
            this.dgReporteProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReporteProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto,
            this.DescripcionProducto,
            this.Coleccion,
            this.Talle,
            this.Color,
            this.StockProductos});
            this.dgReporteProductos.Location = new System.Drawing.Point(12, 55);
            this.dgReporteProductos.Name = "dgReporteProductos";
            this.dgReporteProductos.Size = new System.Drawing.Size(714, 308);
            this.dgReporteProductos.TabIndex = 4;
            // 
            // IdProducto
            // 
            this.IdProducto.HeaderText = "IdProducto";
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.ReadOnly = true;
            this.IdProducto.Visible = false;
            // 
            // DescripcionProducto
            // 
            this.DescripcionProducto.HeaderText = "Producto";
            this.DescripcionProducto.Name = "DescripcionProducto";
            this.DescripcionProducto.ReadOnly = true;
            this.DescripcionProducto.Width = 300;
            // 
            // Coleccion
            // 
            this.Coleccion.HeaderText = "Colección";
            this.Coleccion.Name = "Coleccion";
            this.Coleccion.ReadOnly = true;
            this.Coleccion.Width = 120;
            // 
            // Talle
            // 
            this.Talle.HeaderText = "Talle";
            this.Talle.Name = "Talle";
            this.Talle.ReadOnly = true;
            this.Talle.Width = 50;
            // 
            // Color
            // 
            this.Color.HeaderText = "Color";
            this.Color.Name = "Color";
            this.Color.ReadOnly = true;
            // 
            // StockProductos
            // 
            this.StockProductos.HeaderText = "Stock";
            this.StockProductos.Name = "StockProductos";
            this.StockProductos.ReadOnly = true;
            // 
            // ReporteGenerado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 381);
            this.Controls.Add(this.dgReporteProductos);
            this.Controls.Add(this.dgReporteMateriasPrimas);
            this.Controls.Add(this.lbReporteNombre);
            this.Controls.Add(this.btVolver);
            this.Controls.Add(this.dgReporteFlujosCaja);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ReporteGenerado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dgReporteFlujosCaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgReporteMateriasPrimas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgReporteProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgReporteFlujosCaja;
        private System.Windows.Forms.Button btVolver;
        private System.Windows.Forms.Label lbReporteNombre;
        private System.Windows.Forms.DataGridView dgReporteMateriasPrimas;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMateriaPrima;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockMP;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoMovimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridView dgReporteProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coleccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Talle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockProductos;
    }
}