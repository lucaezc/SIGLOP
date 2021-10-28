using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;


namespace Siglop
{
    public partial class CalculoDeMateriales : Form
    {
        private dbmanager db;
        private String ProductoID;

        public CalculoDeMateriales(dbmanager db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void btBuscar_Click(object sender, EventArgs e) // BUSCAR
        {
            dgArtMateriales.Rows.Clear();
            txtCantidad.Text = "";
            if (tbBuscador.Text.Equals(""))
            {
                MessageBox.Show("Debe ingresar un código de artículo o producto para buscar.");
                tbBuscador.Focus();
            }
            else
            {
                int cantLetras = Regex.Matches(tbBuscador.Text, @"[a-zA-Z]").Count;

                if (cantLetras > 0)
                {
                    MessageBox.Show("La búsqueda sólo acepta números");
                    tbBuscador.Text = "";
                    tbBuscador.Focus();
                }
                else
                {
                    Boolean existe = this.db.Consultar("SELECT ID_PRODUCTO, PRODUCTO_DESCRIPCION FROM PRODUCTO WHERE ID_PRODUCTO = '" + tbBuscador.Text + "'");
                    this.db.Leer();

                    if (existe)
                    {
                        this.ProductoID = this.db.ObtenerValor("ID_PRODUCTO");
                        tbArticulo.Text = this.db.ObtenerValor("PRODUCTO_DESCRIPCION");
                        CalculoMateriales();
                        CalculoUnidadesFabricacion();
                        if (dgArtMateriales.Rows.Count <= 1)
                        {
                            txtCantidad.Text = "No hay datos";
                        }
                    }
                    else
                    {
                        MessageBox.Show("El producto no existe.");
                        tbBuscador.Text = "";
                        tbBuscador.Focus();
                    }
                }
            }
        }

        private void CalculoMateriales()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT M.ID_MATERIA_PRIMA, M.MATERIA_PRIMA_DESCRIPCION, M.MATERIA_PRIMA_CANTIDAD, C.CONFECCION_CANTIDAD_NECESARIA FROM MATERIA_PRIMA M, CONFECCION_PRODUCTO_DETALLE C, CONFECCION_PRODUCTO CP WHERE M.ID_MATERIA_PRIMA = C.ID_MATERIA_PRIMA AND C.ID_CONFECCION = CP.ID_CONFECCION AND CP.ID_PRODUCTO = '" + this.ProductoID + "'", this.db.StringConexion());
            da.SelectCommand.CommandType = CommandType.Text;
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                this.dgArtMateriales.Rows.Add(dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString(), dt.Rows[i][3].ToString());
            }
        }
            
    
        private void CalculoUnidadesFabricacion(){

            bool stock = true;
            int stockActual;
            int stockNecesario;
            decimal stockMinimo=-1;
            for (int i = 0; i < (dgArtMateriales.Rows.Count - 1); i++)
            {
                stockActual = Convert.ToInt32(dgArtMateriales.Rows[i].Cells["StockActual"].Value);
                stockNecesario = Convert.ToInt32(dgArtMateriales.Rows[i].Cells["StockUnidad"].Value);
      
                if (stockNecesario > 0)
                {
                    if (stockMinimo == -1)
                    {
                        stockMinimo = stockActual / stockNecesario;
                    }
                    else
                    {
                        if (stockMinimo > (stockActual / stockNecesario))
                        {
                            stockMinimo = stockActual / stockNecesario;
                        }
                    }
                    if (stockMinimo == 0)
                    {
                        stock = false;
                        break;
                    }
                }
            }

            if (stock == false)
            {
                MessageBox.Show("No existe stock minimo para fabricar unidades para el articulo seleccinado ");
            }
            else
            {
                txtCantidad.Text = stockMinimo.ToString();
            }
       
        }

        private void btnVolver_Click(object sender, EventArgs e) // VOLVER
        {
            this.Dispose();
        }

    }
}
