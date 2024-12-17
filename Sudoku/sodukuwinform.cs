using QUANLYTRANGTHAIGAME;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class sodukuwinform : Form
    {
        private int[,] banChoi = new int[9, 9]; // Dữ liệu bảng Sudoku

        public sodukuwinform()
        {
            InitializeComponent();
            KhoiTaoBangSudoku();
            TaoNutNhapSo();
        }
        private void sodukuwinform_Load(object sender, EventArgs e)
        {
            DienDuLieuBang();
        }


        private void KhoiTaoBangSudoku()
        {
            // Thiết lập DataGridView
            dvgBangTroChoi.RowCount = 9;
            dvgBangTroChoi.ColumnCount = 9;
            dvgBangTroChoi.RowHeadersVisible = false;
            dvgBangTroChoi.ColumnHeadersVisible = false;
            dvgBangTroChoi.DefaultCellStyle.Font = new Font("Arial", 18);
            dvgBangTroChoi.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dvgBangTroChoi.AllowUserToResizeRows = false;
            dvgBangTroChoi.AllowUserToResizeColumns = false;
            dvgBangTroChoi.AllowUserToAddRows = false;

            foreach (DataGridViewColumn cot in dvgBangTroChoi.Columns)
            {
                cot.Width = dvgBangTroChoi.Width / 9 - 1;
            }
            foreach (DataGridViewRow dong in dvgBangTroChoi.Rows)
            {
                dong.Height = dvgBangTroChoi.Height / 9 - 1;
            }
        }

        private void TaoNutNhapSo()
        {
            for (int i = 1; i <= 9; i++)
            {
                Button btn = new Button();
                btn.Text = i.ToString();
                btn.Width = 40;
                btn.Height = 40;
                btn.Tag = i;
                btn.Click += NutNhapSo_Click;
                //flowLayoutPanel1.Controls.Add(btn); // Đảm bảo bạn đã thêm flowLayoutPanel1 vào Form
            }
        }

        private void NutNhapSo_Click(object sender, EventArgs e)
        {
            if (dvgBangTroChoi.CurrentCell != null && dvgBangTroChoi.CurrentCell.ReadOnly == false)
            {
                Button btn = sender as Button;
                dvgBangTroChoi.CurrentCell.Value = btn.Tag.ToString();
            }
        }

        private void btnQuanLyTrangThai_Click(object sender, EventArgs e)
        {
            TaiLaiTrangthai qltttt = new TaiLaiTrangthai();
            this.Hide();
            qltttt.Show();
            this.Close();
        }

        private bool LaGiaTriBanDau(int dong, int cot)
        {
            return banChoi[dong, cot] != 0;
        }

        private void bntXoa_Click(object sender, EventArgs e)
        {
            if (dvgBangTroChoi.CurrentCell != null)
            {
                int dong = dvgBangTroChoi.CurrentCell.RowIndex;
                int cot = dvgBangTroChoi.CurrentCell.ColumnIndex;

                if (banChoi[dong, cot] == 0) // Chỉ cho phép xóa nhập liệu của người dùng
                {
                    dvgBangTroChoi.CurrentCell.Value = "";
                }
                else
                {
                    MessageBox.Show("Không thể xóa giá trị ban đầu.", "Thông báo");
                }
            }
        }

        private void btnKiemTraDungSai_Click(object sender, EventArgs e)
        {
            if (KiemTraBangHopLe())
            {
                MessageBox.Show("Chúc mừng! Bạn đã giải đúng Sudoku.", "Thông báo");
            }
            else
            {
                MessageBox.Show("Bảng Sudoku không hợp lệ. Vui lòng kiểm tra lại.", "Thông báo");
            }
        }

        private bool KiemTraBangHopLe()
        {
            for (int i = 0; i < 9; i++)
            {
                if (!KiemTraHang(i) || !KiemTraCot(i) || !KiemTraO3x3(i))
                    return false;
            }
            return true;
        }

        private bool KiemTraHang(int hang)
        {
            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < 9; i++)
            {
                int value = banChoi[hang, i];
                if (value != 0 && !set.Add(value)) return false;
            }
            return true;
        }

        private bool KiemTraCot(int cot)
        {
            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < 9; i++)
            {
                int value = banChoi[i, cot];
                if (value != 0 && !set.Add(value)) return false;
            }
            return true;
        }

        private bool KiemTraO3x3(int index)
        {
            HashSet<int> set = new HashSet<int>();
            int startRow = (index / 3) * 3;
            int startCol = (index % 3) * 3;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int value = banChoi[startRow + i, startCol + j];
                    if (value != 0 && !set.Add(value)) return false;
                }
            }
            return true;
        }
        private void ShuffleSudoku(int[,] grid)
        {
            Random rand = new Random();

            // Shuffle các hàng trong từng nhóm 3 hàng
            for (int i = 0; i < 9; i += 3)
                for (int j = 0; j < 3; j++)
                    SwapRows(grid, i + j, i + rand.Next(0, 3));

            // Shuffle các cột trong từng nhóm 3 cột
            for (int i = 0; i < 9; i += 3)
                for (int j = 0; j < 3; j++)
                    SwapColumns(grid, i + j, i + rand.Next(0, 3));
        }

        private void SwapRows(int[,] grid, int row1, int row2)
        {
            for (int i = 0; i < 9; i++)
            {
                int temp = grid[row1, i];
                grid[row1, i] = grid[row2, i];
                grid[row2, i] = temp;
            }
        }

        private void SwapColumns(int[,] grid, int col1, int col2)
        {
            for (int i = 0; i < 9; i++)
            {
                int temp = grid[i, col1];
                grid[i, col1] = grid[i, col2];
                grid[i, col2] = temp;
            }
        }
        private void TaoOTrong(int[,] grid)
        {
            Random rand = new Random();
            int soLuongOTrong = 40; // Số lượng ô trống

            for (int i = 0; i < soLuongOTrong; i++)
            {
                int row, col;

                do
                {
                    row = rand.Next(0, 9);
                    col = rand.Next(0, 9);
                } while (grid[row, col] == 0); // Đảm bảo không trùng ô đã xóa

                grid[row, col] = 0; // Xóa giá trị tại ô này
            }
        }
        private void DienDuLieuBang()
        {
            int[,] sudokuBase = {
                { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
                { 4, 5, 6, 7, 8, 9, 1, 2, 3 },
                { 7, 8, 9, 1, 2, 3, 4, 5, 6 },
                { 2, 3, 4, 5, 6, 7, 8, 9, 1 },
                { 5, 6, 7, 8, 9, 1, 2, 3, 4 },
                { 8, 9, 1, 2, 3, 4, 5, 6, 7 },
                { 3, 4, 5, 6, 7, 8, 9, 1, 2 },
                { 6, 7, 8, 9, 1, 2, 3, 4, 5 },
                { 9, 1, 2, 3, 4, 5, 6, 7, 8 }
            };

            ShuffleSudoku(sudokuBase);
            TaoOTrong(sudokuBase);

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    banChoi[i, j] = sudokuBase[i, j];
                    dvgBangTroChoi.Rows[i].Cells[j].Value = banChoi[i, j] == 0 ? "" : banChoi[i, j].ToString();
                }
            }
        }
    }
}