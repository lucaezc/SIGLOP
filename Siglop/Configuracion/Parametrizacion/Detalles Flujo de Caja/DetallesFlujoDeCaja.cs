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
    public partial class DetallesFlujoDeCaja : Form
    {
        private dbmanager db;
        private string D_ID= "0";
        public DetallesFlujoDeCaja(dbmanager db)
         {
            InitializeComponent();
            this.db = db;
            this.CargaTabla(this.db);

            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(this.txtDetalle, "Ingrese un detalle de flujo de caja.");
        }

        private void CargaTabla(dbmanager db)
        {
            Boolean existe = new Boolean();
            existe = this.db.Consultar("SELECT ID_DET_FLUJO_CAJA, DET_FLUJO_CAJA_DESCRIPCION FROM DETALLE_FLUJO_CAJA");
            
            if (existe)
            {
                while (this.db.Leer())
                {
                    this.dataGridViewD.Rows.Add(false, this.db.ObtenerValor("DET_FLUJO_CAJA_DESCRIPCION"));
                }
            }
        }

        private void dataGridViewD_Refrescar()
        {
            this.dataGridViewD.Rows.Clear();
            this.db.Consultar("SELECT ID_DET_FLUJO_CAJA, DET_FLUJO_CAJA_DESCRIPCION FROM DETALLE_FLUJO_CAJA");
            
            while (this.db.Leer())
            {
                this.dataGridViewD.Rows.Add(false, this.db.ObtenerValor("DET_FLUJO_CAJA_DESCRIPCION"));
            }
        }

        private void dataGridViewD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String Det = dataGridViewD.Rows[e.RowIndex].Cells["Detalle"].Value.ToString();
            Boolean existe = this.db.Consultar("SELECT ID_DET_FLUJO_CAJA, DET_FLUJO_CAJA_DESCRIPCION FROM DETALLE_FLUJO_CAJA WHERE DET_FLUJO_CAJA_DESCRIPCION='" + Det + "'");


            if (existe)
            {
                this.db.Leer();
                D_ID = this.db.ObtenerValor("ID_DET_FLUJO_CAJA");
            }
        }

        private void dataGridViewD_LimpiarCampos()
        {
            txtDetalle.Text = "";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string D_Descripcion = txtDetalle.Text;

            Boolean existe = this.db.Consultar("SELECT ID_DET_FLUJO_CAJA, DET_FLUJO_CAJA_DESCRIPCION FROM DETALLE_FLUJO_CAJA WHERE DET_FLUJO_CAJA_DESCRIPCION='" + D_Descripcion + "'");
            
            if ((D_Descripcion != "") && (!existe))
            {
              string message =
                "¿Está seguro de que quiere agregar el detalle de caja: " + D_Descripcion + "?";
              const string caption = "Agregar Detalle de caja.";
              var result = MessageBox.Show(message, caption,
                                           MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Question);

              if (result == DialogResult.Yes)
              {
                this.db.Ejecutar("INSERT INTO DETALLE_FLUJO_CAJA(DET_FLUJO_CAJA_DESCRIPCION) VALUES('"+ D_Descripcion +"')");
                dataGridViewD_Refrescar();
                dataGridViewD_LimpiarCampos();
                MessageBox.Show("El detalle se ha creado correctamente.");
               }
            }
            else
            {
                if ((D_Descripcion != "") && (existe))
                {
                    MessageBox.Show("El detalle ingresado ya se encuentra en el sistema.");
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese el nombre del detalle a agregar.");
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (D_ID != "0")
            {
                string MP_Descripcion = this.db.ObtenerValor("DET_FLUJO_CAJA_DESCRIPCION");
                string message =
                "¿Está seguro de que quiere eliminar el detalle: " + MP_Descripcion + "?";
                const string caption = "Borrar detalle de caja.";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    this.db.Ejecutar("DELETE DETALLE_FLUJO_CAJA WHERE ID_DET_FLUJO_CAJA = " + D_ID);
                    dataGridViewD_Refrescar();
                }

                D_ID = "0";
            }
            else
            {
                MessageBox.Show("Por favor, seleccionar solo un detalle.");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
