namespace BaiTapWindowForm
{
    partial class frmChinh
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnBai1;
        private System.Windows.Forms.ToolStripButton btnBai2;
        private System.Windows.Forms.ToolStripButton btnBai3;

        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnBai1 = new System.Windows.Forms.ToolStripButton();
            this.btnBai2 = new System.Windows.Forms.ToolStripButton();
            this.btnBai3 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBai1,
            this.btnBai2,
            this.btnBai3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(480, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnBai1
            // 
            this.btnBai1.Name = "btnBai1";
            this.btnBai1.Size = new System.Drawing.Size(56, 22);
            this.btnBai1.Text = "Bài 1";
            this.btnBai1.Click += new System.EventHandler(this.btnBai1_Click);
            // 
            // btnBai2
            // 
            this.btnBai2.Name = "btnBai2";
            this.btnBai2.Size = new System.Drawing.Size(56, 22);
            this.btnBai2.Text = "Bài 2";
            this.btnBai2.Click += new System.EventHandler(this.btnBai2_Click);
            // 
            // btnBai3
            // 
            this.btnBai3.Name = "btnBai3";
            this.btnBai3.Size = new System.Drawing.Size(56, 22);
            this.btnBai3.Text = "Bài 3";
            this.btnBai3.Click += new System.EventHandler(this.btnBai3_Click);
            // 
            // frmChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 260);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmChinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chương trình chính";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
