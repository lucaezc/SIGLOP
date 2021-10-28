using System;

namespace Siglop
{
    partial class AltaContacto
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
            this.confirmarAlta = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.datos = new System.Windows.Forms.GroupBox();
            this.cbTipoContacto = new System.Windows.Forms.ComboBox();
            this.lbTipoContacto = new System.Windows.Forms.Label();
            this.telefono3 = new System.Windows.Forms.TextBox();
            this.telefono2 = new System.Windows.Forms.TextBox();
            this.telefono1 = new System.Windows.Forms.TextBox();
            this.lbtelefono = new System.Windows.Forms.Label();
            this.mail = new System.Windows.Forms.TextBox();
            this.lbMail = new System.Windows.Forms.Label();
            this.direccion = new System.Windows.Forms.TextBox();
            this.lbDireccion = new System.Windows.Forms.Label();
            this.apellido = new System.Windows.Forms.TextBox();
            this.lbApellido = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.datos.SuspendLayout();
            this.SuspendLayout();
            // 
            // confirmarAlta
            // 
            this.confirmarAlta.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.confirmarAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmarAlta.Location = new System.Drawing.Point(296, 208);
            this.confirmarAlta.Name = "confirmarAlta";
            this.confirmarAlta.Size = new System.Drawing.Size(151, 40);
            this.confirmarAlta.TabIndex = 2;
            this.confirmarAlta.Text = "Confirmar Alta";
            this.confirmarAlta.UseVisualStyleBackColor = true;
            this.confirmarAlta.Click += new System.EventHandler(this.confirmarAlta_Click);
            // 
            // cancelar
            // 
            this.cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelar.Location = new System.Drawing.Point(453, 208);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(151, 40);
            this.cancelar.TabIndex = 3;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // datos
            // 
            this.datos.Controls.Add(this.cbTipoContacto);
            this.datos.Controls.Add(this.lbTipoContacto);
            this.datos.Controls.Add(this.telefono3);
            this.datos.Controls.Add(this.telefono2);
            this.datos.Controls.Add(this.telefono1);
            this.datos.Controls.Add(this.lbtelefono);
            this.datos.Controls.Add(this.mail);
            this.datos.Controls.Add(this.lbMail);
            this.datos.Controls.Add(this.direccion);
            this.datos.Controls.Add(this.lbDireccion);
            this.datos.Controls.Add(this.apellido);
            this.datos.Controls.Add(this.lbApellido);
            this.datos.Controls.Add(this.nombre);
            this.datos.Controls.Add(this.lbNombre);
            this.datos.Location = new System.Drawing.Point(14, 24);
            this.datos.Name = "datos";
            this.datos.Padding = new System.Windows.Forms.Padding(10);
            this.datos.Size = new System.Drawing.Size(590, 178);
            this.datos.TabIndex = 0;
            this.datos.TabStop = false;
            // 
            // cbTipoContacto
            // 
            this.cbTipoContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoContacto.FormattingEnabled = true;
            this.cbTipoContacto.Location = new System.Drawing.Point(379, 127);
            this.cbTipoContacto.Name = "cbTipoContacto";
            this.cbTipoContacto.Size = new System.Drawing.Size(192, 24);
            this.cbTipoContacto.TabIndex = 13;
            // 
            // lbTipoContacto
            // 
            this.lbTipoContacto.AutoSize = true;
            this.lbTipoContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTipoContacto.Location = new System.Drawing.Point(301, 130);
            this.lbTipoContacto.Name = "lbTipoContacto";
            this.lbTipoContacto.Size = new System.Drawing.Size(39, 16);
            this.lbTipoContacto.TabIndex = 12;
            this.lbTipoContacto.Text = "Tipo:";
            // 
            // telefono3
            // 
            this.telefono3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefono3.Location = new System.Drawing.Point(379, 92);
            this.telefono3.Name = "telefono3";
            this.telefono3.Size = new System.Drawing.Size(192, 22);
            this.telefono3.TabIndex = 11;
            // 
            // telefono2
            // 
            this.telefono2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefono2.Location = new System.Drawing.Point(379, 57);
            this.telefono2.Name = "telefono2";
            this.telefono2.Size = new System.Drawing.Size(192, 22);
            this.telefono2.TabIndex = 10;
            // 
            // telefono1
            // 
            this.telefono1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefono1.Location = new System.Drawing.Point(379, 23);
            this.telefono1.Name = "telefono1";
            this.telefono1.Size = new System.Drawing.Size(192, 22);
            this.telefono1.TabIndex = 9;
            // 
            // lbtelefono
            // 
            this.lbtelefono.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lbtelefono.AutoSize = true;
            this.lbtelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtelefono.Location = new System.Drawing.Point(301, 26);
            this.lbtelefono.Name = "lbtelefono";
            this.lbtelefono.Size = new System.Drawing.Size(72, 16);
            this.lbtelefono.TabIndex = 8;
            this.lbtelefono.Text = "Teléfonos:";
            // 
            // mail
            // 
            this.mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mail.Location = new System.Drawing.Point(87, 127);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(192, 22);
            this.mail.TabIndex = 7;
            // 
            // lbMail
            // 
            this.lbMail.AutoSize = true;
            this.lbMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMail.Location = new System.Drawing.Point(13, 130);
            this.lbMail.Name = "lbMail";
            this.lbMail.Size = new System.Drawing.Size(36, 16);
            this.lbMail.TabIndex = 6;
            this.lbMail.Text = "Mail:";
            // 
            // direccion
            // 
            this.direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direccion.Location = new System.Drawing.Point(87, 92);
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(192, 22);
            this.direccion.TabIndex = 5;
            // 
            // lbDireccion
            // 
            this.lbDireccion.AllowDrop = true;
            this.lbDireccion.AutoSize = true;
            this.lbDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDireccion.Location = new System.Drawing.Point(13, 95);
            this.lbDireccion.Name = "lbDireccion";
            this.lbDireccion.Size = new System.Drawing.Size(68, 16);
            this.lbDireccion.TabIndex = 4;
            this.lbDireccion.Text = "Dirección:";
            // 
            // apellido
            // 
            this.apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellido.Location = new System.Drawing.Point(87, 60);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(192, 22);
            this.apellido.TabIndex = 3;
            this.apellido.TextChanged += new System.EventHandler(this.apellido_TextChanged);
            // 
            // lbApellido
            // 
            this.lbApellido.AutoSize = true;
            this.lbApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApellido.Location = new System.Drawing.Point(13, 60);
            this.lbApellido.Name = "lbApellido";
            this.lbApellido.Size = new System.Drawing.Size(61, 16);
            this.lbApellido.TabIndex = 2;
            this.lbApellido.Text = "Apellido:";
            // 
            // nombre
            // 
            this.nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(87, 23);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(192, 22);
            this.nombre.TabIndex = 1;
            this.nombre.TextChanged += new System.EventHandler(this.nombre_TextChanged);
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(13, 26);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(60, 16);
            this.lbNombre.TabIndex = 1;
            this.lbNombre.Text = "Nombre:";
            // 
            // AltaContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(620, 261);
            this.Controls.Add(this.confirmarAlta);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.datos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AltaContacto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Contacto";
            this.datos.ResumeLayout(false);
            this.datos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button confirmarAlta;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.GroupBox datos;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.TextBox apellido;
        private System.Windows.Forms.Label lbApellido;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.Label lbMail;
        private System.Windows.Forms.TextBox direccion;
        private System.Windows.Forms.Label lbDireccion;
        private System.Windows.Forms.TextBox telefono1;
        private System.Windows.Forms.Label lbtelefono;
        private System.Windows.Forms.TextBox telefono3;
        private System.Windows.Forms.TextBox telefono2;
        private System.Windows.Forms.ComboBox cbTipoContacto;
        private System.Windows.Forms.Label lbTipoContacto;

    }
}