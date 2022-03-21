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
    public partial class fmlistado : Form
    {
        public fmlistado()
        {
            InitializeComponent();
        }

        private void fmlistado_Load(object sender, EventArgs e)
        {
            dgvlistadovotos.DataSource = votosgenerales.olistvoto;

        }


    }
}
