namespace Sudoku
{
    partial class FormQuenMatKhau
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
            pn_QuenMatKhau = new Panel();
            btn_Quaylai = new Button();
            btn_LayLai = new Button();
            tb_Email_QMK = new TextBox();
            tB_TaiKhoan_QMK = new TextBox();
            lb_Email_QMK = new Label();
            lb_TaiKhoan_QMK = new Label();
            lb_TieuDe_QuenMatKhau = new Label();
            pn_QuenMatKhau.SuspendLayout();
            SuspendLayout();
            // 
            // pn_QuenMatKhau
            // 
            pn_QuenMatKhau.Controls.Add(btn_Quaylai);
            pn_QuenMatKhau.Controls.Add(btn_LayLai);
            pn_QuenMatKhau.Controls.Add(tb_Email_QMK);
            pn_QuenMatKhau.Controls.Add(tB_TaiKhoan_QMK);
            pn_QuenMatKhau.Controls.Add(lb_Email_QMK);
            pn_QuenMatKhau.Controls.Add(lb_TaiKhoan_QMK);
            pn_QuenMatKhau.Controls.Add(lb_TieuDe_QuenMatKhau);
            pn_QuenMatKhau.Location = new Point(1, 0);
            pn_QuenMatKhau.Name = "pn_QuenMatKhau";
            pn_QuenMatKhau.Size = new Size(798, 450);
            pn_QuenMatKhau.TabIndex = 11;
            // 
            // btn_Quaylai
            // 
            btn_Quaylai.Location = new Point(442, 272);
            btn_Quaylai.Name = "btn_Quaylai";
            btn_Quaylai.Size = new Size(143, 54);
            btn_Quaylai.TabIndex = 6;
            btn_Quaylai.Text = "Quay lại";
            btn_Quaylai.UseVisualStyleBackColor = true;
            btn_Quaylai.Click += btn_Quaylai_Click;
            // 
            // btn_LayLai
            // 
            btn_LayLai.Location = new Point(177, 272);
            btn_LayLai.Name = "btn_LayLai";
            btn_LayLai.Size = new Size(143, 54);
            btn_LayLai.TabIndex = 5;
            btn_LayLai.Text = "Lấy lại";
            btn_LayLai.UseVisualStyleBackColor = true;
            // 
            // tb_Email_QMK
            // 
            tb_Email_QMK.Location = new Point(304, 157);
            tb_Email_QMK.Name = "tb_Email_QMK";
            tb_Email_QMK.Size = new Size(328, 31);
            tb_Email_QMK.TabIndex = 4;
            // 
            // tB_TaiKhoan_QMK
            // 
            tB_TaiKhoan_QMK.Location = new Point(304, 78);
            tB_TaiKhoan_QMK.Name = "tB_TaiKhoan_QMK";
            tB_TaiKhoan_QMK.Size = new Size(328, 31);
            tB_TaiKhoan_QMK.TabIndex = 3;
            // 
            // lb_Email_QMK
            // 
            lb_Email_QMK.AutoSize = true;
            lb_Email_QMK.Location = new Point(166, 157);
            lb_Email_QMK.Name = "lb_Email_QMK";
            lb_Email_QMK.Size = new Size(58, 25);
            lb_Email_QMK.TabIndex = 2;
            lb_Email_QMK.Text = "Email:";
            // 
            // lb_TaiKhoan_QMK
            // 
            lb_TaiKhoan_QMK.AutoSize = true;
            lb_TaiKhoan_QMK.Location = new Point(164, 84);
            lb_TaiKhoan_QMK.Name = "lb_TaiKhoan_QMK";
            lb_TaiKhoan_QMK.Size = new Size(87, 25);
            lb_TaiKhoan_QMK.TabIndex = 1;
            lb_TaiKhoan_QMK.Text = "Tài Khoản";
            // 
            // lb_TieuDe_QuenMatKhau
            // 
            lb_TieuDe_QuenMatKhau.AutoSize = true;
            lb_TieuDe_QuenMatKhau.Font = new Font("Times New Roman", 16F, FontStyle.Italic, GraphicsUnit.Point, 163);
            lb_TieuDe_QuenMatKhau.Location = new Point(278, 19);
            lb_TieuDe_QuenMatKhau.Name = "lb_TieuDe_QuenMatKhau";
            lb_TieuDe_QuenMatKhau.Size = new Size(222, 37);
            lb_TieuDe_QuenMatKhau.TabIndex = 0;
            lb_TieuDe_QuenMatKhau.Text = "Quên Mật Khẩu";
            // 
            // FormQuenMatKhau
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pn_QuenMatKhau);
            Name = "FormQuenMatKhau";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quên Mật Khẩu";
            pn_QuenMatKhau.ResumeLayout(false);
            pn_QuenMatKhau.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pn_QuenMatKhau;
        private Button btn_Quaylai;
        private Button btn_LayLai;
        private TextBox tb_Email_QMK;
        private TextBox tB_TaiKhoan_QMK;
        private Label lb_Email_QMK;
        private Label lb_TaiKhoan_QMK;
        private Label lb_TieuDe_QuenMatKhau;
    }
}