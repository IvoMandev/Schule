using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24._01._24_1_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            string s = a.Substring(2,4);
            if (int.Parse(s) <= 0120)
            {
                textBox2.Text = "Козирог";
                pictureBox1.Visible = true;
                pictureBox1.Image = Image.FromFile("kozirog.png");
            }
            else if (int.Parse(s) <= 0219)
            {
                textBox2.Text = "Водолей";
                pictureBox1.Visible = true;
                pictureBox1.Image = Image.FromFile("vodolei.jpg");
            }
            else if (int.Parse(s) <= 0320)
            {
                textBox2.Text = "Риби";
                pictureBox1.Visible = true;
                pictureBox1.Image = Image.FromFile("ribi.jpg");
            }
            else if (int.Parse(s) <= 0420)
            {
                textBox2.Text = "Овен";
                pictureBox1.Visible = true;
                pictureBox1.Image = Image.FromFile("oven.jpg");
            }
            else if (int.Parse(s) <= 0521)
            {
                textBox2.Text = "Телец";
                pictureBox1.Visible = true;
                pictureBox1.Image = Image.FromFile("telec.jpg");
            }
            else if (int.Parse(s) <= 0621)
            {
                textBox2.Text = "Близнаци";
                pictureBox1.Visible = true;
                pictureBox1.Image = Image.FromFile("bliznaci.jpg");
            }
            else if (int.Parse(s) <= 0722)
            {
                textBox2.Text = "Рак";
                pictureBox1.Visible = true;
                pictureBox1.Image = Image.FromFile("cancer.jpg");
            }
            else if (int.Parse(s) <= 0822)
            {
                textBox2.Text = "Лъв";
                pictureBox1.Visible = true;
                pictureBox1.Image = Image.FromFile("lion.png");
            }
            else if (int.Parse(s) <= 0922)
            {
                textBox2.Text = "Дева";
                pictureBox1.Visible = true;
                pictureBox1.Image = Image.FromFile("deva.jpg");
            }
            else if (int.Parse(s) <= 1022)
            {
                textBox2.Text = "Везни";
                pictureBox1.Visible = true;
                pictureBox1.Image = Image.FromFile("vezni.jpg");
            }
            else if (int.Parse(s) <= 1122)
            {
                textBox2.Text = "Скорпион";
                pictureBox1.Visible = true;
                pictureBox1.Image = Image.FromFile("scorpion.jpg");
            }
            else if (int.Parse(s) <= 1221)
            {
                textBox2.Text = "Стрелец";
                pictureBox1.Visible = true;
                pictureBox1.Image = Image.FromFile("strelec.png");
            }
            else if (int.Parse(s) <= 1231)
            {
                textBox2.Text = "Козирог";
                pictureBox1.Visible = true;
                pictureBox1.Image = Image.FromFile("kozirog.png");
            }
        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            pictureBox1.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = fontDialog1.Font;
                textBox2.Font = fontDialog1.Font;
            }
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }
    }
}
