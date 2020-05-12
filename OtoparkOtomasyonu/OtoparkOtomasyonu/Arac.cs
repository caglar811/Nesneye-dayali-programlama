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
    //Abstract soyut sınıf nesne türetilemez
    abstract class Arac:IArac
    {
        //Encapsulation Kapsüllenmiş private Alanlar (Fields)
        private string _plaka;
        private string _marka;
        private string _model;
        private string _aractipi;
        protected double _fiyat;
        protected double saat;
        //Constructor Parametresiz
        public Arac()
        {

        }
        //Constructor Parametreli
        public Arac(double fiyat, double saat)
        {
            this._fiyat = fiyat;
            this.Saat = saat;
        }
        //Properties Özellikler
        public string Plaka { get => _plaka; set => _plaka = value; }
        public string Marka { get => _marka; set => _marka = value; }
        public string Model { get => _model; set => _model = value; }
        public string Aractipi { get => _aractipi; set => _aractipi = value; }
        public double Fiyat { get => _fiyat; set => _fiyat = value; }
        protected double Saat { get => saat; set => saat = value; }

        //Interfaceden Gelen Method
        public void AracGiris(string Plaka, string Marka, string Model, string Aractipi)
        {
            this._plaka = Plaka;
            this._marka = Marka;
            this._model = Model;
            this._aractipi = Aractipi;

        }

        //Çok biçimli Pollymorphism method
        public virtual double fiyatHesapla()
        {
            return 0;
        }
    }
}
