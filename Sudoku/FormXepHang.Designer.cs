
namespace Sudoku
{
    partial class FormXepHang
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormXepHang));
            dataGridView1 = new DataGridView();
            btnXepHang = new Button();
            pictureBox4 = new PictureBox();
            lbLeaderBoard = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Cursor = Cursors.No;
            dataGridView1.Location = new Point(46, 97);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(712, 352);
            dataGridView1.TabIndex = 0;
            // 
            // btnXepHang
            // 
            btnXepHang.BackgroundImage = Properties.Resources.hinh_nen_may_tinh_de_thuong_21;
            btnXepHang.BackgroundImageLayout = ImageLayout.Center;
            btnXepHang.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXepHang.ForeColor = SystemColors.Highlight;
            btnXepHang.Location = new Point(303, 473);
            btnXepHang.Name = "btnXepHang";
            btnXepHang.Size = new Size(197, 45);
            btnXepHang.TabIndex = 1;
            btnXepHang.Text = "LEADERBOARD";
            btnXepHang.UseVisualStyleBackColor = true;
            btnXepHang.Visible = false;
            btnXepHang.Click += button1_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(12, 480);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(45, 38);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // lbLeaderBoard
            // 
            lbLeaderBoard.AutoSize = true;
            lbLeaderBoard.Font = new Font("Gill Sans Ultra Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbLeaderBoard.ForeColor = Color.SteelBlue;
            lbLeaderBoard.Location = new Point(288, 18);
            lbLeaderBoard.Name = "lbLeaderBoard";
            lbLeaderBoard.Size = new Size(242, 42);
            lbLeaderBoard.TabIndex = 6;
            lbLeaderBoard.Text = "Leaderboard";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(237, 60);
            label1.Name = "label1";
            label1.Size = new Size(328, 23);
            label1.TabIndex = 7;
            label1.Text = "Who’s the best? Check it out right here!";
            // 
            // FormXepHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 530);
            Controls.Add(label1);
            Controls.Add(lbLeaderBoard);
            Controls.Add(btnXepHang);
            Controls.Add(pictureBox4);
            Controls.Add(dataGridView1);
            Name = "FormXepHang";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnXepHang;
        private PictureBox pictureBox4;
        private Label lbLeaderBoard;
        private Label label1;
    }
}
