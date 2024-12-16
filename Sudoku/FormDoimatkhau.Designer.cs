namespace Sudoku
{
    partial class FormDoimatkhau
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
            tb_MatKhau = new TextBox();
            lb_NhapMatKhau = new Label();
            lb_MatKhau = new Label();
            btn_QuayLai_DangKy = new Button();
            btn_Doimatkhau = new Button();
            tb_TaiKhoan_Doimatkhau = new TextBox();
            lb_TaiKhoan_Doimatkhau = new Label();
            lb_TieuDeDoiMatKhau = new Label();
            pn_DangKy.SuspendLayout();
            SuspendLayout();
            // 
            // pn_DangKy
            // 
            pn_DangKy.Controls.Add(tb_NhapLaiMatKhau);
            pn_DangKy.Controls.Add(tb_MatKhau);
            pn_DangKy.Controls.Add(lb_NhapMatKhau);
            pn_DangKy.Controls.Add(lb_MatKhau);
            pn_DangKy.Controls.Add(btn_QuayLai_DangKy);
            pn_DangKy.Controls.Add(btn_Doimatkhau);
            pn_DangKy.Controls.Add(tb_TaiKhoan_Doimatkhau);
            pn_DangKy.Controls.Add(lb_TaiKhoan_Doimatkhau);
            pn_DangKy.Controls.Add(lb_TieuDeDoiMatKhau);
            pn_DangKy.Location = new Point(1, 6);
            pn_DangKy.Name = "pn_DangKy";
            pn_DangKy.Size = new Size(798, 439);
            pn_DangKy.TabIndex = 13;
            // 
            // tb_NhapLaiMatKhau
            // 
            tb_NhapLaiMatKhau.Location = new Point(300, 207);
            tb_NhapLaiMatKhau.Name = "tb_NhapLaiMatKhau";
            tb_NhapLaiMatKhau.Size = new Size(328, 31);
            tb_NhapLaiMatKhau.TabIndex = 17;
            // 
            // tb_MatKhau
            // 
            tb_MatKhau.Location = new Point(300, 156);
            tb_MatKhau.Name = "tb_MatKhau";
            tb_MatKhau.Size = new Size(328, 31);
            tb_MatKhau.TabIndex = 16;
            // 
            // lb_NhapMatKhau
            // 
            lb_NhapMatKhau.AutoSize = true;
            lb_NhapMatKhau.Location = new Point(159, 213);
            lb_NhapMatKhau.Name = "lb_NhapMatKhau";
            lb_NhapMatKhau.Size = new Size(135, 25);
            lb_NhapMatKhau.TabIndex = 15;
            lb_NhapMatKhau.Text = "Nhập Mật Khẩu";
            // 
            // lb_MatKhau
            // 
            lb_MatKhau.AutoSize = true;
            lb_MatKhau.Location = new Point(162, 164);
            lb_MatKhau.Name = "lb_MatKhau";
            lb_MatKhau.Size = new Size(87, 25);
            lb_MatKhau.TabIndex = 14;
            lb_MatKhau.Text = "Mật Khẩu";
            // 
            // btn_QuayLai_DangKy
            // 
            btn_QuayLai_DangKy.Location = new Point(442, 288);
            btn_QuayLai_DangKy.Name = "btn_QuayLai_DangKy";
            btn_QuayLai_DangKy.Size = new Size(143, 54);
            btn_QuayLai_DangKy.TabIndex = 13;
            btn_QuayLai_DangKy.Text = "Quay lại";
            btn_QuayLai_DangKy.UseVisualStyleBackColor = true;
            btn_QuayLai_DangKy.Click += btn_QuayLai_DangKy_Click;
            // 
            // btn_Doimatkhau
            // 
            btn_Doimatkhau.Location = new Point(177, 288);
            btn_Doimatkhau.Name = "btn_Doimatkhau";
            btn_Doimatkhau.Size = new Size(143, 54);
            btn_Doimatkhau.TabIndex = 12;
            btn_Doimatkhau.Text = "Đổi mật khẩu";
            btn_Doimatkhau.UseVisualStyleBackColor = true;
            // 
            // tb_TaiKhoan_Doimatkhau
            // 
            tb_TaiKhoan_Doimatkhau.Location = new Point(300, 96);
            tb_TaiKhoan_Doimatkhau.Name = "tb_TaiKhoan_Doimatkhau";
            tb_TaiKhoan_Doimatkhau.Size = new Size(328, 31);
            tb_TaiKhoan_Doimatkhau.TabIndex = 10;
            // 
            // lb_TaiKhoan_Doimatkhau
            // 
            lb_TaiKhoan_Doimatkhau.AutoSize = true;
            lb_TaiKhoan_Doimatkhau.BackColor = SystemColors.ButtonFace;
            lb_TaiKhoan_Doimatkhau.Location = new Point(160, 102);
            lb_TaiKhoan_Doimatkhau.Name = "lb_TaiKhoan_Doimatkhau";
            lb_TaiKhoan_Doimatkhau.Size = new Size(87, 25);
            lb_TaiKhoan_Doimatkhau.TabIndex = 8;
            lb_TaiKhoan_Doimatkhau.Text = "Tài Khoản";
            // 
            // lb_TieuDeDoiMatKhau
            // 
            lb_TieuDeDoiMatKhau.AutoSize = true;
            lb_TieuDeDoiMatKhau.Font = new Font("Times New Roman", 16F, FontStyle.Italic, GraphicsUnit.Point, 163);
            lb_TieuDeDoiMatKhau.Location = new Point(274, 37);
            lb_TieuDeDoiMatKhau.Name = "lb_TieuDeDoiMatKhau";
            lb_TieuDeDoiMatKhau.Size = new Size(201, 37);
            lb_TieuDeDoiMatKhau.TabIndex = 7;
            lb_TieuDeDoiMatKhau.Text = "Đổi Mật Khẩu";
            // 
            // FormDoimatkhau
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pn_DangKy);
            Name = "FormDoimatkhau";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đổi Mật Khẩu";
            pn_DangKy.ResumeLayout(false);
            pn_DangKy.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pn_DangKy;
        private TextBox tb_NhapLaiMatKhau;
        private TextBox tb_MatKhau;
        private Label lb_NhapMatKhau;
        private Label lb_MatKhau;
        private Button btn_QuayLai_DangKy;
        private Button btn_Doimatkhau;
        private TextBox tb_TaiKhoan_Doimatkhau;
        private Label lb_TaiKhoan_Doimatkhau;
        private Label lb_TieuDeDoiMatKhau;
    }
}