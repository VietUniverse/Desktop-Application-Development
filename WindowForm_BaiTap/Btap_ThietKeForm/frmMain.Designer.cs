namespace Btap_ThietKeForm
{
    partial class frmMain
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
            this.họVàTênSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bài1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bàiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bài3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bài4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.họVàTênSinhViênToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(363, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // họVàTênSinhViênToolStripMenuItem
            // 
            this.họVàTênSinhViênToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bài1ToolStripMenuItem,
            this.bàiToolStripMenuItem,
            this.bài3ToolStripMenuItem,
            this.bài4ToolStripMenuItem});
            this.họVàTênSinhViênToolStripMenuItem.Name = "họVàTênSinhViênToolStripMenuItem";
            this.họVàTênSinhViênToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.họVàTênSinhViênToolStripMenuItem.Text = "Họ và tên sinh viên";
            // 
            // bài1ToolStripMenuItem
            // 
            this.bài1ToolStripMenuItem.Name = "bài1ToolStripMenuItem";
            this.bài1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bài1ToolStripMenuItem.Text = "Bài 1";
            this.bài1ToolStripMenuItem.Click += new System.EventHandler(this.bài1ToolStripMenuItem_Click);
            // 
            // bàiToolStripMenuItem
            // 
            this.bàiToolStripMenuItem.Name = "bàiToolStripMenuItem";
            this.bàiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bàiToolStripMenuItem.Text = "Bài 2";
            this.bàiToolStripMenuItem.Click += new System.EventHandler(this.bài2ToolStripMenuItem_Click);
            // 
            // bài3ToolStripMenuItem
            // 
            this.bài3ToolStripMenuItem.Name = "bài3ToolStripMenuItem";
            this.bài3ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bài3ToolStripMenuItem.Text = "Bài 3";
            this.bài3ToolStripMenuItem.Click += new System.EventHandler(this.bài3ToolStripMenuItem_Click);
            // 
            // bài4ToolStripMenuItem
            // 
            this.bài4ToolStripMenuItem.Name = "bài4ToolStripMenuItem";
            this.bài4ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bài4ToolStripMenuItem.Text = "Bài 4";
            this.bài4ToolStripMenuItem.Click += new System.EventHandler(this.bài4ToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 148);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chương trình chính";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem họVàTênSinhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bài1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bàiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bài3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bài4ToolStripMenuItem;
    }
}
