﻿namespace Sudoku
{
    partial class FormQuanTriNguoiChoi
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dtGV_Quantritaikhoan = new DataGridView();
            column_Account = new DataGridViewTextBoxColumn();
            column_Password = new DataGridViewTextBoxColumn();
            column_email = new DataGridViewTextBoxColumn();
            column_Access = new DataGridViewTextBoxColumn();
            btn_Add = new Button();
            btn_Edit = new Button();
            btn_Delete = new Button();
            btn_Tailai = new Button();
            pn_Giaodienchinh = new Panel();
            pn_Themnguoichoi = new Panel();
            btnExit = new Button();
            btnAdd = new Button();
            rB_admin_Them = new RadioButton();
            rB_user_Them = new RadioButton();
            tB_Email_Them = new TextBox();
            tB_Matkhau_Them = new TextBox();
            tB_Taikhoan_Them = new TextBox();
            lbPermisson = new Label();
            lbEmail = new Label();
            lbPassword = new Label();
            lbAccount = new Label();
            pn_Xoa = new Panel();
            btnExit_frmXoa = new Button();
            btnDelete = new Button();
            tB_Taikhoan_xoa = new TextBox();
            lb_taikhoan_xoa = new Label();
            pn_Suanguoichoi = new Panel();
            btnExit_frmSua = new Button();
            btnEdit = new Button();
            rB_admin_Sua = new RadioButton();
            rB_user_Sua = new RadioButton();
            tB_Email_Sua = new TextBox();
            tB_Matkhau_Sua = new TextBox();
            lb_phanquyen_Sua = new Label();
            lb_email_Sua = new Label();
            lb_Matkhau_Sua = new Label();
            tB_Taikhoan_Sua = new TextBox();
            lb_Nhaptaikhoan_sua = new Label();
            ((System.ComponentModel.ISupportInitialize)dtGV_Quantritaikhoan).BeginInit();
            pn_Giaodienchinh.SuspendLayout();
            pn_Themnguoichoi.SuspendLayout();
            pn_Xoa.SuspendLayout();
            pn_Suanguoichoi.SuspendLayout();
            SuspendLayout();
            // 
            // dtGV_Quantritaikhoan
            // 
            dtGV_Quantritaikhoan.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.SteelBlue;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dtGV_Quantritaikhoan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dtGV_Quantritaikhoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGV_Quantritaikhoan.Columns.AddRange(new DataGridViewColumn[] { column_Account, column_Password, column_email, column_Access });
            dtGV_Quantritaikhoan.Location = new Point(92, 93);
            dtGV_Quantritaikhoan.Margin = new Padding(2);
            dtGV_Quantritaikhoan.Name = "dtGV_Quantritaikhoan";
            dtGV_Quantritaikhoan.RowHeadersWidth = 62;
            dataGridViewCellStyle4.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ActiveCaptionText;
            dtGV_Quantritaikhoan.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dtGV_Quantritaikhoan.Size = new Size(796, 500);
            dtGV_Quantritaikhoan.TabIndex = 0;
            dtGV_Quantritaikhoan.CellContentClick += dtGV_Quantritaikhoan_CellContentClick;
            dtGV_Quantritaikhoan.RowPostPaint += dataGridView1_RowPostPaint;
            // 
            // column_Account
            // 
            column_Account.DataPropertyName = "taikhoan";
            column_Account.HeaderText = "Account";
            column_Account.MinimumWidth = 8;
            column_Account.Name = "column_Account";
            column_Account.ReadOnly = true;
            column_Account.Width = 150;
            // 
            // column_Password
            // 
            column_Password.DataPropertyName = "matkhau";
            column_Password.HeaderText = "Password";
            column_Password.MinimumWidth = 8;
            column_Password.Name = "column_Password";
            column_Password.Width = 150;
            // 
            // column_email
            // 
            column_email.DataPropertyName = "email";
            column_email.HeaderText = "Email";
            column_email.MinimumWidth = 8;
            column_email.Name = "column_email";
            column_email.Width = 230;
            // 
            // column_Access
            // 
            column_Access.DataPropertyName = "access";
            column_Access.HeaderText = "Access";
            column_Access.MinimumWidth = 8;
            column_Access.Name = "column_Access";
            column_Access.Width = 200;
            // 
            // btn_Add
            // 
            btn_Add.BackColor = Color.SteelBlue;
            btn_Add.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Add.ForeColor = SystemColors.ButtonHighlight;
            btn_Add.Location = new Point(215, 28);
            btn_Add.Margin = new Padding(2);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(149, 42);
            btn_Add.TabIndex = 1;
            btn_Add.Text = "Add";
            btn_Add.UseVisualStyleBackColor = false;
            btn_Add.Click += btn_Add_Click;
            // 
            // btn_Edit
            // 
            btn_Edit.BackColor = Color.SteelBlue;
            btn_Edit.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Bold);
            btn_Edit.ForeColor = SystemColors.ButtonHighlight;
            btn_Edit.Location = new Point(459, 28);
            btn_Edit.Margin = new Padding(2);
            btn_Edit.Name = "btn_Edit";
            btn_Edit.Size = new Size(149, 42);
            btn_Edit.TabIndex = 2;
            btn_Edit.Text = "Edit";
            btn_Edit.UseVisualStyleBackColor = false;
            btn_Edit.Click += btn_Edit_Click;
            // 
            // btn_Delete
            // 
            btn_Delete.BackColor = Color.SteelBlue;
            btn_Delete.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Bold);
            btn_Delete.ForeColor = SystemColors.ButtonHighlight;
            btn_Delete.Location = new Point(705, 28);
            btn_Delete.Margin = new Padding(2);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(149, 42);
            btn_Delete.TabIndex = 3;
            btn_Delete.Text = "Delete";
            btn_Delete.UseVisualStyleBackColor = false;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // btn_Tailai
            // 
            btn_Tailai.BackColor = Color.SteelBlue;
            btn_Tailai.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Tailai.Location = new Point(110, 30);
            btn_Tailai.Margin = new Padding(2);
            btn_Tailai.Name = "btn_Tailai";
            btn_Tailai.Size = new Size(52, 41);
            btn_Tailai.TabIndex = 5;
            btn_Tailai.UseVisualStyleBackColor = false;
            btn_Tailai.Click += btn_Tailai_Click;
            // 
            // pn_Giaodienchinh
            // 
            pn_Giaodienchinh.BackColor = SystemColors.ButtonHighlight;
            pn_Giaodienchinh.Controls.Add(btn_Tailai);
            pn_Giaodienchinh.Controls.Add(btn_Delete);
            pn_Giaodienchinh.Controls.Add(btn_Edit);
            pn_Giaodienchinh.Controls.Add(btn_Add);
            pn_Giaodienchinh.Controls.Add(dtGV_Quantritaikhoan);
            pn_Giaodienchinh.Location = new Point(4, 1);
            pn_Giaodienchinh.Margin = new Padding(2);
            pn_Giaodienchinh.Name = "pn_Giaodienchinh";
            pn_Giaodienchinh.Size = new Size(992, 626);
            pn_Giaodienchinh.TabIndex = 6;
            // 
            // pn_Themnguoichoi
            // 
            pn_Themnguoichoi.BackColor = SystemColors.ButtonHighlight;
            pn_Themnguoichoi.Controls.Add(btnExit);
            pn_Themnguoichoi.Controls.Add(btnAdd);
            pn_Themnguoichoi.Controls.Add(rB_admin_Them);
            pn_Themnguoichoi.Controls.Add(rB_user_Them);
            pn_Themnguoichoi.Controls.Add(tB_Email_Them);
            pn_Themnguoichoi.Controls.Add(tB_Matkhau_Them);
            pn_Themnguoichoi.Controls.Add(tB_Taikhoan_Them);
            pn_Themnguoichoi.Controls.Add(lbPermisson);
            pn_Themnguoichoi.Controls.Add(lbEmail);
            pn_Themnguoichoi.Controls.Add(lbPassword);
            pn_Themnguoichoi.Controls.Add(lbAccount);
            pn_Themnguoichoi.Location = new Point(92, 94);
            pn_Themnguoichoi.Margin = new Padding(2);
            pn_Themnguoichoi.Name = "pn_Themnguoichoi";
            pn_Themnguoichoi.Size = new Size(800, 410);
            pn_Themnguoichoi.TabIndex = 12;
            pn_Themnguoichoi.Visible = false;
            pn_Themnguoichoi.Paint += pn_Themnguoichoi_Paint;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.SteelBlue;
            btnExit.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold);
            btnExit.ForeColor = SystemColors.ButtonHighlight;
            btnExit.Location = new Point(455, 330);
            btnExit.Margin = new Padding(2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(145, 39);
            btnExit.TabIndex = 10;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.SteelBlue;
            btnAdd.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold);
            btnAdd.ForeColor = SystemColors.ButtonHighlight;
            btnAdd.Location = new Point(171, 330);
            btnAdd.Margin = new Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(145, 39);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // rB_admin_Them
            // 
            rB_admin_Them.AutoSize = true;
            rB_admin_Them.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rB_admin_Them.Location = new Point(510, 235);
            rB_admin_Them.Margin = new Padding(2);
            rB_admin_Them.Name = "rB_admin_Them";
            rB_admin_Them.Size = new Size(83, 27);
            rB_admin_Them.TabIndex = 8;
            rB_admin_Them.TabStop = true;
            rB_admin_Them.Text = "admin";
            rB_admin_Them.UseVisualStyleBackColor = true;
            // 
            // rB_user_Them
            // 
            rB_user_Them.AutoSize = true;
            rB_user_Them.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rB_user_Them.Location = new Point(300, 235);
            rB_user_Them.Margin = new Padding(2);
            rB_user_Them.Name = "rB_user_Them";
            rB_user_Them.Size = new Size(69, 27);
            rB_user_Them.TabIndex = 7;
            rB_user_Them.TabStop = true;
            rB_user_Them.Text = "user";
            rB_user_Them.UseVisualStyleBackColor = true;
            // 
            // tB_Email_Them
            // 
            tB_Email_Them.Location = new Point(228, 170);
            tB_Email_Them.Margin = new Padding(2);
            tB_Email_Them.Name = "tB_Email_Them";
            tB_Email_Them.Size = new Size(476, 31);
            tB_Email_Them.TabIndex = 6;
            // 
            // tB_Matkhau_Them
            // 
            tB_Matkhau_Them.Location = new Point(228, 102);
            tB_Matkhau_Them.Margin = new Padding(2);
            tB_Matkhau_Them.Name = "tB_Matkhau_Them";
            tB_Matkhau_Them.Size = new Size(476, 31);
            tB_Matkhau_Them.TabIndex = 5;
            // 
            // tB_Taikhoan_Them
            // 
            tB_Taikhoan_Them.Location = new Point(228, 34);
            tB_Taikhoan_Them.Margin = new Padding(2);
            tB_Taikhoan_Them.Name = "tB_Taikhoan_Them";
            tB_Taikhoan_Them.Size = new Size(476, 31);
            tB_Taikhoan_Them.TabIndex = 4;
            // 
            // lbPermisson
            // 
            lbPermisson.AutoSize = true;
            lbPermisson.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold);
            lbPermisson.Location = new Point(64, 238);
            lbPermisson.Margin = new Padding(2, 0, 2, 0);
            lbPermisson.Name = "lbPermisson";
            lbPermisson.Size = new Size(95, 23);
            lbPermisson.TabIndex = 3;
            lbPermisson.Text = "Permisson";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold);
            lbEmail.Location = new Point(61, 176);
            lbEmail.Margin = new Padding(2, 0, 2, 0);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(55, 23);
            lbEmail.TabIndex = 2;
            lbEmail.Text = "Email";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold);
            lbPassword.Location = new Point(61, 109);
            lbPassword.Margin = new Padding(2, 0, 2, 0);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(88, 23);
            lbPassword.TabIndex = 1;
            lbPassword.Text = "Password";
            // 
            // lbAccount
            // 
            lbAccount.AutoSize = true;
            lbAccount.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbAccount.Location = new Point(60, 38);
            lbAccount.Margin = new Padding(2, 0, 2, 0);
            lbAccount.Name = "lbAccount";
            lbAccount.Size = new Size(78, 23);
            lbAccount.TabIndex = 0;
            lbAccount.Text = "Account";
            // 
            // pn_Xoa
            // 
            pn_Xoa.Controls.Add(btnExit_frmXoa);
            pn_Xoa.Controls.Add(btnDelete);
            pn_Xoa.Controls.Add(tB_Taikhoan_xoa);
            pn_Xoa.Controls.Add(lb_taikhoan_xoa);
            pn_Xoa.Location = new Point(115, 102);
            pn_Xoa.Margin = new Padding(2);
            pn_Xoa.Name = "pn_Xoa";
            pn_Xoa.Size = new Size(622, 172);
            pn_Xoa.TabIndex = 14;
            pn_Xoa.Visible = false;
            // 
            // btnExit_frmXoa
            // 
            btnExit_frmXoa.BackColor = Color.SteelBlue;
            btnExit_frmXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit_frmXoa.ForeColor = SystemColors.ButtonHighlight;
            btnExit_frmXoa.Location = new Point(332, 102);
            btnExit_frmXoa.Margin = new Padding(4);
            btnExit_frmXoa.Name = "btnExit_frmXoa";
            btnExit_frmXoa.Size = new Size(118, 36);
            btnExit_frmXoa.TabIndex = 15;
            btnExit_frmXoa.Text = "Exit";
            btnExit_frmXoa.UseVisualStyleBackColor = false;
            btnExit_frmXoa.Click += btnExit_frmXoa_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.SteelBlue;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(118, 102);
            btnDelete.Margin = new Padding(4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(118, 36);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // tB_Taikhoan_xoa
            // 
            tB_Taikhoan_xoa.Location = new Point(182, 18);
            tB_Taikhoan_xoa.Margin = new Padding(2);
            tB_Taikhoan_xoa.Name = "tB_Taikhoan_xoa";
            tB_Taikhoan_xoa.Size = new Size(388, 31);
            tB_Taikhoan_xoa.TabIndex = 1;
            // 
            // lb_taikhoan_xoa
            // 
            lb_taikhoan_xoa.AutoSize = true;
            lb_taikhoan_xoa.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_taikhoan_xoa.Location = new Point(18, 24);
            lb_taikhoan_xoa.Margin = new Padding(2, 0, 2, 0);
            lb_taikhoan_xoa.Name = "lb_taikhoan_xoa";
            lb_taikhoan_xoa.Size = new Size(78, 23);
            lb_taikhoan_xoa.TabIndex = 0;
            lb_taikhoan_xoa.Text = "Account";
            // 
            // pn_Suanguoichoi
            // 
            pn_Suanguoichoi.BackColor = SystemColors.ButtonHighlight;
            pn_Suanguoichoi.Controls.Add(btnExit_frmSua);
            pn_Suanguoichoi.Controls.Add(btnEdit);
            pn_Suanguoichoi.Controls.Add(rB_admin_Sua);
            pn_Suanguoichoi.Controls.Add(rB_user_Sua);
            pn_Suanguoichoi.Controls.Add(tB_Email_Sua);
            pn_Suanguoichoi.Controls.Add(tB_Matkhau_Sua);
            pn_Suanguoichoi.Controls.Add(lb_phanquyen_Sua);
            pn_Suanguoichoi.Controls.Add(lb_email_Sua);
            pn_Suanguoichoi.Controls.Add(lb_Matkhau_Sua);
            pn_Suanguoichoi.Controls.Add(tB_Taikhoan_Sua);
            pn_Suanguoichoi.Controls.Add(lb_Nhaptaikhoan_sua);
            pn_Suanguoichoi.Location = new Point(202, 49);
            pn_Suanguoichoi.Margin = new Padding(2);
            pn_Suanguoichoi.Name = "pn_Suanguoichoi";
            pn_Suanguoichoi.Size = new Size(604, 392);
            pn_Suanguoichoi.TabIndex = 13;
            pn_Suanguoichoi.Visible = false;
            pn_Suanguoichoi.Paint += pn_Suanguoichoi_Paint;
            // 
            // btnExit_frmSua
            // 
            btnExit_frmSua.BackColor = Color.SteelBlue;
            btnExit_frmSua.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Bold);
            btnExit_frmSua.ForeColor = SystemColors.ButtonHighlight;
            btnExit_frmSua.Location = new Point(394, 335);
            btnExit_frmSua.Margin = new Padding(4);
            btnExit_frmSua.Name = "btnExit_frmSua";
            btnExit_frmSua.Size = new Size(118, 45);
            btnExit_frmSua.TabIndex = 16;
            btnExit_frmSua.Text = "Exit";
            btnExit_frmSua.UseVisualStyleBackColor = false;
            btnExit_frmSua.Click += btnExit_frmSua_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.SteelBlue;
            btnEdit.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Bold);
            btnEdit.ForeColor = SystemColors.ButtonHighlight;
            btnEdit.Location = new Point(118, 335);
            btnEdit.Margin = new Padding(4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(118, 45);
            btnEdit.TabIndex = 15;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // rB_admin_Sua
            // 
            rB_admin_Sua.AutoSize = true;
            rB_admin_Sua.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rB_admin_Sua.Location = new Point(412, 272);
            rB_admin_Sua.Margin = new Padding(2);
            rB_admin_Sua.Name = "rB_admin_Sua";
            rB_admin_Sua.Size = new Size(83, 27);
            rB_admin_Sua.TabIndex = 10;
            rB_admin_Sua.Text = "admin";
            rB_admin_Sua.UseVisualStyleBackColor = true;
            rB_admin_Sua.Visible = false;
            // 
            // rB_user_Sua
            // 
            rB_user_Sua.AutoSize = true;
            rB_user_Sua.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rB_user_Sua.Location = new Point(225, 272);
            rB_user_Sua.Margin = new Padding(2);
            rB_user_Sua.Name = "rB_user_Sua";
            rB_user_Sua.Size = new Size(69, 27);
            rB_user_Sua.TabIndex = 9;
            rB_user_Sua.Text = "user";
            rB_user_Sua.UseVisualStyleBackColor = true;
            rB_user_Sua.Visible = false;
            // 
            // tB_Email_Sua
            // 
            tB_Email_Sua.Location = new Point(182, 188);
            tB_Email_Sua.Margin = new Padding(2);
            tB_Email_Sua.Name = "tB_Email_Sua";
            tB_Email_Sua.Size = new Size(388, 31);
            tB_Email_Sua.TabIndex = 8;
            tB_Email_Sua.Visible = false;
            // 
            // tB_Matkhau_Sua
            // 
            tB_Matkhau_Sua.Location = new Point(182, 118);
            tB_Matkhau_Sua.Margin = new Padding(2);
            tB_Matkhau_Sua.Name = "tB_Matkhau_Sua";
            tB_Matkhau_Sua.Size = new Size(388, 31);
            tB_Matkhau_Sua.TabIndex = 7;
            tB_Matkhau_Sua.Visible = false;
            // 
            // lb_phanquyen_Sua
            // 
            lb_phanquyen_Sua.AutoSize = true;
            lb_phanquyen_Sua.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold);
            lb_phanquyen_Sua.Location = new Point(16, 275);
            lb_phanquyen_Sua.Margin = new Padding(2, 0, 2, 0);
            lb_phanquyen_Sua.Name = "lb_phanquyen_Sua";
            lb_phanquyen_Sua.Size = new Size(108, 23);
            lb_phanquyen_Sua.TabIndex = 4;
            lb_phanquyen_Sua.Text = "Permissions";
            lb_phanquyen_Sua.Visible = false;
            // 
            // lb_email_Sua
            // 
            lb_email_Sua.AutoSize = true;
            lb_email_Sua.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold);
            lb_email_Sua.Location = new Point(18, 196);
            lb_email_Sua.Margin = new Padding(2, 0, 2, 0);
            lb_email_Sua.Name = "lb_email_Sua";
            lb_email_Sua.Size = new Size(55, 23);
            lb_email_Sua.TabIndex = 3;
            lb_email_Sua.Text = "Email";
            lb_email_Sua.Visible = false;
            // 
            // lb_Matkhau_Sua
            // 
            lb_Matkhau_Sua.AutoSize = true;
            lb_Matkhau_Sua.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold);
            lb_Matkhau_Sua.Location = new Point(16, 118);
            lb_Matkhau_Sua.Margin = new Padding(2, 0, 2, 0);
            lb_Matkhau_Sua.Name = "lb_Matkhau_Sua";
            lb_Matkhau_Sua.Size = new Size(88, 23);
            lb_Matkhau_Sua.TabIndex = 2;
            lb_Matkhau_Sua.Text = "Password";
            lb_Matkhau_Sua.Visible = false;
            // 
            // tB_Taikhoan_Sua
            // 
            tB_Taikhoan_Sua.Location = new Point(182, 45);
            tB_Taikhoan_Sua.Margin = new Padding(2);
            tB_Taikhoan_Sua.Name = "tB_Taikhoan_Sua";
            tB_Taikhoan_Sua.Size = new Size(388, 31);
            tB_Taikhoan_Sua.TabIndex = 1;
            tB_Taikhoan_Sua.KeyDown += tB_Taikhoan_Sua_Enter;
            // 
            // lb_Nhaptaikhoan_sua
            // 
            lb_Nhaptaikhoan_sua.AutoSize = true;
            lb_Nhaptaikhoan_sua.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold);
            lb_Nhaptaikhoan_sua.Location = new Point(16, 48);
            lb_Nhaptaikhoan_sua.Margin = new Padding(2, 0, 2, 0);
            lb_Nhaptaikhoan_sua.Name = "lb_Nhaptaikhoan_sua";
            lb_Nhaptaikhoan_sua.Size = new Size(78, 23);
            lb_Nhaptaikhoan_sua.TabIndex = 0;
            lb_Nhaptaikhoan_sua.Text = "Account";
            // 
            // FormQuanTriNguoiChoi
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1000, 625);
            Controls.Add(pn_Suanguoichoi);
            Controls.Add(pn_Xoa);
            Controls.Add(pn_Themnguoichoi);
            Controls.Add(pn_Giaodienchinh);
            Margin = new Padding(2);
            Name = "FormQuanTriNguoiChoi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản trị người chơi";
            Load += FormQuanTriHeThong_Load;
            ((System.ComponentModel.ISupportInitialize)dtGV_Quantritaikhoan).EndInit();
            pn_Giaodienchinh.ResumeLayout(false);
            pn_Themnguoichoi.ResumeLayout(false);
            pn_Themnguoichoi.PerformLayout();
            pn_Xoa.ResumeLayout(false);
            pn_Xoa.PerformLayout();
            pn_Suanguoichoi.ResumeLayout(false);
            pn_Suanguoichoi.PerformLayout();
            ResumeLayout(false);
        }

        #endregion


        private Button btn_Tailai;
        private Button btn_Delete;
        private Button btn_Edit;
        private Button btn_Add;
        private DataGridView dtGV_Quantritaikhoan;
        private TabControl tbC_QuanTriHeThong;
        private Panel pn_Giaodienchinh;
        private Panel pn_Themnguoichoi;
        private Button btnExit;
        private Button btnAdd;
        private RadioButton rB_admin_Them;
        private RadioButton rB_user_Them;
        private TextBox tB_Email_Them;
        private TextBox tB_Matkhau_Them;
        private TextBox tB_Taikhoan_Them;
        private Label lbPermisson;
        private Label lbEmail;
        private Label lbPassword;
        private Label lbAccount;
        private Panel pn_Suanguoichoi;
        private Label lb_phanquyen_Sua;
        private Label lb_email_Sua;
        private Label lb_Matkhau_Sua;
        private TextBox tB_Taikhoan_Sua;
        private Label lb_Nhaptaikhoan_sua;
        private RadioButton rB_admin_Sua;
        private RadioButton rB_user_Sua;
        private TextBox tB_Email_Sua;
        private TextBox tB_Matkhau_Sua;
        private Panel pn_Xoa;
        private Label lb_taikhoan_xoa;
        private TextBox tB_Taikhoan_xoa;
        private Button btnExit_frmXoa;
        private Button btnDelete;
        private Button btnExit_frmSua;
        private Button btnEdit;
        private DataGridViewTextBoxColumn column_Account;
        private DataGridViewTextBoxColumn column_Password;
        private DataGridViewTextBoxColumn column_email;
        private DataGridViewTextBoxColumn column_Access;
    }
}