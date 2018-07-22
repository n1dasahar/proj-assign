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
    public partial class Form1 : Form
    {
        Connection conn = new Connection();
        public Form1()
        {
            InitializeComponent();
        }

        public void addVendorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Addvendor ad = new Addvendor();
            ad.Show();
            this.Hide();
        }

        private void approvalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                
                VendorApproval va = new VendorApproval();
                va.Show();
                this.Hide();
            }
        }

        private void purchaseOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PO p = new PO();
            p.Show();
            this.Hide();
        }

        private void gRNToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addCostomerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
