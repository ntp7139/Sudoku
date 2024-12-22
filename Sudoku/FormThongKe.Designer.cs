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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThongKe));
            txtTen = new TextBox();
            txtID = new TextBox();
            dataGridView1 = new DataGridView();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pb = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // txtTen
            // 
            txtTen.Location = new Point(90, 212);
            txtTen.Margin = new Padding(4, 4, 4, 4);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(316, 31);
            txtTen.TabIndex = 2;
            txtTen.TextChanged += txtTen_TextChanged;
            // 
            // txtID
            // 
            txtID.Location = new Point(89, 294);
            txtID.Margin = new Padding(4, 4, 4, 4);
            txtID.Name = "txtID";
            txtID.Size = new Size(318, 31);
            txtID.TabIndex = 3;
            txtID.TextChanged += textBox2_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(466, 89);
            dataGridView1.Margin = new Padding(4, 4, 4, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(535, 416);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (System.Drawing.Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(328, 440);
            pictureBox4.Margin = new Padding(4, 4, 4, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(51, 45);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (System.Drawing.Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(70, 440);
            pictureBox5.Margin = new Padding(4, 4, 4, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(50, 45);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 13;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // pb
            // 
            pb.Image = Properties.Resources.anhbia1;
            pb.Location = new Point(414, -6);
            pb.Margin = new Padding(4, 4, 4, 4);
            pb.Name = "pb";
            pb.Size = new Size(555, 511);
            pb.SizeMode = PictureBoxSizeMode.CenterImage;
            pb.TabIndex = 14;
            pb.TabStop = false;
            pb.Click += pb_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(28, 208);
            pictureBox2.Margin = new Padding(4, 4, 4, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(46, 42);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (System.Drawing.Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(32, 291);
            pictureBox3.Margin = new Padding(4, 4, 4, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(40, 38);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 16;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(55, 30);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(324, 59);
            label1.TabIndex = 17;
            label1.Text = "History Game";
            // 
            // label2
            // 
            label2.Font = new System.Drawing.Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(15, 89);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(404, 52);
            label2.TabIndex = 18;
            label2.Text = "Review your game history and track your progress here!";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormThongKe
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1000, 500);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pb);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(dataGridView1);
            Controls.Add(txtID);
            Controls.Add(txtTen);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4, 4, 4, 4);
            Name = "FormThongKe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormThongKe";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtTen;
        private TextBox txtID;
        private DataGridView dataGridView1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pb;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label1;
        private Label label2;
    }
}