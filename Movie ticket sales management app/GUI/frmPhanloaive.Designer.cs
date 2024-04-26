namespace Movie_ticket_sales_management_app
{
    partial class frmPhanloaive
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btThem = new Button();
            cbbTenphim = new ComboBox();
            cbbPhong = new ComboBox();
            cbbSuatchieu = new ComboBox();
            cbbVitrighe = new ComboBox();
            cbbGiatien = new ComboBox();
            btCapnhat = new Button();
            grDanhsachve = new GroupBox();
            dgv = new DataGridView();
            groupBox1 = new GroupBox();
            cbbMave = new ComboBox();
            label7 = new Label();
            cbbLoaive = new ComboBox();
            btXoa = new Button();
            btKhoitao = new Button();
            grDanhsachve.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 80);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 0;
            label1.Text = "Loại vé";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(372, 159);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 1;
            label2.Text = "Giá tiền (*)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(372, 80);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 2;
            label3.Text = "Phòng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 124);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 3;
            label4.Text = "Tên phim";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(372, 119);
            label5.Name = "label5";
            label5.Size = new Size(89, 20);
            label5.TabIndex = 4;
            label5.Text = "Vị trí ghế (*)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(372, 34);
            label6.Name = "label6";
            label6.Size = new Size(77, 20);
            label6.TabIndex = 5;
            label6.Text = "Suất chiếu";
            // 
            // btThem
            // 
            btThem.Location = new Point(694, 48);
            btThem.Name = "btThem";
            btThem.Size = new Size(88, 40);
            btThem.TabIndex = 6;
            btThem.Text = "Thêm";
            btThem.UseVisualStyleBackColor = true;
            // 
            // cbbTenphim
            // 
            cbbTenphim.FormattingEnabled = true;
            cbbTenphim.Location = new Point(126, 116);
            cbbTenphim.Name = "cbbTenphim";
            cbbTenphim.Size = new Size(178, 28);
            cbbTenphim.TabIndex = 10;
            // 
            // cbbPhong
            // 
            cbbPhong.FormattingEnabled = true;
            cbbPhong.Location = new Point(480, 72);
            cbbPhong.Name = "cbbPhong";
            cbbPhong.Size = new Size(178, 28);
            cbbPhong.TabIndex = 12;
            // 
            // cbbSuatchieu
            // 
            cbbSuatchieu.FormattingEnabled = true;
            cbbSuatchieu.Location = new Point(480, 31);
            cbbSuatchieu.Name = "cbbSuatchieu";
            cbbSuatchieu.Size = new Size(178, 28);
            cbbSuatchieu.TabIndex = 15;
            // 
            // cbbVitrighe
            // 
            cbbVitrighe.FormattingEnabled = true;
            cbbVitrighe.Location = new Point(480, 116);
            cbbVitrighe.Name = "cbbVitrighe";
            cbbVitrighe.Size = new Size(178, 28);
            cbbVitrighe.TabIndex = 16;
            // 
            // cbbGiatien
            // 
            cbbGiatien.FormattingEnabled = true;
            cbbGiatien.Location = new Point(480, 156);
            cbbGiatien.Name = "cbbGiatien";
            cbbGiatien.Size = new Size(178, 28);
            cbbGiatien.TabIndex = 17;
            // 
            // btCapnhat
            // 
            btCapnhat.Location = new Point(694, 124);
            btCapnhat.Name = "btCapnhat";
            btCapnhat.Size = new Size(88, 40);
            btCapnhat.TabIndex = 18;
            btCapnhat.Text = "Cập nhật";
            btCapnhat.UseVisualStyleBackColor = true;
            btCapnhat.Click += btCapnhat_Click;
            // 
            // grDanhsachve
            // 
            grDanhsachve.Controls.Add(dgv);
            grDanhsachve.Location = new Point(12, 208);
            grDanhsachve.Name = "grDanhsachve";
            grDanhsachve.Size = new Size(929, 274);
            grDanhsachve.TabIndex = 20;
            grDanhsachve.TabStop = false;
            grDanhsachve.Text = "Danh sách vé";
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(0, 26);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.Size = new Size(929, 267);
            dgv.TabIndex = 0;
            dgv.CellContentClick += dgv_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btKhoitao);
            groupBox1.Controls.Add(cbbMave);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(cbbLoaive);
            groupBox1.Controls.Add(btXoa);
            groupBox1.Controls.Add(btCapnhat);
            groupBox1.Controls.Add(cbbGiatien);
            groupBox1.Controls.Add(cbbVitrighe);
            groupBox1.Controls.Add(cbbSuatchieu);
            groupBox1.Controls.Add(cbbPhong);
            groupBox1.Controls.Add(cbbTenphim);
            groupBox1.Controls.Add(btThem);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(929, 190);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            // 
            // cbbMave
            // 
            cbbMave.FormattingEnabled = true;
            cbbMave.Items.AddRange(new object[] { "VIP", "NORMAL" });
            cbbMave.Location = new Point(126, 31);
            cbbMave.Name = "cbbMave";
            cbbMave.Size = new Size(178, 28);
            cbbMave.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 34);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 21;
            label7.Text = "Mã vé";
            // 
            // cbbLoaive
            // 
            cbbLoaive.FormattingEnabled = true;
            cbbLoaive.Items.AddRange(new object[] { "VIP", "NORMAL" });
            cbbLoaive.Location = new Point(126, 77);
            cbbLoaive.Name = "cbbLoaive";
            cbbLoaive.Size = new Size(178, 28);
            cbbLoaive.TabIndex = 20;
            // 
            // btXoa
            // 
            btXoa.Location = new Point(810, 124);
            btXoa.Name = "btXoa";
            btXoa.Size = new Size(88, 40);
            btXoa.TabIndex = 19;
            btXoa.Text = "Xóa";
            btXoa.UseVisualStyleBackColor = true;
            btXoa.Click += btXoa_Click;
            // 
            // btKhoitao
            // 
            btKhoitao.Location = new Point(810, 48);
            btKhoitao.Name = "btKhoitao";
            btKhoitao.Size = new Size(88, 40);
            btKhoitao.TabIndex = 23;
            btKhoitao.Text = "Khởi tạo";
            btKhoitao.UseVisualStyleBackColor = true;
            btKhoitao.Click += btKhoitao_Click;
            // 
            // frmPhanloaive
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(953, 494);
            Controls.Add(groupBox1);
            Controls.Add(grDanhsachve);
            Name = "frmPhanloaive";
            Text = "PHÂN LOẠI VÉ";
            Load += frmPhanloaive_Load;
            grDanhsachve.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btThem;
        private ComboBox cbbTenphim;
        private ComboBox cbbPhong;
        private ComboBox cbbSuatchieu;
        private ComboBox cbbVitrighe;
        private ComboBox cbbGiatien;
        private Button btCapnhat;
        private GroupBox grDanhsachve;
        private DataGridView dgv;
        private GroupBox groupBox1;
        private Button btXoa;
        private ComboBox cbbLoaive;
        private ComboBox cbbMave;
        private Label label7;
        private Button btKhoitao;
    }
}