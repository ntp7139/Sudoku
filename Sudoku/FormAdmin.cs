
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
    public partial class FormAdmin : Form
    {
        Nguoichoi Admin = new Nguoichoi();
        public FormAdmin(string  ID_player)
        {
            Admin.taikhoan = ID_player;
            InitializeComponent();
            
           
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Quantringuoichoi_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormQuanTriNguoiChoi newform = new FormQuanTriNguoiChoi();
            newform.ShowDialog();
            this.Show();
        }

        private void btn_Choitrochoi_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormGiaoDienTroChoi newform = new FormGiaoDienTroChoi(Admin.taikhoan );
            newform.ShowDialog();
            this.Show();

        }
    }
}
