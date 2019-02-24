namespace WindowsFormsApplication1
{
    partial class Anaform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anaform));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buton_kayitsil = new DevExpress.XtraEditors.SimpleButton();
            this.buton_hastaekle = new DevExpress.XtraEditors.SimpleButton();
            this.buton_tetkikgüncelle = new DevExpress.XtraEditors.SimpleButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buton_hastasec = new DevExpress.XtraEditors.SimpleButton();
            this.buton_hastagüncelle = new DevExpress.XtraEditors.SimpleButton();
            this.buton_hastagecmisi = new DevExpress.XtraEditors.SimpleButton();
            this.buton_testsonuclari = new DevExpress.XtraEditors.SimpleButton();
            this.buton_tetkiksec = new DevExpress.XtraEditors.SimpleButton();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iletişimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sorunVeŞikayetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şifreİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labDuyurularıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(599, 192);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(117, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(214, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "TC ile Arama:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Menu;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buton_kayitsil);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Location = new System.Drawing.Point(12, 139);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(619, 371);
            this.panel1.TabIndex = 18;
            // 
            // buton_kayitsil
            // 
            this.buton_kayitsil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buton_kayitsil.ImageOptions.Image")));
            this.buton_kayitsil.Location = new System.Drawing.Point(20, 320);
            this.buton_kayitsil.Name = "buton_kayitsil";
            this.buton_kayitsil.Size = new System.Drawing.Size(75, 35);
            this.buton_kayitsil.TabIndex = 5;
            this.buton_kayitsil.Text = "SİL";
            this.buton_kayitsil.Click += new System.EventHandler(this.simpleButton6_Click);
            // 
            // buton_hastaekle
            // 
            this.buton_hastaekle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buton_hastaekle.ImageOptions.Image")));
            this.buton_hastaekle.Location = new System.Drawing.Point(12, 34);
            this.buton_hastaekle.Name = "buton_hastaekle";
            this.buton_hastaekle.Size = new System.Drawing.Size(119, 52);
            this.buton_hastaekle.TabIndex = 24;
            this.buton_hastaekle.Text = "HASTA EKLE";
            this.buton_hastaekle.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // buton_tetkikgüncelle
            // 
            this.buton_tetkikgüncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buton_tetkikgüncelle.ImageOptions.Image")));
            this.buton_tetkikgüncelle.Location = new System.Drawing.Point(156, 34);
            this.buton_tetkikgüncelle.Name = "buton_tetkikgüncelle";
            this.buton_tetkikgüncelle.Size = new System.Drawing.Size(140, 52);
            this.buton_tetkikgüncelle.TabIndex = 25;
            this.buton_tetkikgüncelle.Text = "TETKİK GÜNCELLE";
            this.buton_tetkikgüncelle.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(44, 255);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 23;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(44, 176);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(44, 212);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(200, 20);
            this.textBox5.TabIndex = 21;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(44, 134);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(200, 20);
            this.textBox4.TabIndex = 20;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(44, 98);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(200, 20);
            this.textBox3.TabIndex = 19;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(44, 59);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 20);
            this.textBox2.TabIndex = 18;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(44, 21);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(200, 20);
            this.textBox6.TabIndex = 24;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buton_hastasec);
            this.groupBox1.Controls.Add(this.buton_hastagüncelle);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(663, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 357);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "HASTA BİLGİLERİ";
            // 
            // buton_hastasec
            // 
            this.buton_hastasec.AccessibleName = "button";
            this.buton_hastasec.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buton_hastasec.ImageOptions.Image")));
            this.buton_hastasec.Location = new System.Drawing.Point(6, 309);
            this.buton_hastasec.Name = "buton_hastasec";
            this.buton_hastasec.Size = new System.Drawing.Size(117, 34);
            this.buton_hastasec.TabIndex = 30;
            this.buton_hastasec.Text = "HASTAYI SEÇ";
            this.buton_hastasec.Click += new System.EventHandler(this.simpleButton8_Click);
            // 
            // buton_hastagüncelle
            // 
            this.buton_hastagüncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buton_hastagüncelle.ImageOptions.Image")));
            this.buton_hastagüncelle.Location = new System.Drawing.Point(150, 312);
            this.buton_hastagüncelle.Name = "buton_hastagüncelle";
            this.buton_hastagüncelle.Size = new System.Drawing.Size(106, 28);
            this.buton_hastagüncelle.TabIndex = 29;
            this.buton_hastagüncelle.Text = "GÜNCELLE";
            this.buton_hastagüncelle.Click += new System.EventHandler(this.simpleButton7_Click);
            // 
            // buton_hastagecmisi
            // 
            this.buton_hastagecmisi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buton_hastagecmisi.ImageOptions.Image")));
            this.buton_hastagecmisi.Location = new System.Drawing.Point(721, 39);
            this.buton_hastagecmisi.Name = "buton_hastagecmisi";
            this.buton_hastagecmisi.Size = new System.Drawing.Size(126, 47);
            this.buton_hastagecmisi.TabIndex = 28;
            this.buton_hastagecmisi.Text = "HASTA GEÇMİŞİ";
            this.buton_hastagecmisi.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // buton_testsonuclari
            // 
            this.buton_testsonuclari.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buton_testsonuclari.ImageOptions.Image")));
            this.buton_testsonuclari.Location = new System.Drawing.Point(518, 39);
            this.buton_testsonuclari.Name = "buton_testsonuclari";
            this.buton_testsonuclari.Size = new System.Drawing.Size(177, 50);
            this.buton_testsonuclari.TabIndex = 27;
            this.buton_testsonuclari.Text = "TEST SONUÇLARI";
            this.buton_testsonuclari.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // buton_tetkiksec
            // 
            this.buton_tetkiksec.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buton_tetkiksec.ImageOptions.Image")));
            this.buton_tetkiksec.Location = new System.Drawing.Point(313, 36);
            this.buton_tetkiksec.Name = "buton_tetkiksec";
            this.buton_tetkiksec.Size = new System.Drawing.Size(169, 50);
            this.buton_tetkiksec.TabIndex = 26;
            this.buton_tetkiksec.Text = "UYGULANACAK TESTLER";
            this.buton_tetkiksec.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çıkışToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // iletişimToolStripMenuItem
            // 
            this.iletişimToolStripMenuItem.Name = "iletişimToolStripMenuItem";
            this.iletişimToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.iletişimToolStripMenuItem.Text = "İletişim";
            this.iletişimToolStripMenuItem.Click += new System.EventHandler(this.iletişimToolStripMenuItem_Click);
            // 
            // sorunVeŞikayetToolStripMenuItem
            // 
            this.sorunVeŞikayetToolStripMenuItem.Name = "sorunVeŞikayetToolStripMenuItem";
            this.sorunVeŞikayetToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.sorunVeŞikayetToolStripMenuItem.Text = "Sorun ve Şikayet";
            this.sorunVeŞikayetToolStripMenuItem.Click += new System.EventHandler(this.sorunVeŞikayetToolStripMenuItem_Click);
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.şifreİşlemleriToolStripMenuItem,
            this.kullanıcıBilgileriToolStripMenuItem});
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.ayarlarToolStripMenuItem.Text = "Ayarlar";
            // 
            // şifreİşlemleriToolStripMenuItem
            // 
            this.şifreİşlemleriToolStripMenuItem.Name = "şifreİşlemleriToolStripMenuItem";
            this.şifreİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.şifreİşlemleriToolStripMenuItem.Text = "Şifre İşlemleri";
            this.şifreİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.şifreİşlemleriToolStripMenuItem_Click);
            // 
            // kullanıcıBilgileriToolStripMenuItem
            // 
            this.kullanıcıBilgileriToolStripMenuItem.Name = "kullanıcıBilgileriToolStripMenuItem";
            this.kullanıcıBilgileriToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.kullanıcıBilgileriToolStripMenuItem.Text = "Kullanıcı Bilgileri";
            this.kullanıcıBilgileriToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıBilgileriToolStripMenuItem_Click);
            // 
            // labDuyurularıToolStripMenuItem
            // 
            this.labDuyurularıToolStripMenuItem.Name = "labDuyurularıToolStripMenuItem";
            this.labDuyurularıToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.labDuyurularıToolStripMenuItem.Text = "Lab Duyuruları";
            this.labDuyurularıToolStripMenuItem.Click += new System.EventHandler(this.labDuyurularıToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.iletişimToolStripMenuItem,
            this.sorunVeŞikayetToolStripMenuItem,
            this.ayarlarToolStripMenuItem,
            this.labDuyurularıToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1099, 24);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Anaform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1099, 555);
            this.Controls.Add(this.buton_tetkiksec);
            this.Controls.Add(this.buton_tetkikgüncelle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buton_hastagecmisi);
            this.Controls.Add(this.buton_hastaekle);
            this.Controls.Add(this.buton_testsonuclari);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Anaform";
            this.Text = "ANAFORM";
            this.Load += new System.EventHandler(this.Anaform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton buton_hastaekle;
        private DevExpress.XtraEditors.SimpleButton buton_tetkikgüncelle;
        private DevExpress.XtraEditors.SimpleButton buton_kayitsil;
        private DevExpress.XtraEditors.SimpleButton buton_hastagüncelle;
        private DevExpress.XtraEditors.SimpleButton buton_hastasec;
        private DevExpress.XtraEditors.SimpleButton buton_hastagecmisi;
        private DevExpress.XtraEditors.SimpleButton buton_testsonuclari;
        private DevExpress.XtraEditors.SimpleButton buton_tetkiksec;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iletişimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sorunVeŞikayetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şifreİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıBilgileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem labDuyurularıToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}