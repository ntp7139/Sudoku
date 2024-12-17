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
            pictureBox1 = new PictureBox();
            pn_DangKy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pn_DangKy
            // 
            pn_DangKy.BackgroundImage = Properties.Resources.tuvi1;
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
            pn_DangKy.Controls.Add(pictureBox1);
            pn_DangKy.Location = new Point(-14, -1);
            pn_DangKy.Margin = new Padding(2);
            pn_DangKy.Name = "pn_DangKy";
            pn_DangKy.Size = new Size(826, 512);
            pn_DangKy.TabIndex = 12;
            // 
            // tb_NhapLaiMatKhau
            // 
            tb_NhapLaiMatKhau.BackColor = Color.FloralWhite;
            tb_NhapLaiMatKhau.Location = new Point(254, 329);
            tb_NhapLaiMatKhau.Margin = new Padding(2);
            tb_NhapLaiMatKhau.Multiline = true;
            tb_NhapLaiMatKhau.Name = "tb_NhapLaiMatKhau";
            tb_NhapLaiMatKhau.PasswordChar = '*';
            tb_NhapLaiMatKhau.Size = new Size(465, 33);
            tb_NhapLaiMatKhau.TabIndex = 3;
            // 
            // tb_MatKhau_DangKy
            // 
            tb_MatKhau_DangKy.BackColor = Color.FloralWhite;
            tb_MatKhau_DangKy.Location = new Point(254, 256);
            tb_MatKhau_DangKy.Margin = new Padding(2);
            tb_MatKhau_DangKy.Multiline = true;
            tb_MatKhau_DangKy.Name = "tb_MatKhau_DangKy";
            tb_MatKhau_DangKy.PasswordChar = '*';
            tb_MatKhau_DangKy.Size = new Size(465, 33);
            tb_MatKhau_DangKy.TabIndex = 2;
            tb_MatKhau_DangKy.TextChanged += this.tb_MatKhau_DangKy_TextChanged;
            // 
            // lb_NhapMatKhau
            // 
            lb_NhapMatKhau.BackColor = Color.Moccasin;
            lb_NhapMatKhau.BorderStyle = BorderStyle.Fixed3D;
            lb_NhapMatKhau.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_NhapMatKhau.ForeColor = Color.SaddleBrown;
            lb_NhapMatKhau.ImageAlign = ContentAlignment.TopLeft;
            lb_NhapMatKhau.Location = new Point(120, 324);
            lb_NhapMatKhau.Margin = new Padding(2, 0, 2, 0);
            lb_NhapMatKhau.Name = "lb_NhapMatKhau";
            lb_NhapMatKhau.Size = new Size(106, 46);
            lb_NhapMatKhau.TabIndex = 15;
            lb_NhapMatKhau.Text = "NHẬP LẠI MẬT KHẨU";
            lb_NhapMatKhau.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lb_MatKhau_DangKy
            // 
            lb_MatKhau_DangKy.BackColor = Color.Moccasin;
            lb_MatKhau_DangKy.BorderStyle = BorderStyle.Fixed3D;
            lb_MatKhau_DangKy.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_MatKhau_DangKy.ForeColor = Color.SaddleBrown;
            lb_MatKhau_DangKy.Location = new Point(120, 257);
            lb_MatKhau_DangKy.Margin = new Padding(2, 0, 2, 0);
            lb_MatKhau_DangKy.Name = "lb_MatKhau_DangKy";
            lb_MatKhau_DangKy.Size = new Size(106, 33);
            lb_MatKhau_DangKy.TabIndex = 14;
            lb_MatKhau_DangKy.Text = "MẬT KHẨU";
            lb_MatKhau_DangKy.TextAlign = ContentAlignment.MiddleCenter;
            lb_MatKhau_DangKy.Click += this.lb_MatKhau_DangKy_Click;
            // 
            // btn_QuayLai_DangKy
            // 
            btn_QuayLai_DangKy.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_QuayLai_DangKy.ForeColor = Color.Brown;
            btn_QuayLai_DangKy.Image = Properties.Resources.hinh_nen_iPad_cute;
            btn_QuayLai_DangKy.ImageAlign = ContentAlignment.TopLeft;
            btn_QuayLai_DangKy.Location = new Point(497, 397);
            btn_QuayLai_DangKy.Margin = new Padding(2);
            btn_QuayLai_DangKy.Name = "btn_QuayLai_DangKy";
            btn_QuayLai_DangKy.Size = new Size(128, 49);
            btn_QuayLai_DangKy.TabIndex = 13;
            btn_QuayLai_DangKy.Text = "QUAY LẠI";
            btn_QuayLai_DangKy.UseVisualStyleBackColor = true;
            btn_QuayLai_DangKy.Click += btn_QuayLai_DangKy_Click;
            // 
            // btn_DangKy
            // 
            btn_DangKy.BackColor = Color.LightGreen;
            btn_DangKy.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_DangKy.ForeColor = Color.Brown;
            btn_DangKy.Image = Properties.Resources.hinh_nen_iPad_cute;
            btn_DangKy.ImageAlign = ContentAlignment.TopRight;
            btn_DangKy.Location = new Point(227, 397);
            btn_DangKy.Margin = new Padding(2);
            btn_DangKy.Name = "btn_DangKy";
            btn_DangKy.Size = new Size(128, 49);
            btn_DangKy.TabIndex = 12;
            btn_DangKy.Text = "ĐĂNG KÝ";
            btn_DangKy.UseVisualStyleBackColor = false;
            btn_DangKy.Click += btn_DangKy_Click;
            // 
            // tb_Email_DangKy
            // 
            tb_Email_DangKy.BackColor = Color.FloralWhite;
            tb_Email_DangKy.Location = new Point(254, 190);
            tb_Email_DangKy.Margin = new Padding(2);
            tb_Email_DangKy.Multiline = true;
            tb_Email_DangKy.Name = "tb_Email_DangKy";
            tb_Email_DangKy.Size = new Size(465, 34);
            tb_Email_DangKy.TabIndex = 1;
            tb_Email_DangKy.TextChanged += tb_Email_DangKy_TextChanged;
            // 
            // tb_TaiKhoan_DangKy
            // 
            tb_TaiKhoan_DangKy.BackColor = Color.FloralWhite;
            tb_TaiKhoan_DangKy.Location = new Point(254, 115);
            tb_TaiKhoan_DangKy.Margin = new Padding(2);
            tb_TaiKhoan_DangKy.Multiline = true;
            tb_TaiKhoan_DangKy.Name = "tb_TaiKhoan_DangKy";
            tb_TaiKhoan_DangKy.Size = new Size(465, 35);
            tb_TaiKhoan_DangKy.TabIndex = 0;
            // 
            // lb_Email_DangKy
            // 
            lb_Email_DangKy.BackColor = Color.Moccasin;
            lb_Email_DangKy.BorderStyle = BorderStyle.Fixed3D;
            lb_Email_DangKy.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_Email_DangKy.ForeColor = Color.SaddleBrown;
            lb_Email_DangKy.Location = new Point(120, 190);
            lb_Email_DangKy.Margin = new Padding(2, 0, 2, 0);
            lb_Email_DangKy.Name = "lb_Email_DangKy";
            lb_Email_DangKy.Size = new Size(106, 34);
            lb_Email_DangKy.TabIndex = 9;
            lb_Email_DangKy.Text = "EMAIL";
            lb_Email_DangKy.TextAlign = ContentAlignment.MiddleCenter;
            lb_Email_DangKy.Click += this.lb_Email_DangKy_Click;
            // 
            // lb_TaiKhoan_Dki
            // 
            lb_TaiKhoan_Dki.BackColor = Color.Moccasin;
            lb_TaiKhoan_Dki.BorderStyle = BorderStyle.Fixed3D;
            lb_TaiKhoan_Dki.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_TaiKhoan_Dki.ForeColor = Color.SaddleBrown;
            lb_TaiKhoan_Dki.Location = new Point(120, 113);
            lb_TaiKhoan_Dki.Margin = new Padding(2, 0, 2, 0);
            lb_TaiKhoan_Dki.Name = "lb_TaiKhoan_Dki";
            lb_TaiKhoan_Dki.Size = new Size(108, 37);
            lb_TaiKhoan_Dki.TabIndex = 8;
            lb_TaiKhoan_Dki.Text = "TÀI KHOẢN";
            lb_TaiKhoan_Dki.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lb_TieuDeDangKy
            // 
            lb_TieuDeDangKy.BackColor = Color.NavajoWhite;
            lb_TieuDeDangKy.BorderStyle = BorderStyle.FixedSingle;
            lb_TieuDeDangKy.FlatStyle = FlatStyle.Popup;
            lb_TieuDeDangKy.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_TieuDeDangKy.ForeColor = Color.FromArgb(128, 64, 64);
            lb_TieuDeDangKy.Location = new Point(118, 27);
            lb_TieuDeDangKy.Margin = new Padding(2, 0, 2, 0);
            lb_TieuDeDangKy.Name = "lb_TieuDeDangKy";
            lb_TieuDeDangKy.Size = new Size(568, 48);
            lb_TieuDeDangKy.TabIndex = 7;
            lb_TieuDeDangKy.Text = "ĐĂNG KÝ";
            lb_TieuDeDangKy.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FloralWhite;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(81, 64);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(696, 416);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // FormDangKy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 500);
            Controls.Add(pn_DangKy);
            Margin = new Padding(2);
            Name = "FormDangKy";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormDangKy_Load;
            pn_DangKy.ResumeLayout(false);
            pn_DangKy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
    }
}