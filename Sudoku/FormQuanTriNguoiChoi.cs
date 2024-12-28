using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity.Injection;

namespace Sudoku
{
    public partial class FormQuanTriNguoiChoi : Form
    {
        private string strConnection = "server=127.0.0.1,port=3306;uid=root;pwd=phatbaoan112;database=sudoku";
        public FormQuanTriNguoiChoi()
        {
            InitializeComponent();
        }

        private void FormQuanTriHeThong_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Tailai_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {

            using (MySql.Data.MySqlClient.MySqlConnection connection = new MySql.Data.MySqlClient.MySqlConnection(strConnection))
            {
                try
                {
                    connection.Open();
                    string Query = "select taikhoan as column_Taikhoan, matkhau as column_Matkhau, email as column_email, access as column_phanquyen from nguoichoi";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(Query, strConnection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dtGV_Quantritaikhoan.Columns["column_Taikhoan"].DataPropertyName = "column_Taikhoan";
                    dtGV_Quantritaikhoan.Columns["column_Matkhau"].DataPropertyName = "column_Matkhau";
                    dtGV_Quantritaikhoan.Columns["column_email"].DataPropertyName = "column_email";
                    dtGV_Quantritaikhoan.Columns["column_phanquyen"].DataPropertyName = "column_phanquyen";
                    this.dtGV_Quantritaikhoan.AutoGenerateColumns = true;

                    this.dtGV_Quantritaikhoan.DataSource = dataTable;
                    connection.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            pn_Giaodienchinh.Visible = true;
            pn_Themnguoichoi.Visible = false;
        }
        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dtGV_Quantritaikhoan.RowHeadersDefaultCellStyle.ForeColor))
            {
                string rowNumber = (e.RowIndex + 1).ToString(); // Số thứ tự
                e.Graphics.DrawString(rowNumber,
                    dtGV_Quantritaikhoan.DefaultCellStyle.Font,
                    b,
                    e.RowBounds.Location.X + 15, // Vị trí X
                    e.RowBounds.Location.Y + 4); // Vị trí Y
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            pn_Giaodienchinh.Visible = false;
            pn_Themnguoichoi.Visible = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool Them = true;

            string taikhoan = tB_Taikhoan_Them.Text;
            string matkhau = tB_Matkhau_Them.Text;
            string email = tB_Email_Them.Text;
            string access = rB_admin_Them.Checked ? rB_admin_Them.Text : rB_user_Them.Text;
            string Check = $"Select * from nguoichoi where taikhoan ='{taikhoan}' or email = '{email}'";
            string Insert = $"Insert into nguoichoi(taikhoan,matkhau,email,access) values('{taikhoan}','{matkhau}','{email}','{access}')";
            if (taikhoan == "" || email == "")
            {
                MessageBox.Show("Không được để tài khoản hoặc email rỗng !", "Thông báo", MessageBoxButtons.OKCancel);
            }
            else
                using (MySqlConnection connection = new MySqlConnection(strConnection))
                {
                    try
                    {
                        connection.Open();
                        MySqlCommand Kiemtra = new MySqlCommand(Check, connection);
                        using (MySqlDataReader read = Kiemtra.ExecuteReader())
                        {
                            if (read.HasRows)
                            {
                                MessageBox.Show("Tài khoản hoặc email đã tồn tại!", "Thông báo", MessageBoxButtons.OKCancel);
                                Them = false;
                            }
                            else Them = true;
                            read.Close();
                        }
                        if (Them == true)
                        {
                            MySqlCommand Them_nguoichoi = new MySqlCommand(Insert, connection);
                            int row = Them_nguoichoi.ExecuteNonQuery();
                            MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OKCancel);
                        }


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
        }

        private void pn_Themnguoichoi_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            pn_Giaodienchinh.Visible = false;
            pn_Themnguoichoi.Visible = false;
            pn_Suanguoichoi.Visible = true;
            pn_Xoa.Visible = false;

        }

        private void btn_Thoat_Sua_Click(object sender, EventArgs e)
        {
            pn_Suanguoichoi.Visible = false;
            tB_Taikhoan_Sua.Text = "";
            tB_Email_Sua.Text = "";
            tB_Matkhau_Sua.Text = "";
            rB_admin_Sua.Checked = false;
            rB_user_Sua.Checked = false;
            tB_Email_Sua.Visible = false;
            tB_Matkhau_Sua.Visible = false;
            lb_email_Sua.Visible = false;
            lb_Matkhau_Sua.Visible = false;
            lb_phanquyen_Sua.Visible = false;
            rB_admin_Sua.Visible = false;
            rB_user_Sua.Visible = false;

        }
        private void tB_Taikhoan_Sua_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                string taikhoan = tB_Taikhoan_Sua.Text;

                string Check = $"Select * from nguoichoi where taikhoan ='{taikhoan}'";
                using (MySqlConnection connection = new MySqlConnection(strConnection))
                {
                    try
                    {
                        connection.Open();
                        MySqlCommand mySqlCommand = new MySqlCommand(Check, connection);
                        using (MySqlDataReader read = mySqlCommand.ExecuteReader())
                        {
                            if (read.HasRows)
                            {
                                read.Read();
                                tB_Email_Sua.Text = read["email"].ToString();
                                tB_Matkhau_Sua.Text = read["matkhau"].ToString();
                                string access = read["access"].ToString();
                                if (access == "user")
                                {
                                    rB_user_Sua.Checked = true;
                                }
                                else rB_admin_Sua.Checked = true;
                                tB_Email_Sua.Visible = true;
                                tB_Matkhau_Sua.Visible = true;
                                lb_email_Sua.Visible = true;
                                lb_Matkhau_Sua.Visible = true;
                                lb_phanquyen_Sua.Visible = true;
                                rB_admin_Sua.Visible = true;
                                rB_user_Sua.Visible = true;
                                read.Close();

                            }
                            else MessageBox.Show("Tài khoản không tồn tại!", "Thông báo", MessageBoxButtons.OKCancel);

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

        }

        private void btn_Thaydoi_Click(object sender, EventArgs e)
        {

            string taikhoan = tB_Taikhoan_Sua.Text;
            string matkhau = tB_Matkhau_Sua.Text;
            string email = tB_Email_Sua.Text;
            string access = rB_admin_Sua.Checked ? rB_admin_Sua.Text : rB_user_Sua.Text;
            string Check = $"Update nguoichoi set matkhau ='{matkhau}',email ='{email}',access ='{access}'  where taikhoan ='{taikhoan}'";
            using (MySqlConnection connection = new MySqlConnection(strConnection))
            {
                try
                {
                    connection.Open();
                    MySqlCommand mySqlCommand = new MySqlCommand(Check, connection);
                    int row = mySqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OKCancel);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            pn_Giaodienchinh.Visible = false;
            pn_Themnguoichoi.Visible = false;
            pn_Suanguoichoi.Visible = false;
            pn_Xoa.Visible = true;

        }


        private void pn_Suanguoichoi_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string taikhoan = tB_Taikhoan_xoa.Text;

            string Check = $"Delete from nguoichoi  where taikhoan ='{taikhoan}'";
            using (MySqlConnection connection = new MySqlConnection(strConnection))
            {
                try
                {
                    connection.Open();
                    MySqlCommand mySqlCommand = new MySqlCommand(Check, connection);
                    int row = mySqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Xóa người chơi thành công!");
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnExit_frmXoa_Click(object sender, EventArgs e)
        {
            pn_Xoa.Visible = false;
            tB_Taikhoan_xoa.Text = "";
            pn_Giaodienchinh.Visible = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string taikhoan = tB_Taikhoan_Sua.Text;
            string matkhau = tB_Matkhau_Sua.Text;
            string email = tB_Email_Sua.Text;
            string access = rB_admin_Sua.Checked ? rB_admin_Sua.Text : rB_user_Sua.Text;
            string Check = $"Update nguoichoi set matkhau ='{matkhau}',email ='{email}',access ='{access}'  where taikhoan ='{taikhoan}'";
            using (MySqlConnection connection = new MySqlConnection(strConnection))
            {
                try
                {
                    connection.Open();
                    MySqlCommand mySqlCommand = new MySqlCommand(Check, connection);
                    int row = mySqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OKCancel);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnExit_frmSua_Click(object sender, EventArgs e)
        {
            pn_Suanguoichoi.Visible = false;
            tB_Taikhoan_Sua.Text = "";
            tB_Email_Sua.Text = "";
            tB_Matkhau_Sua.Text = "";
            rB_admin_Sua.Checked = false;
            rB_user_Sua.Checked = false;
            tB_Email_Sua.Visible = false;
            tB_Matkhau_Sua.Visible = false;
            lb_email_Sua.Visible = false;
            lb_Matkhau_Sua.Visible = false;
            lb_phanquyen_Sua.Visible = false;
            rB_admin_Sua.Visible = false;
            rB_user_Sua.Visible = false;
            pn_Giaodienchinh.Visible = true;
        }
    }
}
