namespace Batu
{
    partial class kayit_ekran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kayit_ekran));
            this.btn_kayitol = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtbox_kullaniciad = new System.Windows.Forms.TextBox();
            this.txtbox_sifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_geri = new System.Windows.Forms.Button();
            this.buttonimagelist = new System.Windows.Forms.ImageList(this.components);
            this.btn_hakkimizda = new System.Windows.Forms.Button();
            this.btn_destek = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_kayitol
            // 
            this.btn_kayitol.Location = new System.Drawing.Point(287, 211);
            this.btn_kayitol.Name = "btn_kayitol";
            this.btn_kayitol.Size = new System.Drawing.Size(150, 50);
            this.btn_kayitol.TabIndex = 13;
            this.btn_kayitol.Text = "KAYIT OL";
            this.btn_kayitol.UseVisualStyleBackColor = true;
            this.btn_kayitol.Click += new System.EventHandler(this.Btn_kayitol_Click);
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
            // txtbox_kullaniciad
            // 
            this.txtbox_kullaniciad.Location = new System.Drawing.Point(287, 150);
            this.txtbox_kullaniciad.Name = "txtbox_kullaniciad";
            this.txtbox_kullaniciad.Size = new System.Drawing.Size(211, 20);
            this.txtbox_kullaniciad.TabIndex = 14;
            this.txtbox_kullaniciad.TextChanged += new System.EventHandler(this.Txtbox_kullaniciad_TextChanged);
            // 
            // txtbox_sifre
            // 
            this.txtbox_sifre.Location = new System.Drawing.Point(287, 185);
            this.txtbox_sifre.Name = "txtbox_sifre";
            this.txtbox_sifre.PasswordChar = '*';
            this.txtbox_sifre.Size = new System.Drawing.Size(211, 20);
            this.txtbox_sifre.TabIndex = 15;
            this.txtbox_sifre.TextChanged += new System.EventHandler(this.Txtbox_sifre_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(192, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "KULLANICI ADI :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(192, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "ŞİFRE : ";
            // 
            // btn_geri
            // 
            this.btn_geri.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_geri.ForeColor = System.Drawing.Color.Red;
            this.btn_geri.Location = new System.Drawing.Point(537, 12);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(75, 23);
            this.btn_geri.TabIndex = 18;
            this.btn_geri.Text = "GERİ DÖN";
            this.btn_geri.UseVisualStyleBackColor = false;
            this.btn_geri.Click += new System.EventHandler(this.Btn_geri_Click);
            // 
            // buttonimagelist
            // 
            this.buttonimagelist.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("buttonimagelist.ImageStream")));
            this.buttonimagelist.TransparentColor = System.Drawing.Color.Transparent;
            this.buttonimagelist.Images.SetKeyName(0, "destek_icon.png");
            this.buttonimagelist.Images.SetKeyName(1, "hakkımızda.png");
            // 
            // btn_hakkimizda
            // 
            this.btn_hakkimizda.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_hakkimizda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_hakkimizda.ImageIndex = 1;
            this.btn_hakkimizda.ImageList = this.buttonimagelist;
            this.btn_hakkimizda.Location = new System.Drawing.Point(108, 403);
            this.btn_hakkimizda.Name = "btn_hakkimizda";
            this.btn_hakkimizda.Size = new System.Drawing.Size(105, 31);
            this.btn_hakkimizda.TabIndex = 20;
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
            this.btn_destek.TabIndex = 19;
            this.btn_destek.Text = "DESTEK";
            this.btn_destek.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_destek.UseVisualStyleBackColor = false;
            // 
            // kayit_ekran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(624, 446);
            this.Controls.Add(this.btn_hakkimizda);
            this.Controls.Add(this.btn_destek);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbox_sifre);
            this.Controls.Add(this.txtbox_kullaniciad);
            this.Controls.Add(this.btn_kayitol);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "kayit_ekran";
            this.Text = "Kayıt Ol";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_kayitol;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtbox_kullaniciad;
        private System.Windows.Forms.TextBox txtbox_sifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_geri;
        private System.Windows.Forms.ImageList buttonimagelist;
        private System.Windows.Forms.Button btn_hakkimizda;
        private System.Windows.Forms.Button btn_destek;
    }
}