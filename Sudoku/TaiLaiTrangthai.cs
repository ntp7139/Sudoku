using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Sudoku
{
    public partial class TaiLaiTrangthai : Form
    {
        Nguoichoi player = new Nguoichoi();
        public TaiLaiTrangthai(string ID_Player)
        {
            InitializeComponent();
            dtgLuuTrangThaiVanCu.RowPostPaint += dataGridView1_RowPostPaint;
            player.Load_Player(ID_Player);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgLuuTrangThaiVanCu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            string query = $"SELECT taikhoan,game_id,score,time,che_do FROM lichsudau WHERE taikhoan = '{player.taikhoan}';";
            Connection Check = new Connection();
            DataTable dt = Check.ExcuteQuery(query);
            dtgLuuTrangThaiVanCu.DataSource = dt;
            dtgLuuTrangThaiVanCu.AutoGenerateColumns = true;
        }
        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dtgLuuTrangThaiVanCu.RowHeadersDefaultCellStyle.ForeColor))
            {
                string rowNumber = (e.RowIndex).ToString(); // Số thứ tự
                e.Graphics.DrawString(rowNumber,
                    dtgLuuTrangThaiVanCu.DefaultCellStyle.Font,
                    b,
                    e.RowBounds.Location.X + 15, // Vị trí X
                    e.RowBounds.Location.Y + 4); // Vị trí Y
            }
        }

        private void dtgLuuTrangThaiVanCu_MouseClick(object sender, MouseEventArgs e)
        {
            // Lấy thông tin vị trí của con trỏ chuột
            var hit = dtgLuuTrangThaiVanCu.HitTest(e.X, e.Y);

            // Kiểm tra xem có nhấn vào một hàng hợp lệ không
            if (hit.RowIndex >= 0)
            {
                int rowIndex = hit.RowIndex; // Index của hàng
                string player_id = (string)dtgLuuTrangThaiVanCu.Rows[rowIndex].Cells[0].Value;
                string game_id = (string)dtgLuuTrangThaiVanCu.Rows[rowIndex].Cells[1].Value;
                this.Hide();
                FormSudoKuDe newform = new FormSudoKuDe(player_id,game_id);
                newform.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Bạn không nhấn vào hàng nào.");
            }
        }

    }
}
