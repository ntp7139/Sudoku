using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Sudoku
{
    internal class Connection
    {
        //Connection tới  server 
        private string connection = "server=127.0.0.1;uid=root;pwd=phatbaoan112;database=sudoku";
        //Kết nối tới MySQL sever
        public MySqlConnection MySqlConnection(string connect)
        {
            MySqlConnection conn = new MySqlConnection(connect);
            return conn;
        }
        // Thực hiện truy vấn tra về select
        public DataTable ExcuteQuery(string query)
        {
            DataTable dt = new DataTable();
            MySqlConnection Connect = MySqlConnection(connection);
            try
            {
                Connect.Open();
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query,Connect))
                { 
                    adapter.Fill(dt);

                }
                Connect.Close();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }
        // Thực hiện các câu lệnh non-Query (Insert, Update, Delete)
        public void ExcuteNonQuery(string nonquery)
        {
            MySqlConnection Connect = MySqlConnection(connection);
            try
            {
                Connect.Open();
                using (MySqlCommand command = new MySqlCommand(nonquery, Connect))
                {
                    command.ExecuteNonQuery();
                }
                Connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // Thực hiện truy vấn xem có cột hay không
        public bool Check(string query) 
        {
            bool check =false;
            MySqlConnection Connect = MySqlConnection(connection);
            try
            {
                Connect.Open();
                MySqlCommand command = new MySqlCommand(query, Connect);
                using (MySqlDataReader read = command.ExecuteReader())
                {
                    if (read.HasRows)
                    {
                        check = true;
                    }
                    else check = false;
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            return check;
        }
        // Thực hiện trả về duy nhất 1 giá trị
        public object ExcuteScalar(string query)
        {
            object result = null;
            MySqlConnection Connect = MySqlConnection(connection);
            try
            {
                Connect.Open();
                MySqlCommand cmd = new MySqlCommand(query, Connect);
                result = cmd.ExecuteScalar();
                Connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return result;
        }
    }
}
