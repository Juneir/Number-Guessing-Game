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
    public partial class Form2 : Form
    {
        public int opacity = 0;
        public int yes = 0;
        public Form2()
        {
            InitializeComponent();
            this.Opacity = (double)opacity / 100;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (yes < 10)
            {
                yes++;
                opacity += 10;
                this.Opacity = (double)opacity / 100;
            }
        }
    }
}
