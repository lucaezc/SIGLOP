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
    public partial class AltaDeUsuario : Form
    {
        private dbmanager db;
        public AltaDeUsuario(dbmanager db)
        {
            InitializeComponent();
            this.db = db;
            this.CargaCombo();
        }

        private void CargaCombo()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT ROL_DESCRIPCION FROM ROL", this.db.StringConexion());
            da.Fill(ds, "ROL");
            this.cmbRol.DataSource = ds.Tables[0].DefaultView;
            this.cmbRol.DisplayMember = "ROL_DESCRIPCION";
            this.cmbRol.ValueMember = "ROL_DESCRIPCION";
        }

        public void validarDatos()
        {
            string usuario = txtUsr.Text;
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text; 
            string rol = cmbRol.Text;
            string contrasenia = txtPwd.Text;
            string contraseniaRepe = txtConfirmaPwd.Text;

            if (usuario == "")
            {
                MessageBox.Show("Por favor, ingrese el usuario.");
            }
            else
            {
                Boolean existe = false;
                existe = this.db.Consultar("SELECT USUARIO_ID, USUARIO_NOMBRE, USUARIO_APELLIDO, USUARIO_PASS, USUARIO_ES_ADMIN, CANT_INTENTOS_FALLIDOS FROM USUARIO WHERE USUARIO_ID = '" + usuario + "'");
                if (existe)
                {
                    MessageBox.Show("El usuario ingresado ya está en uso. Por favor, ingrese otro usuario.");
                    txtUsr.Focus();
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
                                        MessageBox.Show("Las contreñas no coinciden y deben coincidir.Por favor, vuelva a intentarlo.");
                                    }
                                    else
                                    {
                                        this.guardarUsuario();
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void guardarUsuario()
        {
            string usuario = txtUsr.Text;
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string rol = cmbRol.Text; 
            string contrasenia = txtPwd.Text;
            string contraseniaRepe = txtConfirmaPwd.Text;

            if ((usuario != "") && (apellido != "") && (rol != "") && (contrasenia != "") && (contraseniaRepe != "")  && (contrasenia==contraseniaRepe))
            {
                this.db.Ejecutar("INSERT INTO USUARIO (USUARIO_ID, USUARIO_NOMBRE, USUARIO_APELLIDO, USUARIO_PASS, USUARIO_ES_ADMIN," +
                "CANT_INTENTOS_FALLIDOS) VALUES ('" + usuario + "', '" + nombre + "', '" + apellido + "', '" + contrasenia + 
                "', '" + "0" + "', '" + "0" + "')");

                this.db.Consultar("SELECT @@IDENTITY 'ID_USUARIO'");
                this.db.Leer();
                Decimal idUsuario = Decimal.Parse(this.db.ObtenerValor("ID_USUARIO"));

                this.db.Consultar("SELECT ID_ROL FROM ROL WHERE ROL_DESCRIPCION='" + rol + "'");
                this.db.Leer();
                string idRol = this.db.ObtenerValor("ID_ROL");
                this.db.Ejecutar("INSERT INTO REL_ROL_USUARIO (ID_USUARIO, ID_ROL) VALUES("+ idUsuario + ", "+ idRol +")");
                this.Dispose();
                MessageBox.Show("Usuario creado correctamente.");
            }
        } 

        private void btnConfirmaAlta_Click(object sender, EventArgs e)
        {
            this.validarDatos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
