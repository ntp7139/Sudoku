using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace Sudoku
{
    public partial class FormDangKy : Form
    {
        public FormDangKy()
        {
            InitializeComponent();
        }

        private void btn_QuayLai_DangKy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {

            string strConnection = "server=127.0.0.1;uid=root;pwd=phatbaoan112;database=sudoku";
            using (MySql.Data.MySqlClient.MySqlConnection connection = new MySql.Data.MySqlClient.MySqlConnection(strConnection))
            {
                try
                {
                    connection.Open();
                    string taikhoan = tb_TaiKhoan_DangKy.Text;
                    string matkhau = tb_MatKhau_DangKy.Text;
                    string nhaplaimatkhau = tb_NhapLaiMatKhau.Text;
                    string email = tb_Email_DangKy.Text;
                    string Check_taikhoan = $"Select * from nguoichoi where taikhoan ='{taikhoan}'";
                    MySqlCommand kiemtra = new MySqlCommand(Check_taikhoan, connection);
                    MySqlDataReader kiemtra_taikhoan = kiemtra.ExecuteReader();

                    if (kiemtra_taikhoan.HasRows)
                    {
                        MessageBox.Show("Tai khoan da ton tai!");
                        kiemtra_taikhoan.Close();

                    }
                    else
                    {
                        kiemtra_taikhoan.Close();
                        string Check_email = $"Select * from nguoichoi where email ='{email}'";
                        MySqlCommand kiemtra1 = new MySqlCommand(Check_email, connection);
                        MySqlDataReader kiemtra_email = kiemtra1.ExecuteReader();
                        if (kiemtra_email.HasRows)
                        {
                            MessageBox.Show("Email da ton tai");
                            kiemtra_email.Close();
                        }
                        else if (matkhau != nhaplaimatkhau)
                        {
                            MessageBox.Show("Mat khau không trùng hợp!");
                        }
                        else
                        {
                            kiemtra_email.Close();

                            string insert = $"insert into nguoichoi values('{taikhoan}','{matkhau}','{email}')";
                            MySqlCommand mySqlCommand = new MySqlCommand(insert, connection);
                            try
                            {
                                int row = mySqlCommand.ExecuteNonQuery();
                                MessageBox.Show("Dang ky thanh cong!");
                                this.Close();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void FormDangKy_Load(object sender, EventArgs e)
        {

        }

        private void tb_Email_DangKy_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
