namespace Kar_Hesaplama
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboIslemTuru = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboSirketAdi = new System.Windows.Forms.ComboBox();
            this.comboUevcbAdi = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEak = new System.Windows.Forms.TextBox();
            this.txtKgup = new System.Windows.Forms.TextBox();
            this.txtGerekceliEak = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboTalimatYonu = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtArizaDengeleme = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBirakilanTalimat = new System.Windows.Forms.TextBox();
            this.txtGelenTalimat = new System.Windows.Forms.TextBox();
            this.txtTeslimEdilenTalimat = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtSistemYonu = new System.Windows.Forms.TextBox();
            this.txtGipSatisTutar = new System.Windows.Forms.TextBox();
            this.txtGipSatisMiktar = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtGrupDengesizligi = new System.Windows.Forms.TextBox();
            this.txtAksaDeng = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.dateTarih = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.upDownSaat = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTumunuListele = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.upDownSaat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboIslemTuru
            // 
            this.comboIslemTuru.DisplayMember = "Appearence";
            this.comboIslemTuru.FormattingEnabled = true;
            this.comboIslemTuru.Location = new System.Drawing.Point(93, 13);
            this.comboIslemTuru.Name = "comboIslemTuru";
            this.comboIslemTuru.Size = new System.Drawing.Size(121, 23);
            this.comboIslemTuru.TabIndex = 0;
            this.comboIslemTuru.ValueMember = "id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "İşlem Türü:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şirket Adı:";
            // 
            // comboSirketAdi
            // 
            this.comboSirketAdi.DisplayMember = "Appearence";
            this.comboSirketAdi.FormattingEnabled = true;
            this.comboSirketAdi.Location = new System.Drawing.Point(93, 43);
            this.comboSirketAdi.Name = "comboSirketAdi";
            this.comboSirketAdi.Size = new System.Drawing.Size(121, 23);
            this.comboSirketAdi.TabIndex = 3;
            this.comboSirketAdi.ValueMember = "id";
            this.comboSirketAdi.SelectedIndexChanged += new System.EventHandler(this.comboSirketAdi_SelectedIndexChanged);
            // 
            // comboUevcbAdi
            // 
            this.comboUevcbAdi.DisplayMember = "Appearence";
            this.comboUevcbAdi.FormattingEnabled = true;
            this.comboUevcbAdi.Location = new System.Drawing.Point(93, 72);
            this.comboUevcbAdi.Name = "comboUevcbAdi";
            this.comboUevcbAdi.Size = new System.Drawing.Size(121, 23);
            this.comboUevcbAdi.TabIndex = 4;
            this.comboUevcbAdi.ValueMember = "id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "UEVCB Adı:";
            // 
            // txtEak
            // 
            this.txtEak.Location = new System.Drawing.Point(304, 13);
            this.txtEak.Name = "txtEak";
            this.txtEak.Size = new System.Drawing.Size(121, 23);
            this.txtEak.TabIndex = 6;
            // 
            // txtKgup
            // 
            this.txtKgup.Location = new System.Drawing.Point(304, 43);
            this.txtKgup.Name = "txtKgup";
            this.txtKgup.Size = new System.Drawing.Size(121, 23);
            this.txtKgup.TabIndex = 7;
            // 
            // txtGerekceliEak
            // 
            this.txtGerekceliEak.Location = new System.Drawing.Point(304, 72);
            this.txtGerekceliEak.Name = "txtGerekceliEak";
            this.txtGerekceliEak.Size = new System.Drawing.Size(121, 23);
            this.txtGerekceliEak.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "UEVCB EAK:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(223, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "UEVCB KGÜP:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(219, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Gerekçeli EAK:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Talimat Yönü:";
            // 
            // comboTalimatYonu
            // 
            this.comboTalimatYonu.DisplayMember = "Appearence";
            this.comboTalimatYonu.FormattingEnabled = true;
            this.comboTalimatYonu.Location = new System.Drawing.Point(93, 102);
            this.comboTalimatYonu.Name = "comboTalimatYonu";
            this.comboTalimatYonu.Size = new System.Drawing.Size(121, 23);
            this.comboTalimatYonu.TabIndex = 13;
            this.comboTalimatYonu.ValueMember = "id";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(231, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Arıza Deng.";
            // 
            // txtArizaDengeleme
            // 
            this.txtArizaDengeleme.Location = new System.Drawing.Point(304, 102);
            this.txtArizaDengeleme.Name = "txtArizaDengeleme";
            this.txtArizaDengeleme.Size = new System.Drawing.Size(121, 23);
            this.txtArizaDengeleme.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(454, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "Bırakılan Talimat:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(469, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 15);
            this.label10.TabIndex = 17;
            this.label10.Text = "Gelen Talimat:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(431, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 15);
            this.label11.TabIndex = 18;
            this.label11.Text = "Teslim Edilen Talimat:";
            // 
            // txtBirakilanTalimat
            // 
            this.txtBirakilanTalimat.Location = new System.Drawing.Point(556, 13);
            this.txtBirakilanTalimat.Name = "txtBirakilanTalimat";
            this.txtBirakilanTalimat.Size = new System.Drawing.Size(121, 23);
            this.txtBirakilanTalimat.TabIndex = 19;
            // 
            // txtGelenTalimat
            // 
            this.txtGelenTalimat.Location = new System.Drawing.Point(556, 43);
            this.txtGelenTalimat.Name = "txtGelenTalimat";
            this.txtGelenTalimat.Size = new System.Drawing.Size(121, 23);
            this.txtGelenTalimat.TabIndex = 20;
            // 
            // txtTeslimEdilenTalimat
            // 
            this.txtTeslimEdilenTalimat.Location = new System.Drawing.Point(556, 72);
            this.txtTeslimEdilenTalimat.Name = "txtTeslimEdilenTalimat";
            this.txtTeslimEdilenTalimat.Size = new System.Drawing.Size(121, 23);
            this.txtTeslimEdilenTalimat.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(700, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 15);
            this.label12.TabIndex = 24;
            this.label12.Text = "Sistem Yönü:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(690, 46);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 15);
            this.label13.TabIndex = 23;
            this.label13.Text = "GİP Satış Tutar:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(683, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 15);
            this.label14.TabIndex = 22;
            this.label14.Text = "GİP Satış Miktar:";
            // 
            // txtSistemYonu
            // 
            this.txtSistemYonu.Location = new System.Drawing.Point(781, 72);
            this.txtSistemYonu.Name = "txtSistemYonu";
            this.txtSistemYonu.Size = new System.Drawing.Size(121, 23);
            this.txtSistemYonu.TabIndex = 27;
            // 
            // txtGipSatisTutar
            // 
            this.txtGipSatisTutar.Location = new System.Drawing.Point(781, 43);
            this.txtGipSatisTutar.Name = "txtGipSatisTutar";
            this.txtGipSatisTutar.Size = new System.Drawing.Size(121, 23);
            this.txtGipSatisTutar.TabIndex = 26;
            // 
            // txtGipSatisMiktar
            // 
            this.txtGipSatisMiktar.Location = new System.Drawing.Point(781, 13);
            this.txtGipSatisMiktar.Name = "txtGipSatisMiktar";
            this.txtGipSatisMiktar.Size = new System.Drawing.Size(121, 23);
            this.txtGipSatisMiktar.TabIndex = 25;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(452, 104);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(98, 15);
            this.label15.TabIndex = 28;
            this.label15.Text = "Grup Dengesizlik:";
            // 
            // txtGrupDengesizligi
            // 
            this.txtGrupDengesizligi.Location = new System.Drawing.Point(556, 101);
            this.txtGrupDengesizligi.Name = "txtGrupDengesizligi";
            this.txtGrupDengesizligi.Size = new System.Drawing.Size(121, 23);
            this.txtGrupDengesizligi.TabIndex = 29;
            // 
            // txtAksaDeng
            // 
            this.txtAksaDeng.Location = new System.Drawing.Point(781, 102);
            this.txtAksaDeng.Name = "txtAksaDeng";
            this.txtAksaDeng.Size = new System.Drawing.Size(121, 23);
            this.txtAksaDeng.TabIndex = 31;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(678, 105);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(97, 15);
            this.label16.TabIndex = 30;
            this.label16.Text = "Aksa Dengesizlik:";
            // 
            // dateTarih
            // 
            this.dateTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTarih.Location = new System.Drawing.Point(93, 131);
            this.dateTarih.Name = "dateTarih";
            this.dateTarih.Size = new System.Drawing.Size(121, 23);
            this.dateTarih.TabIndex = 32;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(52, 137);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 15);
            this.label17.TabIndex = 33;
            this.label17.Text = "Tarih:";
            // 
            // upDownSaat
            // 
            this.upDownSaat.Location = new System.Drawing.Point(93, 160);
            this.upDownSaat.Name = "upDownSaat";
            this.upDownSaat.Size = new System.Drawing.Size(120, 23);
            this.upDownSaat.TabIndex = 34;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(55, 162);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(32, 15);
            this.label18.TabIndex = 35;
            this.label18.Text = "Saat:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(231, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 23);
            this.button1.TabIndex = 36;
            this.button1.Text = "Kayıt Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(231, 162);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 23);
            this.button2.TabIndex = 37;
            this.button2.Text = "Kayıt Güncelle";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(231, 191);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(194, 23);
            this.button3.TabIndex = 38;
            this.button3.Text = "Kayıt Sil";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15,
            this.Column16,
            this.Column17,
            this.Column18,
            this.Column19});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 274);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(974, 239);
            this.dataGridView1.TabIndex = 39;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_DoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id";
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "islemTur";
            this.Column2.HeaderText = "İşlem Türü";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Tarih";
            this.Column3.HeaderText = "Tarih";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "saat";
            this.Column4.HeaderText = "Saat";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "sirketAdi";
            this.Column5.HeaderText = "Şirket Adı";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "uevcbAdi";
            this.Column6.HeaderText = "UEVÇB Adı";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "uevcbEak";
            this.Column7.HeaderText = "UEVCB Eak";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "uevcbKgup";
            this.Column8.HeaderText = "UEVCB KGÜP";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "gerekceliEak";
            this.Column9.HeaderText = "Gerekçeli Eak";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "arizaDengelemeMiktar";
            this.Column10.HeaderText = "Arıza Dengeleme Miktarı";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "yonAdi";
            this.Column11.HeaderText = "Talimat Yönü";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "birakilanTalimat";
            this.Column12.HeaderText = "Bırakılan Talimat";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "gelenTalimat";
            this.Column13.HeaderText = "Gelen Talimat";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            // 
            // Column14
            // 
            this.Column14.DataPropertyName = "teslimEdilenTalimat";
            this.Column14.HeaderText = "Teslim Edilen Talimat";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            // 
            // Column15
            // 
            this.Column15.DataPropertyName = "gipSatisMiktar";
            this.Column15.HeaderText = "GİP Satış Miktarı";
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            // 
            // Column16
            // 
            this.Column16.DataPropertyName = "gipSatisTutar";
            this.Column16.HeaderText = "GİP Satış Tutarı";
            this.Column16.Name = "Column16";
            this.Column16.ReadOnly = true;
            // 
            // Column17
            // 
            this.Column17.DataPropertyName = "sistemYonu";
            this.Column17.HeaderText = "Sistem Yönü";
            this.Column17.Name = "Column17";
            this.Column17.ReadOnly = true;
            // 
            // Column18
            // 
            this.Column18.DataPropertyName = "grupDengesizligi";
            this.Column18.HeaderText = "Grup Dengesizliği";
            this.Column18.Name = "Column18";
            this.Column18.ReadOnly = true;
            // 
            // Column19
            // 
            this.Column19.DataPropertyName = "aksaDengesizligi";
            this.Column19.HeaderText = "Aksa Dengesizliği";
            this.Column19.Name = "Column19";
            this.Column19.ReadOnly = true;
            // 
            // btnTumunuListele
            // 
            this.btnTumunuListele.Location = new System.Drawing.Point(0, 245);
            this.btnTumunuListele.Name = "btnTumunuListele";
            this.btnTumunuListele.Size = new System.Drawing.Size(194, 23);
            this.btnTumunuListele.TabIndex = 40;
            this.btnTumunuListele.Text = "Tümünü Listele";
            this.btnTumunuListele.UseVisualStyleBackColor = true;
            this.btnTumunuListele.Click += new System.EventHandler(this.btnTumunuListele_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 513);
            this.Controls.Add(this.btnTumunuListele);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.upDownSaat);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.dateTarih);
            this.Controls.Add(this.txtAksaDeng);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtGrupDengesizligi);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtSistemYonu);
            this.Controls.Add(this.txtGipSatisTutar);
            this.Controls.Add(this.txtGipSatisMiktar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtTeslimEdilenTalimat);
            this.Controls.Add(this.txtGelenTalimat);
            this.Controls.Add(this.txtBirakilanTalimat);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtArizaDengeleme);
            this.Controls.Add(this.comboTalimatYonu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtGerekceliEak);
            this.Controls.Add(this.txtKgup);
            this.Controls.Add(this.txtEak);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboUevcbAdi);
            this.Controls.Add(this.comboSirketAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboIslemTuru);
            this.Name = "Form1";
            this.Text = "İşlem Kaydı";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.upDownSaat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboIslemTuru;
        private Label label1;
        private Label label2;
        private ComboBox comboSirketAdi;
        private ComboBox comboUevcbAdi;
        private Label label3;
        private TextBox txtEak;
        private TextBox txtKgup;
        private TextBox txtGerekceliEak;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox comboTalimatYonu;
        private Label label8;
        private TextBox txtArizaDengeleme;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox txtBirakilanTalimat;
        private TextBox txtGelenTalimat;
        private TextBox txtTeslimEdilenTalimat;
        private Label label12;
        private Label label13;
        private Label label14;
        private TextBox txtSistemYonu;
        private TextBox txtGipSatisTutar;
        private TextBox txtGipSatisMiktar;
        private Label label15;
        private TextBox txtGrupDengesizligi;
        private TextBox txtAksaDeng;
        private Label label16;
        private DateTimePicker dateTarih;
        private Label label17;
        private NumericUpDown upDownSaat;
        private Label label18;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView1;
        private Button btnTumunuListele;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn Column14;
        private DataGridViewTextBoxColumn Column15;
        private DataGridViewTextBoxColumn Column16;
        private DataGridViewTextBoxColumn Column17;
        private DataGridViewTextBoxColumn Column18;
        private DataGridViewTextBoxColumn Column19;
    }
}