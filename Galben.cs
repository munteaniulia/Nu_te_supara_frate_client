using Nu_te_supara_frate.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nu_te_supara_frate
{
    class Galben : Pioni
    {
        string culoare;

        public Galben(Tabla t, string nume, Zar zar, PictureBox pion, int pozitie, string culoare) : base(t, nume, zar, pion, pozitie)
        {
            this.culoare = culoare;
        }

        public override void muta(Zar z, Drum drum, Form Tabla)
        {

            while (z.getFata() != 0)
            {
                if (getPozitie() < 19)
                {
                    drum.getDrum()[getPozitie() + 20].Show();
                    setPozite(1);
                    drum.getDrum()[getPozitie() + 20].Hide();
                    getPion().Location = drum.getDrum()[getPozitie() + 20].Location;
                    z.decrementFata();
                }
                else
                {
                    if (getPozitie() == 19)
                    {

                        drum.getDrum()[getPozitie() + 20].Show();
                        setPozite(1);
                        drum.getDrum()[0].Hide();
                        getPion().Location = drum.getDrum()[0].Location;
                        z.decrementFata();
                    }
                    else
                    {
                        if (getPozitie() < 39)
                        {
                            drum.getDrum()[getPozitie() - 20].Show();
                            setPozite(1);
                            drum.getDrum()[getPozitie() - 20].Hide();
                            getPion().Location = drum.getDrum()[getPozitie() - 20].Location;
                            z.decrementFata();
                        }
                        else
                        {
                            if (getPozitie() == 39)
                            {
                                drum.getDrum()[19].Show();
                                drum.getCasa()[8].Hide();
                                getPion().Location = drum.getCasa()[8].Location;
                                setPozite(1);
                                z.decrementFata();
                            }
                            else
                            {
                                if (getPozitie() > 39 && getPozitie() <= 43)
                                {
                                    drum.getCasa()[getPozitie() - 32].Show();
                                    setPozite(1);
                                    drum.getCasa()[getPozitie() - 32].Hide();
                                    getPion().Location = drum.getCasa()[getPozitie() - 32].Location;
                                    z.decrementFata();
                                }
                            }
                        }
                    }
                }
            }
        }

        public override bool verificare(Drum drum, Jucator[] j)
        {
            int ct = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int k = 8; k < 12; k++)
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
