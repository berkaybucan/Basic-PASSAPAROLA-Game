using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passaparola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int soruno = 0, dogru = 0, yanlis = 0,kalansoru=23;

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode ==Keys.Enter)
            {
                switch(soruno)
                {
                    case 1:
                        if (textBox1.Text =="akdeniz")
                        {
                            dogru++;
                            btnA.BackColor = Color.Green;
                        }
                        else
                        {
                            yanlis++;
                            btnA.BackColor = Color.Red;
                        }
                            break;
                    case 2:
                        if (textBox1.Text == "bam")
                        {
                            dogru++;
                            btnB.BackColor = Color.Green;
                        }
                        else
                        {
                            yanlis++;
                            btnB.BackColor = Color.Red;
                        }
                        break;

                    case 3:
                        if (textBox1.Text == "cazgır")
                        {
                            dogru++;
                            btnC.BackColor = Color.Green;
                        }
                        else
                        {
                            yanlis++;
                            btnC.BackColor = Color.Red;
                        }
                        break;
                    case 4:
                        if (textBox1.Text == "dağcılık")
                        {
                            dogru++;
                            btnD.BackColor = Color.Green;
                        }
                        else
                        {
                            yanlis++;
                            btnD.BackColor = Color.Red;
                        }
                        break;
                    case 5:
                        if (textBox1.Text == "erzurum")
                        {
                            dogru++;
                            btnE.BackColor = Color.Green;
                        }
                        else
                        {
                            yanlis++;
                            btnE.BackColor = Color.Red;
                        }
                        break;
                    case 6:
                        if (textBox1.Text == "fil")
                        {
                            dogru++;
                            btnF.BackColor = Color.Green;
                        }
                        else
                        {
                            yanlis++;
                            btnF.BackColor = Color.Red;
                        }
                        break;
                    case 7:
                        if (textBox1.Text == "google")
                        {
                            dogru++;
                            btnG.BackColor = Color.Green;
                        }
                        else
                        {
                            yanlis++;
                            btnG.BackColor = Color.Red;
                        }
                        break;
                    case 8:
                        if (textBox1.Text == "hipokrat")
                        {
                            dogru++;
                            btnH.BackColor = Color.Green;
                        }
                        else
                        {
                            yanlis++;
                            btnH.BackColor = Color.Red;
                        }
                        break;
                    case 9:
                        if (textBox1.Text == "ısırgan")
                        {
                            dogru++;
                            btnI.BackColor = Color.Green;
                        }
                        else
                        {
                            yanlis++;
                            btnI.BackColor = Color.Red;
                        }
                        break;
                    case 10:
                        if (textBox1.Text == "imece")
                        {
                            dogru++;
                            btnİ.BackColor = Color.Green;
                        }
                        else
                        {
                            yanlis++;
                            btnİ.BackColor = Color.Red;
                        }
                        break;
                    case 11:
                        if (textBox1.Text == "jüpiter")
                        {
                            dogru++;
                            btnJ.BackColor = Color.Green;
                        }
                        else
                        {
                            yanlis++;
                            btnJ.BackColor = Color.Red;
                        }
                        break;
                    case 12:
                        if (textBox1.Text == "kokpit")
                        {
                            dogru++;
                            btnK.BackColor = Color.Green;
                        }
                        else
                        {
                            yanlis++;
                            btnK.BackColor = Color.Red;
                        }
                        break;

                    case 13:
                        if (textBox1.Text == "lizbon")
                        {
                            dogru++;
                            btnL.BackColor = Color.Green;
                        }
                        else
                        {
                            yanlis++;
                            btnL.BackColor = Color.Red;
                        }
                        break;
                    case 14:
                        if (textBox1.Text == "miyop")
                        {
                            dogru++;
                            btnM.BackColor = Color.Green;
                        }
                        else
                        {
                            yanlis++;
                            btnM.BackColor = Color.Red;
                        }
                        break;
                    case 15:
                        if (textBox1.Text == "nar")
                        {
                            dogru++;
                            btnN.BackColor = Color.Green;
                        }
                        else
                        {
                            yanlis++;
                            btnN.BackColor = Color.Red;
                        }
                        break;
                    case 16:
                        if (textBox1.Text == "ozon")
                        {
                            dogru++;
                            btnO.BackColor = Color.Green;
                        }
                        else
                        {
                            yanlis++;
                            btnO.BackColor = Color.Red;
                        }
                        break;
                    case 17:
                        if (textBox1.Text == "patlıcan")
                        {
                            dogru++;
                            btnP.BackColor = Color.Green;
                        }
                        else
                        {
                            yanlis++;
                            btnP.BackColor = Color.Red;
                        }
                        break;
                    case 18:
                        if (textBox1.Text == "rusya")
                        {
                            dogru++;
                            btnR.BackColor = Color.Green;
                        }
                        else
                        {
                            yanlis++;
                            btnR.BackColor = Color.Red;
                        }
                        break;
                    case 19:
                        if (textBox1.Text == "samsung")
                        {
                            dogru++;
                            btnS.BackColor = Color.Green;
                        }
                        else
                        {
                            yanlis++;
                            btnS.BackColor = Color.Red;
                        }
                        break;
                    case 20:
                        if (textBox1.Text == "tarkan")
                        {
                            dogru++;
                            btnT.BackColor = Color.Green;
                        }
                        else
                        {
                            yanlis++;
                            btnT.BackColor = Color.Red;
                        }
                        break;
                    case 21:
                        if (textBox1.Text == "uyluk")
                        {
                            dogru++;
                            btnU.BackColor = Color.Green;
                        }
                        else
                        {
                            yanlis++;
                            btnU.BackColor = Color.Red;
                        }
                        break;
                    case 22:
                        if (textBox1.Text == "van")
                        {
                            dogru++;
                            btnV.BackColor = Color.Green;
                        }
                        else
                        {
                            yanlis++;
                            btnV.BackColor = Color.Red;
                        }
                        break;
                    case 23:
                        if (textBox1.Text == "yenidoğan")
                        {
                            dogru++;
                            btnY.BackColor = Color.Green;
                        }
                        else
                        {
                            yanlis++;
                            btnY.BackColor = Color.Red;
                        }
                        break;
                    case 24:
                        if (textBox1.Text == "zonguldak")
                        {
                            dogru++;
                            btnZ.BackColor = Color.Green;
                        }
                        else
                        {
                            yanlis++;
                            btnZ.BackColor = Color.Red;
                        }
                        break;
                }
            }
        }

        private void Cevapla_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblDogru.Text = Convert.ToString(dogru);
            LblYanlis.Text = Convert.ToString(yanlis);
            LblKalanSoru.Text = Convert.ToString(kalansoru);
            Cevapla.Text = "Sıradaki Soru";
            kalansoru--;
            soruno++;
            if (soruno>24)
            {
                MessageBox.Show("Tebrikler ! Oyunumuzun Sonuna Geldik \n Aşağıdaki Skorlarla Oyunu Bitirdiniz : \n Doğru Cevap Sayısı :" + dogru + "\n Yanlış Cevap Sayısı :" + yanlis +"\n Boş Cevap Sayısı :"+(24-(dogru+yanlis))+ " \n 30 Saniye Sonra Bilgi Ekranı ve Oyun Kapanacaktır");
            }
            this.Text = soruno.ToString();
            if (soruno==1)
            {
                btnGenel.Text = btnA.Text;
                richTextBox1.Text = "Ülkemizdeki denizlerden hangisinde ne çok balık bulunur ?"; //Akdeniz
                btnA.BackColor = Color.Yellow;

            }
            if (soruno == 2)
            {
                btnGenel.Text = btnB.Text;
                richTextBox1.Text = "Telli çalgılarda sazların en kalın telinin adı nedir ?"; //Bam
                btnB.BackColor = Color.Yellow;
            }
            if (soruno == 3)
            {
                btnGenel.Text = btnC.Text;
                richTextBox1.Text = "Yağlı güreşte pehlivanları yüksek bir sesle izleyicilere tanıtan ve dua okuyarak onları alana süren kimseye ne ad verilir?";//Cazgır
                btnC.BackColor = Color.Yellow;
            }
            if (soruno == 4)
            {
                btnGenel.Text = btnD.Text;
                richTextBox1.Text = "Alpinizm ne demektir?"; //Dağcılık
                btnD.BackColor = Color.Yellow;

            }
            if (soruno == 5)
            {
                btnGenel.Text = btnE.Text;
                richTextBox1.Text = " 2011 Dünya Üniversitelerarası Kış Olimpiyatları Türkiye'nin  hangi ilinde yapılmıştır? ?";//Erzurum
                btnE.BackColor = Color.Yellow;
            }
            if (soruno == 6)
            {
                btnGenel.Text = btnF.Text;
                richTextBox1.Text = "Zıplayamayan tek memeli hayvan nedir ? ?"; //Fil
                btnF.BackColor = Color.Yellow;
            }
            if (soruno == 7)
            {
                btnGenel.Text = btnG.Text;
                richTextBox1.Text = " Dünyada genel olarak internet üzerinde en fazla kullanılan arama motoru hangisidir ?";//Google
                btnG.BackColor = Color.Yellow;

            }
            if (soruno == 8)
            {
                btnGenel.Text = btnH.Text;
                richTextBox1.Text = " Bugün bile adına tıp yemini edilen İspanyol tıp bilgini kimdir ? ";//Hipokrat
                btnH.BackColor = Color.Yellow;
            }
            if (soruno == 9)
            {
                btnGenel.Text = btnI.Text;
                richTextBox1.Text = "Dokunduğumuzda Kaşındıran Ot Hangi Ottur? "; //Isırgan
                btnI.BackColor = Color.Yellow;
            }
            if (soruno == 10)
            {
                btnGenel.Text = btnİ.Text;
                richTextBox1.Text = "Köylülerin el birliği ile köyün işini birlikte yapmalarına ne ad verilir ?";//İmece
                btnİ.BackColor = Color.Yellow;

            }
            if (soruno == 11)
            {
                btnGenel.Text = btnJ.Text;
                richTextBox1.Text = "En büyük uyduya sahip olan gezegen hangisidir ?"; //Jupiter
                btnJ.BackColor = Color.Yellow;
            }
            if (soruno == 12)
            {
                btnGenel.Text = btnK.Text;
                richTextBox1.Text = "Uçaklardaki pilot kabinine verilen isim nedir ?"; //Kokpit
                btnK.BackColor = Color.Yellow;
            }
            if (soruno == 13)
            {
                btnGenel.Text = btnL.Text;
                richTextBox1.Text = "Portekiz'in başkenti nedir?"; //Lizbon
                btnL.BackColor = Color.Yellow;
            }
            if (soruno == 14)
            {
                btnGenel.Text = btnM.Text;
                richTextBox1.Text = "Uzağı görememe kusuru nedir ?"; //Miyop
                btnM.BackColor = Color.Yellow;

            }
            if (soruno == 15)
            {
                btnGenel.Text = btnN.Text;
                richTextBox1.Text = "Pazardan aldım bir tane eve geldim bin tane ?"; //Nar
                btnN.BackColor = Color.Yellow;
            }
            if (soruno == 16)
            {
                btnGenel.Text = btnO.Text;
                richTextBox1.Text = "Biyosferi Güneşin Zararlı Işınlarından Koruyan Gaz Hangisidir?"; //Ozon
                btnO.BackColor = Color.Yellow;
            }
            if (soruno == 17)
            {
                btnGenel.Text = btnP.Text;
                richTextBox1.Text = "İmam Bayıldı Yemeğinin Ana Malzemesi Nedir? ";//Patlıcan
                btnP.BackColor = Color.Yellow;

            }
            if (soruno == 18)
            {
                btnGenel.Text = btnR.Text;
                richTextBox1.Text = "Yüzölçümü en büyük olan dünya ülkesi nedir ?"; //Rusya
                btnR.BackColor = Color.Yellow;
            }
            if (soruno == 19)
            {
                btnGenel.Text = btnS.Text;
                richTextBox1.Text = "Güney Kore'deki en büyük teknoloji şirketinin adı nedir?"; //Samsung
                btnS.BackColor = Color.Yellow;
            }
            if (soruno == 20)
            {
                btnGenel.Text = btnT.Text;
                richTextBox1.Text = "Kuzu Kuzu Kimin Şarkısıdır  ?"; //Tarkan
                btnT.BackColor = Color.Yellow;

            }
            if (soruno == 21)
            {
                btnGenel.Text = btnU.Text;
                richTextBox1.Text = "Bacağın kalçadan dize kadar olan bölümüne ne ad verilir  ?"; //Uyluk
                btnU.BackColor = Color.Yellow;
            }
            if (soruno == 22)
            {
                btnGenel.Text = btnV.Text;
                richTextBox1.Text = "23 Ekim ve 9 Kasımda yaşanan sarsıcı deprem Türkiye'nin hangi ilinde görülmüştür ?"; //Van
                btnV.BackColor = Color.Yellow;
            }
            if (soruno == 23)
            {
                btnGenel.Text = btnY.Text;
                richTextBox1.Text = "0-28 günlük bebeklere ne isim verilir? ?"; //Yenidoğan
                btnY.BackColor = Color.Yellow;
            }
            if (soruno == 24)
            {
                btnGenel.Text = btnZ.Text;
                richTextBox1.Text = "Koronavirüs önlemlerinde 30 büyükşehirle birlikte Türkiye'nin hangi şehri sokağa çıkma kısıtlamasına maruz kalmıştır ?"; //Zonguldak
                btnZ.BackColor = Color.Yellow;
            }

        }
    }
}
