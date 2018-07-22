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
    public partial class VendorApproval : Form
    {
        Connection conn = new Connection();
        public VendorApproval()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                conn.oleDbConnection1.Open();
                OleDbCommand cmd = new OleDbCommand("update vendor set vstatus='Inactive' where vid='"+comboBox1.Text+"'", conn.oleDbConnection1);
                cmd.ExecuteNonQuery();
                conn.oleDbConnection1.Close();
            }
            Addvendor ad = new Addvendor();
            ad.Show();
            this.Hide();
        }

        private void VendorApproval_Load(object sender, EventArgs e)
        {
            {
                conn.oleDbConnection1.Open();
                OleDbCommand cmd = new OleDbCommand("select vid from vendor ", conn.oleDbConnection1);

                OleDbDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    comboBox1.Items.Add(dr["vid"]).ToString();
                }
                conn.oleDbConnection1.Close();

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                conn.oleDbConnection1.Open();
                OleDbCommand cmd = new OleDbCommand("select * from vendor where vid='" + comboBox1.Text + "'", conn.oleDbConnection1);
                OleDbDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                    textBox1.Text = dr["vname"].ToString();
                    textBox2.Text = dr["vcode"].ToString();
                    textBox3.Text = dr["vcity"].ToString();
                    textBox4.Text = dr["ph1"].ToString();
                    textBox5.Text = dr["ph2"].ToString();
                    textBox6.Text = dr["vaddress"].ToString();
                    textBox7.Text = dr["cpname"].ToString();
                    textBox8.Text = dr["cpph"].ToString();
                    textBox9.Text = dr["vemail"].ToString();
                    textBox10.Text = dr["vfax"].ToString();
                    textBox11.Text = dr["vgroup"].ToString();



                }
                conn.oleDbConnection1.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
