using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace KolkoKrzyzyk
{
    public partial class Form1 : Form
    {
        char p1, p2, p3;
        char p4, p5, p6;
        char p7, p8, p9;
        char kto;

        void sprawdz()
        {
            string w;
            if (p1 == p2 && p2 == p3 && p1 != 'n' ||
                 p4 == p5 && p5 == p6 && p4 != 'n' ||
                 p7 == p8 && p8 == p9 && p7 != 'n' ||
                 p1 == p4 && p4 == p7 && p1 != 'n' ||
                 p2 == p5 && p5 == p8 && p2 != 'n' ||
                 p3 == p6 && p6 == p9 && p3 != 'n' ||
                 p1 == p5 && p5 == p9 && p1 != 'n' ||
                 p3 == p5 && p5 == p7 && p3 != 'n')
            {
                if (kto == 'x')
                {
                    w = "Wygrywa koteł_1!";
                }
                else
                {
                    w = "Wygrywa koteł_2!";
                }
                SoundPlayer simpleSound = new SoundPlayer("img/heil.wav");
                simpleSound.Play();
                DialogResult dialog = MessageBox.Show(w, "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dialog == DialogResult.OK)
                    Application.Restart();

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {


            pole1.ImageLocation = "img/n.bmp";
            pole2.ImageLocation = "img/n.bmp";
            pole3.ImageLocation = "img/n.bmp";
            pole4.ImageLocation = "img/n.bmp";
            pole5.ImageLocation = "img/n.bmp";
            pole6.ImageLocation = "img/n.bmp";
            pole7.ImageLocation = "img/n.bmp";
            pole8.ImageLocation = "img/n.bmp";
            pole9.ImageLocation = "img/n.bmp";
            tura.ImageLocation = "img/smallo.bmp";

            p1 = 'n'; p2 = 'n'; p3 = 'n';
            p4 = 'n'; p5 = 'n'; p6 = 'n';
            p7 = 'n'; p8 = 'n'; p9 = 'n';

            kto = 'o';

            pole1.Enabled = true;
            pole2.Enabled = true;
            pole3.Enabled = true;
            pole4.Enabled = true;
            pole5.Enabled = true;
            pole6.Enabled = true;
            pole7.Enabled = true;
            pole8.Enabled = true;
            pole9.Enabled = true;
        }
        
        private void pole2_Click(object sender, EventArgs e)
        {
            if (p2 == 'n')
            {
                if (kto == 'o')
                {
                    pole2.ImageLocation = "img/o.bmp";
                    p2 = 'o';
                    kto = 'x';
                    tura.ImageLocation = "img/smallx.bmp";


                }
                else
                {
                    pole2.ImageLocation = "img/x.bmp";
                    p2 = 'x';
                    kto = 'o';
                    tura.ImageLocation = "img/smallo.bmp";
                }
                pole2.Enabled = false;
                sprawdz();
            }
        }

        private void pole3_Click(object sender, EventArgs e)
        {
            if (p3 == 'n')
            {
                if (kto == 'o')
                {
                    pole3.ImageLocation = "img/o.bmp";
                    p3 = 'o';
                    kto = 'x';
                    tura.ImageLocation = "img/smallx.bmp";


                }
                else
                {
                    pole3.ImageLocation = "img/x.bmp";
                    p3 = 'x';
                    kto = 'o';
                    tura.ImageLocation = "img/smallo.bmp";
                }
                pole3.Enabled = false;
                sprawdz();
            }
        }

        private void pole4_Click(object sender, EventArgs e)
        {
            if (p4 == 'n')
            {
                if (kto == 'o')
                {
                    pole4.ImageLocation = "img/o.bmp";
                    p4 = 'o';
                    kto = 'x';
                    tura.ImageLocation = "img/smallx.bmp";


                }
                else
                {
                    pole4.ImageLocation = "img/x.bmp";
                    p4 = 'x';
                    kto = 'o';
                    tura.ImageLocation = "img/smallo.bmp";
                }
                pole4.Enabled = false;
                sprawdz();
            }
        }

        private void pole5_Click(object sender, EventArgs e)
        {
            if (p5 == 'n')
            {
                if (kto == 'o')
                {
                    pole5.ImageLocation = "img/o.bmp";
                    p5 = 'o';
                    kto = 'x';
                    tura.ImageLocation = "img/smallx.bmp";


                }
                else
                {
                    pole5.ImageLocation = "img/x.bmp";
                    p5 = 'x';
                    kto = 'o';
                    tura.ImageLocation = "img/smallo.bmp";
                }
                pole5.Enabled = false;
                sprawdz();
            }
        }

        private void pole6_Click(object sender, EventArgs e)
        {
            if (p6 == 'n')
            {
                if (kto == 'o')
                {
                    pole6.ImageLocation = "img/o.bmp";
                    p6 = 'o';
                    kto = 'x';
                    tura.ImageLocation = "img/smallx.bmp";


                }
                else
                {
                    pole6.ImageLocation = "img/x.bmp";
                    p6 = 'x';
                    kto = 'o';
                    tura.ImageLocation = "img/smallo.bmp";
                }
                pole6.Enabled = false;
                sprawdz();
            }
        }

        private void pole7_Click(object sender, EventArgs e)
        {
            if (p7 == 'n')
            {
                if (kto == 'o')
                {
                    pole7.ImageLocation = "img/o.bmp";
                    p7 = 'o';
                    kto = 'x';
                    tura.ImageLocation = "img/smallx.bmp";


                }
                else
                {
                    pole7.ImageLocation = "img/x.bmp";
                    p7 = 'x';
                    kto = 'o';
                    tura.ImageLocation = "img/smallo.bmp";
                }
                pole7.Enabled = false;
                sprawdz();
            }
        }

        private void pole8_Click(object sender, EventArgs e)
        {
            if (p8 == 'n')
            {
                if (kto == 'o')
                {
                    pole8.ImageLocation = "img/o.bmp";
                    p8 = 'o';
                    kto = 'x';
                    tura.ImageLocation = "img/smallx.bmp";


                }
                else
                {
                    pole8.ImageLocation = "img/x.bmp";
                    p8 = 'x';
                    kto = 'o';
                    tura.ImageLocation = "img/smallo.bmp";
                }
                pole8.Enabled = false;
                sprawdz();
            }
        }

        private void pole9_Click(object sender, EventArgs e)
        {
            if (p9 == 'n')
            {
                if (kto == 'o')
                {
                    pole9.ImageLocation = "img/o.bmp";
                    p9 = 'o';
                    kto = 'x';
                    tura.ImageLocation = "img/smallx.bmp";


                }
                else
                {
                    pole9.ImageLocation = "img/x.bmp";
                    p9 = 'x';
                    kto = 'o';
                    tura.ImageLocation = "img/smallo.bmp";
                }
                pole9.Enabled = false;
                sprawdz();
            }
        }

        private void pole1_Click(object sender, EventArgs e)
        {
            if (p1 == 'n')
            {
                if (kto == 'o')
                {
                    pole1.ImageLocation = "img/o.bmp";
                    p1 = 'o';
                    kto = 'x';
                    tura.ImageLocation = "img/smallx.bmp";


                }
                else
                {
                    pole1.ImageLocation = "img/x.bmp";
                    p1 = 'x';
                    kto = 'o';
                    tura.ImageLocation = "img/smallo.bmp";
                }
                pole1.Enabled = false;
                sprawdz();
            }




        }

        public Form1()
        {
            InitializeComponent();
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }



        private void tura_Click(object sender, EventArgs e)
        {

        }

    }
}
