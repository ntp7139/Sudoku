using Org.BouncyCastle.Asn1.Crmf;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

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
            txtTen = new TextBox();
            txtID = new TextBox();
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // lbTen
            // 
            lbTen.AutoSize = true;
            lbTen.BackColor = Color.DeepSkyBlue;
            lbTen.BorderStyle = BorderStyle.FixedSingle;
            lbTen.Font = new System.Drawing.Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTen.ForeColor = SystemColors.ButtonHighlight;
            lbTen.Image = Properties.Resources.xanh_lá;
            lbTen.Location = new Point(19, 27);
            lbTen.Name = "lbTen";
            lbTen.RightToLeft = RightToLeft.Yes;
            lbTen.Size = new Size(50, 31);
            lbTen.TabIndex = 0;
            lbTen.Text = "Tên";
            lbTen.Click += lbTen_Click;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(77, 31);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(537, 27);
            txtTen.TabIndex = 2;
            txtTen.TextChanged += txtTen_TextChanged;
            // 
            // txtID
            // 
            txtID.Location = new Point(78, 86);
            txtID.Name = "txtID";
            txtID.Size = new Size(535, 27);
            txtID.TabIndex = 3;
            txtID.TextChanged += textBox2_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.PowderBlue;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(52, 137);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(532, 244);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Menu;
            pictureBox1.Image = Properties.Resources.nâu_vằn;
            pictureBox1.Location = new Point(17, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(54, 36);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DeepSkyBlue;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Image = Properties.Resources.xanh_lá;
            label1.Location = new Point(19, 79);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(49, 31);
            label1.TabIndex = 9;
            label1.Text = " ID";
            label1.Click += label1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.Menu;
            pictureBox2.Image = Properties.Resources.nâu_vằn;
            pictureBox2.Location = new Point(17, 76);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(54, 36);
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.ButtonHighlight;
            pictureBox3.Image = Properties.Resources.nâu_vằn;
            pictureBox3.Location = new Point(182, 401);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(289, 40);
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Screenshot_2024_12_11_163328;
            pictureBox4.Location = new Point(535, 404);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(41, 36);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.Screenshot_2024_12_11_163157;
            pictureBox5.Location = new Point(76, 404);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(35, 33);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 13;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Image = Properties.Resources.xanh_lá;
            label2.ImageAlign = ContentAlignment.TopLeft;
            label2.Location = new Point(187, 405);
            label2.Name = "label2";
            label2.Size = new Size(281, 32);
            label2.TabIndex = 14;
            label2.Text = "LỊCH SỬ NGƯỜI CHƠI";
            label2.Click += label2_Click;
            // 
            // FormThongKe
            // 
            StartPosition = FormStartPosition.CenterScreen;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = Properties.Resources.hinh2;
            ClientSize = new Size(640, 447);
            Controls.Add(label2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(txtID);
            Controls.Add(txtTen);
            Controls.Add(lbTen);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FormThongKe";
            Text = "FormThongKe";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTen;
        private TextBox txtTen;
        private TextBox txtID;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Label label2;
    }
}