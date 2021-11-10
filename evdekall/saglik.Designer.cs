
namespace evdekall
{
    partial class saglik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(saglik));
            this.label1 = new System.Windows.Forms.Label();
            this.hareket = new System.Windows.Forms.Panel();
            this.vkihesap = new System.Windows.Forms.Button();
            this.cikis = new System.Windows.Forms.PictureBox();
            this.kucult = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.koronaTest = new System.Windows.Forms.Button();
            this.saglikliBeslenme = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cikis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kucult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myriad Pro Cond", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(411, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "SAĞLIK";
            // 
            // hareket
            // 
            this.hareket.BackColor = System.Drawing.Color.Red;
            this.hareket.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hareket.Location = new System.Drawing.Point(-2, -1);
            this.hareket.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hareket.Name = "hareket";
            this.hareket.Size = new System.Drawing.Size(807, 22);
            this.hareket.TabIndex = 60;
            this.hareket.MouseDown += new System.Windows.Forms.MouseEventHandler(this.hareket_MouseDown);
            this.hareket.MouseMove += new System.Windows.Forms.MouseEventHandler(this.hareket_MouseMove);
            this.hareket.MouseUp += new System.Windows.Forms.MouseEventHandler(this.hareket_MouseUp);
            // 
            // vkihesap
            // 
            this.vkihesap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vkihesap.Location = new System.Drawing.Point(28, 159);
            this.vkihesap.Name = "vkihesap";
            this.vkihesap.Size = new System.Drawing.Size(194, 47);
            this.vkihesap.TabIndex = 61;
            this.vkihesap.Text = "Vucüt Kitle İndeksi Hesapla";
            this.vkihesap.UseVisualStyleBackColor = true;
            this.vkihesap.Click += new System.EventHandler(this.vkihesap_Click);
            // 
            // cikis
            // 
            this.cikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cikis.Image = global::evdekall.Properties.Resources.previous;
            this.cikis.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cikis.Location = new System.Drawing.Point(758, 27);
            this.cikis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(30, 33);
            this.cikis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cikis.TabIndex = 59;
            this.cikis.TabStop = false;
            this.cikis.Click += new System.EventHandler(this.cikis_Click);
            // 
            // kucult
            // 
            this.kucult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kucult.Image = global::evdekall.Properties.Resources.minimize;
            this.kucult.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.kucult.Location = new System.Drawing.Point(722, 27);
            this.kucult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kucult.Name = "kucult";
            this.kucult.Size = new System.Drawing.Size(30, 33);
            this.kucult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kucult.TabIndex = 58;
            this.kucult.TabStop = false;
            this.kucult.Click += new System.EventHandler(this.kucult_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::evdekall.Properties.Resources.heartbeat;
            this.pictureBox3.Location = new System.Drawing.Point(296, 29);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(107, 78);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // koronaTest
            // 
            this.koronaTest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.koronaTest.Location = new System.Drawing.Point(28, 224);
            this.koronaTest.Name = "koronaTest";
            this.koronaTest.Size = new System.Drawing.Size(194, 47);
            this.koronaTest.TabIndex = 62;
            this.koronaTest.Text = "Korona Virüs Testi";
            this.koronaTest.UseVisualStyleBackColor = true;
            // 
            // saglikliBeslenme
            // 
            this.saglikliBeslenme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saglikliBeslenme.Location = new System.Drawing.Point(28, 287);
            this.saglikliBeslenme.Name = "saglikliBeslenme";
            this.saglikliBeslenme.Size = new System.Drawing.Size(194, 47);
            this.saglikliBeslenme.TabIndex = 63;
            this.saglikliBeslenme.Text = "Sağlıklı Beslenme";
            this.saglikliBeslenme.UseVisualStyleBackColor = true;
            // 
            // saglik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saglikliBeslenme);
            this.Controls.Add(this.koronaTest);
            this.Controls.Add(this.vkihesap);
            this.Controls.Add(this.hareket);
            this.Controls.Add(this.cikis);
            this.Controls.Add(this.kucult);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "saglik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sağlık";
            ((System.ComponentModel.ISupportInitialize)(this.cikis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kucult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox cikis;
        private System.Windows.Forms.PictureBox kucult;
        private System.Windows.Forms.Panel hareket;
        private System.Windows.Forms.Button vkihesap;
        private System.Windows.Forms.Button koronaTest;
        private System.Windows.Forms.Button saglikliBeslenme;
    }
}