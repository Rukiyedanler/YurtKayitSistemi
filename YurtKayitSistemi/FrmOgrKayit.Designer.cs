namespace YurtKayitSistemi
{
    partial class FrmOgrKayit
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOgrKayit));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbBolum = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbOdaNo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.rchAdres = new System.Windows.Forms.RichTextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtEdtOgrAd = new DevExpress.XtraEditors.TextEdit();
            this.txtEdtOgrSoyad = new DevExpress.XtraEditors.TextEdit();
            this.txtEdtTC = new DevExpress.XtraEditors.TextEdit();
            this.txtEdtOgrTelefon = new DevExpress.XtraEditors.TextEdit();
            this.txtEdtDogum = new DevExpress.XtraEditors.TextEdit();
            this.txtEdtVeliTelefon = new DevExpress.XtraEditors.TextEdit();
            this.txtEdtVeliAdSoyad = new DevExpress.XtraEditors.TextEdit();
            this.txtEdtMail = new DevExpress.XtraEditors.TextEdit();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtOgrAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtOgrSoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtTC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtOgrTelefon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtDogum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtVeliTelefon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtVeliAdSoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtMail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(163, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(140, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Öğrenci Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(220, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "TC:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(186, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefon:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(146, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "DoğumTarihi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(146, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Öğrenci Bölüm:";
            // 
            // cmbBolum
            // 
            this.cmbBolum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBolum.FormattingEnabled = true;
            this.cmbBolum.Location = new System.Drawing.Point(303, 269);
            this.cmbBolum.Name = "cmbBolum";
            this.cmbBolum.Size = new System.Drawing.Size(271, 28);
            this.cmbBolum.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(218, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 22);
            this.label7.TabIndex = 12;
            this.label7.Text = "Mail:";
            // 
            // cmbOdaNo
            // 
            this.cmbOdaNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbOdaNo.FormattingEnabled = true;
            this.cmbOdaNo.Location = new System.Drawing.Point(303, 356);
            this.cmbOdaNo.Name = "cmbOdaNo";
            this.cmbOdaNo.Size = new System.Drawing.Size(271, 28);
            this.cmbOdaNo.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(190, 360);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 22);
            this.label8.TabIndex = 14;
            this.label8.Text = "Oda No:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(155, 406);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 22);
            this.label9.TabIndex = 16;
            this.label9.Text = "Veli Ad Soyad:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(166, 453);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 22);
            this.label10.TabIndex = 18;
            this.label10.Text = "Veli Telefon:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(173, 518);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 22);
            this.label11.TabIndex = 20;
            this.label11.Text = "Adres:";
            // 
            // rchAdres
            // 
            this.rchAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rchAdres.Location = new System.Drawing.Point(303, 503);
            this.rchAdres.Name = "rchAdres";
            this.rchAdres.Size = new System.Drawing.Size(271, 116);
            this.rchAdres.TabIndex = 21;
            this.rchAdres.Text = "";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Cambria", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(723, 269);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(144, 78);
            this.btnKaydet.TabIndex = 22;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtEdtOgrAd
            // 
            this.txtEdtOgrAd.EditValue = "";
            this.txtEdtOgrAd.Location = new System.Drawing.Point(303, 34);
            this.txtEdtOgrAd.Name = "txtEdtOgrAd";
            this.txtEdtOgrAd.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEdtOgrAd.Properties.Appearance.Options.UseFont = true;
            this.txtEdtOgrAd.Size = new System.Drawing.Size(271, 28);
            this.txtEdtOgrAd.TabIndex = 23;
            // 
            // txtEdtOgrSoyad
            // 
            this.txtEdtOgrSoyad.EditValue = "";
            this.txtEdtOgrSoyad.Location = new System.Drawing.Point(303, 81);
            this.txtEdtOgrSoyad.Name = "txtEdtOgrSoyad";
            this.txtEdtOgrSoyad.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEdtOgrSoyad.Properties.Appearance.Options.UseFont = true;
            this.txtEdtOgrSoyad.Size = new System.Drawing.Size(271, 28);
            this.txtEdtOgrSoyad.TabIndex = 24;
            // 
            // txtEdtTC
            // 
            this.txtEdtTC.EditValue = "";
            this.txtEdtTC.Location = new System.Drawing.Point(303, 132);
            this.txtEdtTC.Name = "txtEdtTC";
            this.txtEdtTC.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEdtTC.Properties.Appearance.Options.UseFont = true;
            this.txtEdtTC.Properties.Mask.EditMask = "f0";
            this.txtEdtTC.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtEdtTC.Size = new System.Drawing.Size(271, 28);
            this.txtEdtTC.TabIndex = 25;
            // 
            // txtEdtOgrTelefon
            // 
            this.txtEdtOgrTelefon.EditValue = "";
            this.txtEdtOgrTelefon.Location = new System.Drawing.Point(303, 180);
            this.txtEdtOgrTelefon.Name = "txtEdtOgrTelefon";
            this.txtEdtOgrTelefon.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEdtOgrTelefon.Properties.Appearance.Options.UseFont = true;
            this.txtEdtOgrTelefon.Properties.Mask.EditMask = "(999) 000-0000";
            this.txtEdtOgrTelefon.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.txtEdtOgrTelefon.Size = new System.Drawing.Size(271, 28);
            this.txtEdtOgrTelefon.TabIndex = 26;
            // 
            // txtEdtDogum
            // 
            this.txtEdtDogum.EditValue = "";
            this.txtEdtDogum.Location = new System.Drawing.Point(303, 226);
            this.txtEdtDogum.Name = "txtEdtDogum";
            this.txtEdtDogum.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEdtDogum.Properties.Appearance.Options.UseFont = true;
            this.txtEdtDogum.Properties.Mask.EditMask = "d";
            this.txtEdtDogum.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtEdtDogum.Size = new System.Drawing.Size(271, 28);
            this.txtEdtDogum.TabIndex = 27;
            // 
            // txtEdtVeliTelefon
            // 
            this.txtEdtVeliTelefon.EditValue = "";
            this.txtEdtVeliTelefon.Location = new System.Drawing.Point(303, 447);
            this.txtEdtVeliTelefon.Name = "txtEdtVeliTelefon";
            this.txtEdtVeliTelefon.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEdtVeliTelefon.Properties.Appearance.Options.UseFont = true;
            this.txtEdtVeliTelefon.Properties.Mask.EditMask = "(999) 000-0000";
            this.txtEdtVeliTelefon.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.txtEdtVeliTelefon.Size = new System.Drawing.Size(271, 28);
            this.txtEdtVeliTelefon.TabIndex = 28;
            // 
            // txtEdtVeliAdSoyad
            // 
            this.txtEdtVeliAdSoyad.EditValue = "";
            this.txtEdtVeliAdSoyad.Location = new System.Drawing.Point(303, 400);
            this.txtEdtVeliAdSoyad.Name = "txtEdtVeliAdSoyad";
            this.txtEdtVeliAdSoyad.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEdtVeliAdSoyad.Properties.Appearance.Options.UseFont = true;
            this.txtEdtVeliAdSoyad.Size = new System.Drawing.Size(271, 28);
            this.txtEdtVeliAdSoyad.TabIndex = 29;
            // 
            // txtEdtMail
            // 
            this.txtEdtMail.EditValue = "";
            this.txtEdtMail.Location = new System.Drawing.Point(303, 307);
            this.txtEdtMail.Name = "txtEdtMail";
            this.txtEdtMail.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEdtMail.Properties.Appearance.Options.UseFont = true;
            this.txtEdtMail.Size = new System.Drawing.Size(271, 28);
            this.txtEdtMail.TabIndex = 30;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(45, 539);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "label12";
            this.label12.Visible = false;
            // 
            // FrmOgrKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(960, 599);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtEdtMail);
            this.Controls.Add(this.txtEdtVeliAdSoyad);
            this.Controls.Add(this.txtEdtVeliTelefon);
            this.Controls.Add(this.txtEdtDogum);
            this.Controls.Add(this.txtEdtOgrTelefon);
            this.Controls.Add(this.txtEdtTC);
            this.Controls.Add(this.txtEdtOgrSoyad);
            this.Controls.Add(this.txtEdtOgrAd);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.rchAdres);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbOdaNo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbBolum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmOgrKayit";
            this.Text = "Öğrenci Kayıt";
            this.Load += new System.EventHandler(this.FrmOgrKayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtOgrAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtOgrSoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtTC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtOgrTelefon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtDogum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtVeliTelefon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtVeliAdSoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtMail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbBolum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbOdaNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox rchAdres;
        private System.Windows.Forms.Button btnKaydet;
        private DevExpress.XtraEditors.TextEdit txtEdtOgrAd;
        private DevExpress.XtraEditors.TextEdit txtEdtOgrSoyad;
        private DevExpress.XtraEditors.TextEdit txtEdtTC;
        private DevExpress.XtraEditors.TextEdit txtEdtOgrTelefon;
        private DevExpress.XtraEditors.TextEdit txtEdtDogum;
        private DevExpress.XtraEditors.TextEdit txtEdtVeliTelefon;
        private DevExpress.XtraEditors.TextEdit txtEdtVeliAdSoyad;
        private DevExpress.XtraEditors.TextEdit txtEdtMail;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private System.Windows.Forms.Label label12;
    }
}

