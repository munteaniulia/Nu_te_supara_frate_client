using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nu_te_supara_frate
{
    public class Jucator
    {
        string nume;
        Zar zar;
        Tabla tabla;
        
        public Jucator(Tabla t, string nume, Zar zar)
        {
            tabla = t;
            this.nume = nume;
            this.zar = zar;
           
        }

        public virtual int getPozitie()
        {return 0;}

        public virtual void setPozite(int i)
        {}

        public virtual PictureBox getPion()
        { PictureBox p=new PictureBox(); return p; }

        public virtual void muta(Zar z, Drum drum, Form Tabla)
        { }
        public virtual bool verificare(Drum drum, Jucator []j)
        {
            int ct = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int k = 0; k < 4; k++)
                    if (j[i].getPion().Location == drum.getCasa()[k].Location)
                    {
                        ct++;
                    }
            }
            if (ct == 4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
      
    }
}
