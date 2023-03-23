using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
namespace Nu_te_supara_frate
{
    public class Pioni:Jucator
    {
        int pozitie;
        PictureBox pion;

        public Pioni(Tabla t,string nume, Zar zar, PictureBox pion, int pozitie):base(t,nume, zar)
        {
            this.pozitie = pozitie;
            this.pion = pion;
        }


        public override int  getPozitie()
        {
            return pozitie;
        }
        public override void setPozite(int i)
        {
                pozitie += i;
        }
        public override PictureBox getPion()
        {
            return pion;
        }

       




    }
}
