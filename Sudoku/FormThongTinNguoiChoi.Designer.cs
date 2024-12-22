namespace Sudoku
{
    partial class FormThongTinNguoiChoi
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
            lb_Taikhoan = new Label();
            lb_Quyentruycap = new Label();
            lb_Game_played = new Label();
            lb_game_won = new Label();
            lb_Time_played = new Label();
            lb_current_game_id = new Label();
            tB_taikhoan = new TextBox();
            tB_QuyenTruyCap = new TextBox();
            tB_game_played = new TextBox();
            tB_Game_won = new TextBox();
            tB_time_played = new TextBox();
            tB_game_id_current = new TextBox();
            btn_Update = new Button();
            btn_Thoat = new Button();
            SuspendLayout();
            // 
            // lb_Taikhoan
            // 
            lb_Taikhoan.AutoSize = true;
            lb_Taikhoan.Location = new Point(78, 18);
            lb_Taikhoan.Name = "lb_Taikhoan";
            lb_Taikhoan.Size = new Size(87, 25);
            lb_Taikhoan.TabIndex = 0;
            lb_Taikhoan.Text = "Tài Khoản";
            // 
            // lb_Quyentruycap
            // 
            lb_Quyentruycap.AutoSize = true;
            lb_Quyentruycap.Location = new Point(78, 87);
            lb_Quyentruycap.Name = "lb_Quyentruycap";
            lb_Quyentruycap.Size = new Size(133, 25);
            lb_Quyentruycap.TabIndex = 1;
            lb_Quyentruycap.Text = "Quyền truy cập";
            // 
            // lb_Game_played
            // 
            lb_Game_played.AutoSize = true;
            lb_Game_played.Location = new Point(78, 160);
            lb_Game_played.Name = "lb_Game_played";
            lb_Game_played.Size = new Size(146, 25);
            lb_Game_played.TabIndex = 2;
            lb_Game_played.Text = "Số game đã chơi";
            // 
            // lb_game_won
            // 
            lb_game_won.AutoSize = true;
            lb_game_won.Location = new Point(78, 237);
            lb_game_won.Name = "lb_game_won";
            lb_game_won.Size = new Size(134, 25);
            lb_game_won.TabIndex = 3;
            lb_game_won.Text = "Số game thắng";
            // 
            // lb_Time_played
            // 
            lb_Time_played.AutoSize = true;
            lb_Time_played.Location = new Point(78, 302);
            lb_Time_played.Name = "lb_Time_played";
            lb_Time_played.Size = new Size(152, 25);
            lb_Time_played.TabIndex = 4;
            lb_Time_played.Text = "Số giờ chơi game";
            // 
            // lb_current_game_id
            // 
            lb_current_game_id.AutoSize = true;
            lb_current_game_id.Location = new Point(78, 358);
            lb_current_game_id.Name = "lb_current_game_id";
            lb_current_game_id.Size = new Size(149, 25);
            lb_current_game_id.TabIndex = 5;
            lb_current_game_id.Text = "Mã game hiện tại";
            // 
            // tB_taikhoan
            // 
            tB_taikhoan.Location = new Point(279, 18);
            tB_taikhoan.Name = "tB_taikhoan";
            tB_taikhoan.Size = new Size(458, 31);
            tB_taikhoan.TabIndex = 6;
            // 
            // tB_QuyenTruyCap
            // 
            tB_QuyenTruyCap.Location = new Point(279, 87);
            tB_QuyenTruyCap.Name = "tB_QuyenTruyCap";
            tB_QuyenTruyCap.Size = new Size(458, 31);
            tB_QuyenTruyCap.TabIndex = 7;
            // 
            // tB_game_played
            // 
            tB_game_played.Location = new Point(279, 160);
            tB_game_played.Name = "tB_game_played";
            tB_game_played.Size = new Size(458, 31);
            tB_game_played.TabIndex = 8;
            // 
            // tB_Game_won
            // 
            tB_Game_won.Location = new Point(279, 237);
            tB_Game_won.Name = "tB_Game_won";
            tB_Game_won.Size = new Size(458, 31);
            tB_Game_won.TabIndex = 9;
            // 
            // tB_time_played
            // 
            tB_time_played.Location = new Point(279, 302);
            tB_time_played.Name = "tB_time_played";
            tB_time_played.Size = new Size(458, 31);
            tB_time_played.TabIndex = 10;
            // 
            // tB_game_id_current
            // 
            tB_game_id_current.Location = new Point(279, 358);
            tB_game_id_current.Name = "tB_game_id_current";
            tB_game_id_current.Size = new Size(458, 31);
            tB_game_id_current.TabIndex = 11;
            // 
            // btn_Update
            // 
            btn_Update.Location = new Point(189, 405);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(145, 36);
            btn_Update.TabIndex = 12;
            btn_Update.Text = "Cập nhật";
            btn_Update.UseVisualStyleBackColor = true;
            btn_Update.Click += btn_Update_Click;
            // 
            // btn_Thoat
            // 
            btn_Thoat.Location = new Point(475, 405);
            btn_Thoat.Name = "btn_Thoat";
            btn_Thoat.Size = new Size(120, 35);
            btn_Thoat.TabIndex = 13;
            btn_Thoat.Text = "Thoát";
            btn_Thoat.UseVisualStyleBackColor = true;
            btn_Thoat.Click += btn_Thoat_Click;
            // 
            // FormThongTinNguoiChoi
            // 
            StartPosition = FormStartPosition.CenterScreen;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Thoat);
            Controls.Add(btn_Update);
            Controls.Add(tB_game_id_current);
            Controls.Add(tB_time_played);
            Controls.Add(tB_Game_won);
            Controls.Add(tB_game_played);
            Controls.Add(tB_QuyenTruyCap);
            Controls.Add(tB_taikhoan);
            Controls.Add(lb_current_game_id);
            Controls.Add(lb_Time_played);
            Controls.Add(lb_game_won);
            Controls.Add(lb_Game_played);
            Controls.Add(lb_Quyentruycap);
            Controls.Add(lb_Taikhoan);
            Name = "FormThongTinNguoiChoi";
            Text = "FormThongTinNguoiChoi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_Taikhoan;
        private Label lb_Quyentruycap;
        private Label lb_Game_played;
        private Label lb_game_won;
        private Label lb_Time_played;
        private Label lb_current_game_id;
        private TextBox tB_taikhoan;
        private TextBox tB_QuyenTruyCap;
        private TextBox tB_game_played;
        private TextBox tB_Game_won;
        private TextBox tB_time_played;
        private TextBox tB_game_id_current;
        private Button btn_Update;
        private Button btn_Thoat;
    }
}