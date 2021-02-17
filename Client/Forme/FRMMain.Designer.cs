namespace Client
{
    partial class FRMClient
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
            this.test2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noviPacijentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unesiLekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretraziLekoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bolestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unesiBolestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMainContainer = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.test2ToolStripMenuItem,
            this.lekToolStripMenuItem,
            this.bolestToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(439, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // test2ToolStripMenuItem
            // 
            this.test2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretragaToolStripMenuItem,
            this.noviPacijentToolStripMenuItem});
            this.test2ToolStripMenuItem.Name = "test2ToolStripMenuItem";
            this.test2ToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.test2ToolStripMenuItem.Text = "Pacijent";
            // 
            // pretragaToolStripMenuItem
            // 
            this.pretragaToolStripMenuItem.Name = "pretragaToolStripMenuItem";
            this.pretragaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pretragaToolStripMenuItem.Text = "Pretraga";
            this.pretragaToolStripMenuItem.Click += new System.EventHandler(this.pretragaToolStripMenuItem_Click);
            // 
            // noviPacijentToolStripMenuItem
            // 
            this.noviPacijentToolStripMenuItem.Name = "noviPacijentToolStripMenuItem";
            this.noviPacijentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.noviPacijentToolStripMenuItem.Text = "Novi pacijent";
            this.noviPacijentToolStripMenuItem.Click += new System.EventHandler(this.noviPacijentToolStripMenuItem_Click);
            // 
            // lekToolStripMenuItem
            // 
            this.lekToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unesiLekToolStripMenuItem,
            this.pretraziLekoveToolStripMenuItem});
            this.lekToolStripMenuItem.Name = "lekToolStripMenuItem";
            this.lekToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.lekToolStripMenuItem.Text = "Lek";
            // 
            // unesiLekToolStripMenuItem
            // 
            this.unesiLekToolStripMenuItem.Name = "unesiLekToolStripMenuItem";
            this.unesiLekToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.unesiLekToolStripMenuItem.Text = "Unesi lek";
            this.unesiLekToolStripMenuItem.Click += new System.EventHandler(this.unesiLekToolStripMenuItem_Click);
            // 
            // pretraziLekoveToolStripMenuItem
            // 
            this.pretraziLekoveToolStripMenuItem.Name = "pretraziLekoveToolStripMenuItem";
            this.pretraziLekoveToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.pretraziLekoveToolStripMenuItem.Text = "Pretrazi lekove";
            this.pretraziLekoveToolStripMenuItem.Click += new System.EventHandler(this.pretraziLekoveToolStripMenuItem_Click);
            // 
            // bolestToolStripMenuItem
            // 
            this.bolestToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unesiBolestToolStripMenuItem});
            this.bolestToolStripMenuItem.Name = "bolestToolStripMenuItem";
            this.bolestToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.bolestToolStripMenuItem.Text = "Bolest";
            // 
            // unesiBolestToolStripMenuItem
            // 
            this.unesiBolestToolStripMenuItem.Name = "unesiBolestToolStripMenuItem";
            this.unesiBolestToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.unesiBolestToolStripMenuItem.Text = "Unesi Bolest";
            this.unesiBolestToolStripMenuItem.Click += new System.EventHandler(this.unesiBolestToolStripMenuItem_Click);
            // 
            // pnlMainContainer
            // 
            this.pnlMainContainer.Location = new System.Drawing.Point(0, 27);
            this.pnlMainContainer.Name = "pnlMainContainer";
            this.pnlMainContainer.Size = new System.Drawing.Size(439, 291);
            this.pnlMainContainer.TabIndex = 1;
            // 
            // FRMClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 323);
            this.Controls.Add(this.pnlMainContainer);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FRMClient";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem test2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noviPacijentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unesiLekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretraziLekoveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bolestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unesiBolestToolStripMenuItem;
        private System.Windows.Forms.Panel pnlMainContainer;
    }
}

