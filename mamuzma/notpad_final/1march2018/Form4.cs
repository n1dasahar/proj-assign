using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _1march2018
{
    public partial class Form4 : Form
    {
        Form1 f1;
        public Form4(Form1 ff)
        {
            f1 = ff;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (f1.textBox1.Text.Contains(textBox1.Text))
            {
                MessageBox.Show("Find");

            }
            else
            {
                MessageBox.Show("Not Find");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.label1.Text = "Find What";
            this.button1.Text = "Find";
            this.button2.Text = "Cancel";
            this.Text = "Find";


        }
    }
}
