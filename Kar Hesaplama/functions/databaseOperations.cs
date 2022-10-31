using System.Data.SQLite;
using Dapper;
using Kar_Hesaplama.Models;
using System.Linq;

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
            conn.Open();
            
        }
    }
}
