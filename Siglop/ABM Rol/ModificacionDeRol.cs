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
    public partial class ModificacionRol : Form
    {
        private dbmanager db;
        string rolID = "0";
        string rolAnterior;
        public ModificacionRol(dbmanager db)
        {
            InitializeComponent();
            this.db = db;

            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(NombreRol, "Ingrese el nombre del rol a buscar.");
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            dataGridViewA.Rows.Clear();

            if (NombreRol.Text != "")
            {
                Boolean existe = this.db.Consultar("SELECT r.ID_ROL, r.ROL_DESCRIPCION, p.ID_PERMISO, p.PERMISO_STOCK, p.PERMISO_PRODUCTO, p.PERMISO_F_CAJA, p.PERMISO_CONSULTAS, p.PERMISO_AGENDA, p.PERMISO_REPORTES, p.PERMISO_CONF FROM ROL r,PERMISO p,PERMISO_ROL pr WHERE ROL_DESCRIPCION LIKE '" + NombreRol.Text.ToUpper() + "%' AND pr.ID_ROL=r.ID_ROL AND pr.ID_PERMISO=p.ID_PERMISO");
                Boolean tilde = false;

                if (existe)
                {
                    this.db.Leer();
                    nombre.Text = this.db.ObtenerValor("ROL_DESCRIPCION");
                    rolAnterior = this.db.ObtenerValor("ROL_DESCRIPCION");
                    rolID = this.db.ObtenerValor("ID_ROL");

                    string query = "SELECT p.PERMISO_STOCK, p.PERMISO_PRODUCTO, p.PERMISO_F_CAJA, p.PERMISO_CONSULTAS, p.PERMISO_AGENDA, p.PERMISO_REPORTES, p.PERMISO_CONF FROM ROL r,PERMISO p, PERMISO_ROL pr WHERE ROL_DESCRIPCION='" + nombre.Text + "' AND r.ID_ROL = pr.ID_ROL AND p.ID_PERMISO=pr.ID_PERMISO";
                    this.db.Consultar(query);

                    this.db.Leer();
                    string permisoStock = this.db.ObtenerValor("PERMISO_STOCK");
                    if (permisoStock == "True")
                    {
                        tilde = true;
                    }
                    dataGridViewA.Rows.Add(tilde, "Gestión de Stock");
                    tilde = false;

                    permisoStock = this.db.ObtenerValor("PERMISO_PRODUCTO");
                    if (permisoStock == "True")
                    {
                        tilde = true;
                    }
                    dataGridViewA.Rows.Add(tilde, "Catálogo de Productos");
                    tilde = false;

                    permisoStock = this.db.ObtenerValor("PERMISO_F_CAJA");
                    if (permisoStock == "True")
                    {
                        tilde = true;
                    }
                    dataGridViewA.Rows.Add(tilde, "Gestión de Flujo de Caja");
                    tilde = false;

                    permisoStock = this.db.ObtenerValor("PERMISO_CONSULTAS");
                    if (permisoStock == "True")
                    {
                        tilde = true;
                    }
                    dataGridViewA.Rows.Add(tilde, "Consultas");
                    tilde = false;

                    permisoStock = this.db.ObtenerValor("PERMISO_AGENDA");
                    if (permisoStock == "True")
                    {
                        tilde = true;
                    }
                    dataGridViewA.Rows.Add(tilde, "Agenda");
                    tilde = false;

                    permisoStock = this.db.ObtenerValor("PERMISO_REPORTES");
                    if (permisoStock == "True")
                    {
                        tilde = true;
                    }
                    dataGridViewA.Rows.Add(tilde, "Reportes");
                    tilde = false;

                    permisoStock = this.db.ObtenerValor("PERMISO_CONF");
                    if (permisoStock == "True")
                    {
                        tilde = true;
                    }
                    dataGridViewA.Rows.Add(tilde, "Configuración");
                }
                else
                {
                    MessageBox.Show("El rol buscado no existe en el sistema. Por favor, vuelva a intentarlo.");
                }
            }
        }

        private void ModificarR_Click(object sender, EventArgs e)
        {
            if (rolID == "0")
            {
                MessageBox.Show("Por favor, busque un rol en el sistema.");
            }
            else
            {
                string rol = nombre.Text;
                Boolean existe = false;
                existe = this.db.Consultar("SELECT r.ID_ROL, r.ROL_DESCRIPCION, p.ID_PERMISO, p.PERMISO_STOCK, p.PERMISO_PRODUCTO, p.PERMISO_F_CAJA, p.PERMISO_CONSULTAS, p.PERMISO_AGENDA, p.PERMISO_REPORTES, p.PERMISO_CONF FROM ROL r,PERMISO p,PERMISO_ROL pr WHERE ROL_DESCRIPCION='" + rolAnterior + "' AND pr.ID_ROL=r.ID_ROL AND pr.ID_PERMISO=p.ID_PERMISO");
                //this.db.Consultar("SELECT @@IDENTITY 'ID_ROL'");
                this.db.Leer();
                string rolIDNow = this.db.ObtenerValor("ID_ROL");
                //MessageBox.Show("id leido ahora " + rolIDNow);
                //MessageBox.Show("id leido antes " + rolID);

                if (nombre.Text == "")
                {
                    MessageBox.Show("Por favor, ingrese un nombre de rol.");
                }
                else
                {
                    if (existe && (rolID != rolIDNow)) //Existe y modifico los datos del mismo rol que no sean el ID de rol...
                    {
                        MessageBox.Show("El rol ingresado ya está existe. Por favor, ingrese otro nombre de rol.");
                        nombre.Focus();
                    }
                    else
                    {
                        int acceso1 = 0;
                        int acceso2 = 0;
                        int acceso3 = 0;
                        int acceso4 = 0;
                        int acceso5 = 0;
                        int acceso6 = 0;
                        int acceso7 = 0;
                        //int cant_accesos=6;

                        //MessageBox.Show("total seleccionados " + dataGridViewA.SelectedCells.Count);
                        for (int x = 0; x <= dataGridViewA.SelectedCells.Count - 1; x++)
                            {
                                int unAcceso = dataGridViewA.SelectedCells[x].RowIndex;
                                MessageBox.Show("unAcceso " + unAcceso);
                                if (unAcceso == 0)
                                {
                                    acceso1 = 1;
                                }
                                if (unAcceso == 1)
                                {
                                    acceso2 = 1;
                                }
                                if (unAcceso == 2)
                                {
                                    acceso3 = 1;
                                }
                                if (unAcceso == 3)
                                {
                                    acceso4 = 1;
                                }
                                if (unAcceso == 4)
                                {
                                    acceso5 = 1;
                                }
                                if (unAcceso == 5)
                                {
                                    acceso6 = 1;
                                }
                                if (unAcceso == 6)
                                {
                                    acceso7 = 1;
                                }
                            }


                        this.db.Consultar("SELECT r.ID_ROL, r.ROL_DESCRIPCION, p.ID_PERMISO, p.PERMISO_STOCK, p.PERMISO_PRODUCTO, p.PERMISO_F_CAJA, p.PERMISO_CONSULTAS, p.PERMISO_AGENDA, p.PERMISO_REPORTES, p.PERMISO_CONF FROM ROL r,PERMISO p,PERMISO_ROL pr WHERE ROL_DESCRIPCION='" + rol + "' AND pr.ID_ROL=r.ID_ROL AND pr.ID_PERMISO=p.ID_PERMISO");
                        this.db.Leer();
                        Decimal idPermiso = Decimal.Parse(this.db.ObtenerValor("ID_PERMISO"));
                        //MessageBox.Show("id permiso: "+idPermiso);
                        Boolean existeRelacion = this.db.Consultar("SELECT r.ID_ROL FROM ROL r,PERMISO_ROL pr WHERE pr.ID_PERMISO=" + idPermiso + " AND pr.ID_ROL=" + rolIDNow);
                        //MessageBox.Show("id rol: " + rolIDNow);

                        if (existeRelacion)
                        {
                            this.db.Ejecutar("UPDATE PERMISO SET PERMISO_STOCK=" + acceso1 + ", PERMISO_PRODUCTO=" + acceso2 + ", PERMISO_F_CAJA=" + acceso3 + ", PERMISO_CONSULTAS=" + acceso4 + ", PERMISO_AGENDA=" + acceso5 + ", PERMISO_REPORTES=" + acceso6 + ", PERMISO_CONF=" + acceso7 + "WHERE ID_PERMISO=" + idPermiso);
                            this.db.Ejecutar("UPDATE ROL SET ROL_DESCRIPCION='" + rol + "' WHERE ID_ROL=" + rolIDNow );
                            MessageBox.Show("Rol actualizado.");
                            dataGridViewA.Rows.Clear();
                            nombre.Text = "";
                            this.Dispose();
                        }
                        else
                        {
                            MessageBox.Show("No existe usuarios que tengan ese rol.");
                        }
                    }
                }
            }
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
