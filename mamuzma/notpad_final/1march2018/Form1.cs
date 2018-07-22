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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Undo();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Nida Sahar-Notepad";
           
            
            newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
           // printToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.P;
            undoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            cuttoolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            copyToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            pasteToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            deleteToolStripMenuItem.ShortcutKeys = Keys.Delete;
            findToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F;
            replaceToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.H;
            gotoToolStripMenuItem1.ShortcutKeys = Keys.Control | Keys.G;
            timeDateToolStripMenuItem.ShortcutKeys = Keys.F5;

            



           // this.undoToolStripMenuItem.Enabled = false;
           // this.cuttoolStripMenuItem.Enabled = false;
          //  this.copyToolStripMenuItem.Enabled = false;
          //  this.deleteToolStripMenuItem.Enabled = false;
          //  this.findNextToolStripMenuItem.Enabled = false;
          //  this.findToolStripMenuItem.Enabled = false;
           


            this.textBox1.ScrollBars = ScrollBars.Both;
            openFileDialog1.Filter = "alltex(*.Text)|*.Text";
            saveFileDialog1.Filter = "alltex(*.Text)|*.Text";
            


        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            {

               // this.undoToolStripMenuItem.Enabled = true;
               // this.cuttoolStripMenuItem.Enabled = true;
               // this.copyToolStripMenuItem.Enabled = true;
               // this.deleteToolStripMenuItem.Enabled = true;
              //  this.findNextToolStripMenuItem.Enabled = true;
              //  this.findToolStripMenuItem.Enabled = true;
            }
         //   else
            {
               // this.undoToolStripMenuItem.Enabled = false;
              //  this.cuttoolStripMenuItem.Enabled = false;
              //  this.copyToolStripMenuItem.Enabled = false;
               // this.deleteToolStripMenuItem.Enabled = false;
              //  this.findNextToolStripMenuItem.Enabled = false;
               // this.findToolStripMenuItem.Enabled = false;
            }


        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
                DialogResult dr = saveFileDialog1.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    string filename = saveFileDialog1.FileName;
                    filename += filename + ".Txt";
                    System.IO.File.WriteAllText(filename, this.textBox1.Text);
                }
                else
                {
                    this.textBox1.Clear();
                }

            
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
             DialogResult dr = this.openFileDialog1.ShowDialog();
             if (dr == DialogResult.OK)
             {
                 string filename = openFileDialog1.FileName;
                 this.textBox1.Text = System.IO.File.ReadAllText(filename);
             }
            
             
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cuttoolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Cut();





        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Paste();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.DeselectAll();
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4(this);
            
            f4.Show();
            

        }

       
        

       

        private void gotoToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        

        public void replaceToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(this);
            f3.Show();
            
        }

        private void timeDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = System.DateTime.Today.ToString();
        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (wordWrapToolStripMenuItem.Checked == true)
            {
                textBox1.WordWrap = false;
            }
            else if(wordWrapToolStripMenuItem.Checked==false)
            {
                textBox1.WordWrap = true;
            }
               
        }



        private void withColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;
            DialogResult dr = this.colorDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                this.textBox1.ForeColor = this.colorDialog1.Color;

            }




        }

        private void regularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            DialogResult dr = this.fontDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                this.textBox1.Font = this.fontDialog1.Font;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = saveFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string filename = saveFileDialog1.FileName;
                filename += filename + ".Txt";
                System.IO.File.WriteAllText(filename,this.textBox1.Text);



            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult dr = saveFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string filename = saveFileDialog1.FileName;
                filename += filename + ".Txt";
                System.IO.File.WriteAllText(filename, this.textBox1.Text);



            }

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void statusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //  DialogResult dr = printDialog1.ShowDialog();
          //  if (dr == DialogResult.OK)
          //  {

             
          //  }
        }

        private void pageSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void findNextToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


       
    }
}
