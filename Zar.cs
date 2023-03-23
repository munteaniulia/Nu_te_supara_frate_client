using Nu_te_supara_frate.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Nu_te_supara_frate
{
    public class Zar
    {
        Random zar;
        PictureBox img;
        int fata;


        public Zar(Random r, PictureBox img) 
        {
            zar = r;
            fata = zar.Next(1, 7);
            this.img = img;
        }


        public int  getFata()
        {
            return fata;
        }

        public void decrementFata()
        {
            --fata ;
        }
        public int SetFata(int f)
        {
            fata = f;
            switch (fata)
            {
                case 1:
                    img.Image = Resources._1;
                    img.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 2:
                    img.Image = Resources._2;
                    img.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 3:
                    img.Image = Resources._3;
                    img.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 4:
                    img.Image = Resources._4;
                    img.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 5:
                    img.Image = Resources._5;
                    img.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 6:
                    img.Image = Resources._6;
                    img.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                //default:
                //    img.Image = Resources._1;
                //    img.SizeMode = PictureBoxSizeMode.StretchImage;
                //    break;
            }
            return fata;
        }

        public void Roll()
        {
            fata = zar.Next(1, 7);
            SetFata(fata);
            
        }
        
    }
}
