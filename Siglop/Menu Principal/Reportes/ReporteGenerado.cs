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
    public partial class ReporteGenerado : Form
    {
        private dbmanager db;
        private String query, tipoReporte;
        private int nroReporte;
        public ReporteGenerado(dbmanager db, String query, String tipoReporte, int nroReporte)
        {
            InitializeComponent();
            this.db = db;
            this.query = query;
            this.tipoReporte = tipoReporte;
            this.nroReporte = nroReporte;

            lbReporteNombre.Text = this.tipoReporte;
            CargaReporte();
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void CargaReporte()
        {
            this.dgReporteFlujosCaja.Rows.Clear();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(this.query, this.db.StringConexion());
            da.SelectCommand.CommandType = CommandType.Text;
            da.Fill(dt);

            switch (this.nroReporte)
            {
                case 1: // Reporte flujo de caja diario
                case 2: // Reporte flujo de caja mensual
                case 3: // Reporte flujo de caja anual
                    dgReporteFlujosCaja.Visible = true;
                    dgReporteMateriasPrimas.Visible = false;
                    dgReporteProductos.Visible = false;

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        this.dgReporteFlujosCaja.Rows.Add(dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString(), dt.Rows[i][3].ToString(), dt.Rows[i][4].ToString(), dt.Rows[i][5].ToString(), dt.Rows[i][6].ToString());
                    }

                    break;
                case 4: // Reporte stock materias primas
                    dgReporteMateriasPrimas.Visible = true;
                    dgReporteFlujosCaja.Visible = false;
                    dgReporteProductos.Visible = false;

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        this.dgReporteMateriasPrimas.Rows.Add(dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString());
                    }

                    break;
                case 5: // Reporte stock productos terminados
                    dgReporteProductos.Visible = true;
                    dgReporteMateriasPrimas.Visible = false;
                    dgReporteFlujosCaja.Visible = false;

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        this.dgReporteProductos.Rows.Add(dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString(), dt.Rows[i][3].ToString(), dt.Rows[i][4].ToString(), dt.Rows[i][5].ToString());
                    }

                    break;
                default:
                    break;
            }
        }
    }
}
