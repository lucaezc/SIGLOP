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
    public partial class Roles : Form
    {
        private dbmanager db;
        System.Data.SqlClient.SqlDataAdapter da;
        private String rolID = "";
        string rol = "";
        public Roles(dbmanager db)
        {
            InitializeComponent();
            this.db = db;
            cargarLista();
        }

        private void cargarLista()
        {
            DataTable dt = new DataTable();
            string query = "SELECT ID_ROL, ROL_DESCRIPCION FROM ROL";
            da = new System.Data.SqlClient.SqlDataAdapter(query, this.db.StringConexion());

            da.SelectCommand.CommandType = CommandType.Text;
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                listRoles.DataSource = dt;
                listRoles.DisplayMember = "DESCRIPCION";
                listRoles.ValueMember = "ROL_DESCRIPCION";
            }
        }

         private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String itemSeleccionado = listRoles.SelectedValue.ToString();
            String nombreSeleccionado = listRoles.SelectedItem.ToString();
            dataGridView2.Rows.Clear();

            if (itemSeleccionado != "System.Data.DataRowView")
            {
                this.db.Consultar("SELECT r.ID_ROL, r.ROL_DESCRIPCION, p.ID_PERMISO, p.PERMISO_STOCK, p.PERMISO_PRODUCTO, p.PERMISO_F_CAJA, p.PERMISO_CONSULTAS, p.PERMISO_AGENDA, p.PERMISO_REPORTES, p.PERMISO_CONF FROM ROL r,PERMISO p,PERMISO_ROL pr WHERE ROL_DESCRIPCION='" + itemSeleccionado+"' AND pr.ID_ROL=r.ID_ROL AND pr.ID_PERMISO=p.ID_PERMISO");
                Boolean tilde = false;                

                    this.db.Leer();
                    txtRol.Text = this.db.ObtenerValor("ROL_DESCRIPCION");
                    rol = txtRol.Text;
                    rolID = this.db.ObtenerValor("ID_ROL");

                    string query = "SELECT p.PERMISO_STOCK, p.PERMISO_PRODUCTO, p.PERMISO_F_CAJA, p.PERMISO_CONSULTAS, p.PERMISO_AGENDA, p.PERMISO_REPORTES, p.PERMISO_CONF FROM ROL r,PERMISO p, PERMISO_ROL pr WHERE ROL_DESCRIPCION='" + txtRol.Text +"' AND r.ID_ROL = pr.ID_ROL AND p.ID_PERMISO=pr.ID_PERMISO";
                    this.db.Consultar(query);

                    this.db.Leer();
                    string permisoStock = this.db.ObtenerValor("PERMISO_STOCK");
                    if(permisoStock == "True"){
                        tilde = true;
                    }
                    dataGridView2.Rows.Add(tilde, "Gestión de Stock");
                    tilde = false;

                    permisoStock = this.db.ObtenerValor("PERMISO_PRODUCTO");
                    if (permisoStock == "True")
                    {
                        tilde = true;
                    }
                    dataGridView2.Rows.Add(tilde, "Catálogo de Productos");
                    tilde = false;

                    permisoStock = this.db.ObtenerValor("PERMISO_F_CAJA");
                    if (permisoStock == "True")
                    {
                        tilde = true;
                    }
                    dataGridView2.Rows.Add(tilde, "Gestión de Flujo de Caja");
                    tilde = false;

                    permisoStock = this.db.ObtenerValor("PERMISO_CONSULTAS");
                    if (permisoStock == "True")
                    {
                        tilde = true;
                    }
                    dataGridView2.Rows.Add(tilde, "Consultas");
                    tilde = false;

                    permisoStock = this.db.ObtenerValor("PERMISO_AGENDA");
                    if (permisoStock == "True")
                    {
                        tilde = true;
                    }
                    dataGridView2.Rows.Add(tilde, "Agenda");
                    tilde = false;

                    permisoStock = this.db.ObtenerValor("PERMISO_REPORTES");
                    if (permisoStock == "True")
                    {
                        tilde = true;
                    }
                    dataGridView2.Rows.Add(tilde, "Reportes");
                    tilde = false;

                    permisoStock = this.db.ObtenerValor("PERMISO_CONF");
                    if (permisoStock == "True")
                    {
                        tilde = true;
                    }
                    dataGridView2.Rows.Add(tilde, "Configuración");
            }
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            AltaRol g = new AltaRol(this.db);
            DialogResult res = g.ShowDialog();
            if (res == DialogResult.OK)
            {
                cargarLista();
            }  
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            if (rolID != "")
            {
                string message = "¿Está seguro de que quiere eliminar el rol: " + rol +"?"; 
                const string caption = "Borrar Rol";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    this.db.Consultar("SELECT ID_ROL FROM ROL WHERE ROL_DESCRIPCION='" + rol + "'");
                    this.db.Leer();
                    String idRol = this.db.ObtenerValor("ID_ROL");

                    this.db.Consultar("SELECT ID_PERMISO FROM PERMISO_ROL WHERE ID_ROL=" + idRol);
                    this.db.Leer();
                    String idPermiso = this.db.ObtenerValor("ID_PERMISO");
                    this.db.Ejecutar("DELETE PERMISO_ROL WHERE ID_ROL=" + idRol);


                    this.db.Ejecutar("DELETE PERMISO WHERE ID_PERMISO=" + idPermiso);
                    this.db.Ejecutar("DELETE ROL WHERE ROL_DESCRIPCION='"+ rol+"'");
                    MessageBox.Show("Rol eliminado.");
                    cargarLista();
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un rol.");
            }
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            ModificacionRol g = new ModificacionRol(this.db);
            DialogResult res = g.ShowDialog();
            if (res == DialogResult.OK)
            {
                cargarLista();
            }  
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
