using System;
using Nu_te_supara_frate.Properties;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.ComponentModel;
using System.Data;
using System.Drawing;


namespace Nu_te_supara_frate
{
    
    class Rosu:Pioni
    {
        string culoare;
        
        public Rosu(Tabla t, string nume, Zar zar, PictureBox pion, int pozitie,  string culoare):base(t, nume, zar,pion,pozitie)
        {
            this.culoare = culoare;
          
        }

        public override void  muta(Zar z, Drum drum,Form Tabla)
        {
           
            while (z.getFata()!=0)
            {

                if (getPozitie() < 39)
                {
                    drum.getDrum()[getPozitie()].Show();
                    setPozite(1);
                    drum.getDrum()[getPozitie()].Hide();
                    getPion().Location = drum.getDrum()[getPozitie()].Location;
                    z.decrementFata();
                }
                else
                {
                    if (getPozitie() == 39)
                    {
                        drum.getDrum()[39].Show();
                        drum.getCasa()[0].Hide();
                        getPion().Location = drum.getCasa()[0].Location;
                        setPozite(1);
                        z.decrementFata();
                    }
                    else
                    {
                        if (getPozitie() > 39 && getPozitie() <= 43)
                        {
                            drum.getCasa()[getPozitie() - 40].Show();
                            setPozite(1);
                            drum.getCasa()[getPozitie() - 40].Hide();
                            getPion().Location = drum.getCasa()[getPozitie() - 40].Location;
                            z.decrementFata();
                        }
                    }
                }

            }


        }

    

    }
    
}
