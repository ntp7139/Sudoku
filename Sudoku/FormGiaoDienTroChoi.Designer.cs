namespace Sudoku
{
    partial class FormGiaoDienTroChoi
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
            pn_GiaoDien = new Panel();
            btn_Choitiep = new Button();
            btn_Quaylai = new Button();
            lb_Chedochoi = new Label();
            btn_Kho = new Button();
            btn_TrungBinh = new Button();
            btn_De = new Button();
            btn_Thongke = new Button();
            btn_Bangxephang = new Button();
            btn_Choilaivancu = new Button();
            btn_Thoat = new Button();
            btn_Choi = new Button();
            pn_GiaoDien.SuspendLayout();
            SuspendLayout();
            // 
            // pn_GiaoDien
            // 
            pn_GiaoDien.BackgroundImage = Properties.Resources.Untitled;
            pn_GiaoDien.Controls.Add(btn_Choitiep);
            pn_GiaoDien.Controls.Add(btn_Quaylai);
            pn_GiaoDien.Controls.Add(lb_Chedochoi);
            pn_GiaoDien.Controls.Add(btn_Kho);
            pn_GiaoDien.Controls.Add(btn_TrungBinh);
            pn_GiaoDien.Controls.Add(btn_De);
            pn_GiaoDien.Controls.Add(btn_Thongke);
            pn_GiaoDien.Controls.Add(btn_Bangxephang);
            pn_GiaoDien.Controls.Add(btn_Choilaivancu);
            pn_GiaoDien.Controls.Add(btn_Thoat);
            pn_GiaoDien.Controls.Add(btn_Choi);
            pn_GiaoDien.Dock = DockStyle.Fill;
            pn_GiaoDien.Location = new Point(0, 0);
            pn_GiaoDien.Name = "pn_GiaoDien";
            pn_GiaoDien.Size = new Size(830, 513);
            pn_GiaoDien.TabIndex = 3;
            // 
            // btn_Choitiep
            // 
            btn_Choitiep.BackColor = SystemColors.ActiveCaption;
            btn_Choitiep.Location = new Point(512, 5);
            btn_Choitiep.Name = "btn_Choitiep";
            btn_Choitiep.Size = new Size(195, 58);
            btn_Choitiep.TabIndex = 10;
            btn_Choitiep.Text = "Chơi tiếp";
            btn_Choitiep.UseVisualStyleBackColor = true;
            btn_Choitiep.Click += btn_Choitiep_Click;
            
            // 
            // btn_Quaylai
            // 
            btn_Quaylai.AutoSize = true;
            btn_Quaylai.Location = new Point(19, 28);
            btn_Quaylai.Name = "btn_Quaylai";
            btn_Quaylai.Size = new Size(86, 42);
            btn_Quaylai.TabIndex = 9;
            btn_Quaylai.Text = "Quay lại";
            btn_Quaylai.TextAlign = ContentAlignment.TopCenter;
            btn_Quaylai.UseVisualStyleBackColor = false;
            btn_Quaylai.Visible = false;
            btn_Quaylai.Click += btn_Quaylai_Click;
            // 
            // lb_Chedochoi
            // 
            lb_Chedochoi.AutoSize = true;
            lb_Chedochoi.BackColor = SystemColors.ControlDark;
            lb_Chedochoi.Font = new Font("Times New Roman", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            lb_Chedochoi.Location = new Point(235, 12);
            lb_Chedochoi.Name = "lb_Chedochoi";
            lb_Chedochoi.Size = new Size(130, 41);
            lb_Chedochoi.TabIndex = 8;
            lb_Chedochoi.Text = "Chế Độ";
            lb_Chedochoi.TextAlign = ContentAlignment.MiddleCenter;
            lb_Chedochoi.Visible = false;
            // 
            // btn_Kho
            // 
            btn_Kho.Location = new Point(214, 314);
            btn_Kho.Name = "btn_Kho";
            btn_Kho.Size = new Size(199, 84);
            btn_Kho.TabIndex = 7;
            btn_Kho.Text = "Khó";
            btn_Kho.UseVisualStyleBackColor = true;
            btn_Kho.Visible = false;
            btn_Kho.Click += btn_Kho_Click;
            // 
            // btn_TrungBinh
            // 
            btn_TrungBinh.Location = new Point(214, 187);
            btn_TrungBinh.Name = "btn_TrungBinh";
            btn_TrungBinh.Size = new Size(199, 84);
            btn_TrungBinh.TabIndex = 6;
            btn_TrungBinh.Text = "Trung Bình";
            btn_TrungBinh.UseVisualStyleBackColor = true;
            btn_TrungBinh.Visible = false;
            btn_TrungBinh.Click += btn_TrungBinh_Click;
            // 
            // btn_De
            // 
            btn_De.Location = new Point(214, 79);
            btn_De.Name = "btn_De";
            btn_De.Size = new Size(199, 84);
            btn_De.TabIndex = 5;
            btn_De.Text = "Dễ";
            btn_De.UseVisualStyleBackColor = true;
            btn_De.Visible = false;
            btn_De.Click += btn_De_Click;
            // 
            // btn_Thongke
            // 
            btn_Thongke.Location = new Point(513, 318);
            btn_Thongke.Name = "btn_Thongke";
            btn_Thongke.Size = new Size(194, 45);
            btn_Thongke.TabIndex = 4;
            btn_Thongke.Text = "Bảng thống kê";
            btn_Thongke.UseVisualStyleBackColor = true;
            btn_Thongke.Click += btn_Thongke_Click;
            // 
            // btn_Bangxephang
            // 
            btn_Bangxephang.Location = new Point(512, 236);
            btn_Bangxephang.Name = "btn_Bangxephang";
            btn_Bangxephang.Size = new Size(193, 52);
            btn_Bangxephang.TabIndex = 3;
            btn_Bangxephang.Text = "Bảng xếp hạng";
            btn_Bangxephang.UseVisualStyleBackColor = true;
            btn_Bangxephang.Click += btn_Bangxephang_Click;
            // 
            // btn_Choilaivancu
            // 
            btn_Choilaivancu.Location = new Point(512, 167);
            btn_Choilaivancu.Name = "btn_Choilaivancu";
            btn_Choilaivancu.Size = new Size(195, 44);
            btn_Choilaivancu.TabIndex = 2;
            btn_Choilaivancu.Text = "Chơi ván cũ";
            btn_Choilaivancu.UseVisualStyleBackColor = true;
            btn_Choilaivancu.Click += btn_Choilaivancu_Click;
            // 
            // btn_Thoat
            // 
            btn_Thoat.BackColor = SystemColors.ButtonFace;
            btn_Thoat.Location = new Point(512, 389);
            btn_Thoat.Name = "btn_Thoat";
            btn_Thoat.Size = new Size(195, 58);
            btn_Thoat.TabIndex = 1;
            btn_Thoat.Text = "Thoát";
            btn_Thoat.UseVisualStyleBackColor = false;
            btn_Thoat.Click += btn_Thoat_Click;
            // 
            // btn_Choi
            // 
            btn_Choi.BackColor = SystemColors.ActiveCaption;
            btn_Choi.Location = new Point(512, 87);
            btn_Choi.Name = "btn_Choi";
            btn_Choi.Size = new Size(195, 58);
            btn_Choi.TabIndex = 0;
            btn_Choi.Text = "Chơi ván mới";
            btn_Choi.UseVisualStyleBackColor = true;
            btn_Choi.Click += btn_Choi_Click;
            // 
            // FormGiaoDienTroChoi
            // 
            StartPosition = FormStartPosition.CenterScreen;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 500);
            Controls.Add(pn_GiaoDien);
            Name = "FormGiaoDienTroChoi";
            Text = "FormGiaoDienTroChoi";
            pn_GiaoDien.ResumeLayout(false);
            pn_GiaoDien.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pn_GiaoDien;
        private Button btn_Thoat;
        private Button btn_Choi;
        private Button btn_Choilaivancu;
        private Button btn_Thongke;
        private Button btn_Bangxephang;
        private Label lb_Chedochoi;
        private Button btn_Kho;
        private Button btn_TrungBinh;
        private Button btn_De;
        private Button btn_Quaylai;
        private Button btn_Choitiep;
    }
}