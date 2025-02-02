namespace MDI
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
            menuStrip = new MenuStrip();
            aPIFormToolStripMenuItem = new ToolStripMenuItem();
            rebexToolStripMenuItem = new ToolStripMenuItem();
            ynamicToolStripMenuItem = new ToolStripMenuItem();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { aPIFormToolStripMenuItem, rebexToolStripMenuItem, ynamicToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(1490, 28);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            menuStrip.ItemClicked += menuStrip1_ItemClicked;
            // 
            // aPIFormToolStripMenuItem
            // 
            aPIFormToolStripMenuItem.Name = "aPIFormToolStripMenuItem";
            aPIFormToolStripMenuItem.Size = new Size(45, 24);
            aPIFormToolStripMenuItem.Text = "API";
            aPIFormToolStripMenuItem.Click += aPIFormToolStripMenuItem_Click;
            // 
            // rebexToolStripMenuItem
            // 
            rebexToolStripMenuItem.Name = "rebexToolStripMenuItem";
            rebexToolStripMenuItem.Size = new Size(64, 24);
            rebexToolStripMenuItem.Text = "Rebex";
            rebexToolStripMenuItem.Click += rebexToolStripMenuItem_Click;
            // 
            // ynamicToolStripMenuItem
            // 
            ynamicToolStripMenuItem.Name = "ynamicToolStripMenuItem";
            ynamicToolStripMenuItem.Size = new Size(85, 24);
            ynamicToolStripMenuItem.Text = " Dynamic";
            ynamicToolStripMenuItem.Click += ynamicToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1490, 558);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem aPIFormToolStripMenuItem;
        private ToolStripMenuItem rebexToolStripMenuItem;
        private ToolStripMenuItem ynamicToolStripMenuItem;
    }
}
