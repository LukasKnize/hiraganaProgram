using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//text to speech (text na zvuk)
using System.Speech.Synthesis;


namespace skolniProjektPVA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] hira = new string[] {"あ", "い", "う", "え", "お", "か", "き", "く", "け", "こ", "さ", "し", "す", "せ", "そ", "た", "ち", "つ", "て", "と", "な", "に", "ぬ", "ね", "の", "は", "ひ", "ふ", "へ", "ほ", "ま", "み", "む", "め", "も", "や", "ゆ", "よ", "ら", "り", "る", "れ", "ろ", "わ", "を", "ん", "v"};
        string[] romanji = new string[] { "a", "i", "u", "e", "o", "ka", "ki", "ku", "ke", "ko", "sa", "shi", "su", "se", "so", "ta", "chi", "cu", "te", "to", "na", "ni", "nu", "ne", "no", "ha", "hi", "fu", "he", "ho", "ma", "mi", "mu", "me", "mo", "ja", "ju", "jo", "ra", "ri", "ru", "re", "ro", "wa", "wo", "n", "vvv" };
        Random random = new Random();
        int lastChar = 0;
        int nextCharacter = 0;
        int steps = 0;
        
        private void click(object sender, EventArgs e)
        {
           
            Button bu = sender as Button;
            if (bu.Tag.ToString() == "n")
            {
                textBox1.BackColor = ColorTranslator.FromHtml("#DA627D");
                string bhira = hira[ Generate.Get("ok", steps)];
                User.badHira.Add(bhira);
                User.mis += 1; 
            }
            else
            {
                textBox1.BackColor = ColorTranslator.FromHtml("#699156");
                User.ok += 1;
                steps += 1;
                int randomB = random.Next(1, 4);
                switch (randomB)
                {
                    case 1:
                        button1.Tag = Generate.Get("ok", steps).ToString();
                        button1.Text = romanji[Convert.ToInt32(button1.Tag)];
                        textBox1.Text = hira[Convert.ToInt32(button1.Tag)];
                        button2.Text = romanji[Generate.Get("v1", steps)];
                        button2.Tag = "n";
                        button3.Text = romanji[Generate.Get("v2", steps)];
                        button3.Tag = "n";
                            break;
                    case 2:
                        button2.Tag = Generate.Get("ok", steps).ToString();
                        button2.Text = romanji[Convert.ToInt32(button2.Tag)];
                        textBox1.Text = hira[Convert.ToInt32(button2.Tag)];
                        button1.Text = romanji[Generate.Get("v1", steps)];
                        button1.Tag = "n";
                        button3.Text = romanji[Generate.Get("v2", steps)];
                        button3.Tag = "n";
                        break;
                    case 3:
                        button3.Tag = Generate.Get("ok", steps).ToString();
                        button3.Text = romanji[Convert.ToInt32(button3.Tag)];
                        textBox1.Text = hira[Convert.ToInt32(button3.Tag)];
                        button1.Text = romanji[Generate.Get("v1", steps)];
                        button1.Tag = "n";
                        button2.Text = romanji[Generate.Get("v2", steps)];
                        button2.Tag = "n";
                        break;
                    default:
                        break;
                }
               
            }
        }

        

        private void RunAudio(object sender, EventArgs e)
        {
            var synthesizer = new SpeechSynthesizer();
            synthesizer.SetOutputToDefaultAudioDevice();
            //Microsoft Haruka Desktop
            synthesizer.SelectVoice("Microsoft Haruka Desktop");
            synthesizer.Speak(hira[nextCharacter]);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#699156");
            textBox1.BackColor = ColorTranslator.FromHtml("#699156");
            bool x = true;
            while (x)
            {
                nextCharacter = generate();
                if (nextCharacter != lastChar)
                {
                    lastChar = nextCharacter;
                    x = false;
                }
            }
            int randomB = random.Next(1, 4);
            switch (randomB)
            {
                case 1:
                    button1.Tag = nextCharacter.ToString();
                    button1.Text = romanji[nextCharacter];
                    button2.Text = romanji[random.Next(46)];
                    button2.Tag = "n";
                    button3.Text = romanji[random.Next(46)];
                    button3.Tag = "n";
                    break;
                case 2:
                    button2.Tag = nextCharacter.ToString();
                    button2.Text = romanji[nextCharacter];
                    button1.Text = romanji[random.Next(46)];
                    button1.Tag = "n";
                    button3.Text = romanji[random.Next(46)];
                    button3.Tag = "n";
                    break;
                case 3:
                    button3.Tag = nextCharacter.ToString();
                    button3.Text = romanji[nextCharacter];
                    button1.Text = romanji[random.Next(46)];
                    button1.Tag = "n";
                    button2.Text = romanji[random.Next(46)];
                    button2.Tag = "n";
                    break;
                default:
                    break;
            }
            textBox1.Text = hira[nextCharacter];
        }

        private int generate()
        {
            int nextChar = random.Next(46);
            return nextChar;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            (new Form2()).Show();
            this.Hide();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            (new Form2()).Show();
        }
    }
}
