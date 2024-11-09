using System;
using System.Drawing;
using System.Windows.Forms;

namespace PixelFilm
{
    public partial class frmImagenes : Form
    {
        private Bitmap picOriginal;
        private Bitmap picResultado;

        frmHistograma histo = new frmHistograma();
        private bool vHistograma = false;


        private Filtros filtros = new Filtros();

        public frmImagenes()
        {
            InitializeComponent();

            picOriginal = (Bitmap)pictureBox2.Image;
            //picResultado = new Bitmap(800, 600);
            picResultado = picOriginal;
        }


        private void frmImagenes_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Filtro Negativo");
            listBox1.Items.Add("Filtro Escala de grises");
            listBox1.Items.Add("Filtro Correccion de Gamma");
            listBox1.Items.Add("Filtro Blur Gaussiano");
            listBox1.Items.Add("Filtro Enfoque Laplaciano");
            listBox1.Items.Add("Filtro Mejorar Brillo y Contraste");
            listBox1.Items.Add("Filtro Umbral");

            listBox1.Items.Add("Filtro Mosaico");
            listBox1.Items.Add("Filtro Sepia");
            listBox1.Items.Add("Filtro Reduccion de Ruido");
            listBox1.Items.Add("Filtro Aberracion Cromatica");
        }

        private void iconGuardar_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex != -1)
            {
                int itemIndex = listBox1.SelectedIndex;
                string itemString = listBox1.SelectedItem.ToString();


                //picResultado = filtros.filtroMosaico(picResultado, 8);
                //picResultado = filtros.filtroAberracionCromatica(picResultado, 4);

                switch (itemIndex)
                {
                    case 0:
                        {
                            picResultado = filtros.filtroNegativo(picResultado);
                            break;
                        }
                    case 1:
                        {
                            picResultado = filtros.filtroEscalaGrises(picResultado);
                            break;
                        }
                    case 2:
                        {
                            picResultado = filtros.filtroCorreccionGamma(picResultado, (trackBar1.Value / 5.0f), (trackBar2.Value / 5.0f), (trackBar3.Value / 5.0f));
                            break;
                        }
                    case 3:
                        {
                            picResultado = filtros.filtroBlurGaussiano2(picResultado, trackBar1.Value);
                            break;
                        }
                    case 4:
                        {
                            picResultado = filtros.filtroEnfoqueLaplaciano(picResultado, (int)(trackBar1.Value * 3 + 1));
                            break;
                        }
                    case 5:
                        {
                            picResultado = filtros.filtroBrillo(picResultado, (float)(trackBar1.Value / 5.0f));
                            picResultado = filtros.filtroContraste(picResultado, (float)(trackBar2.Value / 5.0f) * 2.5f);
                            break;
                        }
                    case 6:
                        {
                            picResultado = filtros.filtroUmbral(picResultado, (int)(trackBar1.Value * 25.5));
                            break;
                        }

                    case 7:
                        {
                            picResultado = filtros.filtroMosaico(picResultado, (int)(trackBar1.Value + 1));
                            break;
                        }
                    case 8:
                        {
                            picResultado = filtros.filtroSepia(picResultado);
                            break;
                        }
                    case 9:
                        {
                            picResultado = filtros.filtroReduccionRuido(picResultado, 3);
                            break;
                        }
                    case 10:
                        {
                            picResultado = filtros.filtroAberracionCromatica(picResultado, (int)(trackBar1.Value));
                            break;
                        }
                }


                pictureBox2.Image = picResultado;
                listBox2.Items.Add(itemString);
                ActualizarHisto();
            }
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            picResultado = picOriginal;
            pictureBox2.Image = picResultado;
            listBox2.Items.Clear();

            ActualizarHisto();
        }


        private void iconEliminar_Click(object sender, EventArgs e)
        {
            
        }


        private void frmImagenes_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnVerHistograma_Click(object sender, EventArgs e)
        {
            cHistograma.Controls.Clear();
            vHistograma = !vHistograma;

            if (vHistograma)
            {
                AbrirFormulario(histo);
                ActualizarHisto();
            }
        }

        public void abrirFoto(Bitmap imagen)
        {
            picOriginal = imagen;
            //altoVentana = picOriginal.Height;
            //anchoVentana = picOriginal.Width;

            picResultado = picOriginal;

            pictureBox2.Image = picResultado;
            listBox2.Items.Clear();

            ActualizarHisto();
        }

        public void guardarFoto(SaveFileDialog saveFileDialog)
        {
            try
            {
                //picResultado.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
                picResultado.Save(saveFileDialog.FileName);
                MessageBox.Show("Archivo Guardado");
            }
            catch
            {
                MessageBox.Show("No se puede sobrescribir el archivo");
            }
        }

        private void AbrirFormulario(Form formulario)
        {
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            //formulario.BackColor = Color.Firebrick;

            cHistograma.Controls.Clear();
            cHistograma.Controls.Add(formulario);
            formulario.Show();
        }

        private void ActualizarHisto()
        {
            if (vHistograma)
            {
                histo.ActualizarHistograma(picResultado);
                histo.Refresh();
            }
        }
    }
}
