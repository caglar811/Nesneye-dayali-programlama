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
    class Kamyonet:Arac
    {
        //Constructor Parametreli
        public Kamyonet(double fiyat,double saat):base(fiyat,saat)
        {

        }
        //Constructor Parametresiz
        public Kamyonet()
        {

        }
        //Pollymorphism Çok biçimli method
        public override double fiyatHesapla()
        {
            double toplam = (_fiyat * saat);
            return toplam=toplam+(toplam*0.20);
        }
    }
}
