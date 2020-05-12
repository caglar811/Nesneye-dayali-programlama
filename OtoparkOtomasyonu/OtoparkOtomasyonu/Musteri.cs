/******************************************************
 **                 SAKARYA üNİVERSİTESİ              
 **            BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ    
 **             BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ
 **                 NESNEYE DAYALI PROGRAMLAMA DERSİ
 **                     2019-2020 BAHAR DÖNEMİ
 **                     PROJE NUMARASI.........: 02
 **                     ÖĞRENCİ ADI............: ÇAĞLAR YILMAZ
 **                     ÖĞRENCİ NUMARASI.......: B151200029
 **                     DERSİN ALINDIĞI GRUP...: A 
 *****************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoparkOtomasyonu
{
    class Musteri:IMusteri
    {
        //Kapsüllenmiş private alanlar (Fields)
        private string _ad;
        private string _soyad;
        private string _TcKimlik;
        private string _Telefon;

        //Properties Özellikler
        public string Ad { get => _ad; set => _ad = value; }
        public string Soyad { get => _soyad; set => _soyad = value; }
        public string TcKimlik { get => _TcKimlik; set => _TcKimlik = value; }
        public string Telefon { get => _Telefon; set => _Telefon = value; }

        //Interface den gelen parametreli method
        public void MusteriKayit(string Ad, string SoyAd, string TcKimlik, string Telefon)
        {
            this._ad = Ad;
            this._soyad = SoyAd;
            this._TcKimlik = TcKimlik;
            this._Telefon = Telefon;
        }
    }
}
