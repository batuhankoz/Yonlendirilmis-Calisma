namespace Batu
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.btn_siralama = new System.Windows.Forms.Button();
            this.btn_oyna = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonimagelist = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_kullanicipuan = new System.Windows.Forms.Label();
            this.lbl_kullaniciad = new System.Windows.Forms.Label();
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(108, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 25);
            this.button1.TabIndex = 42;
            this.button1.Text = "HAKKIMIZDA";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageKey = "destek_icon.png";
            this.button2.ImageList = this.buttonimagelist;
            this.button2.Location = new System.Drawing.Point(12, 409);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.button2.Size = new System.Drawing.Size(90, 25);
            this.button2.TabIndex = 41;
            this.button2.Text = "DESTEK";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // buttonimagelist
            // 
            this.buttonimagelist.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("buttonimagelist.ImageStream")));
            this.buttonimagelist.TransparentColor = System.Drawing.Color.Transparent;
            this.buttonimagelist.Images.SetKeyName(0, "destek_icon.png");
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
            this.panel1.Location = new System.Drawing.Point(458, 387);
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
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(626, 446);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_siralama);
            this.Controls.Add(this.btn_oyna);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form5";
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_siralama;
        private System.Windows.Forms.Button btn_oyna;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ImageList buttonimagelist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_kullanicipuan;
        private System.Windows.Forms.Label lbl_kullaniciad;
    }
}