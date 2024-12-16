namespace Sudoku
{
    partial class FormDangKy
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
            pn_DangKy = new Panel();
            tb_NhapLaiMatKhau = new TextBox();
            tb_MatKhau_DangKy = new TextBox();
            lb_NhapMatKhau = new Label();
            lb_MatKhau_DangKy = new Label();
            btn_QuayLai_DangKy = new Button();
            btn_DangKy = new Button();
            tb_Email_DangKy = new TextBox();
            tb_TaiKhoan_DangKy = new TextBox();
            lb_Email_DangKy = new Label();
            lb_TaiKhoan_Dki = new Label();
            lb_TieuDeDangKy = new Label();
            pn_DangKy.SuspendLayout();
            SuspendLayout();
            // 
            // pn_DangKy
            // 
            pn_DangKy.Controls.Add(tb_NhapLaiMatKhau);
            pn_DangKy.Controls.Add(tb_MatKhau_DangKy);
            pn_DangKy.Controls.Add(lb_NhapMatKhau);
            pn_DangKy.Controls.Add(lb_MatKhau_DangKy);
            pn_DangKy.Controls.Add(btn_QuayLai_DangKy);
            pn_DangKy.Controls.Add(btn_DangKy);
            pn_DangKy.Controls.Add(tb_Email_DangKy);
            pn_DangKy.Controls.Add(tb_TaiKhoan_DangKy);
            pn_DangKy.Controls.Add(lb_Email_DangKy);
            pn_DangKy.Controls.Add(lb_TaiKhoan_Dki);
            pn_DangKy.Controls.Add(lb_TieuDeDangKy);
            pn_DangKy.Location = new Point(1, 6);
            pn_DangKy.Name = "pn_DangKy";
            pn_DangKy.Size = new Size(798, 439);
            pn_DangKy.TabIndex = 12;
            // 
            // tb_NhapLaiMatKhau
            // 
            tb_NhapLaiMatKhau.Location = new Point(300, 265);
            tb_NhapLaiMatKhau.Name = "tb_NhapLaiMatKhau";
            tb_NhapLaiMatKhau.PasswordChar = '*';
            tb_NhapLaiMatKhau.Size = new Size(328, 31);
            tb_NhapLaiMatKhau.TabIndex = 17;
            // 
            // tb_MatKhau_DangKy
            // 
            tb_MatKhau_DangKy.Location = new Point(300, 208);
            tb_MatKhau_DangKy.Name = "tb_MatKhau_DangKy";
            tb_MatKhau_DangKy.PasswordChar = '*';
            tb_MatKhau_DangKy.Size = new Size(328, 31);
            tb_MatKhau_DangKy.TabIndex = 16;
            // 
            // lb_NhapMatKhau
            // 
            lb_NhapMatKhau.AutoSize = true;
            lb_NhapMatKhau.Location = new Point(159, 271);
            lb_NhapMatKhau.Name = "lb_NhapMatKhau";
            lb_NhapMatKhau.Size = new Size(135, 25);
            lb_NhapMatKhau.TabIndex = 15;
            lb_NhapMatKhau.Text = "Nhập Mật Khẩu";
            // 
            // lb_MatKhau_DangKy
            // 
            lb_MatKhau_DangKy.AutoSize = true;
            lb_MatKhau_DangKy.Location = new Point(162, 216);
            lb_MatKhau_DangKy.Name = "lb_MatKhau_DangKy";
            lb_MatKhau_DangKy.Size = new Size(87, 25);
            lb_MatKhau_DangKy.TabIndex = 14;
            lb_MatKhau_DangKy.Text = "Mật Khẩu";
            // 
            // btn_QuayLai_DangKy
            // 
            btn_QuayLai_DangKy.Location = new Point(443, 319);
            btn_QuayLai_DangKy.Name = "btn_QuayLai_DangKy";
            btn_QuayLai_DangKy.Size = new Size(143, 54);
            btn_QuayLai_DangKy.TabIndex = 13;
            btn_QuayLai_DangKy.Text = "Quay lại";
            btn_QuayLai_DangKy.UseVisualStyleBackColor = true;
            btn_QuayLai_DangKy.Click += btn_QuayLai_DangKy_Click;
            // 
            // btn_DangKy
            // 
            btn_DangKy.Location = new Point(178, 319);
            btn_DangKy.Name = "btn_DangKy";
            btn_DangKy.Size = new Size(143, 54);
            btn_DangKy.TabIndex = 12;
            btn_DangKy.Text = "Đăng Ký";
            btn_DangKy.UseVisualStyleBackColor = true;
            btn_DangKy.Click += btn_DangKy_Click;
            // 
            // tb_Email_DangKy
            // 
            tb_Email_DangKy.Location = new Point(300, 153);
            tb_Email_DangKy.Name = "tb_Email_DangKy";
            tb_Email_DangKy.Size = new Size(328, 31);
            tb_Email_DangKy.TabIndex = 11;
            // 
            // tb_TaiKhoan_DangKy
            // 
            tb_TaiKhoan_DangKy.Location = new Point(300, 96);
            tb_TaiKhoan_DangKy.Name = "tb_TaiKhoan_DangKy";
            tb_TaiKhoan_DangKy.Size = new Size(328, 31);
            tb_TaiKhoan_DangKy.TabIndex = 10;
            // 
            // lb_Email_DangKy
            // 
            lb_Email_DangKy.AutoSize = true;
            lb_Email_DangKy.Location = new Point(162, 156);
            lb_Email_DangKy.Name = "lb_Email_DangKy";
            lb_Email_DangKy.Size = new Size(58, 25);
            lb_Email_DangKy.TabIndex = 9;
            lb_Email_DangKy.Text = "Email:";
            // 
            // lb_TaiKhoan_Dki
            // 
            lb_TaiKhoan_Dki.AutoSize = true;
            lb_TaiKhoan_Dki.BackColor = SystemColors.ButtonFace;
            lb_TaiKhoan_Dki.Location = new Point(160, 102);
            lb_TaiKhoan_Dki.Name = "lb_TaiKhoan_Dki";
            lb_TaiKhoan_Dki.Size = new Size(87, 25);
            lb_TaiKhoan_Dki.TabIndex = 8;
            lb_TaiKhoan_Dki.Text = "Tài Khoản";
            // 
            // lb_TieuDeDangKy
            // 
            lb_TieuDeDangKy.AutoSize = true;
            lb_TieuDeDangKy.Font = new Font("Times New Roman", 16F, FontStyle.Italic, GraphicsUnit.Point, 163);
            lb_TieuDeDangKy.Location = new Point(274, 37);
            lb_TieuDeDangKy.Name = "lb_TieuDeDangKy";
            lb_TieuDeDangKy.Size = new Size(130, 37);
            lb_TieuDeDangKy.TabIndex = 7;
            lb_TieuDeDangKy.Text = "Đăng Ký";
            // 
            // FormDangKy
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pn_DangKy);
            Name = "FormDangKy";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng Ký";
            pn_DangKy.ResumeLayout(false);
            pn_DangKy.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pn_DangKy;
        private TextBox tb_NhapLaiMatKhau;
        private TextBox tb_MatKhau_DangKy;
        private Label lb_NhapMatKhau;
        private Label lb_MatKhau_DangKy;
        private Button btn_QuayLai_DangKy;
        private Button btn_DangKy;
        private TextBox tb_Email_DangKy;
        private TextBox tb_TaiKhoan_DangKy;
        private Label lb_Email_DangKy;
        private Label lb_TaiKhoan_Dki;
        private Label lb_TieuDeDangKy;
    }
}