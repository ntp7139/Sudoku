using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku1
{
    
    public class Nguoichoi
    {
        public string taikhoan;
        public string access;
        public string score;
        
        public int game_played;
        public int game_won;
        public int time_played;
        public int current_game_id;
        //Phương thức trả về thông tin người chơi khi nhập tài khoản ( tài khoản  = id )
        public Nguoichoi() { }
        public void testc() { }

    }
    public class LichSuDau
    {
       public string taikhoan;
       public  string game_id;
       public  string bang_sudoku;
       public int time;
        public int score;
       public string status;
    }

}
