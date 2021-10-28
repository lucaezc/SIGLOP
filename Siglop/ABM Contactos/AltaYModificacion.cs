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

     partial class AltaContacto : Form
    {
        private dbmanager db;
        String usuarioID;
        Boolean vacio = true;
        Boolean actualiza = false;

        public AltaContacto(dbmanager db)
        {
            InitializeComponent();
            this.db = db;
            confirmarAlta.Text = "Guardar Alta";
            CargaCombo();
        }

        private void CargaCombo() //CARGA COMBOBOX
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT ID_TIPO_CONTACTO, TIPO_CONTACTO_DESCRIPCION FROM TIPO_CONTACTO", this.db.StringConexion());
            da.Fill(ds, "SIGLOP.TIPO_CONTACTO");
            this.cbTipoContacto.DataSource = ds.Tables[0].DefaultView;
            this.cbTipoContacto.DisplayMember = "TIPO_CONTACTO_DESCRIPCION";
            this.cbTipoContacto.ValueMember = "ID_TIPO_CONTACTO";
        }

        public AltaContacto(dbmanager db, string usuarioID, ListBox listado)  //Este metodo se usa para Modificar contacto
        {
            InitializeComponent();
            this.db = db;
            confirmarAlta.Text = "Guardar";
            this.Text = "Modificar Contacto";
            
            this.usuarioID = usuarioID;
            CargaCombo();
            Boolean existe = this.db.Consultar("SELECT a.ID_CONTACTO, a.AGENDA_NOMBRE, a.AGENDA_APELLIDO, a.AGENDA_EMAIL, a.AGENDA_TELEFONO1, a.AGENDA_TELEFONO2, a.AGENDA_TELEFONO3, a.AGENDA_DIRECCION, a.AGENDA_TIPO from AGENDA a WHERE a.ID_CONTACTO =" + usuarioID);

                
                if (existe)
                {
                    this.db.Leer();


                    if (this.db.ObtenerValor("AGENDA_NOMBRE") != "Nulo")
                    {
                        nombre.Text = this.db.ObtenerValor("AGENDA_NOMBRE");
                    }
                    else
                    {
                        nombre.Text = "";
                    }


                    if (this.db.ObtenerValor("AGENDA_APELLIDO") != "Nulo")
                    {
                        apellido.Text = this.db.ObtenerValor("AGENDA_APELLIDO");
                    }
                    else
                    {
                        apellido.Text = "";
                    }


                    if (this.db.ObtenerValor("AGENDA_DIRECCION") != "Nulo")
                    {
                        direccion.Text = this.db.ObtenerValor("AGENDA_DIRECCION");
                    }
                    else
                    {
                        direccion.Text = "";
                    }


                    if (this.db.ObtenerValor("AGENDA_EMAIL") != "Nulo")
                    {
                        mail.Text = this.db.ObtenerValor("AGENDA_EMAIL");
                    }
                    else
                    {
                        mail.Text = "";
                    }


                    if (this.db.ObtenerValor("AGENDA_TELEFONO1") != "Nulo")
                    {
                        telefono1.Text = this.db.ObtenerValor("AGENDA_TELEFONO1");
                    }
                    else
                    {
                        telefono1.Text = "";
                    }


                    if (this.db.ObtenerValor("AGENDA_TELEFONO2") != "Nulo")
                    {
                        telefono2.Text = this.db.ObtenerValor("AGENDA_TELEFONO2");
                    }
                    else
                    {
                        telefono2.Text = "";
                    }


                    if (this.db.ObtenerValor("AGENDA_TELEFONO3") != "Nulo")
                    {
                        telefono3.Text = this.db.ObtenerValor("AGENDA_TELEFONO3");
                    }
                    else
                    {
                        telefono3.Text = "";
                    }

                    cbTipoContacto.SelectedIndex = Int32.Parse(this.db.ObtenerValor("AGENDA_TIPO")) - 1;


                }

                else {
                    MessageBox.Show("No existe el Contacto buscado  ");
                }

                listado.Refresh();
                listado.Update();

        }

        private void guardarcontacto()
        {
            string contacto_Nombre = nombre.Text;
            string contacto_Apellido = apellido.Text;
            string contacto_Direccion = direccion.Text;
            string contacto_Mail = mail.Text;
            string contacto_Telefono1 = telefono1.Text.Trim();
            string contacto_Telefono2 = telefono2.Text.Trim();
            string contacto_Telefono3 = telefono3.Text.Trim();

            if (telefono1.Text.Trim() == "")
            {
                contacto_Telefono1 = "NULL";
            }
            else
            {
                contacto_Telefono1 = telefono1.Text;
            }
            if (telefono2.Text.Trim() == "")
            {
                contacto_Telefono2 = "NULL";
            }
            else
            {
                contacto_Telefono2 = telefono2.Text;
            }
            if (telefono3.Text.Trim() == "")
            {
                contacto_Telefono3 = "NULL";
            }
            else
            {
                contacto_Telefono3 = telefono3.Text;
            }
            Decimal tipoContacto = Decimal.Parse(cbTipoContacto.SelectedValue.ToString());

            this.db.Ejecutar("INSERT INTO AGENDA (AGENDA_TIPO, AGENDA_NOMBRE, AGENDA_APELLIDO, AGENDA_EMAIL, AGENDA_TELEFONO1, AGENDA_TELEFONO2, AGENDA_TELEFONO3, AGENDA_DIRECCION ) VALUES" +
            "(" + tipoContacto + ",'" + contacto_Nombre + "', '" + contacto_Apellido + "', '" + contacto_Mail + "', " + contacto_Telefono1 + ", " + contacto_Telefono2 + ", " + contacto_Telefono3 + ", '" + contacto_Direccion + "')");

        }

        private void nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void apellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void confirmarAlta_Click( object sender, EventArgs e)
        {
            string mensaje = "";
            if (nombre.Text == "")
            {
                mensaje += "Debe ingresar el nombre del contacto.\n";
                vacio = false;
            }

            if (apellido.Text == "")
            {
                mensaje += "Debe ingresar el apellido del contacto.\n";
                vacio = false;
            }

            if (direccion.Text == "")
            {
                mensaje += "Debe ingresar la direccion del contacto.\n";
                vacio = false;
            }

            if (mail.Text == "")
            {
                mensaje += "Debe ingresar el mail del contacto.\n";
                vacio = false;
            }

            if (telefono1.Text == "" && telefono2.Text == "" && telefono3.Text == "")
            {
                mensaje += "Debe ingresar al menos un telefono del contacto.\n";
                vacio = false;
            }


            if (vacio)
            {
                if (confirmarAlta.Text == "Guardar")
                {
                    this.modificar();
                    this.actualiza = true;
                    this.Dispose();
                }
                else
                {
                    this.guardarcontacto();
                    this.Dispose();
                }
            }
            else
            {
                MessageBox.Show(mensaje);
            }

        }

        private void modificar()
        {
            string contacto_Nombre = nombre.Text;
            string contacto_Apellido = apellido.Text;
            string contacto_Direccion = direccion.Text;
            string contacto_Mail = mail.Text;
            string contacto_Telefono1 = telefono1.Text.Trim();
            string contacto_Telefono2 = telefono2.Text.Trim();
            string contacto_Telefono3 = telefono3.Text.Trim();

            if (telefono1.Text.Trim() == "")
            {
                contacto_Telefono1 = "NULL";
            }
            else
            {
                contacto_Telefono1 = telefono1.Text;
            }
            if (telefono2.Text.Trim() == "")
            {
                contacto_Telefono2 = "NULL";
            }
            else
            {
                contacto_Telefono2 = telefono2.Text;
            }
            if (telefono3.Text.Trim() == "")
            {
                contacto_Telefono3 = "NULL";
            }
            else
            {
                contacto_Telefono3 = telefono3.Text;
            }

            Decimal tipoContacto = Decimal.Parse(cbTipoContacto.SelectedValue.ToString());

            this.db.Ejecutar("UPDATE AGENDA SET " +
            "AGENDA_TIPO = " + tipoContacto + " , AGENDA_NOMBRE='" + contacto_Nombre + "', AGENDA_APELLIDO='" + contacto_Apellido + "', AGENDA_EMAIL='" + contacto_Mail + "', " +
            "AGENDA_TELEFONO1='" + contacto_Telefono1 + "', AGENDA_TELEFONO2='" + contacto_Telefono2 + "', AGENDA_TELEFONO3='" + contacto_Telefono3 + "', AGENDA_DIRECCION='" + contacto_Direccion + "' " +
            "WHERE ID_CONTACTO = '" + this.usuarioID + "'"); 

        }

    }
}
