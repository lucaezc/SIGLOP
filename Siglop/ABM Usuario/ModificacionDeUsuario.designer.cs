namespace Siglop
{
    partial class ModificacionDeUsuario
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
            System.Windows.Forms.PictureBox pictureBox1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificacionDeUsuario));
            this.gbBuscador = new System.Windows.Forms.GroupBox();
            this.Buscador = new System.Windows.Forms.TextBox();
            this.gbUsuario = new System.Windows.Forms.GroupBox();
            this.lbContrasenia2 = new System.Windows.Forms.Label();
            this.textContraseniaRepe = new System.Windows.Forms.TextBox();
            this.lbContrasenia = new System.Windows.Forms.Label();
            this.comboBoxRol = new System.Windows.Forms.ComboBox();
            this.textContrasenia = new System.Windows.Forms.TextBox();
            this.lbRol = new System.Windows.Forms.Label();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textUsuario = new System.Windows.Forms.TextBox();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.ModificarU = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            this.gbBuscador.SuspendLayout();
            this.gbUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            pictureBox1.Location = new System.Drawing.Point(364, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(22, 20);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // gbBuscador
            // 
            this.gbBuscador.Controls.Add(pictureBox1);
            this.gbBuscador.Controls.Add(this.Buscador);
            this.gbBuscador.Location = new System.Drawing.Point(13, 13);
            this.gbBuscador.Name = "gbBuscador";
            this.gbBuscador.Size = new System.Drawing.Size(401, 43);
            this.gbBuscador.TabIndex = 0;
            this.gbBuscador.TabStop = false;
            // 
            // Buscador
            // 
            this.Buscador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscador.Location = new System.Drawing.Point(16, 15);
            this.Buscador.Name = "Buscador";
            this.Buscador.Size = new System.Drawing.Size(335, 22);
            this.Buscador.TabIndex = 0;
            // 
            // gbUsuario
            // 
            this.gbUsuario.Controls.Add(this.lbContrasenia2);
            this.gbUsuario.Controls.Add(this.textContraseniaRepe);
            this.gbUsuario.Controls.Add(this.lbContrasenia);
            this.gbUsuario.Controls.Add(this.comboBoxRol);
            this.gbUsuario.Controls.Add(this.textContrasenia);
            this.gbUsuario.Controls.Add(this.lbRol);
            this.gbUsuario.Controls.Add(this.textApellido);
            this.gbUsuario.Controls.Add(this.label1);
            this.gbUsuario.Controls.Add(this.textNombre);
            this.gbUsuario.Controls.Add(this.label2);
            this.gbUsuario.Controls.Add(this.textUsuario);
            this.gbUsuario.Controls.Add(this.lbUsuario);
            this.gbUsuario.Location = new System.Drawing.Point(13, 62);
            this.gbUsuario.Name = "gbUsuario";
            this.gbUsuario.Size = new System.Drawing.Size(401, 223);
            this.gbUsuario.TabIndex = 1;
            this.gbUsuario.TabStop = false;
            // 
            // lbContrasenia2
            // 
            this.lbContrasenia2.AutoSize = true;
            this.lbContrasenia2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContrasenia2.Location = new System.Drawing.Point(13, 185);
            this.lbContrasenia2.Name = "lbContrasenia2";
            this.lbContrasenia2.Size = new System.Drawing.Size(138, 16);
            this.lbContrasenia2.TabIndex = 17;
            this.lbContrasenia2.Text = "Confirmar contraseña:";
            // 
            // textContraseniaRepe
            // 
            this.textContraseniaRepe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textContraseniaRepe.Location = new System.Drawing.Point(157, 180);
            this.textContraseniaRepe.Name = "textContraseniaRepe";
            this.textContraseniaRepe.Size = new System.Drawing.Size(228, 22);
            this.textContraseniaRepe.TabIndex = 16;
            this.textContraseniaRepe.UseSystemPasswordChar = true;
            // 
            // lbContrasenia
            // 
            this.lbContrasenia.AutoSize = true;
            this.lbContrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContrasenia.Location = new System.Drawing.Point(13, 150);
            this.lbContrasenia.Name = "lbContrasenia";
            this.lbContrasenia.Size = new System.Drawing.Size(80, 16);
            this.lbContrasenia.TabIndex = 15;
            this.lbContrasenia.Text = "Contraseña:";
            // 
            // comboBoxRol
            // 
            this.comboBoxRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRol.FormattingEnabled = true;
            this.comboBoxRol.Location = new System.Drawing.Point(157, 118);
            this.comboBoxRol.Name = "comboBoxRol";
            this.comboBoxRol.Size = new System.Drawing.Size(229, 24);
            this.comboBoxRol.TabIndex = 14;
            // 
            // textContrasenia
            // 
            this.textContrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textContrasenia.Location = new System.Drawing.Point(157, 150);
            this.textContrasenia.Name = "textContrasenia";
            this.textContrasenia.Size = new System.Drawing.Size(228, 22);
            this.textContrasenia.TabIndex = 13;
            this.textContrasenia.UseSystemPasswordChar = true;
            // 
            // lbRol
            // 
            this.lbRol.AutoSize = true;
            this.lbRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRol.Location = new System.Drawing.Point(13, 118);
            this.lbRol.Name = "lbRol";
            this.lbRol.Size = new System.Drawing.Size(32, 16);
            this.lbRol.TabIndex = 12;
            this.lbRol.Text = "Rol:";
            // 
            // textApellido
            // 
            this.textApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textApellido.Location = new System.Drawing.Point(157, 83);
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(229, 22);
            this.textApellido.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Apellido:";
            // 
            // textNombre
            // 
            this.textNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombre.Location = new System.Drawing.Point(157, 49);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(229, 22);
            this.textNombre.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre:";
            // 
            // textUsuario
            // 
            this.textUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUsuario.Location = new System.Drawing.Point(157, 17);
            this.textUsuario.Name = "textUsuario";
            this.textUsuario.Size = new System.Drawing.Size(229, 22);
            this.textUsuario.TabIndex = 4;
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuario.Location = new System.Drawing.Point(13, 16);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(58, 16);
            this.lbUsuario.TabIndex = 5;
            this.lbUsuario.Text = "Usuario:";
            // 
            // ModificarU
            // 
            this.ModificarU.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ModificarU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModificarU.Location = new System.Drawing.Point(116, 301);
            this.ModificarU.Name = "ModificarU";
            this.ModificarU.Size = new System.Drawing.Size(140, 40);
            this.ModificarU.TabIndex = 4;
            this.ModificarU.Text = "Modificar";
            this.ModificarU.UseVisualStyleBackColor = true;
            this.ModificarU.Click += new System.EventHandler(this.ModificarU_Click);
            // 
            // cancelar
            // 
            this.cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelar.Location = new System.Drawing.Point(274, 301);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(140, 40);
            this.cancelar.TabIndex = 5;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // ModificacionDeUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(430, 355);
            this.Controls.Add(this.ModificarU);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.gbUsuario);
            this.Controls.Add(this.gbBuscador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ModificacionDeUsuario";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificación de Usuario";
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            this.gbBuscador.ResumeLayout(false);
            this.gbBuscador.PerformLayout();
            this.gbUsuario.ResumeLayout(false);
            this.gbUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBuscador;
        private System.Windows.Forms.TextBox Buscador;
        private System.Windows.Forms.GroupBox gbUsuario;
        private System.Windows.Forms.Button ModificarU;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textUsuario;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.TextBox textContrasenia;
        private System.Windows.Forms.Label lbRol;
        private System.Windows.Forms.ComboBox comboBoxRol;
        private System.Windows.Forms.Label lbContrasenia;
        private System.Windows.Forms.Label lbContrasenia2;
        private System.Windows.Forms.TextBox textContraseniaRepe;
    }
}