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
    public partial class GrnVendor : Form
    {
        Connection conn = new Connection();
        public GrnVendor()
        {
            InitializeComponent();
        }

        private void GrnVendor_Load(object sender, EventArgs e)
        {
            {
                conn.oleDbConnection1.Open();
                OleDbCommand cmd = new OleDbCommand("select poid from po where status='open'", conn.oleDbConnection1);
                OleDbDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    comboBox1.Items.Add(dr["poid"]).ToString();
                }
            }
        }
    }
}
