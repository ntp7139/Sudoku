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
            btnChoiTiep = new Button();
            SuspendLayout();
            // 
            // lbTroChoiDaDuocTamDung
            // 
            lbTroChoiDaDuocTamDung.BackColor = Color.Transparent;
            lbTroChoiDaDuocTamDung.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTroChoiDaDuocTamDung.Location = new Point(58, 11);
            lbTroChoiDaDuocTamDung.Margin = new Padding(6, 0, 6, 0);
            lbTroChoiDaDuocTamDung.Name = "lbTroChoiDaDuocTamDung";
            lbTroChoiDaDuocTamDung.Size = new Size(354, 42);
            lbTroChoiDaDuocTamDung.TabIndex = 3;
            lbTroChoiDaDuocTamDung.Text = "The game has been paused";
            lbTroChoiDaDuocTamDung.TextAlign = ContentAlignment.MiddleCenter;
            lbTroChoiDaDuocTamDung.Click += lbTroChoiDaDuocTamDung_Click;
            // 
            // btnChoiTiep
            // 
            btnChoiTiep.BackColor = Color.SteelBlue;
            btnChoiTiep.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChoiTiep.ForeColor = SystemColors.ButtonHighlight;
            btnChoiTiep.Location = new Point(172, 66);
            btnChoiTiep.Margin = new Padding(6, 8, 6, 8);
            btnChoiTiep.Name = "btnChoiTiep";
            btnChoiTiep.Size = new Size(111, 49);
            btnChoiTiep.TabIndex = 9;
            btnChoiTiep.Text = "Continue";
            btnChoiTiep.UseVisualStyleBackColor = false;
            btnChoiTiep.Click += btnChoiTiep_Click;
            // 
            // TamDunghoacTieptuc
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(468, 132);
            Controls.Add(btnChoiTiep);
            Controls.Add(lbTroChoiDaDuocTamDung);
            Margin = new Padding(4, 5, 4, 5);
            Name = "TamDunghoacTieptuc";
            StartPosition = FormStartPosition.CenterParent;
            Text = "TamDunghoacTieptuc";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lbTroChoiDaDuocTamDung;
        private System.Windows.Forms.Button btnChoiTiep;
    }
}