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
    public partial class ConsultaFlujoDeCaja : Form
    {
        private dbmanager db;
        public ConsultaFlujoDeCaja(dbmanager db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btConsultar_Click(object sender, EventArgs e) // CONSULTAR
        {
            DateTime fechaConsulta = dtpFechaConsulta.Value.Date;

            if (DateTime.Compare(fechaConsulta, DateTime.Today) > 0)
            {
                MessageBox.Show("No se puede consultar por fechas posteriores al día de hoy.");
            }
            else
            {
                this.dgEgresos.Rows.Clear();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT C.ID_CAJA, CD.ID_DETALLE, CD.DETALLE_CANTIDAD, DTC.DET_FLUJO_CAJA_DESCRIPCION, CD.DETALLE_OBSERVACION, CD.DETALLE_MONTO FROM CAJA C " +
                                                       "JOIN CAJA_DETALLE CD ON C.ID_CAJA = CD.ID_CAJA JOIN DETALLE_FLUJO_CAJA DTC ON CD.ID_DETALLE_FLUJO_CAJA = DTC.ID_DET_FLUJO_CAJA " +
                                                       "WHERE C.CAJA_FECHA = '" + fechaConsulta.ToString("yyyyMMdd") + "' AND TIPO_MOVIMIENTO = 1", this.db.StringConexion());
                da.SelectCommand.CommandType = CommandType.Text;
                da.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    this.dgEgresos.Rows.Add(dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString(), dt.Rows[i][3].ToString(), dt.Rows[i][4].ToString(), dt.Rows[i][5].ToString());
                }

                this.dgIngresos.Rows.Clear();
                DataTable dt1 = new DataTable();
                SqlDataAdapter da1 = new SqlDataAdapter("SELECT C.ID_CAJA, CD.ID_DETALLE, CD.DETALLE_CANTIDAD, DTC.DET_FLUJO_CAJA_DESCRIPCION, CD.DETALLE_OBSERVACION, CD.DETALLE_MONTO FROM CAJA C " +
                                                        "JOIN CAJA_DETALLE CD ON C.ID_CAJA = CD.ID_CAJA JOIN DETALLE_FLUJO_CAJA DTC ON CD.ID_DETALLE_FLUJO_CAJA = DTC.ID_DET_FLUJO_CAJA " +
                                                        "WHERE C.CAJA_FECHA = '" + fechaConsulta.ToString("yyyyMMdd") + "' AND TIPO_MOVIMIENTO = 2", this.db.StringConexion());
                da1.SelectCommand.CommandType = CommandType.Text;
                da1.Fill(dt1);
                for (int i = 0; i < dt1.Rows.Count; i++)
                {
                    this.dgIngresos.Rows.Add(dt1.Rows[i][0].ToString(), dt1.Rows[i][1].ToString(), dt1.Rows[i][2].ToString(), dt1.Rows[i][3].ToString(), dt1.Rows[i][4].ToString(), dt1.Rows[i][5].ToString());
                }

                if (this.dgEgresos.Rows.Count == 1 && this.dgIngresos.Rows.Count == 1)
                {
                    MessageBox.Show("Para la fecha indicada no se registra ningún flujo de caja.");
                }
            }
        }
    }
}
