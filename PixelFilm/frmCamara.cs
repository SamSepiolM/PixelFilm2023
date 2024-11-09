using System;
using System.Drawing;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

namespace PixelFilm
{
    public partial class frmCamara : Form
    {
        //private Filtros filtros = new Filtros();
        private Bitmap imagenO;
        frmHistograma histo = new frmHistograma();
        private bool vHistograma = false;

        //SpeechSynthesizer vos = new SpeechSynthesizer();
        //DECLARANDO TODAS LAS VARIABLES, vectores y  haarcascades
        Image<Bgr, Byte> currentFrame;
        Capture grabber;
        HaarCascade face;
        MCvFont font = new MCvFont(FONT.CV_FONT_HERSHEY_TRIPLEX, 0.5d, 0.9d);
        Image<Gray, byte> result = null;
        Image<Gray, byte> gray = null;
        //List<Image<Gray, byte>> trainingImages = new List<Image<Gray, byte>>();
        //List<string> labels = new List<string>();
        //List<string> labels1 = new List<string>();
        //List<string> NamePersons = new List<string>();
        //int ContTrain, NumLabels;
        int t = 0;
        string name;
        //string names = null, Labelsinfo;

        public frmCamara()
        {
            InitializeComponent();

            //GARGAMOS LA DETECCION DE LAS CARAS POR  haarcascades 
            face = new HaarCascade("haarcascade_frontalface_default.xml");
        }

        private void frmCamara_Load(object sender, EventArgs e)
        {
            Reconocer();
        }

        private void iconGuardar_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                imagenO.Save(saveFileDialog1.FileName);
                MessageBox.Show("Archivo Guardado");

                this.Invalidate();
            }
            
        }

        private void btnVerHistograma_Click(object sender, EventArgs e)
        {
            cHistograma.Controls.Clear();
            vHistograma = !vHistograma;
            if (vHistograma)
            {
                AbrirFormulario(histo);
            }
        }


        private void Reconocer()
        {
            //Iniciar el dispositivo de captura
            //grabber = new Capture();
            grabber = new Capture(0);
            
            grabber.QueryFrame();
            //Iniciar el evento FrameGraber
            Application.Idle += new EventHandler(FrameGrabber);
        }

        private void FrameGrabber(object sender, EventArgs e)
        {
            lblNumeroDetect.Text = "0";

            Bgr rostro = new Bgr(Color.LightGreen);
            Bgr letras = new Bgr(Color.YellowGreen);


            //Obtener la secuencia del dispositivo de captura
            try
            {
                currentFrame = grabber.QueryFrame().Resize(640, 480, INTER.CV_INTER_CUBIC);
                imagenO = currentFrame.ToBitmap();
            }
            catch (Exception)
            {
                //lblNadie.Text = "";
                pictureBox1.Image = null;
                imagenO = null;
            }

            //Convertir a escala de grises
            gray = currentFrame.Convert<Gray, Byte>();

            //Detector de Rostros
            MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(face, 1.2, 10, HAAR_DETECTION_TYPE.DEFAULT, new Size(20, 20));

            //Accion para cada elemento detectado
            foreach (MCvAvgComp f in facesDetected[0])
            {

                //NamePersons.Add("");

                result = currentFrame.Copy(f.rect).Convert<Gray, byte>().Resize(173, 168, INTER.CV_INTER_CUBIC);
                //Dibujar el cuadro para el rostro
                currentFrame.Draw(f.rect, rostro, 1);


                //Dibujar el nombre para cada rostro detectado y reconocido
                name = "Persona " + (t + 1);
                currentFrame.Draw(name, ref font, new Point(f.rect.X - 2, f.rect.Y - 2), letras);

                /*if (trainingImages.ToArray().Length != 0)
                {
                    //Clase para reconocimiento con el nùmero de imagenes
                    MCvTermCriteria termCrit = new MCvTermCriteria(ContTrain, 0.001);

                    //Clase Eigen para reconocimiento de rostro
                    EigenObjectRecognizer recognizer = new EigenObjectRecognizer(trainingImages.ToArray(), labels.ToArray(), ref termCrit);
                    var fa = new Image<Gray, byte>[trainingImages.Count]; //currentFrame.Convert<Bitmap>();

                    name = recognizer.Recognize(result);
                    //Dibujar el nombre para cada rostro detectado y reconocido
                    currentFrame.Draw(name, ref font, new Point(f.rect.X - 2, f.rect.Y - 2), new Bgr(Color.YellowGreen));
                }*/

                //NamePersons[t] = name;

                //Establecer el nùmero de rostros detectados
                lblNumeroDetect.Text = facesDetected[0].Length.ToString();
                //lblNadie.Text = name;

                t = t + 1;
            }
            t = 0;

            //Nombres concatenados de todos los rostros reconocidos
            /*for (int nnn = 0; nnn < facesDetected[0].Length; nnn++)
            {
                names = names + NamePersons[nnn] + ", ";
            }*/

            //Mostrar los rostros procesados y reconocidos
            pictureBox1.Image = currentFrame.ToBitmap();

            //Borrar la lista de nombres            
            //NamePersons.Clear();


            if (vHistograma)
            {
                histo.ActualizarHistograma(imagenO);
                histo.Refresh();
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

        public void Desconectar()
        {
            Application.Idle -= new EventHandler(FrameGrabber);
            grabber.Dispose();
        }

        private void frmCamara_FormClosing(object sender, FormClosingEventArgs e)
        {
            Desconectar();
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            Desconectar();
            Reconocer();
        }
    }
}
