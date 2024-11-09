
namespace PixelFilm
{
    partial class frmVideos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVideos));
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.iconEliminar = new FontAwesome.Sharp.IconButton();
            this.iconGuardar = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.iconPlay = new FontAwesome.Sharp.IconButton();
            this.iconPause = new FontAwesome.Sharp.IconButton();
            this.iconStop = new FontAwesome.Sharp.IconButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnVerHistograma = new FontAwesome.Sharp.IconButton();
            this.label10 = new System.Windows.Forms.Label();
            this.cHistograma = new System.Windows.Forms.Panel();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 603);
            this.label1.TabIndex = 58;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnLimpiar.IconColor = System.Drawing.Color.White;
            this.btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiar.IconSize = 20;
            this.btnLimpiar.Location = new System.Drawing.Point(61, 457);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(224, 28);
            this.btnLimpiar.TabIndex = 63;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // iconEliminar
            // 
            this.iconEliminar.BackColor = System.Drawing.Color.Firebrick;
            this.iconEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.iconEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconEliminar.ForeColor = System.Drawing.Color.White;
            this.iconEliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.iconEliminar.IconColor = System.Drawing.Color.White;
            this.iconEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconEliminar.IconSize = 20;
            this.iconEliminar.Location = new System.Drawing.Point(61, 493);
            this.iconEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.iconEliminar.Name = "iconEliminar";
            this.iconEliminar.Size = new System.Drawing.Size(224, 28);
            this.iconEliminar.TabIndex = 56;
            this.iconEliminar.Text = "Cargar Video";
            this.iconEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconEliminar.UseVisualStyleBackColor = false;
            this.iconEliminar.Click += new System.EventHandler(this.iconEliminar_Click);
            // 
            // iconGuardar
            // 
            this.iconGuardar.BackColor = System.Drawing.Color.Chartreuse;
            this.iconGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.iconGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconGuardar.ForeColor = System.Drawing.Color.Black;
            this.iconGuardar.IconChar = FontAwesome.Sharp.IconChar.SquareUpRight;
            this.iconGuardar.IconColor = System.Drawing.Color.Black;
            this.iconGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconGuardar.IconSize = 20;
            this.iconGuardar.Location = new System.Drawing.Point(61, 421);
            this.iconGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.iconGuardar.Name = "iconGuardar";
            this.iconGuardar.Size = new System.Drawing.Size(224, 28);
            this.iconGuardar.TabIndex = 55;
            this.iconGuardar.Text = "Agregar";
            this.iconGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconGuardar.UseVisualStyleBackColor = false;
            this.iconGuardar.Click += new System.EventHandler(this.iconGuardar_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1126, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 393);
            this.label3.TabIndex = 80;
            this.label3.Text = "Historial de filtros aplicados";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(56, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 33);
            this.label2.TabIndex = 79;
            this.label2.Text = "Lista de Filtros";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 31;
            this.listBox1.Location = new System.Drawing.Point(32, 99);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(277, 283);
            this.listBox1.TabIndex = 78;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(382, 46);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(725, 489);
            this.axWindowsMediaPlayer1.TabIndex = 82;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.ForeColor = System.Drawing.Color.White;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(1128, 194);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(186, 304);
            this.listBox2.TabIndex = 86;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(393, 75);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(710, 463);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 87;
            this.pictureBox2.TabStop = false;
            // 
            // iconPlay
            // 
            this.iconPlay.BackColor = System.Drawing.Color.Chartreuse;
            this.iconPlay.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.iconPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconPlay.ForeColor = System.Drawing.Color.Black;
            this.iconPlay.IconChar = FontAwesome.Sharp.IconChar.SquareUpRight;
            this.iconPlay.IconColor = System.Drawing.Color.Black;
            this.iconPlay.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPlay.IconSize = 20;
            this.iconPlay.Location = new System.Drawing.Point(403, 556);
            this.iconPlay.Margin = new System.Windows.Forms.Padding(4);
            this.iconPlay.Name = "iconPlay";
            this.iconPlay.Size = new System.Drawing.Size(224, 28);
            this.iconPlay.TabIndex = 88;
            this.iconPlay.Text = "Play";
            this.iconPlay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconPlay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconPlay.UseVisualStyleBackColor = false;
            this.iconPlay.Click += new System.EventHandler(this.iconPlay_Click);
            // 
            // iconPause
            // 
            this.iconPause.BackColor = System.Drawing.Color.Chartreuse;
            this.iconPause.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.iconPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconPause.ForeColor = System.Drawing.Color.Black;
            this.iconPause.IconChar = FontAwesome.Sharp.IconChar.SquareUpRight;
            this.iconPause.IconColor = System.Drawing.Color.Black;
            this.iconPause.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPause.IconSize = 20;
            this.iconPause.Location = new System.Drawing.Point(635, 556);
            this.iconPause.Margin = new System.Windows.Forms.Padding(4);
            this.iconPause.Name = "iconPause";
            this.iconPause.Size = new System.Drawing.Size(224, 28);
            this.iconPause.TabIndex = 89;
            this.iconPause.Text = "Pause";
            this.iconPause.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconPause.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconPause.UseVisualStyleBackColor = false;
            this.iconPause.Click += new System.EventHandler(this.iconPause_Click);
            // 
            // iconStop
            // 
            this.iconStop.BackColor = System.Drawing.Color.Chartreuse;
            this.iconStop.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.iconStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconStop.ForeColor = System.Drawing.Color.Black;
            this.iconStop.IconChar = FontAwesome.Sharp.IconChar.SquareUpRight;
            this.iconStop.IconColor = System.Drawing.Color.Black;
            this.iconStop.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconStop.IconSize = 20;
            this.iconStop.Location = new System.Drawing.Point(867, 556);
            this.iconStop.Margin = new System.Windows.Forms.Padding(4);
            this.iconStop.Name = "iconStop";
            this.iconStop.Size = new System.Drawing.Size(224, 28);
            this.iconStop.TabIndex = 90;
            this.iconStop.Text = "Stop";
            this.iconStop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconStop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconStop.UseVisualStyleBackColor = false;
            this.iconStop.Click += new System.EventHandler(this.iconStop_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1158, 559);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 91;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnVerHistograma
            // 
            this.btnVerHistograma.BackColor = System.Drawing.Color.Transparent;
            this.btnVerHistograma.IconChar = FontAwesome.Sharp.IconChar.BroomBall;
            this.btnVerHistograma.IconColor = System.Drawing.Color.Black;
            this.btnVerHistograma.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVerHistograma.IconSize = 18;
            this.btnVerHistograma.Location = new System.Drawing.Point(1558, 27);
            this.btnVerHistograma.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerHistograma.Name = "btnVerHistograma";
            this.btnVerHistograma.Size = new System.Drawing.Size(52, 25);
            this.btnVerHistograma.TabIndex = 93;
            this.btnVerHistograma.UseVisualStyleBackColor = false;
            this.btnVerHistograma.Click += new System.EventHandler(this.btnVerHistograma_Click);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(359, 23);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(1260, 33);
            this.label10.TabIndex = 92;
            this.label10.Text = "Editor de Videos";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cHistograma
            // 
            this.cHistograma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.cHistograma.Location = new System.Drawing.Point(1332, 110);
            this.cHistograma.Margin = new System.Windows.Forms.Padding(4);
            this.cHistograma.Name = "cHistograma";
            this.cHistograma.Size = new System.Drawing.Size(280, 350);
            this.cHistograma.TabIndex = 94;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(1395, 465);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(154, 56);
            this.trackBar1.TabIndex = 95;
            this.trackBar1.Value = 5;
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(1395, 505);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(154, 56);
            this.trackBar2.TabIndex = 96;
            this.trackBar2.Value = 5;
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(1395, 545);
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(154, 56);
            this.trackBar3.TabIndex = 97;
            this.trackBar3.Value = 5;
            // 
            // frmVideos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(1632, 603);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.cHistograma);
            this.Controls.Add(this.btnVerHistograma);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.iconStop);
            this.Controls.Add(this.iconPause);
            this.Controls.Add(this.iconPlay);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.iconEliminar);
            this.Controls.Add(this.iconGuardar);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmVideos";
            this.Text = "frmCaja";
            this.Load += new System.EventHandler(this.frmVideos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private FontAwesome.Sharp.IconButton iconEliminar;
        private FontAwesome.Sharp.IconButton iconGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private FontAwesome.Sharp.IconButton iconPlay;
        private FontAwesome.Sharp.IconButton iconPause;
        private FontAwesome.Sharp.IconButton iconStop;
        private System.Windows.Forms.ComboBox comboBox1;
        private FontAwesome.Sharp.IconButton btnVerHistograma;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel cHistograma;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar3;
    }
}