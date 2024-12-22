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
    public partial class FormDoimatkhau : Form
    {
        public FormDoimatkhau()
        {
            InitializeComponent();
        }

        private void btn_QuayLai_DangKy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pn_DangKy_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox_QuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lb_TieuDeDoiMatKhau_Click(object sender, EventArgs e)
        {

        }
    }
}
