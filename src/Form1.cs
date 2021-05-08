using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NumberGuessing
{
    public partial class Form1 : Form
    {
        public char[] numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        public string o, t, th, f;
        public int round = 0;
        public bool close = true;

        public Form1()
        {
            InitializeComponent();
            label7.Visible = false;
            label8.Text = "";
            button2.Visible = false;
            timer1.Enabled = false;
            Random random = new Random();
            string one = random.Next(0, 9).ToString();
            string two = random.Next(0, 9).ToString();
            string three = random.Next(0, 9).ToString();
            string four = random.Next(0, 9).ToString();
            while(two == one)
            {
                two = random.Next(0, 9).ToString();
            }
            while (three == two || three == one)
            {
                three = random.Next(0, 9).ToString();
            }
            while (four == two || four == one || four == three)
            {
                four = random.Next(0, 9).ToString();
            }
            o = one;
            t = two;
            th = three;
            f = four;
            label7.Text = o + t + th + f;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text.Length == 1)
            {
                textBox2.Focus();
            }
            else
            {
                textBox1.Focus();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 1)
            {
                textBox3.Focus();
            }
            else if(textBox2.Text.Length == 0)
            {
                textBox1.Focus();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            int red = rand.Next(0, 255);
            int blue = rand.Next(0, 255);
            int green = rand.Next(0, 255);
            label6.ForeColor = Color.FromArgb(red, green, blue);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label6.Text = "？优？良";
            label6.ForeColor = Color.FromArgb(0, 0, 0);
            label8.Text = "";
            button2.Visible = false;
            listBox1.Items.Clear();
            timer1.Enabled = false;
            Random random = new Random();
            string one = random.Next(0, 9).ToString();
            string two = random.Next(0, 9).ToString();
            string three = random.Next(0, 9).ToString();
            string four = random.Next(0, 9).ToString();
            while (two == one)
            {
                two = random.Next(0, 9).ToString();
            }
            while (three == two || three == one)
            {
                three = random.Next(0, 9).ToString();
            }
            while (four == two || four == one || four == three)
            {
                four = random.Next(0, 9).ToString();
            }
            o = one;
            t = two;
            th = three;
            f = four;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox1.Focus();
            round = 0;
            label7.Text = o + t + th + f;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Length == 1)
            {
                textBox4.Focus();
            }
            else if (textBox3.Text.Length == 0)
            {
                textBox2.Focus();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (close)
            {
                close = false;
                Form2 form2 = new Form2();
                form2.ShowDialog();
                this.Close();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text.Length == 1)
            {
                button1.Focus();
            }
            else if (textBox4.Text.Length == 0)
            {
                textBox3.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int good = 0;
            int great = 0;
            round++;
            //check for 良
            if(textBox2.Text == o || textBox3.Text == o || textBox4.Text == o)
            {
                good++;
            }
            if (textBox1.Text == t || textBox3.Text == t || textBox4.Text == t)
            {
                good++;
            }
            if (textBox1.Text == th || textBox2.Text == th || textBox4.Text == th)
            {
                good++;
            }
            if (textBox1.Text == f || textBox2.Text == f || textBox3.Text == f)
            {
                good++;
            }
            //check for 优
            if(textBox1.Text == o)
            {
                great++;
            }
            if (textBox2.Text == t)
            {
                great++;
            }
            if (textBox3.Text == th)
            {
                great++;
            }
            if (textBox4.Text == f)
            {
                great++;
            }
            label6.Text = great + "优" + good + "良";
            listBox1.Items.Add(textBox1.Text + textBox2.Text + textBox3.Text + textBox4.Text + "   " + label6.Text);
            if(great == 4)
            {
                label6.Text = "猜中了！";
                timer1.Enabled = true;
                label8.Text = "本次猜数，你用了" + round + "轮猜中数值" + label7.Text;
                button2.Visible = true;
                button2.Focus();
            }
        }
    }
}
