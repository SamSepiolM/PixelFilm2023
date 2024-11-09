
namespace PixelFilm
{
    partial class InicioPixelFilm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioPixelFilm));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.MenuArchivo = new FontAwesome.Sharp.IconMenuItem();
            this.abrirArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFotos = new FontAwesome.Sharp.IconMenuItem();
            this.MenuVideos = new FontAwesome.Sharp.IconMenuItem();
            this.MenuCamara = new FontAwesome.Sharp.IconMenuItem();
            this.MenuInfo = new FontAwesome.Sharp.IconMenuItem();
            this.menutitulo = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.contenedor = new System.Windows.Forms.Panel();
            this.lblfecha = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblhora = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.Black;
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuArchivo,
            this.MenuFotos,
            this.MenuVideos,
            this.MenuCamara,
            this.MenuInfo});
            this.menu.Location = new System.Drawing.Point(0, 86);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1632, 78);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // MenuArchivo
            // 
            this.MenuArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirArchivoToolStripMenuItem,
            this.guardarArchivoToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.MenuArchivo.ForeColor = System.Drawing.Color.White;
            this.MenuArchivo.IconChar = FontAwesome.Sharp.IconChar.File;
            this.MenuArchivo.IconColor = System.Drawing.Color.White;
            this.MenuArchivo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuArchivo.IconSize = 50;
            this.MenuArchivo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuArchivo.Name = "MenuArchivo";
            this.MenuArchivo.Size = new System.Drawing.Size(73, 74);
            this.MenuArchivo.Text = "Archivo";
            this.MenuArchivo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.MenuArchivo.ToolTipText = "menu arjcrcr";
            this.MenuArchivo.Click += new System.EventHandler(this.MenuArchivo_Click);
            // 
            // abrirArchivoToolStripMenuItem
            // 
            this.abrirArchivoToolStripMenuItem.Name = "abrirArchivoToolStripMenuItem";
            this.abrirArchivoToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.abrirArchivoToolStripMenuItem.Text = "Abrir Archivo";
            this.abrirArchivoToolStripMenuItem.Click += new System.EventHandler(this.abrirArchivoToolStripMenuItem_Click);
            // 
            // guardarArchivoToolStripMenuItem
            // 
            this.guardarArchivoToolStripMenuItem.Name = "guardarArchivoToolStripMenuItem";
            this.guardarArchivoToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.guardarArchivoToolStripMenuItem.Text = "Guardar Archivo";
            this.guardarArchivoToolStripMenuItem.Click += new System.EventHandler(this.guardarArchivoToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // MenuFotos
            // 
            this.MenuFotos.ForeColor = System.Drawing.Color.White;
            this.MenuFotos.IconChar = FontAwesome.Sharp.IconChar.PhotoVideo;
            this.MenuFotos.IconColor = System.Drawing.Color.White;
            this.MenuFotos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuFotos.IconSize = 50;
            this.MenuFotos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuFotos.Name = "MenuFotos";
            this.MenuFotos.Size = new System.Drawing.Size(64, 74);
            this.MenuFotos.Text = "Fotos";
            this.MenuFotos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.MenuFotos.Click += new System.EventHandler(this.MenuFotos_Click);
            // 
            // MenuVideos
            // 
            this.MenuVideos.ForeColor = System.Drawing.Color.White;
            this.MenuVideos.IconChar = FontAwesome.Sharp.IconChar.Video;
            this.MenuVideos.IconColor = System.Drawing.Color.White;
            this.MenuVideos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuVideos.IconSize = 50;
            this.MenuVideos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuVideos.Name = "MenuVideos";
            this.MenuVideos.Size = new System.Drawing.Size(68, 74);
            this.MenuVideos.Text = "Videos";
            this.MenuVideos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.MenuVideos.Click += new System.EventHandler(this.MenuVideos_Click);
            // 
            // MenuCamara
            // 
            this.MenuCamara.ForeColor = System.Drawing.Color.White;
            this.MenuCamara.IconChar = FontAwesome.Sharp.IconChar.Camera;
            this.MenuCamara.IconColor = System.Drawing.Color.White;
            this.MenuCamara.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuCamara.IconSize = 50;
            this.MenuCamara.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuCamara.Name = "MenuCamara";
            this.MenuCamara.Size = new System.Drawing.Size(74, 74);
            this.MenuCamara.Text = "Camara";
            this.MenuCamara.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.MenuCamara.Click += new System.EventHandler(this.MenuCamara_Click);
            // 
            // MenuInfo
            // 
            this.MenuInfo.ForeColor = System.Drawing.Color.White;
            this.MenuInfo.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.MenuInfo.IconColor = System.Drawing.Color.White;
            this.MenuInfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuInfo.IconSize = 50;
            this.MenuInfo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuInfo.Name = "MenuInfo";
            this.MenuInfo.Size = new System.Drawing.Size(89, 74);
            this.MenuInfo.Text = "Acerca de";
            this.MenuInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.MenuInfo.Click += new System.EventHandler(this.MenuInfo_Click);
            // 
            // menutitulo
            // 
            this.menutitulo.AutoSize = false;
            this.menutitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.menutitulo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menutitulo.Location = new System.Drawing.Point(0, 0);
            this.menutitulo.Name = "menutitulo";
            this.menutitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menutitulo.Size = new System.Drawing.Size(1632, 86);
            this.menutitulo.TabIndex = 1;
            this.menutitulo.Text = "menuStrip2";
            this.menutitulo.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FloralWhite;
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bienvenido a PixelFilm";
            // 
            // contenedor
            // 
            this.contenedor.AutoScroll = true;
            this.contenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(0, 164);
            this.contenedor.Margin = new System.Windows.Forms.Padding(4);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(1632, 651);
            this.contenedor.TabIndex = 3;
            this.contenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.contenedor_Paint);
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.lblfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.ForeColor = System.Drawing.Color.White;
            this.lblfecha.Location = new System.Drawing.Point(473, 21);
            this.lblfecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(44, 20);
            this.lblfecha.TabIndex = 8;
            this.lblfecha.Text = "label";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.pictureBox1.Image = global::PixelFilm.Properties.Resources.origin;
            this.pictureBox1.Location = new System.Drawing.Point(1489, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 78;
            this.pictureBox1.TabStop = false;
            // 
            // lblhora
            // 
            this.lblhora.AutoSize = true;
            this.lblhora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.lblhora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhora.ForeColor = System.Drawing.Color.White;
            this.lblhora.Location = new System.Drawing.Point(473, 49);
            this.lblhora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(44, 20);
            this.lblhora.TabIndex = 79;
            this.lblhora.Text = "label";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Imagenes PNG, BMP, JPG|*.PNG; *.BMP; *.JPG";
            this.openFileDialog1.ReadOnlyChecked = true;
            this.openFileDialog1.RestoreDirectory = true;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Imagenes PNG|*.PNG|Imagenes BitMap|*.bmp|Imagenes JPG|*.JPG";
            // 
            // InicioPixelFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(1632, 815);
            this.Controls.Add(this.lblhora);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menutitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InicioPixelFilm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PixelFilm 2023";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.MenuStrip menutitulo;
        private FontAwesome.Sharp.IconMenuItem MenuFotos;
        private FontAwesome.Sharp.IconMenuItem MenuVideos;
        private FontAwesome.Sharp.IconMenuItem MenuInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel contenedor;
        private FontAwesome.Sharp.IconMenuItem MenuCamara;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem abrirArchivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarArchivoToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem MenuArchivo;
    }
}

