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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            textBox1.Text += "游戏规则说明\r\n";
            textBox1.Text += "1.在此游戏中，你需要猜一个没有重复数位的4位数。\r\n";
            textBox1.Text += "2.每做出一次猜测时，软件会给出反馈。对于你的猜测中的任意一个数位，如果在结果数值中的相同数位上也有同样的数，则这个数叫做一个“优”；如果在结果数值中的不同数位上有同样的数，则这个数叫做一个“良”。\r\n";
            textBox1.Text += "  例如：你的结果数是1357，你做出的猜测是5316，那么反馈就是“1优2良”，因为你猜中了数字“3”的位置和数值，而只猜中了数字“5”、“1”的数值\r\n";
            textBox1.Text += "3.每次的猜测都会有记录，你需要用记录中的信息，用最少的次数猜出结果数值。祝你好运！\r\n";
            button1.Focus();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("请将反馈发送至imlolhaha@outlook.com，主题为“猜数字游戏意见反馈”", "猜数字游戏", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
