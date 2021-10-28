namespace Siglop
{
    partial class ModificacionRol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificacionRol));
            this.ModificarR = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.lbNombre = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.active = new System.Windows.Forms.CheckBox();
            this.gbNombre = new System.Windows.Forms.GroupBox();
            this.dataGridViewA = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Pantalla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbAccesos = new System.Windows.Forms.Label();
            this.gbBuscador = new System.Windows.Forms.GroupBox();
            this.NombreRol = new System.Windows.Forms.TextBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            this.gbNombre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewA)).BeginInit();
            this.gbBuscador.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            pictureBox1.Location = new System.Drawing.Point(301, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(22, 20);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // ModificarR
            // 
            this.ModificarR.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ModificarR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModificarR.Location = new System.Drawing.Point(84, 326);
            this.ModificarR.Name = "ModificarR";
            this.ModificarR.Size = new System.Drawing.Size(130, 47);
            this.ModificarR.TabIndex = 2;
            this.ModificarR.Text = "Modificar";
            this.ModificarR.UseVisualStyleBackColor = true;
            this.ModificarR.Click += new System.EventHandler(this.ModificarR_Click);
            // 
            // cancelar
            // 
            this.cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelar.Location = new System.Drawing.Point(220, 326);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(130, 47);
            this.cancelar.TabIndex = 3;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
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
            this.nombre.Size = new System.Drawing.Size(270, 22);
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
            this.gbNombre.Controls.Add(this.dataGridViewA);
            this.gbNombre.Controls.Add(this.lbAccesos);
            this.gbNombre.Controls.Add(this.active);
            this.gbNombre.Controls.Add(this.nombre);
            this.gbNombre.Controls.Add(this.lbNombre);
            this.gbNombre.Location = new System.Drawing.Point(14, 51);
            this.gbNombre.Name = "gbNombre";
            this.gbNombre.Padding = new System.Windows.Forms.Padding(10);
            this.gbNombre.Size = new System.Drawing.Size(336, 269);
            this.gbNombre.TabIndex = 0;
            this.gbNombre.TabStop = false;
            // 
            // dataGridViewA
            // 
            this.dataGridViewA.AllowUserToAddRows = false;
            this.dataGridViewA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar,
            this.Pantalla});
            this.dataGridViewA.Location = new System.Drawing.Point(16, 63);
            this.dataGridViewA.Name = "dataGridViewA";
            this.dataGridViewA.Size = new System.Drawing.Size(299, 171);
            this.dataGridViewA.TabIndex = 5;
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Sel";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.Width = 50;
            // 
            // Pantalla
            // 
            this.Pantalla.HeaderText = "Acceso";
            this.Pantalla.Name = "Pantalla";
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
            // gbBuscador
            // 
            this.gbBuscador.Controls.Add(pictureBox1);
            this.gbBuscador.Controls.Add(this.NombreRol);
            this.gbBuscador.Location = new System.Drawing.Point(14, 6);
            this.gbBuscador.Name = "gbBuscador";
            this.gbBuscador.Padding = new System.Windows.Forms.Padding(10);
            this.gbBuscador.Size = new System.Drawing.Size(336, 46);
            this.gbBuscador.TabIndex = 4;
            this.gbBuscador.TabStop = false;
            // 
            // NombreRol
            // 
            this.NombreRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreRol.Location = new System.Drawing.Point(12, 17);
            this.NombreRol.Name = "NombreRol";
            this.NombreRol.Size = new System.Drawing.Size(283, 22);
            this.NombreRol.TabIndex = 5;
            // 
            // ModificacionRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(368, 385);
            this.Controls.Add(this.gbBuscador);
            this.Controls.Add(this.ModificarR);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.gbNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ModificacionRol";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificación de Rol";
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            this.gbNombre.ResumeLayout(false);
            this.gbNombre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewA)).EndInit();
            this.gbBuscador.ResumeLayout(false);
            this.gbBuscador.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ModificarR;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.CheckBox active;
        private System.Windows.Forms.GroupBox gbNombre;
        private System.Windows.Forms.Label lbAccesos;
        private System.Windows.Forms.GroupBox gbBuscador;
        private System.Windows.Forms.TextBox NombreRol;
        private System.Windows.Forms.DataGridView dataGridViewA;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pantalla;

    }
}