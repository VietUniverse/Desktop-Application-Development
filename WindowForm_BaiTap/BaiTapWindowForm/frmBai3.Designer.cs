namespace BaiTapWindowForm
{
    partial class frmBai3
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

        private System.Windows.Forms.GroupBox grpCong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.Label lblKetQuaCong;

        private System.Windows.Forms.GroupBox grpTongDay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Button btnTongDaySo;
        private System.Windows.Forms.Label lblKetQuaTong;

        private void InitializeComponent()
        {
            this.grpCong = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.btnCong = new System.Windows.Forms.Button();
            this.lblKetQuaCong = new System.Windows.Forms.Label();
            this.grpTongDay = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.btnTongDaySo = new System.Windows.Forms.Button();
            this.lblKetQuaTong = new System.Windows.Forms.Label();
            this.grpCong.SuspendLayout();
            this.grpTongDay.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCong
            // 
            this.grpCong.Controls.Add(this.lblKetQuaCong);
            this.grpCong.Controls.Add(this.btnCong);
            this.grpCong.Controls.Add(this.txtB);
            this.grpCong.Controls.Add(this.label2);
            this.grpCong.Controls.Add(this.txtA);
            this.grpCong.Controls.Add(this.label1);
            this.grpCong.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCong.Location = new System.Drawing.Point(20, 20);
            this.grpCong.Name = "grpCong";
            this.grpCong.Size = new System.Drawing.Size(380, 140);
            this.grpCong.TabIndex = 0;
            this.grpCong.TabStop = false;
            this.grpCong.Text = "Cộng hai số (Hàm tĩnh CongHaiSo)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số a:";
            // 
            // txtA
            // 
            this.txtA.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtA.Location = new System.Drawing.Point(65, 27);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(70, 25);
            this.txtA.TabIndex = 1;
            this.txtA.Text = "15";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(155, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số b:";
            // 
            // txtB
            // 
            this.txtB.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtB.Location = new System.Drawing.Point(200, 27);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(70, 25);
            this.txtB.TabIndex = 3;
            this.txtB.Text = "25";
            // 
            // btnCong
            // 
            this.btnCong.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCong.Location = new System.Drawing.Point(280, 25);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(85, 28);
            this.btnCong.TabIndex = 4;
            this.btnCong.Text = "Cộng hai số";
            this.btnCong.UseVisualStyleBackColor = true;
            this.btnCong.Click += new System.EventHandler(this.btnCong_Click);
            // 
            // lblKetQuaCong
            // 
            this.lblKetQuaCong.AutoSize = true;
            this.lblKetQuaCong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQuaCong.ForeColor = System.Drawing.Color.Blue;
            this.lblKetQuaCong.Location = new System.Drawing.Point(20, 85);
            this.lblKetQuaCong.Name = "lblKetQuaCong";
            this.lblKetQuaCong.Size = new System.Drawing.Size(109, 19);
            this.lblKetQuaCong.TabIndex = 5;
            this.lblKetQuaCong.Text = "Kết quả s = 40";
            // 
            // grpTongDay
            // 
            this.grpTongDay.Controls.Add(this.lblKetQuaTong);
            this.grpTongDay.Controls.Add(this.btnTongDaySo);
            this.grpTongDay.Controls.Add(this.txtN);
            this.grpTongDay.Controls.Add(this.label3);
            this.grpTongDay.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTongDay.Location = new System.Drawing.Point(20, 175);
            this.grpTongDay.Name = "grpTongDay";
            this.grpTongDay.Size = new System.Drawing.Size(380, 130);
            this.grpTongDay.TabIndex = 1;
            this.grpTongDay.TabStop = false;
            this.grpTongDay.Text = "Tính tổng dãy số (Hàm tĩnh TongDaySo)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nhập n:";
            // 
            // txtN
            // 
            this.txtN.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtN.Location = new System.Drawing.Point(85, 32);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(80, 25);
            this.txtN.TabIndex = 1;
            this.txtN.Text = "10";
            // 
            // btnTongDaySo
            // 
            this.btnTongDaySo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTongDaySo.Location = new System.Drawing.Point(180, 30);
            this.btnTongDaySo.Name = "btnTongDaySo";
            this.btnTongDaySo.Size = new System.Drawing.Size(180, 28);
            this.btnTongDaySo.TabIndex = 2;
            this.btnTongDaySo.Text = "Tính tổng (1 đến n)";
            this.btnTongDaySo.UseVisualStyleBackColor = true;
            this.btnTongDaySo.Click += new System.EventHandler(this.btnTongDaySo_Click);
            // 
            // lblKetQuaTong
            // 
            this.lblKetQuaTong.AutoSize = true;
            this.lblKetQuaTong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQuaTong.ForeColor = System.Drawing.Color.Red;
            this.lblKetQuaTong.Location = new System.Drawing.Point(20, 80);
            this.lblKetQuaTong.Name = "lblKetQuaTong";
            this.lblKetQuaTong.Size = new System.Drawing.Size(176, 19);
            this.lblKetQuaTong.TabIndex = 3;
            this.lblKetQuaTong.Text = "Tổng dãy số (1..10) = 55";
            // 
            // frmBai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 325);
            this.Controls.Add(this.grpTongDay);
            this.Controls.Add(this.grpCong);
            this.Name = "frmBai3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bài 3 - Hàm tĩnh và Tính toán";
            this.grpCong.ResumeLayout(false);
            this.grpCong.PerformLayout();
            this.grpTongDay.ResumeLayout(false);
            this.grpTongDay.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion
    }
}
