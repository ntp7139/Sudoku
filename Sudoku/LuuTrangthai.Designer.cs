namespace QUANLYTRANGTHAIGAME
{
    partial class LuuTrangthai
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
            lbTenGoiNhoChoManChoi = new Label();
            lbTenManChoi = new Label();
            tbNhapTenManChoi = new TextBox();
            btnLuu = new Button();
            btnHuy = new Button();
            SuspendLayout();
            // 
            // lbTenGoiNhoChoManChoi
            // 
            lbTenGoiNhoChoManChoi.BackColor = Color.Transparent;
            lbTenGoiNhoChoManChoi.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTenGoiNhoChoManChoi.Location = new Point(248, 56);
            lbTenGoiNhoChoManChoi.Margin = new Padding(5, 0, 5, 0);
            lbTenGoiNhoChoManChoi.Name = "lbTenGoiNhoChoManChoi";
            lbTenGoiNhoChoManChoi.Size = new Size(548, 77);
            lbTenGoiNhoChoManChoi.TabIndex = 1;
            lbTenGoiNhoChoManChoi.Text = "TÊN GỢI NHỚ CHO MÀN CHƠI";
            // 
            // lbTenManChoi
            // 
            lbTenManChoi.BackColor = Color.Transparent;
            lbTenManChoi.Font = new Font("Microsoft YaHei", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTenManChoi.Location = new Point(8, 261);
            lbTenManChoi.Margin = new Padding(5, 0, 5, 0);
            lbTenManChoi.Name = "lbTenManChoi";
            lbTenManChoi.Size = new Size(201, 45);
            lbTenManChoi.TabIndex = 5;
            lbTenManChoi.Text = "Tên màn chơi";
            // 
            // tbNhapTenManChoi
            // 
            tbNhapTenManChoi.BackColor = Color.White;
            tbNhapTenManChoi.Location = new Point(206, 244);
            tbNhapTenManChoi.Margin = new Padding(5, 6, 5, 6);
            tbNhapTenManChoi.Multiline = true;
            tbNhapTenManChoi.Name = "tbNhapTenManChoi";
            tbNhapTenManChoi.Size = new Size(599, 60);
            tbNhapTenManChoi.TabIndex = 6;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.Chartreuse;
            btnLuu.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLuu.Location = new Point(206, 478);
            btnLuu.Margin = new Padding(6, 8, 6, 8);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(269, 72);
            btnLuu.TabIndex = 7;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.Chartreuse;
            btnHuy.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHuy.Location = new Point(550, 478);
            btnHuy.Margin = new Padding(6, 8, 6, 8);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(269, 72);
            btnHuy.TabIndex = 8;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // LuuTrangthai
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(1000, 703);
            Controls.Add(btnHuy);
            Controls.Add(btnLuu);
            Controls.Add(tbNhapTenManChoi);
            Controls.Add(lbTenManChoi);
            Controls.Add(lbTenGoiNhoChoManChoi);
            Margin = new Padding(4, 5, 4, 5);
            Name = "LuuTrangthai";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LuuTrangThai";
            Load += LuuTrangThai_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbTenGoiNhoChoManChoi;
        private System.Windows.Forms.Label lbTenManChoi;
        private System.Windows.Forms.TextBox tbNhapTenManChoi;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
    }
}