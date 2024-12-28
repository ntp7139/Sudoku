namespace Sudoku
{
    partial class TaiLaiTrangthai :Form
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaiLaiTrangthai));
            dtgLuuTrangThaiVanCu = new DataGridView();
            taikhoan = new DataGridViewTextBoxColumn();
            game_id = new DataGridViewTextBoxColumn();
            score = new DataGridViewTextBoxColumn();
            time = new DataGridViewTextBoxColumn();
            che_do = new DataGridViewTextBoxColumn();
            Tenman = new DataGridViewTextBoxColumn();
            Thoigianlluu = new DataGridViewTextBoxColumn();
            btnReload = new Button();
            btnHuy = new Button();
            label1 = new Label();
            lbthu = new Label();
            label2 = new Label();
            label3 = new Label();
            lbTaiDuLieuManChoi = new Label();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dtgLuuTrangThaiVanCu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dtgLuuTrangThaiVanCu
            // 
            dtgLuuTrangThaiVanCu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgLuuTrangThaiVanCu.BackgroundColor = Color.AliceBlue;
            dtgLuuTrangThaiVanCu.BorderStyle = BorderStyle.Fixed3D;
            dtgLuuTrangThaiVanCu.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgLuuTrangThaiVanCu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgLuuTrangThaiVanCu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgLuuTrangThaiVanCu.Columns.AddRange(new DataGridViewColumn[] { taikhoan, game_id, score, time, che_do });
            dtgLuuTrangThaiVanCu.Location = new Point(75, 103);
            dtgLuuTrangThaiVanCu.Margin = new Padding(3, 4, 3, 4);
            dtgLuuTrangThaiVanCu.Name = "dtgLuuTrangThaiVanCu";
            dtgLuuTrangThaiVanCu.ReadOnly = true;
            dtgLuuTrangThaiVanCu.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = Color.AliceBlue;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dtgLuuTrangThaiVanCu.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dtgLuuTrangThaiVanCu.RowHeadersWidth = 51;
            dtgLuuTrangThaiVanCu.RowTemplate.Height = 24;
            dtgLuuTrangThaiVanCu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgLuuTrangThaiVanCu.Size = new Size(641, 409);
            dtgLuuTrangThaiVanCu.TabIndex = 1;
            dtgLuuTrangThaiVanCu.CellContentClick += dtgLuuTrangThaiVanCu_CellContentClick;
            dtgLuuTrangThaiVanCu.MouseClick += dtgLuuTrangThaiVanCu_MouseClick;
            // 
            // taikhoan
            // 
            taikhoan.DataPropertyName = "taikhoan";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.AliceBlue;
            dataGridViewCellStyle2.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ActiveCaptionText;
            taikhoan.DefaultCellStyle = dataGridViewCellStyle2;
            taikhoan.HeaderText = "Account";
            taikhoan.MinimumWidth = 6;
            taikhoan.Name = "taikhoan";
            taikhoan.ReadOnly = true;
            taikhoan.Resizable = DataGridViewTriState.True;
            // 
            // game_id
            // 
            game_id.DataPropertyName = "game_id";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.AliceBlue;
            dataGridViewCellStyle3.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ActiveCaptionText;
            game_id.DefaultCellStyle = dataGridViewCellStyle3;
            game_id.HeaderText = "ID";
            game_id.MinimumWidth = 6;
            game_id.Name = "game_id";
            game_id.ReadOnly = true;
            game_id.ToolTipText = "ID used to identify you in each game session";
            // 
            // score
            // 
            score.DataPropertyName = "score";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.AliceBlue;
            dataGridViewCellStyle4.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ActiveCaptionText;
            score.DefaultCellStyle = dataGridViewCellStyle4;
            score.HeaderText = "Score";
            score.MinimumWidth = 6;
            score.Name = "score";
            score.ReadOnly = true;
            score.Resizable = DataGridViewTriState.True;
            score.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // time
            // 
            time.DataPropertyName = "time";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.AliceBlue;
            dataGridViewCellStyle5.ForeColor = SystemColors.ActiveCaptionText;
            time.DefaultCellStyle = dataGridViewCellStyle5;
            time.HeaderText = "Time";
            time.MinimumWidth = 6;
            time.Name = "time";
            time.ReadOnly = true;
            time.Resizable = DataGridViewTriState.True;
            time.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // che_do
            // 
            che_do.DataPropertyName = "che_do";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.AliceBlue;
            dataGridViewCellStyle6.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.ActiveCaptionText;
            che_do.DefaultCellStyle = dataGridViewCellStyle6;
            che_do.HeaderText = "Level";
            che_do.MinimumWidth = 6;
            che_do.Name = "che_do";
            che_do.ReadOnly = true;
            che_do.Resizable = DataGridViewTriState.True;
            che_do.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Tenman
            // 
            Tenman.MinimumWidth = 8;
            Tenman.Name = "Tenman";
            Tenman.Width = 150;
            // 
            // Thoigianlluu
            // 
            Thoigianlluu.MinimumWidth = 8;
            Thoigianlluu.Name = "Thoigianlluu";
            Thoigianlluu.Width = 150;
            // 
            // btnReload
            // 
            btnReload.BackColor = SystemColors.ButtonHighlight;
            btnReload.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReload.ForeColor = SystemColors.ButtonHighlight;
            btnReload.Location = new Point(277, 550);
            btnReload.Margin = new Padding(3, 4, 3, 4);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(11, 10);
            btnReload.TabIndex = 2;
            btnReload.Text = "Reload";
            btnReload.UseVisualStyleBackColor = false;
            btnReload.Click += btnTaiLai_Click;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.SteelBlue;
            btnHuy.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHuy.ForeColor = SystemColors.ButtonHighlight;
            btnHuy.Location = new Point(362, 521);
            btnHuy.Margin = new Padding(3, 4, 3, 4);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(118, 31);
            btnHuy.TabIndex = 3;
            btnHuy.Text = "Exit";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gill Sans Ultra Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(197, 13);
            label1.Name = "label1";
            label1.Size = new Size(267, 42);
            label1.TabIndex = 4;
            label1.Text = "Welcome back";
            // 
            // lbthu
            // 
            lbthu.AutoSize = true;
            lbthu.Font = new Font("Cooper Black", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbthu.ForeColor = Color.SteelBlue;
            lbthu.Location = new Point(460, 17);
            lbthu.Name = "lbthu";
            lbthu.Size = new Size(43, 32);
            lbthu.TabIndex = 5;
            lbthu.Text = "W";
            lbthu.Click += lbthu_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(113, 62);
            label2.Name = "label2";
            label2.Size = new Size(379, 23);
            label2.TabIndex = 6;
            label2.Text = "Which level would you like to continue? Click ";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(524, 62);
            label3.Name = "label3";
            label3.Size = new Size(139, 23);
            label3.TabIndex = 7;
            label3.Text = "to keep playing!";
            // 
            // lbTaiDuLieuManChoi
            // 
            lbTaiDuLieuManChoi.AutoSize = true;
            lbTaiDuLieuManChoi.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            lbTaiDuLieuManChoi.ForeColor = SystemColors.ActiveCaptionText;
            lbTaiDuLieuManChoi.Location = new Point(482, 62);
            lbTaiDuLieuManChoi.Name = "lbTaiDuLieuManChoi";
            lbTaiDuLieuManChoi.Size = new Size(46, 23);
            lbTaiDuLieuManChoi.TabIndex = 8;
            lbTaiDuLieuManChoi.Text = "here";
            lbTaiDuLieuManChoi.Click += lbTaiDuLieuManChoi_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(36, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(43, 43);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(673, 13);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(43, 43);
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(-1, 239);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(43, 43);
            pictureBox9.TabIndex = 16;
            pictureBox9.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(745, 200);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(43, 43);
            pictureBox5.TabIndex = 17;
            pictureBox5.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(710, 521);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(35, 33);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 18;
            pictureBox8.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(36, 511);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(33, 39);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // TaiLaiTrangthai
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 562);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(lbTaiDuLieuManChoi);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbthu);
            Controls.Add(label1);
            Controls.Add(btnHuy);
            Controls.Add(btnReload);
            Controls.Add(dtgLuuTrangThaiVanCu);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TaiLaiTrangthai";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TaiLaiTrangthai";
            ((System.ComponentModel.ISupportInitialize)dtgLuuTrangThaiVanCu).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dtgLuuTrangThaiVanCu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenman;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thoigianlluu;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnHuy;
        private Label label1;
        private Label lbthu;
        private Label label2;
        private Label label3;
        private Label lbTaiDuLieuManChoi;
        private DataGridViewTextBoxColumn taikhoan;
        private DataGridViewTextBoxColumn game_id;
        private DataGridViewTextBoxColumn score;
        private DataGridViewTextBoxColumn time;
        private DataGridViewTextBoxColumn che_do;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox9;
        private PictureBox pictureBox5;
        private PictureBox pictureBox8;
        private PictureBox pictureBox2;
    }
}