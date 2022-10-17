namespace Lab8
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendingMachineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courseInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordIndexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.vendingMachineToolStripMenuItem,
            this.courseInformationToolStripMenuItem,
            this.wordIndexToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // vendingMachineToolStripMenuItem
            // 
            this.vendingMachineToolStripMenuItem.Name = "vendingMachineToolStripMenuItem";
            this.vendingMachineToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.vendingMachineToolStripMenuItem.Text = "Vending Machine";
            this.vendingMachineToolStripMenuItem.Click += new System.EventHandler(this.vendingMachineToolStripMenuItem_Click);
            // 
            // courseInformationToolStripMenuItem
            // 
            this.courseInformationToolStripMenuItem.Name = "courseInformationToolStripMenuItem";
            this.courseInformationToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.courseInformationToolStripMenuItem.Text = "Course Information";
            this.courseInformationToolStripMenuItem.Click += new System.EventHandler(this.courseInformationToolStripMenuItem_Click);
            // 
            // wordIndexToolStripMenuItem
            // 
            this.wordIndexToolStripMenuItem.Name = "wordIndexToolStripMenuItem";
            this.wordIndexToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.wordIndexToolStripMenuItem.Text = "Word Index";
            this.wordIndexToolStripMenuItem.Click += new System.EventHandler(this.wordIndexToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Structures And Dictionaries";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem vendingMachineToolStripMenuItem;
        private ToolStripMenuItem courseInformationToolStripMenuItem;
        private ToolStripMenuItem wordIndexToolStripMenuItem;
    }
}