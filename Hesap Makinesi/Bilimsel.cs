using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_Makinesi
{
    public partial class Bilimsel : Form
    {
        public Bilimsel()
        {
            InitializeComponent();
        }

        float değerTutucu = 0;
        string islem = "";
        bool sıfırlama = true;
        float ikinci = 0; //tpçb işlemleri için şimdilik
        bool tıklama = true;
        bool tıklama2 = true;
        bool eksiarti = true;
        bool eksiarti2 = true;
        double eksiartisayac = 3;

        private void Bilimsel_Load(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sıfırlama)
            {
                textBox1.Text += 1.ToString();
            }
            else
            {
                textBox1.Text = "";
                sıfırlama = true;
                textBox1.Text = 1.ToString();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (sıfırlama)
            {
                textBox1.Text += 2.ToString();
            }
            else
            {
                textBox1.Text = "";
                sıfırlama = true;
                textBox1.Text = 2.ToString();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (sıfırlama)
            {
                textBox1.Text += 3.ToString();
            }
            else
            {
                textBox1.Text = "";
                sıfırlama = true;
                textBox1.Text = 3.ToString();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (sıfırlama)
            {
                textBox1.Text += 4.ToString();
            }
            else
            {
                textBox1.Text = "";
                sıfırlama = true;
                textBox1.Text = 4.ToString();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (sıfırlama)
            {
                textBox1.Text += 5.ToString();
            }
            else
            {
                textBox1.Text = "";
                sıfırlama = true;
                textBox1.Text = 5.ToString();
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (sıfırlama)
            {
                textBox1.Text += 6.ToString();
            }
            else
            {
                textBox1.Text = "";
                sıfırlama = true;
                textBox1.Text = 6.ToString();
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (sıfırlama)
            {
                textBox1.Text += 7.ToString();
            }
            else
            {
                textBox1.Text = "";
                sıfırlama = true;
                textBox1.Text = 7.ToString();
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (sıfırlama)
            {
                textBox1.Text += 8.ToString();
            }
            else
            {
                textBox1.Text = "";
                sıfırlama = true;
                textBox1.Text = 8.ToString();
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (sıfırlama)
            {
                textBox1.Text += 9.ToString();
            }
            else
            {
                textBox1.Text = "";
                sıfırlama = true;
                textBox1.Text = 9.ToString();
            }

        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {

            }
            else
            {
                if (sıfırlama)
                {
                    textBox1.Text += 0.ToString();
                }
                else
                {
                    textBox1.Text = "";
                    sıfırlama = true;
                    textBox1.Text = 0.ToString();
                }
            }
        }

        private void button_arti_Click(object sender, EventArgs e)
        {
            islem = "toplama";
            textBox2.Text = "";
            if (eksiarti2)
            {
                //Burası pozitif kısım için
                if (textBox1.Text == "")
                {

                }
                else
                {
                    textBox2.Text = "";
                    değerTutucu += float.Parse(textBox1.Text);
                    textBox2.Text = değerTutucu.ToString() + " + ";
                    sıfırlama = false;
                }
            }
            else
            {
                //Burası negatif kısım için artık eksi olayı 
                if (textBox1.Text == "")
                {

                }
                else
                {
                    textBox2.Text = "";
                    değerTutucu -= float.Parse(textBox1.Text);
                    textBox2.Text = değerTutucu.ToString() + " + ";
                    sıfırlama = false;
                }
            }
        }

        private void button_esittir_Click(object sender, EventArgs e)
        {
            if (tıklama)
            {
                ikinci = float.Parse(textBox1.Text);
                tıklama = false;

            }
            else
            {
                //BURASI İLK TIKLAMADA SAYIYI ALMAK İÇİN
            }

            if (textBox1.Text == "")
            {

            }
            else
            {
                if (islem == "")
                {

                }
                else if (islem == "toplama")
                {
                    if (tıklama2)
                    {

                        textBox2.Text += ikinci;
                        textBox1.Text = (değerTutucu + ikinci).ToString();
                        tıklama2 = false;
                        değerTutucu = değerTutucu + ikinci;


                    }
                    else if (tıklama2 == false)
                    {

                        değerTutucu += ikinci;
                        textBox2.Text = (textBox1.Text + " + " + ikinci.ToString());
                        textBox1.Text = (değerTutucu).ToString();


                    }
                }
                else if (islem == "çıkarma")
                {
                    if (tıklama2)
                    {

                        textBox2.Text += ikinci;
                        textBox1.Text = (değerTutucu - ikinci).ToString();
                        tıklama2 = false;
                        değerTutucu = değerTutucu - ikinci;


                    }
                    else if (tıklama2 == false)
                    {

                        değerTutucu -= ikinci;
                        textBox2.Text = (textBox1.Text + " - " + ikinci.ToString());
                        textBox1.Text = (değerTutucu).ToString();


                    }


                }
                else if (islem == "çarpma")
                {
                    textBox1.Text = (değerTutucu * float.Parse(textBox1.Text)).ToString();
                }
                else if (islem == "bölme")
                {
                    textBox1.Text = (değerTutucu / float.Parse(textBox1.Text)).ToString();
                }

            }
        }

        private void button_eksi_Click(object sender, EventArgs e)
        {
            islem = "çıkarma";
            if (eksiarti2)
            {
                if (textBox1.Text == "")
                {

                }
                else
                {
                    if (textBox2.Text == "" || textBox2.Text == " + ")
                    {
                        değerTutucu = float.Parse(textBox1.Text);
                        textBox2.Text = değerTutucu.ToString() + " - ";
                        sıfırlama = false;
                    }
                    else
                    {
                        değerTutucu -= float.Parse(textBox1.Text);
                        textBox2.Text = değerTutucu.ToString() + " - ";

                        sıfırlama = false;

                    }
                }
                textBox1.Text = "";
            }
            else
            {
                if (textBox1.Text == "")
                {

                }
                else
                {
                    if (textBox2.Text == "")
                    {
                        değerTutucu = float.Parse(textBox1.Text);
                        textBox2.Text = değerTutucu.ToString() + " - ";
                        sıfırlama = false;
                    }
                    else
                    {
                        değerTutucu -= float.Parse(textBox1.Text);
                        textBox2.Text = değerTutucu.ToString() + " - ";

                        sıfırlama = false;

                    }
                }
                textBox1.Text = "";
            }
        }

        private void button_carpi_Click(object sender, EventArgs e)
        {
            islem = "çarpma";
            if (eksiarti2)
            {
                if (textBox1.Text == "")
                {

                }
                else
                {
                    if (textBox2.Text == "" || textBox2.Text == " + ")
                    {
                        değerTutucu = float.Parse(textBox1.Text);
                        textBox2.Text = değerTutucu.ToString() + " * ";
                    }
                    else
                    {
                        değerTutucu *= float.Parse(textBox1.Text);
                        textBox2.Text = değerTutucu.ToString() + " * ";
                        textBox1.Text = "";
                        sıfırlama = false;

                    }

                    textBox1.Text = "";
                }
            }
            else
            {
                if (textBox1.Text == "")
                {

                }
                else
                {
                    if (textBox2.Text == "" || textBox2.Text == " + " || textBox2.Text == " - ")
                    {
                        değerTutucu = -float.Parse(textBox1.Text);
                        textBox2.Text = " - " + (-değerTutucu).ToString() + " * ";
                    }
                    else
                    {
                        değerTutucu *= float.Parse(textBox1.Text);
                        textBox2.Text = değerTutucu.ToString() + " * ";
                        textBox1.Text = "";
                        sıfırlama = false;

                    }

                    textBox1.Text = "";
                }
            }
        }

        private void button_bölme_Click(object sender, EventArgs e)
        {
            islem = "bölme";
            if (eksiarti2)
            {
                if (textBox1.Text == "")
                {

                }
                else
                {
                    if (textBox2.Text == "" || textBox2.Text == " + ")
                    {
                        değerTutucu = float.Parse(textBox1.Text);
                        textBox2.Text = değerTutucu.ToString() + " / ";
                    }
                    else
                    {
                        değerTutucu /= float.Parse(textBox1.Text);
                        textBox2.Text = değerTutucu.ToString() + " / ";
                        textBox1.Text = "";
                        sıfırlama = false;

                    }

                    textBox1.Text = "";
                }
            }
            else
            {
                if (textBox1.Text == "")
                {

                }
                else
                {
                    if (textBox2.Text == "" || textBox2.Text == " - ")
                    {
                        değerTutucu = -float.Parse(textBox1.Text);
                        textBox2.Text = " - " + (-değerTutucu).ToString() + " / ";
                    }
                    else
                    {
                        değerTutucu /= float.Parse(textBox1.Text);
                        textBox2.Text = değerTutucu.ToString() + " / ";
                        textBox1.Text = "";
                        sıfırlama = false;

                    }

                    textBox1.Text = "";
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            float kare = 0;
            kare = float.Parse(textBox1.Text) * float.Parse(textBox1.Text);
            textBox2.Text = kare.ToString();
            sıfırlama = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            eksiartisayac++;

            if (eksiartisayac % 2 == 0)
            {
                textBox2.Text = " - ";
                eksiarti2 = false;
            }
            else
            {
                textBox2.Text = " + ";
                eksiarti2 = true;

            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            değerTutucu = 0;
            islem = "";
            sıfırlama = true;
            ikinci = 0; //tpçb işlemleri için şimdilik
            tıklama = true;
            tıklama2 = true;
            eksiarti = true;
            eksiarti2 = true;
            eksiartisayac = 3;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {

            }
            else
            {
                if (textBox1.Text.Length > 0)
                {
                    textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                    // İmleci en sona taşımak için
                    textBox1.SelectionStart = textBox1.Text.Length;
                }

            }
        }

        private void button_virgül_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(","))
            {
                textBox1.Text += ",";
            }
        }

        private void button_yüzde_Click(object sender, EventArgs e)
        {

        }
    }
}
