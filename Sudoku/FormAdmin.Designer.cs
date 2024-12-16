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
            btn_Quantringuoichoi = new Button();
            btn_Quantrimanchoi = new Button();
            btn_Thoat = new Button();
            btn_Choitrochoi = new Button();
            SuspendLayout();
            // 
            // btn_Quantringuoichoi
            // 
            btn_Quantringuoichoi.Location = new Point(103, 84);
            btn_Quantringuoichoi.Name = "btn_Quantringuoichoi";
            btn_Quantringuoichoi.Size = new Size(250, 107);
            btn_Quantringuoichoi.TabIndex = 0;
            btn_Quantringuoichoi.Text = "Quản trị người chơi";
            btn_Quantringuoichoi.UseVisualStyleBackColor = true;
            btn_Quantringuoichoi.Click += btn_Quantringuoichoi_Click;
            // 
            // btn_Quantrimanchoi
            // 
            btn_Quantrimanchoi.Location = new Point(445, 84);
            btn_Quantrimanchoi.Name = "btn_Quantrimanchoi";
            btn_Quantrimanchoi.Size = new Size(250, 107);
            btn_Quantrimanchoi.TabIndex = 1;
            btn_Quantrimanchoi.Text = "Quản trị màn chơi";
            btn_Quantrimanchoi.UseVisualStyleBackColor = true;
            // 
            // btn_Thoat
            // 
            btn_Thoat.Location = new Point(642, -6);
            btn_Thoat.Name = "btn_Thoat";
            btn_Thoat.Size = new Size(160, 84);
            btn_Thoat.TabIndex = 2;
            btn_Thoat.Text = "Thoát";
            btn_Thoat.UseVisualStyleBackColor = true;
            btn_Thoat.Click += btn_Thoat_Click;
            // 
            // btn_Choitrochoi
            // 
            btn_Choitrochoi.Location = new Point(269, 254);
            btn_Choitrochoi.Name = "btn_Choitrochoi";
            btn_Choitrochoi.Size = new Size(250, 107);
            btn_Choitrochoi.TabIndex = 3;
            btn_Choitrochoi.Text = "Chơi trò chơi";
            btn_Choitrochoi.UseVisualStyleBackColor = true;
            btn_Choitrochoi.Click += btn_Choitrochoi_Click;
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Choitrochoi);
            Controls.Add(btn_Thoat);
            Controls.Add(btn_Quantrimanchoi);
            Controls.Add(btn_Quantringuoichoi);
            Name = "FormAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAdmin";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Quantringuoichoi;
        private Button btn_Quantrimanchoi;
        private Button btn_Thoat;
        private Button btn_Choitrochoi;
    }
}