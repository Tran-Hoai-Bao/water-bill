namespace Copy
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            addInvoice = new AddInvoice();
            addToolStripMenuItem = new ToolStripMenuItem();
            manageInvoiceToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            manageInvoice = new ManageInvoice();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // addInvoice
            // 
            addInvoice.InvoicesManager = null;
            addInvoice.Location = new Point(0, 31);
            addInvoice.Name = "addInvoice";
            addInvoice.Size = new Size(883, 629);
            addInvoice.TabIndex = 2;
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(102, 24);
            addToolStripMenuItem.Text = "Add Invoice";
            addToolStripMenuItem.Click += addToolStripMenuItem_Click;
            // 
            // manageInvoiceToolStripMenuItem
            // 
            manageInvoiceToolStripMenuItem.Name = "manageInvoiceToolStripMenuItem";
            manageInvoiceToolStripMenuItem.Size = new Size(128, 24);
            manageInvoiceToolStripMenuItem.Text = "Manage Invoice";
            manageInvoiceToolStripMenuItem.Click += manageInvoiceToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { addToolStripMenuItem, manageInvoiceToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(920, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // manageInvoice
            // 
            manageInvoice.Location = new Point(0, 31);
            manageInvoice.Name = "manageInvoice";
            manageInvoice.Size = new Size(920, 525);
            manageInvoice.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 708);
            Controls.Add(manageInvoice);
            Controls.Add(addInvoice);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private AddInvoice addInvoice;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem manageInvoiceToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ManageInvoice manageInvoice;
    }
}
