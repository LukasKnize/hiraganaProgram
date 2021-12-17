using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace skolniProjektPVA
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //otevřít základní tréning
            (new Form1()).Show();
            this.Hide();
        }

        private void TextBox212_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox112.Text = User.mis.ToString();
            textBox212.Text = User.ok.ToString();
            var synthesizer = new SpeechSynthesizer();
           // if (synthesizer.GetInstalledVoices())
           // {

            //}

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
