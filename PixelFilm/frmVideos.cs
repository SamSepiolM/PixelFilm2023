using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace PixelFilm
{
    public partial class frmVideos : Form
    {

        private Filtros filtros = new Filtros();

        private Bitmap picOriginal;
        private Bitmap picResultado;

        frmHistograma histo = new frmHistograma();
        private bool vHistograma = false;

        private VideoCapture capture;

        private Timer timer;

        private int filtroSeleccionado = -1, resolucion = 4;

        private string rutaVideo;

        private bool play = false;

        private float ondas = 0;

        bool ondasA = false;

        float nuevox = 0;

        private int valorTrackBar = 5;

        OpenCvSharp.Size sizeVideo = new OpenCvSharp.Size();

        Bitmap vhsOriginal, vhs;

        public frmVideos()
        {
            InitializeComponent();
        }


        private void frmVideos_Load(object sender, EventArgs e)
        {
            //axWindowsMediaPlayer1.Visible = true;
            //axWindowsMediaPlayer1.URL = "C:/Users/L/Videos/PIA_PI/PIA PI/PixelFilm/Resources/Video_Prueba.mp4";
            //axWindowsMediaPlayer1.Ctlcontrols.play();
            picOriginal = (Bitmap)pictureBox2.Image;
            picResultado = picOriginal;

            vhsOriginal = new Bitmap(Path.GetFullPath("..\\..\\Resources\\VCR-Overlay.png"));
            vhs = vhsOriginal;

            trackBar1.Value = valorTrackBar;


            cambiarResolucion(resolucion);

            comboBox1.Items.Add("Original");
            comboBox1.Items.Add("1/2");
            comboBox1.Items.Add("1/3");
            comboBox1.Items.Add("1/4");
            comboBox1.Items.Add("1/5");
            comboBox1.SelectedIndex = 3;

            listBox1.Items.Add("Filtro Negativo");
            listBox1.Items.Add("Filtro Escala de grises");
            listBox1.Items.Add("Filtro Correccion de Gamma");
            listBox1.Items.Add("Filtro Blur Gaussiano");
            listBox1.Items.Add("Filtro Enfoque Laplaciano");
            listBox1.Items.Add("Filtro Mejorar Brillo y Contraste");
            listBox1.Items.Add("Filtro Umbral");

            listBox1.Items.Add("Filtro Interferencia VHS");
            listBox1.Items.Add("Filtro Ruido Aleatorio");
            listBox1.Items.Add("Filtro Deformacion de Ondas");
            listBox1.Items.Add("Filtro Ensombrecer");
        }

        private void iconGuardar_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                int itemIndex = listBox1.SelectedIndex;
                string itemString = listBox1.SelectedItem.ToString();

                filtroSeleccionado = itemIndex;
                if (!play)
                {
                    AplicarFiltros();
                }

                listBox2.Items.Clear();
                listBox2.Items.Add(itemString);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            picResultado = picOriginal;
            //picResultado = new Bitmap(picOriginal, sizeVideo.Width, sizeVideo.Height);
            pictureBox2.Image = picOriginal;
            listBox2.Items.Clear();
            filtroSeleccionado = -1;

            ActualizarHisto();
        }

        private void iconEliminar_Click(object sender, EventArgs e)
        {
            rutaVideo = "..\\..\\Resources\\Video_Prueba.mp4";
            cargarVideo(rutaVideo);
        }

        public void cargarVideo(string ruta)
        {
            Desconectar();
            ruta = Path.GetFullPath(ruta);
            rutaVideo = ruta;

            capture = new VideoCapture(ruta);

            if (!capture.IsOpened())
            {
                MessageBox.Show("No puedo Martha");
                return;
            }

            // Maneja el evento Tick del temporizador para actualizar el PictureBox con los fotogramas
            timer = new Timer();
            timer.Interval = (int)capture.Fps / 2;
            //timer.Interval = 2; 
            Reproducir();
        }

        public void Desconectar()
        {
            if (timer != null)
            {
                timer.Stop();
            }

            if (capture != null)
            {
                capture.Release();
                capture.Dispose();
            }

            filtroSeleccionado = -1;
            play = false;
            listBox2.Items.Clear();
        }

        private void iconPlay_Click(object sender, EventArgs e)
        {
            Reproducir();
        }

        private void iconPause_Click(object sender, EventArgs e)
        {
            if (timer != null)
            {
                timer.Stop();
                play = false;
            }
        }

        private void iconStop_Click(object sender, EventArgs e)
        {
            if (timer != null)
            {
                timer.Stop();
                play = false;
            }
            
            if (capture != null)
            {
                capture.Release();
            }
        }

        private void Reproducir()
        {
            if (capture != null && play == false)
            {
                timer.Start();
                timer.Tick += (sender1, e1) =>
                {
                    try
                    {
                        Mat frame = new Mat();
                        
                        capture.Read(frame);
                        
                        if (frame.Empty())
                        {
                            //OpenCvSharp.Size size = new OpenCvSharp.Size(pictureBox2.Width, pictureBox2.Height);
                            //frame.Resize(size);
                            play = false;
                            timer.Stop();
                            capture.PosFrames = 0;
                            
                            capture.Release();

                            cargarVideo(rutaVideo);
                            return;
                        }

                        //float aspect = (float)frame.Width / (float)frame.Height;

                        //OpenCvSharp.Size sizeVideo2 = new OpenCvSharp.Size(aspect * sizeVideo.Width, sizeVideo.Height);
                        picOriginal = BitmapConverter.ToBitmap(frame.Resize(sizeVideo));
                        //picOriginal = BitmapConverter.ToBitmap(frame.Resize(sizeVideo2));
                        picResultado = picOriginal;

                        AplicarFiltros();

                        play = true;
                    }
                    catch
                    {
                        return;
                    }
                };
            }
        }

        private void AplicarFiltros()
        {
            //AplicaFiltros
            switch (filtroSeleccionado)
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
                        picResultado = filtros.filtroBlurGaussiano(picResultado, trackBar1.Value);
                        break;
                    }
                case 4:
                    {
                        picResultado = filtros.filtroEnfoqueLaplaciano(picResultado, (int)(trackBar1.Value * 3 + 1));
                        break;
                    }
                case 5:
                    {
                        picResultado = filtros.filtroBrilloYContraste(picResultado, (float)(trackBar1.Value / 5.0f), (float)(trackBar2.Value / 5.0f) * 2.5f);
                        break;
                    }
                case 6:
                    {
                        picResultado = filtros.filtroUmbral(picResultado, (int)(trackBar1.Value * 25.5f));
                        break;
                    }

                case 7:
                    {
                        nuevox += (float)(trackBar1.Value / 5.0f + 0.4f) * 0.15f;
                        //picResultado = filtros.filtroInterferenciaVHS1(picResultado, nuevox);
                        picResultado = new Bitmap(picOriginal, sizeVideo.Width, sizeVideo.Height);
                        picResultado = filtros.filtroInterferenciaVHS2(picResultado, vhs, nuevox, (int)((trackBar2.Value /8.0f) * 8.0f), trackBar3.Value * 7);
                        break;
                    }
                case 8:
                    {
                        picResultado = filtros.filtroRuidoAleatorio2(picResultado, (int)(trackBar1.Value));
                        break;
                    }
                case 9:
                    {
                        if (ondas >= 4)
                        {
                            ondasA = true;
                        }
                        if (ondas <= -4)
                        {
                            ondasA = false;
                        }
                        if (ondasA)
                        {
                            ondas -= 0.4f;
                        }
                        else
                        {
                            ondas += 0.4f;
                        }

                        nuevox += (float)(trackBar1.Value/10.0f + 0.1f) * 0.3f;

                        picResultado = filtros.filtroDeformacionOndas(picResultado, nuevox, -nuevox);
                        break;
                    }
                case 10:
                    {
                        picResultado = filtros.filtroEnsombrecer_Iluminar(picResultado, (float)(trackBar1.Value/5.0f + 0.4f) * 2.2f, (float)(trackBar2.Value / 10.0f));
                        break;
                    }

                default:
                    {
                        break;
                    }
            }

            pictureBox2.Image = picResultado;
            ActualizarHisto();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int auxResolucion = comboBox1.SelectedIndex;

            resolucion = auxResolucion + 1;
            /*switch (auxResolucion)
            {
                case 0:
                    {
                        resolucion = 1;
                        break;
                    }
            }*/
            cambiarResolucion(resolucion);
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

        private void cambiarResolucion(int resize)
        {
            sizeVideo.Width = pictureBox2.Width / resize;
            sizeVideo.Height = pictureBox2.Height / resize;

            vhs = new Bitmap(vhsOriginal, sizeVideo.Width, sizeVideo.Height);
           // picResultado = new Bitmap(picOriginal, sizeVideo.Width, sizeVideo.Height);
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
