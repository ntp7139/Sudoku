
namespace QUANLYTRANGTHAIGAME
{
    partial class BatDaulai
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
            btnThoatGame = new Button();
            SuspendLayout();
            // 
            // lbTroChoiDaDuocTamDung
            // 
            lbTroChoiDaDuocTamDung.BackColor = Color.Transparent;
            lbTroChoiDaDuocTamDung.Font = new Font("Microsoft Sans Serif", 19.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTroChoiDaDuocTamDung.Location = new Point(162, 69);
            lbTroChoiDaDuocTamDung.Margin = new Padding(8, 0, 8, 0);
            lbTroChoiDaDuocTamDung.Name = "lbTroChoiDaDuocTamDung";
            lbTroChoiDaDuocTamDung.Size = new Size(773, 86);
            lbTroChoiDaDuocTamDung.TabIndex = 4;
            lbTroChoiDaDuocTamDung.Text = "Bạn có muốn bắt đầu lại không?";
            // 
            // btnChoiTiep
            // 
            btnChoiTiep.BackColor = Color.Chartreuse;
            btnChoiTiep.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnChoiTiep.Location = new Point(82, 476);
            btnChoiTiep.Margin = new Padding(8, 10, 8, 10);
            btnChoiTiep.Name = "btnChoiTiep";
            btnChoiTiep.Size = new Size(270, 72);
            btnChoiTiep.TabIndex = 8;
            btnChoiTiep.Text = "Đồng ý";
            btnChoiTiep.UseVisualStyleBackColor = false;
            btnChoiTiep.Click += btnChoiTiep_Click;
            // 
            // btnThoatGame
            // 
            btnThoatGame.BackColor = Color.Chartreuse;
            btnThoatGame.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThoatGame.Location = new Point(630, 476);
            btnThoatGame.Margin = new Padding(8, 10, 8, 10);
            btnThoatGame.Name = "btnThoatGame";
            btnThoatGame.Size = new Size(271, 72);
            btnThoatGame.TabIndex = 9;
            btnThoatGame.Text = "Thoát game";
            btnThoatGame.UseVisualStyleBackColor = false;
            btnThoatGame.Click += btnThoatGame_Click;
            // 
            // BatDaulai
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(1000, 702);
            Controls.Add(btnThoatGame);
            Controls.Add(btnChoiTiep);
            Controls.Add(lbTroChoiDaDuocTamDung);
            Margin = new Padding(3, 5, 3, 5);
            Name = "BatDaulai";
            Text = "BatDaulai";
            Load += BatDaulai_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lbTroChoiDaDuocTamDung;
        private System.Windows.Forms.Button btnChoiTiep;
        private System.Windows.Forms.Button btnThoatGame;
    }
}