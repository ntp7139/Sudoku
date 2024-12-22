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
    public partial class FormThongTinNguoiChoi : Form
    {
        Nguoichoi current_player = new Nguoichoi();
        public FormThongTinNguoiChoi(string player_ID)
        {
            current_player.taikhoan = (string)player_ID;
            current_player.Load_Player(player_ID);
            InitializeComponent();
            Load_Data();

        }
        public void Load_Data()
        {
            tB_taikhoan.Text = current_player.taikhoan;
            tB_QuyenTruyCap.Text = current_player.access;
            tB_game_played.Text = current_player.game_played;
            tB_Game_won.Text = current_player.game_won;
            tB_time_played.Text = current_player.time_played;
            tB_game_id_current.Text = current_player.current_game_id;
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            current_player.Load_Player(current_player.taikhoan);
            Load_Data();
        }
    }
}
