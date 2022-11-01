using System.Data.SQLite;
using Dapper;
using Kar_Hesaplama.Models;
using System.Linq;
using System.Data.SQLite.Linq;

namespace Kar_Hesaplama.functions
{
    public class databaseOperations
    {
        public SQLiteConnection conn = new SQLiteConnection("Data Source = celiklerFurkanDb.db");
        public List<clsBasicModels> getSirket()
        {
            var Sql = "select sirket_id id, sirketAdi Appearence from tblSirket";
            conn.Open();
            var results = conn.Query<clsBasicModels>(Sql).ToList();
            conn.Close();
            return results;
        }
        public List<clsUevcbModel> getUevcb(int sirketId)
        {
            var Sql = "select uevcb_id id ,sirket_id sirketId, uevcbAdi Appearence from tblUevcb where sirket_id = " + sirketId + "";
            conn.Open();
            var results = conn.Query<clsUevcbModel>(Sql).ToList();
            conn.Close();
            return results;
        }
        public List<clsBasicModels> get_islemTur()
        {
            var Sql = "select id id, islemTur Appearence from tbl_islemTuru";
            conn.Open();
            var results = conn.Query<clsBasicModels>(Sql).ToList();
            conn.Close();
            return results;
        }
        public List<clsBasicModels> getTalimatYonu()
        {
            var Sql = "select yon_id id, yonAdi Appearence from tblTalimatYonu";
            conn.Open();
            var results = conn.Query<clsBasicModels>(Sql).ToList();
            conn.Close();
            return results;
        }
        public void insertRecord(clsKayitModels kayitModel)
        {
            var sql = "insert into tblAylikTablo" +
                "(islemTur_id, Tarih, saat, sirket_id, uevcb_id, uevcbEak, uevcbKgup, gerekceliEak, arizaDengelemeMiktar," +
                " talimatYon_id, birakilanTalimat, gelenTalimat, teslimEdilenTalimat, gipSatisMiktar, gipSatisTutar, sistemYonu, " +
                "grupDengesizligi, aksaDengesizligi) values " +
                "(@islemTur_id, @Tarih, @saat, @sirket_id, @uevcb_id, @uevcbEak, @uevcbKgup, @gerekceliEak, @arizaDengelemeMiktar," +
                " @talimatYon_id, @birakilanTalimat, @gelenTalimat, @teslimEdilenTalimat, @gipSatisMiktar, @gipSatisTutar, @sistemYonu, " +
                "@grupDengesizligi, @aksaDengesizligi)";

            conn.Open();
            conn.Execute(sql, kayitModel);
            conn.Close();
            MessageBox.Show("Kayıt Tamamlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public List<GetKayitlar> getKayitlar()
        {
            var sql = "select t.id, i.islemTur, t.Tarih, t.saat, s.sirketAdi, u.uevcbAdi, t.uevcbEak, t.uevcbKgup, t.gerekceliEak, y.yonAdi, t.birakilanTalimat, t.gelenTalimat, t.teslimEdilenTalimat, " +
            "t.gipSatisMiktar, t.gipSatisTutar, t.sistemYonu, t.grupDengesizligi, t.aksaDengesizligi " +
            "from tblAylikTablo t, tbl_islemTuru i, tblTalimatYonu y, tblSirket s, tblUevcb u " +
            "where t.islemTur_id = i.id " +
            "and t.talimatYon_id = y.yon_id " +
            "and t.sirket_id = s.sirket_id " +
            "and s.sirket_id = u.sirket_id ";
            conn.Open();
            var results = conn.Query<GetKayitlar>(sql).ToList();
            conn.Close();
            return results;
            
        }
        public clsKayitModels fillForms(int id)
        {
            clsKayitModels model = new clsKayitModels();
            var sql = "select * from tblAylikTablo where id = " + id + "";
            conn.Open();
            conn.Execute(sql, model);
            conn.Close();
            return model;
            
        }
    }
}
