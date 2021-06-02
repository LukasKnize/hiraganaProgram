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

        string[] hira = new string[] { "あ", "い", "う", "え", "お", "か", "き", "く", "け", "こ", "さ", "し", "す", "せ", "そ", "た", "ち", "つ", "て", "と", "な", "に", "ぬ", "ね", "の", "は", "ひ", "ふ", "へ", "ほ", "ま", "み", "む", "め", "も", "や", "ゆ", "よ", "ら", "り", "る", "れ", "ろ", "わ", "を", "ん", "v" };
        string[] romanji = new string[] { "a", "i", "u", "e", "o", "ka", "ki", "ku", "ke", "ko", "sa", "shi", "su", "se", "so", "ta", "chi", "cu", "te", "to", "na", "ni", "nu", "ne", "no", "ha", "hi", "fu", "he", "ho", "ma", "mi", "mu", "me", "mo", "ja", "ju", "jo", "ra", "ri", "ru", "re", "ro", "wa", "wo", "n", "vvv" };
        Random random = new Random();
        int lastChar = 0;
        int nextCharacter = 0;
        int steps = 0;

        private void button5_Click(object sender, EventArgs e)
        {
            (new Form2()).Show();
            this.Hide();
        }

        private void ClickIt(object sender, EventArgs e)
        {
            Button bu = sender as Button;
            if (bu.Tag.ToString() == "n")
            {
                textBox1.BackColor = ColorTranslator.FromHtml("#DA627D");
                User.mis += 1;
            }
            else
            {
                textBox1.BackColor = ColorTranslator.FromHtml("#699156");
                User.ok += 1;
                steps += 1;
                textBox2.Text = Generate.GetDoble("ok1", steps).ToString() + ";" + Generate.GetDoble("ok2", steps).ToString();
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
                textBox2.Text = Generate.GetDoble("ok1", steps).ToString() + ";" + Generate.GetDoble("ok2", steps).ToString();
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#699156");
            textBox1.BackColor = ColorTranslator.FromHtml("#699156");
            bool x = true;
            int x1 = random.Next(46);
            int x2 = 0;
            while (x)
            {
                x2 = random.Next(46);
                if (x2 != x1)
                {
                    x = false;
                }
            }
            int randomB = random.Next(1, 4);
            switch (randomB)
            {
                case 1:
                    button1.Tag = x1.ToString();
                    button1.Text = romanji[x1] + romanji[x2];
                    button2.Text = romanji[random.Next(46)] + romanji[random.Next(46)];
                    button2.Tag = "n";
                    button3.Text = romanji[random.Next(46)] + romanji[random.Next(46)];
                    button3.Tag = "n";
                    break;
                case 2:
                    button2.Tag = x1.ToString();
                    button2.Text = romanji[x1] + romanji[x2]; 
                    button1.Text = romanji[random.Next(46)] + romanji[random.Next(46)];
                    button1.Tag = "n";
                    button3.Text = romanji[random.Next(46)] + romanji[random.Next(46)];
                    button3.Tag = "n";
                    break;
                case 3:
                    button3.Tag = x1.ToString();
                    button3.Text = romanji[x1] + romanji[x2];
                    button1.Text = romanji[random.Next(46)] + romanji[random.Next(46)];
                    button1.Tag = "n";
                    button2.Text = romanji[random.Next(46)] + romanji[random.Next(46)];
                    button2.Tag = "n";
                    break;
                default:
                    break;
            }
            textBox1.Text = hira[x1] + hira[x2];
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
