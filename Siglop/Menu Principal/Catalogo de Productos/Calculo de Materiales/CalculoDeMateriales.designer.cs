namespace Siglop
{
    partial class CalculoDeMateriales
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
            System.Windows.Forms.PictureBox btBuscar;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculoDeMateriales));
            this.dgArtMateriales = new System.Windows.Forms.DataGridView();
            this.MaterialID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCantdad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.tbBuscador = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbArticulo = new System.Windows.Forms.TextBox();
            this.lbArticulo = new System.Windows.Forms.Label();
            btBuscar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(btBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgArtMateriales)).BeginInit();
            this.SuspendLayout();
            // 
            // btBuscar
            // 
            btBuscar.BackColor = System.Drawing.SystemColors.ControlDark;
            btBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btBuscar.Image")));
            btBuscar.Location = new System.Drawing.Point(359, 16);
            btBuscar.Name = "btBuscar";
            btBuscar.Size = new System.Drawing.Size(22, 20);
            btBuscar.TabIndex = 18;
            btBuscar.TabStop = false;
            btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // dgArtMateriales
            // 
            this.dgArtMateriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgArtMateriales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaterialID,
            this.Material,
            this.StockActual,
            this.StockUnidad});
            this.dgArtMateriales.Location = new System.Drawing.Point(12, 99);
            this.dgArtMateriales.Name = "dgArtMateriales";
            this.dgArtMateriales.Size = new System.Drawing.Size(486, 107);
            this.dgArtMateriales.TabIndex = 2;
            // 
            // MaterialID
            // 
            this.MaterialID.HeaderText = "MaterialID";
            this.MaterialID.Name = "MaterialID";
            this.MaterialID.Visible = false;
            // 
            // Material
            // 
            this.Material.HeaderText = "Material";
            this.Material.Name = "Material";
            // 
            // StockActual
            // 
            this.StockActual.HeaderText = "Stock Actual";
            this.StockActual.Name = "StockActual";
            // 
            // StockUnidad
            // 
            this.StockUnidad.HeaderText = "Stock Necesario para una unidad";
            this.StockUnidad.Name = "StockUnidad";
            this.StockUnidad.Width = 200;
            // 
            // lblCantdad
            // 
            this.lblCantdad.AutoSize = true;
            this.lblCantdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantdad.Location = new System.Drawing.Point(9, 218);
            this.lblCantdad.Name = "lblCantdad";
            this.lblCantdad.Size = new System.Drawing.Size(287, 16);
            this.lblCantdad.TabIndex = 3;
            this.lblCantdad.Text = "Cantidad de unidades que se pueden fabricar: ";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Enabled = false;
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(302, 217);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(196, 22);
            this.txtCantidad.TabIndex = 4;
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(402, 254);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(96, 38);
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // tbBuscador
            // 
            this.tbBuscador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBuscador.Location = new System.Drawing.Point(80, 16);
            this.tbBuscador.Name = "tbBuscador";
            this.tbBuscador.Size = new System.Drawing.Size(273, 22);
            this.tbBuscador.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Buscar:";
            // 
            // tbArticulo
            // 
            this.tbArticulo.Enabled = false;
            this.tbArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbArticulo.Location = new System.Drawing.Point(80, 59);
            this.tbArticulo.Name = "tbArticulo";
            this.tbArticulo.Size = new System.Drawing.Size(273, 22);
            this.tbArticulo.TabIndex = 20;
            // 
            // lbArticulo
            // 
            this.lbArticulo.AutoSize = true;
            this.lbArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbArticulo.Location = new System.Drawing.Point(9, 62);
            this.lbArticulo.Name = "lbArticulo";
            this.lbArticulo.Size = new System.Drawing.Size(65, 16);
            this.lbArticulo.TabIndex = 19;
            this.lbArticulo.Text = "Producto:";
            // 
            // CalculoDeMateriales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 307);
            this.Controls.Add(this.tbArticulo);
            this.Controls.Add(this.lbArticulo);
            this.Controls.Add(btBuscar);
            this.Controls.Add(this.tbBuscador);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblCantdad);
            this.Controls.Add(this.dgArtMateriales);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CalculoDeMateriales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cálculo de materiales para confección de productos";
            ((System.ComponentModel.ISupportInitialize)(btBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgArtMateriales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgArtMateriales;
        private System.Windows.Forms.Label lblCantdad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.TextBox tbBuscador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbArticulo;
        private System.Windows.Forms.Label lbArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Material;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockActual;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockUnidad;
    }
}