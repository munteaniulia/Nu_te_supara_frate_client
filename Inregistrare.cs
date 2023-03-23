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
        Tabla ptabla;
        string my_name;
        public Inreg()
        {
            InitializeComponent();
            
            
        }

        private void bNext_Click(object sender, EventArgs e)
        {

            this.my_name = NumeJucator.Text;
            ptabla = new Tabla(this);
           
            
            
            
            if (NumeJucator.Text.Length > 0)
            {
                this.Hide();
                ptabla.Show();
                ptabla.J1.Text = NumeJucator.Text;
                
                
            }
            
        }
        public string get_name()
        {
            return my_name;
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
