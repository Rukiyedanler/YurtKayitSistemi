namespace YurtKayitSistemi
{
    partial class FrmYoneticiDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmYoneticiDuzenle));
            this.txtYoneticiid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.yoneticiAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yoneticiSifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtOtomasyonuDataSet8 = new YurtKayitSistemi.YurtOtomasyonuDataSet8();
            this.adminTableAdapter = new YurtKayitSistemi.YurtOtomasyonuDataSet8TableAdapters.AdminTableAdapter();
            this.btnDonme = new System.Windows.Forms.Button();
            this.yurtOtomasyonuDataSet34 = new YurtKayitSistemi.YurtOtomasyonuDataSet34();
            this.adminBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.adminTableAdapter1 = new YurtKayitSistemi.YurtOtomasyonuDataSet34TableAdapters.AdminTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtYoneticiid
            // 
            this.txtYoneticiid.BackColor = System.Drawing.Color.DarkSalmon;
            this.txtYoneticiid.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYoneticiid.ForeColor = System.Drawing.Color.Black;
            this.txtYoneticiid.Location = new System.Drawing.Point(228, 12);
            this.txtYoneticiid.Name = "txtYoneticiid";
            this.txtYoneticiid.Size = new System.Drawing.Size(208, 26);
            this.txtYoneticiid.TabIndex = 33;
            this.txtYoneticiid.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DarkSalmon;
            this.label8.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(77, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 28);
            this.label8.TabIndex = 32;
            this.label8.Text = "Yonetici id:";
            this.label8.Visible = false;
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.BackColor = System.Drawing.Color.DarkSalmon;
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciAdi.ForeColor = System.Drawing.Color.Black;
            this.txtKullaniciAdi.Location = new System.Drawing.Point(228, 72);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(208, 26);
            this.txtKullaniciAdi.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSalmon;
            this.label1.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(62, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 28);
            this.label1.TabIndex = 34;
            this.label1.Text = "Kullaıcı Adı :";
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.Color.DarkSalmon;
            this.txtSifre.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.ForeColor = System.Drawing.Color.Black;
            this.txtSifre.Location = new System.Drawing.Point(228, 132);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(208, 26);
            this.txtSifre.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkSalmon;
            this.label2.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(129, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 28);
            this.label2.TabIndex = 36;
            this.label2.Text = "Şifre :";
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnKaydet.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaydet.ForeColor = System.Drawing.Color.Black;
            this.btnKaydet.Location = new System.Drawing.Point(516, 22);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(122, 44);
            this.btnKaydet.TabIndex = 38;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnSil.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSil.ForeColor = System.Drawing.Color.Black;
            this.btnSil.Location = new System.Drawing.Point(516, 72);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(122, 41);
            this.btnSil.TabIndex = 39;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnGuncelle.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuncelle.ForeColor = System.Drawing.Color.Black;
            this.btnGuncelle.Location = new System.Drawing.Point(516, 119);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(122, 42);
            this.btnGuncelle.TabIndex = 40;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkSalmon;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.yoneticiAdDataGridViewTextBoxColumn,
            this.yoneticiSifreDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.adminBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 254);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(732, 195);
            this.dataGridView1.TabIndex = 41;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // yoneticiAdDataGridViewTextBoxColumn
            // 
            this.yoneticiAdDataGridViewTextBoxColumn.DataPropertyName = "YoneticiAd";
            this.yoneticiAdDataGridViewTextBoxColumn.HeaderText = "YoneticiAd";
            this.yoneticiAdDataGridViewTextBoxColumn.Name = "yoneticiAdDataGridViewTextBoxColumn";
            // 
            // yoneticiSifreDataGridViewTextBoxColumn
            // 
            this.yoneticiSifreDataGridViewTextBoxColumn.DataPropertyName = "YoneticiSifre";
            this.yoneticiSifreDataGridViewTextBoxColumn.HeaderText = "YoneticiSifre";
            this.yoneticiSifreDataGridViewTextBoxColumn.Name = "yoneticiSifreDataGridViewTextBoxColumn";
            // 
            // adminBindingSource
            // 
            this.adminBindingSource.DataMember = "Admin";
            this.adminBindingSource.DataSource = this.yurtOtomasyonuDataSet8;
            // 
            // yurtOtomasyonuDataSet8
            // 
            this.yurtOtomasyonuDataSet8.DataSetName = "YurtOtomasyonuDataSet8";
            this.yurtOtomasyonuDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adminTableAdapter
            // 
            this.adminTableAdapter.ClearBeforeFill = true;
            // 
            // btnDonme
            // 
            this.btnDonme.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnDonme.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonme.ForeColor = System.Drawing.Color.Black;
            this.btnDonme.Location = new System.Drawing.Point(516, 168);
            this.btnDonme.Margin = new System.Windows.Forms.Padding(4);
            this.btnDonme.Name = "btnDonme";
            this.btnDonme.Size = new System.Drawing.Size(122, 39);
            this.btnDonme.TabIndex = 42;
            this.btnDonme.Text = "Ana Menüye Dön";
            this.btnDonme.UseVisualStyleBackColor = false;
            this.btnDonme.Click += new System.EventHandler(this.btnDonme_Click);
            // 
            // yurtOtomasyonuDataSet34
            // 
            this.yurtOtomasyonuDataSet34.DataSetName = "YurtOtomasyonuDataSet34";
            this.yurtOtomasyonuDataSet34.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adminBindingSource1
            // 
            this.adminBindingSource1.DataMember = "Admin";
            this.adminBindingSource1.DataSource = this.yurtOtomasyonuDataSet34;
            // 
            // adminTableAdapter1
            // 
            this.adminTableAdapter1.ClearBeforeFill = true;
            // 
            // FrmYoneticiDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(733, 450);
            this.Controls.Add(this.btnDonme);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtYoneticiid);
            this.Controls.Add(this.label8);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmYoneticiDuzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yonetici İşlemleri";
            this.Load += new System.EventHandler(this.FrmYoneticiDuzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtYoneticiid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private YurtOtomasyonuDataSet8 yurtOtomasyonuDataSet8;
        private System.Windows.Forms.BindingSource adminBindingSource;
        private YurtOtomasyonuDataSet8TableAdapters.AdminTableAdapter adminTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn yoneticiAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yoneticiSifreDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnDonme;
        private YurtOtomasyonuDataSet34 yurtOtomasyonuDataSet34;
        private System.Windows.Forms.BindingSource adminBindingSource1;
        private YurtOtomasyonuDataSet34TableAdapters.AdminTableAdapter adminTableAdapter1;
    }
}