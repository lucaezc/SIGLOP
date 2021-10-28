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
    public partial class MateriasPrimas : Form
    {
        private dbmanager db;
        private string MP_ID = "0";
        public MateriasPrimas(dbmanager db)
        {
            InitializeComponent();
            this.db = db;
            this.CargaTabla(this.db);

            ToolTip tooltip1 = new ToolTip();
            tooltip1.SetToolTip(this.txtDetalle, "Ingrese una materia prima.");
            ToolTip tooltip2 = new ToolTip();
            tooltip2.SetToolTip(this.txtCantidad, "Ingrese la cantidad númerica.");
            ToolTip tooltip3 = new ToolTip();
            tooltip3.SetToolTip(this.txtPrecio, "Ingrese el precio utilizando un punto para centavos.");        
        }

        private void CargaTabla(dbmanager db)
        {
            Boolean existe = new Boolean();
            existe = this.db.Consultar("SELECT MATERIA_PRIMA_DESCRIPCION, ID_MATERIA_PRIMA FROM MATERIA_PRIMA");

            if (existe)
            {
                while (this.db.Leer())
                {
                    this.dataGridViewMP.Rows.Add(false, this.db.ObtenerValor("MATERIA_PRIMA_DESCRIPCION"));
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MP_ID != "0")
            {
                string MP_Descripcion = this.db.ObtenerValor("MATERIA_PRIMA_DESCRIPCION"); 
                string message =
                "¿Está seguro de que quiere eliminar la materia prima: " + MP_Descripcion + "?";
                const string caption = "Borrar materia prima.";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    this.db.Ejecutar("DELETE MATERIA_PRIMA WHERE ID_MATERIA_PRIMA = " + MP_ID);
                    dataGridViewMP_Refrescar();
                }
                MP_ID = "0";
            }
            else
            {
                MessageBox.Show("Por favor, seleccionar solo una Materia Prima.");
            }
        }

        private void dataGridViewMP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String MP = dataGridViewMP.Rows[e.RowIndex].Cells["Detalle"].Value.ToString();
            //String MP = matprima.Substring(8, matprima.Length - 8);
            Boolean existe = this.db.Consultar("SELECT MATERIA_PRIMA_DESCRIPCION, ID_MATERIA_PRIMA FROM MATERIA_PRIMA WHERE MATERIA_PRIMA_DESCRIPCION='"+ MP+"'");
            
            if (existe)
            {
                this.db.Leer();
                MP_ID = this.db.ObtenerValor("ID_MATERIA_PRIMA");
            }

        }

        private void dataGridViewMP_Refrescar()
        {
            this.dataGridViewMP.Rows.Clear();
            this.db.Consultar("SELECT MATERIA_PRIMA_DESCRIPCION, ID_MATERIA_PRIMA FROM MATERIA_PRIMA");
            
            while (this.db.Leer())
            {
                this.dataGridViewMP.Rows.Add(false, this.db.ObtenerValor("MATERIA_PRIMA_DESCRIPCION"));
            }
        }

        private void dataGridViewMP_LimpiarCampos()
        {
            txtDetalle.Text = "";
            txtCantidad.Text = "";
            txtPrecio.Text = "";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string MP_Descripcion = txtDetalle.Text;
            string MP_Cantidad = txtCantidad.Text;
            string MP_Precio = txtPrecio.Text;

            Boolean existe = this.db.Consultar("SELECT MATERIA_PRIMA_DESCRIPCION, ID_MATERIA_PRIMA FROM MATERIA_PRIMA WHERE MATERIA_PRIMA_DESCRIPCION='" + MP_Descripcion+"'");

            if ((MP_Descripcion != "") && (!existe))
            {
                if ((MP_Cantidad != ""))
                {
                    if (MP_Precio != "")
                    {
                        string message =
                        "¿Está seguro de que quiere agregar la materia prima: " + MP_Descripcion + "?";
                        const string caption = "Agregar materia prima.";
                        var result = MessageBox.Show(message, caption,
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            this.db.Ejecutar("INSERT INTO MATERIA_PRIMA (MATERIA_PRIMA_DESCRIPCION, MATERIA_PRIMA_CANTIDAD, MATERIA_PRIMA_PRECIO) VALUES ('"
                                + MP_Descripcion + "',"+ MP_Cantidad +","+ MP_Precio +")");

                            dataGridViewMP_Refrescar();
                            dataGridViewMP_LimpiarCampos();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Por favor, ingrese el precio de la materia prima a agregar.");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese la cantidad de la materia prima a agregar.");
                }       
            }
            else
            {
                if ((MP_Descripcion != "") && (existe))
                {
                    MessageBox.Show("La materia prima ingresada ya se encuentra en el sistema.");
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese el nombre de la materia prima a agregar.");
                }
            }
        }
    }
}
