namespace Siglop
{
    partial class Parametrizacion
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
            this.btnCaja = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnMatPrima = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCaja
            // 
            this.btnCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaja.Location = new System.Drawing.Point(32, 27);
            this.btnCaja.Name = "btnCaja";
            this.btnCaja.Size = new System.Drawing.Size(150, 45);
            this.btnCaja.TabIndex = 0;
            this.btnCaja.Text = "Detalles de flujo de caja";
            this.btnCaja.UseVisualStyleBackColor = true;
            this.btnCaja.Click += new System.EventHandler(this.btnCaja_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(188, 95);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(150, 45);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnMatPrima
            // 
            this.btnMatPrima.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMatPrima.Location = new System.Drawing.Point(188, 27);
            this.btnMatPrima.Name = "btnMatPrima";
            this.btnMatPrima.Size = new System.Drawing.Size(150, 45);
            this.btnMatPrima.TabIndex = 2;
            this.btnMatPrima.Text = "Materias Primas";
            this.btnMatPrima.UseVisualStyleBackColor = true;
            this.btnMatPrima.Click += new System.EventHandler(this.btnMatPrima_Click);
            // 
            // Parametrizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(381, 172);
            this.Controls.Add(this.btnMatPrima);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnCaja);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Parametrizacion";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parametrización";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCaja;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnMatPrima;
    }
}