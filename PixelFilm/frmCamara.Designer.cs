
namespace PixelFilm
{
    partial class frmCamara
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
            this.label10 = new System.Windows.Forms.Label();
            this.lblNumeroDetect = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnVerHistograma = new FontAwesome.Sharp.IconButton();
            this.iconGuardar = new FontAwesome.Sharp.IconButton();
            this.cHistograma = new System.Windows.Forms.Panel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnRecargar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(359, 23);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(1119, 33);
            this.label10.TabIndex = 36;
            this.label10.Text = "Visor de Camara";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNumeroDetect
            // 
            this.lblNumeroDetect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblNumeroDetect.Cursor = System.Windows.Forms.Cursors.No;
            this.lblNumeroDetect.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroDetect.ForeColor = System.Drawing.Color.White;
            this.lblNumeroDetect.Location = new System.Drawing.Point(277, 116);
            this.lblNumeroDetect.Margin = new System.Windows.Forms.Padding(4);
            this.lblNumeroDetect.Name = "lblNumeroDetect";
            this.lblNumeroDetect.ReadOnly = true;
            this.lblNumeroDetect.Size = new System.Drawing.Size(55, 45);
            this.lblNumeroDetect.TabIndex = 23;
            this.lblNumeroDetect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 32);
            this.label2.TabIndex = 22;
            this.label2.Text = "Rostros Detectados";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 553);
            this.label1.TabIndex = 37;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(400, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(730, 466);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 82;
            this.pictureBox1.TabStop = false;
            // 
            // btnVerHistograma
            // 
            this.btnVerHistograma.BackColor = System.Drawing.Color.Transparent;
            this.btnVerHistograma.IconChar = FontAwesome.Sharp.IconChar.BroomBall;
            this.btnVerHistograma.IconColor = System.Drawing.Color.Black;
            this.btnVerHistograma.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVerHistograma.IconSize = 18;
            this.btnVerHistograma.Location = new System.Drawing.Point(1405, 28);
            this.btnVerHistograma.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerHistograma.Name = "btnVerHistograma";
            this.btnVerHistograma.Size = new System.Drawing.Size(52, 25);
            this.btnVerHistograma.TabIndex = 47;
            this.btnVerHistograma.UseVisualStyleBackColor = false;
            this.btnVerHistograma.Click += new System.EventHandler(this.btnVerHistograma_Click);
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
            this.iconGuardar.Location = new System.Drawing.Point(60, 294);
            this.iconGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.iconGuardar.Name = "iconGuardar";
            this.iconGuardar.Size = new System.Drawing.Size(224, 28);
            this.iconGuardar.TabIndex = 32;
            this.iconGuardar.Text = "Tomar Foto";
            this.iconGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconGuardar.UseVisualStyleBackColor = false;
            this.iconGuardar.Click += new System.EventHandler(this.iconGuardar_Click);
            // 
            // cHistograma
            // 
            this.cHistograma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.cHistograma.Location = new System.Drawing.Point(1165, 76);
            this.cHistograma.Margin = new System.Windows.Forms.Padding(4);
            this.cHistograma.Name = "cHistograma";
            this.cHistograma.Size = new System.Drawing.Size(300, 400);
            this.cHistograma.TabIndex = 83;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Imagenes PNG|*.PNG|Imagenes BitMap|*.bmp|Imagenes JPG|*.JPG";
            // 
            // btnRecargar
            // 
            this.btnRecargar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRecargar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRecargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecargar.ForeColor = System.Drawing.Color.White;
            this.btnRecargar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnRecargar.IconColor = System.Drawing.Color.White;
            this.btnRecargar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRecargar.IconSize = 20;
            this.btnRecargar.Location = new System.Drawing.Point(61, 330);
            this.btnRecargar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRecargar.Name = "btnRecargar";
            this.btnRecargar.Size = new System.Drawing.Size(224, 28);
            this.btnRecargar.TabIndex = 84;
            this.btnRecargar.Text = "Recargar Cámara";
            this.btnRecargar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRecargar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRecargar.UseVisualStyleBackColor = false;
            this.btnRecargar.Click += new System.EventHandler(this.btnRecargar_Click);
            // 
            // frmCamara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(1482, 553);
            this.Controls.Add(this.btnRecargar);
            this.Controls.Add(this.cHistograma);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnVerHistograma);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.iconGuardar);
            this.Controls.Add(this.lblNumeroDetect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCamara";
            this.Text = "Camara";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCamara_FormClosing);
            this.Load += new System.EventHandler(this.frmCamara_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private FontAwesome.Sharp.IconButton iconGuardar;
        private System.Windows.Forms.TextBox lblNumeroDetect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnVerHistograma;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel cHistograma;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private FontAwesome.Sharp.IconButton btnRecargar;
    }
}