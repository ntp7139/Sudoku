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
            btnPlayerManagement = new Button();
            btnLevelManagement = new Button();
            btnExit = new Button();
            btnPlayGame = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnPlayerManagement
            // 
            btnPlayerManagement.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPlayerManagement.Location = new Point(166, 148);
            btnPlayerManagement.Margin = new Padding(2);
            btnPlayerManagement.Name = "btnPlayerManagement";
            btnPlayerManagement.Size = new Size(191, 75);
            btnPlayerManagement.TabIndex = 0;
            btnPlayerManagement.Text = "Player Management";
            btnPlayerManagement.UseVisualStyleBackColor = true;
            btnPlayerManagement.Click += btnPlayerManagement_Click;
            // 
            // btnLevelManagement
            // 
            btnLevelManagement.Enabled = false;
            btnLevelManagement.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Bold);
            btnLevelManagement.Location = new Point(410, 148);
            btnLevelManagement.Margin = new Padding(2);
            btnLevelManagement.Name = "btnLevelManagement";
            btnLevelManagement.Size = new Size(206, 75);
            btnLevelManagement.TabIndex = 1;
            btnLevelManagement.Text = "Level Management";
            btnLevelManagement.UseVisualStyleBackColor = true;
            btnLevelManagement.Click += btnLevelManagement_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Bold);
            btnExit.Location = new Point(410, 256);
            btnExit.Margin = new Padding(2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(206, 68);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnPlayGame
            // 
            btnPlayGame.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Bold);
            btnPlayGame.Location = new Point(166, 256);
            btnPlayGame.Margin = new Padding(2);
            btnPlayGame.Name = "btnPlayGame";
            btnPlayGame.Size = new Size(191, 68);
            btnPlayGame.TabIndex = 2;
            btnPlayGame.Text = "Play Game";
            btnPlayGame.UseVisualStyleBackColor = true;
            btnPlayGame.Click += btnPlayGame_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -2);
            pictureBox1.Margin = new Padding(4, 4, 4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(801, 454);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPlayGame);
            Controls.Add(btnExit);
            Controls.Add(btnLevelManagement);
            Controls.Add(btnPlayerManagement);
            Controls.Add(pictureBox1);
            Margin = new Padding(2);
            Name = "FormAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAdmin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnPlayerManagement;
        private Button btnLevelManagement;
        private Button btnExit;
        private Button btnPlayGame;
        private PictureBox pictureBox1;
    }
}