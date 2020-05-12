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
    //Araç sınıfına ait bir interface Arayüz
    interface IArac
    {
        //parametreli method
        void AracGiris(string Plaka, string Marka,string Model, string Aractipi);
        
    }
}
