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
    public partial class Agenda : Form
    {

        private dbmanager db;
        System.Data.SqlClient.SqlDataAdapter da;
        private String usuarioID;
    
        public Agenda(dbmanager db)
        {
            InitializeComponent();
            this.db = db;
            CargaListado();

        }

        private void CargaListado(){
            DataTable dt = new DataTable();
            string query = "SELECT a.ID_CONTACTO,  a.AGENDA_NOMBRE +' '+ a.AGENDA_APELLIDO AS DESCRIPCION, a.AGENDA_EMAIL, a.AGENDA_TELEFONO1, a.AGENDA_TELEFONO2, a.AGENDA_TELEFONO3, a.AGENDA_DIRECCION from AGENDA a";
            da = new System.Data.SqlClient.SqlDataAdapter(query, this.db.StringConexion());

            da.SelectCommand.CommandType = CommandType.Text;
            da.Fill(dt);
            //conn.Open();

            if (dt.Rows.Count > 0)
            {
                Listado.DataSource = dt;
                Listado.DisplayMember = "DESCRIPCION";
                Listado.ValueMember = "ID_CONTACTO";
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

      

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Listado_SelectedIndexChanged(object sender, EventArgs e)
        {
            String itemSeleccionado = Listado.SelectedValue.ToString();
            String nombreSeleccionado = Listado.SelectedItem.ToString();

            if (itemSeleccionado != "System.Data.DataRowView")
            {
                Boolean existe = this.db.Consultar("SELECT a.ID_CONTACTO, a.AGENDA_NOMBRE, a.AGENDA_APELLIDO, a.AGENDA_EMAIL, a.AGENDA_TELEFONO1, a.AGENDA_TELEFONO2, a.AGENDA_TELEFONO3, a.AGENDA_DIRECCION, tc.TIPO_CONTACTO_DESCRIPCION from AGENDA a JOIN TIPO_CONTACTO tc ON a.AGENDA_TIPO = tc.ID_TIPO_CONTACTO WHERE a.ID_CONTACTO =" + itemSeleccionado);
                
                if (existe)
                {
                    this.db.Leer();

                    usuarioID = this.db.ObtenerValor("ID_CONTACTO");

                    if (this.db.ObtenerValor("AGENDA_NOMBRE") != "Nulo")
                    {
                        T_Nombre.Text = this.db.ObtenerValor("AGENDA_NOMBRE");
                    }
                    else
                    {
                        T_Nombre.Text = "";
                    }


                    if (this.db.ObtenerValor("AGENDA_APELLIDO") != "Nulo")
                    {
                        T_Apellido.Text = this.db.ObtenerValor("AGENDA_APELLIDO");
                    }
                    else
                    {
                        T_Apellido.Text = "";
                    }


                    if (this.db.ObtenerValor("AGENDA_DIRECCION") != "Nulo")
                    {
                        T_Direccion.Text = this.db.ObtenerValor("AGENDA_DIRECCION");
                    }
                    else
                    {
                        T_Direccion.Text = "";
                    }


                    if (this.db.ObtenerValor("AGENDA_EMAIL") != "Nulo")
                    {
                        T_Mail.Text = this.db.ObtenerValor("AGENDA_EMAIL");
                    }
                    else
                    {
                        T_Mail.Text = "";
                    }


                    if (this.db.ObtenerValor("AGENDA_TELEFONO1") != "Nulo")
                    {
                        T_Telefono1.Text = this.db.ObtenerValor("AGENDA_TELEFONO1");
                    }
                    else
                    {
                        T_Telefono1.Text = "";
                    }


                    if (this.db.ObtenerValor("AGENDA_TELEFONO2") != "Nulo")
                    {
                        T_Telefono2.Text = this.db.ObtenerValor("AGENDA_TELEFONO2");
                    }
                    else
                    {
                        T_Telefono2.Text = "";
                    }


                    if (this.db.ObtenerValor("AGENDA_TELEFONO3") != "Nulo")
                    {
                        T_Telefono3.Text = this.db.ObtenerValor("AGENDA_TELEFONO3");
                    }
                    else
                    {
                        T_Telefono3.Text = "";
                    }

                    tbTipoContacto.Text = this.db.ObtenerValor("TIPO_CONTACTO_DESCRIPCION");

                }

                else {
                    MessageBox.Show("No existe el Contacto buscado  ");
                }
            }


        }


        private void Agenda_Load(object sender, EventArgs e)
        {

        }

        private void T_Nombre_TextChanged(object sender, EventArgs e)
        {
       
        }

        private void T_Apellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void T_Telefono1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Buscador_TextChanged(object sender, EventArgs e)
        {

        }

        private void Buscador_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
                {
                           
                pictureBox1_Click( sender, e);
        }
        }

        private void pictureBox1_Click(object sender, EventArgs e) // BUSCAR
        {
            Boolean existe = this.db.Consultar("SELECT a.ID_CONTACTO, a.AGENDA_NOMBRE, a.AGENDA_APELLIDO,a.AGENDA_NOMBRE +' '+ a.AGENDA_APELLIDO AS DESCRIPCION, a.AGENDA_EMAIL, a.AGENDA_TELEFONO1, a.AGENDA_TELEFONO2, a.AGENDA_TELEFONO3, a.AGENDA_DIRECCION, tc.TIPO_CONTACTO_DESCRIPCION from AGENDA a JOIN TIPO_CONTACTO tc ON a.AGENDA_TIPO = tc.ID_TIPO_CONTACTO WHERE UPPER(a.AGENDA_NOMBRE+' '+a.AGENDA_APELLIDO) LIKE '" + Buscador.Text.ToUpper() + "%'");
            {
                this.db.Leer();
                usuarioID = this.db.ObtenerValor("ID_CONTACTO");

                if (existe)
                {

                    if (this.db.ObtenerValor("AGENDA_NOMBRE") != "Nulo")
                    {
                        T_Nombre.Text = this.db.ObtenerValor("AGENDA_NOMBRE");
                    }
                    else
                    {
                        T_Nombre.Text = "";
                    }


                    if (this.db.ObtenerValor("AGENDA_APELLIDO") != "Nulo")
                    {
                        T_Apellido.Text = this.db.ObtenerValor("AGENDA_APELLIDO");
                    }
                    else
                    {
                        T_Apellido.Text = "";
                    }


                    if (this.db.ObtenerValor("AGENDA_DIRECCION") != "Nulo")
                    {
                        T_Direccion.Text = this.db.ObtenerValor("AGENDA_DIRECCION");
                    }
                    else
                    {
                        T_Direccion.Text = "";
                    }


                    if (this.db.ObtenerValor("AGENDA_EMAIL") != "Nulo")
                    {
                        T_Mail.Text = this.db.ObtenerValor("AGENDA_EMAIL");
                    }
                    else
                    {
                        T_Mail.Text = "";
                    }


                    if (this.db.ObtenerValor("AGENDA_TELEFONO1") != "Nulo")
                    {
                        T_Telefono1.Text = this.db.ObtenerValor("AGENDA_TELEFONO1");
                    }
                    else
                    {
                        T_Telefono1.Text = "";
                    }


                    if (this.db.ObtenerValor("AGENDA_TELEFONO2") != "Nulo")
                    {
                        T_Telefono2.Text = this.db.ObtenerValor("AGENDA_TELEFONO2");
                    }
                    else
                    {
                        T_Telefono2.Text = "";
                    }


                    if (this.db.ObtenerValor("AGENDA_TELEFONO3") != "Nulo")
                    {
                        T_Telefono3.Text = this.db.ObtenerValor("AGENDA_TELEFONO3");
                    }
                    else
                    {
                        T_Telefono3.Text = "";
                    }
                    tbTipoContacto.Text = this.db.ObtenerValor("TIPO_CONTACTO_DESCRIPCION");
                }
                else {
                    MessageBox.Show("No existe el Contacto buscado.");
                }
            }
        }

        private void Alta_Contacto_Click( object sender, EventArgs e)
        {
            AltaContacto a = new AltaContacto(this.db);
            DialogResult res = a.ShowDialog(); // Comunicación entre formularios  
            if (res == DialogResult.OK) // Cuando vuelve del otro Form con el botón Aceptar
            {
                CargaListado();
            }
        }

        private void Eliminar_Contacto_Click(object sender, EventArgs e)
        {
            if (usuarioID != "0")
            {

                string message =
                "Esta seguro de que quiere eliminar al contacto: " + T_Nombre.Text + " " + T_Apellido.Text;
                const string caption = "Borrar Contacto";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    this.db.Ejecutar("DELETE AGENDA  WHERE ID_CONTACTO = " + usuarioID);
                    MessageBox.Show("CONTACTO eliminado.");
                    CargaListado();
                }

            }
            else {

                MessageBox.Show("Seleccionar CONTACTO.");
            }
           
        }

        private void Modificar_Click(object sender, EventArgs e)
        {

            if (usuarioID == null )
            {
                MessageBox.Show("Usted debe seleccionar un contacto a modificar. ");
            }
            else
            {
                AltaContacto m = new AltaContacto(this.db, this.usuarioID, this.Listado);
                DialogResult res = m.ShowDialog(); // Comunicación entre formularios  
                if (res == DialogResult.OK) // Cuando vuelve del otro Form con el botón Aceptar
                {
                    CargaListado();
                }
            }
            
        }


     

     

 

    }
}
