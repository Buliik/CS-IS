namespace str.Templates
{
    partial class FormMain
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
            this.RezervaceToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.zbranToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zákazníkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zaměstnanecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.střelbaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prostoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RezervaceToolStripMenu,
            this.zbranToolStripItem,
            this.zákazníkToolStripMenuItem,
            this.zaměstnanecToolStripMenuItem,
            this.střelbaToolStripMenuItem,
            this.prostoryToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // RezervaceToolStripMenu
            // 
            this.RezervaceToolStripMenu.Name = "RezervaceToolStripMenu";
            this.RezervaceToolStripMenu.Size = new System.Drawing.Size(71, 20);
            this.RezervaceToolStripMenu.Text = "Rezervace";
            this.RezervaceToolStripMenu.Click += new System.EventHandler(this.RezervaceToolStripMenu_Click);
            // 
            // zbranToolStripItem
            // 
            this.zbranToolStripItem.Name = "zbranToolStripItem";
            this.zbranToolStripItem.Size = new System.Drawing.Size(56, 20);
            this.zbranToolStripItem.Text = "Zbraně";
            this.zbranToolStripItem.Click += new System.EventHandler(this.zbranToolStripItem_Click);
            // 
            // zákazníkToolStripMenuItem
            // 
            this.zákazníkToolStripMenuItem.Name = "zákazníkToolStripMenuItem";
            this.zákazníkToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.zákazníkToolStripMenuItem.Text = "Zákazník";
            this.zákazníkToolStripMenuItem.Click += new System.EventHandler(this.zákazníkToolStripMenuItem_Click);
            // 
            // zaměstnanecToolStripMenuItem
            // 
            this.zaměstnanecToolStripMenuItem.Name = "zaměstnanecToolStripMenuItem";
            this.zaměstnanecToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.zaměstnanecToolStripMenuItem.Text = "Zaměstnanec";
            this.zaměstnanecToolStripMenuItem.Click += new System.EventHandler(this.zaměstnanecToolStripMenuItem_Click);
            // 
            // střelbaToolStripMenuItem
            // 
            this.střelbaToolStripMenuItem.Name = "střelbaToolStripMenuItem";
            this.střelbaToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.střelbaToolStripMenuItem.Text = "Střelba";
            this.střelbaToolStripMenuItem.Click += new System.EventHandler(this.střelbaToolStripMenuItem_Click);
            // 
            // prostoryToolStripMenuItem
            // 
            this.prostoryToolStripMenuItem.Name = "prostoryToolStripMenuItem";
            this.prostoryToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.prostoryToolStripMenuItem.Text = "Prostory";
            this.prostoryToolStripMenuItem.Click += new System.EventHandler(this.prostoryToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem zbranToolStripItem;
        private System.Windows.Forms.ToolStripMenuItem zákazníkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zaměstnanecToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem střelbaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RezervaceToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem prostoryToolStripMenuItem;
    }
}