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
            lbThoat = new Label();
            button3 = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lbDoimatkhau = new Label();
            btn_DongY = new Button();
            tB_MatKhau = new TextBox();
            lb_MatKhau = new Label();
            lb_TaiKhoan = new Label();
            tB_TaiKhoan = new TextBox();
            pictureBox1 = new PictureBox();
            tCt_FormDangNhap = new TabControl();
            pn_DangNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            pn_DangNhap.BackColor = SystemColors.ButtonHighlight;
            pn_DangNhap.Controls.Add(lbThoat);
            pn_DangNhap.Controls.Add(button3);
            pn_DangNhap.Controls.Add(label3);
            pn_DangNhap.Controls.Add(label2);
            pn_DangNhap.Controls.Add(label1);
            pn_DangNhap.Controls.Add(lbDoimatkhau);
            pn_DangNhap.Controls.Add(btn_DongY);
            pn_DangNhap.Controls.Add(tB_MatKhau);
            pn_DangNhap.Controls.Add(lb_MatKhau);
            pn_DangNhap.Controls.Add(lb_TaiKhoan);
            pn_DangNhap.Controls.Add(tB_TaiKhoan);
            pn_DangNhap.Controls.Add(pictureBox1);
            pn_DangNhap.Dock = DockStyle.Fill;
            pn_DangNhap.Location = new Point(0, 0);
            pn_DangNhap.Margin = new Padding(2);
            pn_DangNhap.Name = "pn_DangNhap";
            pn_DangNhap.Size = new Size(1000, 625);
            pn_DangNhap.TabIndex = 9;
            pn_DangNhap.Paint += pn_DangNhap_Paint;
            // 
            // lbThoat
            // 
            lbThoat.AutoSize = true;
            lbThoat.Font = new Font("Segoe UI", 9F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 163);
            lbThoat.Location = new Point(839, 570);
            lbThoat.Margin = new Padding(2, 0, 2, 0);
            lbThoat.Name = "lbThoat";
            lbThoat.Size = new Size(57, 25);
            lbThoat.TabIndex = 15;
            lbThoat.Text = "Thoát";
            lbThoat.Click += label4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.SteelBlue;
            button3.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(598, 494);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(336, 44);
            button3.TabIndex = 14;
            button3.Text = "Đăng Ký";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveBorder;
            label3.Location = new Point(746, 462);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(29, 25);
            label3.TabIndex = 13;
            label3.Text = "or";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(578, 119);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(259, 25);
            label2.TabIndex = 11;
            label2.Text = "Please log in to your account";
            // 
            // label1
            // 
            label1.Font = new Font("Gill Sans Ultra Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(578, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(300, 108);
            label1.TabIndex = 10;
            label1.Text = "Welcome Back!";
            // 
            // lbDoimatkhau
            // 
            lbDoimatkhau.AutoSize = true;
            lbDoimatkhau.Font = new Font("Segoe UI", 9F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 163);
            lbDoimatkhau.Location = new Point(624, 571);
            lbDoimatkhau.Margin = new Padding(2, 0, 2, 0);
            lbDoimatkhau.Name = "lbDoimatkhau";
            lbDoimatkhau.Size = new Size(120, 25);
            lbDoimatkhau.TabIndex = 9;
            lbDoimatkhau.Text = "Đổi mật khẩu";
            lbDoimatkhau.Click += lbDoimatkhau_Click;
            // 
            // btn_DongY
            // 
            btn_DongY.BackColor = Color.SteelBlue;
            btn_DongY.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_DongY.ForeColor = SystemColors.ButtonHighlight;
            btn_DongY.Location = new Point(598, 419);
            btn_DongY.Margin = new Padding(2);
            btn_DongY.Name = "btn_DongY";
            btn_DongY.Size = new Size(336, 44);
            btn_DongY.TabIndex = 5;
            btn_DongY.Text = "Đăng Nhập";
            btn_DongY.UseVisualStyleBackColor = false;
            btn_DongY.Click += btn_DongY_Click;
            // 
            // tB_MatKhau
            // 
            tB_MatKhau.Location = new Point(580, 328);
            tB_MatKhau.Margin = new Padding(2);
            tB_MatKhau.Name = "tB_MatKhau";
            tB_MatKhau.PasswordChar = '*';
            tB_MatKhau.Size = new Size(366, 31);
            tB_MatKhau.TabIndex = 3;
            // 
            // lb_MatKhau
            // 
            lb_MatKhau.AutoSize = true;
            lb_MatKhau.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_MatKhau.Location = new Point(580, 298);
            lb_MatKhau.Margin = new Padding(2, 0, 2, 0);
            lb_MatKhau.Name = "lb_MatKhau";
            lb_MatKhau.Size = new Size(95, 25);
            lb_MatKhau.TabIndex = 2;
            lb_MatKhau.Text = "Mật khẩu";
            // 
            // lb_TaiKhoan
            // 
            lb_TaiKhoan.AutoSize = true;
            lb_TaiKhoan.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_TaiKhoan.Location = new Point(575, 188);
            lb_TaiKhoan.Margin = new Padding(2, 0, 2, 0);
            lb_TaiKhoan.Name = "lb_TaiKhoan";
            lb_TaiKhoan.Size = new Size(98, 25);
            lb_TaiKhoan.TabIndex = 1;
            lb_TaiKhoan.Text = "Tài Khoản";
            // 
            // tB_TaiKhoan
            // 
            tB_TaiKhoan.Location = new Point(576, 216);
            tB_TaiKhoan.Margin = new Padding(2);
            tB_TaiKhoan.Name = "tB_TaiKhoan";
            tB_TaiKhoan.Size = new Size(370, 31);
            tB_TaiKhoan.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.anhbia1;
            pictureBox1.Location = new Point(1, -1);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(555, 625);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // tCt_FormDangNhap
            // 
            tCt_FormDangNhap.Location = new Point(0, 0);
            tCt_FormDangNhap.Name = "tCt_FormDangNhap";
            tCt_FormDangNhap.SelectedIndex = 0;
            tCt_FormDangNhap.Size = new Size(800, 500);
            tCt_FormDangNhap.TabIndex = 0;
            // 
            // FormDangNhap
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1000, 625);
            Controls.Add(pn_DangNhap);
            Margin = new Padding(2);
            Name = "FormDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng Nhập";
            pn_DangNhap.ResumeLayout(false);
            pn_DangNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Button button2;
        private TabPage tabPage2;
        private TabPage tabPage1;
        private Panel pn_DangNhap;
        private Button btn_DongY;
        private TextBox tB_MatKhau;
        private Label lb_MatKhau;
        private Label lb_TaiKhoan;
        private TextBox tB_TaiKhoan;
        private TabControl tCt_FormDangNhap;
        private Label lbDoimatkhau;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Button button3;
        private Label lbThoat;
    }
}
