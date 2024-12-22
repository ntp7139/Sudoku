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
            dtgLuuTrangThaiVanCu = new DataGridView();
            Tenman = new DataGridViewTextBoxColumn();
            Thoigianlluu = new DataGridViewTextBoxColumn();
            btnTaiLai = new Button();
            btnHuy = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgLuuTrangThaiVanCu).BeginInit();
            SuspendLayout();
            // 
            // dtgLuuTrangThaiVanCu
            // 
            dtgLuuTrangThaiVanCu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgLuuTrangThaiVanCu.BackgroundColor = SystemColors.Control;
            dtgLuuTrangThaiVanCu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgLuuTrangThaiVanCu.Location = new Point(176, 78);
            dtgLuuTrangThaiVanCu.Margin = new Padding(4, 5, 4, 5);
            dtgLuuTrangThaiVanCu.Name = "dtgLuuTrangThaiVanCu";
            dtgLuuTrangThaiVanCu.ReadOnly = true;
            dtgLuuTrangThaiVanCu.RowHeadersWidth = 51;
            dtgLuuTrangThaiVanCu.RowTemplate.Height = 24;
            dtgLuuTrangThaiVanCu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgLuuTrangThaiVanCu.Size = new Size(649, 317);
            dtgLuuTrangThaiVanCu.TabIndex = 1;
            dtgLuuTrangThaiVanCu.CellContentClick += dtgLuuTrangThaiVanCu_CellContentClick;
            dtgLuuTrangThaiVanCu.MouseClick += dtgLuuTrangThaiVanCu_MouseClick;
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
            // btnTaiLai
            // 
            btnTaiLai.BackColor = Color.LawnGreen;
            btnTaiLai.Location = new Point(69, 533);
            btnTaiLai.Margin = new Padding(4, 5, 4, 5);
            btnTaiLai.Name = "btnTaiLai";
            btnTaiLai.Size = new Size(224, 66);
            btnTaiLai.TabIndex = 2;
            btnTaiLai.Text = "Tải lại";
            btnTaiLai.UseVisualStyleBackColor = false;
            btnTaiLai.Click += btnTaiLai_Click;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.LawnGreen;
            btnHuy.Location = new Point(672, 533);
            btnHuy.Margin = new Padding(4, 5, 4, 5);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(224, 66);
            btnHuy.TabIndex = 3;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // TaiLaiTrangthai
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(1000, 703);
            Controls.Add(btnHuy);
            Controls.Add(btnTaiLai);
            Controls.Add(dtgLuuTrangThaiVanCu);
            Margin = new Padding(4, 5, 4, 5);
            Name = "TaiLaiTrangthai";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TaiLaiTrangthai";
            ((System.ComponentModel.ISupportInitialize)dtgLuuTrangThaiVanCu).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dtgLuuTrangThaiVanCu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenman;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thoigianlluu;
        private System.Windows.Forms.Button btnTaiLai;
        private System.Windows.Forms.Button btnHuy;
    }
}