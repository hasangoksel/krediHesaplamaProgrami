using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace krediHesaplama
{
    public partial class Form1 : Form
    {
        double faizOrani = 1.89;
        double aylikOdeme = 0, toplamGeriOdeme = 0, krediTutari, krediPuani, vadeA, bankaKazanci;
        string krediTuru, vade;

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            label6.Text = "0";
            label10.Text = "... Ay";
            label12.Text = "0";
            label8.Text = "0";
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            krediTuru = comboBox2.Text;
            krediTutari = Convert.ToInt32(textBox2.Text);
            krediPuani = Convert.ToDouble(textBox1.Text);
            vade = comboBox1.Text;

            if (krediTuru == "İhtiyaç Kredisi")
            {
                if (krediPuani >= 1.2 )
                {
                    if (vade == "3 Ay" || vade == "6 Ay" || vade == "12 Ay" || vade == "36 Ay")
                    {
                        if (comboBox1.SelectedIndex == 0) vadeA = 3;
                        if (comboBox1.SelectedIndex == 1) vadeA = 6;
                        if (comboBox1.SelectedIndex == 2) vadeA = 12;
                        if (comboBox1.SelectedIndex == 3) vadeA = 36;
                        if (krediTutari <= 50000 && krediTutari >= 1000)
                        {
                            bankaKazanci = krediTutari * (faizOrani / 100) * vadeA;
                            toplamGeriOdeme = krediTutari + bankaKazanci;
                            aylikOdeme = toplamGeriOdeme / vadeA;
                            aylikOdeme = Math.Round(aylikOdeme, 2);
                            label6.Text = textBox2.Text;
                            label10.Text = vade.ToString();
                            label12.Text = aylikOdeme.ToString() + " ₺";
                            label8.Text = toplamGeriOdeme.ToString() + " ₺";
                        }
                        else
                        {
                            MessageBox.Show("İhtiyaç Kredisi -> 1.000-50.000 ", "Kredi Limit Uyarısı");
                        }
                    }
                    else
                    {
                        MessageBox.Show("İhtiyaç Kredisi -> 3-36 Ay", "Vade Uyarısı");
                    }
                }
                else if (krediPuani > 10)
                {
                    MessageBox.Show("Kredi Puanı Max. : 10", "Puan Uyarısı");
                }
                else
                {
                    MessageBox.Show("İhtiyaç Kredisi Min. Puan : 1.2", "Puan Uyarısı");
                }
            }
            else if (krediTuru == "Taşıt Kredisi")
            {
                if (krediPuani >= 2 )
                {
                    if (vade == "3 Ay" || vade == "6 Ay" || vade == "12 Ay" || vade == "36 Ay" || vade == "60 Ay")
                    {
                        if (comboBox1.SelectedIndex == 0) vadeA = 3;
                        if (comboBox1.SelectedIndex == 1) vadeA = 6;
                        if (comboBox1.SelectedIndex == 2) vadeA = 12;
                        if (comboBox1.SelectedIndex == 3) vadeA = 36;
                        if (comboBox1.SelectedIndex == 4) vadeA = 60;
                        if (krediTutari <= 124000 && krediTutari >= 1000)
                        {
                            bankaKazanci = krediTutari * (faizOrani / 100) * vadeA;
                            toplamGeriOdeme = krediTutari + bankaKazanci;
                            aylikOdeme = toplamGeriOdeme / vadeA;
                            aylikOdeme = Math.Round(aylikOdeme, 2);
                            label6.Text = textBox2.Text;
                            label10.Text = vade.ToString();
                            label12.Text = aylikOdeme.ToString() + " ₺";
                            label8.Text = toplamGeriOdeme.ToString() + " ₺";
                        }
                        else
                        {
                            MessageBox.Show("Taşıt Kredisi -> 1.000-124.000 ", "Kredi Limit Uyarısı");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Taşıt Kredisi -> 3-60 Ay", "Vade Uyarısı");
                    }
                }
                else if (krediPuani>10)
                {
                    MessageBox.Show("Kredi Puanı Max. : 10", "Puan Uyarısı");
                }
                else
                {
                    MessageBox.Show("Taşıt Kredisi Min. Puan : 2", "Puan Uyarısı");
                }
            }
            else if (krediTuru == "Konut Kredisi")
            {
                if (krediPuani >= 3 )
                {

                    if (comboBox1.SelectedIndex == 0) vadeA = 3;
                    if (comboBox1.SelectedIndex == 1) vadeA = 6;
                    if (comboBox1.SelectedIndex == 2) vadeA = 12;
                    if (comboBox1.SelectedIndex == 3) vadeA = 36;
                    if (comboBox1.SelectedIndex == 4) vadeA = 60;
                    if (comboBox1.SelectedIndex == 5) vadeA = 120;
                    if (krediTutari <= 284000 && krediTutari >= 1000)
                    {
                        bankaKazanci = krediTutari * (faizOrani / 100) * vadeA;
                        toplamGeriOdeme = krediTutari + bankaKazanci;
                        aylikOdeme = toplamGeriOdeme / vadeA;
                        aylikOdeme = Math.Round(aylikOdeme, 2);
                        label6.Text = textBox2.Text;
                        label10.Text = vade.ToString();
                        label12.Text = aylikOdeme.ToString() + " ₺";
                        label8.Text = toplamGeriOdeme.ToString() + " ₺";
                    }
                    else
                    {
                        MessageBox.Show("Konut Kredisi -> 1.000-284.000 ", "Kredi Limit Uyarısı");
                    }
                }
                else if (krediPuani > 10)
                {
                    MessageBox.Show("Kredi Puanı Max. : 10", "Puan Uyarısı");
                }
                else
                {
                    MessageBox.Show("Konut Kredisi Min. Puan : 3", "Puan Uyarısı");
                }
            }
            else if (krediTuru == "Evlilik Kredisi")
            {
                if (krediPuani >= 1.8)
                {
                    if (vade == "3 Ay" || vade == "6 Ay" || vade == "12 Ay" || vade == "36 Ay" || vade == "60 Ay")
                    {
                        if (comboBox1.SelectedIndex == 0) vadeA = 3;
                        if (comboBox1.SelectedIndex == 1) vadeA = 6;
                        if (comboBox1.SelectedIndex == 2) vadeA = 12;
                        if (comboBox1.SelectedIndex == 3) vadeA = 36;
                        if (comboBox1.SelectedIndex == 4) vadeA = 60;
                        if (krediTutari <= 98000 && krediTutari >= 1000)
                        {
                            bankaKazanci = krediTutari * (faizOrani / 100) * vadeA;
                            toplamGeriOdeme = krediTutari + bankaKazanci;
                            aylikOdeme = toplamGeriOdeme / vadeA;
                            aylikOdeme = Math.Round(aylikOdeme, 2);
                            label6.Text = textBox2.Text;
                            label10.Text = vade.ToString();
                            label12.Text = aylikOdeme.ToString() + " ₺";
                            label8.Text = toplamGeriOdeme.ToString() + " ₺";
                        }
                        else
                        {
                            MessageBox.Show("Evlilik Kredisi -> 1.000-98.000", "Kredi Limit Uyarısı");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Evlilik Kredisi -> 3-60 Ay", "Vade Uyarısı");
                    }
                }
                else if (krediPuani > 10)
                {
                    MessageBox.Show("Kredi Puanı Max. : 10", "Puan Uyarısı");
                }
                else
                {
                    MessageBox.Show("Evlilik Kredisi Min. Puan : 1.8", "Puan Uyarısı");
                }
            }
            else if (krediTuru == "Esnaf Kredisi")
            {
                if (krediPuani >= 2 )
                {
                    if (vade == "3 Ay" || vade == "6 Ay" || vade == "12 Ay" || vade == "36 Ay" || vade == "60 Ay")
                    {
                        if (comboBox1.SelectedIndex == 0) vadeA = 3;
                        if (comboBox1.SelectedIndex == 1) vadeA = 6;
                        if (comboBox1.SelectedIndex == 2) vadeA = 12;
                        if (comboBox1.SelectedIndex == 3) vadeA = 36;
                        if (comboBox1.SelectedIndex == 4) vadeA = 60;
                        if (krediTutari <= 150000 && krediTutari >= 1000)
                        {
                            bankaKazanci = krediTutari * (faizOrani / 100) * vadeA;
                            toplamGeriOdeme = krediTutari + bankaKazanci;
                            aylikOdeme = toplamGeriOdeme / vadeA;
                            aylikOdeme = Math.Round(aylikOdeme, 2);
                            label6.Text = textBox2.Text;
                            label10.Text = vade.ToString();
                            label12.Text = aylikOdeme.ToString() + " ₺";
                            label8.Text = toplamGeriOdeme.ToString() + " ₺";
                        }
                        else
                        {
                            MessageBox.Show("Esnaf Kredisi -> 1.000-150.000", "Kredi Limit Uyarısı");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Esnaf Kredisi -> 3-60 Ay", "Vade Uyarısı");
                    }
                }
                else if (krediPuani > 10)
                {
                    MessageBox.Show("Kredi Puanı Max. : 10", "Puan Uyarısı");
                }
                else
                {
                    MessageBox.Show("Esnaf Kredisi Min. Puan : 2", "Puan Uyarısı");
                }
            }
            else if (krediTuru == "Öğrenci Kredisi")
            {
                if (krediPuani >= 1.6 )
                {
                    if (vade == "3 Ay" || vade == "6 Ay" || vade == "12 Ay" )
                    {
                        if (comboBox1.SelectedIndex == 0) vadeA = 3;
                        if (comboBox1.SelectedIndex == 1) vadeA = 6;
                        if (comboBox1.SelectedIndex == 2) vadeA = 12;
                       
                        if (krediTutari <= 5000 && krediTutari >= 500)
                        {
                            bankaKazanci = krediTutari * (faizOrani / 100) * vadeA;
                            toplamGeriOdeme = krediTutari + bankaKazanci;
                            aylikOdeme = toplamGeriOdeme / vadeA;
                            aylikOdeme = Math.Round(aylikOdeme, 2);
                            label6.Text = textBox2.Text;
                            label10.Text = vade.ToString();
                            label12.Text = aylikOdeme.ToString() + " ₺";
                            label8.Text = toplamGeriOdeme.ToString() + " ₺";
                        }
                        else
                        {
                            MessageBox.Show("Öğrenci Kredisi -> 500-5.000", "Kredi Limit Uyarısı");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Öğrenci Kredisi -> 3-12 Ay", "Vade Uyarısı");
                    }
                }
                else if (krediPuani > 10)
                {
                    MessageBox.Show("Kredi Puanı Max. : 10", "Puan Uyarısı");
                }
                else
                {
                    MessageBox.Show("Öğrenci Kredisi Min. Puan : 1.6", "Puan Uyarısı");
                }
            }

        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("0-10 Aralığındaki Kredi Puanınızı Giriniz.", "Kredi Puanı");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //İhtiyaç Kredisi
            //Taşıt Kredisi
            //Konut Kredisi
            //Evlilik Kredisi
            //Esnaf Kredisi
            //Öğrenci Kredisi
            MessageBox.Show("İhtiyaç Kredisi -> 3-36 Ay\nTaşıt Kredisi -> 3-60 Ay\nKonut Kredisi -> 3-120 Ay\nEvlilik Kredisi -> 3-60 Ay\nEsnaf Kredisi -> 3-60 Ay\nÖğrenci Kredisi -> 3-12 Ay ", "Vade Seçenekleri");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İhtiyaç Kredisi -> 50.000\nTaşıt Kredisi -> 124.000\nKonut Kredisi -> 284.000\nEvlilik Kredisi -> 98.000\nEsnaf Kredisi -> 150.000\nÖğrenci Kredisi -> 5.000 ", "Kredi Üst Limitleri");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sonbahar Kredi Fırsatları Kapsamında Tüm Kredi Seçeneklerimizde Faiz Oranı % 1.89 Olarak Belirlenmiştir.", "Faiz Oranları");
        }
    }
}
