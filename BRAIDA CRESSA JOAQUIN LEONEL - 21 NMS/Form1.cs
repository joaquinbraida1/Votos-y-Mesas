using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BRAIDA_CRESSA_JOAQUIN_LEONEL___21_NMS
{
    public partial class MENU : Form
    {
        public MENU()
        {
            InitializeComponent();
        }

        private void MsSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fmcargar_Click(object sender, EventArgs e)
        {
            fmcarga ofmcarga = new fmcarga();
            ofmcarga.MdiParent = this;
            ofmcarga.Show();
            
        }

        private void listado_Click(object sender, EventArgs e)
        {
            fmlistado ofmlistado = new fmlistado();
            ofmlistado.MdiParent = this;
            ofmlistado.Show();
        }

        private void estadistica_Click(object sender, EventArgs e)
        {
            fmestadistica ofmestadistica = new fmestadistica();
            ofmestadistica.MdiParent = this;
            ofmestadistica.Show();

        }
    }
}
