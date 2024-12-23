
using Org.BouncyCastle.Math.Field;
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
        Nguoichoi nguoichoi = new Nguoichoi();
        public FormGiaoDienTroChoi(string player_ID)
        {
            nguoichoi.taikhoan = player_ID;
            nguoichoi.Load_Player(player_ID);
            InitializeComponent();

        }

        private void btn_Choi_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            btn_ThongTinNguoiCHoi.Visible = false;
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
            TaiLaiTrangthai newform = new TaiLaiTrangthai(nguoichoi.taikhoan);
            newform.ShowDialog();
            this.Show();
        }

        private void btn_Quaylai_Click(object sender, EventArgs e)
        {
            btn_ThongTinNguoiCHoi.Visible = true;
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
            button1.Visible = true;

        }

        private void btn_De_Click(object sender, EventArgs e)
        {
            this.Hide();
            nguoichoi.Load_Player(nguoichoi.taikhoan);
            FormSudoKuDe newform = new FormSudoKuDe(nguoichoi.taikhoan);
            newform.ShowDialog();
            this.Show();
        }

        private void btn_TrungBinh_Click(object sender, EventArgs e)
        {
            this.Hide();
            nguoichoi.Load_Player(nguoichoi.taikhoan);
            FormSudoKuTrungBinh newform = new FormSudoKuTrungBinh(nguoichoi.taikhoan);
            newform.ShowDialog();
            this.Show();
        }

        private void btn_Kho_Click(object sender, EventArgs e)
        {
            this.Hide();
            nguoichoi.Load_Player(nguoichoi.taikhoan);
            FormSudoKuKho newform = new FormSudoKuKho(nguoichoi.taikhoan);
            newform.ShowDialog();
            this.Show();
        }

        private void btn_Choitiep_Click(object sender, EventArgs e)
        {
            this.Hide();
            try
            {
                nguoichoi.Load_Player(nguoichoi.taikhoan);
                LichSuDau check = new LichSuDau();
                check.game_id = nguoichoi.current_game_id;
                check.Load_LSD();

                if (check.Che_Do == "Easy")
                {
                    FormSudoKuDe newform = new FormSudoKuDe(nguoichoi.taikhoan, nguoichoi.current_game_id);
                    newform.ShowDialog();
                    this.Show();
                }
                else if (check.Che_Do == "Medium")
                {
                    FormSudoKuTrungBinh newform = new FormSudoKuTrungBinh(nguoichoi.taikhoan, nguoichoi.current_game_id);
                    newform.ShowDialog();
                    this.Show();
                }
                else if (check.Che_Do == "Hard")
                {
                    FormSudoKuKho newform = new FormSudoKuKho(nguoichoi.taikhoan, nguoichoi.current_game_id);
                    newform.ShowDialog();
                    this.Show();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_ThongTinNguoiCHoi_Click(object sender, EventArgs e)
        {
            this.Hide();
            nguoichoi.Load_Player(nguoichoi.taikhoan);
            FormThongTinNguoiChoi Form_Player = new FormThongTinNguoiChoi(nguoichoi.taikhoan);
            Form_Player.ShowDialog();
            this.Show();
        }

        private void pn_GiaoDien_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
