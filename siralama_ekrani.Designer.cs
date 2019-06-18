namespace Batu
{
    partial class siralama_ekrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(siralama_ekrani));
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.kullanici_puan1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kullanici_ad1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label6 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btn_geri = new System.Windows.Forms.Button();
            this.btn_yenile = new System.Windows.Forms.Button();
            this.buttonimagelist = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(44, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 13);
            this.label7.TabIndex = 65;
            this.label7.Text = "5.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(44, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 63;
            this.label5.Text = "3.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(44, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 62;
            this.label4.Text = "2.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(44, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 61;
            this.label3.Text = "1.";
            // 
            // kullanici_puan1
            // 
            this.kullanici_puan1.Text = "PUAN";
            this.kullanici_puan1.Width = 195;
            // 
            // kullanici_ad1
            // 
            this.kullanici_ad1.Text = "KULLANICI ADI";
            this.kullanici_ad1.Width = 195;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(44, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 64;
            this.label6.Text = "4.";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.kullanici_ad1,
            this.kullanici_puan1});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(66, 75);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(393, 324);
            this.listView1.TabIndex = 60;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // btn_geri
            // 
            this.btn_geri.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_geri.ForeColor = System.Drawing.Color.Red;
            this.btn_geri.Location = new System.Drawing.Point(539, 12);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(75, 23);
            this.btn_geri.TabIndex = 59;
            this.btn_geri.Text = "GERİ DÖN";
            this.btn_geri.UseVisualStyleBackColor = false;
            this.btn_geri.Click += new System.EventHandler(this.Btn_geri_Click);
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
            this.btn_yenile.TabIndex = 56;
            this.btn_yenile.UseVisualStyleBackColor = false;
            this.btn_yenile.Click += new System.EventHandler(this.Btn_yenile_Click);
            // 
            // buttonimagelist
            // 
            this.buttonimagelist.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("buttonimagelist.ImageStream")));
            this.buttonimagelist.TransparentColor = System.Drawing.Color.Transparent;
            this.buttonimagelist.Images.SetKeyName(0, "yenile.png");
            // 
            // siralama_ekrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Batu.Properties.Resources.background_630x450;
            this.ClientSize = new System.Drawing.Size(626, 446);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.btn_yenile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "siralama_ekrani";
            this.Text = "siralama_ekrani";
            this.Load += new System.EventHandler(this.Siralama_ekrani_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader kullanici_puan1;
        private System.Windows.Forms.ColumnHeader kullanici_ad1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btn_geri;
        private System.Windows.Forms.Button btn_yenile;
        private System.Windows.Forms.ImageList buttonimagelist;
    }
}