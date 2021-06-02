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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            textBox1.Text = User.mis.ToString();
            textBox2.Text = User.ok.ToString();
            textBox3.Text = User.xxxxxx();
            textBox4.Text = User.easy.ToString();
            textBox5.Text = User.hard.ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            (new Form2()).Show();
            this.Hide();
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            (new Form2()).Show();
        }
    }
}
