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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDoimatkhau));
            pn_DangKy = new Panel();
            pictureBox_QuayLai = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            tb_NhapLaiMatKhau = new TextBox();
            tb_MatKhau = new TextBox();
            lb_MatKhau = new Label();
            btn_Doimatkhau = new Button();
            tb_TaiKhoan_Doimatkhau = new TextBox();
            lb_TaiKhoan_Doimatkhau = new Label();
            lb_TieuDeDoiMatKhau = new Label();
            pn_DangKy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_QuayLai).BeginInit();
            SuspendLayout();
            // 
            // pn_DangKy
            // 
            pn_DangKy.BackColor = Color.White;
            pn_DangKy.Controls.Add(pictureBox_QuayLai);
            pn_DangKy.Controls.Add(label2);
            pn_DangKy.Controls.Add(label1);
            pn_DangKy.Controls.Add(tb_NhapLaiMatKhau);
            pn_DangKy.Controls.Add(tb_MatKhau);
            pn_DangKy.Controls.Add(lb_MatKhau);
            pn_DangKy.Controls.Add(btn_Doimatkhau);
            pn_DangKy.Controls.Add(tb_TaiKhoan_Doimatkhau);
            pn_DangKy.Controls.Add(lb_TaiKhoan_Doimatkhau);
            pn_DangKy.Controls.Add(lb_TieuDeDoiMatKhau);
            pn_DangKy.Location = new Point(1, 5);
            pn_DangKy.Margin = new Padding(2);
            pn_DangKy.Name = "pn_DangKy";
            pn_DangKy.Size = new Size(638, 351);
            pn_DangKy.TabIndex = 13;
            pn_DangKy.Paint += pn_DangKy_Paint;
            // 
            // pictureBox_QuayLai
            // 
            pictureBox_QuayLai.Image = (Image)resources.GetObject("pictureBox_QuayLai.Image");
            pictureBox_QuayLai.Location = new Point(11, 301);
            pictureBox_QuayLai.Name = "pictureBox_QuayLai";
            pictureBox_QuayLai.Size = new Size(44, 38);
            pictureBox_QuayLai.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_QuayLai.TabIndex = 20;
            pictureBox_QuayLai.TabStop = false;
            pictureBox_QuayLai.Click += pictureBox_QuayLai_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(126, 235);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(120, 20);
            label2.TabIndex = 19;
            label2.Text = "MẬT KHẨU MỚI";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(171, 64);
            label1.Name = "label1";
            label1.Size = new Size(289, 20);
            label1.TabIndex = 18;
            label1.Text = "Bạn muốn đổi mật khẩu? Tạo mới tại đây";
            // 
            // tb_NhapLaiMatKhau
            // 
            tb_NhapLaiMatKhau.BorderStyle = BorderStyle.FixedSingle;
            tb_NhapLaiMatKhau.Location = new Point(127, 257);
            tb_NhapLaiMatKhau.Margin = new Padding(2);
            tb_NhapLaiMatKhau.Name = "tb_NhapLaiMatKhau";
            tb_NhapLaiMatKhau.PasswordChar = '*';
            tb_NhapLaiMatKhau.Size = new Size(402, 27);
            tb_NhapLaiMatKhau.TabIndex = 17;
            // 
            // tb_MatKhau
            // 
            tb_MatKhau.BorderStyle = BorderStyle.FixedSingle;
            tb_MatKhau.Location = new Point(127, 191);
            tb_MatKhau.Margin = new Padding(2);
            tb_MatKhau.Name = "tb_MatKhau";
            tb_MatKhau.PasswordChar = '*';
            tb_MatKhau.Size = new Size(402, 27);
            tb_MatKhau.TabIndex = 16;
            // 
            // lb_MatKhau
            // 
            lb_MatKhau.AutoSize = true;
            lb_MatKhau.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_MatKhau.Location = new Point(126, 169);
            lb_MatKhau.Margin = new Padding(2, 0, 2, 0);
            lb_MatKhau.Name = "lb_MatKhau";
            lb_MatKhau.Size = new Size(110, 20);
            lb_MatKhau.TabIndex = 14;
            lb_MatKhau.Text = "MẬT KHẨU CŨ";
            // 
            // btn_Doimatkhau
            // 
            btn_Doimatkhau.BackColor = Color.Black;
            btn_Doimatkhau.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Doimatkhau.ForeColor = SystemColors.ButtonHighlight;
            btn_Doimatkhau.Location = new Point(171, 301);
            btn_Doimatkhau.Margin = new Padding(2);
            btn_Doimatkhau.Name = "btn_Doimatkhau";
            btn_Doimatkhau.Size = new Size(318, 39);
            btn_Doimatkhau.TabIndex = 12;
            btn_Doimatkhau.Text = "Đổi mật khẩu";
            btn_Doimatkhau.UseVisualStyleBackColor = false;
            // 
            // tb_TaiKhoan_Doimatkhau
            // 
            tb_TaiKhoan_Doimatkhau.BorderStyle = BorderStyle.FixedSingle;
            tb_TaiKhoan_Doimatkhau.Location = new Point(127, 125);
            tb_TaiKhoan_Doimatkhau.Margin = new Padding(2);
            tb_TaiKhoan_Doimatkhau.Name = "tb_TaiKhoan_Doimatkhau";
            tb_TaiKhoan_Doimatkhau.Size = new Size(402, 27);
            tb_TaiKhoan_Doimatkhau.TabIndex = 10;
            // 
            // lb_TaiKhoan_Doimatkhau
            // 
            lb_TaiKhoan_Doimatkhau.AutoSize = true;
            lb_TaiKhoan_Doimatkhau.BackColor = SystemColors.ControlLightLight;
            lb_TaiKhoan_Doimatkhau.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_TaiKhoan_Doimatkhau.Location = new Point(126, 103);
            lb_TaiKhoan_Doimatkhau.Margin = new Padding(2, 0, 2, 0);
            lb_TaiKhoan_Doimatkhau.Name = "lb_TaiKhoan_Doimatkhau";
            lb_TaiKhoan_Doimatkhau.Size = new Size(87, 20);
            lb_TaiKhoan_Doimatkhau.TabIndex = 8;
            lb_TaiKhoan_Doimatkhau.Text = "TÀI KHOẢN";
            // 
            // lb_TieuDeDoiMatKhau
            // 
            lb_TieuDeDoiMatKhau.AutoSize = true;
            lb_TieuDeDoiMatKhau.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_TieuDeDoiMatKhau.Location = new Point(186, 15);
            lb_TieuDeDoiMatKhau.Margin = new Padding(2, 0, 2, 0);
            lb_TieuDeDoiMatKhau.Name = "lb_TieuDeDoiMatKhau";
            lb_TieuDeDoiMatKhau.Size = new Size(278, 38);
            lb_TieuDeDoiMatKhau.TabIndex = 7;
            lb_TieuDeDoiMatKhau.Text = "Tạo mật khẩu mới ";
            // 
            // FormDoimatkhau
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 360);
            Controls.Add(pn_DangKy);
            Margin = new Padding(2);
            Name = "FormDoimatkhau";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đổi Mật Khẩu";
            pn_DangKy.ResumeLayout(false);
            pn_DangKy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_QuayLai).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pn_DangKy;
        private TextBox tb_NhapLaiMatKhau;
        private TextBox tb_MatKhau;
        private Label lb_MatKhau;
        private Button btn_Doimatkhau;
        private TextBox tb_TaiKhoan_Doimatkhau;
        private Label lb_TaiKhoan_Doimatkhau;
        private Label lb_TieuDeDoiMatKhau;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox_QuayLai;
    }
}