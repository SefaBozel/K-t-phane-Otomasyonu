namespace Kütüphane_Otomasyonu
{
    partial class KAldigiKitaplar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KAldigiKitaplar));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_KullaniciAdi = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Kitap = new System.Windows.Forms.TextBox();
            this.txt_KullaniciAdi = new System.Windows.Forms.TextBox();
            this.txt_KitapID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_KullaniciID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_GeriDon = new System.Windows.Forms.Button();
            this.btn_TeslimEt = new System.Windows.Forms.Button();
            this.dtp_teslim = new System.Windows.Forms.DateTimePicker();
            this.dtp_alim = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_yazar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(341, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(676, 548);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Elimdeki Kitapların Listesi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(670, 519);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_KullaniciAdi);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt_Kitap);
            this.groupBox2.Controls.Add(this.txt_KullaniciAdi);
            this.groupBox2.Controls.Add(this.txt_KitapID);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_KullaniciID);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btn_GeriDon);
            this.groupBox2.Controls.Add(this.btn_TeslimEt);
            this.groupBox2.Controls.Add(this.dtp_teslim);
            this.groupBox2.Controls.Add(this.dtp_alim);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_yazar);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(323, 548);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlemler";
            // 
            // lbl_KullaniciAdi
            // 
            this.lbl_KullaniciAdi.AutoSize = true;
            this.lbl_KullaniciAdi.Location = new System.Drawing.Point(247, 26);
            this.lbl_KullaniciAdi.Name = "lbl_KullaniciAdi";
            this.lbl_KullaniciAdi.Size = new System.Drawing.Size(64, 25);
            this.lbl_KullaniciAdi.TabIndex = 19;
            this.lbl_KullaniciAdi.Text = "label1";
            this.lbl_KullaniciAdi.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 25);
            this.label8.TabIndex = 18;
            this.label8.Text = "Kullanici Adi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "Kitap Adi:";
            // 
            // txt_Kitap
            // 
            this.txt_Kitap.Enabled = false;
            this.txt_Kitap.Location = new System.Drawing.Point(144, 183);
            this.txt_Kitap.Name = "txt_Kitap";
            this.txt_Kitap.Size = new System.Drawing.Size(167, 30);
            this.txt_Kitap.TabIndex = 16;
            // 
            // txt_KullaniciAdi
            // 
            this.txt_KullaniciAdi.Enabled = false;
            this.txt_KullaniciAdi.Location = new System.Drawing.Point(144, 111);
            this.txt_KullaniciAdi.Name = "txt_KullaniciAdi";
            this.txt_KullaniciAdi.Size = new System.Drawing.Size(167, 30);
            this.txt_KullaniciAdi.TabIndex = 15;
            // 
            // txt_KitapID
            // 
            this.txt_KitapID.Enabled = false;
            this.txt_KitapID.Location = new System.Drawing.Point(144, 147);
            this.txt_KitapID.Name = "txt_KitapID";
            this.txt_KitapID.Size = new System.Drawing.Size(167, 30);
            this.txt_KitapID.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Kitap ID:";
            // 
            // txt_KullaniciID
            // 
            this.txt_KullaniciID.Enabled = false;
            this.txt_KullaniciID.Location = new System.Drawing.Point(144, 75);
            this.txt_KullaniciID.Name = "txt_KullaniciID";
            this.txt_KullaniciID.Size = new System.Drawing.Size(167, 30);
            this.txt_KullaniciID.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Kullanici ID:";
            // 
            // btn_GeriDon
            // 
            this.btn_GeriDon.Location = new System.Drawing.Point(76, 433);
            this.btn_GeriDon.Name = "btn_GeriDon";
            this.btn_GeriDon.Size = new System.Drawing.Size(189, 73);
            this.btn_GeriDon.TabIndex = 10;
            this.btn_GeriDon.Text = "Önceden Aldığım Kitaplar";
            this.btn_GeriDon.UseVisualStyleBackColor = true;
            this.btn_GeriDon.Click += new System.EventHandler(this.btn_GeriDon_Click);
            // 
            // btn_TeslimEt
            // 
            this.btn_TeslimEt.Location = new System.Drawing.Point(76, 354);
            this.btn_TeslimEt.Name = "btn_TeslimEt";
            this.btn_TeslimEt.Size = new System.Drawing.Size(189, 73);
            this.btn_TeslimEt.TabIndex = 9;
            this.btn_TeslimEt.Text = "Kitabı Teslim Et";
            this.btn_TeslimEt.UseVisualStyleBackColor = true;
            this.btn_TeslimEt.Click += new System.EventHandler(this.btn_TeslimEt_Click);
            // 
            // dtp_teslim
            // 
            this.dtp_teslim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_teslim.Location = new System.Drawing.Point(144, 305);
            this.dtp_teslim.Name = "dtp_teslim";
            this.dtp_teslim.Size = new System.Drawing.Size(167, 30);
            this.dtp_teslim.TabIndex = 8;
            // 
            // dtp_alim
            // 
            this.dtp_alim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_alim.Location = new System.Drawing.Point(144, 259);
            this.dtp_alim.Name = "dtp_alim";
            this.dtp_alim.Size = new System.Drawing.Size(167, 30);
            this.dtp_alim.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 50);
            this.label4.TabIndex = 6;
            this.label4.Text = "Son Teslim\r\nTarihi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Alım Tarihi:";
            // 
            // txt_yazar
            // 
            this.txt_yazar.Enabled = false;
            this.txt_yazar.Location = new System.Drawing.Point(144, 219);
            this.txt_yazar.Name = "txt_yazar";
            this.txt_yazar.Size = new System.Drawing.Size(167, 30);
            this.txt_yazar.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Yazar Adı:";
            // 
            // KAldigiKitaplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1029, 572);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "KAldigiKitaplar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Elimdeki Kitaplar";
            this.Load += new System.EventHandler(this.KAldigiKitaplar_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_GeriDon;
        private System.Windows.Forms.Button btn_TeslimEt;
        private System.Windows.Forms.DateTimePicker dtp_teslim;
        private System.Windows.Forms.DateTimePicker dtp_alim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_yazar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_KitapID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_KullaniciID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Kitap;
        private System.Windows.Forms.TextBox txt_KullaniciAdi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_KullaniciAdi;
    }
}