using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace Sudoku
{
    public partial class FormDangNhap : Form
    {
        public Nguoichoi nguoichoi = new Nguoichoi();
        public LichSuDau lichsudau = new LichSuDau();
        private string strConnection = "server=127.0.0.1;uid=root;pwd=phatbaoan112;database=sudoku";
        public void Test()
        {

        }
        public FormDangNhap()
        {
            InitializeComponent();
            
        }

        private void lb_QuenMatKhau_Click(object sender, EventArgs e)
        {
          
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void lb_Email_DangKy_Click(object sender, EventArgs e)
        {

        }

        private void lb_DangKy_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDangKy newform = new FormDangKy();
            newform.ShowDialog();
            this.Show();
        }


        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (tB_TaiKhoan.Text == "admin" && tB_MatKhau.Text == "admin")
            {
                this.Hide();
                FormAdmin newform = new FormAdmin("admin");
                newform.ShowDialog();
                this.Show();
            }
            else
            {

                using (MySql.Data.MySqlClient.MySqlConnection connection = new MySql.Data.MySqlClient.MySqlConnection(strConnection))
                {
                    try
                    {
                        connection.Open();
                        string matkhau = tB_MatKhau.Text;
                        string taikhoan = tB_TaiKhoan.Text;
                        string Check = $"select * from nguoichoi where taikhoan = '{taikhoan}' and matkhau ='{matkhau}'";
                        MySqlCommand mySqlCommand = new MySqlCommand(Check, connection);
                        using (MySqlDataReader read = mySqlCommand.ExecuteReader())
                        {
                            if (read.HasRows)
                            {
                                read.Read();
                                string useraccess = read["access"]?.ToString();
                                if (useraccess == "admin")
                                {
                                    this.Hide();
                                    FormQuanTriNguoiChoi newform = new FormQuanTriNguoiChoi();

                                    newform.ShowDialog();
                                    this.Show();
                                }
                                this.Hide();
                                FormGiaoDienTroChoi form1 = new FormGiaoDienTroChoi(taikhoan);
                                form1.ShowDialog();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Sai thong tin dang nhap! ");
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }


        }

        private void pn_DangNhap_Paint(object sender, PaintEventArgs e)
        {

        }
        public void FormDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void lbChangePassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            btnUpdatePassword newform = new btnUpdatePassword();
            newform.ShowDialog();
            this.Show();
        }

        private void lb_TieuDe_Click(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDangKy newform = new FormDangKy();
            newform.ShowDialog();
            this.Show();
        }

        private void lbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }

}
