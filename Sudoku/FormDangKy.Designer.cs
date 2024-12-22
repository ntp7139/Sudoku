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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDangKy));
            pn_DangKy = new Panel();
            label1 = new Label();
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
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pn_DangKy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // pn_DangKy
            // 
            pn_DangKy.BackColor = SystemColors.ButtonHighlight;
            pn_DangKy.Controls.Add(pictureBox5);
            pn_DangKy.Controls.Add(pictureBox4);
            pn_DangKy.Controls.Add(pictureBox3);
            pn_DangKy.Controls.Add(pictureBox1);
            pn_DangKy.Controls.Add(label1);
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
            pn_DangKy.Location = new Point(-14, -1);
            pn_DangKy.Margin = new Padding(2);
            pn_DangKy.Name = "pn_DangKy";
            pn_DangKy.Size = new Size(826, 512);
            pn_DangKy.TabIndex = 12;
            pn_DangKy.Paint += pn_DangKy_Paint;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(159, 55);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(535, 31);
            label1.TabIndex = 19;
            label1.Text = "Bạn chưa có tài khoản? Đăng kí ngay tại đây.";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tb_NhapLaiMatKhau
            // 
            tb_NhapLaiMatKhau.BackColor = Color.FloralWhite;
            tb_NhapLaiMatKhau.BorderStyle = BorderStyle.FixedSingle;
            tb_NhapLaiMatKhau.Location = new Point(192, 370);
            tb_NhapLaiMatKhau.Margin = new Padding(2);
            tb_NhapLaiMatKhau.Multiline = true;
            tb_NhapLaiMatKhau.Name = "tb_NhapLaiMatKhau";
            tb_NhapLaiMatKhau.PasswordChar = '*';
            tb_NhapLaiMatKhau.Size = new Size(527, 33);
            tb_NhapLaiMatKhau.TabIndex = 3;
            // 
            // tb_MatKhau_DangKy
            // 
            tb_MatKhau_DangKy.BackColor = Color.FloralWhite;
            tb_MatKhau_DangKy.BorderStyle = BorderStyle.FixedSingle;
            tb_MatKhau_DangKy.Location = new Point(192, 292);
            tb_MatKhau_DangKy.Margin = new Padding(2);
            tb_MatKhau_DangKy.Multiline = true;
            tb_MatKhau_DangKy.Name = "tb_MatKhau_DangKy";
            tb_MatKhau_DangKy.PasswordChar = '*';
            tb_MatKhau_DangKy.Size = new Size(527, 33);
            tb_MatKhau_DangKy.TabIndex = 2;
            tb_MatKhau_DangKy.TextChanged += tb_MatKhau_DangKy_TextChanged;
            // 
            // lb_NhapMatKhau
            // 
            lb_NhapMatKhau.BackColor = SystemColors.ButtonHighlight;
            lb_NhapMatKhau.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_NhapMatKhau.ForeColor = Color.SaddleBrown;
            lb_NhapMatKhau.ImageAlign = ContentAlignment.TopLeft;
            lb_NhapMatKhau.Location = new Point(85, 344);
            lb_NhapMatKhau.Margin = new Padding(2, 0, 2, 0);
            lb_NhapMatKhau.Name = "lb_NhapMatKhau";
            lb_NhapMatKhau.Size = new Size(236, 24);
            lb_NhapMatKhau.TabIndex = 15;
            lb_NhapMatKhau.Text = "NHẬP LẠI MẬT KHẨU";
            lb_NhapMatKhau.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lb_MatKhau_DangKy
            // 
            lb_MatKhau_DangKy.BackColor = SystemColors.ButtonHighlight;
            lb_MatKhau_DangKy.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_MatKhau_DangKy.ForeColor = Color.SaddleBrown;
            lb_MatKhau_DangKy.Location = new Point(108, 263);
            lb_MatKhau_DangKy.Margin = new Padding(2, 0, 2, 0);
            lb_MatKhau_DangKy.Name = "lb_MatKhau_DangKy";
            lb_MatKhau_DangKy.Size = new Size(106, 33);
            lb_MatKhau_DangKy.TabIndex = 14;
            lb_MatKhau_DangKy.Text = "MẬT KHẨU";
            lb_MatKhau_DangKy.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_QuayLai_DangKy
            // 
            btn_QuayLai_DangKy.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_QuayLai_DangKy.ForeColor = Color.Brown;
            btn_QuayLai_DangKy.Image = Properties.Resources.hinh_nen_iPad_cute;
            btn_QuayLai_DangKy.ImageAlign = ContentAlignment.TopLeft;
            btn_QuayLai_DangKy.Location = new Point(470, 436);
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
            btn_DangKy.Location = new Point(229, 436);
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
            tb_Email_DangKy.BorderStyle = BorderStyle.FixedSingle;
            tb_Email_DangKy.Location = new Point(192, 211);
            tb_Email_DangKy.Margin = new Padding(2);
            tb_Email_DangKy.Multiline = true;
            tb_Email_DangKy.Name = "tb_Email_DangKy";
            tb_Email_DangKy.Size = new Size(527, 34);
            tb_Email_DangKy.TabIndex = 1;
            tb_Email_DangKy.TextChanged += tb_Email_DangKy_TextChanged;
            // 
            // tb_TaiKhoan_DangKy
            // 
            tb_TaiKhoan_DangKy.BackColor = Color.FloralWhite;
            tb_TaiKhoan_DangKy.BorderStyle = BorderStyle.FixedSingle;
            tb_TaiKhoan_DangKy.Location = new Point(192, 137);
            tb_TaiKhoan_DangKy.Margin = new Padding(2);
            tb_TaiKhoan_DangKy.Multiline = true;
            tb_TaiKhoan_DangKy.Name = "tb_TaiKhoan_DangKy";
            tb_TaiKhoan_DangKy.Size = new Size(527, 35);
            tb_TaiKhoan_DangKy.TabIndex = 0;
            // 
            // lb_Email_DangKy
            // 
            lb_Email_DangKy.BackColor = SystemColors.ButtonHighlight;
            lb_Email_DangKy.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_Email_DangKy.ForeColor = Color.SaddleBrown;
            lb_Email_DangKy.Location = new Point(91, 182);
            lb_Email_DangKy.Margin = new Padding(2, 0, 2, 0);
            lb_Email_DangKy.Name = "lb_Email_DangKy";
            lb_Email_DangKy.Size = new Size(106, 34);
            lb_Email_DangKy.TabIndex = 9;
            lb_Email_DangKy.Text = "EMAIL";
            lb_Email_DangKy.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lb_TaiKhoan_Dki
            // 
            lb_TaiKhoan_Dki.BackColor = SystemColors.ButtonHighlight;
            lb_TaiKhoan_Dki.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_TaiKhoan_Dki.ForeColor = Color.SaddleBrown;
            lb_TaiKhoan_Dki.Location = new Point(107, 106);
            lb_TaiKhoan_Dki.Margin = new Padding(2, 0, 2, 0);
            lb_TaiKhoan_Dki.Name = "lb_TaiKhoan_Dki";
            lb_TaiKhoan_Dki.Size = new Size(108, 37);
            lb_TaiKhoan_Dki.TabIndex = 8;
            lb_TaiKhoan_Dki.Text = "TÀI KHOẢN";
            lb_TaiKhoan_Dki.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lb_TieuDeDangKy
            // 
            lb_TieuDeDangKy.BackColor = SystemColors.ButtonHighlight;
            lb_TieuDeDangKy.FlatStyle = FlatStyle.Popup;
            lb_TieuDeDangKy.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_TieuDeDangKy.ForeColor = Color.Black;
            lb_TieuDeDangKy.Location = new Point(269, 10);
            lb_TieuDeDangKy.Margin = new Padding(2, 0, 2, 0);
            lb_TieuDeDangKy.Name = "lb_TieuDeDangKy";
            lb_TieuDeDangKy.Size = new Size(329, 48);
            lb_TieuDeDangKy.TabIndex = 7;
            lb_TieuDeDangKy.Text = "Tạo tài khoản mới";
            lb_TieuDeDangKy.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(135, 137);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(129, 210);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(52, 35);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 22;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(135, 290);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(46, 35);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 23;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(135, 368);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(36, 35);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 24;
            pictureBox5.TabStop = false;
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
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
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
        private Label label1;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
    }
}