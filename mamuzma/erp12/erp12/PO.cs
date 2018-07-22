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
    public partial class PO : Form
    {
        Connection conn = new Connection();
        public PO()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                conn.oleDbConnection1.Open();
                OleDbCommand cmd = new OleDbCommand("select vid from vendor ", conn.oleDbConnection1);

                OleDbDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    comboBox2.Items.Add(dr["vid"]).ToString();
                }
                conn.oleDbConnection1.Close();

            }
           
        }
        private void PO_Load(object sender, EventArgs e)
        {
            {
                conn.oleDbConnection1.Open();
                OleDbCommand cmd = new OleDbCommand("select deptname from dept", conn.oleDbConnection1);
                OleDbDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    
                    comboBox1.Items.Add(dr["deptname"]).ToString();
                }
                conn.oleDbConnection1.Close();
            }
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                conn.oleDbConnection1.Open();
                OleDbCommand cmd = new OleDbCommand("select * from vendor where vid='" + comboBox2.Text + "'", conn.oleDbConnection1);
                OleDbDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    textBox1.Text = dr["vname"].ToString();
                    textBox2.Text = dr["cpname"].ToString();
                    textBox3.Text = dr["cpph"].ToString();
                }

                conn.oleDbConnection1.Close();
            }
            {
                {
                    int c = 0;
                    conn.oleDbConnection1.Open();
                    OleDbCommand cmd = new OleDbCommand("select count(poid) from po where vdept='" + comboBox1.Text + "'", conn.oleDbConnection1);
                    OleDbDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        c = Convert.ToInt32(dr[0]); c++;
                    }
                    if (comboBox1.Text == "Consumer")
                    {
                        
                        
                        textBox4.Text = "Con-00" + c.ToString() + "-" + System.DateTime.Today.Year;
                    }
                    if (comboBox1.Text == "HR")
                    {
                        comboBox2.Items.Clear();
                        textBox4.Text = "HR-00" + c.ToString() + "-" + System.DateTime.Today.Year;
                    }
                    if (comboBox1.Text == "Marketing")
                    {
                        comboBox2.Items.Clear();
                        textBox4.Text = "MR-00" + c.ToString() + "-" + System.DateTime.Today.Year;
                    }
                    if (comboBox1.Text == "Sales")
                    {
                        comboBox2.Items.Clear();
                        textBox4.Text = "SA-00" + c.ToString() + "-" + System.DateTime.Today.Year;
                    }

                    conn.oleDbConnection1.Close();
                }
            }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           
            this.textBox5.Text =  System.DateTime.Today.Day +"/ "+System.DateTime.Today.Month +"/ "+ System.DateTime.Today.Year;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox8.Text = this.textBox4.Text;
            {
                int c = 0;
                conn.oleDbConnection1.Open();
                OleDbCommand cmd = new OleDbCommand("select count(poid)from poproduct", conn.oleDbConnection1);
                OleDbDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    c = Convert.ToInt32(dr[0]); c++;
                }

                textBox6.Text = "00" + c.ToString();

                conn.oleDbConnection1.Close();
            }
            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            {
                conn.oleDbConnection1.Open();
                OleDbCommand smd = new OleDbCommand("select pname from products", conn.oleDbConnection1);
                OleDbDataReader dr = smd.ExecuteReader();
                while (dr.Read())
                {
                    comboBox4.Items.Add(dr["pname"]).ToString();

                }
                conn.oleDbConnection1.Close();
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select baseprice from products where pname'"+comboBox4.Text+"'",conn.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {

                textBox7.Text = dr["baseprice"].ToString(); 
            }
            conn.oleDbConnection1.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                conn.oleDbConnection1.Open();
                OleDbCommand cmd = new OleDbCommand("insert into poproducts(poid,pid,pqty)values(@poid,@pid,@pqty)", conn.oleDbConnection1);
                cmd.Parameters.AddWithValue("poid", textBox8.Text);
                cmd.Parameters.AddWithValue("pid", textBox6.Text);
                cmd.Parameters.AddWithValue("pid", textBox7.Text);

                conn.oleDbConnection1.Close();
            }
        }
    }
}
