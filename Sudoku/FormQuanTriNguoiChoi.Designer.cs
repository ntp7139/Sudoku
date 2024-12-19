namespace Sudoku
{
    partial class FormQuanTriNguoiChoi
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
            dtGV_Quantritaikhoan = new DataGridView();
            column_Taikhoan = new DataGridViewTextBoxColumn();
            column_Matkhau = new DataGridViewTextBoxColumn();
            column_email = new DataGridViewTextBoxColumn();
            column_phanquyen = new DataGridViewTextBoxColumn();
            btn_Themtaikhoan = new Button();
            btn_Suuataikhoan = new Button();
            btn_Xoataikhoan = new Button();
            btn_Tailai = new Button();
            pn_Giaodienchinh = new Panel();
            pn_Themnguoichoi = new Panel();
            btn_Thoat_Them = new Button();
            btn_Them = new Button();
            rB_admin_Them = new RadioButton();
            rB_user_Them = new RadioButton();
            tB_Email_Them = new TextBox();
            tB_Matkhau_Them = new TextBox();
            tB_Taikhoan_Them = new TextBox();
            lb_Phanquyen_Them = new Label();
            lb_Email_Them = new Label();
            lb_Matkhau_Them = new Label();
            lb_Taikhoan_Them = new Label();
            pn_Suanguoichoi = new Panel();
            rB_admin_Sua = new RadioButton();
            rB_user_Sua = new RadioButton();
            tB_Email_Sua = new TextBox();
            tB_Matkhau_Sua = new TextBox();
            btn_Thoat_Sua = new Button();
            btn_Thaydoi = new Button();
            lb_phanquyen_Sua = new Label();
            lb_email_Sua = new Label();
            lb_Matkhau_Sua = new Label();
            tB_Taikhoan_Sua = new TextBox();
            lb_Nhaptaikhoan_sua = new Label();
            pn_Xoa = new Panel();
            btn_Thoat_Xoa = new Button();
            btn_Xoa = new Button();
            tB_Taikhoan_xoa = new TextBox();
            lb_taikhoan_xoa = new Label();
            ((System.ComponentModel.ISupportInitialize)dtGV_Quantritaikhoan).BeginInit();
            pn_Giaodienchinh.SuspendLayout();
            pn_Themnguoichoi.SuspendLayout();
            pn_Suanguoichoi.SuspendLayout();
            pn_Xoa.SuspendLayout();
            SuspendLayout();
            // 
            // dtGV_Quantritaikhoan
            // 
            dtGV_Quantritaikhoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGV_Quantritaikhoan.Columns.AddRange(new DataGridViewColumn[] { column_Taikhoan, column_Matkhau, column_email, column_phanquyen });
            dtGV_Quantritaikhoan.Location = new Point(2, 63);
            dtGV_Quantritaikhoan.Name = "dtGV_Quantritaikhoan";
            dtGV_Quantritaikhoan.RowHeadersWidth = 62;
            dtGV_Quantritaikhoan.Size = new Size(796, 372);
            dtGV_Quantritaikhoan.TabIndex = 0;
            dtGV_Quantritaikhoan.RowPostPaint += dataGridView1_RowPostPaint;
            // 
            // column_Taikhoan
            // 
            column_Taikhoan.HeaderText = "Tài khoản";
            column_Taikhoan.MinimumWidth = 8;
            column_Taikhoan.Name = "column_Taikhoan";
            column_Taikhoan.Width = 150;
            // 
            // column_Matkhau
            // 
            column_Matkhau.HeaderText = "Mật khẩu";
            column_Matkhau.MinimumWidth = 8;
            column_Matkhau.Name = "column_Matkhau";
            column_Matkhau.Width = 150;
            // 
            // column_email
            // 
            column_email.HeaderText = "Email";
            column_email.MinimumWidth = 8;
            column_email.Name = "column_email";
            column_email.Width = 230;
            // 
            // column_phanquyen
            // 
            column_phanquyen.HeaderText = "Quyền truy cập";
            column_phanquyen.MinimumWidth = 8;
            column_phanquyen.Name = "column_phanquyen";
            column_phanquyen.Width = 200;
            // 
            // btn_Themtaikhoan
            // 
            btn_Themtaikhoan.Location = new Point(125, 9);
            btn_Themtaikhoan.Name = "btn_Themtaikhoan";
            btn_Themtaikhoan.Size = new Size(149, 43);
            btn_Themtaikhoan.TabIndex = 1;
            btn_Themtaikhoan.Text = "Thêm";
            btn_Themtaikhoan.UseVisualStyleBackColor = true;
            btn_Themtaikhoan.Click += btn_Themtaikhoan_Click;
            // 
            // btn_Suuataikhoan
            // 
            btn_Suuataikhoan.Location = new Point(369, 9);
            btn_Suuataikhoan.Name = "btn_Suuataikhoan";
            btn_Suuataikhoan.Size = new Size(149, 43);
            btn_Suuataikhoan.TabIndex = 2;
            btn_Suuataikhoan.Text = "Sửa";
            btn_Suuataikhoan.UseVisualStyleBackColor = true;
            btn_Suuataikhoan.Click += btn_Suuataikhoan_Click;
            // 
            // btn_Xoataikhoan
            // 
            btn_Xoataikhoan.Location = new Point(615, 9);
            btn_Xoataikhoan.Name = "btn_Xoataikhoan";
            btn_Xoataikhoan.Size = new Size(149, 43);
            btn_Xoataikhoan.TabIndex = 3;
            btn_Xoataikhoan.Text = "Xóa";
            btn_Xoataikhoan.UseVisualStyleBackColor = true;
            btn_Xoataikhoan.Click += btn_Xoataikhoan_Click;
            // 
            // btn_Tailai
            // 
            btn_Tailai.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Tailai.Location = new Point(20, 11);
            btn_Tailai.Name = "btn_Tailai";
            btn_Tailai.Size = new Size(53, 41);
            btn_Tailai.TabIndex = 5;
            btn_Tailai.UseVisualStyleBackColor = true;
            btn_Tailai.Click += btn_Tailai_Click;
            // 
            // pn_Giaodienchinh
            // 
            pn_Giaodienchinh.Controls.Add(btn_Tailai);
            pn_Giaodienchinh.Controls.Add(btn_Xoataikhoan);
            pn_Giaodienchinh.Controls.Add(btn_Suuataikhoan);
            pn_Giaodienchinh.Controls.Add(btn_Themtaikhoan);
            pn_Giaodienchinh.Controls.Add(dtGV_Quantritaikhoan);
            pn_Giaodienchinh.Location = new Point(3, 3);
            pn_Giaodienchinh.Name = "pn_Giaodienchinh";
            pn_Giaodienchinh.Size = new Size(794, 447);
            pn_Giaodienchinh.TabIndex = 6;
            // 
            // pn_Themnguoichoi
            // 
            pn_Themnguoichoi.Controls.Add(btn_Thoat_Them);
            pn_Themnguoichoi.Controls.Add(btn_Them);
            pn_Themnguoichoi.Controls.Add(rB_admin_Them);
            pn_Themnguoichoi.Controls.Add(rB_user_Them);
            pn_Themnguoichoi.Controls.Add(tB_Email_Them);
            pn_Themnguoichoi.Controls.Add(tB_Matkhau_Them);
            pn_Themnguoichoi.Controls.Add(tB_Taikhoan_Them);
            pn_Themnguoichoi.Controls.Add(lb_Phanquyen_Them);
            pn_Themnguoichoi.Controls.Add(lb_Email_Them);
            pn_Themnguoichoi.Controls.Add(lb_Matkhau_Them);
            pn_Themnguoichoi.Controls.Add(lb_Taikhoan_Them);
            pn_Themnguoichoi.Location = new Point(3, 3);
            pn_Themnguoichoi.Name = "pn_Themnguoichoi";
            pn_Themnguoichoi.Size = new Size(794, 447);
            pn_Themnguoichoi.TabIndex = 12;
            pn_Themnguoichoi.Visible = false;
            pn_Themnguoichoi.Paint += pn_Themnguoichoi_Paint;
            // 
            // btn_Thoat_Them
            // 
            btn_Thoat_Them.Location = new Point(463, 286);
            btn_Thoat_Them.Name = "btn_Thoat_Them";
            btn_Thoat_Them.Size = new Size(145, 55);
            btn_Thoat_Them.TabIndex = 10;
            btn_Thoat_Them.Text = "Thoát";
            btn_Thoat_Them.UseVisualStyleBackColor = true;
            btn_Thoat_Them.Click += btn_Thoat_Them_Click;
            // 
            // btn_Them
            // 
            btn_Them.Location = new Point(119, 286);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(145, 55);
            btn_Them.TabIndex = 9;
            btn_Them.Text = "Thêm";
            btn_Them.UseVisualStyleBackColor = true;
            btn_Them.Click += btn_Them_Click;
            // 
            // rB_admin_Them
            // 
            rB_admin_Them.AutoSize = true;
            rB_admin_Them.Location = new Point(402, 215);
            rB_admin_Them.Name = "rB_admin_Them";
            rB_admin_Them.Size = new Size(87, 29);
            rB_admin_Them.TabIndex = 8;
            rB_admin_Them.TabStop = true;
            rB_admin_Them.Text = "admin";
            rB_admin_Them.UseVisualStyleBackColor = true;
            // 
            // rB_user_Them
            // 
            rB_user_Them.AutoSize = true;
            rB_user_Them.Location = new Point(221, 215);
            rB_user_Them.Name = "rB_user_Them";
            rB_user_Them.Size = new Size(70, 29);
            rB_user_Them.TabIndex = 7;
            rB_user_Them.TabStop = true;
            rB_user_Them.Text = "user";
            rB_user_Them.UseVisualStyleBackColor = true;
            // 
            // tB_Email_Them
            // 
            tB_Email_Them.Location = new Point(221, 162);
            tB_Email_Them.Name = "tB_Email_Them";
            tB_Email_Them.Size = new Size(360, 31);
            tB_Email_Them.TabIndex = 6;
            // 
            // tB_Matkhau_Them
            // 
            tB_Matkhau_Them.Location = new Point(221, 99);
            tB_Matkhau_Them.Name = "tB_Matkhau_Them";
            tB_Matkhau_Them.Size = new Size(360, 31);
            tB_Matkhau_Them.TabIndex = 5;
            // 
            // tB_Taikhoan_Them
            // 
            tB_Taikhoan_Them.Location = new Point(221, 44);
            tB_Taikhoan_Them.Name = "tB_Taikhoan_Them";
            tB_Taikhoan_Them.Size = new Size(360, 31);
            tB_Taikhoan_Them.TabIndex = 4;
            // 
            // lb_Phanquyen_Them
            // 
            lb_Phanquyen_Them.AutoSize = true;
            lb_Phanquyen_Them.Location = new Point(70, 215);
            lb_Phanquyen_Them.Name = "lb_Phanquyen_Them";
            lb_Phanquyen_Them.Size = new Size(105, 25);
            lb_Phanquyen_Them.TabIndex = 3;
            lb_Phanquyen_Them.Text = "Phân quyền";
            // 
            // lb_Email_Them
            // 
            lb_Email_Them.AutoSize = true;
            lb_Email_Them.Location = new Point(70, 162);
            lb_Email_Them.Name = "lb_Email_Them";
            lb_Email_Them.Size = new Size(54, 25);
            lb_Email_Them.TabIndex = 2;
            lb_Email_Them.Text = "Email";
            // 
            // lb_Matkhau_Them
            // 
            lb_Matkhau_Them.AutoSize = true;
            lb_Matkhau_Them.Location = new Point(70, 105);
            lb_Matkhau_Them.Name = "lb_Matkhau_Them";
            lb_Matkhau_Them.Size = new Size(87, 25);
            lb_Matkhau_Them.TabIndex = 1;
            lb_Matkhau_Them.Text = "Mật Khẩu";
            // 
            // lb_Taikhoan_Them
            // 
            lb_Taikhoan_Them.AutoSize = true;
            lb_Taikhoan_Them.Location = new Point(70, 50);
            lb_Taikhoan_Them.Name = "lb_Taikhoan_Them";
            lb_Taikhoan_Them.Size = new Size(87, 25);
            lb_Taikhoan_Them.TabIndex = 0;
            lb_Taikhoan_Them.Text = "Tài Khoản";
            // 
            // pn_Suanguoichoi
            // 
            pn_Suanguoichoi.Controls.Add(rB_admin_Sua);
            pn_Suanguoichoi.Controls.Add(rB_user_Sua);
            pn_Suanguoichoi.Controls.Add(tB_Email_Sua);
            pn_Suanguoichoi.Controls.Add(tB_Matkhau_Sua);
            pn_Suanguoichoi.Controls.Add(btn_Thoat_Sua);
            pn_Suanguoichoi.Controls.Add(btn_Thaydoi);
            pn_Suanguoichoi.Controls.Add(lb_phanquyen_Sua);
            pn_Suanguoichoi.Controls.Add(lb_email_Sua);
            pn_Suanguoichoi.Controls.Add(lb_Matkhau_Sua);
            pn_Suanguoichoi.Controls.Add(tB_Taikhoan_Sua);
            pn_Suanguoichoi.Controls.Add(lb_Nhaptaikhoan_sua);
            pn_Suanguoichoi.Location = new Point(134, 16);
            pn_Suanguoichoi.Name = "pn_Suanguoichoi";
            pn_Suanguoichoi.Size = new Size(478, 261);
            pn_Suanguoichoi.TabIndex = 13;
            pn_Suanguoichoi.Visible = false;
            // 
            // rB_admin_Sua
            // 
            rB_admin_Sua.AutoSize = true;
            rB_admin_Sua.Location = new Point(300, 166);
            rB_admin_Sua.Name = "rB_admin_Sua";
            rB_admin_Sua.Size = new Size(87, 29);
            rB_admin_Sua.TabIndex = 10;
            rB_admin_Sua.Text = "admin";
            rB_admin_Sua.UseVisualStyleBackColor = true;
            rB_admin_Sua.Visible = false;
            // 
            // rB_user_Sua
            // 
            rB_user_Sua.AutoSize = true;
            rB_user_Sua.Location = new Point(183, 166);
            rB_user_Sua.Name = "rB_user_Sua";
            rB_user_Sua.Size = new Size(70, 29);
            rB_user_Sua.TabIndex = 9;
            rB_user_Sua.Text = "user";
            rB_user_Sua.UseVisualStyleBackColor = true;
            rB_user_Sua.Visible = false;
            // 
            // tB_Email_Sua
            // 
            tB_Email_Sua.Location = new Point(183, 118);
            tB_Email_Sua.Name = "tB_Email_Sua";
            tB_Email_Sua.Size = new Size(233, 31);
            tB_Email_Sua.TabIndex = 8;
            tB_Email_Sua.Visible = false;
            // 
            // tB_Matkhau_Sua
            // 
            tB_Matkhau_Sua.Location = new Point(183, 69);
            tB_Matkhau_Sua.Name = "tB_Matkhau_Sua";
            tB_Matkhau_Sua.Size = new Size(233, 31);
            tB_Matkhau_Sua.TabIndex = 7;
            tB_Matkhau_Sua.Visible = false;
            // 
            // btn_Thoat_Sua
            // 
            btn_Thoat_Sua.Location = new Point(270, 219);
            btn_Thoat_Sua.Name = "btn_Thoat_Sua";
            btn_Thoat_Sua.Size = new Size(117, 35);
            btn_Thoat_Sua.TabIndex = 6;
            btn_Thoat_Sua.Text = "Thoát";
            btn_Thoat_Sua.UseVisualStyleBackColor = true;
            btn_Thoat_Sua.Click += btn_Thoat_Sua_Click;
            // 
            // btn_Thaydoi
            // 
            btn_Thaydoi.Location = new Point(71, 219);
            btn_Thaydoi.Name = "btn_Thaydoi";
            btn_Thaydoi.Size = new Size(117, 35);
            btn_Thaydoi.TabIndex = 5;
            btn_Thaydoi.Text = "Thay đổi";
            btn_Thaydoi.UseVisualStyleBackColor = true;
            btn_Thaydoi.Click += btn_Thaydoi_Click;
            // 
            // lb_phanquyen_Sua
            // 
            lb_phanquyen_Sua.AutoSize = true;
            lb_phanquyen_Sua.Location = new Point(12, 166);
            lb_phanquyen_Sua.Name = "lb_phanquyen_Sua";
            lb_phanquyen_Sua.Size = new Size(105, 25);
            lb_phanquyen_Sua.TabIndex = 4;
            lb_phanquyen_Sua.Text = "Phân quyền";
            lb_phanquyen_Sua.Visible = false;
            // 
            // lb_email_Sua
            // 
            lb_email_Sua.AutoSize = true;
            lb_email_Sua.Location = new Point(12, 118);
            lb_email_Sua.Name = "lb_email_Sua";
            lb_email_Sua.Size = new Size(54, 25);
            lb_email_Sua.TabIndex = 3;
            lb_email_Sua.Text = "Email";
            lb_email_Sua.Visible = false;
            // 
            // lb_Matkhau_Sua
            // 
            lb_Matkhau_Sua.AutoSize = true;
            lb_Matkhau_Sua.Location = new Point(12, 69);
            lb_Matkhau_Sua.Name = "lb_Matkhau_Sua";
            lb_Matkhau_Sua.Size = new Size(86, 25);
            lb_Matkhau_Sua.TabIndex = 2;
            lb_Matkhau_Sua.Text = "Mật khẩu";
            lb_Matkhau_Sua.Visible = false;
            // 
            // tB_Taikhoan_Sua
            // 
            tB_Taikhoan_Sua.Location = new Point(183, 15);
            tB_Taikhoan_Sua.Name = "tB_Taikhoan_Sua";
            tB_Taikhoan_Sua.Size = new Size(233, 31);
            tB_Taikhoan_Sua.TabIndex = 1;
            tB_Taikhoan_Sua.KeyDown += tB_Taikhoan_Sua_Enter;
            // 
            // lb_Nhaptaikhoan_sua
            // 
            lb_Nhaptaikhoan_sua.AutoSize = true;
            lb_Nhaptaikhoan_sua.Location = new Point(12, 18);
            lb_Nhaptaikhoan_sua.Name = "lb_Nhaptaikhoan_sua";
            lb_Nhaptaikhoan_sua.Size = new Size(133, 25);
            lb_Nhaptaikhoan_sua.TabIndex = 0;
            lb_Nhaptaikhoan_sua.Text = "Nhập tài khoản";
            // 
            // pn_Xoa
            // 
            pn_Xoa.Controls.Add(btn_Thoat_Xoa);
            pn_Xoa.Controls.Add(btn_Xoa);
            pn_Xoa.Controls.Add(tB_Taikhoan_xoa);
            pn_Xoa.Controls.Add(lb_taikhoan_xoa);
            pn_Xoa.Location = new Point(214, 106);
            pn_Xoa.Name = "pn_Xoa";
            pn_Xoa.Size = new Size(449, 121);
            pn_Xoa.TabIndex = 14;
            pn_Xoa.Visible = false;
            // 
            // btn_Thoat_Xoa
            // 
            btn_Thoat_Xoa.Location = new Point(259, 68);
            btn_Thoat_Xoa.Name = "btn_Thoat_Xoa";
            btn_Thoat_Xoa.Size = new Size(91, 41);
            btn_Thoat_Xoa.TabIndex = 3;
            btn_Thoat_Xoa.Text = "Thoát";
            btn_Thoat_Xoa.UseVisualStyleBackColor = true;
            btn_Thoat_Xoa.Click += btn_Thoat_Xoa_Click;
            // 
            // btn_Xoa
            // 
            btn_Xoa.Location = new Point(88, 68);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new Size(91, 41);
            btn_Xoa.TabIndex = 2;
            btn_Xoa.Text = "Xóa";
            btn_Xoa.UseVisualStyleBackColor = true;
            btn_Xoa.Click += btn_Xoa_Click;
            // 
            // tB_Taikhoan_xoa
            // 
            tB_Taikhoan_xoa.Location = new Point(171, 11);
            tB_Taikhoan_xoa.Name = "tB_Taikhoan_xoa";
            tB_Taikhoan_xoa.Size = new Size(255, 31);
            tB_Taikhoan_xoa.TabIndex = 1;
            // 
            // lb_taikhoan_xoa
            // 
            lb_taikhoan_xoa.AutoSize = true;
            lb_taikhoan_xoa.Location = new Point(33, 17);
            lb_taikhoan_xoa.Name = "lb_taikhoan_xoa";
            lb_taikhoan_xoa.Size = new Size(87, 25);
            lb_taikhoan_xoa.TabIndex = 0;
            lb_taikhoan_xoa.Text = "Tài Khoản";
            // 
            // FormQuanTriNguoiChoi
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 449);
            Controls.Add(pn_Xoa);
            Controls.Add(pn_Suanguoichoi);
            Controls.Add(pn_Giaodienchinh);
            Controls.Add(pn_Themnguoichoi);
            Name = "FormQuanTriNguoiChoi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản trị người chơi";
            Load += FormQuanTriHeThong_Load;
            ((System.ComponentModel.ISupportInitialize)dtGV_Quantritaikhoan).EndInit();
            pn_Giaodienchinh.ResumeLayout(false);
            pn_Themnguoichoi.ResumeLayout(false);
            pn_Themnguoichoi.PerformLayout();
            pn_Suanguoichoi.ResumeLayout(false);
            pn_Suanguoichoi.PerformLayout();
            pn_Xoa.ResumeLayout(false);
            pn_Xoa.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

       
        private Button btn_Tailai;
        private Button btn_Xoataikhoan;
        private Button btn_Suuataikhoan;
        private Button btn_Themtaikhoan;
        private DataGridView dtGV_Quantritaikhoan;
        private DataGridViewTextBoxColumn column_Taikhoan;
        private DataGridViewTextBoxColumn column_Matkhau;
        private DataGridViewTextBoxColumn column_email;
        private DataGridViewTextBoxColumn column_phanquyen;
        private TabControl tbC_QuanTriHeThong;
        private Panel pn_Giaodienchinh;
        private Panel pn_Themnguoichoi;
        private Button btn_Thoat_Them;
        private Button btn_Them;
        private RadioButton rB_admin_Them;
        private RadioButton rB_user_Them;
        private TextBox tB_Email_Them;
        private TextBox tB_Matkhau_Them;
        private TextBox tB_Taikhoan_Them;
        private Label lb_Phanquyen_Them;
        private Label lb_Email_Them;
        private Label lb_Matkhau_Them;
        private Label lb_Taikhoan_Them;
        private Panel pn_Suanguoichoi;
        private Button btn_Thaydoi;
        private Label lb_phanquyen_Sua;
        private Label lb_email_Sua;
        private Label lb_Matkhau_Sua;
        private TextBox tB_Taikhoan_Sua;
        private Label lb_Nhaptaikhoan_sua;
        private RadioButton rB_admin_Sua;
        private RadioButton rB_user_Sua;
        private TextBox tB_Email_Sua;
        private TextBox tB_Matkhau_Sua;
        private Button btn_Thoat_Sua;
        private Panel pn_Xoa;
        private Label lb_taikhoan_xoa;
        private Button btn_Thoat_Xoa;
        private Button btn_Xoa;
        private TextBox tB_Taikhoan_xoa;
    }
}