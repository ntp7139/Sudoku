namespace QUANLYTRANGTHAIGAME
{
    partial class ChoiLaiVancu
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
            lbBanCoMuonChoiLaiVanCuKhong = new Label();
            btnDongY = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // lbBanCoMuonChoiLaiVanCuKhong
            // 
            lbBanCoMuonChoiLaiVanCuKhong.AccessibleRole = AccessibleRole.Sound;
            lbBanCoMuonChoiLaiVanCuKhong.BackColor = Color.Transparent;
            lbBanCoMuonChoiLaiVanCuKhong.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbBanCoMuonChoiLaiVanCuKhong.Location = new Point(211, 89);
            lbBanCoMuonChoiLaiVanCuKhong.Margin = new Padding(5, 0, 5, 0);
            lbBanCoMuonChoiLaiVanCuKhong.Name = "lbBanCoMuonChoiLaiVanCuKhong";
            lbBanCoMuonChoiLaiVanCuKhong.Size = new Size(709, 86);
            lbBanCoMuonChoiLaiVanCuKhong.TabIndex = 1;
            lbBanCoMuonChoiLaiVanCuKhong.Text = "Bạn có muốn chơi lại ván vừa xong không?";
            // 
            // btnDongY
            // 
            btnDongY.BackColor = Color.LawnGreen;
            btnDongY.Location = new Point(96, 420);
            btnDongY.Margin = new Padding(5, 6, 5, 6);
            btnDongY.Name = "btnDongY";
            btnDongY.Size = new Size(249, 70);
            btnDongY.TabIndex = 2;
            btnDongY.Text = "Đồng ý";
            btnDongY.UseVisualStyleBackColor = false;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.LawnGreen;
            btnThoat.Location = new Point(578, 420);
            btnThoat.Margin = new Padding(5, 6, 5, 6);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(278, 70);
            btnThoat.TabIndex = 3;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // ChoiLaiVancu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(1000, 703);
            Controls.Add(btnThoat);
            Controls.Add(btnDongY);
            Controls.Add(lbBanCoMuonChoiLaiVanCuKhong);
            Margin = new Padding(4, 5, 4, 5);
            Name = "ChoiLaiVancu";
            Text = "ChoiLaiVancu";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lbBanCoMuonChoiLaiVanCuKhong;
        private System.Windows.Forms.Button btnDongY;
        private System.Windows.Forms.Button btnThoat;
    }
}