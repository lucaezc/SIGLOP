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
    public partial class Usuarios : Form
    {
        private dbmanager db;
        System.Data.SqlClient.SqlDataAdapter da;
        private String usuarioID= "";
        public Usuarios(dbmanager db)
        {
            InitializeComponent();
            this.db = db;
            this.cargarTabla(db);
        }

        private void cargarTabla(dbmanager db)
        {
            DataTable dt = new DataTable();
            string query =
                "SELECT u.ID_USUARIO AS ID, u.USUARIO_ID AS USUARIO_ID, u.USUARIO_NOMBRE, u.USUARIO_APELLIDO,"
                + "a.ROL_DESCRIPCION from USUARIO u, ROL a, REL_ROL_USUARIO r WHERE u.ID_USUARIO=r.ID_USUARIO AND r.ID_ROL=a.ID_ROL";
            da = new System.Data.SqlClient.SqlDataAdapter(query, this.db.StringConexion());

            da.SelectCommand.CommandType = CommandType.Text;
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                ListadoUsuarios.DataSource = dt;
                ListadoUsuarios.DisplayMember = "DESCRIPCION";
                ListadoUsuarios.ValueMember = "USUARIO_ID";
            }
        }

        private void ConfirmarAltaU_Click(object sender, EventArgs e)
        {
            AltaDeUsuario g = new AltaDeUsuario(this.db);
            DialogResult res = g.ShowDialog(); // Comunicación entre formularios  
            if (res == DialogResult.Cancel)
            {
                cargarTabla(this.db);
            }           
        }

        private void bModifUsuarios_Click(object sender, EventArgs e)
        {
            ModificacionDeUsuario g = new ModificacionDeUsuario(this.db);
            DialogResult res = g.ShowDialog();
            if (res == DialogResult.OK)
            {
                cargarTabla(this.db);
            }  
        }

        private void bEliminUsuarios_Click(object sender, EventArgs e)
        {          
            if (usuarioID != "")
            {
                string message =
                "¿Está seguro de que quiere eliminar el usuario: " + textNombre.Text + " " + textApellido.Text;
                const string caption = "Borrar Usuario";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    this.db.Consultar("SELECT ID_USUARIO FROM USUARIO WHERE USUARIO_ID='"+ usuarioID +"'");
                    this.db.Leer();
                    String idUsuario = this.db.ObtenerValor("ID_USUARIO");

                    this.db.Ejecutar("DELETE REL_ROL_USUARIO WHERE ID_USUARIO=" + idUsuario);
                    this.db.Ejecutar("DELETE USUARIO WHERE USUARIO_ID='" + usuarioID + "'");
                    MessageBox.Show("Usuario eliminado.");
                    cargarTabla(this.db);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un usuario.");
            }
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ListadoUsuarios_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            String itemSeleccionado = ListadoUsuarios.SelectedValue.ToString();
            String nombreSeleccionado = ListadoUsuarios.SelectedItem.ToString();

            if (itemSeleccionado != "System.Data.DataRowView")
            {
                Boolean existe = this.db.Consultar("SELECT u.ID_USUARIO, u.USUARIO_ID, u.USUARIO_NOMBRE as USUARIO_NOMBRE, u.USUARIO_APELLIDO, a.ROL_DESCRIPCION from USUARIO u,"
                    + "ROL a, REL_ROL_USUARIO r WHERE u.USUARIO_ID='" + itemSeleccionado + "' AND u.ID_USUARIO=r.ID_USUARIO AND r.ID_ROL=a.ID_ROL");

                usuarioID = itemSeleccionado;

                if (existe)
                {
                    this.db.Leer();
                    usuariosNombre.Text = this.db.ObtenerValor("USUARIO_ID");

                    if (this.db.ObtenerValor("USUARIO_NOMBRE") != "")
                    {
                        textNombre.Text = this.db.ObtenerValor("USUARIO_NOMBRE");
                    }
                    else
                    {
                        textNombre.Text = "";
                    }

                    if (this.db.ObtenerValor("USUARIO_APELLIDO") != "Nulo")
                    {
                        textApellido.Text = this.db.ObtenerValor("USUARIO_APELLIDO");
                    }
                    else
                    {
                        textApellido.Text = "";
                    }

                    if (this.db.ObtenerValor("ROL_DESCRIPCION") != "Nulo")
                    {
                        textRol.Text = this.db.ObtenerValor("ROL_DESCRIPCION");
                    }
                    else
                    {
                        textRol.Text = "";
                    }
                }
            }
        }
    }
}
