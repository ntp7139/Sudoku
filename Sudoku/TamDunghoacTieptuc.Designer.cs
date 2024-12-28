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
            lbTroChoiDaDuocTamDung.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTroChoiDaDuocTamDung.Location = new Point(46, 9);
            lbTroChoiDaDuocTamDung.Margin = new Padding(5, 0, 5, 0);
            lbTroChoiDaDuocTamDung.Name = "lbTroChoiDaDuocTamDung";
            lbTroChoiDaDuocTamDung.Size = new Size(283, 34);
            lbTroChoiDaDuocTamDung.TabIndex = 3;
            lbTroChoiDaDuocTamDung.Text = "The game has been paused";
            lbTroChoiDaDuocTamDung.TextAlign = ContentAlignment.MiddleCenter;
            lbTroChoiDaDuocTamDung.Click += lbTroChoiDaDuocTamDung_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(221, 51);
            button1.Margin = new Padding(5, 6, 5, 6);
            button1.Name = "button1";
            button1.Size = new Size(89, 40);
            button1.TabIndex = 8;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnChoiTiep
            // 
            btnChoiTiep.BackColor = Color.SteelBlue;
            btnChoiTiep.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChoiTiep.ForeColor = SystemColors.ButtonHighlight;
            btnChoiTiep.Location = new Point(60, 51);
            btnChoiTiep.Margin = new Padding(5, 6, 5, 6);
            btnChoiTiep.Name = "btnChoiTiep";
            btnChoiTiep.Size = new Size(89, 39);
            btnChoiTiep.TabIndex = 9;
            btnChoiTiep.Text = "Continue";
            btnChoiTiep.UseVisualStyleBackColor = false;
            btnChoiTiep.Click += btnChoiTiep_Click;
            // 
            // TamDunghoacTieptuc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(374, 106);
            Controls.Add(btnChoiTiep);
            Controls.Add(button1);
            Controls.Add(lbTroChoiDaDuocTamDung);
            Margin = new Padding(3, 4, 3, 4);
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