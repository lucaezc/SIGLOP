using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Siglop
{
    public partial class GestionFlujoDeCaja : Form
    {
        private dbmanager db;
        private Decimal caja;
        public GestionFlujoDeCaja(dbmanager db)
        {
            InitializeComponent();
            this.db = db;
            CargaCombos();
            FlujoCajaIniciado();
            CargaEgresos();
            CargaIngresos();
        }

        private void CargaCombos() //CARGA LOS COMBOBOX
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT ID_DET_FLUJO_CAJA, DET_FLUJO_CAJA_DESCRIPCION FROM DETALLE_FLUJO_CAJA", this.db.StringConexion());
            da.Fill(ds, "SIGLOP.DETALLE_FLUJO_CAJA");
            this.cmbDetalleEgreso.DataSource = ds.Tables[0].DefaultView;
            this.cmbDetalleEgreso.DisplayMember = "DET_FLUJO_CAJA_DESCRIPCION";
            this.cmbDetalleEgreso.ValueMember = "ID_DET_FLUJO_CAJA";

            DataSet ds1 = new DataSet();
            SqlDataAdapter da1 = new SqlDataAdapter("SELECT ID_DET_FLUJO_CAJA, DET_FLUJO_CAJA_DESCRIPCION FROM DETALLE_FLUJO_CAJA", this.db.StringConexion());
            da1.Fill(ds1, "SIGLOP.DETALLE_FLUJO_CAJA");
            this.cmbDetalleIngreso.DataSource = ds1.Tables[0].DefaultView;
            this.cmbDetalleIngreso.DisplayMember = "DET_FLUJO_CAJA_DESCRIPCION";
            this.cmbDetalleIngreso.ValueMember = "ID_DET_FLUJO_CAJA";
        }

        private void FlujoCajaIniciado() //VERIFICA SI SE INICIÓ EL FLUJO DE CAJA O NO
        {
            DateTime fechaFlujoCaja = dtpFlujoCaja.Value.Date;
            Boolean existe = this.db.Consultar("SELECT ID_CAJA FROM CAJA WHERE CAJA_FECHA = '" + fechaFlujoCaja.ToString("yyyyMMdd") + "'");
            caja = 0;
            if (existe)
            {
                this.db.Leer();
                caja = Decimal.Parse(this.db.ObtenerValor("ID_CAJA"));
            }
            if (!caja.Equals(0))
            {
                // Flujo existente
                this.btIniciarFlujoCaja.Enabled = false;
                this.lbFCIniciado.Visible = true;
                CargaEgresos();
                CargaIngresos();
            }
            else
            {
                this.dgEgresos.Rows.Clear();
                this.dgIngresos.Rows.Clear();
                this.btIniciarFlujoCaja.Enabled = true;
                this.lbFCIniciado.Visible = false;
            }

        }

        private void CargaEgresos()
        {
            this.dgEgresos.Rows.Clear();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT ID_CAJA, ID_DETALLE, DETALLE_CANTIDAD, DET_FLUJO_CAJA_DESCRIPCION, DETALLE_OBSERVACION, DETALLE_MONTO FROM CAJA_DETALLE CD JOIN DETALLE_FLUJO_CAJA DFC ON CD.ID_DETALLE_FLUJO_CAJA = DFC.ID_DET_FLUJO_CAJA WHERE ID_CAJA = " + caja + " AND TIPO_MOVIMIENTO = 1", this.db.StringConexion());
            da.SelectCommand.CommandType = CommandType.Text;
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                this.dgEgresos.Rows.Add(dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString(), dt.Rows[i][3].ToString(), dt.Rows[i][4].ToString(), dt.Rows[i][5].ToString());
            }
        }

        private void CargaIngresos()
        {
            this.dgIngresos.Rows.Clear();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT ID_CAJA, ID_DETALLE, DETALLE_CANTIDAD, DET_FLUJO_CAJA_DESCRIPCION, DETALLE_OBSERVACION, DETALLE_MONTO FROM CAJA_DETALLE CD JOIN DETALLE_FLUJO_CAJA DFC ON CD.ID_DETALLE_FLUJO_CAJA = DFC.ID_DET_FLUJO_CAJA WHERE ID_CAJA = " + caja + " AND TIPO_MOVIMIENTO = 2", this.db.StringConexion());
            da.SelectCommand.CommandType = CommandType.Text;
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                this.dgIngresos.Rows.Add(dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString(), dt.Rows[i][3].ToString(), dt.Rows[i][4].ToString(), dt.Rows[i][5].ToString());
            }
        }

        private void GestionFlujoDeCaja_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarEgreso_Click(object sender, EventArgs e) //AGREGAR EGRESO
        {
            DateTime fechaFlujoCaja = dtpFlujoCaja.Value.Date;
            Boolean existe = this.db.Consultar("SELECT ID_CAJA FROM CAJA WHERE CAJA_FECHA = '" + fechaFlujoCaja.ToString("yyyyMMdd") + "'");
            caja = 0;
            if (existe)
            {
                this.db.Leer();
                caja = Decimal.Parse(this.db.ObtenerValor("ID_CAJA"));
            }
            if (!caja.Equals(0))
            {
                if (this.txtCantEgreso.Text.Equals(""))
                {
                    MessageBox.Show("Debe ingresar una cantidad para el egreso");
                    this.txtCantEgreso.Focus();
                }
                else
                {
                    if (this.txtObsEgresos.Text.Equals(""))
                    {
                        MessageBox.Show("Debe ingresar una observación para el egreso");
                        this.txtObsEgresos.Focus();
                    }
                    else
                    {
                        if (this.txtMontoEgresos.Text.Equals(""))
                        {
                            MessageBox.Show("Debe ingresar un monto para el egreso");
                            this.txtMontoEgresos.Focus();
                        }
                        else
                        {
                            Decimal cantidad = Decimal.Parse(txtCantEgreso.Text);
                            Decimal monto = Decimal.Parse(txtMontoEgresos.Text);
                            Decimal detalleFlujoCajaId = Decimal.Parse(cmbDetalleEgreso.SelectedValue.ToString());
                            String observacion = txtObsEgresos.Text;
                            this.db.Ejecutar("INSERT INTO CAJA_DETALLE (ID_CAJA, TIPO_MOVIMIENTO, ID_DETALLE_FLUJO_CAJA, DETALLE_CANTIDAD, DETALLE_MONTO, DETALLE_OBSERVACION) VALUES ("
                                             + caja + ",1," + detalleFlujoCajaId + "," + cantidad + "," + monto + ",'" + observacion + "')");
                            CargaEgresos();
                            txtCantEgreso.Text = "";
                            txtMontoEgresos.Text = "";
                            txtObsEgresos.Text = "";
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Antes de agregar un egreso debe iniciar un flujo de caja para el día de la fecha ingresada.");
            }
        }

        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btIniciarFlujoCaja_Click(object sender, EventArgs e)
        {
            DateTime fechaFlujoCaja = dtpFlujoCaja.Value.Date;
            this.db.Ejecutar("INSERT INTO CAJA (CAJA_FECHA) VALUES ('" + fechaFlujoCaja.ToString("yyyyMMdd") + "')");
            this.btIniciarFlujoCaja.Enabled = false;
            this.lbFCIniciado.Visible = true;
            this.dtpFlujoCaja.Enabled = false;
        }

        private void btnAgregarIngreso_Click(object sender, EventArgs e) //AGREGAR INGRESO
        {
            DateTime fechaFlujoCaja = dtpFlujoCaja.Value.Date;
            Boolean existe = this.db.Consultar("SELECT ID_CAJA FROM CAJA WHERE CAJA_FECHA = '" + fechaFlujoCaja.ToString("yyyyMMdd") + "'");
            caja = 0;
            if (existe)
            {
                this.db.Leer();
                caja = Decimal.Parse(this.db.ObtenerValor("ID_CAJA"));
            }
            if (!caja.Equals(0))
            {
                if (this.txtCantIngreso.Text.Equals(""))
                {
                    MessageBox.Show("Debe ingresar una cantidad para el ingreso");
                    this.txtCantIngreso.Focus();
                }
                else
                {
                    if (this.txtObsIngreso.Text.Equals(""))
                    {
                        MessageBox.Show("Debe ingresar una observación para el ingreso");
                        this.txtObsIngreso.Focus();
                    }
                    else
                    {
                        if (this.txtMontoIngreso.Text.Equals(""))
                        {
                            MessageBox.Show("Debe ingresar un monto para el ingreso");
                            this.txtMontoIngreso.Focus();
                        }
                        else
                        {
                            Decimal cantidad = Decimal.Parse(txtCantIngreso.Text);
                            Decimal monto = Decimal.Parse(txtMontoIngreso.Text);
                            Decimal detalleFlujoCajaId = Decimal.Parse(cmbDetalleIngreso.SelectedValue.ToString());
                            String observacion = txtObsIngreso.Text;
                            this.db.Ejecutar("INSERT INTO CAJA_DETALLE (ID_CAJA, TIPO_MOVIMIENTO, ID_DETALLE_FLUJO_CAJA, DETALLE_CANTIDAD, DETALLE_MONTO, DETALLE_OBSERVACION) VALUES ("
                                             + caja + ",2," + detalleFlujoCajaId + "," + cantidad + "," + monto + ",'" + observacion + "')");
                            CargaIngresos();
                            txtCantIngreso.Text = "";
                            txtMontoIngreso.Text = "";
                            txtObsIngreso.Text = "";
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Antes de agregar un ingreso debe iniciar un flujo de caja para el día de la fecha ingresada.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e) // ELIMINAR SELECCIONADOS
        {
            foreach (DataGridViewRow row in this.dgEgresos.SelectedRows)
            {
                Int32 fila = this.dgEgresos.CurrentCell.RowIndex;

                Decimal idCaja = Decimal.Parse(this.dgEgresos.Rows[fila].Cells[0].Value.ToString());
                Decimal idDetalle = Decimal.Parse(this.dgEgresos.Rows[fila].Cells[1].Value.ToString());

                this.dgEgresos.Rows.RemoveAt(this.dgEgresos.CurrentRow.Index);
                
                this.db.Ejecutar("DELETE CAJA_DETALLE WHERE ID_DETALLE = " + idDetalle + " AND ID_CAJA = " + idCaja);
            }

            CargaEgresos();

            foreach (DataGridViewRow row in this.dgIngresos.SelectedRows)
            {
                Int32 fila = this.dgIngresos.CurrentCell.RowIndex;

                Decimal idCaja = Decimal.Parse(this.dgIngresos.Rows[fila].Cells[0].Value.ToString());
                Decimal idDetalle = Decimal.Parse(this.dgIngresos.Rows[fila].Cells[1].Value.ToString());

                this.dgIngresos.Rows.RemoveAt(this.dgIngresos.CurrentRow.Index);

                this.db.Ejecutar("DELETE CAJA_DETALLE WHERE ID_DETALLE = " + idDetalle + " AND ID_CAJA = " + idCaja);
            }

            CargaIngresos();
        }

        private void dtpFlujoCaja_ValueChanged(object sender, EventArgs e)
        {
            FlujoCajaIniciado();
        }
    }
}
