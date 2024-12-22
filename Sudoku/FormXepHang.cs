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
            panel1.Visible = false;
            string query = "select A.taikhoan,A.max_score,lichsudau.time,lichsudau.game_status\r\nfrom (Select taikhoan,Max(cast(score as unsigned))as max_score from lichsudau group by taikhoan ) as A\r\n\tleft join lichsudau\r\non A.max_score = lichsudau.score\r\n";

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
