namespace HuongDanThucHanh
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
            btnReadJSON = new Button();
            btnReadXML = new Button();
            btnWriteReadText = new Button();
            btnWriteXmlWriter = new Button();
            btnWriteXmlSerializer = new Button();
            SuspendLayout();
            // 
            // btnReadJSON
            // 
            btnReadJSON.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnReadJSON.Location = new Point(30, 25);
            btnReadJSON.Name = "btnReadJSON";
            btnReadJSON.Size = new Size(190, 45);
            btnReadJSON.TabIndex = 0;
            btnReadJSON.Text = "Đọc file JSON";
            btnReadJSON.UseVisualStyleBackColor = true;
            btnReadJSON.Click += btnReadJSON_Click;
            // 
            // btnReadXML
            // 
            btnReadXML.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnReadXML.Location = new Point(235, 25);
            btnReadXML.Name = "btnReadXML";
            btnReadXML.Size = new Size(210, 45);
            btnReadXML.TabIndex = 1;
            btnReadXML.Text = "Đọc XML (XmlDocument)";
            btnReadXML.UseVisualStyleBackColor = true;
            btnReadXML.Click += btnReadXML_Click;
            // 
            // btnWriteReadText
            // 
            btnWriteReadText.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnWriteReadText.Location = new Point(460, 25);
            btnWriteReadText.Name = "btnWriteReadText";
            btnWriteReadText.Size = new Size(200, 45);
            btnWriteReadText.TabIndex = 2;
            btnWriteReadText.Text = "Đọc & Ghi file Text";
            btnWriteReadText.UseVisualStyleBackColor = true;
            btnWriteReadText.Click += btnWriteReadText_Click;
            // 
            // btnWriteXmlWriter
            // 
            btnWriteXmlWriter.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnWriteXmlWriter.Location = new Point(30, 85);
            btnWriteXmlWriter.Name = "btnWriteXmlWriter";
            btnWriteXmlWriter.Size = new Size(305, 45);
            btnWriteXmlWriter.TabIndex = 3;
            btnWriteXmlWriter.Text = "Ghi file XML (XmlWriter)";
            btnWriteXmlWriter.UseVisualStyleBackColor = true;
            btnWriteXmlWriter.Click += btnWriteXmlWriter_Click;
            // 
            // btnWriteXmlSerializer
            // 
            btnWriteXmlSerializer.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnWriteXmlSerializer.Location = new Point(355, 85);
            btnWriteXmlSerializer.Name = "btnWriteXmlSerializer";
            btnWriteXmlSerializer.Size = new Size(305, 45);
            btnWriteXmlSerializer.TabIndex = 4;
            btnWriteXmlSerializer.Text = "Ghi file XML (XmlSerializer)";
            btnWriteXmlSerializer.UseVisualStyleBackColor = true;
            btnWriteXmlSerializer.Click += btnWriteXmlSerializer_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(690, 155);
            Controls.Add(btnWriteXmlSerializer);
            Controls.Add(btnWriteXmlWriter);
            Controls.Add(btnWriteReadText);
            Controls.Add(btnReadXML);
            Controls.Add(btnReadJSON);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lab 03 - Thao Tác Tập Tin (Hướng Dẫn Thực Hành)";
            ResumeLayout(false);
        }

        #endregion

        private Button btnReadJSON;
        private Button btnReadXML;
        private Button btnWriteReadText;
        private Button btnWriteXmlWriter;
        private Button btnWriteXmlSerializer;
    }
}
