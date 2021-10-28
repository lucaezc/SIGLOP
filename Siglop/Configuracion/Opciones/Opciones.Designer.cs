namespace Siglop
{
    partial class Opciones
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
            this.chkMatPrima = new System.Windows.Forms.CheckBox();
            this.chkStkSimple = new System.Windows.Forms.CheckBox();
            this.chkStkCurva = new System.Windows.Forms.CheckBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.chkAlertaFaltantes = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // chkMatPrima
            // 
            this.chkMatPrima.AutoSize = true;
            this.chkMatPrima.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMatPrima.Location = new System.Drawing.Point(23, 27);
            this.chkMatPrima.Name = "chkMatPrima";
            this.chkMatPrima.Size = new System.Drawing.Size(217, 20);
            this.chkMatPrima.TabIndex = 0;
            this.chkMatPrima.Text = "Llevar stock de materias primas";
            this.chkMatPrima.UseVisualStyleBackColor = true;
            this.chkMatPrima.CheckedChanged += new System.EventHandler(this.chkMatPrima_CheckedChanged);
            // 
            // chkStkSimple
            // 
            this.chkStkSimple.AutoSize = true;
            this.chkStkSimple.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkStkSimple.Location = new System.Drawing.Point(23, 65);
            this.chkStkSimple.Name = "chkStkSimple";
            this.chkStkSimple.Size = new System.Drawing.Size(205, 20);
            this.chkStkSimple.TabIndex = 1;
            this.chkStkSimple.Text = "Habilitar vista de stock simple";
            this.chkStkSimple.UseVisualStyleBackColor = true;
            this.chkStkSimple.CheckedChanged += new System.EventHandler(this.chkStkSimple_CheckedChanged);
            // 
            // chkStkCurva
            // 
            this.chkStkCurva.AutoSize = true;
            this.chkStkCurva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkStkCurva.Location = new System.Drawing.Point(23, 102);
            this.chkStkCurva.Name = "chkStkCurva";
            this.chkStkCurva.Size = new System.Drawing.Size(306, 20);
            this.chkStkCurva.TabIndex = 2;
            this.chkStkCurva.Text = "Habilitar vista de stock por curvas (Talle/Color)";
            this.chkStkCurva.UseVisualStyleBackColor = true;
            this.chkStkCurva.CheckedChanged += new System.EventHandler(this.chkStkCurva_CheckedChanged);
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(225, 181);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(113, 37);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // chkAlertaFaltantes
            // 
            this.chkAlertaFaltantes.AutoSize = true;
            this.chkAlertaFaltantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAlertaFaltantes.Location = new System.Drawing.Point(23, 137);
            this.chkAlertaFaltantes.Name = "chkAlertaFaltantes";
            this.chkAlertaFaltantes.Size = new System.Drawing.Size(188, 20);
            this.chkAlertaFaltantes.TabIndex = 4;
            this.chkAlertaFaltantes.Text = "Alerta de faltantes de stock";
            this.chkAlertaFaltantes.UseVisualStyleBackColor = true;
            this.chkAlertaFaltantes.CheckedChanged += new System.EventHandler(this.chkAlertaFaltantes_CheckedChanged);
            // 
            // Opciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(350, 230);
            this.Controls.Add(this.chkAlertaFaltantes);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.chkStkCurva);
            this.Controls.Add(this.chkStkSimple);
            this.Controls.Add(this.chkMatPrima);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Opciones";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Opciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkMatPrima;
        private System.Windows.Forms.CheckBox chkStkSimple;
        private System.Windows.Forms.CheckBox chkStkCurva;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.CheckBox chkAlertaFaltantes;
    }
}