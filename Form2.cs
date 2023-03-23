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
    public partial class Tabla : Form
    {
        Form form1;
        
        public Tabla(Form form)
        {
            InitializeComponent();
            form1 = form;
            form1.Hide();
            
        }

        private void pTabla_Load(object sender, EventArgs e) {}//GRESEALAAAAAAAAAAAAAAAA

        private void bX_Click(object sender, EventArgs e)
        {
            form1.Hide();

        }
    }
}
