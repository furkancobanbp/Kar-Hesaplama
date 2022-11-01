using Kar_Hesaplama.functions;
using Kar_Hesaplama.Models;

namespace Kar_Hesaplama
{
    public partial class Form1 : Form
    {
        databaseOperations dbOp;
        clsKayitModels kayitModel;
        int id;
        public Form1()
        {
            InitializeComponent();
            dbOp = new databaseOperations();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboSirketAdi.DataSource = dbOp.getSirket();
            comboIslemTuru.DataSource = dbOp.get_islemTur();
            comboTalimatYonu.DataSource = dbOp.getTalimatYonu();

            kayitModel = new clsKayitModels();

            comboIslemTuru.DataBindings.Add("SelectedValue", kayitModel, "islemTur_id", true, DataSourceUpdateMode.OnPropertyChanged);
            dateTarih.DataBindings.Add("Value", kayitModel, "Tarih", true, DataSourceUpdateMode.OnPropertyChanged);
            upDownSaat.DataBindings.Add("Value", kayitModel, "saat", true, DataSourceUpdateMode.OnPropertyChanged);
            comboSirketAdi.DataBindings.Add("SelectedValue", kayitModel, "sirket_id", true, DataSourceUpdateMode.OnPropertyChanged);
            comboUevcbAdi.DataBindings.Add("SelectedValue", kayitModel, "uevcb_id", true, DataSourceUpdateMode.OnPropertyChanged);
            txtEak.DataBindings.Add("Text", kayitModel, "uevcbEak", true, DataSourceUpdateMode.OnPropertyChanged);
            txtKgup.DataBindings.Add("Text", kayitModel, "uevcbKgup", true, DataSourceUpdateMode.OnPropertyChanged);
            txtGerekceliEak.DataBindings.Add("Text", kayitModel, "gerekceliEak", true, DataSourceUpdateMode.OnPropertyChanged);
            txtArizaDengeleme.DataBindings.Add("Text", kayitModel, "arizaDengelemeMiktar", true, DataSourceUpdateMode.OnPropertyChanged);
            comboTalimatYonu.DataBindings.Add("SelectedValue", kayitModel, "talimatYon_id", true, DataSourceUpdateMode.OnPropertyChanged);
            txtBirakilanTalimat.DataBindings.Add("Text", kayitModel, "birakilanTalimat", true, DataSourceUpdateMode.OnPropertyChanged);
            txtGelenTalimat.DataBindings.Add("Text", kayitModel, "gelenTalimat", true, DataSourceUpdateMode.OnPropertyChanged);
            txtTeslimEdilenTalimat.DataBindings.Add("Text", kayitModel, "teslimEdilenTalimat", true, DataSourceUpdateMode.OnPropertyChanged);
            txtGipSatisMiktar.DataBindings.Add("Text", kayitModel, "gipSatisMiktar", true, DataSourceUpdateMode.OnPropertyChanged);
            txtGipSatisTutar.DataBindings.Add("Text", kayitModel, "gipSatisTutar", true, DataSourceUpdateMode.OnPropertyChanged);
            txtSistemYonu.DataBindings.Add("Text", kayitModel, "sistemYonu", true, DataSourceUpdateMode.OnPropertyChanged);
            txtGrupDengesizligi.DataBindings.Add("Text", kayitModel, "grupDengesizligi", true, DataSourceUpdateMode.OnPropertyChanged);
            txtAksaDeng.DataBindings.Add("Text", kayitModel, "aksaDengesizligi", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void comboSirketAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboUevcbAdi.DataSource = dbOp.getUevcb(Convert.ToInt32(comboSirketAdi.SelectedValue));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dbOp.insertRecord(kayitModel);
        }

        private void btnTumunuListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dbOp.getKayitlar();
        }

        private void dataGridView1_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {            
            id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            kayitModel = dbOp.fillForms(id);
        }
    }
}