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
            lb_Taikhoan.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold);
            lb_Taikhoan.Location = new Point(66, 42);
            lb_Taikhoan.Margin = new Padding(2, 0, 2, 0);
            lb_Taikhoan.Name = "lb_Taikhoan";
            lb_Taikhoan.Size = new Size(67, 20);
            lb_Taikhoan.TabIndex = 0;
            lb_Taikhoan.Text = "Account";
            // 
            // lb_Quyentruycap
            // 
            lb_Quyentruycap.AutoSize = true;
            lb_Quyentruycap.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold);
            lb_Quyentruycap.Location = new Point(66, 98);
            lb_Quyentruycap.Margin = new Padding(2, 0, 2, 0);
            lb_Quyentruycap.Name = "lb_Quyentruycap";
            lb_Quyentruycap.Size = new Size(56, 20);
            lb_Quyentruycap.TabIndex = 1;
            lb_Quyentruycap.Text = "Access";
            // 
            // lb_Game_played
            // 
            lb_Game_played.AutoSize = true;
            lb_Game_played.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold);
            lb_Game_played.Location = new Point(66, 156);
            lb_Game_played.Margin = new Padding(2, 0, 2, 0);
            lb_Game_played.Name = "lb_Game_played";
            lb_Game_played.Size = new Size(98, 20);
            lb_Game_played.TabIndex = 2;
            lb_Game_played.Text = "Game Playes";
            // 
            // lb_game_won
            // 
            lb_game_won.AutoSize = true;
            lb_game_won.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold);
            lb_game_won.Location = new Point(66, 218);
            lb_game_won.Margin = new Padding(2, 0, 2, 0);
            lb_game_won.Name = "lb_game_won";
            lb_game_won.Size = new Size(41, 20);
            lb_game_won.TabIndex = 3;
            lb_game_won.Text = "Wins";
            // 
            // lb_Time_played
            // 
            lb_Time_played.AutoSize = true;
            lb_Time_played.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold);
            lb_Time_played.Location = new Point(66, 270);
            lb_Time_played.Margin = new Padding(2, 0, 2, 0);
            lb_Time_played.Name = "lb_Time_played";
            lb_Time_played.Size = new Size(43, 20);
            lb_Time_played.TabIndex = 4;
            lb_Time_played.Text = "Time";
            // 
            // lb_current_game_id
            // 
            lb_current_game_id.AutoSize = true;
            lb_current_game_id.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold);
            lb_current_game_id.Location = new Point(66, 314);
            lb_current_game_id.Margin = new Padding(2, 0, 2, 0);
            lb_current_game_id.Name = "lb_current_game_id";
            lb_current_game_id.Size = new Size(68, 20);
            lb_current_game_id.TabIndex = 5;
            lb_current_game_id.Text = "Game ID";
            // 
            // tB_taikhoan
            // 
            tB_taikhoan.Location = new Point(247, 42);
            tB_taikhoan.Margin = new Padding(2);
            tB_taikhoan.Name = "tB_taikhoan";
            tB_taikhoan.Size = new Size(412, 25);
            tB_taikhoan.TabIndex = 6;
            // 
            // tB_QuyenTruyCap
            // 
            tB_QuyenTruyCap.Location = new Point(247, 98);
            tB_QuyenTruyCap.Margin = new Padding(2);
            tB_QuyenTruyCap.Name = "tB_QuyenTruyCap";
            tB_QuyenTruyCap.Size = new Size(412, 25);
            tB_QuyenTruyCap.TabIndex = 7;
            // 
            // tB_game_played
            // 
            tB_game_played.Location = new Point(247, 156);
            tB_game_played.Margin = new Padding(2);
            tB_game_played.Name = "tB_game_played";
            tB_game_played.Size = new Size(412, 25);
            tB_game_played.TabIndex = 8;
            // 
            // tB_Game_won
            // 
            tB_Game_won.Location = new Point(247, 218);
            tB_Game_won.Margin = new Padding(2);
            tB_Game_won.Name = "tB_Game_won";
            tB_Game_won.Size = new Size(412, 25);
            tB_Game_won.TabIndex = 9;
            // 
            // tB_time_played
            // 
            tB_time_played.Location = new Point(247, 270);
            tB_time_played.Margin = new Padding(2);
            tB_time_played.Name = "tB_time_played";
            tB_time_played.Size = new Size(412, 25);
            tB_time_played.TabIndex = 10;
            // 
            // tB_game_id_current
            // 
            tB_game_id_current.Location = new Point(247, 314);
            tB_game_id_current.Margin = new Padding(2);
            tB_game_id_current.Name = "tB_game_id_current";
            tB_game_id_current.Size = new Size(412, 25);
            tB_game_id_current.TabIndex = 11;
            // 
            // btn_Update
            // 
            btn_Update.BackColor = Color.SteelBlue;
            btn_Update.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold);
            btn_Update.ForeColor = SystemColors.ButtonHighlight;
            btn_Update.Location = new Point(176, 375);
            btn_Update.Margin = new Padding(2);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(130, 29);
            btn_Update.TabIndex = 12;
            btn_Update.Text = "Update";
            btn_Update.UseVisualStyleBackColor = false;
            btn_Update.Click += btn_Update_Click;
            // 
            // btn_Thoat
            // 
            btn_Thoat.BackColor = Color.SteelBlue;
            btn_Thoat.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold);
            btn_Thoat.ForeColor = SystemColors.ButtonHighlight;
            btn_Thoat.Location = new Point(434, 375);
            btn_Thoat.Margin = new Padding(2);
            btn_Thoat.Name = "btn_Thoat";
            btn_Thoat.Size = new Size(108, 28);
            btn_Thoat.TabIndex = 13;
            btn_Thoat.Text = "Exit";
            btn_Thoat.UseVisualStyleBackColor = false;
            btn_Thoat.Click += btn_Thoat_Click;
            // 
            // FormThongTinNguoiChoi
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(720, 427);
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
            Font = new Font("Trebuchet MS", 9F, FontStyle.Bold);
            Margin = new Padding(2);
            Name = "FormThongTinNguoiChoi";
            StartPosition = FormStartPosition.CenterScreen;
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