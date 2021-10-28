namespace Siglop
{
    partial class GestionFlujoDeCaja
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
            this.dgEgresos = new System.Windows.Forms.DataGridView();
            this.IdCaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblEgresos = new System.Windows.Forms.Label();
            this.lblIngresos = new System.Windows.Forms.Label();
            this.dgIngresos = new System.Windows.Forms.DataGridView();
            this.IdCajaI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdDetalle1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblAgregarEgreso = new System.Windows.Forms.Label();
            this.txtCantEgreso = new System.Windows.Forms.TextBox();
            this.cmbDetalleEgreso = new System.Windows.Forms.ComboBox();
            this.txtObsEgresos = new System.Windows.Forms.TextBox();
            this.txtMontoEgresos = new System.Windows.Forms.TextBox();
            this.btnAgregarEgreso = new System.Windows.Forms.Button();
            this.btnAgregarIngreso = new System.Windows.Forms.Button();
            this.txtMontoIngreso = new System.Windows.Forms.TextBox();
            this.txtObsIngreso = new System.Windows.Forms.TextBox();
            this.cmbDetalleIngreso = new System.Windows.Forms.ComboBox();
            this.txtCantIngreso = new System.Windows.Forms.TextBox();
            this.lblAgregarIngreso = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.gbInicioFlujoCaja = new System.Windows.Forms.GroupBox();
            this.lbFCIniciado = new System.Windows.Forms.Label();
            this.dtpFlujoCaja = new System.Windows.Forms.DateTimePicker();
            this.btIniciarFlujoCaja = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgEgresos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgIngresos)).BeginInit();
            this.gbInicioFlujoCaja.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgEgresos
            // 
            this.dgEgresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEgresos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCaja,
            this.IdDetalle,
            this.Cantidad,
            this.Detalle,
            this.Observaciones,
            this.Monto});
            this.dgEgresos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgEgresos.Location = new System.Drawing.Point(26, 122);
            this.dgEgresos.Name = "dgEgresos";
            this.dgEgresos.Size = new System.Drawing.Size(882, 85);
            this.dgEgresos.TabIndex = 2;
            // 
            // IdCaja
            // 
            this.IdCaja.HeaderText = "IdCaja";
            this.IdCaja.Name = "IdCaja";
            this.IdCaja.Visible = false;
            // 
            // IdDetalle
            // 
            this.IdDetalle.HeaderText = "IdDetalle";
            this.IdDetalle.Name = "IdDetalle";
            this.IdDetalle.Visible = false;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Detalle
            // 
            this.Detalle.HeaderText = "Detalle";
            this.Detalle.Name = "Detalle";
            this.Detalle.Width = 300;
            // 
            // Observaciones
            // 
            this.Observaciones.HeaderText = "Observaciones";
            this.Observaciones.Name = "Observaciones";
            this.Observaciones.Width = 300;
            // 
            // Monto
            // 
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            this.Monto.Width = 125;
            // 
            // lblEgresos
            // 
            this.lblEgresos.AutoSize = true;
            this.lblEgresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEgresos.Location = new System.Drawing.Point(22, 99);
            this.lblEgresos.Name = "lblEgresos";
            this.lblEgresos.Size = new System.Drawing.Size(75, 20);
            this.lblEgresos.TabIndex = 3;
            this.lblEgresos.Text = "Egresos";
            // 
            // lblIngresos
            // 
            this.lblIngresos.AutoSize = true;
            this.lblIngresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresos.Location = new System.Drawing.Point(22, 264);
            this.lblIngresos.Name = "lblIngresos";
            this.lblIngresos.Size = new System.Drawing.Size(79, 20);
            this.lblIngresos.TabIndex = 5;
            this.lblIngresos.Text = "Ingresos";
            // 
            // dgIngresos
            // 
            this.dgIngresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgIngresos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCajaI,
            this.IdDetalle1,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgIngresos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgIngresos.Location = new System.Drawing.Point(28, 286);
            this.dgIngresos.Name = "dgIngresos";
            this.dgIngresos.Size = new System.Drawing.Size(880, 85);
            this.dgIngresos.TabIndex = 4;
            // 
            // IdCajaI
            // 
            this.IdCajaI.HeaderText = "IdCaja";
            this.IdCajaI.Name = "IdCajaI";
            this.IdCajaI.Visible = false;
            // 
            // IdDetalle1
            // 
            this.IdDetalle1.HeaderText = "IdDetalle";
            this.IdDetalle1.Name = "IdDetalle1";
            this.IdDetalle1.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Detalle";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 300;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Observaciones";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 300;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Monto";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(833, 416);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 41);
            this.btnVolver.TabIndex = 6;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click_1);
            // 
            // lblAgregarEgreso
            // 
            this.lblAgregarEgreso.AutoSize = true;
            this.lblAgregarEgreso.Location = new System.Drawing.Point(25, 218);
            this.lblAgregarEgreso.Name = "lblAgregarEgreso";
            this.lblAgregarEgreso.Size = new System.Drawing.Size(44, 13);
            this.lblAgregarEgreso.TabIndex = 7;
            this.lblAgregarEgreso.Text = "Agregar";
            // 
            // txtCantEgreso
            // 
            this.txtCantEgreso.Location = new System.Drawing.Point(76, 215);
            this.txtCantEgreso.Name = "txtCantEgreso";
            this.txtCantEgreso.Size = new System.Drawing.Size(78, 20);
            this.txtCantEgreso.TabIndex = 8;
            // 
            // cmbDetalleEgreso
            // 
            this.cmbDetalleEgreso.FormattingEnabled = true;
            this.cmbDetalleEgreso.Location = new System.Drawing.Point(159, 215);
            this.cmbDetalleEgreso.Name = "cmbDetalleEgreso";
            this.cmbDetalleEgreso.Size = new System.Drawing.Size(248, 21);
            this.cmbDetalleEgreso.TabIndex = 9;
            this.cmbDetalleEgreso.Text = "Detalle";
            // 
            // txtObsEgresos
            // 
            this.txtObsEgresos.Location = new System.Drawing.Point(413, 215);
            this.txtObsEgresos.Name = "txtObsEgresos";
            this.txtObsEgresos.Size = new System.Drawing.Size(308, 20);
            this.txtObsEgresos.TabIndex = 10;
            // 
            // txtMontoEgresos
            // 
            this.txtMontoEgresos.Location = new System.Drawing.Point(727, 215);
            this.txtMontoEgresos.Name = "txtMontoEgresos";
            this.txtMontoEgresos.Size = new System.Drawing.Size(132, 20);
            this.txtMontoEgresos.TabIndex = 11;
            // 
            // btnAgregarEgreso
            // 
            this.btnAgregarEgreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarEgreso.Location = new System.Drawing.Point(865, 213);
            this.btnAgregarEgreso.Name = "btnAgregarEgreso";
            this.btnAgregarEgreso.Size = new System.Drawing.Size(43, 23);
            this.btnAgregarEgreso.TabIndex = 12;
            this.btnAgregarEgreso.Text = "+";
            this.btnAgregarEgreso.UseVisualStyleBackColor = true;
            this.btnAgregarEgreso.Click += new System.EventHandler(this.btnAgregarEgreso_Click);
            // 
            // btnAgregarIngreso
            // 
            this.btnAgregarIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarIngreso.Location = new System.Drawing.Point(865, 377);
            this.btnAgregarIngreso.Name = "btnAgregarIngreso";
            this.btnAgregarIngreso.Size = new System.Drawing.Size(43, 23);
            this.btnAgregarIngreso.TabIndex = 18;
            this.btnAgregarIngreso.Text = "+";
            this.btnAgregarIngreso.UseVisualStyleBackColor = true;
            this.btnAgregarIngreso.Click += new System.EventHandler(this.btnAgregarIngreso_Click);
            // 
            // txtMontoIngreso
            // 
            this.txtMontoIngreso.Location = new System.Drawing.Point(727, 379);
            this.txtMontoIngreso.Name = "txtMontoIngreso";
            this.txtMontoIngreso.Size = new System.Drawing.Size(132, 20);
            this.txtMontoIngreso.TabIndex = 17;
            // 
            // txtObsIngreso
            // 
            this.txtObsIngreso.Location = new System.Drawing.Point(413, 380);
            this.txtObsIngreso.Name = "txtObsIngreso";
            this.txtObsIngreso.Size = new System.Drawing.Size(308, 20);
            this.txtObsIngreso.TabIndex = 16;
            // 
            // cmbDetalleIngreso
            // 
            this.cmbDetalleIngreso.FormattingEnabled = true;
            this.cmbDetalleIngreso.Location = new System.Drawing.Point(159, 380);
            this.cmbDetalleIngreso.Name = "cmbDetalleIngreso";
            this.cmbDetalleIngreso.Size = new System.Drawing.Size(248, 21);
            this.cmbDetalleIngreso.TabIndex = 15;
            this.cmbDetalleIngreso.Text = "Detalle";
            // 
            // txtCantIngreso
            // 
            this.txtCantIngreso.Location = new System.Drawing.Point(76, 380);
            this.txtCantIngreso.Name = "txtCantIngreso";
            this.txtCantIngreso.Size = new System.Drawing.Size(78, 20);
            this.txtCantIngreso.TabIndex = 14;
            // 
            // lblAgregarIngreso
            // 
            this.lblAgregarIngreso.AutoSize = true;
            this.lblAgregarIngreso.Location = new System.Drawing.Point(26, 383);
            this.lblAgregarIngreso.Name = "lblAgregarIngreso";
            this.lblAgregarIngreso.Size = new System.Drawing.Size(44, 13);
            this.lblAgregarIngreso.TabIndex = 13;
            this.lblAgregarIngreso.Text = "Agregar";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(683, 416);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(138, 41);
            this.btnEliminar.TabIndex = 19;
            this.btnEliminar.Text = "Eliminar Seleccionados";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // gbInicioFlujoCaja
            // 
            this.gbInicioFlujoCaja.Controls.Add(this.lbFCIniciado);
            this.gbInicioFlujoCaja.Controls.Add(this.dtpFlujoCaja);
            this.gbInicioFlujoCaja.Controls.Add(this.btIniciarFlujoCaja);
            this.gbInicioFlujoCaja.Location = new System.Drawing.Point(26, 9);
            this.gbInicioFlujoCaja.Name = "gbInicioFlujoCaja";
            this.gbInicioFlujoCaja.Size = new System.Drawing.Size(882, 72);
            this.gbInicioFlujoCaja.TabIndex = 20;
            this.gbInicioFlujoCaja.TabStop = false;
            // 
            // lbFCIniciado
            // 
            this.lbFCIniciado.AutoSize = true;
            this.lbFCIniciado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFCIniciado.Location = new System.Drawing.Point(446, 32);
            this.lbFCIniciado.Name = "lbFCIniciado";
            this.lbFCIniciado.Size = new System.Drawing.Size(222, 15);
            this.lbFCIniciado.TabIndex = 2;
            this.lbFCIniciado.Text = "Flujo de caja ya iniciado para esa fecha";
            this.lbFCIniciado.Visible = false;
            // 
            // dtpFlujoCaja
            // 
            this.dtpFlujoCaja.Location = new System.Drawing.Point(20, 32);
            this.dtpFlujoCaja.Name = "dtpFlujoCaja";
            this.dtpFlujoCaja.Size = new System.Drawing.Size(216, 20);
            this.dtpFlujoCaja.TabIndex = 1;
            this.dtpFlujoCaja.ValueChanged += new System.EventHandler(this.dtpFlujoCaja_ValueChanged);
            // 
            // btIniciarFlujoCaja
            // 
            this.btIniciarFlujoCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIniciarFlujoCaja.Location = new System.Drawing.Point(252, 17);
            this.btIniciarFlujoCaja.Name = "btIniciarFlujoCaja";
            this.btIniciarFlujoCaja.Size = new System.Drawing.Size(178, 47);
            this.btIniciarFlujoCaja.TabIndex = 0;
            this.btIniciarFlujoCaja.Text = "Iniciar flujo de caja del día";
            this.btIniciarFlujoCaja.UseVisualStyleBackColor = true;
            this.btIniciarFlujoCaja.Click += new System.EventHandler(this.btIniciarFlujoCaja_Click);
            // 
            // GestionFlujoDeCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 472);
            this.Controls.Add(this.gbInicioFlujoCaja);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregarIngreso);
            this.Controls.Add(this.txtMontoIngreso);
            this.Controls.Add(this.txtObsIngreso);
            this.Controls.Add(this.cmbDetalleIngreso);
            this.Controls.Add(this.txtCantIngreso);
            this.Controls.Add(this.lblAgregarIngreso);
            this.Controls.Add(this.btnAgregarEgreso);
            this.Controls.Add(this.txtMontoEgresos);
            this.Controls.Add(this.txtObsEgresos);
            this.Controls.Add(this.cmbDetalleEgreso);
            this.Controls.Add(this.txtCantEgreso);
            this.Controls.Add(this.lblAgregarEgreso);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblIngresos);
            this.Controls.Add(this.dgIngresos);
            this.Controls.Add(this.lblEgresos);
            this.Controls.Add(this.dgEgresos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GestionFlujoDeCaja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión del Flujo de Caja";
            ((System.ComponentModel.ISupportInitialize)(this.dgEgresos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgIngresos)).EndInit();
            this.gbInicioFlujoCaja.ResumeLayout(false);
            this.gbInicioFlujoCaja.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgEgresos;
        private System.Windows.Forms.Label lblEgresos;
        private System.Windows.Forms.Label lblIngresos;
        private System.Windows.Forms.DataGridView dgIngresos;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblAgregarEgreso;
        private System.Windows.Forms.TextBox txtCantEgreso;
        private System.Windows.Forms.ComboBox cmbDetalleEgreso;
        private System.Windows.Forms.TextBox txtObsEgresos;
        private System.Windows.Forms.TextBox txtMontoEgresos;
        private System.Windows.Forms.Button btnAgregarEgreso;
        private System.Windows.Forms.Button btnAgregarIngreso;
        private System.Windows.Forms.TextBox txtMontoIngreso;
        private System.Windows.Forms.TextBox txtObsIngreso;
        private System.Windows.Forms.ComboBox cmbDetalleIngreso;
        private System.Windows.Forms.TextBox txtCantIngreso;
        private System.Windows.Forms.Label lblAgregarIngreso;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox gbInicioFlujoCaja;
        private System.Windows.Forms.DateTimePicker dtpFlujoCaja;
        private System.Windows.Forms.Button btIniciarFlujoCaja;
        private System.Windows.Forms.Label lbFCIniciado;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCajaI;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDetalle1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}