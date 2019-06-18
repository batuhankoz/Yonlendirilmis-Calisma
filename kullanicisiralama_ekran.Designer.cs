namespace Batu
{
    partial class kullanicisiralama_ekran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kullanicisiralama_ekran));
            this.buttonimagelist = new System.Windows.Forms.ImageList(this.components);
            this.btn_yenile = new System.Windows.Forms.Button();
            this.lbl_cikisyap = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_kullanicipuan = new System.Windows.Forms.Label();
            this.lbl_kullaniciad = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_geri = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.kullanici_ad1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kullanici_puan1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonimagelist
            // 
            this.buttonimagelist.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("buttonimagelist.ImageStream")));
            this.buttonimagelist.TransparentColor = System.Drawing.Color.Transparent;
            this.buttonimagelist.Images.SetKeyName(0, "yenile.png");
            // 
            // btn_yenile
            // 
            this.btn_yenile.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btn_yenile.ImageIndex = 0;
            this.btn_yenile.ImageList = this.buttonimagelist;
            this.btn_yenile.Location = new System.Drawing.Point(507, 12);
            this.btn_yenile.Name = "btn_yenile";
            this.btn_yenile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_yenile.Size = new System.Drawing.Size(30, 30);
            this.btn_yenile.TabIndex = 46;
            this.btn_yenile.UseVisualStyleBackColor = false;
            this.btn_yenile.Click += new System.EventHandler(this.Btn_yenile_Click);
            // 
            // lbl_cikisyap
            // 
            this.lbl_cikisyap.AutoSize = true;
            this.lbl_cikisyap.ForeColor = System.Drawing.Color.Red;
            this.lbl_cikisyap.Location = new System.Drawing.Point(563, 371);
            this.lbl_cikisyap.Name = "lbl_cikisyap";
            this.lbl_cikisyap.Size = new System.Drawing.Size(51, 13);
            this.lbl_cikisyap.TabIndex = 48;
            this.lbl_cikisyap.Text = "Çıkış Yap";
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
            this.panel1.TabIndex = 47;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Puanınız :";
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
            // btn_geri
            // 
            this.btn_geri.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_geri.ForeColor = System.Drawing.Color.Red;
            this.btn_geri.Location = new System.Drawing.Point(539, 12);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(75, 23);
            this.btn_geri.TabIndex = 49;
            this.btn_geri.Text = "GERİ DÖN";
            this.btn_geri.UseVisualStyleBackColor = false;
            this.btn_geri.Click += new System.EventHandler(this.Btn_geri_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.kullanici_ad1,
            this.kullanici_puan1});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(106, 48);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(331, 324);
            this.listView1.TabIndex = 50;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // kullanici_ad1
            // 
            this.kullanici_ad1.Text = "KULLANICI ADI";
            this.kullanici_ad1.Width = 195;
            // 
            // kullanici_puan1
            // 
            this.kullanici_puan1.Text = "PUAN";
            this.kullanici_puan1.Width = 132;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(84, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "1.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(84, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "2.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(84, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 53;
            this.label5.Text = "3.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(84, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 54;
            this.label6.Text = "4.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(84, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 13);
            this.label7.TabIndex = 55;
            this.label7.Text = "5.";
            // 
            // kullanicisiralama_ekran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(626, 446);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.lbl_cikisyap);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_yenile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "kullanicisiralama_ekran";
            this.Text = "Sıralama";
            this.Load += new System.EventHandler(this.Siralama_ekran_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList buttonimagelist;
        private System.Windows.Forms.Button btn_yenile;
        private System.Windows.Forms.Label lbl_cikisyap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_kullanicipuan;
        private System.Windows.Forms.Label lbl_kullaniciad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_geri;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader kullanici_ad1;
        private System.Windows.Forms.ColumnHeader kullanici_puan1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}