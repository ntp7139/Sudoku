﻿namespace Sudoku
{
    partial class FormSudoKuDe :Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSudoKuDe));
            btnGoiY = new Button();
            btnXoa = new Button();
            btnKiemTraDungSai = new Button();
            dvgBangTroChoi = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            lb_Time = new Label();
            btn_TamDung = new Button();
            btn_Luu = new Button();
            btn_ChoiLai = new Button();
            btn_QuayLai = new Button();
            lb_Score = new Label();
            label1 = new Label();
            label2 = new Label();
            pbQuayLai = new PictureBox();
            label3 = new Label();
            pbTamDung = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            pbChoiLai = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dvgBangTroChoi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbQuayLai).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbTamDung).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbChoiLai).BeginInit();
            SuspendLayout();
            // 
            // btnGoiY
            // 
            btnGoiY.BackColor = SystemColors.ButtonHighlight;
            btnGoiY.Location = new Point(286, 588);
            btnGoiY.Margin = new Padding(3, 4, 3, 4);
            btnGoiY.Name = "btnGoiY";
            btnGoiY.Size = new Size(75, 38);
            btnGoiY.TabIndex = 1;
            btnGoiY.Text = "Gợi ý";
            btnGoiY.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = SystemColors.ButtonHighlight;
            btnXoa.Location = new Point(150, 588);
            btnXoa.Margin = new Padding(3, 4, 3, 4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 38);
            btnXoa.TabIndex = 14;
            btnXoa.Text = " Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += bntXoa_Click;
            // 
            // btnKiemTraDungSai
            // 
            btnKiemTraDungSai.BackColor = SystemColors.ButtonHighlight;
            btnKiemTraDungSai.Location = new Point(26, 587);
            btnKiemTraDungSai.Margin = new Padding(3, 4, 3, 4);
            btnKiemTraDungSai.Name = "btnKiemTraDungSai";
            btnKiemTraDungSai.Size = new Size(75, 40);
            btnKiemTraDungSai.TabIndex = 15;
            btnKiemTraDungSai.Text = "Kiểm tra";
            btnKiemTraDungSai.UseVisualStyleBackColor = false;
            btnKiemTraDungSai.Click += btnKiemTraDungSai_Click_1;
            // 
            // dvgBangTroChoi
            // 
            dvgBangTroChoi.AllowUserToOrderColumns = true;
            dvgBangTroChoi.BackgroundColor = SystemColors.ButtonHighlight;
            dvgBangTroChoi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgBangTroChoi.ColumnHeadersVisible = false;
            dvgBangTroChoi.Location = new Point(5, 107);
            dvgBangTroChoi.Margin = new Padding(3, 4, 3, 4);
            dvgBangTroChoi.Name = "dvgBangTroChoi";
            dvgBangTroChoi.RowHeadersVisible = false;
            dvgBangTroChoi.RowHeadersWidth = 51;
            dvgBangTroChoi.RowTemplate.Height = 24;
            dvgBangTroChoi.Size = new Size(509, 428);
            dvgBangTroChoi.TabIndex = 16;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.SteelBlue;
            button1.Location = new Point(17, 645);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(40, 45);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += NutNhapSo_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonHighlight;
            button2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.SteelBlue;
            button2.Location = new Point(72, 645);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(40, 45);
            button2.TabIndex = 1;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += NutNhapSo_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonHighlight;
            button3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.SteelBlue;
            button3.Location = new Point(125, 645);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(40, 45);
            button3.TabIndex = 2;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += NutNhapSo_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ButtonHighlight;
            button4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.SteelBlue;
            button4.Location = new Point(179, 645);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(40, 45);
            button4.TabIndex = 3;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += NutNhapSo_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ButtonHighlight;
            button5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.SteelBlue;
            button5.Location = new Point(233, 645);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(40, 45);
            button5.TabIndex = 4;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += NutNhapSo_Click;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ButtonHighlight;
            button6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.SteelBlue;
            button6.Location = new Point(287, 645);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(40, 45);
            button6.TabIndex = 5;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = false;
            button6.Click += NutNhapSo_Click;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.ButtonHighlight;
            button7.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.SteelBlue;
            button7.Location = new Point(340, 645);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(40, 45);
            button7.TabIndex = 6;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = false;
            button7.Click += NutNhapSo_Click;
            // 
            // button8
            // 
            button8.BackColor = SystemColors.ButtonHighlight;
            button8.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.ForeColor = Color.SteelBlue;
            button8.Location = new Point(397, 644);
            button8.Margin = new Padding(3, 4, 3, 4);
            button8.Name = "button8";
            button8.Size = new Size(40, 45);
            button8.TabIndex = 7;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = false;
            button8.Click += NutNhapSo_Click;
            // 
            // button9
            // 
            button9.BackColor = SystemColors.ButtonHighlight;
            button9.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.ForeColor = Color.SteelBlue;
            button9.Location = new Point(451, 644);
            button9.Margin = new Padding(3, 4, 3, 4);
            button9.Name = "button9";
            button9.Size = new Size(40, 45);
            button9.TabIndex = 8;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = false;
            button9.Click += NutNhapSo_Click;
            // 
            // lb_Time
            // 
            lb_Time.AutoSize = true;
            lb_Time.ForeColor = SystemColors.ControlDarkDark;
            lb_Time.Location = new Point(302, 60);
            lb_Time.Margin = new Padding(2, 0, 2, 0);
            lb_Time.Name = "lb_Time";
            lb_Time.Size = new Size(42, 20);
            lb_Time.TabIndex = 22;
            lb_Time.Text = "Time";
            // 
            // btn_TamDung
            // 
            btn_TamDung.AutoSize = true;
            btn_TamDung.Location = new Point(335, 119);
            btn_TamDung.Margin = new Padding(2);
            btn_TamDung.Name = "btn_TamDung";
            btn_TamDung.Size = new Size(87, 33);
            btn_TamDung.TabIndex = 21;
            btn_TamDung.Text = "Tạm dừng";
            btn_TamDung.UseVisualStyleBackColor = true;
            btn_TamDung.Click += btn_TamDung_Click;
            // 
            // btn_Luu
            // 
            btn_Luu.Location = new Point(418, 588);
            btn_Luu.Margin = new Padding(2);
            btn_Luu.Name = "btn_Luu";
            btn_Luu.Size = new Size(75, 38);
            btn_Luu.TabIndex = 20;
            btn_Luu.Text = "Lưu";
            btn_Luu.UseVisualStyleBackColor = true;
            btn_Luu.Click += btn_Luu_Click;
            // 
            // btn_ChoiLai
            // 
            btn_ChoiLai.Location = new Point(372, 156);
            btn_ChoiLai.Margin = new Padding(2);
            btn_ChoiLai.Name = "btn_ChoiLai";
            btn_ChoiLai.Size = new Size(70, 33);
            btn_ChoiLai.TabIndex = 19;
            btn_ChoiLai.Text = "Chơi lại";
            btn_ChoiLai.UseVisualStyleBackColor = true;
            btn_ChoiLai.Click += btn_ChoiLai_Click;
            // 
            // btn_QuayLai
            // 
            btn_QuayLai.Location = new Point(198, 119);
            btn_QuayLai.Margin = new Padding(2);
            btn_QuayLai.Name = "btn_QuayLai";
            btn_QuayLai.Size = new Size(70, 33);
            btn_QuayLai.TabIndex = 18;
            btn_QuayLai.Text = "Quay Lại";
            btn_QuayLai.UseVisualStyleBackColor = true;
            btn_QuayLai.Click += btn_QuayLai_Click;
            // 
            // lb_Score
            // 
            lb_Score.AutoSize = true;
            lb_Score.ForeColor = SystemColors.ControlDarkDark;
            lb_Score.Location = new Point(144, 60);
            lb_Score.Margin = new Padding(2, 0, 2, 0);
            lb_Score.Name = "lb_Score";
            lb_Score.Size = new Size(46, 20);
            lb_Score.TabIndex = 23;
            lb_Score.Text = "Score";
            lb_Score.Click += lb_Score_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(5, 60);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 24;
            label1.Text = "Độ khó";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(5, 83);
            label2.Name = "label2";
            label2.Size = new Size(28, 20);
            label2.TabIndex = 25;
            label2.Text = "Dễ";
            // 
            // pbQuayLai
            // 
            pbQuayLai.Image = (Image)resources.GetObject("pbQuayLai.Image");
            pbQuayLai.Location = new Point(0, 0);
            pbQuayLai.Name = "pbQuayLai";
            pbQuayLai.Size = new Size(33, 37);
            pbQuayLai.SizeMode = PictureBoxSizeMode.StretchImage;
            pbQuayLai.TabIndex = 26;
            pbQuayLai.TabStop = false;
            pbQuayLai.Click += pbQuayLai_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(184, 6);
            label3.Name = "label3";
            label3.Size = new Size(96, 31);
            label3.TabIndex = 27;
            label3.Text = "Sudoku";
            // 
            // pbTamDung
            // 
            pbTamDung.Image = (Image)resources.GetObject("pbTamDung.Image");
            pbTamDung.Location = new Point(438, 53);
            pbTamDung.Name = "pbTamDung";
            pbTamDung.Size = new Size(35, 33);
            pbTamDung.SizeMode = PictureBoxSizeMode.StretchImage;
            pbTamDung.TabIndex = 28;
            pbTamDung.TabStop = false;
            pbTamDung.Click += pbTamDung_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(438, 549);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(35, 40);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 30;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(302, 549);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(42, 40);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 31;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(163, 548);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(50, 40);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 32;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(38, 549);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(48, 38);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 33;
            pictureBox7.TabStop = false;
            // 
            // pbChoiLai
            // 
            pbChoiLai.Image = (Image)resources.GetObject("pbChoiLai.Image");
            pbChoiLai.Location = new Point(474, 1);
            pbChoiLai.Name = "pbChoiLai";
            pbChoiLai.Size = new Size(40, 37);
            pbChoiLai.SizeMode = PictureBoxSizeMode.StretchImage;
            pbChoiLai.TabIndex = 34;
            pbChoiLai.TabStop = false;
            pbChoiLai.Click += pbChoiLai_Click;
            // 
            // FormSudoKuDe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(521, 698);
            Controls.Add(pbChoiLai);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pbTamDung);
            Controls.Add(label3);
            Controls.Add(pbQuayLai);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lb_Score);
            Controls.Add(dvgBangTroChoi);
            Controls.Add(lb_Time);
            Controls.Add(btn_TamDung);
            Controls.Add(btn_Luu);
            Controls.Add(btn_ChoiLai);
            Controls.Add(btn_QuayLai);
            Controls.Add(btnKiemTraDungSai);
            Controls.Add(btnXoa);
            Controls.Add(btnGoiY);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormSudoKuDe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chế Độ Dễ";
            ((System.ComponentModel.ISupportInitialize)dvgBangTroChoi).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbQuayLai).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbTamDung).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbChoiLai).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Button btnGoiY;
      /*  private System.Windows.Forms.Button btnNhap1;
        private System.Windows.Forms.Button btnNhap2;
        private System.Windows.Forms.Button bntNhap3;
        private System.Windows.Forms.Button bntNhap4;
        private System.Windows.Forms.Button bntNhap5;
        private System.Windows.Forms.Button bntNhap6;
        private System.Windows.Forms.Button btnNhap7;
        private System.Windows.Forms.Button bntNhap8;
        private System.Windows.Forms.Button bntNhap9;*/
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnKiemTraDungSai;
        private System.Windows.Forms.DataGridView dvgBangTroChoi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private Label lb_Time;
        private Button btn_TamDung;
        private Button btn_Luu;
        private Button btn_ChoiLai;
        private Button btn_QuayLai;
        private Label lb_Score;
        private Label label1;
        private Label label2;
        private PictureBox pbQuayLai;
        private Label label3;
        private PictureBox pbTamDung;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pbChoiLai;
    }
}