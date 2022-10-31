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
            ((System.ComponentModel.ISupportInitialize)(this.upDownSaat)).BeginInit();
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
            this.button1.Location = new System.Drawing.Point(20, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 23);
            this.button1.TabIndex = 36;
            this.button1.Text = "Kayıt Ekle";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(20, 227);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 23);
            this.button2.TabIndex = 37;
            this.button2.Text = "Kayıt Güncelle";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(20, 256);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(194, 23);
            this.button3.TabIndex = 38;
            this.button3.Text = "Kayıt Sil";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 513);
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
    }
}