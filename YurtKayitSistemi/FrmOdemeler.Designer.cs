namespace YurtKayitSistemi
{
    partial class FrmOdemeler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOdemeler));
            this.label1 = new System.Windows.Forms.Label();
            this.txtOgrTC = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOdenen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKalanBorc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOdenenAy = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOdemeAL = new System.Windows.Forms.Button();
            this.btnDonme = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ogrAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrKalanBorcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrTCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borclarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtOtomasyonuDataSet27 = new YurtKayitSistemi.YurtOtomasyonuDataSet27();
            this.borclarTableAdapter = new YurtKayitSistemi.YurtOtomasyonuDataSet27TableAdapters.BorclarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borclarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet27)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSalmon;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(612, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci TC";
            // 
            // txtOgrTC
            // 
            this.txtOgrTC.BackColor = System.Drawing.Color.DarkSalmon;
            this.txtOgrTC.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOgrTC.ForeColor = System.Drawing.Color.Black;
            this.txtOgrTC.Location = new System.Drawing.Point(589, 87);
            this.txtOgrTC.Name = "txtOgrTC";
            this.txtOgrTC.Size = new System.Drawing.Size(131, 27);
            this.txtOgrTC.TabIndex = 1;
            // 
            // txtAd
            // 
            this.txtAd.BackColor = System.Drawing.Color.DarkSalmon;
            this.txtAd.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAd.ForeColor = System.Drawing.Color.Black;
            this.txtAd.Location = new System.Drawing.Point(439, 87);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(131, 27);
            this.txtAd.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkSalmon;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(469, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ad Soyad";
            // 
            // txtOdenen
            // 
            this.txtOdenen.BackColor = System.Drawing.Color.DarkSalmon;
            this.txtOdenen.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOdenen.ForeColor = System.Drawing.Color.Black;
            this.txtOdenen.Location = new System.Drawing.Point(747, 87);
            this.txtOdenen.Name = "txtOdenen";
            this.txtOdenen.Size = new System.Drawing.Size(131, 27);
            this.txtOdenen.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkSalmon;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(781, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ödenen";
            // 
            // txtKalanBorc
            // 
            this.txtKalanBorc.BackColor = System.Drawing.Color.DarkSalmon;
            this.txtKalanBorc.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKalanBorc.ForeColor = System.Drawing.Color.Black;
            this.txtKalanBorc.Location = new System.Drawing.Point(900, 87);
            this.txtKalanBorc.Name = "txtKalanBorc";
            this.txtKalanBorc.Size = new System.Drawing.Size(131, 27);
            this.txtKalanBorc.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkSalmon;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(922, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kalan Borç";
            // 
            // txtOdenenAy
            // 
            this.txtOdenenAy.BackColor = System.Drawing.Color.DarkSalmon;
            this.txtOdenenAy.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOdenenAy.ForeColor = System.Drawing.Color.Black;
            this.txtOdenenAy.Location = new System.Drawing.Point(1051, 87);
            this.txtOdenenAy.Name = "txtOdenenAy";
            this.txtOdenenAy.Size = new System.Drawing.Size(131, 27);
            this.txtOdenenAy.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkSalmon;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(1073, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ödenen Ay";
            // 
            // btnOdemeAL
            // 
            this.btnOdemeAL.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnOdemeAL.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdemeAL.Location = new System.Drawing.Point(857, 170);
            this.btnOdemeAL.Name = "btnOdemeAL";
            this.btnOdemeAL.Size = new System.Drawing.Size(129, 45);
            this.btnOdemeAL.TabIndex = 10;
            this.btnOdemeAL.Text = "Ödeme Al";
            this.btnOdemeAL.UseVisualStyleBackColor = false;
            this.btnOdemeAL.Click += new System.EventHandler(this.btnOdemeAL_Click);
            // 
            // btnDonme
            // 
            this.btnDonme.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnDonme.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDonme.Location = new System.Drawing.Point(670, 170);
            this.btnDonme.Name = "btnDonme";
            this.btnDonme.Size = new System.Drawing.Size(134, 45);
            this.btnDonme.TabIndex = 11;
            this.btnDonme.Text = "Ana Ekrana Dön";
            this.btnDonme.UseVisualStyleBackColor = false;
            this.btnDonme.Click += new System.EventHandler(this.btnDonme_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkSalmon;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogrAdDataGridViewTextBoxColumn,
            this.ogrSoyadDataGridViewTextBoxColumn,
            this.ogrKalanBorcDataGridViewTextBoxColumn,
            this.ogrTCDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.borclarBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-3, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(436, 260);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // ogrAdDataGridViewTextBoxColumn
            // 
            this.ogrAdDataGridViewTextBoxColumn.DataPropertyName = "OgrAd";
            this.ogrAdDataGridViewTextBoxColumn.HeaderText = "OgrAd";
            this.ogrAdDataGridViewTextBoxColumn.Name = "ogrAdDataGridViewTextBoxColumn";
            // 
            // ogrSoyadDataGridViewTextBoxColumn
            // 
            this.ogrSoyadDataGridViewTextBoxColumn.DataPropertyName = "OgrSoyad";
            this.ogrSoyadDataGridViewTextBoxColumn.HeaderText = "OgrSoyad";
            this.ogrSoyadDataGridViewTextBoxColumn.Name = "ogrSoyadDataGridViewTextBoxColumn";
            // 
            // ogrKalanBorcDataGridViewTextBoxColumn
            // 
            this.ogrKalanBorcDataGridViewTextBoxColumn.DataPropertyName = "OgrKalanBorc";
            this.ogrKalanBorcDataGridViewTextBoxColumn.HeaderText = "OgrKalanBorc";
            this.ogrKalanBorcDataGridViewTextBoxColumn.Name = "ogrKalanBorcDataGridViewTextBoxColumn";
            // 
            // ogrTCDataGridViewTextBoxColumn
            // 
            this.ogrTCDataGridViewTextBoxColumn.DataPropertyName = "OgrTC";
            this.ogrTCDataGridViewTextBoxColumn.HeaderText = "OgrTC";
            this.ogrTCDataGridViewTextBoxColumn.Name = "ogrTCDataGridViewTextBoxColumn";
            // 
            // borclarBindingSource
            // 
            this.borclarBindingSource.DataMember = "Borclar";
            this.borclarBindingSource.DataSource = this.yurtOtomasyonuDataSet27;
            // 
            // yurtOtomasyonuDataSet27
            // 
            this.yurtOtomasyonuDataSet27.DataSetName = "YurtOtomasyonuDataSet27";
            this.yurtOtomasyonuDataSet27.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // borclarTableAdapter
            // 
            this.borclarTableAdapter.ClearBeforeFill = true;
            // 
            // FrmOdemeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1236, 262);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDonme);
            this.Controls.Add(this.btnOdemeAL);
            this.Controls.Add(this.txtOdenenAy);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtKalanBorc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOdenen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOgrTC);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmOdemeler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Odemeler";
            this.Load += new System.EventHandler(this.FrmOdemeler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borclarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet27)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOgrTC;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOdenen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKalanBorc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOdenenAy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOdemeAL;
        private System.Windows.Forms.Button btnDonme;
        private System.Windows.Forms.DataGridView dataGridView1;
        private YurtOtomasyonuDataSet27 yurtOtomasyonuDataSet27;
        private System.Windows.Forms.BindingSource borclarBindingSource;
        private YurtOtomasyonuDataSet27TableAdapters.BorclarTableAdapter borclarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrKalanBorcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrTCDataGridViewTextBoxColumn;
    }
}