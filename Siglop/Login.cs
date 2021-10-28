using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Siglop
{
    public partial class Login : Form
    {
        private dbmanager db;
        private String username;
        private String password;
        private String hashPass;
        public static Decimal rolSeleccionado;

        public Login(dbmanager db)
        {
            InitializeComponent();
            this.db = db;
        }
        
        public string hash(string input)
        {
            SHA256 hash = SHA256.Create();

            // Convertir la cadena en un array de bytes y calcular hash
            byte[] data = hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Copiar cada elemento del array a un StringBuilder en formato hexadecimal
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                MessageBox.Show("Debe ingresar el usuario.\n");
            }
            else
            {
                username = txtUsuario.Text;
                Boolean existe = false;
                existe = this.db.Consultar("SELECT USUARIO_ID, USUARIO_NOMBRE, USUARIO_APELLIDO, USUARIO_PASS, USUARIO_ES_ADMIN, CANT_INTENTOS_FALLIDOS FROM USUARIO WHERE USUARIO_ID = '" + username + "' AND CANT_INTENTOS_FALLIDOS < 3");
                if (!existe)
                {
                    MessageBox.Show("El usuario ingresado no existe en la base de datos o fue inhabilitado.");
                    txtPwd.Text = "";
                    txtUsuario.Text = "";
                    txtUsuario.Focus();
                }
                else
                {
                    if (txtPwd.Text == "")
                    {
                        MessageBox.Show("Debe ingresar la contraseña.\n");
                    }
                    else
                    {
                        hashPass = this.hash(txtPwd.Text.Trim());
                        password = txtPwd.Text.Trim();
                        this.db.Leer();
                        String dbUsername = this.db.ObtenerValor("USUARIO_ID");
                        String dbPassword = this.db.ObtenerValor("USUARIO_PASS");
                        int dbIntentos_Fallidos = Int32.Parse(this.db.ObtenerValor("CANT_INTENTOS_FALLIDOS"));

                        if ((password == dbPassword) || (hashPass == dbPassword))
                        {
                            if (dbIntentos_Fallidos > 0) //Resetea
                            {
                                this.db.Ejecutar("UPDATE USUARIO SET CANT_INTENTOS_FALLIDOS = 0 WHERE USUARIO_ID = '" + username + "'");
                            }

                            Menu g = new Menu(db, dbUsername);
                            g.Show();
                            this.Hide(); //Ocultar login
            
                        }
                        else
                        {
                            MessageBox.Show("No se ha ingresado correctamente el usuario y/o la contraseña.\nPor favor, intentelo nuevamente.\n");
                            this.db.Ejecutar("UPDATE USUARIO SET CANT_INTENTOS_FALLIDOS = CANT_INTENTOS_FALLIDOS + 1 WHERE USUARIO_ID = '" + username + "'");
                 
                            if (dbIntentos_Fallidos == 3)
                            {
                                MessageBox.Show("El usuario se ha inhabilitado debido a que se superó la cantidad de intentos fallidos.");
                            }
                 
                            dbIntentos_Fallidos = dbIntentos_Fallidos + 1;
                        }
                    }
                }
            }
}

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            AltaDeUsuario g = new AltaDeUsuario(db);
            g.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        
    }
}
