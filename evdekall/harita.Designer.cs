
namespace evdekall
{
    partial class harita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(harita));
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtİLCE = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.mekan = new System.Windows.Forms.ComboBox();
            this.hareket = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.iller = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cikis = new System.Windows.Forms.PictureBox();
            this.kucult = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cikis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kucult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(190, 66);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(812, 484);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "İLÇE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(72, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "İL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(26, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = " NE ARIYORSUN ?";
            // 
            // txtİLCE
            // 
            this.txtİLCE.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.txtİLCE.Location = new System.Drawing.Point(27, 298);
            this.txtİLCE.Name = "txtİLCE";
            this.txtİLCE.Size = new System.Drawing.Size(125, 25);
            this.txtİLCE.TabIndex = 5;
            this.txtİLCE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtİLCE_KeyPress);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(18, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 44);
            this.button1.TabIndex = 9;
            this.button1.Text = "ARA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mekan
            // 
            this.mekan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mekan.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mekan.Items.AddRange(new object[] {
            "",
            "Eczane",
            "Hastane",
            "Market",
            "Bakkal",
            "Fırın",
            "Süpermarket"});
            this.mekan.Location = new System.Drawing.Point(26, 361);
            this.mekan.Name = "mekan";
            this.mekan.Size = new System.Drawing.Size(126, 27);
            this.mekan.TabIndex = 11;
            // 
            // hareket
            // 
            this.hareket.BackColor = System.Drawing.Color.Red;
            this.hareket.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hareket.Location = new System.Drawing.Point(-1, -1);
            this.hareket.Margin = new System.Windows.Forms.Padding(4);
            this.hareket.Name = "hareket";
            this.hareket.Size = new System.Drawing.Size(1020, 22);
            this.hareket.TabIndex = 56;
            this.hareket.MouseDown += new System.Windows.Forms.MouseEventHandler(this.hareket_MouseDown);
            this.hareket.MouseMove += new System.Windows.Forms.MouseEventHandler(this.hareket_MouseMove);
            this.hareket.MouseUp += new System.Windows.Forms.MouseEventHandler(this.hareket_MouseUp);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(91, 404);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 44);
            this.button2.TabIndex = 58;
            this.button2.Text = "TEMİZLE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // iller
            // 
            this.iller.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.iller.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.iller.Items.AddRange(new object[] {
            "",
            "Adana",
            "Adıyaman",
            "Afyon",
            "Ağrı",
            "Amasya",
            "Ankara",
            "Antalya",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkari",
            "Hatay",
            "Isparta",
            "İçel (Mersin)",
            "İstanbul",
            "İzmir",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kırklareli",
            "Kırşehir",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "Kahramanmaraş",
            "Mardin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Rize",
            "Sakarya",
            "Samsun",
            "Siirt",
            "Sinop",
            "Sivas",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Şanlıurfa",
            "Uşak",
            "Van",
            "Yozgat",
            "Zonguldak",
            "Aksaray",
            "Bayburt",
            "Karaman",
            "Kırıkkale",
            "Batman",
            "Şırnak",
            "Bartın",
            "Ardahan",
            "Iğdır",
            "Yalova",
            "Karabük",
            "Kilis",
            "Osmaniye",
            "Düzce"});
            this.iller.Location = new System.Drawing.Point(26, 246);
            this.iller.Name = "iller";
            this.iller.Size = new System.Drawing.Size(126, 27);
            this.iller.TabIndex = 59;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(-1, 557);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1020, 22);
            this.panel1.TabIndex = 57;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::evdekall.Properties.Resources.maps;
            this.pictureBox2.Location = new System.Drawing.Point(26, 102);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(126, 92);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 62;
            this.pictureBox2.TabStop = false;
            // 
            // cikis
            // 
            this.cikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cikis.Image = global::evdekall.Properties.Resources.previous;
            this.cikis.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cikis.Location = new System.Drawing.Point(966, 27);
            this.cikis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(36, 34);
            this.cikis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cikis.TabIndex = 57;
            this.cikis.TabStop = false;
            this.cikis.Click += new System.EventHandler(this.cikis_Click);
            // 
            // kucult
            // 
            this.kucult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kucult.Image = global::evdekall.Properties.Resources.minimize;
            this.kucult.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.kucult.Location = new System.Drawing.Point(930, 28);
            this.kucult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kucult.Name = "kucult";
            this.kucult.Size = new System.Drawing.Size(30, 33);
            this.kucult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kucult.TabIndex = 55;
            this.kucult.TabStop = false;
            this.kucult.Click += new System.EventHandler(this.kucult_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::evdekall.Properties.Resources.mapload;
            this.pictureBox1.Location = new System.Drawing.Point(190, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(812, 484);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(461, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 28);
            this.label6.TabIndex = 63;
            this.label6.Text = "HARİTALAR";
            // 
            // harita
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 577);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.iller);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cikis);
            this.Controls.Add(this.hareket);
            this.Controls.Add(this.kucult);
            this.Controls.Add(this.mekan);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtİLCE);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.webBrowser1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "harita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Haritalar";
            this.Load += new System.EventHandler(this.harita_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cikis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kucult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtİLCE;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox mekan;
        private System.Windows.Forms.PictureBox cikis;
        private System.Windows.Forms.Panel hareket;
        private System.Windows.Forms.PictureBox kucult;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox iller;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
    }
}