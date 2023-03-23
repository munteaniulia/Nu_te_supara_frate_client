using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Nu_te_supara_frate
{
   public class Drum
    {
        PictureBox[] drum = new PictureBox[41];
        PictureBox[]casa= new PictureBox[17];
        int x = 250, y = 75, x1 = 210, y1 = 115, y2 = 240;

        public PictureBox[] getDrum()
        {
            return drum;
        }

        public PictureBox[] getCasa()
        {
            return casa;
        }


        public Drum(Form Tabla)
        { 
            for (int i = 0; i < 41; i++)
            {
                drum[i] = new PictureBox();
                drum[i].Size = new Size(27, 25);
                drum[i].BackColor = Color.FloralWhite;
                
                if ((i >= 1 && i <= 4) || (i >= 9 && i <= 10) || (i >= 15 && i <= 18))
                    y += 40 ;
                if ((i >= 5 && i <= 8) || (i >= 31 && i <= 34) || i==39)
                    x += 40;
                if ((i >= 11 && i <= 14) || (i >= 25 && i <= 28) || i==19 || i==20)
                    x -= 40 ;
                if ((i >= 21 && i <= 24) || (i >= 29 && i <= 30) || (i >= 35 && i <= 38))
                    y -= 40;

                //if (i == 14)
                //{
                //    y2 = y;
                //}
                drum[i].Location = new Point(x, y);
                Tabla.Controls.Add(drum[i]);
            }
     
            for (int i = 0; i < 16; i++)
            {
                casa[i] = new PictureBox();
                casa[i].Size = new Size(27, 25);
                if (i == 0)
                {
                    casa[i].BackColor = Color.Red;
                }
                if (i >= 1 && i <= 3)
                {
                    casa[i].BackColor = Color.Red;
                    y1 += 40;
                }
                if(i>=4 && i <= 7)
                {
                    casa[i].BackColor = Color.Green;
                    if (i == 4)
                    {
                        y1 += 40;
                        x1 = 210 + 40 * 5;
                    }
                    
                    x1 -= 40;
                }
                if(i>=8 && i <= 11)
                {
                    casa[i].BackColor = Color.Yellow;
                    if (i == 8)
                    {
                        x1 -= 40;
                        y1 = 75 + 40 * 10;
                    }
                    y1-= 40;
                }
                if(i>=12 && i <= 15)
                {
                    casa[i].BackColor = Color.Blue;
                    if (i == 12)
                    {
                        x1 -= 40 * 5;
                        y1 -= 40;
                    }
                    x1 += 40;
                }

                casa[i].Location = new Point(x1, y1);
                Tabla.Controls.Add(casa[i]);
            }

        }
        
       

    }
}
