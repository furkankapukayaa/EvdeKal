﻿
namespace evdekall
{
    partial class giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(giris));
            this.label4 = new System.Windows.Forms.Label();
            this.yas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.soyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ad = new System.Windows.Forms.TextBox();
            this.hareket = new System.Windows.Forms.Panel();
            this.panel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.girisYap = new System.Windows.Forms.Button();
            this.cikis = new System.Windows.Forms.PictureBox();
            this.kucult = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cikis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kucult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Oswald", 14.25F);
            this.label4.Location = new System.Drawing.Point(39, 287);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 32);
            this.label4.TabIndex = 25;
            this.label4.Text = "Yaşınız";
            // 
            // yas
            // 
            this.yas.BackColor = System.Drawing.SystemColors.InfoText;
            this.yas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.yas.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            this.yas.ForeColor = System.Drawing.Color.White;
            this.yas.Location = new System.Drawing.Point(111, 293);
            this.yas.Margin = new System.Windows.Forms.Padding(4);
            this.yas.Name = "yas";
            this.yas.Size = new System.Drawing.Size(204, 22);
            this.yas.TabIndex = 24;
            this.yas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.yas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.yas_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Oswald", 14.25F);
            this.label2.Location = new System.Drawing.Point(36, 240);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 32);
            this.label2.TabIndex = 23;
            this.label2.Text = "Soyadınız";
            // 
            // soyad
            // 
            this.soyad.BackColor = System.Drawing.SystemColors.InfoText;
            this.soyad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.soyad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.soyad.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            this.soyad.ForeColor = System.Drawing.Color.White;
            this.soyad.Location = new System.Drawing.Point(129, 246);
            this.soyad.Margin = new System.Windows.Forms.Padding(4);
            this.soyad.Name = "soyad";
            this.soyad.Size = new System.Drawing.Size(186, 22);
            this.soyad.TabIndex = 22;
            this.soyad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.soyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soyad_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(36, 193);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 32);
            this.label1.TabIndex = 21;
            this.label1.Text = "Adınız";
            // 
            // ad
            // 
            this.ad.BackColor = System.Drawing.SystemColors.InfoText;
            this.ad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ad.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            this.ad.ForeColor = System.Drawing.Color.White;
            this.ad.Location = new System.Drawing.Point(103, 199);
            this.ad.Margin = new System.Windows.Forms.Padding(4);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(212, 22);
            this.ad.TabIndex = 18;
            this.ad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ad_KeyPress);
            // 
            // hareket
            // 
            this.hareket.BackColor = System.Drawing.Color.Red;
            this.hareket.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hareket.Location = new System.Drawing.Point(-1, -1);
            this.hareket.Margin = new System.Windows.Forms.Padding(4);
            this.hareket.Name = "hareket";
            this.hareket.Size = new System.Drawing.Size(369, 22);
            this.hareket.TabIndex = 57;
            this.hareket.MouseDown += new System.Windows.Forms.MouseEventHandler(this.hareket_MouseDown);
            this.hareket.MouseMove += new System.Windows.Forms.MouseEventHandler(this.hareket_MouseMove);
            this.hareket.MouseUp += new System.Windows.Forms.MouseEventHandler(this.hareket_MouseUp);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Red;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel.Location = new System.Drawing.Point(-1, 406);
            this.panel.Margin = new System.Windows.Forms.Padding(4);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(369, 22);
            this.panel.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Oswald", 18F);
            this.label3.Location = new System.Drawing.Point(138, 125);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 41);
            this.label3.TabIndex = 60;
            this.label3.Text = "GİRİŞ YAP";
            // 
            // girisYap
            // 
            this.girisYap.BackColor = System.Drawing.Color.Transparent;
            this.girisYap.BackgroundImage = global::evdekall.Properties.Resources.login1;
            this.girisYap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.girisYap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.girisYap.FlatAppearance.BorderSize = 0;
            this.girisYap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.girisYap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.girisYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.girisYap.ForeColor = System.Drawing.Color.Transparent;
            this.girisYap.Location = new System.Drawing.Point(296, 330);
            this.girisYap.Name = "girisYap";
            this.girisYap.Size = new System.Drawing.Size(58, 73);
            this.girisYap.TabIndex = 59;
            this.girisYap.UseVisualStyleBackColor = false;
            this.girisYap.Click += new System.EventHandler(this.girisYap_Click);
            // 
            // cikis
            // 
            this.cikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cikis.Image = global::evdekall.Properties.Resources.remove_button;
            this.cikis.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cikis.Location = new System.Drawing.Point(332, 22);
            this.cikis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(30, 33);
            this.cikis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cikis.TabIndex = 56;
            this.cikis.TabStop = false;
            this.cikis.Click += new System.EventHandler(this.cikis_Click);
            // 
            // kucult
            // 
            this.kucult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kucult.Image = global::evdekall.Properties.Resources.minimize;
            this.kucult.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.kucult.Location = new System.Drawing.Point(296, 22);
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
            this.pictureBox1.Image = global::evdekall.Properties.Resources.evdekala;
            this.pictureBox1.Location = new System.Drawing.Point(13, 29);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // giris
            // 
            this.AcceptButton = this.girisYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 426);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.girisYap);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.hareket);
            this.Controls.Add(this.cikis);
            this.Controls.Add(this.kucult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.yas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.soyad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Yap";
            this.Load += new System.EventHandler(this.giris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cikis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kucult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox yas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox soyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox cikis;
        private System.Windows.Forms.PictureBox kucult;
        private System.Windows.Forms.Panel hareket;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button girisYap;
        private System.Windows.Forms.TextBox ad;
        private System.Windows.Forms.Label label3;
    }
}