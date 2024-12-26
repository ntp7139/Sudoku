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
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tb_NhapLaiMatKhau = new TextBox();
            tb_MatKhau_DangKy = new TextBox();
            lbConfirmPasswordl = new Label();
            lbPassword = new Label();
            btnExit = new Button();
            btnSignup = new Button();
            tb_Email_DangKy = new TextBox();
            tb_TaiKhoan_DangKy = new TextBox();
            lbEmail = new Label();
            lbAccount = new Label();
            lb_TieuDeDangKy = new Label();
            pn_DangKy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            pn_DangKy.Controls.Add(lbConfirmPasswordl);
            pn_DangKy.Controls.Add(lbPassword);
            pn_DangKy.Controls.Add(btnExit);
            pn_DangKy.Controls.Add(btnSignup);
            pn_DangKy.Controls.Add(tb_Email_DangKy);
            pn_DangKy.Controls.Add(tb_TaiKhoan_DangKy);
            pn_DangKy.Controls.Add(lbEmail);
            pn_DangKy.Controls.Add(lbAccount);
            pn_DangKy.Controls.Add(lb_TieuDeDangKy);
            pn_DangKy.Location = new Point(-14, -1);
            pn_DangKy.Margin = new Padding(2);
            pn_DangKy.Name = "pn_DangKy";
            pn_DangKy.Size = new Size(826, 512);
            pn_DangKy.TabIndex = 12;
            pn_DangKy.Paint += pn_DangKy_Paint;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(136, 368);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(44, 35);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 24;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(131, 290);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(52, 35);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 23;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(131, 210);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(52, 35);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 22;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(133, 137);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(43, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(159, 55);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(535, 31);
            label1.TabIndex = 19;
            label1.Text = "Don't you have a account? Sign up here!";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tb_NhapLaiMatKhau
            // 
            tb_NhapLaiMatKhau.BackColor = SystemColors.ButtonHighlight;
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
            tb_MatKhau_DangKy.BackColor = SystemColors.ButtonHighlight;
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
            // lbConfirmPasswordl
            // 
            lbConfirmPasswordl.BackColor = SystemColors.ButtonHighlight;
            lbConfirmPasswordl.Font = new Font("Trebuchet MS", 9.5F, FontStyle.Bold);
            lbConfirmPasswordl.ForeColor = SystemColors.ActiveCaptionText;
            lbConfirmPasswordl.ImageAlign = ContentAlignment.TopLeft;
            lbConfirmPasswordl.Location = new Point(81, 344);
            lbConfirmPasswordl.Margin = new Padding(2, 0, 2, 0);
            lbConfirmPasswordl.Name = "lbConfirmPasswordl";
            lbConfirmPasswordl.Size = new Size(236, 24);
            lbConfirmPasswordl.TabIndex = 15;
            lbConfirmPasswordl.Text = "Confirm Password";
            lbConfirmPasswordl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbPassword
            // 
            lbPassword.BackColor = SystemColors.ButtonHighlight;
            lbPassword.Font = new Font("Trebuchet MS", 9.5F, FontStyle.Bold);
            lbPassword.ForeColor = SystemColors.ActiveCaptionText;
            lbPassword.Location = new Point(112, 263);
            lbPassword.Margin = new Padding(2, 0, 2, 0);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(106, 33);
            lbPassword.TabIndex = 14;
            lbPassword.Text = "Password";
            lbPassword.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.SteelBlue;
            btnExit.Font = new Font("Trebuchet MS", 11F, FontStyle.Bold);
            btnExit.ForeColor = SystemColors.ButtonHighlight;
            btnExit.ImageAlign = ContentAlignment.TopLeft;
            btnExit.Location = new Point(470, 450);
            btnExit.Margin = new Padding(2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(128, 35);
            btnExit.TabIndex = 13;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnSignup
            // 
            btnSignup.BackColor = Color.SteelBlue;
            btnSignup.Font = new Font("Trebuchet MS", 11F, FontStyle.Bold);
            btnSignup.ForeColor = SystemColors.ButtonHighlight;
            btnSignup.ImageAlign = ContentAlignment.TopRight;
            btnSignup.Location = new Point(229, 450);
            btnSignup.Margin = new Padding(2);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(128, 35);
            btnSignup.TabIndex = 12;
            btnSignup.Text = "Sign up";
            btnSignup.UseVisualStyleBackColor = false;
            btnSignup.Click += btnSignup_Click;
            // 
            // tb_Email_DangKy
            // 
            tb_Email_DangKy.BackColor = SystemColors.ButtonHighlight;
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
            tb_TaiKhoan_DangKy.BackColor = SystemColors.ButtonHighlight;
            tb_TaiKhoan_DangKy.BorderStyle = BorderStyle.FixedSingle;
            tb_TaiKhoan_DangKy.Location = new Point(192, 137);
            tb_TaiKhoan_DangKy.Margin = new Padding(2);
            tb_TaiKhoan_DangKy.Multiline = true;
            tb_TaiKhoan_DangKy.Name = "tb_TaiKhoan_DangKy";
            tb_TaiKhoan_DangKy.Size = new Size(527, 35);
            tb_TaiKhoan_DangKy.TabIndex = 0;
            // 
            // lbEmail
            // 
            lbEmail.BackColor = SystemColors.ButtonHighlight;
            lbEmail.Font = new Font("Trebuchet MS", 9.5F, FontStyle.Bold);
            lbEmail.ForeColor = SystemColors.ActiveCaptionText;
            lbEmail.Location = new Point(96, 181);
            lbEmail.Margin = new Padding(2, 0, 2, 0);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(106, 34);
            lbEmail.TabIndex = 9;
            lbEmail.Text = "Email";
            lbEmail.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbAccount
            // 
            lbAccount.BackColor = SystemColors.ButtonHighlight;
            lbAccount.Font = new Font("Trebuchet MS", 9.5F, FontStyle.Bold);
            lbAccount.ForeColor = SystemColors.ActiveCaptionText;
            lbAccount.Location = new Point(106, 106);
            lbAccount.Margin = new Padding(2, 0, 2, 0);
            lbAccount.Name = "lbAccount";
            lbAccount.Size = new Size(108, 37);
            lbAccount.TabIndex = 8;
            lbAccount.Text = "Account";
            lbAccount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lb_TieuDeDangKy
            // 
            lb_TieuDeDangKy.BackColor = SystemColors.ButtonHighlight;
            lb_TieuDeDangKy.FlatStyle = FlatStyle.Popup;
            lb_TieuDeDangKy.Font = new Font("Cooper Black", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_TieuDeDangKy.ForeColor = Color.SteelBlue;
            lb_TieuDeDangKy.Location = new Point(269, 10);
            lb_TieuDeDangKy.Margin = new Padding(2, 0, 2, 0);
            lb_TieuDeDangKy.Name = "lb_TieuDeDangKy";
            lb_TieuDeDangKy.Size = new Size(329, 48);
            lb_TieuDeDangKy.TabIndex = 7;
            lb_TieuDeDangKy.Text = "Create a new account";
            lb_TieuDeDangKy.TextAlign = ContentAlignment.MiddleCenter;
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
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pn_DangKy;
        private TextBox tb_NhapLaiMatKhau;
        private TextBox tb_MatKhau_DangKy;
        private Label lbConfirmPasswordl;
        private Label lbPassword;
        private Button btnExit;
        private Button btnSignup;
        private TextBox tb_Email_DangKy;
        private TextBox tb_TaiKhoan_DangKy;
        private Label lbEmail;
        private Label lbAccount;
        private Label lb_TieuDeDangKy;
        private Label label1;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
    }
}