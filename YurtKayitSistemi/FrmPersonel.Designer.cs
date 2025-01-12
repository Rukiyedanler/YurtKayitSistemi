namespace YurtKayitSistemi
{
    partial class FrmPersonel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonel));
            this.txtPersonelAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPersonelGorev = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.bGuncelle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.personelAdSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelDepartmanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.yurtOtomasyonuDataSet31 = new YurtKayitSistemi.YurtOtomasyonuDataSet31();
            this.personelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtOtomasyonuDataSet9 = new YurtKayitSistemi.YurtOtomasyonuDataSet9();
            this.personelTableAdapter = new YurtKayitSistemi.YurtOtomasyonuDataSet9TableAdapters.PersonelTableAdapter();
            this.btnDonme = new System.Windows.Forms.Button();
            this.personelTableAdapter1 = new YurtKayitSistemi.YurtOtomasyonuDataSet31TableAdapters.PersonelTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPersonelid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet9)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPersonelAd
            // 
            this.txtPersonelAd.BackColor = System.Drawing.Color.DarkSalmon;
            this.txtPersonelAd.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPersonelAd.ForeColor = System.Drawing.Color.Black;
            this.txtPersonelAd.Location = new System.Drawing.Point(227, 85);
            this.txtPersonelAd.Name = "txtPersonelAd";
            this.txtPersonelAd.Size = new System.Drawing.Size(208, 26);
            this.txtPersonelAd.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSalmon;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(59, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 32);
            this.label1.TabIndex = 36;
            this.label1.Text = "Personel Ad:";
            // 
            // txtPersonelGorev
            // 
            this.txtPersonelGorev.BackColor = System.Drawing.Color.DarkSalmon;
            this.txtPersonelGorev.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPersonelGorev.ForeColor = System.Drawing.Color.Black;
            this.txtPersonelGorev.Location = new System.Drawing.Point(227, 136);
            this.txtPersonelGorev.Name = "txtPersonelGorev";
            this.txtPersonelGorev.Size = new System.Drawing.Size(208, 26);
            this.txtPersonelGorev.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkSalmon;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(28, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 32);
            this.label2.TabIndex = 38;
            this.label2.Text = "Personel Görev:";
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnKaydet.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaydet.ForeColor = System.Drawing.Color.Black;
            this.btnKaydet.Location = new System.Drawing.Point(62, 233);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(119, 46);
            this.btnKaydet.TabIndex = 40;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnSil.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSil.ForeColor = System.Drawing.Color.Black;
            this.btnSil.Location = new System.Drawing.Point(292, 233);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(116, 46);
            this.btnSil.TabIndex = 41;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // bGuncelle
            // 
            this.bGuncelle.BackColor = System.Drawing.Color.DarkSalmon;
            this.bGuncelle.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bGuncelle.ForeColor = System.Drawing.Color.Black;
            this.bGuncelle.Location = new System.Drawing.Point(179, 301);
            this.bGuncelle.Name = "bGuncelle";
            this.bGuncelle.Size = new System.Drawing.Size(116, 41);
            this.bGuncelle.TabIndex = 42;
            this.bGuncelle.Text = "Güncelle";
            this.bGuncelle.UseVisualStyleBackColor = false;
            this.bGuncelle.Click += new System.EventHandler(this.bGuncelle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkSalmon;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personelAdSoyadDataGridViewTextBoxColumn,
            this.personelDepartmanDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.personelBindingSource1;
            this.dataGridView1.GridColor = System.Drawing.Color.Gray;
            this.dataGridView1.Location = new System.Drawing.Point(479, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 10;
            this.dataGridView1.Size = new System.Drawing.Size(391, 290);
            this.dataGridView1.TabIndex = 43;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // personelAdSoyadDataGridViewTextBoxColumn
            // 
            this.personelAdSoyadDataGridViewTextBoxColumn.DataPropertyName = "PersonelAdSoyad";
            this.personelAdSoyadDataGridViewTextBoxColumn.HeaderText = "PersonelAdSoyad";
            this.personelAdSoyadDataGridViewTextBoxColumn.Name = "personelAdSoyadDataGridViewTextBoxColumn";
            // 
            // personelDepartmanDataGridViewTextBoxColumn
            // 
            this.personelDepartmanDataGridViewTextBoxColumn.DataPropertyName = "PersonelDepartman";
            this.personelDepartmanDataGridViewTextBoxColumn.HeaderText = "PersonelDepartman";
            this.personelDepartmanDataGridViewTextBoxColumn.Name = "personelDepartmanDataGridViewTextBoxColumn";
            // 
            // personelBindingSource1
            // 
            this.personelBindingSource1.DataMember = "Personel";
            this.personelBindingSource1.DataSource = this.yurtOtomasyonuDataSet31;
            // 
            // yurtOtomasyonuDataSet31
            // 
            this.yurtOtomasyonuDataSet31.DataSetName = "YurtOtomasyonuDataSet31";
            this.yurtOtomasyonuDataSet31.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personelBindingSource
            // 
            this.personelBindingSource.DataMember = "Personel";
            this.personelBindingSource.DataSource = this.yurtOtomasyonuDataSet9;
            // 
            // yurtOtomasyonuDataSet9
            // 
            this.yurtOtomasyonuDataSet9.DataSetName = "YurtOtomasyonuDataSet9";
            this.yurtOtomasyonuDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personelTableAdapter
            // 
            this.personelTableAdapter.ClearBeforeFill = true;
            // 
            // btnDonme
            // 
            this.btnDonme.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnDonme.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonme.ForeColor = System.Drawing.Color.Black;
            this.btnDonme.Location = new System.Drawing.Point(570, 365);
            this.btnDonme.Margin = new System.Windows.Forms.Padding(4);
            this.btnDonme.Name = "btnDonme";
            this.btnDonme.Size = new System.Drawing.Size(174, 61);
            this.btnDonme.TabIndex = 44;
            this.btnDonme.Text = "Ana Menüye Dön";
            this.btnDonme.UseVisualStyleBackColor = false;
            this.btnDonme.Click += new System.EventHandler(this.btnDonme_Click);
            // 
            // personelTableAdapter1
            // 
            this.personelTableAdapter1.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DarkSalmon;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(51, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 32);
            this.label8.TabIndex = 34;
            this.label8.Text = "Personel id:";
            this.label8.Visible = false;
            // 
            // txtPersonelid
            // 
            this.txtPersonelid.BackColor = System.Drawing.Color.DarkSalmon;
            this.txtPersonelid.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPersonelid.ForeColor = System.Drawing.Color.Black;
            this.txtPersonelid.Location = new System.Drawing.Point(212, 12);
            this.txtPersonelid.Name = "txtPersonelid";
            this.txtPersonelid.Size = new System.Drawing.Size(208, 26);
            this.txtPersonelid.TabIndex = 35;
            this.txtPersonelid.Visible = false;
            // 
            // FrmPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(897, 450);
            this.Controls.Add(this.btnDonme);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtPersonelGorev);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPersonelAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPersonelid);
            this.Controls.Add(this.label8);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPersonel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel";
            this.Load += new System.EventHandler(this.FrmPersonel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPersonelAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPersonelGorev;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button bGuncelle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private YurtOtomasyonuDataSet9 yurtOtomasyonuDataSet9;
        private System.Windows.Forms.BindingSource personelBindingSource;
        private YurtOtomasyonuDataSet9TableAdapters.PersonelTableAdapter personelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelAdSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelDepartmanDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnDonme;
        private YurtOtomasyonuDataSet31 yurtOtomasyonuDataSet31;
        private System.Windows.Forms.BindingSource personelBindingSource1;
        private YurtOtomasyonuDataSet31TableAdapters.PersonelTableAdapter personelTableAdapter1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPersonelid;
    }
}