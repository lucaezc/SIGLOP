using System;

namespace Siglop
{
    partial class Agenda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        /// 

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agenda));
            this.Listado = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbTipoContacto = new System.Windows.Forms.TextBox();
            this.lbTipoContacto = new System.Windows.Forms.Label();
            this.T_Telefono3 = new System.Windows.Forms.TextBox();
            this.T_Telefono2 = new System.Windows.Forms.TextBox();
            this.T_Telefono1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.T_Mail = new System.Windows.Forms.TextBox();
            this.T_Direccion = new System.Windows.Forms.TextBox();
            this.T_Apellido = new System.Windows.Forms.TextBox();
            this.T_Nombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Alta_Contacto = new System.Windows.Forms.Button();
            this.Modificar = new System.Windows.Forms.Button();
            this.Eliminar_Contacto = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Buscador = new System.Windows.Forms.TextBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            pictureBox1.Location = new System.Drawing.Point(658, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(22, 20);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Listado
            // 
            this.Listado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Listado.FormattingEnabled = true;
            this.Listado.ItemHeight = 16;
            this.Listado.Location = new System.Drawing.Point(12, 51);
            this.Listado.Name = "Listado";
            this.Listado.Size = new System.Drawing.Size(158, 148);
            this.Listado.TabIndex = 0;
            this.Listado.SelectedIndexChanged += new System.EventHandler(this.Listado_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbTipoContacto);
            this.groupBox1.Controls.Add(this.lbTipoContacto);
            this.groupBox1.Controls.Add(this.T_Telefono3);
            this.groupBox1.Controls.Add(this.T_Telefono2);
            this.groupBox1.Controls.Add(this.T_Telefono1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.T_Mail);
            this.groupBox1.Controls.Add(this.T_Direccion);
            this.groupBox1.Controls.Add(this.T_Apellido);
            this.groupBox1.Controls.Add(this.T_Nombre);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(186, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(529, 169);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tbTipoContacto
            // 
            this.tbTipoContacto.Enabled = false;
            this.tbTipoContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTipoContacto.Location = new System.Drawing.Point(351, 118);
            this.tbTipoContacto.Name = "tbTipoContacto";
            this.tbTipoContacto.Size = new System.Drawing.Size(143, 22);
            this.tbTipoContacto.TabIndex = 13;
            // 
            // lbTipoContacto
            // 
            this.lbTipoContacto.AutoSize = true;
            this.lbTipoContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTipoContacto.Location = new System.Drawing.Point(274, 118);
            this.lbTipoContacto.Name = "lbTipoContacto";
            this.lbTipoContacto.Size = new System.Drawing.Size(39, 16);
            this.lbTipoContacto.TabIndex = 12;
            this.lbTipoContacto.Text = "Tipo:";
            // 
            // T_Telefono3
            // 
            this.T_Telefono3.Enabled = false;
            this.T_Telefono3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_Telefono3.Location = new System.Drawing.Point(351, 90);
            this.T_Telefono3.Name = "T_Telefono3";
            this.T_Telefono3.Size = new System.Drawing.Size(143, 22);
            this.T_Telefono3.TabIndex = 11;
            // 
            // T_Telefono2
            // 
            this.T_Telefono2.Enabled = false;
            this.T_Telefono2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_Telefono2.Location = new System.Drawing.Point(351, 59);
            this.T_Telefono2.Name = "T_Telefono2";
            this.T_Telefono2.Size = new System.Drawing.Size(143, 22);
            this.T_Telefono2.TabIndex = 10;
            // 
            // T_Telefono1
            // 
            this.T_Telefono1.Enabled = false;
            this.T_Telefono1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_Telefono1.Location = new System.Drawing.Point(351, 30);
            this.T_Telefono1.Name = "T_Telefono1";
            this.T_Telefono1.Size = new System.Drawing.Size(143, 22);
            this.T_Telefono1.TabIndex = 9;
            this.T_Telefono1.TextChanged += new System.EventHandler(this.T_Telefono1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(274, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Teléfonos:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // T_Mail
            // 
            this.T_Mail.Enabled = false;
            this.T_Mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_Mail.Location = new System.Drawing.Point(89, 118);
            this.T_Mail.Name = "T_Mail";
            this.T_Mail.Size = new System.Drawing.Size(170, 22);
            this.T_Mail.TabIndex = 7;
            // 
            // T_Direccion
            // 
            this.T_Direccion.Enabled = false;
            this.T_Direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_Direccion.Location = new System.Drawing.Point(89, 87);
            this.T_Direccion.Name = "T_Direccion";
            this.T_Direccion.Size = new System.Drawing.Size(170, 22);
            this.T_Direccion.TabIndex = 6;
            // 
            // T_Apellido
            // 
            this.T_Apellido.Enabled = false;
            this.T_Apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_Apellido.Location = new System.Drawing.Point(89, 59);
            this.T_Apellido.Name = "T_Apellido";
            this.T_Apellido.Size = new System.Drawing.Size(170, 22);
            this.T_Apellido.TabIndex = 5;
            this.T_Apellido.TextChanged += new System.EventHandler(this.T_Apellido_TextChanged);
            // 
            // T_Nombre
            // 
            this.T_Nombre.Enabled = false;
            this.T_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_Nombre.Location = new System.Drawing.Point(89, 30);
            this.T_Nombre.Name = "T_Nombre";
            this.T_Nombre.Size = new System.Drawing.Size(170, 22);
            this.T_Nombre.TabIndex = 4;
            this.T_Nombre.TextChanged += new System.EventHandler(this.T_Nombre_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mail:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dirección:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Alta_Contacto
            // 
            this.Alta_Contacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Alta_Contacto.Location = new System.Drawing.Point(186, 217);
            this.Alta_Contacto.Name = "Alta_Contacto";
            this.Alta_Contacto.Size = new System.Drawing.Size(147, 36);
            this.Alta_Contacto.TabIndex = 2;
            this.Alta_Contacto.Text = "Agregar Contacto";
            this.Alta_Contacto.UseVisualStyleBackColor = true;
            this.Alta_Contacto.Click += new System.EventHandler(this.Alta_Contacto_Click);
            // 
            // Modificar
            // 
            this.Modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modificar.Location = new System.Drawing.Point(339, 217);
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(147, 36);
            this.Modificar.TabIndex = 3;
            this.Modificar.Text = "Modificar Contacto";
            this.Modificar.UseVisualStyleBackColor = true;
            this.Modificar.Click += new System.EventHandler(this.Modificar_Click);
            // 
            // Eliminar_Contacto
            // 
            this.Eliminar_Contacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eliminar_Contacto.Location = new System.Drawing.Point(492, 217);
            this.Eliminar_Contacto.Name = "Eliminar_Contacto";
            this.Eliminar_Contacto.Size = new System.Drawing.Size(147, 36);
            this.Eliminar_Contacto.TabIndex = 4;
            this.Eliminar_Contacto.Text = "Eliminar Contacto";
            this.Eliminar_Contacto.UseVisualStyleBackColor = true;
            this.Eliminar_Contacto.Click += new System.EventHandler(this.Eliminar_Contacto_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(645, 217);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(70, 36);
            this.button4.TabIndex = 5;
            this.button4.Text = "Volver";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Buscador
            // 
            this.Buscador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscador.Location = new System.Drawing.Point(186, 16);
            this.Buscador.Name = "Buscador";
            this.Buscador.Size = new System.Drawing.Size(466, 22);
            this.Buscador.TabIndex = 6;
            this.Buscador.TextChanged += new System.EventHandler(this.Buscador_TextChanged);
            this.Buscador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Buscador_KeyPress);
            // 
            // Agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(727, 270);
            this.Controls.Add(pictureBox1);
            this.Controls.Add(this.Buscador);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Eliminar_Contacto);
            this.Controls.Add(this.Modificar);
            this.Controls.Add(this.Alta_Contacto);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Listado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Agenda";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda";
            this.TransparencyKey = System.Drawing.Color.DimGray;
            this.Load += new System.EventHandler(this.Agenda_Load);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Listado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox T_Nombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox T_Mail;
        private System.Windows.Forms.TextBox T_Direccion;
        private System.Windows.Forms.TextBox T_Apellido;
        private System.Windows.Forms.TextBox T_Telefono3;
        private System.Windows.Forms.TextBox T_Telefono2;
        private System.Windows.Forms.TextBox T_Telefono1;
        private System.Windows.Forms.Button Alta_Contacto;
        private System.Windows.Forms.Button Modificar;
        private System.Windows.Forms.Button Eliminar_Contacto;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox Buscador;
        private System.Windows.Forms.Label lbTipoContacto;
        private System.Windows.Forms.TextBox tbTipoContacto;
    }
}