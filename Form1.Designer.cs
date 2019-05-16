namespace Batu
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_destek = new System.Windows.Forms.Button();
            this.buttonimagelist = new System.Windows.Forms.ImageList(this.components);
            this.btn_hakkimizda = new System.Windows.Forms.Button();
            this.btn_oyna = new System.Windows.Forms.Button();
            this.btn_siralama = new System.Windows.Forms.Button();
            this.btn_girisyap = new System.Windows.Forms.Button();
            this.iconimagelist = new System.Windows.Forms.ImageList(this.components);
            this.btn_kayitol = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(195, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 66);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_destek
            // 
            this.btn_destek.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_destek.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_destek.ImageKey = "destek_icon.png";
            this.btn_destek.ImageList = this.buttonimagelist;
            this.btn_destek.Location = new System.Drawing.Point(12, 409);
            this.btn_destek.Name = "btn_destek";
            this.btn_destek.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btn_destek.Size = new System.Drawing.Size(90, 25);
            this.btn_destek.TabIndex = 1;
            this.btn_destek.Text = "DESTEK";
            this.btn_destek.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_destek.UseVisualStyleBackColor = false;
            // 
            // buttonimagelist
            // 
            this.buttonimagelist.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("buttonimagelist.ImageStream")));
            this.buttonimagelist.TransparentColor = System.Drawing.Color.Transparent;
            this.buttonimagelist.Images.SetKeyName(0, "destek_icon.png");
            // 
            // btn_hakkimizda
            // 
            this.btn_hakkimizda.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_hakkimizda.Location = new System.Drawing.Point(108, 409);
            this.btn_hakkimizda.Name = "btn_hakkimizda";
            this.btn_hakkimizda.Size = new System.Drawing.Size(90, 25);
            this.btn_hakkimizda.TabIndex = 2;
            this.btn_hakkimizda.Text = "HAKKIMIZDA";
            this.btn_hakkimizda.UseVisualStyleBackColor = false;
            // 
            // btn_oyna
            // 
            this.btn_oyna.Location = new System.Drawing.Point(245, 111);
            this.btn_oyna.Name = "btn_oyna";
            this.btn_oyna.Size = new System.Drawing.Size(150, 50);
            this.btn_oyna.TabIndex = 3;
            this.btn_oyna.Text = "OYNA";
            this.btn_oyna.UseVisualStyleBackColor = true;
            this.btn_oyna.Click += new System.EventHandler(this.Btn_oyna_Click);
            // 
            // btn_siralama
            // 
            this.btn_siralama.Location = new System.Drawing.Point(245, 167);
            this.btn_siralama.Name = "btn_siralama";
            this.btn_siralama.Size = new System.Drawing.Size(150, 50);
            this.btn_siralama.TabIndex = 4;
            this.btn_siralama.Text = "SIRALAMA";
            this.btn_siralama.UseVisualStyleBackColor = true;
            // 
            // btn_girisyap
            // 
            this.btn_girisyap.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_girisyap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_girisyap.ImageKey = "girişyap_icon.png";
            this.btn_girisyap.ImageList = this.iconimagelist;
            this.btn_girisyap.Location = new System.Drawing.Point(166, 223);
            this.btn_girisyap.Name = "btn_girisyap";
            this.btn_girisyap.Padding = new System.Windows.Forms.Padding(10, 0, 15, 0);
            this.btn_girisyap.Size = new System.Drawing.Size(150, 50);
            this.btn_girisyap.TabIndex = 5;
            this.btn_girisyap.Text = "GİRİŞ YAP";
            this.btn_girisyap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_girisyap.UseVisualStyleBackColor = false;
            this.btn_girisyap.Click += new System.EventHandler(this.Btn_girisyap_Click);
            // 
            // iconimagelist
            // 
            this.iconimagelist.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconimagelist.ImageStream")));
            this.iconimagelist.TransparentColor = System.Drawing.Color.Transparent;
            this.iconimagelist.Images.SetKeyName(0, "anaekran_icon.png");
            this.iconimagelist.Images.SetKeyName(1, "girişyap_icon.png");
            this.iconimagelist.Images.SetKeyName(2, "kayıtol_icon.png");
            // 
            // btn_kayitol
            // 
            this.btn_kayitol.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_kayitol.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kayitol.ImageKey = "kayıtol_icon.png";
            this.btn_kayitol.ImageList = this.iconimagelist;
            this.btn_kayitol.Location = new System.Drawing.Point(322, 223);
            this.btn_kayitol.Name = "btn_kayitol";
            this.btn_kayitol.Padding = new System.Windows.Forms.Padding(10, 0, 15, 0);
            this.btn_kayitol.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_kayitol.Size = new System.Drawing.Size(150, 50);
            this.btn_kayitol.TabIndex = 6;
            this.btn_kayitol.Text = "KAYIT OL";
            this.btn_kayitol.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_kayitol.UseVisualStyleBackColor = false;
            this.btn_kayitol.Click += new System.EventHandler(this.Btn_kayitol_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(624, 446);
            this.Controls.Add(this.btn_kayitol);
            this.Controls.Add(this.btn_girisyap);
            this.Controls.Add(this.btn_siralama);
            this.Controls.Add(this.btn_oyna);
            this.Controls.Add(this.btn_hakkimizda);
            this.Controls.Add(this.btn_destek);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Ana Sayfa";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_destek;
        private System.Windows.Forms.Button btn_hakkimizda;
        private System.Windows.Forms.Button btn_oyna;
        private System.Windows.Forms.Button btn_siralama;
        private System.Windows.Forms.Button btn_girisyap;
        private System.Windows.Forms.Button btn_kayitol;
        private System.Windows.Forms.ImageList buttonimagelist;
        private System.Windows.Forms.ImageList iconimagelist;
    }
}