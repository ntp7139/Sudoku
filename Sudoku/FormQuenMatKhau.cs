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
    public partial class FormQuenMatKhau : Form
    {
        public FormQuenMatKhau()
        {
            InitializeComponent();
        }

        private void btn_Quaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
