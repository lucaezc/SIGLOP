using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Siglop
{
    public partial class Menu : Form
    {

        private dbmanager db;
        private String usuarioId;
        public Menu(dbmanager db, String usuarioId)
        {
            InitializeComponent();
            this.db = db;
            this.usuarioId = usuarioId;
            revisarPermisos();
            if (SIGLOP.Properties.Settings.Default.AlertaFaltantes == 'S')
            {
                AlertaFaltantes();
            }
        }

        private void AlertaFaltantes()
        {
            String mensaje = "El/los siguientes producto/s está/n próximo/s a quedarse sin stock:\r\r";
            Boolean existe = this.db.Consultar("SELECT p.PRODUCTO_DESCRIPCION, t.TALLE_DESCRIPCION, c.COLOR_DESCRIPCION, ptc.PRODUCTO_STOCK FROM PRODUCTO p " +
                                               "JOIN PRODUCTO_TALLE_COLOR ptc ON p.ID_PRODUCTO = ptc.ID_PRODUCTO " +
                                               "JOIN TALLE t ON ptc.ID_TALLE = t.ID_TALLE " +
                                               "JOIN COLOR c ON ptc.ID_COLOR = c.ID_COLOR " +
                                               "WHERE ptc.PRODUCTO_STOCK < 5");
            if (existe)
            {
                while(this.db.Leer())
                {
                    mensaje = mensaje + this.db.ObtenerValor("PRODUCTO_DESCRIPCION") + "\r Talle: " + this.db.ObtenerValor("TALLE_DESCRIPCION") + ", Color: " + this.db.ObtenerValor("COLOR_DESCRIPCION") + ", Stock: " + this.db.ObtenerValor("PRODUCTO_STOCK") + "\r\r";
                }
            
                MessageBox.Show(mensaje, "ALERTA DE FALTANTES");
            }
        }

        private void revisarPermisos()
        {
            Boolean existe = this.db.Consultar( "SELECT P.PERMISO_AGENDA, P.PERMISO_CONF, P.PERMISO_CONSULTAS, P.PERMISO_F_CAJA, " +
                                                "P.PERMISO_PRODUCTO, P.PERMISO_REPORTES, P.PERMISO_STOCK, U.USUARIO_ES_ADMIN FROM USUARIO U " +
                                                "JOIN REL_ROL_USUARIO RU ON U.ID_USUARIO = RU.ID_USUARIO " +
                                                "JOIN PERMISO_ROL PR ON RU.ID_ROL = PR.ID_ROL " +
                                                "JOIN PERMISO P ON PR.ID_PERMISO = P.ID_PERMISO " + 
                                                "WHERE U.USUARIO_ID = '" + this.usuarioId + "'");
            if (existe)
            {
                this.db.Leer();
                Boolean admin = Boolean.Parse(this.db.ObtenerValor("USUARIO_ES_ADMIN"));
                Boolean permisoAgenda = Boolean.Parse(this.db.ObtenerValor("PERMISO_AGENDA"));
                Boolean permisoConfiguracion = Boolean.Parse(this.db.ObtenerValor("PERMISO_CONF"));
                Boolean permisoConsultas = Boolean.Parse(this.db.ObtenerValor("PERMISO_CONSULTAS"));
                Boolean permisoFCajas = Boolean.Parse(this.db.ObtenerValor("PERMISO_F_CAJA"));
                Boolean permisoProductos = Boolean.Parse(this.db.ObtenerValor("PERMISO_PRODUCTO"));
                Boolean permisoReportes = Boolean.Parse(this.db.ObtenerValor("PERMISO_REPORTES"));
                Boolean permisoStock = Boolean.Parse(this.db.ObtenerValor("PERMISO_STOCK"));

                if (!admin)
                {
                    if (!permisoAgenda)
                    {
                        btAgenda.Enabled = false;
                    }
                    if (!permisoConfiguracion)
                    {
                        btConfiguracion.Enabled = false;
                    }
                    if (!permisoConsultas)
                    {
                        btConsultas.Enabled = false;
                    }
                    if (!permisoFCajas)
                    {
                        btFlujoCaja.Enabled = false;
                    }
                    if (!permisoProductos)
                    {
                        btProductos.Enabled = false;
                    }
                    if (!permisoReportes)
                    {
                        btReportes.Enabled = false;
                    }
                    if (!permisoStock)
                    {
                        btStock.Enabled = false;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gestion_de_Stock g = new Gestion_de_Stock(this.db);
            g.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
         
            GestionFlujoDeCaja g = new GestionFlujoDeCaja(this.db);
            g.Show();
        }

        private void button4_Click(object sender, EventArgs e, dbmanager db)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Agenda a = new Agenda(this.db);
            a.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Reportes r = new Reportes(this.db);
            r.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Configuracion g = new Configuracion(db);
            g.Show();
        }

        private void UI005_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CargarListaCatálogoDeProductos c = new CargarListaCatálogoDeProductos(this.db);
            c.Show();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            string message = "¿Está seguro de que quiere salir de la aplicación?";
            const string caption = "Salir";
            var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
               this.Dispose();
               if (System.Windows.Forms.Application.MessageLoop)
               {
                  // WinForms app
                  System.Windows.Forms.Application.Exit();
               }
               else
               {
                  // Console app
                  System.Environment.Exit(1);
               }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ConsultaFlujoDeCaja c = new ConsultaFlujoDeCaja(this.db);
            c.Show();
        }

    
    }
}
