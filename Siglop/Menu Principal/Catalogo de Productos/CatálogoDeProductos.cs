using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Text.RegularExpressions;

namespace Siglop
{
    public partial class CargarListaCatálogoDeProductos : Form
    {
        private dbmanager db;
        System.Data.SqlClient.SqlDataAdapter da;
        String ProductoID;

        public CargarListaCatálogoDeProductos(dbmanager db)
        {
            InitializeComponent();
            this.db = db;
            DataTable dt = new DataTable();
            string query = "SELECT REPLACE(STR(ID_PRODUCTO, 4), SPACE(1), '0') as productoID  from PRODUCTO";
            da = new System.Data.SqlClient.SqlDataAdapter(query, this.db.StringConexion());
            da.SelectCommand.CommandType = CommandType.Text;
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                lbProductos.DataSource = dt;
                lbProductos.DisplayMember = "productoID";
                lbProductos.ValueMember = "productoID";
            }

            if (SIGLOP.Properties.Settings.Default.StockMateriasPrimas == 'S')
            {
                CalculoMateriales.Enabled = true;
            }
            else
            {
                CalculoMateriales.Enabled = false;
            }
        }

        private void CargarProductos()
        {
            DataTable dt = new DataTable();
            string query = "SELECT REPLACE(STR(ID_PRODUCTO, 4), SPACE(1), '0') as productoID  from PRODUCTO";
            da = new System.Data.SqlClient.SqlDataAdapter(query, this.db.StringConexion());
            da.SelectCommand.CommandType = CommandType.Text;
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                lbProductos.DataSource = dt;
                lbProductos.DisplayMember = "productoID";
                lbProductos.ValueMember = "productoID";
            }
        }

        private void cargarDetalleArticulo()
        {
            Limpiar();
            Boolean existe = this.db.Consultar("SELECT ID_PRODUCTO, PRODUCTO_DESCRIPCION, PRODUCTO_TIPO, PRODUCTO_PRECIO_EFECTIVO, PRODUCTO_RECARGO_TARJETA, PRODUCTO_MEDIDAS, PRODUCTO_COLECCION, PRODUCTO_TIEMPO_REPOSICION, PRODUCTO_IMAGEN_PATH FROM PRODUCTO WHERE ID_PRODUCTO = '" + this.ProductoID + "'");
            if (existe)
            {
                this.db.Leer();
                tbCodigo.Text = this.ProductoID;
                tbDescripcion.Text = this.db.ObtenerValor("PRODUCTO_DESCRIPCION");
                tbPrecioEf.Text = this.db.ObtenerValor("PRODUCTO_PRECIO_EFECTIVO");
                tbPrecioTar.Text = (Double.Parse(this.db.ObtenerValor("PRODUCTO_PRECIO_EFECTIVO")) + (Double.Parse(this.db.ObtenerValor("PRODUCTO_RECARGO_TARJETA")))).ToString();
                tbMedidas.Text = this.db.ObtenerValor("PRODUCTO_MEDIDAS");
                tbColAño.Text = this.db.ObtenerValor("PRODUCTO_COLECCION");
                tbReposicion.Text = this.db.ObtenerValor("PRODUCTO_TIEMPO_REPOSICION");
                String path = this.db.ObtenerValor("PRODUCTO_IMAGEN_PATH");
                if (File.Exists(path))
                {
                    pictureBox1.Image = System.Drawing.Image.FromFile(path);
                    pictureBox1.Size = new System.Drawing.Size(230, 220);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    pictureBox1.Image = System.Drawing.Image.FromFile("C:\\SIGLOP\\Imagenes\\ProductoSinImagen.jpg");
                    pictureBox1.Size = new System.Drawing.Size(230, 220);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }

                ObtenerTalles();
                ObtenerColores();
                ObtenerComposicion();
            }

        }

        private void ObtenerColores()
        {
            DataTable dt = new DataTable();
            String existeColor = "SELECT DISTINCT C.ID_COLOR, C.COLOR_DESCRIPCION from PRODUCTO_TALLE_COLOR PTC JOIN COLOR C ON PTC.ID_COLOR = C.ID_COLOR WHERE  PTC.ID_PRODUCTO = '" + this.ProductoID + "'";
            da = new System.Data.SqlClient.SqlDataAdapter(existeColor, this.db.StringConexion());

            da.SelectCommand.CommandType = CommandType.Text;
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                lbColores.DataSource = dt;
                lbColores.DisplayMember = "COLOR_DESCRIPCION";
                lbColores.ValueMember = "ID_COLOR";
            }

        }

        private void ObtenerTalles(){
            DataTable dt = new DataTable();
            string query = "SELECT t.TALLE_DESCRIPCION from PRODUCTO_TALLE_COLOR ptc, TALLE t WHERE ptc.ID_TALLE = t.ID_TALLE and ptc.ID_PRODUCTO = '" + this.ProductoID + "'";
            da = new System.Data.SqlClient.SqlDataAdapter(query, this.db.StringConexion());
            da.SelectCommand.CommandType = CommandType.Text;
            da.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                if (row["TALLE_DESCRIPCION"].ToString() == "XS")
                {
                    tbXS.Checked = true;
                }
                if (row["TALLE_DESCRIPCION"].ToString() == "S")
                {
                    tbS.Checked = true;
                }
                if (row["TALLE_DESCRIPCION"].ToString() == "M")
                {
                    tbM.Checked = true;
                }
                if (row["TALLE_DESCRIPCION"].ToString() == "L")
                {
                    tbL.Checked = true;
                }
                if (row["TALLE_DESCRIPCION"].ToString() == "XL")
                {
                    tbXL.Checked = true;
                }
                if (row["TALLE_DESCRIPCION"].ToString() == "XXL")
                {
                    tbXXL.Checked = true;
                }
                if (row["TALLE_DESCRIPCION"].ToString() == "XXXL")
                {
                    tbXXXL.Checked = true;
                }
                if (row["TALLE_DESCRIPCION"].ToString() == "Especial")
                {
                    tbEspecial.Checked = true;
                }
            }

        }

        private void Limpiar()
        {
            tbCodigo.Text = "";
            tbDescripcion.Text = "";
            tbPrecioEf.Text = "";
            tbPrecioTar.Text = "";
            tbMedidas.Text = "";
            tbColAño.Text = "";
            tbReposicion.Text = "";
            tbXS.Checked = false;
            tbS.Checked = false;
            tbM.Checked = false;
            tbL.Checked = false;
            tbXL.Checked = false;
            tbXXL.Checked = false;
            tbXXXL.Checked = false;
            lbColores.DataSource = null;
            lbColores.Items.Clear();
            lbComposicion.DataSource = null;
            lbComposicion.Items.Clear();
        }

        private void ObtenerComposicion() {

            DataTable dt = new DataTable();
            SqlDataReader dr;

            String QUERY = "SELECT CAST (C.CONFECCION_CANTIDAD_NECESARIA AS VARCHAR(30)) +'  '+  M.MATERIA_PRIMA_DESCRIPCION  AS DESCRIPCION_MATERIALES from MATERIA_PRIMA M, CONFECCION_PRODUCTO_DETALLE C, CONFECCION_PRODUCTO CP WHERE M.ID_MATERIA_PRIMA = C.ID_MATERIA_PRIMA AND C.ID_CONFECCION = CP.ID_CONFECCION AND CP.ID_PRODUCTO = '" + this.ProductoID + "'";
            da = new System.Data.SqlClient.SqlDataAdapter(QUERY, this.db.StringConexion());
            da.SelectCommand.CommandType = CommandType.Text;
            da.Fill(dt);

            SqlConnection con = new SqlConnection();
            con.ConnectionString = this.db.StringConexion();
            da.SelectCommand.Connection = con;

            con.Open();
            dr = da.SelectCommand.ExecuteReader();
            lbComposicion.Items.Clear();

            while(dr.Read())
            {
                lbComposicion.Items.Add(dr["DESCRIPCION_MATERIALES"].ToString());
            }
            dr.Close();
        }


        private void CalculoMateriales_Click(object sender, EventArgs e) // CALCULO DE MATERIALES
        {
            CalculoDeMateriales cm = new CalculoDeMateriales(db);
            cm.Show();
        }

        private void Alta_Click ( object sender, EventArgs e ) // ALTA DE PRODUCTOS
        {
            AltaProd ap = new AltaProd(db);
            DialogResult res = ap.ShowDialog();
            if (res == DialogResult.OK)
            {
                CargarProductos();
                MessageBox.Show("Se agregó el producto correctamente");
            }
        }

        private void button5_Click(object sender, EventArgs e) // VOLVER
        {
            this.Dispose();
        }

        private void lbProductos_SelectedIndexChanged(object sender, EventArgs e) // SELECCIÓN DE ARTÍCULO DEL LISTADO
        {
            String articulo = lbProductos.SelectedValue.ToString().Replace('0',' ').Trim();
            this.ProductoID = articulo;
            cargarDetalleArticulo(); 
        }

        private void btBuscar_Click(object sender, EventArgs e) // BUSCAR
        {
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
                    Boolean existe = this.db.Consultar("SELECT ID_PRODUCTO FROM PRODUCTO WHERE ID_PRODUCTO = '" + tbBuscador.Text + "'");
                    this.db.Leer();

                    if (existe)
                    {
                        this.ProductoID = this.db.ObtenerValor("ID_PRODUCTO");
                        cargarDetalleArticulo();
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

        private void btBaja_Click(object sender, EventArgs e) // BAJA PRODUCTO
        {
            String articulo = lbProductos.SelectedValue.ToString().Replace('0', ' ').Trim();
            if (articulo.Equals(""))
            {
                MessageBox.Show("Debe seleccionar un artículo para eliminar");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("¿Esta seguro que desea eliminar el producto " + articulo + " ? ", "Baja de Producto", MessageBoxButtons.OKCancel);
                if (dialogResult == DialogResult.OK)
                {
                    Decimal confeccionID = 0;
                    Boolean existeConfeccion = this.db.Consultar("SELECT ID_CONFECCION FROM CONFECCION_PRODUCTO WHERE ID_PRODUCTO = '" + articulo + "'");
                    if (existeConfeccion)
                    {
                        this.db.Leer();
                        confeccionID = Decimal.Parse(this.db.ObtenerValor("ID_CONFECCION"));
                    }

                    this.db.Ejecutar("DELETE CONFECCION_PRODUCTO_DETALLE WHERE ID_CONFECCION = " + confeccionID);
                    this.db.Ejecutar("DELETE CONFECCION_PRODUCTO WHERE ID_CONFECCION = " + confeccionID);
                    this.db.Ejecutar("DELETE PRODUCTO_TALLE_COLOR WHERE ID_PRODUCTO = '" + articulo + "'");
                    this.db.Ejecutar("DELETE PRODUCTO WHERE ID_PRODUCTO = '" + articulo + "'");

                    MessageBox.Show("Producto eliminado");
                    CargarProductos();  
                }
            }
        }

        private void btModificacion_Click(object sender, EventArgs e) // MODIFICACION PRODUCTO
        {
            ModificacionProd ap = new ModificacionProd(db);
            DialogResult res = ap.ShowDialog();
            if (res == DialogResult.OK)
            {
                CargarProductos();
                MessageBox.Show("Se modificó el producto correctamente");
            }
        }
    }
}


        




        

