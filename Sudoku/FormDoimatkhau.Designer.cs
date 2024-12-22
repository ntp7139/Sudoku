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
            lb_TieuDeDoiMatKhau = new Label();
            lb_TaiKhoan_Doimatkhau = new Label();
            tb_TaiKhoan_Doimatkhau = new TextBox();
            btn_Doimatkhau = new Button();
            lb_MatKhau = new Label();
            tb_MatKhau = new TextBox();
            tb_NhapLaiMatKhau = new TextBox();
            label2 = new Label();
            pictureBox_QuayLai = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox_QuayLai).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // lb_TieuDeDoiMatKhau
            // 
            lb_TieuDeDoiMatKhau.Font = new Font("Gill Sans Ultra Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_TieuDeDoiMatKhau.ForeColor = Color.SteelBlue;
            lb_TieuDeDoiMatKhau.Location = new Point(18, 21);
            lb_TieuDeDoiMatKhau.Margin = new Padding(2, 0, 2, 0);
            lb_TieuDeDoiMatKhau.Name = "lb_TieuDeDoiMatKhau";
            lb_TieuDeDoiMatKhau.Size = new Size(307, 89);
            lb_TieuDeDoiMatKhau.TabIndex = 7;
            lb_TieuDeDoiMatKhau.Text = "Create New Password!";
            lb_TieuDeDoiMatKhau.TextAlign = ContentAlignment.TopCenter;
            lb_TieuDeDoiMatKhau.Click += lb_TieuDeDoiMatKhau_Click;
            // 
            // lb_TaiKhoan_Doimatkhau
            // 
            lb_TaiKhoan_Doimatkhau.AutoSize = true;
            lb_TaiKhoan_Doimatkhau.BackColor = SystemColors.ControlLightLight;
            lb_TaiKhoan_Doimatkhau.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_TaiKhoan_Doimatkhau.Location = new Point(30, 166);
            lb_TaiKhoan_Doimatkhau.Margin = new Padding(2, 0, 2, 0);
            lb_TaiKhoan_Doimatkhau.Name = "lb_TaiKhoan_Doimatkhau";
            lb_TaiKhoan_Doimatkhau.Size = new Size(76, 20);
            lb_TaiKhoan_Doimatkhau.TabIndex = 8;
            lb_TaiKhoan_Doimatkhau.Text = "Tài Khoản";
            // 
            // tb_TaiKhoan_Doimatkhau
            // 
            tb_TaiKhoan_Doimatkhau.Location = new Point(31, 188);
            tb_TaiKhoan_Doimatkhau.Margin = new Padding(2);
            tb_TaiKhoan_Doimatkhau.Name = "tb_TaiKhoan_Doimatkhau";
            tb_TaiKhoan_Doimatkhau.Size = new Size(303, 27);
            tb_TaiKhoan_Doimatkhau.TabIndex = 10;
            // 
            // btn_Doimatkhau
            // 
            btn_Doimatkhau.BackColor = Color.SteelBlue;
            btn_Doimatkhau.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Doimatkhau.ForeColor = SystemColors.ButtonHighlight;
            btn_Doimatkhau.Location = new Point(86, 435);
            btn_Doimatkhau.Margin = new Padding(2);
            btn_Doimatkhau.Name = "btn_Doimatkhau";
            btn_Doimatkhau.Size = new Size(197, 39);
            btn_Doimatkhau.TabIndex = 12;
            btn_Doimatkhau.Text = "Đổi mật khẩu";
            btn_Doimatkhau.UseVisualStyleBackColor = false;
            // 
            // lb_MatKhau
            // 
            lb_MatKhau.AutoSize = true;
            lb_MatKhau.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_MatKhau.Location = new Point(30, 253);
            lb_MatKhau.Margin = new Padding(2, 0, 2, 0);
            lb_MatKhau.Name = "lb_MatKhau";
            lb_MatKhau.Size = new Size(94, 20);
            lb_MatKhau.TabIndex = 14;
            lb_MatKhau.Text = "Mật khẩu cũ";
            // 
            // tb_MatKhau
            // 
            tb_MatKhau.Location = new Point(31, 275);
            tb_MatKhau.Margin = new Padding(2);
            tb_MatKhau.Name = "tb_MatKhau";
            tb_MatKhau.PasswordChar = '*';
            tb_MatKhau.Size = new Size(303, 27);
            tb_MatKhau.TabIndex = 16;
            // 
            // tb_NhapLaiMatKhau
            // 
            tb_NhapLaiMatKhau.Location = new Point(31, 369);
            tb_NhapLaiMatKhau.Margin = new Padding(2);
            tb_NhapLaiMatKhau.Name = "tb_NhapLaiMatKhau";
            tb_NhapLaiMatKhau.PasswordChar = '*';
            tb_NhapLaiMatKhau.Size = new Size(303, 27);
            tb_NhapLaiMatKhau.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 347);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 19;
            label2.Text = "Mật khẩu mới";
            // 
            // pictureBox_QuayLai
            // 
            pictureBox_QuayLai.Image = (Image)resources.GetObject("pictureBox_QuayLai.Image");
            pictureBox_QuayLai.Location = new Point(15, 436);
            pictureBox_QuayLai.Name = "pictureBox_QuayLai";
            pictureBox_QuayLai.Size = new Size(44, 38);
            pictureBox_QuayLai.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_QuayLai.TabIndex = 20;
            pictureBox_QuayLai.TabStop = false;
            pictureBox_QuayLai.Click += pictureBox_QuayLai_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 101);
            label1.Name = "label1";
            label1.Size = new Size(310, 36);
            label1.TabIndex = 18;
            label1.Text = "Bạn muốn đổi mật khẩu? Tạo mới tại đây!";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(398, 51);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(390, 398);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(296, 158);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 22;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(296, 336);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(38, 33);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 23;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(296, 241);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(38, 35);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 24;
            pictureBox4.TabStop = false;
            // 
            // FormDoimatkhau
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 500);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(tb_NhapLaiMatKhau);
            Controls.Add(label2);
            Controls.Add(tb_MatKhau);
            Controls.Add(pictureBox_QuayLai);
            Controls.Add(tb_TaiKhoan_Doimatkhau);
            Controls.Add(label1);
            Controls.Add(lb_MatKhau);
            Controls.Add(lb_TieuDeDoiMatKhau);
            Controls.Add(btn_Doimatkhau);
            Controls.Add(lb_TaiKhoan_Doimatkhau);
            Margin = new Padding(2);
            Name = "FormDoimatkhau";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đổi Mật Khẩu";
            ((System.ComponentModel.ISupportInitialize)pictureBox_QuayLai).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_TieuDeDoiMatKhau;
        private Label lb_TaiKhoan_Doimatkhau;
        private TextBox tb_TaiKhoan_Doimatkhau;
        private Button btn_Doimatkhau;
        private Label lb_MatKhau;
        private TextBox tb_MatKhau;
        private TextBox tb_NhapLaiMatKhau;
        private Label label2;
        private PictureBox pictureBox_QuayLai;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}