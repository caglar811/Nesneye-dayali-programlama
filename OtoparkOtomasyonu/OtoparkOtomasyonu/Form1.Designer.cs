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
namespace OtoparkOtomasyonu
{
    partial class form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button6 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtAracTipi = new System.Windows.Forms.ComboBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtTcKimlik = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.musteriAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriSoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriTelefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aracPlaka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aracMarkasi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aracModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aracinTipi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblpark1 = new System.Windows.Forms.Label();
            this.lblPark2 = new System.Windows.Forms.Label();
            this.lblPark3 = new System.Windows.Forms.Label();
            this.lblPark4 = new System.Windows.Forms.Label();
            this.lblPark5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1023, 440);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.numericUpDown1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Controls.Add(this.button8);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(1015, 414);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Müşteri Kabul";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.musteriAd,
            this.musteriSoyad,
            this.musteriTC,
            this.musteriTelefon,
            this.aracPlaka,
            this.aracMarkasi,
            this.aracModel,
            this.aracinTipi});
            this.dataGridView1.Location = new System.Drawing.Point(24, 303);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(850, 105);
            this.dataGridView1.TabIndex = 14;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(182, 234);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(82, 46);
            this.button6.TabIndex = 12;
            this.button6.Text = "Araç Çıkışı";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(54, 234);
            this.button8.Margin = new System.Windows.Forms.Padding(2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(82, 46);
            this.button8.TabIndex = 10;
            this.button8.Text = "Araç Girişi";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtAracTipi);
            this.groupBox4.Controls.Add(this.txtModel);
            this.groupBox4.Controls.Add(this.txtMarka);
            this.groupBox4.Controls.Add(this.txtPlaka);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Location = new System.Drawing.Point(325, 34);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(281, 196);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Araç Bilgileri";
            // 
            // txtAracTipi
            // 
            this.txtAracTipi.FormattingEnabled = true;
            this.txtAracTipi.Location = new System.Drawing.Point(102, 136);
            this.txtAracTipi.Margin = new System.Windows.Forms.Padding(2);
            this.txtAracTipi.Name = "txtAracTipi";
            this.txtAracTipi.Size = new System.Drawing.Size(92, 21);
            this.txtAracTipi.TabIndex = 12;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(102, 100);
            this.txtModel.Margin = new System.Windows.Forms.Padding(2);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(92, 20);
            this.txtModel.TabIndex = 11;
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(102, 63);
            this.txtMarka.Margin = new System.Windows.Forms.Padding(2);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(92, 20);
            this.txtMarka.TabIndex = 10;
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(102, 29);
            this.txtPlaka.Margin = new System.Windows.Forms.Padding(2);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(92, 20);
            this.txtPlaka.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 140);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Aracın Tipi :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 100);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Araç Modeli : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 65);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Araç Markası : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 29);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Araç Plakası : ";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtTelefon);
            this.groupBox5.Controls.Add(this.txtTcKimlik);
            this.groupBox5.Controls.Add(this.txtSoyad);
            this.groupBox5.Controls.Add(this.txtAd);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Location = new System.Drawing.Point(22, 34);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(261, 196);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Müşteri Bilgileri";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(118, 136);
            this.txtTelefon.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(89, 20);
            this.txtTelefon.TabIndex = 8;
            // 
            // txtTcKimlik
            // 
            this.txtTcKimlik.Location = new System.Drawing.Point(118, 98);
            this.txtTcKimlik.Margin = new System.Windows.Forms.Padding(2);
            this.txtTcKimlik.Name = "txtTcKimlik";
            this.txtTcKimlik.Size = new System.Drawing.Size(89, 20);
            this.txtTcKimlik.TabIndex = 7;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(118, 65);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(89, 20);
            this.txtSoyad.TabIndex = 6;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(118, 25);
            this.txtAd.Margin = new System.Windows.Forms.Padding(2);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(89, 20);
            this.txtAd.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 140);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Telefon Numarası : ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(4, 100);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "T.C Kimlik Numarası : ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(4, 65);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "Soyadı : ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(4, 29);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(31, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "Adı : ";
            // 
            // groupBox6
            // 
            this.groupBox6.Location = new System.Drawing.Point(363, 0);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox6.Size = new System.Drawing.Size(206, 196);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "groupBox6";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblPark5);
            this.tabPage2.Controls.Add(this.lblPark4);
            this.tabPage2.Controls.Add(this.lblPark3);
            this.tabPage2.Controls.Add(this.lblPark2);
            this.tabPage2.Controls.Add(this.lblpark1);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(1015, 414);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Otopark Kat : 1";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(634, 123);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Otopark Girişi";
            // 
            // musteriAd
            // 
            this.musteriAd.HeaderText = "MusteriAd";
            this.musteriAd.Name = "musteriAd";
            // 
            // musteriSoyad
            // 
            this.musteriSoyad.HeaderText = "MusteriSoyad";
            this.musteriSoyad.Name = "musteriSoyad";
            // 
            // musteriTC
            // 
            this.musteriTC.HeaderText = "MusteriTC";
            this.musteriTC.Name = "musteriTC";
            // 
            // musteriTelefon
            // 
            this.musteriTelefon.HeaderText = "MusteriTelefon";
            this.musteriTelefon.Name = "musteriTelefon";
            // 
            // aracPlaka
            // 
            this.aracPlaka.HeaderText = "AracPlaka";
            this.aracPlaka.Name = "aracPlaka";
            // 
            // aracMarkasi
            // 
            this.aracMarkasi.HeaderText = "AraçMarkası";
            this.aracMarkasi.Name = "aracMarkasi";
            // 
            // aracModel
            // 
            this.aracModel.HeaderText = "AraçModeli";
            this.aracModel.Name = "aracModel";
            // 
            // aracinTipi
            // 
            this.aracinTipi.HeaderText = "AracTipi";
            this.aracinTipi.Name = "aracinTipi";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(344, 249);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 15;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(358, 234);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kaç Saat Durdu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(578, 251);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "0";
            // 
            // lblpark1
            // 
            this.lblpark1.AutoSize = true;
            this.lblpark1.BackColor = System.Drawing.Color.Lime;
            this.lblpark1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblpark1.Location = new System.Drawing.Point(522, 116);
            this.lblpark1.Name = "lblpark1";
            this.lblpark1.Size = new System.Drawing.Size(68, 25);
            this.lblpark1.TabIndex = 33;
            this.lblpark1.Text = "Park1";
            // 
            // lblPark2
            // 
            this.lblPark2.AutoSize = true;
            this.lblPark2.BackColor = System.Drawing.Color.Lime;
            this.lblPark2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPark2.Location = new System.Drawing.Point(448, 116);
            this.lblPark2.Name = "lblPark2";
            this.lblPark2.Size = new System.Drawing.Size(68, 25);
            this.lblPark2.TabIndex = 33;
            this.lblPark2.Text = "Park2";
            // 
            // lblPark3
            // 
            this.lblPark3.AutoSize = true;
            this.lblPark3.BackColor = System.Drawing.Color.Lime;
            this.lblPark3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPark3.Location = new System.Drawing.Point(374, 116);
            this.lblPark3.Name = "lblPark3";
            this.lblPark3.Size = new System.Drawing.Size(68, 25);
            this.lblPark3.TabIndex = 33;
            this.lblPark3.Text = "Park3";
            // 
            // lblPark4
            // 
            this.lblPark4.AutoSize = true;
            this.lblPark4.BackColor = System.Drawing.Color.Lime;
            this.lblPark4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPark4.Location = new System.Drawing.Point(300, 116);
            this.lblPark4.Name = "lblPark4";
            this.lblPark4.Size = new System.Drawing.Size(68, 25);
            this.lblPark4.TabIndex = 33;
            this.lblPark4.Text = "Park4";
            // 
            // lblPark5
            // 
            this.lblPark5.AutoSize = true;
            this.lblPark5.BackColor = System.Drawing.Color.Lime;
            this.lblPark5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPark5.Location = new System.Drawing.Point(226, 116);
            this.lblPark5.Name = "lblPark5";
            this.lblPark5.Size = new System.Drawing.Size(68, 25);
            this.lblPark5.TabIndex = 33;
            this.lblPark5.Text = "Park5";
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 440);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "form1";
            this.Text = "Otopark Takip Otomasyonu";
            this.Load += new System.EventHandler(this.form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox txtAracTipi;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.TextBox txtPlaka;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtTcKimlik;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriSoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriTelefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn aracPlaka;
        private System.Windows.Forms.DataGridViewTextBoxColumn aracMarkasi;
        private System.Windows.Forms.DataGridViewTextBoxColumn aracModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn aracinTipi;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPark5;
        private System.Windows.Forms.Label lblPark4;
        private System.Windows.Forms.Label lblPark3;
        private System.Windows.Forms.Label lblPark2;
        private System.Windows.Forms.Label lblpark1;
    }
}

