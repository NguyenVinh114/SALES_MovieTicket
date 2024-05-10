namespace Movie_ticket_sales_management_app.GUI
{
    partial class frmDoanhThu
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            button1 = new Button();
            button_Xoa = new Button();
            button_Sua = new Button();
            button_Them = new Button();
            textBox_SLVe = new TextBox();
            textBox_GiaVe = new TextBox();
            comboBox_LoaiVe = new ComboBox();
            comboBox_TenPhim = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            textBox_TìmKiem = new TextBox();
            label6 = new Label();
            button_Thoat = new Button();
            button_ThongKe = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font(".VnBahamasB", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Salmon;
            label1.Location = new Point(275, 43);
            label1.Name = "label1";
            label1.Size = new Size(279, 38);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ DOANH THU";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(10, 208);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(872, 407);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(button_Xoa);
            groupBox1.Controls.Add(button_Sua);
            groupBox1.Controls.Add(button_Them);
            groupBox1.Controls.Add(textBox_SLVe);
            groupBox1.Controls.Add(textBox_GiaVe);
            groupBox1.Controls.Add(comboBox_LoaiVe);
            groupBox1.Controls.Add(comboBox_TenPhim);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            groupBox1.Location = new Point(888, 117);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(350, 498);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin";
            // 
            // button1
            // 
            button1.BackColor = Color.LightCoral;
            button1.Location = new Point(201, 435);
            button1.Name = "button1";
            button1.Size = new Size(141, 44);
            button1.TabIndex = 11;
            button1.Text = "Mới";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button_Xoa
            // 
            button_Xoa.BackColor = Color.LightCoral;
            button_Xoa.Location = new Point(13, 435);
            button_Xoa.Name = "button_Xoa";
            button_Xoa.Size = new Size(141, 44);
            button_Xoa.TabIndex = 10;
            button_Xoa.Text = "Xóa";
            button_Xoa.UseVisualStyleBackColor = false;
            button_Xoa.Click += button_Xoa_Click;
            // 
            // button_Sua
            // 
            button_Sua.BackColor = Color.LightCoral;
            button_Sua.Location = new Point(201, 363);
            button_Sua.Name = "button_Sua";
            button_Sua.Size = new Size(141, 44);
            button_Sua.TabIndex = 9;
            button_Sua.Text = "Sửa";
            button_Sua.UseVisualStyleBackColor = false;
            button_Sua.Click += button_Sua_Click;
            // 
            // button_Them
            // 
            button_Them.BackColor = Color.LightCoral;
            button_Them.Location = new Point(13, 363);
            button_Them.Name = "button_Them";
            button_Them.Size = new Size(141, 44);
            button_Them.TabIndex = 8;
            button_Them.Text = "Thêm";
            button_Them.UseVisualStyleBackColor = false;
            button_Them.Click += button_Them_Click;
            // 
            // textBox_SLVe
            // 
            textBox_SLVe.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            textBox_SLVe.Location = new Point(129, 265);
            textBox_SLVe.Name = "textBox_SLVe";
            textBox_SLVe.Size = new Size(213, 30);
            textBox_SLVe.TabIndex = 7;
            textBox_SLVe.KeyPress += textBox_SLVe_KeyPress;
            // 
            // textBox_GiaVe
            // 
            textBox_GiaVe.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            textBox_GiaVe.Location = new Point(129, 186);
            textBox_GiaVe.Name = "textBox_GiaVe";
            textBox_GiaVe.ReadOnly = true;
            textBox_GiaVe.Size = new Size(215, 30);
            textBox_GiaVe.TabIndex = 6;
            // 
            // comboBox_LoaiVe
            // 
            comboBox_LoaiVe.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            comboBox_LoaiVe.FormattingEnabled = true;
            comboBox_LoaiVe.Items.AddRange(new object[] { "VIP", "NORMAL" });
            comboBox_LoaiVe.Location = new Point(129, 122);
            comboBox_LoaiVe.Name = "comboBox_LoaiVe";
            comboBox_LoaiVe.Size = new Size(213, 31);
            comboBox_LoaiVe.TabIndex = 5;
            comboBox_LoaiVe.SelectedIndexChanged += comboBox_LoaiVe_SelectedIndexChanged;
            // 
            // comboBox_TenPhim
            // 
            comboBox_TenPhim.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            comboBox_TenPhim.FormattingEnabled = true;
            comboBox_TenPhim.Items.AddRange(new object[] { "Nhà bà nữ", "Cái giá của hạnh phúc", "Lật mặt 7", "SPX family code: white", "Doraemon: Phiêu lưu đến one piece cùng naruto", "Gintama: Cuộc chiến dân làm đủ nghề", "Vực hỗn mang vs Tháp quang minh" });
            comboBox_TenPhim.Location = new Point(129, 57);
            comboBox_TenPhim.Name = "comboBox_TenPhim";
            comboBox_TenPhim.Size = new Size(215, 31);
            comboBox_TenPhim.TabIndex = 4;
            comboBox_TenPhim.SelectedIndexChanged += comboBox_TenPhim_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label5.ForeColor = Color.DarkRed;
            label5.Location = new Point(6, 261);
            label5.Name = "label5";
            label5.Size = new Size(117, 28);
            label5.TabIndex = 3;
            label5.Text = "Số lượng vé";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label4.ForeColor = Color.DarkRed;
            label4.Location = new Point(13, 116);
            label4.Name = "label4";
            label4.Size = new Size(73, 28);
            label4.TabIndex = 2;
            label4.Text = "Loại vé";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label3.ForeColor = Color.DarkRed;
            label3.Location = new Point(13, 186);
            label3.Name = "label3";
            label3.Size = new Size(66, 28);
            label3.TabIndex = 1;
            label3.Text = "Giá vé";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label2.ForeColor = Color.DarkRed;
            label2.Location = new Point(6, 53);
            label2.Name = "label2";
            label2.Size = new Size(91, 28);
            label2.TabIndex = 0;
            label2.Text = "Tên phim";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox_TìmKiem);
            groupBox2.Controls.Add(label6);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            groupBox2.Location = new Point(10, 117);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(872, 85);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm kiếm";
            // 
            // textBox_TìmKiem
            // 
            textBox_TìmKiem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            textBox_TìmKiem.Location = new Point(342, 36);
            textBox_TìmKiem.Name = "textBox_TìmKiem";
            textBox_TìmKiem.Size = new Size(230, 34);
            textBox_TìmKiem.TabIndex = 8;
            textBox_TìmKiem.TextChanged += textBox_TìmKiem_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label6.ForeColor = Color.Chocolate;
            label6.Location = new Point(224, 39);
            label6.Name = "label6";
            label6.Size = new Size(97, 28);
            label6.TabIndex = 8;
            label6.Text = "Tên phim";
            // 
            // button_Thoat
            // 
            button_Thoat.BackColor = Color.LightCoral;
            button_Thoat.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            button_Thoat.Location = new Point(1091, 40);
            button_Thoat.Name = "button_Thoat";
            button_Thoat.Size = new Size(141, 41);
            button_Thoat.TabIndex = 11;
            button_Thoat.Text = "Thoát";
            button_Thoat.UseVisualStyleBackColor = false;
            button_Thoat.Click += button_Thoat_Click;
            // 
            // button_ThongKe
            // 
            button_ThongKe.BackColor = Color.LightCoral;
            button_ThongKe.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            button_ThongKe.Location = new Point(901, 40);
            button_ThongKe.Name = "button_ThongKe";
            button_ThongKe.Size = new Size(141, 41);
            button_ThongKe.TabIndex = 12;
            button_ThongKe.Text = "Thống kê";
            button_ThongKe.UseVisualStyleBackColor = false;
            // 
            // frmDoanhThu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(1276, 650);
            Controls.Add(button_Thoat);
            Controls.Add(button_ThongKe);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "frmDoanhThu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thống kê doanh thu";
            Load += frmDoanhThu_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Label label2;
        private GroupBox groupBox2;
        private Button button_Them;
        private TextBox textBox_SLVe;
        private TextBox textBox_GiaVe;
        private ComboBox comboBox_LoaiVe;
        private ComboBox comboBox_TenPhim;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox textBox_TìmKiem;
        private Label label6;
        private Button button_Thoat;
        private Button button_Xoa;
        private Button button_Sua;
        private Button button_ThongKe;
        private Button button1;
    }
}