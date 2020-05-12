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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoparkOtomasyonu
{
    
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }
        public int AracKod;
   
        private void button8_Click(object sender, EventArgs e)
        {
            //Hata Kontrol Mekanizması try Catch
            try
            {       //Kontrol yapıları if else
                    if (dataGridView1.RowCount > 5)
                    {
                        MessageBox.Show("Boş Park Yeri Kalmadı");
                    }

                    else if (dataGridView1.RowCount == 1)
                    {
                        lblpark1.BackColor = Color.Red;
                    }
                    else if (dataGridView1.RowCount == 2)
                    {
                        lblPark2.BackColor = Color.Red;
                    }
                    else if (dataGridView1.RowCount == 3)
                    {
                        lblPark3.BackColor = Color.Red;
                    }
                    else if (dataGridView1.RowCount == 4)
                    {
                        lblPark4.BackColor = Color.Red;
                    }
                    else if (dataGridView1.RowCount == 5)
                    {
                        lblPark5.BackColor = Color.Red;
                    }



                //Nesne Türetmek
                Musteri ms = new Musteri();
                NormalArac na = new NormalArac();
                Kamyonet ka = new Kamyonet();
                string Ad = txtAd.Text;
                string Soyad = txtSoyad.Text;
                string TcKimlik = txtTcKimlik.Text;
                string Telefon = txtTelefon.Text;
                ms.MusteriKayit(Ad, Soyad, TcKimlik, Telefon);
                //Kontrol yapıları if else
                if (txtAracTipi.Text=="Normal Araç")
                {
                
                    string AracTipi = txtAracTipi.Text;
                    string Plaka = txtPlaka.Text;
                    string Marka = txtMarka.Text;
                    string Model = txtModel.Text;
                    na.AracGiris(Plaka,Marka,Model,AracTipi);
                }
                else if (txtAracTipi.Text == "Kamyonet")
                {

                    string AracTipi = txtAracTipi.Text;
                    string Plaka = txtPlaka.Text;
                    string Marka = txtMarka.Text;
                    string Model = txtModel.Text;
                    ka.AracGiris(Plaka, Marka, Model, AracTipi);
                }

                if ((!string.IsNullOrWhiteSpace(txtAd.Text)) || (!!string.IsNullOrWhiteSpace(txtSoyad.Text)) || (!string.IsNullOrWhiteSpace(txtTcKimlik.Text)))
                {
                    if (txtAracTipi.Text=="Normal Araç")
                    {
                        dataGridView1.Rows.Add(new object[] { ms.Ad, ms.Soyad, ms.TcKimlik, ms.Telefon, na.Plaka, na.Marka, na.Model, na.Aractipi });
                    }
                    else if(txtAracTipi.Text == "Kamyonet")
                    {
                        dataGridView1.Rows.Add(new object[] { ms.Ad, ms.Soyad, ms.TcKimlik, ms.Telefon, ka.Plaka, ka.Marka, ka.Model, ka.Aractipi });
                    }
                   
                }

            }
            catch (Exception ec)
            {

                MessageBox.Show(ec.Message);
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Hata Kontrol Mekanizması try Catch
            try
            {

             
                double saat = Convert.ToDouble(numericUpDown1.Value);
                double fiyat = 5;
                //Nesne türetmek
                NormalArac na = new NormalArac(fiyat, saat);
                Kamyonet k = new Kamyonet(fiyat,saat);

                //Kontrol Yapıları Switch Case
                switch (txtAracTipi.Text)
                {
                    case "Normal Araç":
                        label4.Text = na.fiyatHesapla().ToString() + " ₺";
                        break;
                    case "Kamyonet":
                       label4.Text= k.fiyatHesapla().ToString()+" ₺";
                        break;
                    default:
                        break;
                }
                //Foreach Kullanımı
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.RemoveAt(row.Index);

                }
                //Kontrol yapıları if else
                if (dataGridView1.RowCount == 1)
                {
                    lblpark1.BackColor = Color.Lime;
                }
                else if (dataGridView1.RowCount == 2)
                {
                    lblPark2.BackColor = Color.Lime;
                }
                else if (dataGridView1.RowCount == 3)
                {
                    lblPark3.BackColor = Color.Lime;
                }
                else if (dataGridView1.RowCount == 4)
                {
                    lblPark4.BackColor = Color.Lime;
                }
                else if (dataGridView1.RowCount == 5)
                {
                    lblPark5.BackColor = Color.Lime;
                }
            }
            catch (Exception ec)
            {

                MessageBox.Show(ec.Message);
            }
        }

        private void form1_Load(object sender, EventArgs e)
        {
            //List Kullanımı
            List<string> AracTip = new List<string>();
            AracTip.Add("Normal Araç");
            AracTip.Add("Kamyonet");
            //Foreach Kullanımı
            foreach (var item in AracTip)
            {
                txtAracTipi.Items.Add(item);
            }
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}
