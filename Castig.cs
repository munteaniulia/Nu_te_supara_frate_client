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
    public partial class Castig : Form
    {
      
        public Castig(Tabla t)
        {
            InitializeComponent();

        }

        private void bExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
