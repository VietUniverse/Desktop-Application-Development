namespace HuongDanCoBan_Bai2
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
            this.sexChoices = new System.Windows.Forms.GroupBox();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.colorChoices = new System.Windows.Forms.GroupBox();
            this.radOrange = new System.Windows.Forms.RadioButton();
            this.radCyan = new System.Windows.Forms.RadioButton();
            this.btnColor = new System.Windows.Forms.Button();
            this.sexChoices.SuspendLayout();
            this.colorChoices.SuspendLayout();
            this.SuspendLayout();
            // 
            // sexChoices
            // 
            this.sexChoices.Controls.Add(this.radFemale);
            this.sexChoices.Controls.Add(this.radMale);
            this.sexChoices.Location = new System.Drawing.Point(419, 46);
            this.sexChoices.Name = "sexChoices";
            this.sexChoices.Size = new System.Drawing.Size(200, 100);
            this.sexChoices.TabIndex = 0;
            this.sexChoices.TabStop = false;
            this.sexChoices.Text = "Chọn giới tính";
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.Checked = true;
            this.radMale.Location = new System.Drawing.Point(23, 31);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(47, 17);
            this.radMale.TabIndex = 1;
            this.radMale.TabStop = true;
            this.radMale.Text = "Nam";
            this.radMale.UseVisualStyleBackColor = true;
            this.radMale.CheckedChanged += new System.EventHandler(this.radMale_CheckedChange);
            // 
            // radFemale
            // 
            this.radFemale.AutoSize = true;
            this.radFemale.Location = new System.Drawing.Point(23, 77);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(39, 17);
            this.radFemale.TabIndex = 1;
            this.radFemale.Text = "Nữ";
            this.radFemale.UseVisualStyleBackColor = true;
            this.radFemale.CheckedChanged += new System.EventHandler(this.radFemale_CheckedChange);
            // 
            // colorChoices
            // 
            this.colorChoices.Controls.Add(this.btnColor);
            this.colorChoices.Controls.Add(this.radOrange);
            this.colorChoices.Controls.Add(this.radCyan);
            this.colorChoices.Location = new System.Drawing.Point(254, 207);
            this.colorChoices.Name = "colorChoices";
            this.colorChoices.Size = new System.Drawing.Size(200, 100);
            this.colorChoices.TabIndex = 0;
            this.colorChoices.TabStop = false;
            this.colorChoices.Text = "Chọn màu";
            // 
            // radOrange
            // 
            this.radOrange.AutoSize = true;
            this.radOrange.Location = new System.Drawing.Point(23, 77);
            this.radOrange.Name = "radOrange";
            this.radOrange.Size = new System.Drawing.Size(69, 17);
            this.radOrange.TabIndex = 1;
            this.radOrange.Text = "Màu cam";
            this.radOrange.UseVisualStyleBackColor = true;
            // 
            // radCyan
            // 
            this.radCyan.AutoSize = true;
            this.radCyan.Checked = true;
            this.radCyan.Location = new System.Drawing.Point(23, 31);
            this.radCyan.Name = "radCyan";
            this.radCyan.Size = new System.Drawing.Size(72, 17);
            this.radCyan.TabIndex = 1;
            this.radCyan.TabStop = true;
            this.radCyan.Text = "Màu xanh";
            this.radCyan.UseVisualStyleBackColor = true;
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(119, 52);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(75, 23);
            this.btnColor.TabIndex = 1;
            this.btnColor.Text = "Tô màu";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.colorChoices);
            this.Controls.Add(this.sexChoices);
            this.Name = "Form1";
            this.Text = "Form1";
            this.sexChoices.ResumeLayout(false);
            this.sexChoices.PerformLayout();
            this.colorChoices.ResumeLayout(false);
            this.colorChoices.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox sexChoices;
        private System.Windows.Forms.RadioButton radFemale;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.GroupBox colorChoices;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.RadioButton radOrange;
        private System.Windows.Forms.RadioButton radCyan;
    }
}

