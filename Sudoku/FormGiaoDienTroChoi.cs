using QUANLYTRANGTHAIGAME;
using Sudoku1;
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
    public partial class FormGiaoDienTroChoi : Form
    {
        Nguoichoi nguoichoi;
        public FormGiaoDienTroChoi(Nguoichoi player)
        {
            InitializeComponent();
            nguoichoi = player;
        }

        private void btn_Choi_Click(object sender, EventArgs e)
        {
            btn_Choi.Visible = false;
            btn_Choitiep.Visible = false;
            btn_Bangxephang.Visible = false;
            btn_Choilaivancu.Visible = false;
            btn_Thongke.Visible = false;
            btn_Thoat.Visible = false;
            lb_Chedochoi.Visible = true;
            btn_De.Visible = true;
            btn_Kho.Visible = true;
            btn_TrungBinh.Visible = true;
            btn_Quaylai.Visible = true;
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Bangxephang_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormXepHang newform = new FormXepHang();
            newform.ShowDialog();
            this.Show();
        }

        private void btn_Thongke_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormThongKe newform = new FormThongKe();
            newform.ShowDialog();
            this.Show();
        }

        private void btn_Choilaivancu_Click(object sender, EventArgs e)
        {
            this.Hide();
            TaiLaiTrangthai newform = new TaiLaiTrangthai();
            newform.ShowDialog();
            this.Show();
        }

        private void btn_Quaylai_Click(object sender, EventArgs e)
        {
            btn_Choi.Visible = true;
            btn_Choitiep.Visible = true;
            btn_Bangxephang.Visible = true;
            btn_Choilaivancu.Visible = true;
            btn_Thongke.Visible = true;
            btn_Thoat.Visible = true;
            lb_Chedochoi.Visible = false;
            btn_De.Visible = false;
            btn_Kho.Visible = false;
            btn_TrungBinh.Visible = false;
            btn_Quaylai.Visible = false;

        }

        private void btn_De_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSudoKuDe newform = new FormSudoKuDe();
            newform.ShowDialog();
            this.Show();
        }

        private void btn_TrungBinh_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSudoKuTrungBinh newform = new FormSudoKuTrungBinh();
            newform.ShowDialog();
            this.Show();
        }

        private void btn_Kho_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSudoKuKho newform = new FormSudoKuKho();
            newform.ShowDialog();
            this.Show();
        }

        private void btn_Choitiep_Click(object sender, EventArgs e)
        {
            
        }
    }
}
