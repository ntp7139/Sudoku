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
    public partial class FormHuongDanChoi : Form
    {
        public FormHuongDanChoi()
        {
            InitializeComponent();
            pnHuongDan1.Visible = true;
            pnHuongDan2.Visible = false;
            pnHuongDan3.Visible = false;
            pnHuongDan4.Visible = false;
            pnHuongDan5.Visible = false;
            pnHuongDan6.Visible = false;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbHD1_Click(object sender, EventArgs e)
        {

        }

        private void pbNextTo2_Click(object sender, EventArgs e)
        {
            pnHuongDan1.Visible = false;
            pnHuongDan3.Visible = false;
            pnHuongDan4.Visible = false;
            pnHuongDan5.Visible = false;
            pnHuongDan6.Visible = false;
            pnHuongDan2.Visible = true;
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbNextTo3_Click(object sender, EventArgs e)
        {
            pnHuongDan1.Visible = false;
            pnHuongDan2.Visible = false;
            pnHuongDan4.Visible = false;
            pnHuongDan5.Visible = false;
            pnHuongDan6.Visible = false;
            pnHuongDan3.Visible = true;
        }

        private void pbReturn1_Click(object sender, EventArgs e)
        {
            pnHuongDan2.Visible = false;
            pnHuongDan3.Visible = false;
            pnHuongDan4.Visible = false;
            pnHuongDan5.Visible = false;
            pnHuongDan6.Visible = false;
            pnHuongDan1.Visible = true;
        }

        private void pbNextTo4_Click(object sender, EventArgs e)
        {
            pnHuongDan2.Visible = false;
            pnHuongDan3.Visible = false;
            pnHuongDan1.Visible = false;
            pnHuongDan5.Visible = false;
            pnHuongDan6.Visible = false;
            pnHuongDan4.Visible = true;
        }

        private void pbReturn2_Click(object sender, EventArgs e)
        {
            pnHuongDan4.Visible = false;
            pnHuongDan3.Visible = false;
            pnHuongDan1.Visible = false;
            pnHuongDan5.Visible = false;
            pnHuongDan6.Visible = false;
            pnHuongDan2.Visible = true;
        }

        private void pbReturn3_Click(object sender, EventArgs e)
        {
            pnHuongDan4.Visible = false;
            pnHuongDan2.Visible = false;
            pnHuongDan1.Visible = false;
            pnHuongDan5.Visible = false;
            pnHuongDan6.Visible = false;
            pnHuongDan3.Visible = true;
        }

        private void pbNextTo5_Click(object sender, EventArgs e)
        {
            pnHuongDan4.Visible = false;
            pnHuongDan2.Visible = false;
            pnHuongDan3.Visible = false;
            pnHuongDan5.Visible = false;
            pnHuongDan6.Visible = false;
            pnHuongDan5.Visible = true;
        }

        private void pbReturn4_Click(object sender, EventArgs e)
        {
            pnHuongDan1.Visible = false;
            pnHuongDan2.Visible = false;
            pnHuongDan3.Visible = false;
            pnHuongDan5.Visible = false;
            pnHuongDan6.Visible = false;
            pnHuongDan4.Visible = true;
        }

        private void pbNextTo6_Click(object sender, EventArgs e)
        {
            pnHuongDan4.Visible = false;
            pnHuongDan2.Visible = false;
            pnHuongDan3.Visible = false;
            pnHuongDan5.Visible = false;
            pnHuongDan1.Visible = false;
            pnHuongDan6.Visible = true;
        }

        private void pbReturn5_Click(object sender, EventArgs e)
        {
            pnHuongDan1.Visible = false;
            pnHuongDan2.Visible = false;
            pnHuongDan3.Visible = false;
            pnHuongDan5.Visible = false;
            pnHuongDan6.Visible = false;
            pnHuongDan5.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

