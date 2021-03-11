
namespace evdekall
{
    partial class butonuyakala
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(butonuyakala));
            this.yakala = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // yakala
            // 
            this.yakala.Cursor = System.Windows.Forms.Cursors.Cross;
            this.yakala.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yakala.Location = new System.Drawing.Point(360, 209);
            this.yakala.Margin = new System.Windows.Forms.Padding(4);
            this.yakala.Name = "yakala";
            this.yakala.Size = new System.Drawing.Size(73, 37);
            this.yakala.TabIndex = 17;
            this.yakala.Text = "TIKLA";
            this.yakala.UseVisualStyleBackColor = true;
            this.yakala.Click += new System.EventHandler(this.button1_Click);
            this.yakala.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // butonuyakala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.yakala);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "butonuyakala";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Butonu Yakala";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.butonuyakala_FormClosed);
            this.Load += new System.EventHandler(this.butonuyakala_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button yakala;
    }
}