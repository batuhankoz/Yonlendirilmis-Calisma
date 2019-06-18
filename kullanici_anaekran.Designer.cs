namespace Batu
{
    partial class kullanici_anaekran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kullanici_anaekran));
            this.btn_siralama = new System.Windows.Forms.Button();
            this.btn_oyna = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonimagelist = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_kullanicipuan = new System.Windows.Forms.Label();
            this.lbl_kullaniciad = new System.Windows.Forms.Label();
            this.lbl_cikisyap = new System.Windows.Forms.Label();
            this.btn_yenile = new System.Windows.Forms.Button();
            this.btn_hakkimizda = new System.Windows.Forms.Button();
            this.btn_destek = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_siralama
            // 
            this.btn_siralama.Location = new System.Drawing.Point(245, 167);
            this.btn_siralama.Name = "btn_siralama";
            this.btn_siralama.Size = new System.Drawing.Size(150, 50);
            this.btn_siralama.TabIndex = 11;
            this.btn_siralama.Text = "SIRALAMA";
            this.btn_siralama.UseVisualStyleBackColor = true;
            this.btn_siralama.Click += new System.EventHandler(this.Btn_siralama_Click);
            // 
            // btn_oyna
            // 
            this.btn_oyna.Location = new System.Drawing.Point(245, 111);
            this.btn_oyna.Name = "btn_oyna";
            this.btn_oyna.Size = new System.Drawing.Size(150, 50);
            this.btn_oyna.TabIndex = 10;
            this.btn_oyna.Text = "OYNA";
            this.btn_oyna.UseVisualStyleBackColor = true;
            this.btn_oyna.Click += new System.EventHandler(this.Btn_oyna_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(195, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 66);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // buttonimagelist
            // 
            this.buttonimagelist.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("buttonimagelist.ImageStream")));
            this.buttonimagelist.TransparentColor = System.Drawing.Color.Transparent;
            this.buttonimagelist.Images.SetKeyName(0, "destek_icon.png");
            this.buttonimagelist.Images.SetKeyName(1, "yenile.png");
            this.buttonimagelist.Images.SetKeyName(2, "hakkımızda.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hoşgeldiniz :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Puanınız :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_kullanicipuan);
            this.panel1.Controls.Add(this.lbl_kullaniciad);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(451, 387);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 47);
            this.panel1.TabIndex = 43;
            // 
            // lbl_kullanicipuan
            // 
            this.lbl_kullanicipuan.AutoSize = true;
            this.lbl_kullanicipuan.Location = new System.Drawing.Point(76, 28);
            this.lbl_kullanicipuan.Name = "lbl_kullanicipuan";
            this.lbl_kullanicipuan.Size = new System.Drawing.Size(10, 13);
            this.lbl_kullanicipuan.TabIndex = 3;
            this.lbl_kullanicipuan.Text = " ";
            // 
            // lbl_kullaniciad
            // 
            this.lbl_kullaniciad.AutoSize = true;
            this.lbl_kullaniciad.Location = new System.Drawing.Point(76, 4);
            this.lbl_kullaniciad.Name = "lbl_kullaniciad";
            this.lbl_kullaniciad.Size = new System.Drawing.Size(10, 13);
            this.lbl_kullaniciad.TabIndex = 2;
            this.lbl_kullaniciad.Text = " ";
            // 
            // lbl_cikisyap
            // 
            this.lbl_cikisyap.AutoSize = true;
            this.lbl_cikisyap.ForeColor = System.Drawing.Color.Red;
            this.lbl_cikisyap.Location = new System.Drawing.Point(563, 371);
            this.lbl_cikisyap.Name = "lbl_cikisyap";
            this.lbl_cikisyap.Size = new System.Drawing.Size(51, 13);
            this.lbl_cikisyap.TabIndex = 44;
            this.lbl_cikisyap.Text = "Çıkış Yap";
            this.lbl_cikisyap.Click += new System.EventHandler(this.Lbl_cikisyap_Click);
            // 
            // btn_yenile
            // 
            this.btn_yenile.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btn_yenile.ImageIndex = 1;
            this.btn_yenile.ImageList = this.buttonimagelist;
            this.btn_yenile.Location = new System.Drawing.Point(584, 12);
            this.btn_yenile.Name = "btn_yenile";
            this.btn_yenile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_yenile.Size = new System.Drawing.Size(30, 30);
            this.btn_yenile.TabIndex = 45;
            this.btn_yenile.UseVisualStyleBackColor = false;
            this.btn_yenile.Click += new System.EventHandler(this.Btn_yenile_Click);
            // 
            // btn_hakkimizda
            // 
            this.btn_hakkimizda.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_hakkimizda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_hakkimizda.ImageIndex = 2;
            this.btn_hakkimizda.ImageList = this.buttonimagelist;
            this.btn_hakkimizda.Location = new System.Drawing.Point(108, 403);
            this.btn_hakkimizda.Name = "btn_hakkimizda";
            this.btn_hakkimizda.Size = new System.Drawing.Size(105, 31);
            this.btn_hakkimizda.TabIndex = 47;
            this.btn_hakkimizda.Text = "HAKKIMIZDA";
            this.btn_hakkimizda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_hakkimizda.UseVisualStyleBackColor = false;
            this.btn_hakkimizda.Click += new System.EventHandler(this.Btn_hakkimizda_Click_1);
            // 
            // btn_destek
            // 
            this.btn_destek.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_destek.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_destek.ImageKey = "destek_icon.png";
            this.btn_destek.ImageList = this.buttonimagelist;
            this.btn_destek.Location = new System.Drawing.Point(12, 403);
            this.btn_destek.Name = "btn_destek";
            this.btn_destek.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btn_destek.Size = new System.Drawing.Size(90, 31);
            this.btn_destek.TabIndex = 46;
            this.btn_destek.Text = "DESTEK";
            this.btn_destek.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_destek.UseVisualStyleBackColor = false;
            // 
            // kullanici_anaekran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(626, 446);
            this.Controls.Add(this.btn_hakkimizda);
            this.Controls.Add(this.btn_destek);
            this.Controls.Add(this.btn_yenile);
            this.Controls.Add(this.lbl_cikisyap);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_siralama);
            this.Controls.Add(this.btn_oyna);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "kullanici_anaekran";
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_siralama;
        private System.Windows.Forms.Button btn_oyna;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList buttonimagelist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_kullanicipuan;
        private System.Windows.Forms.Label lbl_kullaniciad;
        private System.Windows.Forms.Label lbl_cikisyap;
        private System.Windows.Forms.Button btn_yenile;
        private System.Windows.Forms.Button btn_hakkimizda;
        private System.Windows.Forms.Button btn_destek;
    }
}