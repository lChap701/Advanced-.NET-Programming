namespace RepCustomerWithXML
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
            this.allCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersByBalanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allCustomersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allCustomersToolStripMenuItem,
            this.customersByBalanceToolStripMenuItem,
            this.allCustomersToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // allCustomersToolStripMenuItem
            // 
            this.allCustomersToolStripMenuItem.Name = "allCustomersToolStripMenuItem";
            this.allCustomersToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.allCustomersToolStripMenuItem.Text = "All Reps";
            this.allCustomersToolStripMenuItem.Click += new System.EventHandler(this.allRepsToolStripMenuItem_Click);
            // 
            // customersByBalanceToolStripMenuItem
            // 
            this.customersByBalanceToolStripMenuItem.Name = "customersByBalanceToolStripMenuItem";
            this.customersByBalanceToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.customersByBalanceToolStripMenuItem.Text = "Reps by Salary";
            this.customersByBalanceToolStripMenuItem.Click += new System.EventHandler(this.repsBySalaryToolStripMenuItem_Click);
            // 
            // allCustomersToolStripMenuItem1
            // 
            this.allCustomersToolStripMenuItem1.Name = "allCustomersToolStripMenuItem1";
            this.allCustomersToolStripMenuItem1.Size = new System.Drawing.Size(93, 20);
            this.allCustomersToolStripMenuItem1.Text = "All Customers";
            this.allCustomersToolStripMenuItem1.Click += new System.EventHandler(this.allCustomersToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem allCustomersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customersByBalanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allCustomersToolStripMenuItem1;
    }
}

