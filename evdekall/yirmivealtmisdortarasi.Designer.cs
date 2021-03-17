
namespace evdekall
{
    partial class yirmivealtmisdortarasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(yirmivealtmisdortarasi));
            this.cikis = new System.Windows.Forms.PictureBox();
            this.kucult = new System.Windows.Forms.PictureBox();
            this.hareket = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.yasak = new System.Windows.Forms.PictureBox();
            this.serbest = new System.Windows.Forms.PictureBox();
            this.sonuc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cikis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kucult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yasak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serbest)).BeginInit();
            this.SuspendLayout();
            // 
            // cikis
            // 
            this.cikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cikis.Image = global::evdekall.Properties.Resources.previous;
            this.cikis.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cikis.Location = new System.Drawing.Point(579, 33);
            this.cikis.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(48, 42);
            this.cikis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cikis.TabIndex = 64;
            this.cikis.TabStop = false;
            this.cikis.Click += new System.EventHandler(this.cikis_Click);
            // 
            // kucult
            // 
            this.kucult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kucult.Image = global::evdekall.Properties.Resources.minimize;
            this.kucult.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.kucult.Location = new System.Drawing.Point(531, 34);
            this.kucult.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.kucult.Name = "kucult";
            this.kucult.Size = new System.Drawing.Size(40, 41);
            this.kucult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kucult.TabIndex = 63;
            this.kucult.TabStop = false;
            this.kucult.Click += new System.EventHandler(this.kucult_Click);
            // 
            // hareket
            // 
            this.hareket.BackColor = System.Drawing.Color.Red;
            this.hareket.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hareket.Location = new System.Drawing.Point(-3, -1);
            this.hareket.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.hareket.Name = "hareket";
            this.hareket.Size = new System.Drawing.Size(655, 26);
            this.hareket.TabIndex = 62;
            this.hareket.MouseDown += new System.Windows.Forms.MouseEventHandler(this.hareket_MouseDown);
            this.hareket.MouseMove += new System.Windows.Forms.MouseEventHandler(this.hareket_MouseMove);
            this.hareket.MouseUp += new System.Windows.Forms.MouseEventHandler(this.hareket_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 12.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(16, 379);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(573, 52);
            this.label2.TabIndex = 61;
            this.label2.Text = "NOT : Hafta sonu 12.00 - 17.00 Arası Zorunlu İhtiyaç Durumunda \r\nEvinizin Yakının" +
    "daki Eczane,Market vs. Yerlere Gidebilirsiniz. ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // yasak
            // 
            this.yasak.Image = global::evdekall.Properties.Resources.yasak;
            this.yasak.Location = new System.Drawing.Point(245, 144);
            this.yasak.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.yasak.Name = "yasak";
            this.yasak.Size = new System.Drawing.Size(187, 134);
            this.yasak.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.yasak.TabIndex = 60;
            this.yasak.TabStop = false;
            // 
            // serbest
            // 
            this.serbest.Image = global::evdekall.Properties.Resources.serbest;
            this.serbest.Location = new System.Drawing.Point(245, 144);
            this.serbest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.serbest.Name = "serbest";
            this.serbest.Size = new System.Drawing.Size(187, 134);
            this.serbest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.serbest.TabIndex = 59;
            this.serbest.TabStop = false;
            // 
            // sonuc
            // 
            this.sonuc.AutoSize = true;
            this.sonuc.Font = new System.Drawing.Font("Trebuchet MS", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sonuc.Location = new System.Drawing.Point(13, 34);
            this.sonuc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sonuc.Name = "sonuc";
            this.sonuc.Size = new System.Drawing.Size(217, 42);
            this.sonuc.TabIndex = 58;
            this.sonuc.Text = "Yükleniyor...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(15, 346);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(579, 35);
            this.label1.TabIndex = 57;
            this.label1.Text = "İzin Saatlerin : Hafta içi 05.00 - 21.00 Arasındadır.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // yirmibirvealtmisdortarasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 442);
            this.Controls.Add(this.cikis);
            this.Controls.Add(this.kucult);
            this.Controls.Add(this.hareket);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.yasak);
            this.Controls.Add(this.serbest);
            this.Controls.Add(this.sonuc);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "yirmibirvealtmisdortarasi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "21 ve 64 Yaş Arası";
            this.Load += new System.EventHandler(this.yirmibirvealtmisdortarasi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cikis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kucult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yasak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serbest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox cikis;
        private System.Windows.Forms.PictureBox kucult;
        private System.Windows.Forms.Panel hareket;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox yasak;
        private System.Windows.Forms.PictureBox serbest;
        private System.Windows.Forms.Label sonuc;
        private System.Windows.Forms.Label label1;
    }
}