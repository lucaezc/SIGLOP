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
    public partial class Parametrizacion : Form
    {
        private dbmanager db;
        public Parametrizacion(dbmanager db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCaja_Click(object sender, EventArgs e)
        {
            DetallesFlujoDeCaja g = new DetallesFlujoDeCaja(this.db);
            g.Show();
        }

        private void btnMatPrima_Click(object sender, EventArgs e)
        {
            MateriasPrimas g = new MateriasPrimas(this.db);
            g.Show();
        }
    }
}
