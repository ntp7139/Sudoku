using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using Sudoku1;
namespace Sudoku
{
    public partial class FormDangNhap : Form
    {
        private Nguoichoi nguoichoi { get; set; }
        private LichSuDau lichsudau { get; set; }
        private string strConnection;
        public FormDangNhap(string Con)
        {
            InitializeComponent();
            strConnection = Con;
        }

        private void lb_QuenMatKhau_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormQuenMatKhau newform = new FormQuenMatKhau();
            newform.ShowDialog();

            this.Show();

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


        private void btn_DongY_Click(object sender, EventArgs e)
        {   if (tB_TaiKhoan.Text == "admin" && tB_MatKhau.Text == "admin")
            {
                this.Hide();
                FormAdmin newform = new FormAdmin(strConnection,nguoichoi);
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
                                if(useraccess ==  "admin")
                                {
                                    this.Hide();
                                    FormQuanTriNguoiChoi newform = new FormQuanTriNguoiChoi();
                                    
                                    newform.ShowDialog();
                                    this.Show();
                                }
                                this.Hide();
                                FormGiaoDienTroChoi form1 = new FormGiaoDienTroChoi(nguoichoi);
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

        private void lbDoimatkhau_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDoimatkhau newform = new FormDoimatkhau();
            newform.ShowDialog();
            this.Show();
        }
    }

}
