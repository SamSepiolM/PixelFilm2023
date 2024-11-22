
namespace PixelFilm
{
    partial class frmHistograma
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
            this.Draw_RGB = new System.Windows.Forms.CheckBox();
            this.Draw_R = new System.Windows.Forms.CheckBox();
            this.Draw_G = new System.Windows.Forms.CheckBox();
            this.Draw_B = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Draw_RGB
            // 
            this.Draw_RGB.AutoSize = true;
            this.Draw_RGB.BackColor = System.Drawing.Color.White;
            this.Draw_RGB.Location = new System.Drawing.Point(27, 286);
            this.Draw_RGB.Name = "Draw_RGB";
            this.Draw_RGB.Size = new System.Drawing.Size(100, 21);
            this.Draw_RGB.TabIndex = 0;
            this.Draw_RGB.Text = "Draw_RGB";
            this.Draw_RGB.UseVisualStyleBackColor = false;
            this.Draw_RGB.CheckedChanged += new System.EventHandler(this.Draw_RGB_CheckedChanged);
            // 
            // Draw_R
            // 
            this.Draw_R.AutoSize = true;
            this.Draw_R.BackColor = System.Drawing.Color.White;
            this.Draw_R.Location = new System.Drawing.Point(156, 286);
            this.Draw_R.Name = "Draw_R";
            this.Draw_R.Size = new System.Drawing.Size(100, 21);
            this.Draw_R.TabIndex = 1;
            this.Draw_R.Text = "Draw_R     ";
            this.Draw_R.UseVisualStyleBackColor = false;
            this.Draw_R.CheckedChanged += new System.EventHandler(this.Draw_R_CheckedChanged);
            // 
            // Draw_G
            // 
            this.Draw_G.AutoSize = true;
            this.Draw_G.BackColor = System.Drawing.Color.White;
            this.Draw_G.Location = new System.Drawing.Point(27, 323);
            this.Draw_G.Name = "Draw_G";
            this.Draw_G.Size = new System.Drawing.Size(101, 21);
            this.Draw_G.TabIndex = 2;
            this.Draw_G.Text = "Draw_G     ";
            this.Draw_G.UseVisualStyleBackColor = false;
            this.Draw_G.CheckedChanged += new System.EventHandler(this.Draw_G_CheckedChanged);
            // 
            // Draw_B
            // 
            this.Draw_B.AutoSize = true;
            this.Draw_B.BackColor = System.Drawing.Color.White;
            this.Draw_B.Location = new System.Drawing.Point(156, 323);
            this.Draw_B.Name = "Draw_B";
            this.Draw_B.Size = new System.Drawing.Size(99, 21);
            this.Draw_B.TabIndex = 3;
            this.Draw_B.Text = "Draw_B     ";
            this.Draw_B.UseVisualStyleBackColor = false;
            this.Draw_B.CheckedChanged += new System.EventHandler(this.Draw_B_CheckedChanged);
            // 
            // frmHistograma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(282, 353);
            this.Controls.Add(this.Draw_B);
            this.Controls.Add(this.Draw_G);
            this.Controls.Add(this.Draw_R);
            this.Controls.Add(this.Draw_RGB);
            this.Name = "frmHistograma";
            this.Text = "frmHistograma";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmHistograma_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Draw_RGB;
        private System.Windows.Forms.CheckBox Draw_R;
        private System.Windows.Forms.CheckBox Draw_G;
        private System.Windows.Forms.CheckBox Draw_B;
    }
}