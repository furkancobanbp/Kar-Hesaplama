using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kar_Hesaplama.Models
{
    public class clsKayitModels
    {
        public int id { get; set; }
        public int islemTur_id { get; set; }
        public DateTime Tarih { get; set; }
        public int saat { get; set; }
        public int sirket_id { get; set; }
        public int uevcb_id { get; set; }
        public decimal uevcbEak { get; set; }
        public decimal uevcbKgup { get; set; }
        public decimal gerekceliEak { get; set; }
        public decimal arizaDengelemeMiktar { get; set; }
        public int talimatYon_id { get; set; }
        public decimal birakilanTalimat { get; set; }
        public decimal gelenTalimat { get; set; }
        public decimal teslimEdilenTalimat { get; set; }
        public decimal gipSatisMiktar { get; set; }
        public decimal gipSatisTutar { get; set; }
        public decimal sistemYonu { get; set; }
        public decimal grupDengesizligi { get; set; }
        public decimal aksaDengesizligi { get; set; }
    }
    public class GetKayitlar
    {
        public int id { get; set; }
        public String islemTur { get; set; }
        public DateTime Tarih { get; set; }
        public int saat { get; set; }
        public String sirketAdi { get; set; }
        public String uevcbAdi { get; set; }
        public decimal uevcbEak { get; set; }
        public decimal uevcbKgup { get; set; }
        public decimal gerekceliEak { get; set; }
        public decimal arizaDengelemeMiktar { get; set; }
        public String yonAdi { get; set; }
        public decimal birakilanTalimat { get; set; }
        public decimal gelenTalimat { get; set; }
        public decimal teslimEdilenTalimat { get; set; }
        public decimal gipSatisMiktar { get; set; }
        public decimal gipSatisTutar { get; set; }
        public decimal sistemYonu { get; set; }
        public decimal grupDengesizligi { get; set; }
        public decimal aksaDengesizligi { get; set; }

    }
}
