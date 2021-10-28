namespace Siglop
{
    partial class Menu
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
            this.btStock = new System.Windows.Forms.Button();
            this.btProductos = new System.Windows.Forms.Button();
            this.btFlujoCaja = new System.Windows.Forms.Button();
            this.btConsultas = new System.Windows.Forms.Button();
            this.btAgenda = new System.Windows.Forms.Button();
            this.btReportes = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.btConfiguracion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btStock
            // 
            this.btStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStock.Location = new System.Drawing.Point(76, 63);
            this.btStock.Name = "btStock";
            this.btStock.Size = new System.Drawing.Size(150, 65);
            this.btStock.TabIndex = 0;
            this.btStock.Text = "Gestión de Stock";
            this.btStock.UseVisualStyleBackColor = true;
            this.btStock.Click += new System.EventHandler(this.button1_Click);
            // 
            // btProductos
            // 
            this.btProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btProductos.Location = new System.Drawing.Point(232, 63);
            this.btProductos.Name = "btProductos";
            this.btProductos.Size = new System.Drawing.Size(150, 65);
            this.btProductos.TabIndex = 1;
            this.btProductos.Text = "Catálogo de Productos";
            this.btProductos.UseVisualStyleBackColor = true;
            this.btProductos.Click += new System.EventHandler(this.button2_Click);
            // 
            // btFlujoCaja
            // 
            this.btFlujoCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFlujoCaja.Location = new System.Drawing.Point(388, 63);
            this.btFlujoCaja.Name = "btFlujoCaja";
            this.btFlujoCaja.Size = new System.Drawing.Size(150, 65);
            this.btFlujoCaja.TabIndex = 2;
            this.btFlujoCaja.Text = "Gestión de Flujo de Caja";
            this.btFlujoCaja.UseVisualStyleBackColor = true;
            this.btFlujoCaja.Click += new System.EventHandler(this.button3_Click);
            // 
            // btConsultas
            // 
            this.btConsultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConsultas.Location = new System.Drawing.Point(76, 144);
            this.btConsultas.Name = "btConsultas";
            this.btConsultas.Size = new System.Drawing.Size(150, 65);
            this.btConsultas.TabIndex = 3;
            this.btConsultas.Text = "Consultas";
            this.btConsultas.UseVisualStyleBackColor = true;
            this.btConsultas.Click += new System.EventHandler(this.button4_Click);
            // 
            // btAgenda
            // 
            this.btAgenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAgenda.Location = new System.Drawing.Point(232, 144);
            this.btAgenda.Name = "btAgenda";
            this.btAgenda.Size = new System.Drawing.Size(150, 65);
            this.btAgenda.TabIndex = 4;
            this.btAgenda.Text = "Agenda";
            this.btAgenda.UseVisualStyleBackColor = true;
            this.btAgenda.Click += new System.EventHandler(this.button5_Click);
            // 
            // btReportes
            // 
            this.btReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReportes.Location = new System.Drawing.Point(388, 144);
            this.btReportes.Name = "btReportes";
            this.btReportes.Size = new System.Drawing.Size(150, 65);
            this.btReportes.TabIndex = 5;
            this.btReportes.Text = "Reportes";
            this.btReportes.UseVisualStyleBackColor = true;
            this.btReportes.Click += new System.EventHandler(this.button6_Click);
            // 
            // Salir
            // 
            this.Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salir.Location = new System.Drawing.Point(232, 233);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(150, 65);
            this.Salir.TabIndex = 6;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // btConfiguracion
            // 
            this.btConfiguracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConfiguracion.Location = new System.Drawing.Point(388, 233);
            this.btConfiguracion.Name = "btConfiguracion";
            this.btConfiguracion.Size = new System.Drawing.Size(150, 65);
            this.btConfiguracion.TabIndex = 7;
            this.btConfiguracion.Text = "Configuración";
            this.btConfiguracion.UseVisualStyleBackColor = true;
            this.btConfiguracion.Click += new System.EventHandler(this.button8_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(623, 363);
            this.Controls.Add(this.btConfiguracion);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.btReportes);
            this.Controls.Add(this.btAgenda);
            this.Controls.Add(this.btConsultas);
            this.Controls.Add(this.btFlujoCaja);
            this.Controls.Add(this.btProductos);
            this.Controls.Add(this.btStock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SIGLOP: Sistema Integral de Gestión para Locales y Puntos de Venta de Indumentari" +
                "a";
            this.Load += new System.EventHandler(this.UI005_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btStock;
        private System.Windows.Forms.Button btProductos;
        private System.Windows.Forms.Button btFlujoCaja;
        private System.Windows.Forms.Button btConsultas;
        private System.Windows.Forms.Button btAgenda;
        private System.Windows.Forms.Button btReportes;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Button btConfiguracion;
    }
}

