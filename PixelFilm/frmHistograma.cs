using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixelFilm
{
    public partial class frmHistograma : Form
    {

        private int[,] histograma;

        private bool drawR, drawG, drawB;

        //private Pen plumaR = new Pen(Color.FromArgb(255, 255, 0, 0));
        //private Pen plumaG = new Pen(Color.FromArgb(255, 0, 255, 0));
        //private Pen plumaB = new Pen(Color.FromArgb(255, 0, 0, 255));

        //private Pen plumaE = new Pen(Color.White);


        public frmHistograma()
        {
            InitializeComponent();
            histograma = new int[3, 256];
            drawR = false;
            drawG = false;
            drawB = false;

            Draw_RGB.Checked = true;
        }

        private void pasoDatos(int[,] pHistograma)
        {
            histograma = pHistograma;
            int mayorR = 0;
            int mayorG = 0;
            int mayorB = 0;


            //Encontrar el valor mayor 
            for (int i = 0; i < 256; i++)
            {
                mayorR = histograma[0, i] > mayorR ? histograma[0, i] : mayorR;
                mayorG = histograma[1, i] > mayorG ? histograma[1, i] : mayorG;
                mayorB = histograma[2, i] > mayorB ? histograma[2, i] : mayorB;
            }

            //Escalar los datos
            for (int i = 0; i < 256; i++)
            {
                histograma[0, i] = (int)((float)histograma[0, i] / (float)mayorR * 255.0f);
                histograma[1, i] = (int)((float)histograma[1, i] / (float)mayorG * 255.0f);
                histograma[2, i] = (int)((float)histograma[2, i] / (float)mayorB * 255.0f);
            }
        }

        public void ActualizarHistograma(Bitmap picture)
        {
            Color rColor = new Color();
            //int[,] histograma = new int[3, 256];

            for (int x = 0; x < picture.Width; x++)
            {
                for (int y = 0; y < picture.Height; y++)
                {
                    rColor = picture.GetPixel(x, y);
                    histograma[0, rColor.R]++;
                    histograma[1, rColor.G]++;
                    histograma[2, rColor.B]++;
                }
            }

            //SUAVISADO DE HISTOGRAMA
            int[,] hs = new int[3, 256];

            hs[0, 0] = (histograma[0, 0] + histograma[0, 1]) / 2;
            hs[1, 0] = (histograma[1, 0] + histograma[1, 1]) / 2;
            hs[2, 0] = (histograma[2, 0] + histograma[2, 1]) / 2;

            hs[0, 255] = (histograma[0, 255] + histograma[0, 254]) / 2;
            hs[1, 255] = (histograma[1, 255] + histograma[1, 254]) / 2;
            hs[2, 255] = (histograma[2, 255] + histograma[2, 254]) / 2;

            for (int j = 1; j < 254; j++)
            {
                hs[0, j] = (histograma[0, (j - 1)] + histograma[0, j] + histograma[0, (j + 1)]) / 3;
                hs[1, j] = (histograma[1, (j - 1)] + histograma[1, j] + histograma[1, (j + 1)]) / 3;
                hs[2, j] = (histograma[2, (j - 1)] + histograma[2, j] + histograma[2, (j + 1)]) / 3;
            }

            pasoDatos(histograma);
        }

        private void frmHistograma_Paint(object sender, PaintEventArgs e)
        {
            //int altura = 0;

            Graphics g = e.Graphics;

            Pen plumaR = new Pen(Color.FromArgb(255, 255, 0, 0));
            Pen plumaG = new Pen(Color.FromArgb(255, 0, 255, 0));
            Pen plumaB = new Pen(Color.FromArgb(255, 0, 0, 255));

            Pen plumaE = new Pen(Color.White);


            //Pen plumaR = new Pen(Color.Red);
            //Pen plumaG = new Pen(Color.Green);
            //Pen plumaB = new Pen(Color.Blue);



            g.DrawLine(plumaE, 19, 271, 280, 271); //X
            g.DrawLine(plumaE, 19, 270, 19, 10); //Y

            for(int i = 0; i < 256; i++)
            {
                if (drawR)
                {
                    g.DrawLine(plumaR, i + 20, 270, i + 20, 270 - histograma[0, i]);
                }

                if (drawG)
                {
                    g.DrawLine(plumaG, i + 20, 270, i + 20, 270 - histograma[1, i]);
                }

                if (drawB)
                {
                    g.DrawLine(plumaB, i + 20, 270, i + 20, 270 - histograma[2, i]);
                }
            }
        }

        private void Draw_RGB_CheckedChanged(object sender, EventArgs e)
        {
            if (Draw_RGB.Checked)
            {
                drawR = true;
                drawG = true;
                drawB = true;

                Draw_R.Checked = true;
                Draw_G.Checked = true;
                Draw_B.Checked = true;
            }

            if(Draw_R.Checked && Draw_G.Checked && Draw_B.Checked)
            {
                Draw_RGB.Checked = true;

                this.Refresh();
            }

            
        }

        private void Draw_R_CheckedChanged(object sender, EventArgs e)
        {
            if (!Draw_R.Checked)
            {
                Draw_RGB.Checked = false;
            }

            drawR = Draw_R.Checked ? true : false;

            this.Refresh();
        }

        private void Draw_G_CheckedChanged(object sender, EventArgs e)
        {
            if (!Draw_G.Checked)
            {
                Draw_RGB.Checked = false;
            }

            drawG = Draw_G.Checked ? true : false;

            this.Refresh();
        }

        private void Draw_B_CheckedChanged(object sender, EventArgs e)
        {
            if (!Draw_B.Checked)
            {
                Draw_RGB.Checked = false;
            }

            drawB = Draw_B.Checked ? true : false;

            this.Refresh();
        }
    }
}
