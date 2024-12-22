using Org.BouncyCastle.Tls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    
    // Nguoichoi chứa thông tin người chơi game gồm ID, quyền truy cập, số game đã chơi,
    // số game thắng, tổng thời gian chơi, và mã id game đang chơi hiện tại
    public class Nguoichoi
    {
            public string taikhoan = "0";
            public string access = "user";
            public string game_played ;
            public string game_won ;
            public string time_played;
            public string current_game_id = "0";
        //Phương thức trả về thông tin người chơi khi nhập tài khoản ( tài khoản  = id )
        public void Save_ID()
        {
            Connection Check = new Connection();
            if (!Check.Check_ID_Player(taikhoan))
            {
                MessageBox.Show("Không tồn tại người chơi!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            } else
            {
                string query = $"Update nguoichoi set current_game_id = '{current_game_id}' where taikhoan ='{taikhoan}'";
                Check.ExcuteNonQuery(query);
            }
        }
        public void Save()
        {

        }
        public bool Load_Player(string ID_Player)
        {
            Connection Check = new Connection();
            if (!Check.Check_ID_Player(ID_Player))
            {
                return false;
            }
            else
            {
                string query = $"Select * from nguoichoi where taikhoan = '{ID_Player}'";
                DataTable Thongtin = new DataTable();
                Connection Load_Thongtin = new Connection();
                Thongtin = Load_Thongtin.ExcuteQuery(query);
                if (Thongtin != null)
                {
                    DataRow FirstColumn = Thongtin.Rows[0];
                    this.taikhoan = (string)FirstColumn["taikhoan"];
                    this.access = (string)FirstColumn["access"];
                    this.game_won = (string)FirstColumn["game_won"];
                    this.game_played = (string)FirstColumn["game_played"];
                    this.time_played = (string)FirstColumn["time_played"];
                    this.current_game_id = (string)FirstColumn["current_game_id"];

                }
            }
            return true;
        }
        public override string ToString()
        {
            string s = "";
            s += taikhoan + access + game_played.ToString() + game_won.ToString() + current_game_id + time_played.ToString();
            return s;
        }
    }
    public class LichSuDau
    {
           public string taikhoan;
           public  string game_id;
           public string game_status;
            public string time;
            public string score;
           
           public string Current_Sudoku;
           public string Default_Sudoku;
           public string Key_Sudoku;
        public string Check_Loi;
        public string Check_Diem;
        public string Che_Do;
       //Lưu thông tin trận đấu về cơ sở dữ liệu.
        public void Save()
        {
            
            Connection Check = new Connection();
            if (!Check.Check_ID_Sudoku(game_id))
            {
                string query = $"Insert into lichsudau values('{taikhoan}','{game_id}','{game_status}','{time}'," +
                    $"'{score}','{Current_Sudoku}','{Default_Sudoku}','{Key_Sudoku}','{Check_Loi}','{Check_Diem}','{Che_Do}')";
                Check.ExcuteNonQuery(query);
            } else
            {
                string query_1 = "";
            }
        }
        public bool Load_LSD()
        {
            Connection Check = new Connection();
            if (!Check.Check_ID_Sudoku(game_id))
            {
                return false;
            }
            else
            {
                string query = $"Select * from lichsudau where game_id = '{game_id}'";
                DataTable Thongtin = new DataTable();
                Connection Load_Thongtin = new Connection();
                Thongtin = Load_Thongtin.ExcuteQuery(query);
                if (Thongtin != null)
                {
                    DataRow FirstColumn = Thongtin.Rows[0];
                    this.taikhoan = (string)FirstColumn["taikhoan"];
                    this.game_id = (string)FirstColumn["game_id"];
                    this.game_status = (string)FirstColumn["game_status"];
                    this.score = (string)FirstColumn["score"];
                    this.time = (string)FirstColumn["time"];
                    this.Current_Sudoku = (string)FirstColumn["Current_Sudoku"];
                    this.Default_Sudoku = (string)FirstColumn["Default_Sudoku"];
                    this.Key_Sudoku = (string)FirstColumn["Key_Sudoku"];
                    this.Check_Diem = (string)FirstColumn["Check_Diem"];
                    this.Check_Loi = (string)FirstColumn["Check_Loi"];

                }
            }
            return true;
        }
        public string Set_up_ID_game() 
        {
            int id;
           
            string query = "Select COUNT(*) from lichsudau";
            Connection Count = new Connection();
            id = Count.ExcuteScalar(query);
            id++;
            return id.ToString();
         }
    }
    
}
