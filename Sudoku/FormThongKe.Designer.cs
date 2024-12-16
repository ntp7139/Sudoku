namespace Sudoku
{
    partial class FormThongKe
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
            lbTen = new Label();
            lbID = new Label();
            txtTen = new TextBox();
            txtID = new TextBox();
            dataGridView1 = new DataGridView();
            lbLichSuNguoiChoi = new Label();
            btnTruyNhap = new Button();
            btnHome = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lbTen
            // 
            lbTen.AutoSize = true;
            lbTen.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTen.Location = new Point(112, 71);
            lbTen.Name = "lbTen";
            lbTen.Size = new Size(48, 29);
            lbTen.TabIndex = 0;
            lbTen.Text = "Tên";
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbID.Location = new Point(114, 122);
            lbID.Name = "lbID";
            lbID.Size = new Size(38, 29);
            lbID.TabIndex = 1;
            lbID.Text = "ID";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(166, 71);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(537, 27);
            txtTen.TabIndex = 2;
            txtTen.TextChanged += txtTen_TextChanged;
            // 
            // txtID
            // 
            txtID.Location = new Point(168, 126);
            txtID.Name = "txtID";
            txtID.Size = new Size(535, 27);
            txtID.TabIndex = 3;
            txtID.TextChanged += textBox2_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(141, 184);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(535, 209);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // lbLichSuNguoiChoi
            // 
            lbLichSuNguoiChoi.AutoSize = true;
            lbLichSuNguoiChoi.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLichSuNguoiChoi.Location = new Point(270, 12);
            lbLichSuNguoiChoi.Name = "lbLichSuNguoiChoi";
            lbLichSuNguoiChoi.Size = new Size(272, 39);
            lbLichSuNguoiChoi.TabIndex = 5;
            lbLichSuNguoiChoi.Text = "Lịch sử người chơi";
            lbLichSuNguoiChoi.Click += lbLichSuNguoiChoi_Click;
            // 
            // btnTruyNhap
            // 
            btnTruyNhap.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTruyNhap.Location = new Point(241, 404);
            btnTruyNhap.Name = "btnTruyNhap";
            btnTruyNhap.Size = new Size(119, 34);
            btnTruyNhap.TabIndex = 6;
            btnTruyNhap.Text = "Truy nhập";
            btnTruyNhap.UseVisualStyleBackColor = true;
            btnTruyNhap.Click += btnTruyNhap_Click;
            // 
            // btnHome
            // 
            btnHome.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHome.Location = new Point(477, 407);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(94, 29);
            btnHome.TabIndex = 7;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // FormThongKe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnHome);
            Controls.Add(btnTruyNhap);
            Controls.Add(lbLichSuNguoiChoi);
            Controls.Add(dataGridView1);
            Controls.Add(txtID);
            Controls.Add(txtTen);
            Controls.Add(lbID);
            Controls.Add(lbTen);
            Name = "FormThongKe";
            Text = "FormThongKe";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTen;
        private Label lbID;
        private TextBox txtTen;
        private TextBox txtID;
        private DataGridView dataGridView1;
        private Label lbLichSuNguoiChoi;
        private Button btnTruyNhap;
        private Button btnHome;
    }
}