using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hesap_Makinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float değerTutucu = 0;
        string islem ="";
        bool sıfırlama = true;
        float ikinci = 0; //tpçb işlemleri için şimdilik
        bool tıklama = true;
        bool tıklama2 = true;
        bool eksiarti = true;
        bool eksiarti2 = true;
        double eksiartisayac = 3;

        private void Form1_Load(object sender, EventArgs e)
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
                    textBox2.Text =değerTutucu.ToString() + " + ";
                    sıfırlama = false;
                }
            }
            
            
            

        }

        private void button_esittir_Click(object sender, EventArgs e)
        {

            

            if (tıklama)
            {
                ikinci = float.Parse( textBox1.Text);
                tıklama = false;

            }
            else
            {     
                //BURASI İLK TIKLAMADA SAYIYI ALMAK İÇİN
            }
            
            if (textBox1.Text =="")
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
            //pozitif negatif nasıl çalıoştı anlamadım
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
                        textBox2.Text =" - " +  (-değerTutucu).ToString() + " * ";
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
                    if (textBox2.Text == "" ||  textBox2.Text == " - ")
                    {
                        değerTutucu = -float.Parse(textBox1.Text);
                        textBox2.Text =" - " +  (-değerTutucu).ToString() + " / ";
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

        private void button_kare_Click(object sender, EventArgs e)
        {
            float kare = 0;
            kare = float.Parse(textBox1.Text) * float.Parse(textBox1.Text);
            textBox2.Text = kare.ToString();
            sıfırlama = false;


        }

        private void button10_Click(object sender, EventArgs e)
        {
            //substirng gibi ifadelerle çok çalışmadığım için burada yapay zekdan yardım aldım

            eksiartisayac++;

            if ( eksiartisayac%2 == 0 )
            {
                textBox2.Text = " - ";
                eksiarti2 = false;
            }
            else
            {
                textBox2.Text = " + ";
                eksiarti2 = true;

            }
            /*
            if (eksiarti)
            {
                if (textBox1.Text == "" || textBox1.Text == " + " || textBox1.Text == " - ")
                {
                    textBox1.Text = " - ";
                    eksiarti = false;
                    eksiarti2 = false;
                }
                else
                {
                    if (textBox1.Text.StartsWith(" + "))
                    {
                        textBox1.Text = " - " + textBox1.Text.Substring(3);
                        eksiarti2 = false;
                    }
                    else if (textBox1.Text.StartsWith(" - "))
                    {
                        textBox1.Text = " + " + textBox1.Text.Substring(3);
                        eksiarti2 = true;

                    }
                    else
                    {
                        textBox1.Text = " - " + textBox1.Text;
                        eksiarti2 = false;

                    }
                }
            }
            else
            {
                if (textBox1.Text == " - ")
                {
                    textBox1.Text = " + ";
                    eksiarti = true;
                    eksiarti2 = true;

                }
                else
                {
                    if (textBox1.Text.StartsWith(" - "))
                    {
                        textBox1.Text = " + " + textBox1.Text.Substring(3);
                        eksiarti2 = true;

                    }
                    else if (textBox1.Text.StartsWith(" + "))
                    {
                        textBox1.Text = " - " + textBox1.Text.Substring(3);
                        eksiarti2 = false;

                    }
                    else
                    {
                        textBox1.Text = " + " + textBox1.Text;
                        eksiarti2 = true;

                    }
                    eksiarti = true;
                }
            }
            /*
            string tutucu = textBox1.Text;

            if (eksiarti)
            {
                if (textBox1.Text == "" || textBox1.Text == " + ")
                {
                    textBox1.Text = " - ";
                    eksiarti = false;                  
                }
                else
                {
                    if (eksiarti2)
                    {
                        textBox1.Text = " - " + tutucu;
                        eksiarti = false;
                        eksiarti2 = false;
                    }
                    else
                    {
                        textBox1.Text = " + " + tutucu;
                    }
                                     
                }
            }
            else
            {
                if (textBox1.Text == " - " )
                {
                    textBox1.Text = " + ";
                    eksiarti = true;
                }
                else
                {
                    textBox1.Text = " + " + textBox1.Text;
                    eksiarti = true;
                }
                
            }
            */

        }

        private void button_semiclear_Click(object sender, EventArgs e)
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

        private void button_fullclear_Click(object sender, EventArgs e)
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

        private void button24_Click(object sender, EventArgs e)
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

        private void button_bölen_Click(object sender, EventArgs e)
        {

        }

        private void button_yüzde_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            button_standart.Enabled = false;
        }

        private void button_bilimsel_Click_1(object sender, EventArgs e)
        {
            Bilimsel bilimsel = new Bilimsel();
            this.Hide();
            bilimsel.Show();

        }

        private void button_geri_Click(object sender, EventArgs e)
        {
            panel1.Visible=false;
        }
    }
}
