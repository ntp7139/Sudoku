namespace Sudoku
{
    partial class FormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            btn_Quantringuoichoi = new Button();
            btn_Quantrimanchoi = new Button();
            btn_Thoat = new Button();
            btn_Choitrochoi = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_Quantringuoichoi
            // 
            btn_Quantringuoichoi.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Quantringuoichoi.Location = new Point(133, 118);
            btn_Quantringuoichoi.Margin = new Padding(2, 2, 2, 2);
            btn_Quantringuoichoi.Name = "btn_Quantringuoichoi";
            btn_Quantringuoichoi.Size = new Size(153, 60);
            btn_Quantringuoichoi.TabIndex = 0;
            btn_Quantringuoichoi.Text = "Quản trị người chơi";
            btn_Quantringuoichoi.UseVisualStyleBackColor = true;
            btn_Quantringuoichoi.Click += btn_Quantringuoichoi_Click;
            // 
            // btn_Quantrimanchoi
            // 
            btn_Quantrimanchoi.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Quantrimanchoi.Location = new Point(328, 118);
            btn_Quantrimanchoi.Margin = new Padding(2, 2, 2, 2);
            btn_Quantrimanchoi.Name = "btn_Quantrimanchoi";
            btn_Quantrimanchoi.Size = new Size(165, 60);
            btn_Quantrimanchoi.TabIndex = 1;
            btn_Quantrimanchoi.Text = "Quản trị màn chơi";
            btn_Quantrimanchoi.UseVisualStyleBackColor = true;
            // 
            // btn_Thoat
            // 
            btn_Thoat.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Thoat.Location = new Point(328, 205);
            btn_Thoat.Margin = new Padding(2, 2, 2, 2);
            btn_Thoat.Name = "btn_Thoat";
            btn_Thoat.Size = new Size(165, 54);
            btn_Thoat.TabIndex = 2;
            btn_Thoat.Text = "Thoát";
            btn_Thoat.UseVisualStyleBackColor = true;
            btn_Thoat.Click += btn_Thoat_Click;
            // 
            // btn_Choitrochoi
            // 
            btn_Choitrochoi.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Choitrochoi.Location = new Point(133, 205);
            btn_Choitrochoi.Margin = new Padding(2, 2, 2, 2);
            btn_Choitrochoi.Name = "btn_Choitrochoi";
            btn_Choitrochoi.Size = new Size(153, 54);
            btn_Choitrochoi.TabIndex = 3;
            btn_Choitrochoi.Text = "Chơi trò chơi";
            btn_Choitrochoi.UseVisualStyleBackColor = true;
            btn_Choitrochoi.Click += btn_Choitrochoi_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(641, 363);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(640, 360);
            Controls.Add(btn_Choitrochoi);
            Controls.Add(btn_Thoat);
            Controls.Add(btn_Quantrimanchoi);
            Controls.Add(btn_Quantringuoichoi);
            Controls.Add(pictureBox1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "FormAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAdmin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Quantringuoichoi;
        private Button btn_Quantrimanchoi;
        private Button btn_Thoat;
        private Button btn_Choitrochoi;
        private PictureBox pictureBox1;
    }
}