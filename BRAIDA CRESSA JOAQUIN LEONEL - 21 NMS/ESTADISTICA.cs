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
    public partial class fmestadistica : Form
    {
        public fmestadistica()
        {
            InitializeComponent();
        }

        private void fmestadistica_Load(object sender, EventArgs e)
        {
            int acumt = 0;
            int acumbsas = 0;
            int acumcba = 0;
            int maypartidocba = 0;
            int acumcbaA = 0;
            int acumcbaB = 0;



            foreach (voto item in votosgenerales.olistvoto)
            {

                acumt = acumt + item.partidoA + item.partidoB;

                if (item.provincia == "Buenos Aires")
                {
                    acumbsas = acumbsas + item.partidoA + item.partidoB;
                }
                

                if (item.provincia == "Cordoba")

                {
                    acumcba = acumcba + item.partidoA + item.partidoB;
                    
                    acumcbaA = acumcbaA + item.partidoA;

                    acumcbaB = acumcbaB + item.partidoB;
                }
            }

            if (acumcbaA > acumcbaB)
            {
                maypartidocba = acumcbaA;

            }
            else maypartidocba = acumcbaB;



            label8.Text = acumt.ToString();
            lblbsas.Text = acumbsas.ToString();
            lblcba.Text = acumcba.ToString();
            lblmaycba.Text = maypartidocba.ToString(); 







        }


        }

 
    }

