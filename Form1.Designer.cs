namespace FlappyBirdGamee
{
    partial class FlappyBirdGamee
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlappyBirdGamee));
            pbKus = new PictureBox();
            ustBoru = new PictureBox();
            altBoru = new PictureBox();
            pbZemin = new PictureBox();
            oyunZamani = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pbKus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ustBoru).BeginInit();
            ((System.ComponentModel.ISupportInitialize)altBoru).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbZemin).BeginInit();
            SuspendLayout();
            // 
            // pbKus
            // 
            pbKus.BackColor = Color.Transparent;
            pbKus.Image = (Image)resources.GetObject("pbKus.Image");
            pbKus.Location = new Point(117, 299);
            pbKus.Name = "pbKus";
            pbKus.Size = new Size(50, 50);
            pbKus.SizeMode = PictureBoxSizeMode.StretchImage;
            pbKus.TabIndex = 0;
            pbKus.TabStop = false;
            pbKus.Click += pbKus_Click;
            // 
            // ustBoru
            // 
            ustBoru.BackColor = Color.Transparent;
            ustBoru.BorderStyle = BorderStyle.FixedSingle;
            ustBoru.Image = (Image)resources.GetObject("ustBoru.Image");
            ustBoru.Location = new Point(378, -37);
            ustBoru.Name = "ustBoru";
            ustBoru.Size = new Size(90, 250);
            ustBoru.SizeMode = PictureBoxSizeMode.StretchImage;
            ustBoru.TabIndex = 1;
            ustBoru.TabStop = false;
            ustBoru.Click += ustBoru_Click;
            // 
            // altBoru
            // 
            altBoru.BackColor = Color.Transparent;
            altBoru.BorderStyle = BorderStyle.FixedSingle;
            altBoru.Image = (Image)resources.GetObject("altBoru.Image");
            altBoru.Location = new Point(378, 407);
            altBoru.Name = "altBoru";
            altBoru.Size = new Size(90, 250);
            altBoru.SizeMode = PictureBoxSizeMode.StretchImage;
            altBoru.TabIndex = 2;
            altBoru.TabStop = false;
            altBoru.Click += altBoru_Click;
            // 
            // pbZemin
            // 
            pbZemin.BackColor = Color.Transparent;
            pbZemin.Image = (Image)resources.GetObject("pbZemin.Image");
            pbZemin.Location = new Point(-9, 545);
            pbZemin.Name = "pbZemin";
            pbZemin.Size = new Size(598, 112);
            pbZemin.SizeMode = PictureBoxSizeMode.StretchImage;
            pbZemin.TabIndex = 3;
            pbZemin.TabStop = false;
            pbZemin.Click += pbZemin_Click;
            // 
            // oyunZamani
            // 
            oyunZamani.Enabled = true;
            oyunZamani.Interval = 20;
            oyunZamani.Tick += oyunZamani_Tick;
            // 
            // FlappyBirdGamee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(582, 653);
            Controls.Add(pbZemin);
            Controls.Add(altBoru);
            Controls.Add(ustBoru);
            Controls.Add(pbKus);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FlappyBirdGamee";
            Text = " ";
            KeyDown += FlappyBirdGamee_KeyDown;
            KeyUp += FlappyBirdGamee_KeyUp;
            ((System.ComponentModel.ISupportInitialize)pbKus).EndInit();
            ((System.ComponentModel.ISupportInitialize)ustBoru).EndInit();
            ((System.ComponentModel.ISupportInitialize)altBoru).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbZemin).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbKus;
        private PictureBox ustBoru;
        private PictureBox altBoru;
        private PictureBox pbZemin;
        private System.Windows.Forms.Timer oyunZamani;
    }
}
