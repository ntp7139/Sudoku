
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
        public FormAdmin(string ID_player)
        {
            Admin.taikhoan = ID_player;
            InitializeComponent();


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPlayerManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormQuanTriNguoiChoi newform = new FormQuanTriNguoiChoi();
            newform.ShowDialog();
            this.Show();
        }

        private void btnPlayGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormGiaoDienTroChoi newform = new FormGiaoDienTroChoi(Admin.taikhoan);
            newform.ShowDialog();
            this.Show();

        }

        private void btnLevelManagement_Click(object sender, EventArgs e)
        {
            

        }
    }
}
