using Org.BouncyCastle.Tls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku1
{
    
    // Nguoichoi chứa thông tin người chơi game gồm ID, quyền truy cập, số game đã chơi,
    // số game thắng, tổng thời gian chơi, và mã id game đang chơi hiện tại
    public class Nguoichoi
    {
        public string taikhoan;
        public string access;
        public int game_played;
        public int game_won;
        public int time_played;
        public int current_game_id;
        //Phương thức trả về thông tin người chơi khi nhập tài khoản ( tài khoản  = id )
    }
    public class LichSuDau
    {
       public string taikhoan;
       public  string game_id;
       public string game_status;
       public int score;
       public int time;
       
    }
    
}
