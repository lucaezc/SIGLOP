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
    public partial class ModificacionDeUsuario : Form
    {
        private dbmanager db;
        string usuarioID = "0";
        public ModificacionDeUsuario(dbmanager db)
        {
            InitializeComponent();
            this.db = db;

            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(Buscador, "Ingrese el id de usuario o el nombre del usuario a buscar.");
        }

        private void CargaCombo()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT ROL_DESCRIPCION FROM ROL", this.db.StringConexion());
            da.Fill(ds, "ROL");
            this.comboBoxRol.DataSource = ds.Tables[0].DefaultView;
            this.comboBoxRol.DisplayMember = "ROL_DESCRIPCION";
            this.comboBoxRol.ValueMember = "ROL_DESCRIPCION";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (Buscador.Text != "")
            {
                Boolean existe = this.db.Consultar("SELECT ID_USUARIO, USUARIO_ID, USUARIO_NOMBRE, USUARIO_APELLIDO, USUARIO_PASS from USUARIO WHERE UPPER(USUARIO_NOMBRE+' '+USUARIO_APELLIDO) LIKE '" + Buscador.Text.ToUpper() + "%' OR USUARIO_APELLIDO LIKE '" + Buscador.Text.ToUpper() + "%' OR USUARIO_ID LIKE '" + Buscador.Text.ToUpper() + "%'");
                
                if (existe)
                    {
                        this.db.Leer();
                        usuarioID = this.db.ObtenerValor("ID_USUARIO");
                        textUsuario.Text = this.db.ObtenerValor("USUARIO_ID");
                        string usuario = this.db.ObtenerValor("USUARIO_ID");
                                            
                        if (this.db.ObtenerValor("USUARIO_NOMBRE") != "")
                        {
                            textNombre.Text = this.db.ObtenerValor("USUARIO_NOMBRE");
                        }
                        else
                        {
                            textNombre.Text = "";
                        }

                        if (this.db.ObtenerValor("USUARIO_APELLIDO") != "")
                        {
                            textApellido.Text = this.db.ObtenerValor("USUARIO_APELLIDO");
                        }
                        else
                        {
                            textApellido.Text = "";
                        }

                        textContrasenia.Text = this.db.ObtenerValor("USUARIO_PASS");
                        textContraseniaRepe.Text = this.db.ObtenerValor("USUARIO_PASS");
                        this.CargaCombo();
                        /*if (comboBoxRol.SelectedIndexChanged = true)
                        {
                            this.CargaCombo();
                        }
                        else
                        {
                            this.db.Consultar("SELECT a.ROL_DESCRIPCION from USUARIO u, ROL a, REL_ROL_USUARIO r WHERE u.ID_USUARIO=r.ID_USUARIO AND r.ID_ROL=a.ID_ROL AND u.USUARIO_ID='" + usuario + "'");
                            this.db.Leer();
                            comboBoxRol.Text = this.db.ObtenerValor("ROL_DESCRIPCION");
                        }*/
                    }
                    else
                    {
                        MessageBox.Show("El Usuario buscado no existe en el sistema.");
                    }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese el nombre sin/con el apellido del usuario a buscar. Tenga en cuenta que cuanto más específico sea, mejor será la búsqueda.");
            }
        }

        private void ModificarU_Click(object sender, EventArgs e)
        {
            if (usuarioID == "0")
            {
                MessageBox.Show("Por favor, busque un usuario en el sistema. ");
            }
            else
            {
                string usuario = textUsuario.Text;
                string nombre = textNombre.Text;
                string apellido = textApellido.Text;
                string rol = comboBoxRol.Text;
                string contrasenia = textContrasenia.Text;
                string contraseniaRepe = textContraseniaRepe.Text;

                if (usuario == "")
                {
                    MessageBox.Show("Por favor, ingrese el usuario.");
                }
                else
                {
                    Boolean existe = false;
                    existe = this.db.Consultar("SELECT ID_USUARIO, USUARIO_ID, USUARIO_NOMBRE, USUARIO_APELLIDO, USUARIO_PASS, USUARIO_ES_ADMIN, CANT_INTENTOS_FALLIDOS FROM USUARIO WHERE USUARIO_ID = '" + usuario + "'");
                    this.db.Leer();
                    string usuarioIDNow = this.db.ObtenerValor("ID_USUARIO");

                    if (existe && (usuarioID != usuarioIDNow)) //Existe y modifico los datos del mismo usuario que no sean el ID de Usuario...
                    {
                        MessageBox.Show("Ese usuario ya está en uso. Por favor, ingrese otro usuario.");
                        textUsuario.Focus();
                    }
                    else
                    {
                        if (nombre == "")
                        {
                            MessageBox.Show("Debe ingresar su nombre.");
                        }
                        else
                        {
                            if (apellido == "")
                            {
                                MessageBox.Show("Debe ingresar su apellido.");
                            }
                            else
                            {
                                if (rol == "")
                                {
                                    MessageBox.Show("Debe seleccionar un rol.");
                                    this.CargaCombo();
                                }
                                else
                                {
                                    if (contrasenia == "")
                                    {
                                        MessageBox.Show("Debe ingresar una contraseña.");
                                    }
                                    else
                                    {
                                        if (contrasenia != contraseniaRepe)
                                        {
                                            MessageBox.Show("Las contraseñas no coinciden y deben coincidir.Por favor, vuelva a intentarlo.");
                                        }
                                        else
                                        {
                                            this.db.Ejecutar("UPDATE USUARIO SET USUARIO_ID='"+ usuario +"', USUARIO_NOMBRE='"+ nombre +"', USUARIO_APELLIDO='"+ apellido +"', USUARIO_PASS='" + contrasenia +"'WHERE USUARIO_ID='"+usuario+"'");
                                            bool existeRol = this.db.Consultar("SELECT ID_ROL FROM ROL WHERE ROL_DESCRIPCION='" + comboBoxRol.Text + "'");

                                            if (existeRol)
                                            {
                                                this.db.Leer();
                                                string idRol = this.db.ObtenerValor("ID_ROL");

                                                this.db.Ejecutar("UPDATE REL_ROL_USUARIO SET ID_ROL=" + idRol + "WHERE ID_USUARIO=" + usuarioIDNow);
                                                this.Dispose();
                                                MessageBox.Show("Usuario actualizado.");
                                            }
                                            else
                                            {
                                                MessageBox.Show("Por favor, ingrese un Rol válido.");
                                            }
                                        }
                                    }
                                }
                            }
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
