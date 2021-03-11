
namespace evdekall
{
    partial class profil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(profil));
            this.label1 = new System.Windows.Forms.Label();
            this.yas = new System.Windows.Forms.TextBox();
            this.adsoyad = new System.Windows.Forms.TextBox();
            this.izinsorgu = new System.Windows.Forms.Button();
            this.hareket = new System.Windows.Forms.Panel();
            this.panel = new System.Windows.Forms.Panel();
            this.cikis = new System.Windows.Forms.PictureBox();
            this.kucult = new System.Windows.Forms.PictureBox();
            this.spor = new System.Windows.Forms.PictureBox();
            this.oyun = new System.Windows.Forms.PictureBox();
            this.saglik = new System.Windows.Forms.PictureBox();
            this.profilfoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cikis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kucult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oyun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saglik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilfoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(198, 209);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "MERHABA";
            // 
            // yas
            // 
            this.yas.Enabled = false;
            this.yas.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.yas.Location = new System.Drawing.Point(118, 273);
            this.yas.Margin = new System.Windows.Forms.Padding(4);
            this.yas.Name = "yas";
            this.yas.Size = new System.Drawing.Size(236, 27);
            this.yas.TabIndex = 21;
            // 
            // adsoyad
            // 
            this.adsoyad.Enabled = false;
            this.adsoyad.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.adsoyad.Location = new System.Drawing.Point(118, 233);
            this.adsoyad.Margin = new System.Windows.Forms.Padding(4);
            this.adsoyad.Name = "adsoyad";
            this.adsoyad.Size = new System.Drawing.Size(236, 27);
            this.adsoyad.TabIndex = 20;
            // 
            // izinsorgu
            // 
            this.izinsorgu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.izinsorgu.Location = new System.Drawing.Point(144, 308);
            this.izinsorgu.Margin = new System.Windows.Forms.Padding(4);
            this.izinsorgu.Name = "izinsorgu";
            this.izinsorgu.Size = new System.Drawing.Size(183, 52);
            this.izinsorgu.TabIndex = 19;
            this.izinsorgu.Text = "Dışarı Çıkabiliyor Muyum ?";
            this.izinsorgu.UseVisualStyleBackColor = true;
            this.izinsorgu.Click += new System.EventHandler(this.izinsorgu_Click);
            // 
            // hareket
            // 
            this.hareket.BackColor = System.Drawing.Color.Red;
            this.hareket.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hareket.Location = new System.Drawing.Point(-2, -1);
            this.hareket.Margin = new System.Windows.Forms.Padding(4);
            this.hareket.Name = "hareket";
            this.hareket.Size = new System.Drawing.Size(507, 22);
            this.hareket.TabIndex = 61;
            this.hareket.MouseDown += new System.Windows.Forms.MouseEventHandler(this.hareket_MouseDown);
            this.hareket.MouseMove += new System.Windows.Forms.MouseEventHandler(this.hareket_MouseMove);
            this.hareket.MouseUp += new System.Windows.Forms.MouseEventHandler(this.hareket_MouseUp);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Red;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel.Location = new System.Drawing.Point(-2, 480);
            this.panel.Margin = new System.Windows.Forms.Padding(4);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(507, 22);
            this.panel.TabIndex = 62;
            // 
            // cikis
            // 
            this.cikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cikis.Image = global::evdekall.Properties.Resources.newBack;
            this.cikis.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cikis.Location = new System.Drawing.Point(458, 27);
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
            this.kucult.Image = global::evdekall.Properties.Resources.newKucult;
            this.kucult.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.kucult.Location = new System.Drawing.Point(422, 27);
            this.kucult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kucult.Name = "kucult";
            this.kucult.Size = new System.Drawing.Size(30, 33);
            this.kucult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kucult.TabIndex = 55;
            this.kucult.TabStop = false;
            this.kucult.Click += new System.EventHandler(this.kucult_Click);
            // 
            // spor
            // 
            this.spor.BackColor = System.Drawing.Color.Transparent;
            this.spor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.spor.Image = global::evdekall.Properties.Resources.spor;
            this.spor.Location = new System.Drawing.Point(190, 382);
            this.spor.Margin = new System.Windows.Forms.Padding(4);
            this.spor.Name = "spor";
            this.spor.Size = new System.Drawing.Size(99, 78);
            this.spor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.spor.TabIndex = 26;
            this.spor.TabStop = false;
            this.spor.Click += new System.EventHandler(this.spor_Click);
            // 
            // oyun
            // 
            this.oyun.BackColor = System.Drawing.Color.Transparent;
            this.oyun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.oyun.Image = global::evdekall.Properties.Resources.game;
            this.oyun.Location = new System.Drawing.Point(304, 382);
            this.oyun.Margin = new System.Windows.Forms.Padding(4);
            this.oyun.Name = "oyun";
            this.oyun.Size = new System.Drawing.Size(91, 78);
            this.oyun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.oyun.TabIndex = 25;
            this.oyun.TabStop = false;
            this.oyun.Click += new System.EventHandler(this.oyun_Click);
            // 
            // saglik
            // 
            this.saglik.BackColor = System.Drawing.Color.Transparent;
            this.saglik.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saglik.Image = global::evdekall.Properties.Resources.saglik;
            this.saglik.Location = new System.Drawing.Point(75, 382);
            this.saglik.Margin = new System.Windows.Forms.Padding(4);
            this.saglik.Name = "saglik";
            this.saglik.Size = new System.Drawing.Size(107, 78);
            this.saglik.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.saglik.TabIndex = 24;
            this.saglik.TabStop = false;
            this.saglik.Click += new System.EventHandler(this.saglik_Click);
            // 
            // profilfoto
            // 
            this.profilfoto.Image = global::evdekall.Properties.Resources.newProfil;
            this.profilfoto.Location = new System.Drawing.Point(144, 36);
            this.profilfoto.Margin = new System.Windows.Forms.Padding(4);
            this.profilfoto.Name = "profilfoto";
            this.profilfoto.Size = new System.Drawing.Size(179, 159);
            this.profilfoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profilfoto.TabIndex = 18;
            this.profilfoto.TabStop = false;
            // 
            // profil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.hareket);
            this.Controls.Add(this.cikis);
            this.Controls.Add(this.kucult);
            this.Controls.Add(this.spor);
            this.Controls.Add(this.oyun);
            this.Controls.Add(this.saglik);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yas);
            this.Controls.Add(this.adsoyad);
            this.Controls.Add(this.izinsorgu);
            this.Controls.Add(this.profilfoto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "profil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "profil";
            this.Load += new System.EventHandler(this.profil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cikis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kucult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oyun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saglik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilfoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox spor;
        private System.Windows.Forms.PictureBox oyun;
        private System.Windows.Forms.PictureBox saglik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox yas;
        private System.Windows.Forms.TextBox adsoyad;
        private System.Windows.Forms.Button izinsorgu;
        private System.Windows.Forms.PictureBox profilfoto;
        private System.Windows.Forms.PictureBox cikis;
        private System.Windows.Forms.PictureBox kucult;
        private System.Windows.Forms.Panel hareket;
        private System.Windows.Forms.Panel panel;
    }
}