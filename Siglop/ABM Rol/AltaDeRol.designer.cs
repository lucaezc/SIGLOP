namespace Siglop
{
    partial class AltaRol
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
            this.ConfirmarAltaR = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.Accesos = new System.Windows.Forms.CheckedListBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.active = new System.Windows.Forms.CheckBox();
            this.gbNombre = new System.Windows.Forms.GroupBox();
            this.lbAccesos = new System.Windows.Forms.Label();
            this.gbNombre.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConfirmarAltaR
            // 
            this.ConfirmarAltaR.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ConfirmarAltaR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmarAltaR.Location = new System.Drawing.Point(133, 281);
            this.ConfirmarAltaR.Name = "ConfirmarAltaR";
            this.ConfirmarAltaR.Size = new System.Drawing.Size(137, 50);
            this.ConfirmarAltaR.TabIndex = 2;
            this.ConfirmarAltaR.Text = "Confirmar Alta";
            this.ConfirmarAltaR.UseVisualStyleBackColor = true;
            this.ConfirmarAltaR.Click += new System.EventHandler(this.ConfirmarAltaR_Click);
            // 
            // cancelar
            // 
            this.cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelar.Location = new System.Drawing.Point(14, 281);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(113, 50);
            this.cancelar.TabIndex = 3;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // Accesos
            // 
            this.Accesos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Accesos.CausesValidation = false;
            this.Accesos.CheckOnClick = true;
            this.Accesos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Accesos.FormattingEnabled = true;
            this.Accesos.Location = new System.Drawing.Point(16, 64);
            this.Accesos.Name = "Accesos";
            this.Accesos.Size = new System.Drawing.Size(219, 169);
            this.Accesos.TabIndex = 0;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(13, 23);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(32, 16);
            this.lbNombre.TabIndex = 1;
            this.lbNombre.Text = "Rol:";
            // 
            // nombre
            // 
            this.nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(45, 20);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(190, 22);
            this.nombre.TabIndex = 1;
            // 
            // active
            // 
            this.active.AutoSize = true;
            this.active.Checked = true;
            this.active.CheckState = System.Windows.Forms.CheckState.Checked;
            this.active.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.active.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.active.Location = new System.Drawing.Point(16, 240);
            this.active.Name = "active";
            this.active.Size = new System.Drawing.Size(195, 20);
            this.active.TabIndex = 2;
            this.active.Text = "Alertas de faltantes de stock";
            this.active.UseVisualStyleBackColor = true;
            // 
            // gbNombre
            // 
            this.gbNombre.Controls.Add(this.lbAccesos);
            this.gbNombre.Controls.Add(this.Accesos);
            this.gbNombre.Controls.Add(this.active);
            this.gbNombre.Controls.Add(this.nombre);
            this.gbNombre.Controls.Add(this.lbNombre);
            this.gbNombre.Location = new System.Drawing.Point(14, 5);
            this.gbNombre.Name = "gbNombre";
            this.gbNombre.Padding = new System.Windows.Forms.Padding(10);
            this.gbNombre.Size = new System.Drawing.Size(256, 270);
            this.gbNombre.TabIndex = 0;
            this.gbNombre.TabStop = false;
            // 
            // lbAccesos
            // 
            this.lbAccesos.AutoSize = true;
            this.lbAccesos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAccesos.Location = new System.Drawing.Point(13, 47);
            this.lbAccesos.Name = "lbAccesos";
            this.lbAccesos.Size = new System.Drawing.Size(64, 16);
            this.lbAccesos.TabIndex = 3;
            this.lbAccesos.Text = "Accesos:";
            // 
            // AltaRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(287, 347);
            this.Controls.Add(this.ConfirmarAltaR);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.gbNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AltaRol";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de Rol";
            this.gbNombre.ResumeLayout(false);
            this.gbNombre.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ConfirmarAltaR;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.CheckedListBox Accesos;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.CheckBox active;
        private System.Windows.Forms.GroupBox gbNombre;
        private System.Windows.Forms.Label lbAccesos;

    }
}