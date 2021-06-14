using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace skolniProjektPVA
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        //pole s jednotlivými znaky hiragany a jejich přepisu
        string[] hira = new string[] { "あ", "い", "う", "え", "お", "か", "き", "く", "け", "こ", "さ", "し", "す", "せ", "そ", "た", "ち", "つ", "て", "と", "な", "に", "ぬ", "ね", "の", "は", "ひ", "ふ", "へ", "ほ", "ま", "み", "む", "め", "も", "や", "ゆ", "よ", "ら", "り", "る", "れ", "ろ", "わ", "を", "ん", "v" };
        string[] romanji = new string[] { "a", "i", "u", "e", "o", "ka", "ki", "ku", "ke", "ko", "sa", "shi", "su", "se", "so", "ta", "chi", "cu", "te", "to", "na", "ni", "nu", "ne", "no", "ha", "hi", "fu", "he", "ho", "ma", "mi", "mu", "me", "mo", "ja", "ju", "jo", "ra", "ri", "ru", "re", "ro", "wa", "wo", "n", "vvv" };
        Random random = new Random();
        int steps = 0;

        private void button5_Click(object sender, EventArgs e)
        {
            (new Form2()).Show();
            this.Hide();
        }

        private void ClickIt(object sender, EventArgs e)
        {
            Button bu = sender as Button;
            //pokud je v tagu tlačítka n nastane chyba
            if (bu.Tag.ToString() == "n")
            {
                //převod hexadecimálních barev na (nejspíš) RGB
                textBox1.BackColor = ColorTranslator.FromHtml("#DA627D");
                User.mis += 1;
            }
            else
            {
                textBox1.BackColor = ColorTranslator.FromHtml("#699156");
                User.ok += 1;
                steps += 1;
                //vygenerování nových znaků, steps určuje zda se má znovu generovat nebo ponechat
                int randomB = random.Next(1, 4);
                switch (randomB)
                {
                    case 1:
                        button1.Tag = Generate.GetDoble("ok1", steps).ToString();
                        button1.Text = romanji[Generate.GetDoble("ok1", steps)] + romanji[Generate.GetDoble("ok2", steps)];
                        textBox1.Text = hira[Generate.GetDoble("ok1", steps)] + hira[Generate.GetDoble("ok2", steps)];
                        button2.Text = romanji[Generate.GetDoble("v1", steps)] + romanji[Generate.GetDoble("v2", steps)];
                        button2.Tag = "n";
                        button3.Text = romanji[Generate.GetDoble("v3", steps)] + romanji[Generate.GetDoble("v4", steps)];
                        button3.Tag = "n";
                        break;
                    case 2:
                        button2.Tag = Generate.GetDoble("ok1", steps).ToString();
                        button2.Text = romanji[Generate.GetDoble("ok1", steps)] + romanji[Generate.GetDoble("ok2", steps)];
                        textBox1.Text = hira[Generate.GetDoble("ok1", steps)] + hira[Generate.GetDoble("ok2", steps)];
                        button1.Text = romanji[Generate.GetDoble("v1", steps)] + romanji[Generate.GetDoble("v2", steps)];
                        button1.Tag = "n";
                        button3.Text = romanji[Generate.GetDoble("v3", steps)] + romanji[Generate.GetDoble("v4", steps)];
                        button3.Tag = "n";
                        break;
                    case 3:
                        button3.Tag = Generate.GetDoble("ok1", steps).ToString();
                        button3.Text = romanji[Generate.GetDoble("ok1", steps)] + romanji[Generate.GetDoble("ok2", steps)];
                        textBox1.Text = hira[Generate.GetDoble("ok1", steps)] + hira[Generate.GetDoble("ok2", steps)];
                        button1.Text = romanji[Generate.GetDoble("v1", steps)] + romanji[Generate.GetDoble("v2", steps)];
                        button1.Tag = "n";
                        button2.Text = romanji[Generate.GetDoble("v3", steps)] + romanji[Generate.GetDoble("v4", steps)];
                        button2.Tag = "n";
                        break;
                    default:
                        break;
                }
                
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Generate.stepX = -1;
            this.BackColor = ColorTranslator.FromHtml("#699156");
            textBox1.BackColor = ColorTranslator.FromHtml("#699156");
            int randomB = random.Next(1, 4);
            switch (randomB)
            {
                case 1:
                    button1.Tag = Generate.GetDoble("ok1", steps).ToString();
                    button1.Text = romanji[Generate.GetDoble("ok1", steps)] + romanji[Generate.GetDoble("ok2", steps)];
                    textBox1.Text = hira[Generate.GetDoble("ok1", steps)] + hira[Generate.GetDoble("ok2", steps)];
                    button2.Text = romanji[Generate.GetDoble("v1", steps)] + romanji[Generate.GetDoble("v2", steps)];
                    button2.Tag = "n";
                    button3.Text = romanji[Generate.GetDoble("v3", steps)] + romanji[Generate.GetDoble("v4", steps)];
                    button3.Tag = "n";
                    break;
                case 2:
                    button2.Tag = Generate.GetDoble("ok1", steps).ToString();
                    button2.Text = romanji[Generate.GetDoble("ok1", steps)] + romanji[Generate.GetDoble("ok2", steps)];
                    textBox1.Text = hira[Generate.GetDoble("ok1", steps)] + hira[Generate.GetDoble("ok2", steps)];
                    button1.Text = romanji[Generate.GetDoble("v1", steps)] + romanji[Generate.GetDoble("v2", steps)];
                    button1.Tag = "n";
                    button3.Text = romanji[Generate.GetDoble("v3", steps)] + romanji[Generate.GetDoble("v4", steps)];
                    button3.Tag = "n";
                    break;
                case 3:
                    button3.Tag = Generate.GetDoble("ok1", steps).ToString();
                    button3.Text = romanji[Generate.GetDoble("ok1", steps)] + romanji[Generate.GetDoble("ok2", steps)];
                    textBox1.Text = hira[Generate.GetDoble("ok1", steps)] + hira[Generate.GetDoble("ok2", steps)];
                    button1.Text = romanji[Generate.GetDoble("v1", steps)] + romanji[Generate.GetDoble("v2", steps)];
                    button1.Tag = "n";
                    button2.Text = romanji[Generate.GetDoble("v3", steps)] + romanji[Generate.GetDoble("v4", steps)];
                    button2.Tag = "n";

                    break;
                default:
                    break;
            }
            textBox1.Text = hira[Generate.GetDoble("ok1", steps)] + hira[Generate.GetDoble("ok2", steps)];
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            (new Form2()).Show();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
