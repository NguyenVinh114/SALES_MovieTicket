namespace Movie_ticket_sales_management_app.GUI
{
    partial class frmQLBanVevaChiTiet
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            pnlHangGhe = new Panel();
            panel3 = new Panel();
            txtSoVe = new TextBox();
            txtmua = new TextBox();
            txtSoTien = new TextBox();
            panel4 = new Panel();
            btnMua = new Button();
            btnThoat = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            dgvDanhSachHoaDon = new DataGridView();
            colmaHoaDon = new DataGridViewTextBoxColumn();
            colTongTien = new DataGridViewTextBoxColumn();
            colNgayMua = new DataGridViewTextBoxColumn();
            dgvDanhSachChiTietHoaDon = new DataGridView();
            panel2 = new Panel();
            label3 = new Label();
            label2 = new Label();
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachHoaDon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachChiTietHoaDon).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(pnlHangGhe, 0, 1);
            tableLayoutPanel1.Controls.Add(panel3, 0, 2);
            tableLayoutPanel1.Controls.Add(panel4, 0, 3);
            tableLayoutPanel1.Location = new Point(12, 191);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.8504152F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 86.14958F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 148F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 164F));
            tableLayoutPanel1.Size = new Size(1044, 903);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Orange;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1038, 75);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(380, 13);
            label1.Name = "label1";
            label1.Size = new Size(208, 47);
            label1.TabIndex = 0;
            label1.Text = "MÀN CHIẾU";
            // 
            // pnlHangGhe
            // 
            pnlHangGhe.Location = new Point(3, 84);
            pnlHangGhe.Name = "pnlHangGhe";
            pnlHangGhe.Size = new Size(1038, 483);
            pnlHangGhe.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtSoVe);
            panel3.Controls.Add(txtmua);
            panel3.Controls.Add(txtSoTien);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 593);
            panel3.Name = "panel3";
            panel3.Size = new Size(1038, 142);
            panel3.TabIndex = 2;
            // 
            // txtSoVe
            // 
            txtSoVe.Location = new Point(3, 25);
            txtSoVe.Multiline = true;
            txtSoVe.Name = "txtSoVe";
            txtSoVe.Size = new Size(371, 93);
            txtSoVe.TabIndex = 2;
            // 
            // txtmua
            // 
            txtmua.Location = new Point(380, 25);
            txtmua.Multiline = true;
            txtmua.Name = "txtmua";
            txtmua.Size = new Size(397, 93);
            txtmua.TabIndex = 1;
            // 
            // txtSoTien
            // 
            txtSoTien.Location = new Point(790, 25);
            txtSoTien.Multiline = true;
            txtSoTien.Name = "txtSoTien";
            txtSoTien.Size = new Size(234, 93);
            txtSoTien.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnMua);
            panel4.Controls.Add(btnThoat);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 741);
            panel4.Name = "panel4";
            panel4.Size = new Size(1038, 159);
            panel4.TabIndex = 3;
            // 
            // btnMua
            // 
            btnMua.Location = new Point(663, 15);
            btnMua.Name = "btnMua";
            btnMua.Size = new Size(158, 64);
            btnMua.TabIndex = 1;
            btnMua.Text = "MUA VÉ";
            btnMua.UseVisualStyleBackColor = true;
            btnMua.Click += btnMua_Click_1;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = SystemColors.ControlLightLight;
            btnThoat.Location = new Point(864, 15);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(149, 64);
            btnThoat.TabIndex = 0;
            btnThoat.Text = "THOÁT";
            btnThoat.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(dgvDanhSachHoaDon, 0, 0);
            tableLayoutPanel2.Controls.Add(dgvDanhSachChiTietHoaDon, 0, 1);
            tableLayoutPanel2.Location = new Point(1104, 666);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 53.17647F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 46.82353F));
            tableLayoutPanel2.Size = new Size(782, 425);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // dgvDanhSachHoaDon
            // 
            dgvDanhSachHoaDon.AllowUserToAddRows = false;
            dgvDanhSachHoaDon.AllowUserToDeleteRows = false;
            dgvDanhSachHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhSachHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachHoaDon.Columns.AddRange(new DataGridViewColumn[] { colmaHoaDon, colTongTien, colNgayMua });
            dgvDanhSachHoaDon.Dock = DockStyle.Fill;
            dgvDanhSachHoaDon.Location = new Point(3, 3);
            dgvDanhSachHoaDon.Name = "dgvDanhSachHoaDon";
            dgvDanhSachHoaDon.ReadOnly = true;
            dgvDanhSachHoaDon.RowHeadersWidth = 72;
            dgvDanhSachHoaDon.Size = new Size(776, 220);
            dgvDanhSachHoaDon.TabIndex = 0;
            dgvDanhSachHoaDon.CellClick += dgvDanhSachHoaDon_CellClick_1;
            // 
            // colmaHoaDon
            // 
            colmaHoaDon.HeaderText = "Mã Hóa Đơn";
            colmaHoaDon.MinimumWidth = 9;
            colmaHoaDon.Name = "colmaHoaDon";
            colmaHoaDon.ReadOnly = true;
            // 
            // colTongTien
            // 
            colTongTien.HeaderText = "Tổng Tiền";
            colTongTien.MinimumWidth = 9;
            colTongTien.Name = "colTongTien";
            colTongTien.ReadOnly = true;
            // 
            // colNgayMua
            // 
            colNgayMua.HeaderText = "Ngày Mua";
            colNgayMua.MinimumWidth = 9;
            colNgayMua.Name = "colNgayMua";
            colNgayMua.ReadOnly = true;
            // 
            // dgvDanhSachChiTietHoaDon
            // 
            dgvDanhSachChiTietHoaDon.AllowUserToAddRows = false;
            dgvDanhSachChiTietHoaDon.AllowUserToDeleteRows = false;
            dgvDanhSachChiTietHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhSachChiTietHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachChiTietHoaDon.Dock = DockStyle.Fill;
            dgvDanhSachChiTietHoaDon.Location = new Point(3, 229);
            dgvDanhSachChiTietHoaDon.Name = "dgvDanhSachChiTietHoaDon";
            dgvDanhSachChiTietHoaDon.ReadOnly = true;
            dgvDanhSachChiTietHoaDon.RowHeadersWidth = 72;
            dgvDanhSachChiTietHoaDon.Size = new Size(776, 193);
            dgvDanhSachChiTietHoaDon.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.NavajoWhite;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(2, 37);
            panel2.Name = "panel2";
            panel2.Size = new Size(1916, 65);
            panel2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(1432, 12);
            label3.Name = "label3";
            label3.Size = new Size(424, 38);
            label3.TabIndex = 1;
            label3.Text = "26/4/2024 | 21:00 PM - 22:30 PM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(26, 12);
            label2.Name = "label2";
            label2.Size = new Size(686, 38);
            label2.TabIndex = 0;
            label2.Text = "CGV Thủ Dầu Một | CINEMA 14 3D Alpha | Doraemon ";
            // 
            // panel5
            // 
            panel5.BackgroundImage = Properties.Resources._122e38823bf89aa6c3e9__1_;
            panel5.ForeColor = SystemColors.Info;
            panel5.Location = new Point(1107, 191);
            panel5.Name = "panel5";
            panel5.Size = new Size(407, 447);
            panel5.TabIndex = 3;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Yellow;
            panel6.Location = new Point(1602, 194);
            panel6.Name = "panel6";
            panel6.Size = new Size(38, 35);
            panel6.TabIndex = 4;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Blue;
            panel7.Location = new Point(1602, 287);
            panel7.Name = "panel7";
            panel7.Size = new Size(38, 35);
            panel7.TabIndex = 5;
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.Location = new Point(1602, 379);
            panel8.Name = "panel8";
            panel8.Size = new Size(38, 35);
            panel8.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1680, 194);
            label4.Name = "label4";
            label4.Size = new Size(94, 30);
            label4.TabIndex = 7;
            label4.Text = "ĐÃ MUA";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1680, 287);
            label5.Name = "label5";
            label5.Size = new Size(108, 30);
            label5.TabIndex = 8;
            label5.Text = "ĐÃ CHỌN";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1680, 384);
            label6.Name = "label6";
            label6.Size = new Size(129, 30);
            label6.TabIndex = 9;
            label6.Text = "GHẾ TRỐNG";
            // 
            // frmQLBanVevaChiTiet
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1918, 1108);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel2);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Name = "frmQLBanVevaChiTiet";
            Text = "Bán Vé";
            Load += frmQLBanVevaChiTietHD_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachHoaDon).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachChiTietHoaDon).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label label1;
        private Panel pnlHangGhe;
        private Panel panel3;
        private TextBox txtSoVe;
        private TextBox txtmua;
        private TextBox txtSoTien;
        private Panel panel4;
        private Button btnMua;
        private Button btnThoat;
        private TableLayoutPanel tableLayoutPanel2;
        private DataGridView dgvDanhSachHoaDon;
        private DataGridView dgvDanhSachChiTietHoaDon;
        private DataGridViewTextBoxColumn colmaHoaDon;
        private DataGridViewTextBoxColumn colTongTien;
        private DataGridViewTextBoxColumn colNgayMua;
        private Panel panel2;
        private Label label3;
        private Label label2;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}