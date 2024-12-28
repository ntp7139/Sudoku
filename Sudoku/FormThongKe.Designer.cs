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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThongKe));
            txtTen = new TextBox();
            dataGridView1 = new DataGridView();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pb = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txtTen
            // 
            txtTen.Location = new Point(54, 259);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(228, 27);
            txtTen.TabIndex = 0;
            txtTen.TextChanged += txtTen_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.AliceBlue;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.Location = new Point(296, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 45;
            dataGridView1.Size = new Size(500, 476);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (System.Drawing.Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(201, 452);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(41, 36);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (System.Drawing.Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(38, 452);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(40, 36);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 13;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // pb
            // 
            pb.Image = Properties.Resources.anhbia1;
            pb.Location = new Point(316, -2);
            pb.Name = "pb";
            pb.Size = new Size(482, 504);
            pb.SizeMode = PictureBoxSizeMode.CenterImage;
            pb.TabIndex = 14;
            pb.TabStop = false;
            pb.Click += pb_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 257);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(17, 81);
            label1.Name = "label1";
            label1.Size = new Size(259, 47);
            label1.TabIndex = 17;
            label1.Text = "History Game";
            // 
            // label2
            // 
            label2.Font = new System.Drawing.Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(-1, 117);
            label2.Name = "label2";
            label2.Size = new Size(291, 42);
            label2.TabIndex = 18;
            label2.Text = "Review your game history and track your progress here!";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormThongKe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 500);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pb);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(dataGridView1);
            Controls.Add(txtTen);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FormThongKe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormThongKe";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtTen;
        private DataGridView dataGridView1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pb;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
    }
}