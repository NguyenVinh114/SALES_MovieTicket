namespace Movie_ticket_sales_management_app
{
    partial class frmDangky
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
            textBox_TenTaiKhoan = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox_MatKhau = new TextBox();
            label3 = new Label();
            textBox_XNMatKhau = new TextBox();
            label4 = new Label();
            textBox_Email = new TextBox();
            button_DangKy = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._5d1c34b8f9491d82bf62391f7ac4e4a3;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(584, 242);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // textBox_TenTaiKhoan
            // 
            textBox_TenTaiKhoan.Location = new Point(298, 286);
            textBox_TenTaiKhoan.Name = "textBox_TenTaiKhoan";
            textBox_TenTaiKhoan.Size = new Size(253, 27);
            textBox_TenTaiKhoan.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label1.Location = new Point(72, 285);
            label1.Name = "label1";
            label1.Size = new Size(120, 25);
            label1.TabIndex = 9;
            label1.Text = "Tên tài khoản:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label2.Location = new Point(72, 334);
            label2.Name = "label2";
            label2.Size = new Size(90, 25);
            label2.TabIndex = 11;
            label2.Text = "Mật khẩu:";
            // 
            // textBox_MatKhau
            // 
            textBox_MatKhau.Location = new Point(298, 335);
            textBox_MatKhau.Name = "textBox_MatKhau";
            textBox_MatKhau.PasswordChar = '*';
            textBox_MatKhau.Size = new Size(253, 27);
            textBox_MatKhau.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label3.Location = new Point(72, 383);
            label3.Name = "label3";
            label3.Size = new Size(167, 25);
            label3.TabIndex = 13;
            label3.Text = "Xác nhận mật khẩu:";
            // 
            // textBox_XNMatKhau
            // 
            textBox_XNMatKhau.Location = new Point(298, 381);
            textBox_XNMatKhau.Name = "textBox_XNMatKhau";
            textBox_XNMatKhau.PasswordChar = '*';
            textBox_XNMatKhau.Size = new Size(253, 27);
            textBox_XNMatKhau.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label4.Location = new Point(72, 434);
            label4.Name = "label4";
            label4.Size = new Size(58, 25);
            label4.TabIndex = 15;
            label4.Text = "Email:";
            // 
            // textBox_Email
            // 
            textBox_Email.Location = new Point(298, 432);
            textBox_Email.Name = "textBox_Email";
            textBox_Email.Size = new Size(253, 27);
            textBox_Email.TabIndex = 14;
            // 
            // button_DangKy
            // 
            button_DangKy.AutoSize = true;
            button_DangKy.BackColor = Color.Salmon;
            button_DangKy.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            button_DangKy.Location = new Point(233, 501);
            button_DangKy.Name = "button_DangKy";
            button_DangKy.Size = new Size(136, 46);
            button_DangKy.TabIndex = 16;
            button_DangKy.Text = "Đăng ký";
            button_DangKy.UseVisualStyleBackColor = false;
            button_DangKy.Click += button_DangKy_Click;
            // 
            // frmDangky
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(608, 578);
            Controls.Add(button_DangKy);
            Controls.Add(label4);
            Controls.Add(textBox_Email);
            Controls.Add(label3);
            Controls.Add(textBox_XNMatKhau);
            Controls.Add(label2);
            Controls.Add(textBox_MatKhau);
            Controls.Add(label1);
            Controls.Add(textBox_TenTaiKhoan);
            Controls.Add(pictureBox1);
            Name = "frmDangky";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmDangky";
            Load += frmDangky_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBox_TenTaiKhoan;
        private Label label1;
        private Label label2;
        private TextBox textBox_MatKhau;
        private Label label3;
        private TextBox textBox_XNMatKhau;
        private Label label4;
        private TextBox textBox_Email;
        private Button button_DangKy;
    }
}