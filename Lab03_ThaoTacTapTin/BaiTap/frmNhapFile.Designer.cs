namespace BaiTap
{
    partial class frmNhapFile
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

        private void InitializeComponent()
        {
            lblFormat = new Label();
            rdoJson = new RadioButton();
            rdoXml = new RadioButton();
            rdoTxt = new RadioButton();
            lblFilePath = new Label();
            txtFilePath = new TextBox();
            btnBrowse = new Button();
            btnNhap = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // lblFormat
            // 
            lblFormat.AutoSize = true;
            lblFormat.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFormat.Location = new Point(25, 20);
            lblFormat.Name = "lblFormat";
            lblFormat.Size = new Size(137, 20);
            lblFormat.TabIndex = 0;
            lblFormat.Text = "Chọn định dạng tệp:";
            // 
            // rdoJson
            // 
            rdoJson.AutoSize = true;
            rdoJson.Checked = true;
            rdoJson.Location = new Point(170, 18);
            rdoJson.Name = "rdoJson";
            rdoJson.Size = new Size(111, 24);
            rdoJson.TabIndex = 1;
            rdoJson.TabStop = true;
            rdoJson.Text = "JSON (*.json)";
            rdoJson.UseVisualStyleBackColor = true;
            rdoJson.CheckedChanged += rdoJson_CheckedChanged;
            // 
            // rdoXml
            // 
            rdoXml.AutoSize = true;
            rdoXml.Location = new Point(290, 18);
            rdoXml.Name = "rdoXml";
            rdoXml.Size = new Size(105, 24);
            rdoXml.TabIndex = 2;
            rdoXml.Text = "XML (*.xml)";
            rdoXml.UseVisualStyleBackColor = true;
            rdoXml.CheckedChanged += rdoXml_CheckedChanged;
            // 
            // rdoTxt
            // 
            rdoTxt.AutoSize = true;
            rdoTxt.Location = new Point(405, 18);
            rdoTxt.Name = "rdoTxt";
            rdoTxt.Size = new Size(99, 24);
            rdoTxt.TabIndex = 3;
            rdoTxt.Text = "Text (*.txt)";
            rdoTxt.UseVisualStyleBackColor = true;
            rdoTxt.CheckedChanged += rdoTxt_CheckedChanged;
            // 
            // lblFilePath
            // 
            lblFilePath.AutoSize = true;
            lblFilePath.Location = new Point(25, 65);
            lblFilePath.Name = "lblFilePath";
            lblFilePath.Size = new Size(106, 20);
            lblFilePath.TabIndex = 4;
            lblFilePath.Text = "Đường dẫn tệp:";
            // 
            // txtFilePath
            // 
            txtFilePath.Location = new Point(140, 62);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.Size = new Size(365, 27);
            txtFilePath.TabIndex = 5;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(515, 60);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(95, 30);
            btnBrowse.TabIndex = 6;
            btnBrowse.Text = "Duyệt file...";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // btnNhap
            // 
            btnNhap.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnNhap.Location = new Point(190, 110);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(130, 35);
            btnNhap.TabIndex = 7;
            btnNhap.Text = "Nhập dữ liệu";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(335, 110);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(100, 35);
            btnThoat.TabIndex = 8;
            btnThoat.Text = "Đóng";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // frmNhapFile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 160);
            Controls.Add(btnThoat);
            Controls.Add(btnNhap);
            Controls.Add(btnBrowse);
            Controls.Add(txtFilePath);
            Controls.Add(lblFilePath);
            Controls.Add(rdoTxt);
            Controls.Add(rdoXml);
            Controls.Add(rdoJson);
            Controls.Add(lblFormat);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmNhapFile";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Nhập dữ liệu sinh viên từ tệp";
            Load += frmNhapFile_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblFormat;
        private RadioButton rdoJson;
        private RadioButton rdoXml;
        private RadioButton rdoTxt;
        private Label lblFilePath;
        private TextBox txtFilePath;
        private Button btnBrowse;
        private Button btnNhap;
        private Button btnThoat;
    }
}
