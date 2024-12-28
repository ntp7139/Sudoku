using System;

using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sudoku
{
    public partial class FormXepHang : Form
    {
        

        public FormXepHang()
        {
            InitializeComponent();
            dataGridView1.RowPostPaint += dataGridView1_RowPostPaint;
            string query = "Select taikhoan as ACCOUNT, game_id as ID, score as SCORE, time as TIME from lichsudau\r\norder by Cast(score as unsigned) desc\r\nlimit 10;";
            Connection Check = new Connection();
            DataTable dataTable = new DataTable();

            dataTable = Check.ExcuteQuery(query);


            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dataTable;


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

        private void button1_Click(object sender, EventArgs e)
        {
            //panel1.Visible = false;
            string query = "Select score as SCORE,taikhoan as ID,game_id as GAME_ID,time as TIME from lichsudau\r\norder by Cast(score as unsigned) desc\r\nlimit 10;";
           Connection Check = new Connection();
            DataTable dataTable = new DataTable();
            
            dataTable = Check.ExcuteQuery(query);
            
           
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dataTable;
           

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
