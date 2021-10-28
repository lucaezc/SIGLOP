namespace Siglop
{
    partial class Usuarios
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
            this.ConfirmarAltaU = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.gbUsuarios = new System.Windows.Forms.GroupBox();
            this.textRol = new System.Windows.Forms.TextBox();
            this.lbRol = new System.Windows.Forms.Label();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.lbApellido = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.usuariosNombre = new System.Windows.Forms.TextBox();
            this.lbUsuarios = new System.Windows.Forms.Label();
            this.bModifUsuarios = new System.Windows.Forms.Button();
            this.bEliminUsuarios = new System.Windows.Forms.Button();
            this.ListadoUsuarios = new System.Windows.Forms.ListBox();
            this.gbUsuarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConfirmarAltaU
            // 
            this.ConfirmarAltaU.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ConfirmarAltaU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmarAltaU.Location = new System.Drawing.Point(31, 212);
            this.ConfirmarAltaU.Name = "ConfirmarAltaU";
            this.ConfirmarAltaU.Size = new System.Drawing.Size(165, 45);
            this.ConfirmarAltaU.TabIndex = 4;
            this.ConfirmarAltaU.Text = "Alta de Usuario";
            this.ConfirmarAltaU.UseVisualStyleBackColor = true;
            this.ConfirmarAltaU.Click += new System.EventHandler(this.ConfirmarAltaU_Click);
            // 
            // cancelar
            // 
            this.cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelar.Location = new System.Drawing.Point(544, 212);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(97, 45);
            this.cancelar.TabIndex = 5;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // gbUsuarios
            // 
            this.gbUsuarios.Controls.Add(this.textRol);
            this.gbUsuarios.Controls.Add(this.lbRol);
            this.gbUsuarios.Controls.Add(this.textApellido);
            this.gbUsuarios.Controls.Add(this.lbApellido);
            this.gbUsuarios.Controls.Add(this.textNombre);
            this.gbUsuarios.Controls.Add(this.lbNombre);
            this.gbUsuarios.Controls.Add(this.usuariosNombre);
            this.gbUsuarios.Controls.Add(this.lbUsuarios);
            this.gbUsuarios.Location = new System.Drawing.Point(274, 25);
            this.gbUsuarios.Name = "gbUsuarios";
            this.gbUsuarios.Size = new System.Drawing.Size(367, 167);
            this.gbUsuarios.TabIndex = 6;
            this.gbUsuarios.TabStop = false;
            // 
            // textRol
            // 
            this.textRol.Enabled = false;
            this.textRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRol.Location = new System.Drawing.Point(81, 127);
            this.textRol.Name = "textRol";
            this.textRol.Size = new System.Drawing.Size(265, 22);
            this.textRol.TabIndex = 7;
            // 
            // lbRol
            // 
            this.lbRol.AutoSize = true;
            this.lbRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRol.Location = new System.Drawing.Point(17, 131);
            this.lbRol.Name = "lbRol";
            this.lbRol.Size = new System.Drawing.Size(32, 16);
            this.lbRol.TabIndex = 6;
            this.lbRol.Text = "Rol:";
            // 
            // textApellido
            // 
            this.textApellido.Enabled = false;
            this.textApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textApellido.Location = new System.Drawing.Point(81, 88);
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(265, 22);
            this.textApellido.TabIndex = 5;
            // 
            // lbApellido
            // 
            this.lbApellido.AutoSize = true;
            this.lbApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApellido.Location = new System.Drawing.Point(17, 92);
            this.lbApellido.Name = "lbApellido";
            this.lbApellido.Size = new System.Drawing.Size(61, 16);
            this.lbApellido.TabIndex = 4;
            this.lbApellido.Text = "Apellido:";
            // 
            // textNombre
            // 
            this.textNombre.Enabled = false;
            this.textNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombre.Location = new System.Drawing.Point(81, 52);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(265, 22);
            this.textNombre.TabIndex = 3;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(17, 56);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(60, 16);
            this.lbNombre.TabIndex = 2;
            this.lbNombre.Text = "Nombre:";
            // 
            // usuariosNombre
            // 
            this.usuariosNombre.Enabled = false;
            this.usuariosNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuariosNombre.Location = new System.Drawing.Point(81, 16);
            this.usuariosNombre.Name = "usuariosNombre";
            this.usuariosNombre.Size = new System.Drawing.Size(265, 22);
            this.usuariosNombre.TabIndex = 1;
            // 
            // lbUsuarios
            // 
            this.lbUsuarios.AutoSize = true;
            this.lbUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuarios.Location = new System.Drawing.Point(17, 20);
            this.lbUsuarios.Name = "lbUsuarios";
            this.lbUsuarios.Size = new System.Drawing.Size(58, 16);
            this.lbUsuarios.TabIndex = 0;
            this.lbUsuarios.Text = "Usuario:";
            // 
            // bModifUsuarios
            // 
            this.bModifUsuarios.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bModifUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bModifUsuarios.Location = new System.Drawing.Point(202, 212);
            this.bModifUsuarios.Name = "bModifUsuarios";
            this.bModifUsuarios.Size = new System.Drawing.Size(165, 45);
            this.bModifUsuarios.TabIndex = 7;
            this.bModifUsuarios.Text = "Modificación de Usuario";
            this.bModifUsuarios.UseVisualStyleBackColor = true;
            this.bModifUsuarios.Click += new System.EventHandler(this.bModifUsuarios_Click);
            // 
            // bEliminUsuarios
            // 
            this.bEliminUsuarios.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bEliminUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEliminUsuarios.Location = new System.Drawing.Point(373, 212);
            this.bEliminUsuarios.Name = "bEliminUsuarios";
            this.bEliminUsuarios.Size = new System.Drawing.Size(165, 45);
            this.bEliminUsuarios.TabIndex = 8;
            this.bEliminUsuarios.Text = "Eliminación de Usuario";
            this.bEliminUsuarios.UseVisualStyleBackColor = true;
            this.bEliminUsuarios.Click += new System.EventHandler(this.bEliminUsuarios_Click);
            // 
            // ListadoUsuarios
            // 
            this.ListadoUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListadoUsuarios.FormattingEnabled = true;
            this.ListadoUsuarios.ItemHeight = 16;
            this.ListadoUsuarios.Location = new System.Drawing.Point(31, 41);
            this.ListadoUsuarios.Name = "ListadoUsuarios";
            this.ListadoUsuarios.Size = new System.Drawing.Size(226, 148);
            this.ListadoUsuarios.TabIndex = 10;
            this.ListadoUsuarios.SelectedIndexChanged += new System.EventHandler(this.ListadoUsuarios_SelectedIndexChanged_1);
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(667, 289);
            this.Controls.Add(this.ListadoUsuarios);
            this.Controls.Add(this.bEliminUsuarios);
            this.Controls.Add(this.bModifUsuarios);
            this.Controls.Add(this.gbUsuarios);
            this.Controls.Add(this.ConfirmarAltaU);
            this.Controls.Add(this.cancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Usuarios";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.gbUsuarios.ResumeLayout(false);
            this.gbUsuarios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ConfirmarAltaU;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.GroupBox gbUsuarios;
        private System.Windows.Forms.TextBox usuariosNombre;
        private System.Windows.Forms.Label lbUsuarios;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.Label lbApellido;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.TextBox textRol;
        private System.Windows.Forms.Label lbRol;
        private System.Windows.Forms.Button bModifUsuarios;
        private System.Windows.Forms.Button bEliminUsuarios;
        private System.Windows.Forms.ListBox ListadoUsuarios;
    }
}