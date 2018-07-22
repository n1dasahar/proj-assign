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
    public partial class Form3 : Form

    {
        Form1 f1;
        public Form3(Form1 ff)
            
        {
            f1 = ff;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f1.textBox1.Text = f1.textBox1.Text.Replace(textBox1.Text, textBox2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.label1.Text = "Find What";
            this.label2.Text = "Replace With";
            
            this.button2.Text = "Replace";
            this.button3.Text = "Cancel";
            this.Text = "Replace";

            
           
        }
    }
}
