using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace erp12
{
    public partial class Addvendor : Form
    {
        Connection conn = new Connection();
        public Addvendor()
        {
            InitializeComponent();
        }

        private void Addvendor_Load(object sender, EventArgs e)
        {
            {
                int c = 0;
                conn.oleDbConnection1.Open();
                OleDbCommand cmd = new OleDbCommand("select count(vid)from vendor", conn.oleDbConnection1);
                OleDbDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    c = Convert.ToInt32(dr[0]); c++;
                }

                textBox12.Text = "00" + c.ToString();

                conn.oleDbConnection1.Close();
            }
            {
                string[] status = {"Active","Inactive" };
                comboBox1.Items.AddRange(status);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                conn.oleDbConnection1.Open();
                OleDbCommand cmd = new OleDbCommand("insert into vendor(vid,vname,vcode,vcity,ph1,ph2,vaddress,cpname,cpph,vemail,vfax,vgroup,vstatus)values(@vid,@vname,@vcode,@vcity,@ph1,@ph2,@vaddress,@cpname,@cpph,@vemail,@vfax,@vgroup,@vstatus)", conn.oleDbConnection1);
                cmd.Parameters.AddWithValue("vid", textBox12.Text);
                cmd.Parameters.AddWithValue("vname", textBox1.Text);
                cmd.Parameters.AddWithValue("vcode", textBox2.Text);
                cmd.Parameters.AddWithValue("vcity", textBox3.Text);
                cmd.Parameters.AddWithValue("ph1", textBox4.Text);
                cmd.Parameters.AddWithValue("ph2", textBox5.Text);
                cmd.Parameters.AddWithValue("vaddress", textBox6.Text);
                cmd.Parameters.AddWithValue("cpname", textBox7.Text);
                cmd.Parameters.AddWithValue("cpph", textBox8.Text);
                cmd.Parameters.AddWithValue("vemail", textBox9.Text);
                cmd.Parameters.AddWithValue("vfax", textBox10.Text);
                cmd.Parameters.AddWithValue("vgroup", textBox11.Text);
                cmd.Parameters.AddWithValue("vstatus",comboBox1.Text);

                cmd.ExecuteNonQuery();
                conn.oleDbConnection1.Close();
            }
            MessageBox.Show("Your Vendor Is Added");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Active")
            {
                VendorApproval va = new VendorApproval();
                va.Show();
                this.Hide();
            }
            else
            {

                MessageBox.Show("Kindly Set Your Status Correctly");
            }
        }
        }
    }

