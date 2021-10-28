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
    public partial class ModificacionProd : Form
    {
        private dbmanager db;
        private String ProductoID;
        public ModificacionProd(dbmanager db)
        {
            InitializeComponent();
            this.db = db;
            datosProd.Enabled = false;
        }

        private void CargaComboComponentes()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT ID_MATERIA_PRIMA, MATERIA_PRIMA_DESCRIPCION FROM MATERIA_PRIMA", this.db.StringConexion());
            da.Fill(ds, "SIGLOP.MATERIA_PRIMA");
            this.cbComposicion.DataSource = ds.Tables[0].DefaultView;
            this.cbComposicion.DisplayMember = "MATERIA_PRIMA_DESCRIPCION";
            this.cbComposicion.ValueMember = "ID_MATERIA_PRIMA";
        }

        private void CargaComboTipoProducto()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT ID_TIPO_PRODUCTO, TIPO_PRODUCTO_DESCRIPCION FROM TIPO_PRODUCTO", this.db.StringConexion());
            da.Fill(ds, "SIGLOP.TIPO_PRODUCTO");
            this.cbTipoProd.DataSource = ds.Tables[0].DefaultView;
            this.cbTipoProd.DisplayMember = "TIPO_PRODUCTO_DESCRIPCION";
            this.cbTipoProd.ValueMember = "ID_TIPO_PRODUCTO";
        }

        private void CargaColores()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT COLOR_DESCRIPCION FROM COLOR", this.db.StringConexion());
            da.SelectCommand.CommandType = CommandType.Text;
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                this.Colores.Items.Add(dt.Rows[i][0].ToString());
            }
        }

        private void cancelar_Click(object sender, EventArgs e) // CANCELAR
        {
            this.Dispose();
        }

        private void Modificar_Click ( object sender, EventArgs e ) // MODIFICAR
        {
            String descripcion = tbDescripcion.Text;
            Decimal tipoProducto = Decimal.Parse(cbTipoProd.SelectedValue.ToString());
            String precioEfectivo = precioEfec.Text;
            String recargoTarjeta = precioTarj.Text;
            String medidas = tbMedidas.Text;
            String coleccion = tbColeccion.Text;
            String tiempoReposicion = tbTiempoReposicion.Text;
            String path = rutaImagen.Text;
            String stock = tbStock.Text;

            String talle = null;
            Decimal colorId = 0;
            if (chxs.Checked == true)
            {
                talle = chxs.Text;
            }
            if (chs.Checked == true)
            {
                talle = chs.Text;
            }
            if (chm.Checked == true)
            {
                talle = chm.Text;
            }
            if (chl.Checked == true)
            {
                talle = chl.Text;
            }
            if (chxl.Checked == true)
            {
                talle = chxl.Text;
            }
            if (chxxl.Checked == true)
            {
                talle = chxxl.Text;
            }
            if (chxxxl.Checked == true)
            {
                talle = chxxxl.Text;
            }
            if (chesp.Checked == true)
            {
                talle = chesp.Text;
            }
            if (talle == null)
            {
                MessageBox.Show("Debe seleccionar un talle para el producto.");
            }
            else
            {
                Decimal talleID = 0;
                Boolean existeTalle = this.db.Consultar("SELECT ID_TALLE FROM TALLE WHERE TALLE_DESCRIPCION = '" + talle + "'");
                if (existeTalle)
                {
                    this.db.Leer();
                    talleID = Decimal.Parse(this.db.ObtenerValor("ID_TALLE"));
                }

                if (Colores.CheckedItems.Count > 1)
                {
                    MessageBox.Show("Debe elegir sólo un color por ingreso.");
                }
                else
                {
                    foreach (var item in Colores.CheckedItems)
                    {
                        String color = item.ToString().Trim();
                        Boolean existeColor = this.db.Consultar("SELECT ID_COLOR FROM COLOR WHERE COLOR_DESCRIPCION = '" + color + "'");
                        if (existeColor)
                        {
                            this.db.Leer();
                            colorId = Decimal.Parse(this.db.ObtenerValor("ID_COLOR"));
                        }
                    }

                    if (stock.Equals(""))
                    {
                        MessageBox.Show("Debe ingresar el stock del producto.");
                    }
                    else
                    {
                        this.db.Ejecutar("UPDATE PRODUCTO SET PRODUCTO_TIPO = '" + tipoProducto + "', PRODUCTO_DESCRIPCION = '" + descripcion + "', PRODUCTO_PRECIO_EFECTIVO = '" + precioEfectivo +
                            "', PRODUCTO_RECARGO_TARJETA = '" + recargoTarjeta + "', PRODUCTO_MEDIDAS = '" + medidas + "', PRODUCTO_COLECCION = '" + coleccion + "', PRODUCTO_TIEMPO_REPOSICION = '" +
                            tiempoReposicion + "', PRODUCTO_IMAGEN_PATH = '" + path + "' WHERE ID_PRODUCTO = '" + this.ProductoID + "'");

                        this.db.Ejecutar("DELETE PRODUCTO_TALLE_COLOR WHERE ID_PRODUCTO = '" + this.ProductoID + "'");
                        this.db.Ejecutar("INSERT INTO PRODUCTO_TALLE_COLOR (ID_PRODUCTO, ID_TALLE, ID_COLOR, PRODUCTO_STOCK) VALUES ('" + this.ProductoID + "', '" + talleID + "', '" + colorId + "', '" + stock + "')");

                        Decimal confeccionID = 0;
                        Boolean existeConfeccion = this.db.Consultar("SELECT ID_CONFECCION FROM CONFECCION_PRODUCTO WHERE ID_PRODUCTO = '" + this.ProductoID + "'");
                        if (existeConfeccion)
                        {
                            this.db.Leer();
                            confeccionID = Decimal.Parse(this.db.ObtenerValor("ID_CONFECCION"));
                        }

                        this.db.Ejecutar("DELETE CONFECCION_PRODUCTO_DETALLE WHERE ID_CONFECCION = " + confeccionID);
                        this.db.Ejecutar("DELETE CONFECCION_PRODUCTO WHERE ID_CONFECCION = " + confeccionID);

                        String confeccionDesc = "Confección para el producto " + descripcion;
                        this.db.Ejecutar("INSERT INTO CONFECCION_PRODUCTO (ID_PRODUCTO, CONFECCION_DESCRIPCION) VALUES ('" + this.ProductoID + "', '" + confeccionDesc + "')");

                        Decimal confProductoID = 0;
                        Boolean existeConfProd = this.db.Consultar("SELECT @@IDENTITY 'ID'");
                        if (existeConfProd)
                        {
                            this.db.Leer();
                            confProductoID = Decimal.Parse(this.db.ObtenerValor("ID"));
                        }

                        var itemsComponentes = new System.Collections.ArrayList(lbComponente.Items);
                        foreach (var item in itemsComponentes)
                        {
                            string[] valoresComponentes = item.ToString().Split(' ');
                            Decimal cantidad = Decimal.Parse(valoresComponentes[0].ToString());
                            String componenteDesc = valoresComponentes[1].ToString();

                            Decimal componenteID = 0;
                            Boolean existeComponenteDesc = this.db.Consultar("SELECT ID_MATERIA_PRIMA FROM MATERIA_PRIMA WHERE MATERIA_PRIMA_DESCRIPCION = '" + componenteDesc + "'");
                            if (existeComponenteDesc)
                            {
                                this.db.Leer();
                                componenteID = Decimal.Parse(this.db.ObtenerValor("ID_MATERIA_PRIMA"));
                            }

                            this.db.Ejecutar("INSERT INTO CONFECCION_PRODUCTO_DETALLE (ID_CONFECCION, ID_MATERIA_PRIMA, CONFECCION_CANTIDAD_NECESARIA) VALUES ('" + confProductoID + "', '" + componenteID + "', '" + cantidad + "')");
                            Modificar.DialogResult = DialogResult.OK;
                        }
                    }
                }
            }
        }

        private void bMas_Click(object sender, EventArgs e) // AGREGAR COMPONENTE
        {
            Decimal materiaPrimaID = Decimal.Parse(cbComposicion.SelectedValue.ToString());
            Decimal cantidad = 0;
            if (tbCantidad.Text.Equals(""))
            {
                MessageBox.Show("Debe ingresar una cantidad para el componente seleccionado.");
                tbCantidad.Focus();
            }
            else
            {
                 cantidad = Decimal.Parse(tbCantidad.Text);
                 lbComponente.Items.Add(cantidad.ToString() + " " + cbComposicion.GetItemText(cbComposicion.SelectedItem));
                 tbCantidad.Text = "";
            }
        }

        private void bMenos_Click(object sender, EventArgs e) // ELIMINAR COMPONENTE
        {
            ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(lbComponente);
            selectedItems = lbComponente.SelectedItems;

            if (lbComponente.SelectedIndex != -1)
            {
                for (int i = selectedItems.Count - 1; i >= 0; i--)
                    lbComponente.Items.Remove(selectedItems[i]);
            }
        }

        private void examinar_Click(object sender, EventArgs e) // EXAMINAR IMAGEN PATH
        {
            DialogResult result = ofdImagen.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                try
                {
                    rutaImagen.Text = ofdImagen.InitialDirectory + ofdImagen.FileName;
                }
                catch (IOException)
                {
                }
            }
        }

        private void chxs_CheckedChanged(object sender, EventArgs e)
        {
            if (chxs.Checked == true)
            {
                chs.Checked = false;
                chm.Checked = false;
                chl.Checked = false;
                chxl.Checked = false;
                chxxl.Checked = false;
                chxxxl.Checked = false;
                chesp.Checked = false;
            }
        }

        private void chs_CheckedChanged(object sender, EventArgs e)
        {
            if (chs.Checked == true)
            {
                chxs.Checked = false;
                chm.Checked = false;
                chl.Checked = false;
                chxl.Checked = false;
                chxxl.Checked = false;
                chxxxl.Checked = false;
                chesp.Checked = false;
            }
        }

        private void chm_CheckedChanged(object sender, EventArgs e)
        {
            if (chm.Checked == true)
            {
                chxs.Checked = false;
                chs.Checked = false;
                chl.Checked = false;
                chxl.Checked = false;
                chxxl.Checked = false;
                chxxxl.Checked = false;
                chesp.Checked = false;
            }
        }

        private void chl_CheckedChanged(object sender, EventArgs e)
        {
            if (chl.Checked == true)
            {
                chxs.Checked = false;
                chs.Checked = false;
                chm.Checked = false;
                chxl.Checked = false;
                chxxl.Checked = false;
                chxxxl.Checked = false;
                chesp.Checked = false;
            }
        }

        private void chxl_CheckedChanged(object sender, EventArgs e)
        {
            if (chxl.Checked == true)
            {
                chxs.Checked = false;
                chs.Checked = false;
                chm.Checked = false;
                chl.Checked = false;
                chxxl.Checked = false;
                chxxxl.Checked = false;
                chesp.Checked = false;
            }
        }

        private void chxxl_CheckedChanged(object sender, EventArgs e)
        {
            if (chxxl.Checked == true)
            {
                chxs.Checked = false;
                chs.Checked = false;
                chm.Checked = false;
                chl.Checked = false;
                chxl.Checked = false;
                chxxxl.Checked = false;
                chesp.Checked = false;
            }
        }

        private void chxxxl_CheckedChanged(object sender, EventArgs e)
        {
            if (chxxxl.Checked == true)
            {
                chxs.Checked = false;
                chs.Checked = false;
                chm.Checked = false;
                chl.Checked = false;
                chxl.Checked = false;
                chxxl.Checked = false;
                chesp.Checked = false;
            }
        }

        private void chesp_CheckedChanged(object sender, EventArgs e)
        {
            if (chesp.Checked == true)
            {
                chxs.Checked = false;
                chs.Checked = false;
                chm.Checked = false;
                chl.Checked = false;
                chxl.Checked = false;
                chxxl.Checked = false;
                chxxxl.Checked = false;
            }
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
                        CargaComboComponentes();
                        CargaColores();
                        CargaComboTipoProducto();
                        CargaDatos();
                        datosProd.Enabled = true;
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

        private void CargaDatos()
        {
            Boolean existe = this.db.Consultar("SELECT ID_PRODUCTO, PRODUCTO_DESCRIPCION, PRODUCTO_TIPO, PRODUCTO_PRECIO_EFECTIVO, PRODUCTO_RECARGO_TARJETA, PRODUCTO_MEDIDAS, PRODUCTO_COLECCION, PRODUCTO_TIEMPO_REPOSICION, PRODUCTO_IMAGEN_PATH FROM PRODUCTO WHERE ID_PRODUCTO = '" + this.ProductoID + "'");
            if (existe)
            {
                this.db.Leer();
                tbDescripcion.Text = this.db.ObtenerValor("PRODUCTO_DESCRIPCION");
                precioEfec.Text = this.db.ObtenerValor("PRODUCTO_PRECIO_EFECTIVO");
                precioTarj.Text = this.db.ObtenerValor("PRODUCTO_RECARGO_TARJETA");
                tbMedidas.Text = this.db.ObtenerValor("PRODUCTO_MEDIDAS");
                tbColeccion.Text = this.db.ObtenerValor("PRODUCTO_COLECCION");
                tbTiempoReposicion.Text = this.db.ObtenerValor("PRODUCTO_TIEMPO_REPOSICION");
                rutaImagen.Text = this.db.ObtenerValor("PRODUCTO_IMAGEN_PATH");
            }
        }
    }
 }
