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
    public partial class fmcarga : Form
    {
        public fmcarga()
        {
            InitializeComponent();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            voto ovoto = new voto();

            ovoto.mesa = int.Parse(txtmesa.Text);
            ovoto.partidoA = int.Parse(txtparta.Text);
            ovoto.partidoB = int.Parse(txtpartb.Text);
            ovoto.provincia = cboprovincia.SelectedItem.ToString();

            votosgenerales.olistvoto.Add(ovoto);


            Limpiar();
        }

           

       private void Limpiar()
        {
            txtmesa.Clear();
            txtparta.Clear();
            txtpartb.Clear();
            cboprovincia.SelectedIndex = 0;


            txtmesa.Focus();
        }



    }
    }

