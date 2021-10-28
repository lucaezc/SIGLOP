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
    public partial class AltaRol : Form
    {
        private dbmanager db;
        public AltaRol(dbmanager db)
        {
            InitializeComponent();
            this.db = db;
            cargarAccesosDisponibles(db);
        }

        private void cargarAccesosDisponibles(dbmanager db)
        {
            int indice = 0;

            Accesos.Items.Insert(indice, "Gestión de Stock");
            Accesos.Items.Insert(indice++, "Catálogo de Productos");
            Accesos.Items.Insert(indice++, "Gestión de Flujo de Caja");
            Accesos.Items.Insert(indice++, "Consultas");
            Accesos.Items.Insert(indice++, "Agenda");
            Accesos.Items.Insert(indice++, "Reportes");
            Accesos.Items.Insert(indice++, "Configuración");
        }

        private void ConfirmarAltaR_Click(object sender, EventArgs e)
        {
            string nombreRol = nombre.Text;
            
            //String itemSeleccionado = Accesos.SelectedValue.ToString();
            Boolean tilde = this.db.Consultar("SELECT r.ID_ROL, r.ROL_DESCRIPCION, p.PERMISO_STOCK, p.PERMISO_PRODUCTO, p.PERMISO_F_CAJA, p.PERMISO_CONSULTAS, p.PERMISO_AGENDA, p.PERMISO_REPORTES, p.PERMISO_CONF FROM ROL r,PERMISO p,PERMISO_ROL pr WHERE ROL_DESCRIPCION='" + nombreRol + "' AND pr.ID_ROL=r.ID_ROL AND pr.ID_PERMISO=p.ID_PERMISO");

            int acceso1 = 0;
            int acceso2 = 0;
            int acceso3 = 0;
            int acceso4 = 0;
            int acceso5 = 0;
            int acceso6 = 0;
            int acceso7 = 0;

            if (!tilde)
            {
                if (Accesos.CheckedItems.Count != 0)
                {
                    string s = "";
                    string unAcceso = "";
                    
                    for (int x = 0; x <= Accesos.CheckedItems.Count - 1; x++)
                    {
                        s = s + "Checked Item " + (x + 1).ToString() + " = " + Accesos.CheckedItems[x].ToString() + "\n";
                        unAcceso = Accesos.CheckedItems[x].ToString();
                        if (unAcceso == "Gestión de Stock")
                        {
                            acceso1 = 1;
                        }
                        if (unAcceso == "Catálogo de Productos")
                        {
                            acceso2 = 1;
                        }
                        if (unAcceso == "Gestión de Flujo de Caja")
                        {
                            acceso3 = 1;
                        }
                        if (unAcceso == "Consultas")
                        {
                            acceso4 = 1;
                        }
                        if (unAcceso == "Agenda")
                        {
                            acceso5 = 1;
                        }
                        if (unAcceso == "Reportes")
                        {
                            acceso6 = 1;
                        }
                        if (unAcceso == "Configuración")
                        {
                            acceso7 = 1;
                        }  
                    }
                }

                //this.db.Ejecutar("INSERT INTO PERMISO (PERMISO_DESCRIPCION, PERMISO_STOCK, PERMISO_PRODUCTO, PERMISO_F_CAJA, PERMISO_CONSULTAS, PERMISO_AGENDA, PERMISO_REPORTES, PERMISO_CONF) VALUES ('Permisos para" + nombreRol+"',"+ Convert.ToBoolean(acceso1 == true ? 1 : 0) + "," + Convert.ToBoolean(acceso2 == true ? 1 : 0) + "," + Convert.ToBoolean(acceso3 == true ? 1 : 0) + "," + Convert.ToBoolean(acceso4 == true ? 1 : 0) + "," + Convert.ToBoolean(acceso5 == true ? 1 : 0) + "," + Convert.ToBoolean(acceso6 == true ? 1 : 0) + "," + Convert.ToBoolean(acceso7 == true ? 1 : 0) + ")");
                this.db.Ejecutar("INSERT INTO PERMISO (PERMISO_DESCRIPCION, PERMISO_STOCK, PERMISO_PRODUCTO, PERMISO_F_CAJA, PERMISO_CONSULTAS, PERMISO_AGENDA, PERMISO_REPORTES, PERMISO_CONF) VALUES ('Permisos para " + nombreRol + "'," + acceso1 + "," + acceso2 + "," + acceso3 + "," + acceso4 + "," + acceso5+ "," +acceso6 + "," + acceso7+ ")");
                this.db.Consultar("SELECT @@IDENTITY 'ID_PERMISO'");
                this.db.Leer();
                Decimal idPermiso = Decimal.Parse(this.db.ObtenerValor("ID_PERMISO"));

                this.db.Ejecutar("INSERT INTO ROL (ROL_DESCRIPCION) VALUES ('" + nombreRol + "')");
                this.db.Consultar("SELECT @@IDENTITY 'ID_ROL'");
                this.db.Leer();
                Decimal idRol = Decimal.Parse(this.db.ObtenerValor("ID_ROL"));

                this.db.Ejecutar("INSERT INTO PERMISO_ROL (ID_PERMISO, ID_ROL) VALUES (" + idPermiso + ","+ idRol+")");
                MessageBox.Show("El Rol se ha creado correctamente");
                this.Dispose();
            }
            else
            {
                MessageBox.Show("El rol ingresado ya está existe. Por favor, ingrese otro nombre del rol.");
            }
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
