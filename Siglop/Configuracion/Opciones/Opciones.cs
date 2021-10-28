using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace Siglop
{
    public partial class Opciones : Form
    {
        public Opciones()
        {
            InitializeComponent();
            if (SIGLOP.Properties.Settings.Default.StockMateriasPrimas == 'S')
            {
                chkMatPrima.Checked = true;
            }
            else
            {
                chkMatPrima.Checked = false;
            }

            if (SIGLOP.Properties.Settings.Default.VistaStockSimple == 'S')
            {
                chkStkSimple.Checked = true;
            }
            else
            {
                chkStkSimple.Checked = false;
            }

            if (SIGLOP.Properties.Settings.Default.VistaStockCurvas == 'S')
            {
                chkStkCurva.Checked = true;
            }
            else
            {
                chkStkCurva.Checked = false;
            }

            if (SIGLOP.Properties.Settings.Default.AlertaFaltantes == 'S')
            {
                chkAlertaFaltantes.Checked = true;
            }
            else
            {
                chkAlertaFaltantes.Checked = false;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void chkMatPrima_CheckedChanged(object sender, EventArgs e) //Habilitar el calculo de materiales en Catalogo de productos.
        {
            if (chkMatPrima.Checked == true)
            {
                SIGLOP.Properties.Settings.Default.StockMateriasPrimas = 'S';
            }
            else
            {
                SIGLOP.Properties.Settings.Default.StockMateriasPrimas = 'N';
            }
            SIGLOP.Properties.Settings.Default.Save();
        }

        private void chkStkSimple_CheckedChanged(object sender, EventArgs e) //Habilitar vista simplificada en Gestion de Stock.
        {
            if (chkStkSimple.Checked == true)
            {
                SIGLOP.Properties.Settings.Default.VistaStockSimple = 'S';
            }
            else
            {
                SIGLOP.Properties.Settings.Default.VistaStockSimple = 'N';
            }
        }

        private void chkStkCurva_CheckedChanged(object sender, EventArgs e) //Habilitar vista x curvas en Gestion de Stock.
        {
            if (chkStkCurva.Checked == true)
            {
                SIGLOP.Properties.Settings.Default.VistaStockCurvas = 'S';
            }
            else
            {
                SIGLOP.Properties.Settings.Default.VistaStockCurvas = 'N';
            }
        }

        private void chkAlertaFaltantes_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAlertaFaltantes.Checked == true)
            {
                SIGLOP.Properties.Settings.Default.AlertaFaltantes = 'S';
            }
            else
            {
                SIGLOP.Properties.Settings.Default.AlertaFaltantes = 'N';
            }
        }
    }
}
