using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nu_te_supara_frate
{
    public partial class Inreg : Form
    {
        Tabla tabla;
       
        public Inreg()
        {
            InitializeComponent();
            tabla = new Tabla(this);
            
        }

        private void bNext_Click(object sender, EventArgs e)
        {
            if (NumeJucator.Text != null)
            {
                this.Hide();
                tabla.Show();
            }
            else
            {

            }
        }

        private void NumeJucator_TextChanged(object sender, EventArgs e)
        {

        }

        private void pInreg_Load(object sender, EventArgs e)
        {

        }
    }
}
