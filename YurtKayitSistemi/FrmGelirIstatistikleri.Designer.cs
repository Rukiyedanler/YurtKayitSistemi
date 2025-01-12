namespace YurtKayitSistemi
{
    partial class FrmGelirIstatistikleri
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGelirIstatistikleri));
            this.label1 = new System.Windows.Forms.Label();
            this.lblKasa = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbAy = new System.Windows.Forms.ComboBox();
            this.lblAyKazanc = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnDonme = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSalmon;
            this.label1.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(468, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kasadaki Para: ";
            // 
            // lblKasa
            // 
            this.lblKasa.AutoSize = true;
            this.lblKasa.BackColor = System.Drawing.Color.DarkSalmon;
            this.lblKasa.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKasa.ForeColor = System.Drawing.Color.Black;
            this.lblKasa.Location = new System.Drawing.Point(663, 44);
            this.lblKasa.Name = "lblKasa";
            this.lblKasa.Size = new System.Drawing.Size(29, 32);
            this.lblKasa.TabIndex = 1;
            this.lblKasa.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkSalmon;
            this.label2.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(113, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ay seçin: ";
            // 
            // cmbAy
            // 
            this.cmbAy.BackColor = System.Drawing.Color.DarkSalmon;
            this.cmbAy.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbAy.FormattingEnabled = true;
            this.cmbAy.Location = new System.Drawing.Point(235, 63);
            this.cmbAy.Name = "cmbAy";
            this.cmbAy.Size = new System.Drawing.Size(165, 27);
            this.cmbAy.TabIndex = 3;
            this.cmbAy.SelectedIndexChanged += new System.EventHandler(this.cmbAy_SelectedIndexChanged);
            // 
            // lblAyKazanc
            // 
            this.lblAyKazanc.AutoSize = true;
            this.lblAyKazanc.BackColor = System.Drawing.Color.DarkSalmon;
            this.lblAyKazanc.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAyKazanc.ForeColor = System.Drawing.Color.Black;
            this.lblAyKazanc.Location = new System.Drawing.Point(663, 95);
            this.lblAyKazanc.Name = "lblAyKazanc";
            this.lblAyKazanc.Size = new System.Drawing.Size(29, 32);
            this.lblAyKazanc.TabIndex = 5;
            this.lblAyKazanc.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkSalmon;
            this.label4.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(519, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "Seçilen Ay: ";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Black;
            this.chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;
            this.chart1.BackImageTransparentColor = System.Drawing.Color.Black;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(-5, 256);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;
            series1.BackImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            series1.Legend = "Legend1";
            series1.Name = "Aylık";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(813, 239);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            // 
            // btnDonme
            // 
            this.btnDonme.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnDonme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDonme.Location = new System.Drawing.Point(-5, 0);
            this.btnDonme.Margin = new System.Windows.Forms.Padding(4);
            this.btnDonme.Name = "btnDonme";
            this.btnDonme.Size = new System.Drawing.Size(122, 43);
            this.btnDonme.TabIndex = 44;
            this.btnDonme.Text = "Ana Menüye Dön";
            this.btnDonme.UseVisualStyleBackColor = false;
            this.btnDonme.Click += new System.EventHandler(this.btnDonme_Click);
            // 
            // FrmGelirIstatistikleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(804, 493);
            this.Controls.Add(this.btnDonme);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.lblAyKazanc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbAy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblKasa);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGelirIstatistikleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gelir Istatistikleri";
            this.Load += new System.EventHandler(this.FrmGelirIstatistikleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblKasa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbAy;
        private System.Windows.Forms.Label lblAyKazanc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnDonme;
    }
}