using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Siglop
{
    public partial class Gestion_de_Stock : Form
    {
        private dbmanager db;
        public Gestion_de_Stock(dbmanager db)
        {
            InitializeComponent();
            this.db = db;
            cargarGrillaMateriaPrima();

            if (SIGLOP.Properties.Settings.Default.StockMateriasPrimas == 'N')
            {
                tabControl1.TabPages.Remove(tabPage2);
            }

            if (SIGLOP.Properties.Settings.Default.VistaStockSimple == 'S')
            {
                checkBox1.Enabled = true;
                dataGridView1.Enabled = true;
            }
            else
            {
                checkBox1.Enabled = false;
                dataGridView1.Enabled = false;
            }

            if (SIGLOP.Properties.Settings.Default.VistaStockCurvas == 'S')
            {
                checkBox2.Enabled = true;
                textBox1.Enabled = true;
                dataGridView2.Enabled = true;
            }
            else
            {
                checkBox2.Enabled = false;
                textBox1.Enabled = false;
                dataGridView2.Enabled = false;
            }

        }

        private void cargarGrillaStock()
        {
            Boolean existe = new Boolean();
            existe = this.db.Consultar("select p.PRODUCTO_DESCRIPCION, sum(tc.producto_stock) as producto_stock " +
                                            "from PRODUCTO_TALLE_COLOR tc, PRODUCTO p " +
                                            "where tc.id_producto = p.ID_PRODUCTO " +
                                            "group by p.PRODUCTO_DESCRIPCION");

            if (existe)
            {
                while (this.db.Leer())
                {
                    this.dataGridView1.Rows.Add(this.db.ObtenerValor("PRODUCTO_DESCRIPCION"), this.db.ObtenerValor("producto_stock"));
                }
            }

        }

        private void cargarGrillaCurva(string producto)
        {
            Boolean existe = new Boolean();
            existe = this.db.Consultar("select c.COLOR_DESCRIPCION, p.PRODUCTO_DESCRIPCION, " +
                                            "ISNULL(SUM(case TALLE_DESCRIPCION when 'XS' then tc.producto_stock end),0) as stock_XS, " +
                                            "ISNULL(SUM(case TALLE_DESCRIPCION when 'S' then tc.producto_stock end),0) as stock_S,  " +
                                            "ISNULL(SUM(case TALLE_DESCRIPCION when 'M' then tc.producto_stock end),0) as stock_M, " +
                                            "ISNULL(SUM(case TALLE_DESCRIPCION when 'L' then tc.producto_stock end),0) as stock_L, " +
                                            "ISNULL(SUM(case TALLE_DESCRIPCION when 'XL' then tc.producto_stock end),0) as stock_XL, " +
                                            "ISNULL(SUM(case TALLE_DESCRIPCION when 'XXL' then tc.producto_stock end),0) as stock_XXL, " +
                                            "ISNULL(SUM(case TALLE_DESCRIPCION when 'XXXL' then tc.producto_stock end),0) as stock_XXXL, " +
                                            "ISNULL(SUM(case TALLE_DESCRIPCION when 'Especial' then tc.producto_stock end),0) as stock_Especial " +
                                        "from dbo.PRODUCTO_TALLE_COLOR tc, PRODUCTO p, talle t, COLOR c " +
                                        "where tc.id_producto = p.ID_PRODUCTO " +
                                            "and t.ID_TALLE = tc.ID_TALLE " +
                                            "and tc.ID_COLOR = c.ID_COLOR " +
                                            "and p.ID_PRODUCTO = '" + producto + "'" +
                                        "group by c.COLOR_DESCRIPCION, p.PRODUCTO_DESCRIPCION");

            if (existe)
            {
                
                while (this.db.Leer())
                {
                    tbProdDesc.Text = this.db.ObtenerValor("PRODUCTO_DESCRIPCION");
                    this.dataGridView2.Rows.Add(this.db.ObtenerValor("COLOR_DESCRIPCION"),
                                                this.db.ObtenerValor("stock_XS"),
                                                this.db.ObtenerValor("stock_S"),
                                                this.db.ObtenerValor("stock_M"),
                                                this.db.ObtenerValor("stock_L"),
                                                this.db.ObtenerValor("stock_XL"),
                                                this.db.ObtenerValor("stock_XXL"),
                                                this.db.ObtenerValor("stock_XXXL"),
                                                this.db.ObtenerValor("stock_Especial"));
                }
            }
        }

        private void cargarGrillaMateriaPrima()
        {
            Boolean existe = new Boolean();
            existe = this.db.Consultar("select MATERIA_PRIMA_DESCRIPCION, MATERIA_PRIMA_CANTIDAD " +
                                            "from MATERIA_PRIMA");

            if (existe)
            {
                while (this.db.Leer())
                {
                    this.dataGridView3.Rows.Add(this.db.ObtenerValor("MATERIA_PRIMA_DESCRIPCION"), this.db.ObtenerValor("MATERIA_PRIMA_CANTIDAD"));
                }
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.textBox1.Text = this.dataGridView1.SelectedCells[0].Value.ToString();
            //this.dataGridView1.SelectedCells[0].Value = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) // CHECK VISTA SIMPLIFICADA
        {
            this.dataGridView1.Rows.Clear();
            cargarGrillaStock();
            checkBox2.Checked = false;
            textBox1.Text = "";
            this.dataGridView2.Rows.Clear();
            tbProdDesc.Text = "";
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e) // CHECK VISTA POR CURVAS
        {
            this.dataGridView2.Rows.Clear();
            textBox1.Focus();
            checkBox1.Checked = false;
            this.dataGridView1.Rows.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            this.dataGridView2.Rows.Clear();
            tbProdDesc.Text = "";
            if (textBox1.Text.Equals(""))
            {
                MessageBox.Show("Debe ingresar un código de artículo o producto para buscar.");
                textBox1.Focus();
            }
            else
            {
                int cantLetras = Regex.Matches(textBox1.Text, @"[a-zA-Z]").Count;

                if (cantLetras > 0)
                {
                    MessageBox.Show("La búsqueda sólo acepta números");
                    textBox1.Text = "";
                    textBox1.Focus();
                }
                else
                {
                    cargarGrillaCurva(this.textBox1.Text);
                }
            }
            

        }

    }
}
