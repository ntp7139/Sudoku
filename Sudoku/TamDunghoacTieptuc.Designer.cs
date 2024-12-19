namespace Sudoku
{
    partial class TamDunghoacTieptuc :Form
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
            lbTroChoiDaDuocTamDung = new Label();
            button1 = new Button();
            btnChoiTiep = new Button();
            SuspendLayout();
            // 
            // lbTroChoiDaDuocTamDung
            // 
            lbTroChoiDaDuocTamDung.BackColor = Color.Transparent;
            lbTroChoiDaDuocTamDung.Font = new Font("Microsoft Sans Serif", 19.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTroChoiDaDuocTamDung.Location = new Point(73, 41);
            lbTroChoiDaDuocTamDung.Margin = new Padding(6, 0, 6, 0);
            lbTroChoiDaDuocTamDung.Name = "lbTroChoiDaDuocTamDung";
            lbTroChoiDaDuocTamDung.Size = new Size(538, 78);
            lbTroChoiDaDuocTamDung.TabIndex = 3;
            lbTroChoiDaDuocTamDung.Text = "Trò chơi đã được tạm dừng";
            lbTroChoiDaDuocTamDung.Click += lbTroChoiDaDuocTamDung_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Chartreuse;
            button1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(364, 152);
            button1.Margin = new Padding(6, 8, 6, 8);
            button1.Name = "button1";
            button1.Size = new Size(247, 49);
            button1.TabIndex = 8;
            button1.Text = "Thoát Game";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnChoiTiep
            // 
            btnChoiTiep.BackColor = Color.Chartreuse;
            btnChoiTiep.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnChoiTiep.Location = new Point(73, 150);
            btnChoiTiep.Margin = new Padding(6, 8, 6, 8);
            btnChoiTiep.Name = "btnChoiTiep";
            btnChoiTiep.Size = new Size(226, 51);
            btnChoiTiep.TabIndex = 9;
            btnChoiTiep.Text = "Chơi tiếp";
            btnChoiTiep.UseVisualStyleBackColor = false;
            btnChoiTiep.Click += btnChoiTiep_Click;
            // 
            // TamDunghoacTieptuc
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(657, 242);
            Controls.Add(btnChoiTiep);
            Controls.Add(button1);
            Controls.Add(lbTroChoiDaDuocTamDung);
            Margin = new Padding(4, 5, 4, 5);
            Name = "TamDunghoacTieptuc";
            StartPosition = FormStartPosition.CenterParent;
            Text = "TamDunghoacTieptuc";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lbTroChoiDaDuocTamDung;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnChoiTiep;
    }
}