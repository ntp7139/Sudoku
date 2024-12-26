
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

        private void btnPlayNewGame_Click(object sender, EventArgs e)
        {
            btnHowToPlay.Visible = false;
            btnPlayerProfile.Visible = false;
            btnPlayNewGame.Visible = false;
            btnContiue.Visible = false;
            btnLeaderboard.Visible = false;
            btnReplay.Visible = false;
            btnSatistics.Visible = false;
            btnExit.Visible = false;
            lbLevel.Visible = true;
            btnEasy.Visible = true;
            btnHard.Visible = true;
            btnNormal.Visible = true;
            btn_Quaylai.Visible = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLeaderboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormXepHang newform = new FormXepHang();
            newform.ShowDialog();
            this.Show();
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormThongKe newform = new FormThongKe();
            newform.ShowDialog();
            this.Show();
        }

        private void btnReplay_Click(object sender, EventArgs e)
        {
            this.Hide();
            TaiLaiTrangthai newform = new TaiLaiTrangthai(nguoichoi.taikhoan);
            newform.ShowDialog();
            this.Show();
        }

        private void btn_Quaylai_Click(object sender, EventArgs e)
        {
            btnPlayerProfile.Visible = true;
            btnPlayNewGame.Visible = true;
            btnContiue.Visible = true;
            btnLeaderboard.Visible = true;
            btnReplay.Visible = true;
            btnSatistics.Visible = true;
            btnExit.Visible = true;
            lbLevel.Visible = false;
            btnEasy.Visible = false;
            btnHard.Visible = false;
            btnNormal.Visible = false;
            btn_Quaylai.Visible = false;
            btnHowToPlay.Visible = true;

        }

        private void btnEasy_Click(object sender, EventArgs e)
        {
            this.Hide();
            nguoichoi.Load_Player(nguoichoi.taikhoan);
            FormSudoKuDe newform = new FormSudoKuDe(nguoichoi.taikhoan);
            newform.ShowDialog();
            this.Show();
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            this.Hide();
            nguoichoi.Load_Player(nguoichoi.taikhoan);
            FormSudoKuTrungBinh newform = new FormSudoKuTrungBinh(nguoichoi.taikhoan);
            newform.ShowDialog();
            this.Show();
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            this.Hide();
            nguoichoi.Load_Player(nguoichoi.taikhoan);
            FormSudoKuKho newform = new FormSudoKuKho(nguoichoi.taikhoan);
            newform.ShowDialog();
            this.Show();
        }

        private void btnContiue_Click(object sender, EventArgs e)
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

        private void btnPlayerProfile_Click(object sender, EventArgs e)
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

        private void btnHowToPlay_Click(object sender, EventArgs e)
        {

        }
    }
}
