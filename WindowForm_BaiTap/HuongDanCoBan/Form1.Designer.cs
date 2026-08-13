namespace HuongDanCoBan
{
    partial class form1
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnExe = new System.Windows.Forms.Button();
            this.lblSomething = new System.Windows.Forms.Label();
            this.txtCopy = new System.Windows.Forms.TextBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(197, 93);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(93, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nhập tên của bạn";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(327, 90);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            // 
            // btnExe
            // 
            this.btnExe.Location = new System.Drawing.Point(515, 88);
            this.btnExe.Name = "btnExe";
            this.btnExe.Size = new System.Drawing.Size(75, 23);
            this.btnExe.TabIndex = 2;
            this.btnExe.Text = "Xử lý";
            this.btnExe.UseVisualStyleBackColor = true;
            this.btnExe.Click += new System.EventHandler(this.btnExe_Click);
            // 
            // lblSomething
            // 
            this.lblSomething.AutoSize = true;
            this.lblSomething.Location = new System.Drawing.Point(197, 189);
            this.lblSomething.Name = "lblSomething";
            this.lblSomething.Size = new System.Drawing.Size(69, 13);
            this.lblSomething.TabIndex = 3;
            this.lblSomething.Text = "Bạn đã nhập";
            // 
            // txtCopy
            // 
            this.txtCopy.Location = new System.Drawing.Point(327, 186);
            this.txtCopy.Name = "txtCopy";
            this.txtCopy.ReadOnly = true;
            this.txtCopy.Size = new System.Drawing.Size(100, 20);
            this.txtCopy.TabIndex = 4;
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(515, 184);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 2;
            this.btnCopy.Text = "Sao chép";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCopy);
            this.Controls.Add(this.lblSomething);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnExe);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "form1";
            this.Text = "Chương trình đầu tiên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnExe;
        private System.Windows.Forms.Label lblSomething;
        private System.Windows.Forms.TextBox txtCopy;
        private System.Windows.Forms.Button btnCopy;
    }
}

