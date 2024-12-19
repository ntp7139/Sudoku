
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

    public partial class FormSudoKuKho : Form
    {
        private int[,] banChoi = new int[9, 9]; // Dữ liệu bảng Sudoku
        private System.Windows.Forms.Timer time ;
        private int Thoigian = 0; // Biến đếm thời gian
        private int[,] BangSudoku = new int[9, 9];
        public FormSudoKuKho()
        {
            this.MaximizeBox = false;
            InitializeComponent();
            KhoiTaoBangSudoku();
            KhoitaoBoDemThoiGian();
           

        }
        //Khởi tạo sự kiện chạy 
        private void time_Tick(object sender, EventArgs e)
        {
            Thoigian++;
            lb_Time.Enabled = true;
            int Phut = Thoigian / 60;
            int Giay = Thoigian % 60;
            string Phut_Text = Phut < 10 ? "0" + Phut.ToString() : Phut.ToString();
            string Giay_Text = Giay < 10 ? "0"+ Giay.ToString() : Giay.ToString();
            lb_Time.Text = $"{Phut_Text}:{Giay_Text}";
        }
        //Khởi tạo một bộ đếm thời gian

        private void KhoitaoBoDemThoiGian()
        {
            time = new System.Windows.Forms.Timer();
            time.Interval = 1000; // Thời gian đếm là 1 giây;
            time.Tick += time_Tick; // Sự kiện time_Tick sẽ được chạy mỗi time.Interval
            time.Start();

        }
        private void sodukuwinform_Load(object sender, EventArgs e)
        {
            
            DienDuLieuBang();
        }


        private void KhoiTaoBangSudoku()
        {
            dvgBangTroChoi.RowCount = 10;
            dvgBangTroChoi.ColumnCount = 9;
            dvgBangTroChoi.RowHeadersVisible = false;
            dvgBangTroChoi.ColumnHeadersVisible = false;
            dvgBangTroChoi.DefaultCellStyle.Font = new Font("Arial", 18);
            dvgBangTroChoi.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dvgBangTroChoi.AllowUserToResizeRows = false;
            dvgBangTroChoi.AllowUserToResizeColumns = false;
            dvgBangTroChoi.AllowUserToAddRows = false;

            // Tính toán kích thước hàng và cột
            int cellWidth = dvgBangTroChoi.ClientSize.Width / 9;  // Chiều rộng ô
            int cellHeight = dvgBangTroChoi.ClientSize.Height / 9; // Chiều cao ô

            // Xóa AutoSize và đặt kích thước hàng/cột thủ công
            for (int i = 0; i < dvgBangTroChoi.ColumnCount; i++)
            {
                dvgBangTroChoi.Columns[i].Width = cellWidth;
            }
            for (int i = 0; i < dvgBangTroChoi.RowCount; i++)
            {
                dvgBangTroChoi.Rows[i].Height = cellHeight;
                dvgBangTroChoi.Rows[i].Cells[0].Value = i.ToString();
            }
            dvgBangTroChoi.CellPainting += DvgBangTroChoi_CellPainting;


        }
        private void DvgBangTroChoi_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            // Chỉ vẽ lại phần ô (không phải header)
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            // Vẽ lại nền và nội dung ô mặc định
            e.PaintBackground(e.CellBounds, true);
            e.PaintContent(e.CellBounds);

            // Xác định bút để vẽ đường viền
            Pen thickPen = new Pen(Color.Black, 3); // Độ dày 3 pixel
            Pen normalPen = new Pen(Color.Gray, 1); // Viền thông thường

            // Tọa độ của ô hiện tại
            int x = e.CellBounds.Left;
            int y = e.CellBounds.Top;
            int w = e.CellBounds.Width;
            int h = e.CellBounds.Height;

            // Xác định vị trí của ô 3x3
            bool isRightThick = (e.ColumnIndex + 1) % 3 == 0; // Cột bên phải
            bool isBottomThick = (e.RowIndex + 1) % 3 == 0;   // Hàng bên dưới

            // Vẽ đường viền ô
            // Viền phải (đậm nếu là đường chia 3x3)
            if (isRightThick)
                e.Graphics.DrawLine(thickPen, x + w - 1, y, x + w - 1, y + h);
            else
                e.Graphics.DrawLine(normalPen, x + w - 1, y, x + w - 1, y + h);

            // Viền dưới (đậm nếu là đường chia 3x3)
            if (isBottomThick)
                e.Graphics.DrawLine(thickPen, x, y + h - 1, x + w, y + h - 1);
            else
                e.Graphics.DrawLine(normalPen, x, y + h - 1, x + w, y + h - 1);

            // Viền trên và viền trái (viền thông thường)
            if (e.RowIndex == 0)
                e.Graphics.DrawLine(normalPen, x, y, x + w, y); // Viền trên

            if (e.ColumnIndex == 0)
                e.Graphics.DrawLine(normalPen, x, y, x, y + h); // Viền trái

            // Đánh dấu đã vẽ xong
            e.Handled = true;

            // Giải phóng bút
            thickPen.Dispose();
            normalPen.Dispose();
        }


           private void NutNhapSo_Click(object sender, EventArgs e)
           {
               if (dvgBangTroChoi.CurrentCell != null && dvgBangTroChoi.CurrentCell.ReadOnly == false)
               {
                   Button btn = sender as Button;
                   dvgBangTroChoi.CurrentCell.Value = btn.Text.ToString();
               }
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

                if (dvgBangTroChoi.Rows[dong].Cells[cot].ReadOnly == false) // Chỉ cho phép xóa nhập liệu của người dùng
                {
                    dvgBangTroChoi.CurrentCell.Value = "";
                }
                else
                {
                    MessageBox.Show("Không thể xóa giá trị ban đầu.", "Thông báo");
                }
            }
        }



        private bool KiemTraBangHopLe()
        {
            for (int i = 0; i < 9; i++)
            {
                if (KiemtraFullFill())
                {
                    if (!KiemTraHang(i) || !KiemTraCot(i) || !KiemTraO3x3(i))
                        return false;
                }
                else return false;
            }
            return true;
        }

        private bool KiemTraHang(int hang)
        {
            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < 9; i++)
            {
                int value = Convert.ToInt32(dvgBangTroChoi.Rows[hang].Cells[i].Value);
                if (value != 0 && !set.Add(value)) return false;
            }
            return true;
        }

        private bool KiemTraCot(int cot)
        {
            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < 9; i++)
            {
                int value = Convert.ToInt32(dvgBangTroChoi.Rows[i].Cells[cot].Value);
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
                    int value = Convert.ToInt32(dvgBangTroChoi.Rows[startRow + i].Cells[startCol + j].Value);
                    if (value != 0 && !set.Add(value)) return false;
                }
            }
            return true;
        }
        private bool KiemtraFullFill()
        {
            for (int i = 0; i < 9; i++)
                for (int j = 0; j < 9; j++)
                {
                    if (dvgBangTroChoi.Rows[i].Cells[j].Value == null) return false;
                }
            return true;
        }
        private void ShuffleSudoku(int[,] grid)
        {
            Random rand = new Random();
            try
            {
                // Shuffle các hàng trong từng nhóm 3 hàng
                for (int i = 0; i < 9; i += 3)
                    for (int j = 0; j < 3; j++)
                        SwapRows(grid, i + j, i + rand.Next(0, 3));

                // Shuffle các cột trong từng nhóm 3 cột
                for (int i = 0; i < 9; i += 3)
                    for (int j = 0; j < 3; j++)
                        SwapColumns(grid, i + j, i + rand.Next(0, 3));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                    if (banChoi[i, j] != 0)
                    {
                        dvgBangTroChoi.Rows[i].Cells[j].Value = banChoi[i, j];
                        dvgBangTroChoi.Rows[i].Cells[j].ReadOnly = true;
                    }
                    else { dvgBangTroChoi.Rows[i].Cells[j].Value = null; }
                }
            }
        }

        private void btnKiemTraDungSai_Click_1(object sender, EventArgs e)
        {

            if (KiemTraBangHopLe())
            {
                MessageBox.Show("Chúc mừng! Bạn đã giải đúng Sudoku.", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);

            }
            else
            {
                MessageBox.Show("Bảng Sudoku không hợp lệ. Vui lòng kiểm tra lại.", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
            }
        }

        private void btn_TamDung_Click(object sender, EventArgs e)
        {
            TamDunghoacTieptuc newform = new TamDunghoacTieptuc();
            time.Stop();
            newform.ShowDialog();
            time.Start();

        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {

        }

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_ChoiLai_Click(object sender, EventArgs e)
        {
            DialogResult Check = MessageBox.Show("Bạn có chắc là muốn chơi lại không ?","Thông báo",MessageBoxButtons.OKCancel);
            if (Check == DialogResult.OK) 
            {
                Reset_Bang();
            } 
        }
        private void Reset_Bang()
        {
            for (int i = 0; i < 9; i++)
                for (int j = 0; j < 9; j++)
                {
                    if (dvgBangTroChoi.Rows[i].Cells[j].ReadOnly == false)
                    {
                        dvgBangTroChoi.Rows[i].Cells[j].Value = null;
                    }
                }
        }
    }
}