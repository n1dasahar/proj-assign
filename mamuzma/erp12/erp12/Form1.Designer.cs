namespace erp12
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.bussinessPartnerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addVendorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.approvalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gRNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.costomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCostomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.approvalToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salesOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delieveryChalanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invoiceToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.bussinessPartnerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(559, 47);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.ReadOnly = true;
            this.toolStripTextBox1.Size = new System.Drawing.Size(400, 43);
            this.toolStripTextBox1.Text = "Bussiness Information";
            // 
            // bussinessPartnerToolStripMenuItem
            // 
            this.bussinessPartnerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendorToolStripMenuItem,
            this.costomerToolStripMenuItem});
            this.bussinessPartnerToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bussinessPartnerToolStripMenuItem.Name = "bussinessPartnerToolStripMenuItem";
            this.bussinessPartnerToolStripMenuItem.Size = new System.Drawing.Size(145, 43);
            this.bussinessPartnerToolStripMenuItem.Text = "Bussiness Partner";
            // 
            // vendorToolStripMenuItem
            // 
            this.vendorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addVendorToolStripMenuItem,
            this.approvalToolStripMenuItem,
            this.purchaseOrderToolStripMenuItem,
            this.gRNToolStripMenuItem,
            this.invoiceToolStripMenuItem});
            this.vendorToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorToolStripMenuItem.Name = "vendorToolStripMenuItem";
            this.vendorToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.vendorToolStripMenuItem.Text = "Vendor";
            // 
            // addVendorToolStripMenuItem
            // 
            this.addVendorToolStripMenuItem.Name = "addVendorToolStripMenuItem";
            this.addVendorToolStripMenuItem.Size = new System.Drawing.Size(184, 24);
            this.addVendorToolStripMenuItem.Text = "Add Vendor";
            this.addVendorToolStripMenuItem.Click += new System.EventHandler(this.addVendorToolStripMenuItem_Click);
            // 
            // approvalToolStripMenuItem
            // 
            this.approvalToolStripMenuItem.Name = "approvalToolStripMenuItem";
            this.approvalToolStripMenuItem.Size = new System.Drawing.Size(184, 24);
            this.approvalToolStripMenuItem.Text = "Approval";
            this.approvalToolStripMenuItem.Click += new System.EventHandler(this.approvalToolStripMenuItem_Click);
            // 
            // purchaseOrderToolStripMenuItem
            // 
            this.purchaseOrderToolStripMenuItem.Name = "purchaseOrderToolStripMenuItem";
            this.purchaseOrderToolStripMenuItem.Size = new System.Drawing.Size(184, 24);
            this.purchaseOrderToolStripMenuItem.Text = "Purchase Order";
            this.purchaseOrderToolStripMenuItem.Click += new System.EventHandler(this.purchaseOrderToolStripMenuItem_Click);
            // 
            // gRNToolStripMenuItem
            // 
            this.gRNToolStripMenuItem.Name = "gRNToolStripMenuItem";
            this.gRNToolStripMenuItem.Size = new System.Drawing.Size(184, 24);
            this.gRNToolStripMenuItem.Text = "GRN";
            this.gRNToolStripMenuItem.Click += new System.EventHandler(this.gRNToolStripMenuItem_Click);
            // 
            // invoiceToolStripMenuItem
            // 
            this.invoiceToolStripMenuItem.Name = "invoiceToolStripMenuItem";
            this.invoiceToolStripMenuItem.Size = new System.Drawing.Size(184, 24);
            this.invoiceToolStripMenuItem.Text = "Invoice";
            // 
            // costomerToolStripMenuItem
            // 
            this.costomerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCostomerToolStripMenuItem,
            this.approvalToolStripMenuItem1,
            this.salesOrderToolStripMenuItem,
            this.delieveryChalanToolStripMenuItem,
            this.invoiceToolStripMenuItem1});
            this.costomerToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costomerToolStripMenuItem.Name = "costomerToolStripMenuItem";
            this.costomerToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.costomerToolStripMenuItem.Text = "Costomer";
            // 
            // addCostomerToolStripMenuItem
            // 
            this.addCostomerToolStripMenuItem.Name = "addCostomerToolStripMenuItem";
            this.addCostomerToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
            this.addCostomerToolStripMenuItem.Text = "Add Costomer";
            this.addCostomerToolStripMenuItem.Click += new System.EventHandler(this.addCostomerToolStripMenuItem_Click);
            // 
            // approvalToolStripMenuItem1
            // 
            this.approvalToolStripMenuItem1.Name = "approvalToolStripMenuItem1";
            this.approvalToolStripMenuItem1.Size = new System.Drawing.Size(194, 24);
            this.approvalToolStripMenuItem1.Text = "Approval";
            // 
            // salesOrderToolStripMenuItem
            // 
            this.salesOrderToolStripMenuItem.Name = "salesOrderToolStripMenuItem";
            this.salesOrderToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
            this.salesOrderToolStripMenuItem.Text = "Sales Order";
            // 
            // delieveryChalanToolStripMenuItem
            // 
            this.delieveryChalanToolStripMenuItem.Name = "delieveryChalanToolStripMenuItem";
            this.delieveryChalanToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
            this.delieveryChalanToolStripMenuItem.Text = "Delievery Chalan";
            // 
            // invoiceToolStripMenuItem1
            // 
            this.invoiceToolStripMenuItem1.Name = "invoiceToolStripMenuItem1";
            this.invoiceToolStripMenuItem1.Size = new System.Drawing.Size(194, 24);
            this.invoiceToolStripMenuItem1.Text = "Invoice";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 274);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem bussinessPartnerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem costomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addVendorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem approvalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gRNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCostomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem approvalToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salesOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem delieveryChalanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invoiceToolStripMenuItem1;
    }
}

