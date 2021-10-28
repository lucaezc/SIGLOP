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
    public partial class Reportes : Form
    {
        private dbmanager db;
        public Reportes(dbmanager db)
        {
            InitializeComponent();
            this.db = db;
            CargarCombos();
        }

        private void CargarCombos()
        {
            Dictionary<string, string> cmbMensualSource = new Dictionary<string, string>();
            cmbMensualSource.Add("112016", "Noviembre 2016");
            cmbMensualSource.Add("102016", "Octubre 2016");
            cmbMensualSource.Add("092016", "Septiembre 2016");

            cmbFlujosMensual.DataSource = new BindingSource(cmbMensualSource, null); cmbFlujosMensual.DisplayMember = "Value"; cmbFlujosMensual.ValueMember = "Key";

            Dictionary<string, string> cmbAnualSource = new Dictionary<string, string>();
            cmbAnualSource.Add("2016", "2016");
            cmbAnualSource.Add("2015", "2015");

            cmbFlujosAnual.DataSource = new BindingSource(cmbAnualSource, null); cmbFlujosAnual.DisplayMember = "Value"; cmbFlujosAnual.ValueMember = "Key";

        }

        private void Reportes_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) // CHECKBOX STOCK
        {
            if (cbStock.Checked == true)
            {
                cbStock.Enabled = false;
                cbFlujosDeCaja.Checked = false;
                cbFlujosDiario.Checked = false;
                cbFlujosMensual.Checked = false;
                cbFlujosAnual.Checked = false;
                cbFlujosDiario.Enabled = false;
                cbFlujosMensual.Enabled = false;
                cbFlujosAnual.Enabled = false;
                dtpFlujosDiario.Enabled = false;
                cmbFlujosMensual.Enabled = false;
                cmbFlujosAnual.Enabled = false;
                cbMateriaPrima.Enabled = true;
                cbProductosTerminados.Enabled = true;
            }
            else
            {
                cbStock.Enabled = true;
                cbStock.Checked = false;
                cbMateriaPrima.Checked = false;
                cbProductosTerminados.Checked = false;
                cbMateriaPrima.Enabled = false;
                cbProductosTerminados.Enabled = false;
                cbFlujosDiario.Enabled = true;
                cbFlujosMensual.Enabled = true;
                cbFlujosAnual.Enabled = true;
                dtpFlujosDiario.Enabled = true;
                cmbFlujosMensual.Enabled = true;
                cmbFlujosAnual.Enabled = true;
            }
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e) // CHECKBOX FLUJOS DE CAJA
        {
            if (cbFlujosDeCaja.Checked == true)
            {
                cbFlujosDeCaja.Enabled = false;
                cbStock.Checked = false;
                cbMateriaPrima.Checked = false;
                cbProductosTerminados.Checked = false;
                cbMateriaPrima.Enabled = false;
                cbProductosTerminados.Enabled = false;
                cbFlujosDiario.Enabled = true;
                cbFlujosMensual.Enabled = true;
                cbFlujosAnual.Enabled = true;
                dtpFlujosDiario.Enabled = true;
                cmbFlujosMensual.Enabled = true;
                cmbFlujosAnual.Enabled = true;
            }
            else
            {
                cbFlujosDeCaja.Enabled = true;
                cbFlujosDeCaja.Checked = false;
                cbFlujosDiario.Checked = false;
                cbFlujosMensual.Checked = false;
                cbFlujosAnual.Checked = false;
                cbFlujosDiario.Enabled = false;
                cbFlujosMensual.Enabled = false;
                cbFlujosAnual.Enabled = false;
                dtpFlujosDiario.Enabled = false;
                cmbFlujosMensual.Enabled = false;
                cmbFlujosAnual.Enabled = false;
                cbMateriaPrima.Enabled = true;
                cbProductosTerminados.Enabled = true;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e) // CHECKBOX PRODUCTOS TERMINADOS
        {
            cbMateriaPrima.Checked = false;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) // VOLVER
        {
            this.Dispose();
        }

        private void btGenerarReporte_Click(object sender, EventArgs e) // GENERAR REPORTE
        {
            String query = null;
            String tipoReporte = null;
            int nroReporte = 0;

            if (cbFlujosDeCaja.Checked == true) // REPORTE FLUJOS DE CAJA
            {
                tipoReporte = "Reporte Flujo de Caja";

                if (cbFlujosDiario.Checked == true)
                {
                    String fechaFlujoDiario = dtpFlujosDiario.Value.Date.ToString("yyyyMMdd");
                    String anio = fechaFlujoDiario.Substring(0, 4);
                    String mes = fechaFlujoDiario.Substring(4, 2);
                    String dia = fechaFlujoDiario.Substring(6, 2);
    
                    tipoReporte = tipoReporte + " Diario para el día " + dia + "/" + mes + "/" + anio;
                    nroReporte = 1;
                    query = "SELECT C.ID_CAJA, CD.ID_DETALLE, TM.DET_TIPO_MOVIMIENTO, CD.DETALLE_CANTIDAD, DTC.DET_FLUJO_CAJA_DESCRIPCION, CD.DETALLE_OBSERVACION, CD.DETALLE_MONTO FROM CAJA C " +
                            "JOIN CAJA_DETALLE CD ON C.ID_CAJA = CD.ID_CAJA JOIN DETALLE_FLUJO_CAJA DTC ON CD.ID_DETALLE_FLUJO_CAJA = DTC.ID_DET_FLUJO_CAJA " +
                            "JOIN TIPO_MOVIMIENTO TM ON CD.TIPO_MOVIMIENTO = TM.ID_TIPO_MOVIMIENTO WHERE C.CAJA_FECHA = '" + fechaFlujoDiario + "' ORDER BY TM.DET_TIPO_MOVIMIENTO";
                }

                if (cbFlujosMensual.Checked == true) 
                {
                    String fechaFlujoMensual = cmbFlujosMensual.SelectedValue.ToString();
                    String mes = fechaFlujoMensual.Substring(0, 2);
                    String anio = fechaFlujoMensual.Substring(2, 4);

                    tipoReporte = tipoReporte + " Mensual para el mes " + mes + " del año " + anio;
                    nroReporte = 2;
                    query = "SELECT C.ID_CAJA, CD.ID_DETALLE, TM.DET_TIPO_MOVIMIENTO, CD.DETALLE_CANTIDAD, DTC.DET_FLUJO_CAJA_DESCRIPCION, CD.DETALLE_OBSERVACION, CD.DETALLE_MONTO FROM CAJA C " +
                    "JOIN CAJA_DETALLE CD ON C.ID_CAJA = CD.ID_CAJA JOIN DETALLE_FLUJO_CAJA DTC ON CD.ID_DETALLE_FLUJO_CAJA = DTC.ID_DET_FLUJO_CAJA " +
                    "JOIN TIPO_MOVIMIENTO TM ON CD.TIPO_MOVIMIENTO = TM.ID_TIPO_MOVIMIENTO WHERE MONTH(C.CAJA_FECHA) = '" + mes + "' AND YEAR(C.CAJA_FECHA) = '" + anio + "' ORDER BY TM.DET_TIPO_MOVIMIENTO";
                }

                if (cbFlujosAnual.Checked == true)
                {
                    String anio = cmbFlujosAnual.SelectedValue.ToString();

                    tipoReporte = tipoReporte + " Anual para el año " + anio;
                    nroReporte = 3;
                    query = "SELECT C.ID_CAJA, CD.ID_DETALLE, TM.DET_TIPO_MOVIMIENTO, CD.DETALLE_CANTIDAD, DTC.DET_FLUJO_CAJA_DESCRIPCION, CD.DETALLE_OBSERVACION, CD.DETALLE_MONTO FROM CAJA C " +
                    "JOIN CAJA_DETALLE CD ON C.ID_CAJA = CD.ID_CAJA JOIN DETALLE_FLUJO_CAJA DTC ON CD.ID_DETALLE_FLUJO_CAJA = DTC.ID_DET_FLUJO_CAJA " +
                    "JOIN TIPO_MOVIMIENTO TM ON CD.TIPO_MOVIMIENTO = TM.ID_TIPO_MOVIMIENTO WHERE YEAR(C.CAJA_FECHA) = '" + anio + "' ORDER BY TM.DET_TIPO_MOVIMIENTO";
                }
            }

            if (cbStock.Checked == true) // REPORTE STOCK
            {
                tipoReporte = "Reporte Stock";

                if (cbMateriaPrima.Checked == true)
                {
                    tipoReporte = tipoReporte + " de Materias Primas";
                    nroReporte = 4;
                    query = "SELECT ID_MATERIA_PRIMA, MATERIA_PRIMA_DESCRIPCION, MATERIA_PRIMA_CANTIDAD FROM MATERIA_PRIMA";
                }

                if (cbProductosTerminados.Checked == true)
                {
                    tipoReporte = tipoReporte + " de Productos Terminados";
                    nroReporte = 5;
                    query = "SELECT PTC.ID_PRODUCTO, P.PRODUCTO_DESCRIPCION, P.PRODUCTO_COLECCION ,T.TALLE_DESCRIPCION, C.COLOR_DESCRIPCION, PTC.PRODUCTO_STOCK " +
                            "FROM PRODUCTO_TALLE_COLOR PTC JOIN PRODUCTO P ON PTC.ID_PRODUCTO = P.ID_PRODUCTO " +
                            "JOIN COLOR C ON PTC.ID_COLOR = C.ID_COLOR JOIN TALLE T ON PTC.ID_TALLE = T.ID_TALLE";
                }
            }

            if (query != null)
            {
                ReporteGenerado r = new ReporteGenerado(this.db, query, tipoReporte, nroReporte);
                r.Show();
            }
            else
            {
                MessageBox.Show("Elija un tipo de reporte: Stock o Flujos de Caja");
            }
        }

        private void cbFlujosDiario_CheckedChanged(object sender, EventArgs e) // CHECKBOX FLUJOS DE CAJA DIARIO
        {
            cbFlujosMensual.Checked = false;
            cbFlujosAnual.Checked = false;
        }

        private void cbFlujosMensual_CheckedChanged(object sender, EventArgs e) // CHECKBOX FLUJOS DE CAJA MENSUAL
        {
            cbFlujosDiario.Checked = false;
            cbFlujosAnual.Checked = false;
        }

        private void cbFlujosAnual_CheckedChanged(object sender, EventArgs e) // CHECKBOX FLUJOS DE CAJA ANUAL
        {
            cbFlujosDiario.Checked = false;
            cbFlujosMensual.Checked = false;
        }

        private void cbMateriaPrima_CheckedChanged(object sender, EventArgs e) // CHECKBOX MATERIA PRIMA
        {
            cbProductosTerminados.Checked = false;
        }
    }
}
