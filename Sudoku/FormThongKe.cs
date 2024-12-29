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
            constr = "server=phatchison-phatbaoan112-1d4a.d.aivencloud.com;port = 28938;uid=avnadmin;pwd=AVNS_UF7t0kMFhSmIyxPG8M5;database=defaultdb";
            con = new MySqlConnection(constr);
            dataGridView1.RowPostPaint += dataGridView1_RowPostPaint;
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
               

                string query = $"SELECT taikhoan as Account,game_id as ID,score as Score,time as Time FROM lichsudau WHERE taikhoan = '{name}';";
                con.Open();
                MySqlCommand command = new MySqlCommand(query, con);
                MySqlDataReader read = command.ExecuteReader();
                if (read.HasRows)
                {
                    read.Close();
                    MySqlDataAdapter newadt = new MySqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    newadt.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Không có thông tin người chơi !");
                    read.Close();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {

        }

        private void lbTen_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            try
            {
                pb.Visible = false;
                string name = txtTen.Text;
     
                
                string query = $"SELECT taikhoan as Account,game_id as ID,score as Score,time as Time FROM lichsudau WHERE taikhoan = '{name}';";
                con.Open();
                MySqlCommand command = new MySqlCommand(query, con);
                MySqlDataReader read = command.ExecuteReader();
                if (read.HasRows)
                {
                    read.Close();
                    MySqlDataAdapter newadt = new MySqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    newadt.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Không có thông tin người chơi !");
                    read.Close();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pb_Click(object sender, EventArgs e)
        {

        }
        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dataGridView1.RowHeadersDefaultCellStyle.ForeColor))
            {
                string rowNumber = (e.RowIndex + 1).ToString(); // Số thứ tự
                e.Graphics.DrawString(rowNumber,
                    dataGridView1.DefaultCellStyle.Font,
                    b,
                    e.RowBounds.Location.X + 15, // Vị trí X
                    e.RowBounds.Location.Y + 4); // Vị trí Y
            }
        }
    }
}