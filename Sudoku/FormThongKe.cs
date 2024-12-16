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

namespace Sudoku
{
    public partial class FormThongKe : Form
    {
        string constr;
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataAdapter adt;

        public FormThongKe()
        {
            InitializeComponent();
            adt = new MySqlDataAdapter(); // Khởi tạo mặc định
            cmd = new MySqlCommand(); // Khởi tạo mặc định
            constr = "server=127.0.0.1; Database = sudoku; Uid=root; Pwd=phatbaoan112;";
            con = new MySqlConnection(constr);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lbLichSuNguoiChoi_Click(object sender, EventArgs e)
        {

        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTruyNhap_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtTen.Text;
                string id = txtID.Text;
                
                string query = $"SELECT * FROM nguoichoi WHERE taikhoan = '{name}'";
                MySqlDataAdapter newadt = new MySqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                newadt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
