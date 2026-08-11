namespace QuanLyNhaThuoc
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
            components = new System.ComponentModel.Container();
            sdtBox = new TextBox();
            sdt = new Label();
            nameBox = new TextBox();
            name = new Label();
            products = new Label();
            register = new Button();
            find = new Button();
            leaderboard = new DataGridView();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            contextMenuStrip1 = new ContextMenuStrip(components);
            contextMenuStrip2 = new ContextMenuStrip(components);
            contextMenuStrip3 = new ContextMenuStrip(components);
            contextMenuStrip4 = new ContextMenuStrip(components);
            contextMenuStrip5 = new ContextMenuStrip(components);
            money = new Label();
            customer = new DataGridView();
            menuPro = new DataGridView();
            points = new Label();
            calc = new Button();
            proBox = new ComboBox();
            addProduct = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)leaderboard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)menuPro).BeginInit();
            SuspendLayout();
            // 
            // sdtBox
            // 
            sdtBox.Location = new Point(94, 8);
            sdtBox.Name = "sdtBox";
            sdtBox.Size = new Size(267, 23);
            sdtBox.TabIndex = 0;
            sdtBox.TextChanged += sdtBox_TextChanged;
            // 
            // sdt
            // 
            sdt.AutoSize = true;
            sdt.Location = new Point(21, 11);
            sdt.Name = "sdt";
            sdt.Size = new Size(28, 15);
            sdt.TabIndex = 5;
            sdt.Text = "SĐT";
            // 
            // nameBox
            // 
            nameBox.Location = new Point(94, 46);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(267, 23);
            nameBox.TabIndex = 1;
            nameBox.TextChanged += nameBox_TextChanged;
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(21, 49);
            name.Name = "name";
            name.Size = new Size(60, 15);
            name.TabIndex = 6;
            name.Text = "Họ và Tên";
            // 
            // products
            // 
            products.AutoSize = true;
            products.Location = new Point(21, 89);
            products.Name = "products";
            products.Size = new Size(41, 15);
            products.TabIndex = 1;
            products.Text = "Thuốc";
            products.Click += label3_Click;
            // 
            // register
            // 
            register.Location = new Point(615, 31);
            register.Name = "register";
            register.Size = new Size(117, 23);
            register.TabIndex = 6;
            register.Text = "Đăng ký khách mới";
            register.UseVisualStyleBackColor = true;
            register.Click += register_Click;
            // 
            // find
            // 
            find.Location = new Point(405, 31);
            find.Name = "find";
            find.Size = new Size(117, 23);
            find.TabIndex = 5;
            find.Text = "Tra cứu";
            find.UseVisualStyleBackColor = true;
            find.Click += find_Click;
            // 
            // leaderboard
            // 
            leaderboard.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            leaderboard.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            leaderboard.Location = new Point(769, 31);
            leaderboard.Name = "leaderboard";
            leaderboard.Size = new Size(327, 535);
            leaderboard.TabIndex = 5;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(61, 4);
            // 
            // contextMenuStrip3
            // 
            contextMenuStrip3.Name = "contextMenuStrip3";
            contextMenuStrip3.Size = new Size(61, 4);
            // 
            // contextMenuStrip4
            // 
            contextMenuStrip4.Name = "contextMenuStrip4";
            contextMenuStrip4.Size = new Size(61, 4);
            // 
            // contextMenuStrip5
            // 
            contextMenuStrip5.Name = "contextMenuStrip5";
            contextMenuStrip5.Size = new Size(61, 4);
            // 
            // money
            // 
            money.AutoSize = true;
            money.ForeColor = Color.Red;
            money.Location = new Point(310, 129);
            money.Name = "money";
            money.Size = new Size(32, 15);
            money.TabIndex = 7;
            money.Text = "000đ";
            money.Click += label4_Click;
            // 
            // customer
            // 
            customer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            customer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            customer.Location = new Point(405, 89);
            customer.Name = "customer";
            customer.Size = new Size(327, 475);
            customer.TabIndex = 8;
            // 
            // menuPro
            // 
            menuPro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            menuPro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            menuPro.Location = new Point(21, 205);
            menuPro.Name = "menuPro";
            menuPro.Size = new Size(340, 359);
            menuPro.TabIndex = 8;
            // 
            // points
            // 
            points.AutoSize = true;
            points.BackColor = Color.Black;
            points.ForeColor = Color.Lime;
            points.Location = new Point(94, 129);
            points.Name = "points";
            points.Size = new Size(19, 15);
            points.TabIndex = 7;
            points.Text = "00";
            points.Click += label4_Click;
            // 
            // calc
            // 
            calc.Location = new Point(231, 162);
            calc.Name = "calc";
            calc.Size = new Size(130, 23);
            calc.TabIndex = 4;
            calc.Text = "Tính Tiền";
            calc.UseVisualStyleBackColor = true;
            calc.Click += button1_Click_1;
            // 
            // proBox
            // 
            proBox.FormattingEnabled = true;
            proBox.Location = new Point(94, 86);
            proBox.Name = "proBox";
            proBox.Size = new Size(267, 23);
            proBox.TabIndex = 2;
            proBox.DropDown += proBox_DropDown;
            proBox.TextUpdate += proBox_TextUpdate;
            proBox.TextChanged += proBox_TextChanged;
            // 
            // addProduct
            // 
            addProduct.Location = new Point(21, 162);
            addProduct.Name = "addProduct";
            addProduct.Size = new Size(130, 23);
            addProduct.TabIndex = 3;
            addProduct.Text = "Thêm Thuốc";
            addProduct.UseVisualStyleBackColor = true;
            addProduct.Click += addPro_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(878, 5);
            label1.Name = "label1";
            label1.Size = new Size(116, 21);
            label1.TabIndex = 9;
            label1.Text = "Bảng Xếp Hạng";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1121, 608);
            Controls.Add(label1);
            Controls.Add(proBox);
            Controls.Add(menuPro);
            Controls.Add(customer);
            Controls.Add(points);
            Controls.Add(money);
            Controls.Add(leaderboard);
            Controls.Add(addProduct);
            Controls.Add(calc);
            Controls.Add(find);
            Controls.Add(register);
            Controls.Add(products);
            Controls.Add(name);
            Controls.Add(sdt);
            Controls.Add(nameBox);
            Controls.Add(sdtBox);
            Name = "Form1";
            Text = "QuanLyNhaThuoc";
            ((System.ComponentModel.ISupportInitialize)leaderboard).EndInit();
            ((System.ComponentModel.ISupportInitialize)customer).EndInit();
            ((System.ComponentModel.ISupportInitialize)menuPro).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private TextBox sdtBox;
        private Label sdt;
        private TextBox nameBox;
        private Label name;
        private Label products;
        private Button register;
        private Button find;
        private DataGridView leaderboard;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
        private ContextMenuStrip contextMenuStrip3;
        private ContextMenuStrip contextMenuStrip4;
        private ContextMenuStrip contextMenuStrip5;
        private Label money;
        private DataGridView customer;
        private DataGridView menuPro;
        private Label points;
        private Button calc;
        private ComboBox proBox;
        private Button addProduct;
        private Label label1;
    }
}
