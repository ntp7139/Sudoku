namespace Sudoku
{
    partial class FormDangNhap
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
            button1 = new Button();
            button2 = new Button();
            tabPage2 = new TabPage();
            tabPage1 = new TabPage();
            pn_DangNhap = new Panel();
            lb_DangKy = new Label();
            lb_QuenMatKhau = new Label();
            btn_Thoat = new Button();
            btn_DongY = new Button();
            lb_TieuDe = new Label();
            tB_MatKhau = new TextBox();
            lb_MatKhau = new Label();
            lb_TaiKhoan = new Label();
            tB_TaiKhoan = new TextBox();
            tCt_FormDangNhap = new TabControl();
            lbDoimatkhau = new Label();
            pn_DangNhap.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(0, 0);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(793, 413);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(793, 413);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // pn_DangNhap
            // 
            pn_DangNhap.Controls.Add(lbDoimatkhau);
            pn_DangNhap.Controls.Add(lb_DangKy);
            pn_DangNhap.Controls.Add(lb_QuenMatKhau);
            pn_DangNhap.Controls.Add(btn_Thoat);
            pn_DangNhap.Controls.Add(btn_DongY);
            pn_DangNhap.Controls.Add(lb_TieuDe);
            pn_DangNhap.Controls.Add(tB_MatKhau);
            pn_DangNhap.Controls.Add(lb_MatKhau);
            pn_DangNhap.Controls.Add(lb_TaiKhoan);
            pn_DangNhap.Controls.Add(tB_TaiKhoan);
            pn_DangNhap.Dock = DockStyle.Fill;
            pn_DangNhap.Location = new Point(0, 0);
            pn_DangNhap.Name = "pn_DangNhap";
            pn_DangNhap.Size = new Size(800, 450);
            pn_DangNhap.TabIndex = 9;
            pn_DangNhap.Paint += pn_DangNhap_Paint;
            // 
            // lb_DangKy
            // 
            lb_DangKy.AutoSize = true;
            lb_DangKy.Font = new Font("Segoe UI", 9F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 163);
            lb_DangKy.Location = new Point(454, 242);
            lb_DangKy.Name = "lb_DangKy";
            lb_DangKy.Size = new Size(78, 25);
            lb_DangKy.TabIndex = 8;
            lb_DangKy.Text = "Đăng ký";
            lb_DangKy.Click += lb_DangKy_Click;
            // 
            // lb_QuenMatKhau
            // 
            lb_QuenMatKhau.AutoSize = true;
            lb_QuenMatKhau.Font = new Font("Segoe UI", 9F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 163);
            lb_QuenMatKhau.Location = new Point(118, 242);
            lb_QuenMatKhau.Name = "lb_QuenMatKhau";
            lb_QuenMatKhau.Size = new Size(148, 25);
            lb_QuenMatKhau.TabIndex = 7;
            lb_QuenMatKhau.Text = "Quên mật khẩu ?";
            lb_QuenMatKhau.Click += lb_QuenMatKhau_Click;
            // 
            // btn_Thoat
            // 
            btn_Thoat.Location = new Point(458, 320);
            btn_Thoat.Name = "btn_Thoat";
            btn_Thoat.RightToLeft = RightToLeft.No;
            btn_Thoat.Size = new Size(120, 57);
            btn_Thoat.TabIndex = 6;
            btn_Thoat.Text = "Thoát";
            btn_Thoat.UseVisualStyleBackColor = true;
            btn_Thoat.Click += btn_Thoat_Click;
            // 
            // btn_DongY
            // 
            btn_DongY.Location = new Point(118, 320);
            btn_DongY.Name = "btn_DongY";
            btn_DongY.Size = new Size(120, 57);
            btn_DongY.TabIndex = 5;
            btn_DongY.Text = "Đăng Nhập";
            btn_DongY.UseVisualStyleBackColor = true;
            btn_DongY.Click += btn_DongY_Click;
            // 
            // lb_TieuDe
            // 
            lb_TieuDe.Font = new Font("Times New Roman", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            lb_TieuDe.ForeColor = SystemColors.ActiveCaptionText;
            lb_TieuDe.Location = new Point(267, 6);
            lb_TieuDe.Name = "lb_TieuDe";
            lb_TieuDe.Size = new Size(200, 50);
            lb_TieuDe.TabIndex = 4;
            lb_TieuDe.Text = "Đăng Nhập";
            // 
            // tB_MatKhau
            // 
            tB_MatKhau.Location = new Point(364, 172);
            tB_MatKhau.Name = "tB_MatKhau";
            tB_MatKhau.PasswordChar = '*';
            tB_MatKhau.Size = new Size(210, 31);
            tB_MatKhau.TabIndex = 3;
            // 
            // lb_MatKhau
            // 
            lb_MatKhau.AutoSize = true;
            lb_MatKhau.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lb_MatKhau.Location = new Point(126, 172);
            lb_MatKhau.Name = "lb_MatKhau";
            lb_MatKhau.Size = new Size(86, 25);
            lb_MatKhau.TabIndex = 2;
            lb_MatKhau.Text = "Mật khẩu";
            // 
            // lb_TaiKhoan
            // 
            lb_TaiKhoan.AutoSize = true;
            lb_TaiKhoan.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lb_TaiKhoan.Location = new Point(126, 99);
            lb_TaiKhoan.Name = "lb_TaiKhoan";
            lb_TaiKhoan.Size = new Size(87, 25);
            lb_TaiKhoan.TabIndex = 1;
            lb_TaiKhoan.Text = "Tài Khoản";
            // 
            // tB_TaiKhoan
            // 
            tB_TaiKhoan.Location = new Point(364, 99);
            tB_TaiKhoan.Name = "tB_TaiKhoan";
            tB_TaiKhoan.Size = new Size(210, 31);
            tB_TaiKhoan.TabIndex = 0;
            // 
            // tCt_FormDangNhap
            // 
            tCt_FormDangNhap.Location = new Point(0, 0);
            tCt_FormDangNhap.Name = "tCt_FormDangNhap";
            tCt_FormDangNhap.SelectedIndex = 0;
            tCt_FormDangNhap.Size = new Size(200, 100);
            tCt_FormDangNhap.TabIndex = 0;
            // 
            // lbDoimatkhau
            // 
            lbDoimatkhau.AutoSize = true;
            lbDoimatkhau.Font = new Font("Segoe UI", 9F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 163);
            lbDoimatkhau.Location = new Point(118, 281);
            lbDoimatkhau.Name = "lbDoimatkhau";
            lbDoimatkhau.Size = new Size(120, 25);
            lbDoimatkhau.TabIndex = 9;
            lbDoimatkhau.Text = "Đổi mật khẩu";
            lbDoimatkhau.Click += lbDoimatkhau_Click;
            // 
            // FormDangNhap
            // 
            this.StartPosition = FormStartPosition.CenterScreen;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(800, 450);
            Controls.Add(pn_DangNhap);
            Name = "FormDangNhap";
            Text = "Đăng Nhập";
            pn_DangNhap.ResumeLayout(false);
            pn_DangNhap.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Button button2;
        private TabPage tabPage2;
        private TabPage tabPage1;
        private Panel pn_DangNhap;
        private Label lb_DangKy;
        private Label lb_QuenMatKhau;
        private Button btn_Thoat;
        private Button btn_DongY;
        public Label lb_TieuDe;
        private TextBox tB_MatKhau;
        private Label lb_MatKhau;
        private Label lb_TaiKhoan;
        private TextBox tB_TaiKhoan;
        private TabControl tCt_FormDangNhap;
        private Label lbDoimatkhau;
    }
}
