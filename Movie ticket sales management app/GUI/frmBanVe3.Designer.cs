namespace Movie_ticket_sales_management_app.GUI
{
    partial class frmBanVe3
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
            pictureBox1 = new PictureBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel8 = new Panel();
            panel7 = new Panel();
            panel6 = new Panel();
            panel2 = new Panel();
            label3 = new Label();
            label2 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            dgvDanhSachHoaDon = new DataGridView();
            colmaHoaDon = new DataGridViewTextBoxColumn();
            colTongTien = new DataGridViewTextBoxColumn();
            colNgayMua = new DataGridViewTextBoxColumn();
            dgvDanhSachChiTietHoaDon = new DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachHoaDon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachChiTietHoaDon).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources._3;
            pictureBox1.Location = new Point(736, 125);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(193, 266);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1120, 254);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(91, 20);
            label6.TabIndex = 29;
            label6.Text = "GHẾ TRỐNG";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1120, 189);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 28;
            label5.Text = "ĐÃ CHỌN";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1120, 127);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 27;
            label4.Text = "ĐÃ MUA";
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.Location = new Point(1068, 251);
            panel8.Margin = new Padding(2);
            panel8.Name = "panel8";
            panel8.Size = new Size(25, 23);
            panel8.TabIndex = 26;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Blue;
            panel7.Location = new Point(1068, 189);
            panel7.Margin = new Padding(2);
            panel7.Name = "panel7";
            panel7.Size = new Size(25, 23);
            panel7.TabIndex = 25;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Yellow;
            panel6.Location = new Point(1068, 127);
            panel6.Margin = new Padding(2);
            panel6.Name = "panel6";
            panel6.Size = new Size(25, 23);
            panel6.TabIndex = 24;
            // 
            // panel2
            // 
            panel2.BackColor = Color.NavajoWhite;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(1, 23);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1277, 43);
            panel2.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(955, 8);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(302, 28);
            label3.TabIndex = 1;
            label3.Text = "26/4/2024 | 21:00 PM - 22:30 PM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(17, 8);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(467, 28);
            label2.TabIndex = 0;
            label2.Text = "CGV Thủ Dầu Một | CINEMA 14 3D Alpha | Yu-Gi-Oh";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(dgvDanhSachHoaDon, 0, 0);
            tableLayoutPanel2.Controls.Add(dgvDanhSachChiTietHoaDon, 0, 1);
            tableLayoutPanel2.Location = new Point(736, 442);
            tableLayoutPanel2.Margin = new Padding(2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 53.17647F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 46.82353F));
            tableLayoutPanel2.Size = new Size(521, 283);
            tableLayoutPanel2.TabIndex = 22;
            // 
            // dgvDanhSachHoaDon
            // 
            dgvDanhSachHoaDon.AllowUserToAddRows = false;
            dgvDanhSachHoaDon.AllowUserToDeleteRows = false;
            dgvDanhSachHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhSachHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachHoaDon.Columns.AddRange(new DataGridViewColumn[] { colmaHoaDon, colTongTien, colNgayMua });
            dgvDanhSachHoaDon.Dock = DockStyle.Fill;
            dgvDanhSachHoaDon.Location = new Point(2, 2);
            dgvDanhSachHoaDon.Margin = new Padding(2);
            dgvDanhSachHoaDon.Name = "dgvDanhSachHoaDon";
            dgvDanhSachHoaDon.ReadOnly = true;
            dgvDanhSachHoaDon.RowHeadersWidth = 72;
            dgvDanhSachHoaDon.Size = new Size(517, 146);
            dgvDanhSachHoaDon.TabIndex = 0;
            dgvDanhSachHoaDon.CellClick += dgvDanhSachHoaDon_CellClick;
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
            dgvDanhSachChiTietHoaDon.Location = new Point(2, 152);
            dgvDanhSachChiTietHoaDon.Margin = new Padding(2);
            dgvDanhSachChiTietHoaDon.Name = "dgvDanhSachChiTietHoaDon";
            dgvDanhSachChiTietHoaDon.ReadOnly = true;
            dgvDanhSachChiTietHoaDon.RowHeadersWidth = 72;
            dgvDanhSachChiTietHoaDon.Size = new Size(517, 129);
            dgvDanhSachChiTietHoaDon.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(pnlHangGhe, 0, 1);
            tableLayoutPanel1.Controls.Add(panel3, 0, 2);
            tableLayoutPanel1.Controls.Add(panel4, 0, 3);
            tableLayoutPanel1.Location = new Point(8, 125);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.8504152F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 86.14958F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 104F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 98F));
            tableLayoutPanel1.Size = new Size(696, 602);
            tableLayoutPanel1.TabIndex = 21;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Orange;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(2, 2);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(692, 51);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(253, 9);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(149, 35);
            label1.TabIndex = 0;
            label1.Text = "MÀN CHIẾU";
            // 
            // pnlHangGhe
            // 
            pnlHangGhe.Location = new Point(2, 57);
            pnlHangGhe.Margin = new Padding(2);
            pnlHangGhe.Name = "pnlHangGhe";
            pnlHangGhe.Size = new Size(692, 300);
            pnlHangGhe.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtSoVe);
            panel3.Controls.Add(txtmua);
            panel3.Controls.Add(txtSoTien);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(2, 401);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(692, 100);
            panel3.TabIndex = 2;
            // 
            // txtSoVe
            // 
            txtSoVe.Location = new Point(2, 17);
            txtSoVe.Margin = new Padding(2);
            txtSoVe.Multiline = true;
            txtSoVe.Name = "txtSoVe";
            txtSoVe.Size = new Size(249, 63);
            txtSoVe.TabIndex = 2;
            // 
            // txtmua
            // 
            txtmua.Location = new Point(253, 17);
            txtmua.Margin = new Padding(2);
            txtmua.Multiline = true;
            txtmua.Name = "txtmua";
            txtmua.Size = new Size(266, 63);
            txtmua.TabIndex = 1;
            // 
            // txtSoTien
            // 
            txtSoTien.Location = new Point(527, 17);
            txtSoTien.Margin = new Padding(2);
            txtSoTien.Multiline = true;
            txtSoTien.Name = "txtSoTien";
            txtSoTien.Size = new Size(157, 63);
            txtSoTien.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnMua);
            panel4.Controls.Add(btnThoat);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(2, 505);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(692, 95);
            panel4.TabIndex = 3;
            // 
            // btnMua
            // 
            btnMua.Location = new Point(442, 10);
            btnMua.Margin = new Padding(2);
            btnMua.Name = "btnMua";
            btnMua.Size = new Size(105, 43);
            btnMua.TabIndex = 1;
            btnMua.Text = "MUA VÉ";
            btnMua.UseVisualStyleBackColor = true;
            btnMua.Click += btnMua_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = SystemColors.ControlLightLight;
            btnThoat.Location = new Point(576, 10);
            btnThoat.Margin = new Padding(2);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(99, 43);
            btnThoat.TabIndex = 0;
            btnThoat.Text = "THOÁT";
            btnThoat.UseVisualStyleBackColor = false;
            // 
            // frmBanVe3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1279, 751);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel2);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Name = "frmBanVe3";
            Text = "YU-GI-OH";
            Load += frmBanVe3_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachHoaDon).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachChiTietHoaDon).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Panel panel8;
        private Panel panel7;
        private Panel panel6;
        private Panel panel2;
        private Label label3;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel2;
        private DataGridView dgvDanhSachHoaDon;
        private DataGridViewTextBoxColumn colmaHoaDon;
        private DataGridViewTextBoxColumn colTongTien;
        private DataGridViewTextBoxColumn colNgayMua;
        private DataGridView dgvDanhSachChiTietHoaDon;
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
    }
}