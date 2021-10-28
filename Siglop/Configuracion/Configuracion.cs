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
    public partial class Configuracion : Form
    {
        private dbmanager db;
        public Configuracion(dbmanager db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            Usuarios g = new Usuarios(this.db);
            g.Show();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            Roles g = new Roles(this.db);
            g.Show();
        }

        private void btnParametrizacion_Click(object sender, EventArgs e)
        {
            Parametrizacion g = new Parametrizacion(this.db);
            g.Show();
        }

        private void btnOpciones_Click(object sender, EventArgs e)
        {
            Opciones g = new Opciones();
            g.Show();
        }
    }
}
