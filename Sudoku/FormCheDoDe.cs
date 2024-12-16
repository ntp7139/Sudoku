using QUANLYTRANGTHAIGAME;
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
    public partial class FormCheDoDe : Form
    {
        public FormCheDoDe()
        {
            InitializeComponent();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            LuuTrangthai newform = new LuuTrangthai();
            newform.ShowDialog();
        }

        private void btn_TamDung_Click(object sender, EventArgs e)
        {
            TamDunghoacTieptuc newform = new TamDunghoacTieptuc();
            newform.ShowDialog();
        }

        private void btn_ChoiLai_Click(object sender, EventArgs e)
        {
            ChoiLaiVancu newform = new ChoiLaiVancu();
            newform.ShowDialog();
        }

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
