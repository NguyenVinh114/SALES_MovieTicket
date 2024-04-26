namespace Movie_ticket_sales_management_app
{
    partial class frmDangnhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangnhap));
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            textBox1_TenTaiKhoan = new TextBox();
            textBox2_MatKhau = new TextBox();
            linkLabel_QuenMatKhau = new LinkLabel();
            linkLabel_DangKy = new LinkLabel();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(36, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(501, 263);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.padlock;
            pictureBox3.InitialImage = Properties.Resources.padlock;
            pictureBox3.Location = new Point(108, 347);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(30, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // textBox1_TenTaiKhoan
            // 
            textBox1_TenTaiKhoan.Location = new Point(185, 298);
            textBox1_TenTaiKhoan.Name = "textBox1_TenTaiKhoan";
            textBox1_TenTaiKhoan.Size = new Size(287, 27);
            textBox1_TenTaiKhoan.TabIndex = 3;
            // 
            // textBox2_MatKhau
            // 
            textBox2_MatKhau.Location = new Point(185, 347);
            textBox2_MatKhau.Name = "textBox2_MatKhau";
            textBox2_MatKhau.PasswordChar = '*';
            textBox2_MatKhau.Size = new Size(287, 27);
            textBox2_MatKhau.TabIndex = 4;
            // 
            // linkLabel_QuenMatKhau
            // 
            linkLabel_QuenMatKhau.AutoSize = true;
            linkLabel_QuenMatKhau.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            linkLabel_QuenMatKhau.Location = new Point(108, 412);
            linkLabel_QuenMatKhau.Name = "linkLabel_QuenMatKhau";
            linkLabel_QuenMatKhau.Size = new Size(134, 25);
            linkLabel_QuenMatKhau.TabIndex = 5;
            linkLabel_QuenMatKhau.TabStop = true;
            linkLabel_QuenMatKhau.Text = "Quên mật khẩu";
            linkLabel_QuenMatKhau.LinkClicked += linkLabel_QuenMatKhau_LinkClicked;
            // 
            // linkLabel_DangKy
            // 
            linkLabel_DangKy.AutoSize = true;
            linkLabel_DangKy.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            linkLabel_DangKy.Location = new Point(394, 412);
            linkLabel_DangKy.Name = "linkLabel_DangKy";
            linkLabel_DangKy.Size = new Size(78, 25);
            linkLabel_DangKy.TabIndex = 6;
            linkLabel_DangKy.TabStop = true;
            linkLabel_DangKy.Text = "Đăng ký";
            linkLabel_DangKy.LinkClicked += linkLabel_DangKy_LinkClicked;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.user;
            pictureBox2.InitialImage = Properties.Resources.padlock;
            pictureBox2.Location = new Point(108, 298);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = Color.Salmon;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            button1.Location = new Point(215, 469);
            button1.Name = "button1";
            button1.Size = new Size(136, 46);
            button1.TabIndex = 8;
            button1.Text = "Đăng nhập";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // frmDangnhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(574, 552);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Controls.Add(linkLabel_DangKy);
            Controls.Add(linkLabel_QuenMatKhau);
            Controls.Add(textBox2_MatKhau);
            Controls.Add(textBox1_TenTaiKhoan);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Location = new Point(72, 5);
            Name = "frmDangnhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmDangnhap";
            Load += frmDangnhap_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private TextBox textBox1_TenTaiKhoan;
        private TextBox textBox2_MatKhau;
        private LinkLabel linkLabel_QuenMatKhau;
        private LinkLabel linkLabel_DangKy;
        private PictureBox pictureBox2;
        private Button button1;
    }
}