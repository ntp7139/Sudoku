using System;

using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sudoku
{
    public partial class FormXepHang : Form
    {
        string constr;
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataAdapter adt;

        public FormXepHang()
        {
            InitializeComponent();
            adt = new MySqlDataAdapter(); // Khởi tạo mặc định
            cmd = new MySqlCommand(); // Khởi tạo mặc định
            constr = "server=127.0.0.1; Database = sudoku; Uid=root; Pwd=phatbaoan112;";
            con = new MySqlConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            con = new MySqlConnection(constr);
            con.Open();
            cmd = new MySqlCommand("select * from nguoichoi ", con);
            adt = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            adt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
