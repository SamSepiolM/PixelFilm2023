using System;
using System.Drawing;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace PixelFilm
{
    public partial class InicioPixelFilm : Form
    {   
        private static IconMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;
        private static frmImagenes frmFoto = null;
        private static frmVideos frmVideo = null;
        private static frmCamara frmCamaraV = null;
        DateTime fechaActual;


        public InicioPixelFilm()
        {
            
            InitializeComponent();

            fechaActual = DateTime.Now;

            abrirArchivoToolStripMenuItem.Enabled = false;
            guardarArchivoToolStripMenuItem.Enabled = false;
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void AbrirFormulario(IconMenuItem menu, Form formulario){
            if (MenuActivo != null) {
                MenuActivo.BackColor = Color.Black;
            }
            menu.BackColor = Color.Silver;
            MenuActivo = menu;


            if (FormularioActivo != null)
            {
                if (FormularioActivo == frmCamaraV)
                {
                    frmCamaraV.Desconectar();
                }

                if (FormularioActivo == frmVideo)
                {
                    frmVideo.Desconectar();
                }

                
                FormularioActivo.Close();
                FormularioActivo.Dispose();
            }
            FormCollection d = Application.OpenForms;
            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            //formulario.BackColor = Color.Firebrick;

            abrirArchivoToolStripMenuItem.Enabled = true;
            guardarArchivoToolStripMenuItem.Enabled = true;

            contenedor.Controls.Clear();
            contenedor.Controls.Add(formulario);
            formulario.Show();
            
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            
        }

        private void MenuVideos_Click(object sender, EventArgs e)
        {
            frmVideo = new frmVideos();
            AbrirFormulario((IconMenuItem)sender, frmVideo);
        }

        private void MenuArchivo_Click(object sender, EventArgs e)
        {
            //AbrirFormulario((IconMenuItem)sender, new frmCaja());
        }

        private void MenuCamara_Click(object sender, EventArgs e)
        {
            frmCamaraV = new frmCamara();
            AbrirFormulario((IconMenuItem)sender, frmCamaraV);
        }

        private void MenuFotos_Click(object sender, EventArgs e)
        {
            frmFoto = new frmImagenes();
            AbrirFormulario((IconMenuItem)sender, frmFoto);
        }

        private void MenuInfo_Click(object sender, EventArgs e)
        {
            //AbrirFormulario((IconMenuItem)sender, new AboutBox());
            AboutBox about = new AboutBox();
            about.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //fechaActual= fechaActual.AddMilliseconds(109.49999999999995);
            //lblhora.Text = DateTime.Now.ToString("hh:mm:ss");
            lblfecha.Text = DateTime.Now.ToLongDateString();
            lblhora.Text = DateTime.Now.ToLongTimeString();
            
        }

        private void contenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void abrirArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(FormularioActivo != null)
            {
                if (FormularioActivo == frmFoto)
                {
                    openFileDialog1.Filter = "Imagenes PNG, BMP, JPG | *.PNG; *.BMP; *.JPG";
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        frmFoto.abrirFoto((Bitmap)(Bitmap.FromFile(openFileDialog1.FileName)));
                        
                        openFileDialog1.OpenFile().Dispose();
                        openFileDialog1.Dispose();
                        
                        this.Invalidate();
                    }
                }

                if(FormularioActivo == frmVideo)
                {
                    openFileDialog1.Filter = "Videos MP4| *.MP4";
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        frmVideo.cargarVideo(openFileDialog1.FileName);
                        
                        openFileDialog1.OpenFile().Dispose();
                        openFileDialog1.Dispose();

                        this.Invalidate();
                    }
                }
            }
            
        }

        private void guardarArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FormularioActivo != null)
            {
                if (FormularioActivo == frmFoto)
                {
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        //frmFoto.abrirFoto((Bitmap)(Bitmap.FromFile(openFileDialog1.FileName)));

                        frmFoto.guardarFoto(saveFileDialog1);

                        this.Invalidate();
                    }
                }
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
