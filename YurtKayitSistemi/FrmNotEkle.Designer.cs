namespace YurtKayitSistemi
{
    partial class FrmNotEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNotEkle));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnDonme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.DarkSalmon;
            this.richTextBox1.Location = new System.Drawing.Point(-3, 1);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(539, 321);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnKaydet.ForeColor = System.Drawing.Color.Black;
            this.btnKaydet.Location = new System.Drawing.Point(253, 363);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(117, 48);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnDonme
            // 
            this.btnDonme.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnDonme.ForeColor = System.Drawing.Color.Black;
            this.btnDonme.Location = new System.Drawing.Point(135, 363);
            this.btnDonme.Margin = new System.Windows.Forms.Padding(4);
            this.btnDonme.Name = "btnDonme";
            this.btnDonme.Size = new System.Drawing.Size(102, 48);
            this.btnDonme.TabIndex = 43;
            this.btnDonme.Text = "Ana Menüye Dön";
            this.btnDonme.UseVisualStyleBackColor = false;
            this.btnDonme.Click += new System.EventHandler(this.btnDonme_Click);
            // 
            // FrmNotEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(535, 450);
            this.Controls.Add(this.btnDonme);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.richTextBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmNotEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Not Ekle";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnDonme;
    }
}