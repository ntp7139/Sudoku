
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{

    public partial class FormSudoKuTrungBinh : Form
    {
        private Nguoichoi nguoichoi = new Nguoichoi();
        private LichSuDau Bang_Dau = new LichSuDau();
        private int[,] banChoi = new int[9, 9]; // Dữ liệu bảng Sudoku ban đầu
        private System.Windows.Forms.Timer time;
        private int Thoigian = 0; // Biến đếm thời gian
        private int[,] BangSudoku = new int[9, 9];
        private int score = 0;
        private int time_tinh_diem = 0;
        private int Default_score = 60;
        private int[,] Check_Loi = new int[9, 9];
        private int[,] Check_Diem = new int[9, 9];
        private bool status = false;
        private bool Answer_status = false;
        private int Help = 1;
        protected string Che_Do = "Medium";
        protected Dictionary<(int, int), List<int>> draftValues = new Dictionary<(int, int), List<int>>(); // Giá trị nháp
        public void Init_CheckLoi()
        {
            for (int i = 0; i < 9; i++)
                for (int j = 0; j < 9; j++)
                {
                    Check_Loi[i, j] = 1;
                    Check_Diem[i, j] = 1;
                }
        }

        public FormSudoKuTrungBinh()
        {
            this.MaximizeBox = false;
            InitializeComponent();
            KhoiTaoBangSudoku();
            DienDuLieuBang();
            KhoitaoBoDemThoiGian();
            dvgBangTroChoi.CellPainting += dvgBangTroChoi_CellPainting;
            dvgBangTroChoi.KeyDown += dvgBangTroChoi_KeyDown;
            this.KeyPreview = true;


        }
        // Khởi chạy chơi màn mới
        public FormSudoKuTrungBinh(string player_ID)
        {
            nguoichoi.taikhoan = player_ID;
            nguoichoi.Load_Player(player_ID);
            nguoichoi.current_game_id = "0";
            Bang_Dau.game_id = "0";
            Bang_Dau.game_id = Bang_Dau.Set_up_ID_game(Che_Do);
            InitializeComponent();

            KhoiTaoBangSudoku();
            DienDuLieuBang();
            KhoitaoBoDemThoiGian();
            lb_Sudoku_title.Text += "_ID: " + Bang_Dau.game_id;
            dvgBangTroChoi.CellPainting += dvgBangTroChoi_CellPainting;
            dvgBangTroChoi.KeyDown += dvgBangTroChoi_KeyDown;
            this.KeyPreview = true;
            //lb_game_id.Text += Bang_Dau.game_id;
        }
        //Khởi chạy chơi màn đang chơi
        public FormSudoKuTrungBinh(string player_ID, string current_game_id)
        {
            nguoichoi.taikhoan = player_ID;
            nguoichoi.Load_Player(player_ID);
            Bang_Dau.game_id = current_game_id;
            Bang_Dau.Load_LSD();
            InitializeComponent();
            KhoiTaoBangSudoku();

            Load_Game_Cu();
            KhoitaoBoDemThoiGian();
            lb_Sudoku_title.Text +="_ID:" + Bang_Dau.game_id;
            dvgBangTroChoi.CellPainting += dvgBangTroChoi_CellPainting;
            dvgBangTroChoi.KeyDown += dvgBangTroChoi_KeyDown;
            this.KeyPreview = true;
            // lb_game_id.Text += Bang_Dau.game_id;
        }
        
        //Khởi tạo sự kiện chạy 
        private void time_Tick(object sender, EventArgs e)
        {
            Thoigian++;
            time_tinh_diem++;
            lb_Time.Enabled = true;
            int Phut = Thoigian / 60;
            int Giay = Thoigian % 60;
            string Phut_Text = Phut < 10 ? "0" + Phut.ToString() : Phut.ToString();
            string Giay_Text = Giay < 10 ? "0" + Giay.ToString() : Giay.ToString();
            lb_Time.Text = $"{Phut_Text}:{Giay_Text}";
            if (KiemTraBangHopLe() && Answer_status == false && status == false)
            {
                MessageBox.Show("You're winner!");
                status = true;
            }
        }
        //Khởi tạo một bộ đếm thời gian

        private void KhoitaoBoDemThoiGian()
        {
            time = new System.Windows.Forms.Timer();
            time.Interval = 1000; // Thời gian đếm là 1 giây;
            time.Tick += time_Tick; // Sự kiện time_Tick sẽ được chạy mỗi time.Interval
            time.Start();

        }
        // Thêm giá trị nháp
        protected void AddDraft(int row, int col, int draftValue)
        {
            if (!draftValues.ContainsKey((row, col)))
            {
                draftValues[(row, col)] = new List<int>();
            }
            if (!draftValues[(row, col)].Contains(draftValue))
            {
                draftValues[(row, col)].Add(draftValue);
            }
        }

        // Vẽ giá trị nháp trong DataGridView
        protected void dvgBangTroChoi_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            // Kiểm tra nếu ô hiện tại không hợp lệ
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            // Hiển thị giá trị bản nháp nếu tồn tại
            if (draftValues.ContainsKey((e.RowIndex, e.ColumnIndex)))
            {
                // Lấy danh sách giá trị nháp
                string drafts = string.Join(", ", draftValues[(e.RowIndex, e.ColumnIndex)]);

                // Vẽ giá trị chính thức (nếu có)
                if (e.FormattedValue != null && !string.IsNullOrEmpty(e.FormattedValue.ToString()))
                {

                }

                // Vẽ giá trị bản nháp (ở góc dưới bên phải)
                e.Graphics.DrawString(
                   drafts,
                   new Font("Arial", 8, FontStyle.Bold), // Đặt font chữ đậm
                   Brushes.Gray, // Sử dụng màu xám
                   e.CellBounds.X + 5,
                   e.CellBounds.Y + 5
                  );

                // Ngăn không cho vẽ lại nội dung mặc định
                e.Handled = true;
            }
        }

        // Xử lý khi nhấn phím (Ctrl + Số 1-9) để thêm giá trị nháp
        protected void dvgBangTroChoi_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                // Kiểm tra nếu người dùng nhấn Ctrl và phím số từ 1 đến 9
                if (e.Control && e.KeyCode >= Keys.D1 && e.KeyCode <= Keys.D9)
                {
                    int draftValue = e.KeyCode - Keys.D0; // Chuyển phím D1, D2,... về giá trị số 1, 2,...

                    // Lấy ô hiện tại (CurrentCell)
                    int row = dvgBangTroChoi.CurrentCell.RowIndex;
                    int col = dvgBangTroChoi.CurrentCell.ColumnIndex;

                    // Thêm giá trị nháp vào ô
                    AddDraft(row, col, draftValue);

                    // Cập nhật giao diện
                    dvgBangTroChoi.InvalidateCell(col, row);

                    // Ngăn chặn hành động mặc định của phím
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Xóa giá trị nháp trong ô
        protected void ClearDraft(int row, int col)
        {
            if (draftValues.ContainsKey((row, col)))
            {
                draftValues.Remove((row, col));
                dvgBangTroChoi.InvalidateCell(col, row); // Cập nhật lại hiển thị sau khi xóa nháp
            }
        }
        // Xóa bản nháp
        protected void Clear_Draft(object sender, EventArgs e)
        {
            int hang = dvgBangTroChoi.CurrentCell.RowIndex;
            int cot = dvgBangTroChoi.CurrentCell.ColumnIndex;
            ClearDraft(hang, cot);
        }

        //Khởi tạo bảng
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
            dvgBangTroChoi.ReadOnly = false;

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

            }
            dvgBangTroChoi.CellPainting += DvgBangTroChoi_CellPainting;


        }
        //Tạo viền 3x3 cho bảng
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

        //Thao tác nút bấm
        private void NutNhapSo_Click(object sender, EventArgs e)
        {
            if (dvgBangTroChoi.CurrentCell != null && dvgBangTroChoi.CurrentCell.ReadOnly == false)
            {
                if (sender is Button btn)
                {

                    dvgBangTroChoi.CurrentCell.Value = btn.Text.ToString();
                    KiemTra_MoiLanNhap();
                    Fill_Default();
                }
            }

        }



        private bool LaGiaTriBanDau(int dong, int cot)
        {
            return banChoi[dong, cot] != 0;
        }
        // Nút xóa
        private void btnDelete_frmTB_Click(object sender, EventArgs e)
        {
            if (dvgBangTroChoi.CurrentCell != null)
            {
                int dong = dvgBangTroChoi.CurrentCell.RowIndex;
                int cot = dvgBangTroChoi.CurrentCell.ColumnIndex;

                if (dvgBangTroChoi.Rows[dong].Cells[cot].ReadOnly == false) // Chỉ cho phép xóa nhập liệu của người dùng
                {
                    dvgBangTroChoi.CurrentCell.Value = null;
                }
                else
                {
                    MessageBox.Show("Không thể xóa giá trị ban đầu.", "Thông báo");
                }
            }
        }


        // Các phương thức kiểm tra bảng
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
            status = true;
            
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
            int startCol = (index / 3) * 3;

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
        //Tráo bảng tọa bảng sudoku hợp lệ
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
            int soLuongOTrong = 50; // Số lượng ô trống

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
        //Dữ liệu ban đầu
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
            Bang_Dau.Key_Sudoku = Convert_Matrix_To_String(sudokuBase);
            TaoOTrong(sudokuBase);
            Bang_Dau.Default_Sudoku = Convert_Matrix_To_String(sudokuBase);
            Init_CheckLoi();
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    banChoi[i, j] = sudokuBase[i, j];
                    if (banChoi[i, j] != 0)
                    {
                        dvgBangTroChoi.Rows[i].Cells[j].Value = banChoi[i, j];
                        dvgBangTroChoi.Rows[i].Cells[j].ReadOnly = true;
                        dvgBangTroChoi.Rows[i].Cells[j].Style.BackColor = Color.Yellow;

                    }
                    else
                    {
                        dvgBangTroChoi.Rows[i].Cells[j].Value = null;
                        Check_Loi[i, j] = 0;
                    }
                }
            }
            Fill_Default();
        }
        //Kiểm tra đúng sai của bảng
        private void btnCheck_frmTB_Click(object sender, EventArgs e)
        {

            if (KiemTraBangHopLe())
            {
                MessageBox.Show("Chúc mừng! Bạn đã giải đúng Sudoku.", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
                time.Stop();
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

        private void btnSave_frmTB_Click(object sender, EventArgs e)
        {
            try
            {
                Bang_Dau.Che_Do = "Medium";
                Bang_Dau.taikhoan = nguoichoi.taikhoan;
                Bang_Dau.game_id = Bang_Dau.game_id == "0" ? Bang_Dau.Set_up_ID_game(Che_Do) : Bang_Dau.game_id;
                Bang_Dau.time = Thoigian.ToString();
                Bang_Dau.score = lb_Score.Text == "Score" ? "0" : lb_Score.Text;
                // Bang_Dau.Check_Diem = Convert_Matrix_To_String(Check_Diem);
                //Bang_Dau.Check_Loi = Convert_Matrix_To_String(Check_Loi);
                int[,] Table = new int[9, 9];
                Table = Current_Table();
                Bang_Dau.Current_Sudoku = Convert_Matrix_To_String(Table);
                Bang_Dau.game_status = status ? "Done" : "Playing";
                Bang_Dau.Save();
                nguoichoi.current_game_id = Bang_Dau.game_id;
                nguoichoi.Save();
                MessageBox.Show("Bạn đã lưu game thành công!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            Bang_Dau.Che_Do = "Medium";
            Bang_Dau.taikhoan = nguoichoi.taikhoan;
            Bang_Dau.game_id = Bang_Dau.Set_up_ID_game(Che_Do);
            Bang_Dau.time = Thoigian.ToString();
            Bang_Dau.score = lb_Score.Text == "Score" ? "0" : lb_Score.Text;
            // Bang_Dau.Check_Diem = Convert_Matrix_To_String(Check_Diem);
            // Bang_Dau.Check_Loi = Convert_Matrix_To_String(Check_Loi);
            int[,] Table = new int[9, 9];
            Table = Current_Table();
            Bang_Dau.Current_Sudoku = Convert_Matrix_To_String(Table);
            Bang_Dau.game_status = status ? "Done" : "Playing";
            Bang_Dau.Save();
            nguoichoi.current_game_id = Bang_Dau.game_id;
            nguoichoi.Save_ID();
            this.Close();


        }

        private void btn_ChoiLai_Click(object sender, EventArgs e)
        {
            DialogResult Check = MessageBox.Show("Bạn có chắc là muốn chơi lại không ?", "Thông báo", MessageBoxButtons.OKCancel);
            if (Check == DialogResult.OK)
            {
                Reset_Bang();
                Init_CheckLoi();
                score = 0;
                lb_Score.Text = score.ToString();
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
        // Kiểm tra sau mỗi lần nhập số ( Nếu sai báo đỏ)

        private void KiemTra_MoiLanNhap()
        {


            int Cot_RowCheck = -1;
            int Hang_RowCheck = -1;
            int Cot_ColCheck = -1;
            int Hang_ColCheck = -1;
            int Cot_3x3Check = -1;
            int Hang_3x3Check = -1;
            int CountFault = 0;
            // Kiểm tra hàng ở Current cell

            int Hang = dvgBangTroChoi.CurrentCell.RowIndex;
            int Cot = dvgBangTroChoi.CurrentCell.ColumnIndex;
            object GiaTri_Check = dvgBangTroChoi.Rows[Hang].Cells[Cot].Value;
            int GiaTri = Convert.ToInt32(GiaTri_Check);
            int startRow = (Hang / 3) * 3;
            int startCol = (Cot / 3) * 3;
            HashSet<int> set_Hang = new HashSet<int>();
            for (int i = 0; i < 9; i++)
            {
                int value;
                object value1 = dvgBangTroChoi.Rows[Hang].Cells[i].Value;
                if (value1 == null)
                {
                    value = 0;
                }
                else value = Convert.ToInt32(value1);


                if (value != 0 && !set_Hang.Add(value))
                {
                    Hang_RowCheck = Hang;
                    Cot_RowCheck = i;
                    CountFault++;


                }
                else Check_Loi[Hang, i] = 1;
            }
            HashSet<int> set_Cot = new HashSet<int>();
            for (int i = 0; i < 9; i++)
            {
                int value;
                object value1 = dvgBangTroChoi.Rows[i].Cells[Cot].Value;
                if (value1 == null)
                {
                    value = 0;
                }
                else value = Convert.ToInt32(value1);

                if (value != 0 && !set_Cot.Add(value))
                {
                    Hang_ColCheck = i;
                    Cot_ColCheck = Cot;
                    CountFault++;

                }
                else Check_Loi[i, Cot] = 1;
            }
            HashSet<int> set_3x3 = new HashSet<int>();


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int value;
                    object value1 = dvgBangTroChoi.Rows[startRow + i].Cells[startCol + j].Value;
                    if (value1 == null)
                    {
                        value = 0;
                    }
                    else value = Convert.ToInt32(value1);
                    if (value != 0 && !set_3x3.Add(value))
                    {
                        Hang_3x3Check = startRow + i;
                        Cot_3x3Check = startCol + j;
                        CountFault++;

                    }
                    else Check_Loi[startRow + i, startCol + j] = 1;
                }
            }
            if (CountFault > 0)
            {
                if (Hang_RowCheck >= 0)
                    for (int i = 0; i < 9; i++)
                    {
                        if (dvgBangTroChoi.Rows[Hang].Cells[i].Value != null)
                        {
                            object value_check_1 = dvgBangTroChoi.Rows[Hang].Cells[i].Value;
                            int Value_check;
                            if (int.TryParse(value_check_1.ToString(), out Value_check)) // Kiểm tra xem có thể chuyển thành int không
                            {
                                if (Value_check == GiaTri)
                                {
                                    Set_RedColor_Cell(Hang, i);
                                    Check_Loi[Hang, i] = 0;
                                }
                            }
                            else
                            {
                                // Nếu không thể chuyển thành int, bạn có thể xử lý lỗi ở đây
                                MessageBox.Show("Giá trị trong ô không phải là số hợp lệ.");
                            }
                        }
                    }

                if (Hang_ColCheck >= 0)
                    for (int i = 0; i < 9; i++)
                    {
                        if (dvgBangTroChoi.Rows[i].Cells[Cot].Value != null)
                        {
                            object value_check_1 = dvgBangTroChoi.Rows[i].Cells[Cot].Value;
                            int Value_check;
                            if (int.TryParse(value_check_1.ToString(), out Value_check)) // Kiểm tra xem có thể chuyển thành int không
                            {
                                if (Value_check == GiaTri)
                                {
                                    Set_RedColor_Cell(i, Cot);
                                    Check_Loi[i, Cot] = 0;
                                }
                            }
                            else
                            {
                                // Nếu không thể chuyển thành int, bạn có thể xử lý lỗi ở đây
                                MessageBox.Show("Giá trị trong ô không phải là số hợp lệ.");
                            }
                        }
                    }

                if (Hang_3x3Check >= 0)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            if (dvgBangTroChoi.Rows[startRow + i].Cells[startCol + j].Value != null)
                            {
                                object value_check_1 = dvgBangTroChoi.Rows[startRow + i].Cells[startCol + j].Value;
                                int value_check;
                                if (int.TryParse(value_check_1.ToString(), out value_check)) // Kiểm tra xem có thể chuyển thành int không
                                {
                                    if (value_check == GiaTri)
                                    {
                                        Check_Loi[startRow + i, startCol + j] = 0;
                                        Set_RedColor_Cell(startRow + i, startCol + j);
                                    }
                                }
                                else
                                {
                                    // Nếu không thể chuyển thành int, bạn có thể xử lý lỗi ở đây
                                    MessageBox.Show("Giá trị trong ô không phải là số hợp lệ.");
                                }
                            }
                        }
                    }
                }
            }
            if (CountFault == 0)
            {
                if (Check_Diem[Hang, Cot] == 1)
                    score += Default_score - time_tinh_diem;
                time_tinh_diem = 0;
                lb_Score.Text = score.ToString();
                Check_Diem[Hang, Cot] = 0;

            }
            for (int i = 0; i < 9; i++)
                for (int j = 0; j < 9; j++)
                    if (Check_Loi[i, j] == 1)
                        dvgBangTroChoi.Rows[i].Cells[j].Style.BackColor = Color.White;
        }
        private void KiemTra_MoiLanNhap(int m, int n)
        {


            int Cot_RowCheck = -1;
            int Hang_RowCheck = -1;
            int Cot_ColCheck = -1;
            int Hang_ColCheck = -1;
            int Cot_3x3Check = -1;
            int Hang_3x3Check = -1;
            int CountFault = 0;
            // Kiểm tra hàng ở Current cell

            int Hang = m;
            int Cot = n;
            object GiaTri_Check = dvgBangTroChoi.Rows[Hang].Cells[Cot].Value;
            int GiaTri = Convert.ToInt32(GiaTri_Check);
            int startRow = (Hang / 3) * 3;
            int startCol = (Cot / 3) * 3;
            HashSet<int> set_Hang = new HashSet<int>();
            for (int i = 0; i < 9; i++)
            {
                int value;
                object value1 = dvgBangTroChoi.Rows[Hang].Cells[i].Value;
                if (value1 == null)
                {
                    value = 0;
                }
                else value = Convert.ToInt32(value1);


                if (value != 0 && !set_Hang.Add(value))
                {
                    Hang_RowCheck = Hang;
                    Cot_RowCheck = i;
                    CountFault++;


                }
                else Check_Loi[Hang, i] = 1;
            }
            HashSet<int> set_Cot = new HashSet<int>();
            for (int i = 0; i < 9; i++)
            {
                int value;
                object value1 = dvgBangTroChoi.Rows[i].Cells[Cot].Value;
                if (value1 == null)
                {
                    value = 0;
                }
                else value = Convert.ToInt32(value1);

                if (value != 0 && !set_Cot.Add(value))
                {
                    Hang_ColCheck = i;
                    Cot_ColCheck = Cot;
                    CountFault++;

                }
                else Check_Loi[i, Cot] = 1;
            }
            HashSet<int> set_3x3 = new HashSet<int>();


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int value;
                    object value1 = dvgBangTroChoi.Rows[startRow + i].Cells[startCol + j].Value;
                    if (value1 == null)
                    {
                        value = 0;
                    }
                    else value = Convert.ToInt32(value1);
                    if (value != 0 && !set_3x3.Add(value))
                    {
                        Hang_3x3Check = startRow + i;
                        Cot_3x3Check = startCol + j;
                        CountFault++;

                    }
                    else Check_Loi[startRow + i, startCol + j] = 1;
                }
            }
            if (CountFault > 0)
            {
                if (Hang_RowCheck >= 0)
                    for (int i = 0; i < 9; i++)
                    {
                        if (dvgBangTroChoi.Rows[Hang].Cells[i].Value != null)
                        {
                            object value_check_1 = dvgBangTroChoi.Rows[Hang].Cells[i].Value;
                            int Value_check;
                            if (int.TryParse(value_check_1.ToString(), out Value_check)) // Kiểm tra xem có thể chuyển thành int không
                            {
                                if (Value_check == GiaTri)
                                {
                                    Set_RedColor_Cell(Hang, i);
                                    Check_Loi[Hang, i] = 0;
                                }
                            }
                            else
                            {
                                // Nếu không thể chuyển thành int, bạn có thể xử lý lỗi ở đây
                                MessageBox.Show("Giá trị trong ô không phải là số hợp lệ.");
                            }
                        }
                    }

                if (Hang_ColCheck >= 0)
                    for (int i = 0; i < 9; i++)
                    {
                        if (dvgBangTroChoi.Rows[i].Cells[Cot].Value != null)
                        {
                            object value_check_1 = dvgBangTroChoi.Rows[i].Cells[Cot].Value;
                            int Value_check;
                            if (int.TryParse(value_check_1.ToString(), out Value_check)) // Kiểm tra xem có thể chuyển thành int không
                            {
                                if (Value_check == GiaTri)
                                {
                                    Set_RedColor_Cell(i, Cot);
                                    Check_Loi[i, Cot] = 0;
                                }
                            }
                            else
                            {
                                // Nếu không thể chuyển thành int, bạn có thể xử lý lỗi ở đây
                                MessageBox.Show("Giá trị trong ô không phải là số hợp lệ.");
                            }
                        }
                    }

                if (Hang_3x3Check >= 0)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            if (dvgBangTroChoi.Rows[startRow + i].Cells[startCol + j].Value != null)
                            {
                                object value_check_1 = dvgBangTroChoi.Rows[startRow + i].Cells[startCol + j].Value;
                                int value_check;
                                if (int.TryParse(value_check_1.ToString(), out value_check)) // Kiểm tra xem có thể chuyển thành int không
                                {
                                    if (value_check == GiaTri)
                                    {
                                        Check_Loi[startRow + i, startCol + j] = 0;
                                        Set_RedColor_Cell(startRow + i, startCol + j);
                                    }
                                }
                                else
                                {
                                    // Nếu không thể chuyển thành int, bạn có thể xử lý lỗi ở đây
                                    MessageBox.Show("Giá trị trong ô không phải là số hợp lệ.");
                                }
                            }
                        }
                    }
                }
            }
            if (CountFault == 0)
            {
                Check_Diem[Hang, Cot] = 0;

            }
            for (int i = 0; i < 9; i++)
                for (int j = 0; j < 9; j++)
                    if (Check_Loi[i, j] == 1)
                        dvgBangTroChoi.Rows[i].Cells[j].Style.BackColor = Color.White;
        }
        public void Set_RedColor_Cell(int i, int j)
        {
            dvgBangTroChoi.Rows[i].Cells[j].Style.BackColor = Color.Red;

        }
        public string Convert_Matrix_To_String(int[,] matrix)
        {
            string Answer = "";
            for (int i = 0; i < 9; i++)
                for (int j = 0; j < 9; j++)
                    Answer += matrix[i, j].ToString();
            return Answer;
        }
        public int[,] Convert_String_To_Matrix(string Data)
        {
            int[,] Table = new int[9, 9];
            for (int i = 0; i < 9; i++)
                for (int j = 0; j < 9; j++)
                    Table[i, j] = Data[9 * i + j] - '0';
            return Table;
        }
        public int[,] Current_Table()
        {
            int[,] current_table = new int[9, 9];
            for (int i = 0; i < 9; i++)
                for (int j = 0; j < 9; j++)
                {
                    object Data = dvgBangTroChoi.Rows[i].Cells[j].Value;
                    if (Data != null)
                    {
                        current_table[i, j] = Convert.ToInt32(Data);
                    }
                    else
                    {
                        current_table[i, j] = 0;
                    }
                }
            return current_table;
        }
        public bool Load_Game_Cu()
        {
            bool check = false;
            try
            {
                banChoi = Convert_String_To_Matrix(Bang_Dau.Default_Sudoku);
                BangSudoku = Convert_String_To_Matrix(Bang_Dau.Current_Sudoku);

                Thoigian = Convert.ToInt32(Bang_Dau.time);
                score = Convert.ToInt32(Bang_Dau.score);
                //Check_Diem = Convert_String_To_Matrix(Bang_Dau.Check_Diem);
                //Check_Loi = Convert_String_To_Matrix(Bang_Dau.Check_Loi);
                Init_CheckLoi();
                status = Bang_Dau.game_status == "Done";
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {

                        if (banChoi[i, j] != 0 && BangSudoku[i, j] != 0)
                        {
                            dvgBangTroChoi.Rows[i].Cells[j].Value = banChoi[i, j];
                            dvgBangTroChoi.Rows[i].Cells[j].ReadOnly = true;
                            // dvgBangTroChoi.Rows[i].Cells[j].Style.BackColor = Color.Yellow;

                        }
                        else if (BangSudoku[i, j] != 0)
                        {
                            dvgBangTroChoi.Rows[i].Cells[j].ReadOnly = false;
                            dvgBangTroChoi.Rows[i].Cells[j].Value = BangSudoku[i, j];
                        }

                    }
                }
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {

                        if (banChoi[i, j] == 0)
                        {
                            if (BangSudoku[i, j] != 0)
                            {
                                KiemTra_MoiLanNhap(i, j);
                                Fill_Default();
                            }
                        }

                    }
                }

                lb_Score.Text = score.ToString();
                check = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            return check;
        }
        public void Fill_Default()
        {
            for (int i = 0; i < 9; i++)
                for (int j = 0; j < 9; j++)
                    if (dvgBangTroChoi.Rows[i].Cells[j].ReadOnly == true)
                        if (!(dvgBangTroChoi.Rows[i].Cells[j].Style.BackColor == Color.Red))
                        {
                            dvgBangTroChoi.Rows[i].Cells[j].Style.BackColor = Color.LightBlue;
                        }

        }

        private void btnAnswer_frmTB_Click(object sender, EventArgs e)
        {


            if (!Answer_status)
            {
                int[,] Bang = new int[9, 9];
                Bang = Current_Table();

                Bang_Dau.Current_Sudoku = Convert_Matrix_To_String(Bang);
                
                for (int i = 0; i < 9; i++)
                    for (int j = 0; j < 9; j++)
                    {
                        if (dvgBangTroChoi.Rows[i].Cells[j].ReadOnly == false)
                        {
                            dvgBangTroChoi.Rows[i].Cells[j].Style.ForeColor = Color.Gray;
                            dvgBangTroChoi.Rows[i].Cells[j].Value = Bang_Dau.Key_Sudoku[i * 9 + j] - '0';
                        }
                        else
                        {
                            if (dvgBangTroChoi.Rows[i].Cells[j].Style.BackColor != Color.Red)
                            {
                                dvgBangTroChoi.Rows[i].Cells[j].Style.BackColor = Color.LightBlue;
                            }
                        }
                    }
                Bang_Dau.Save();
                Answer_status = true;
            }
            else
            {
                for (int i = 0; i < 9; i++)
                    for (int j = 0; j < 9; j++)
                    {
                        if (dvgBangTroChoi.Rows[i].Cells[j].ReadOnly == false)
                        {
                            dvgBangTroChoi.Rows[i].Cells[j].Style.ForeColor = Color.Black;
                            if (Bang_Dau.Current_Sudoku[i * 9 + j] != '0')
                            {
                                dvgBangTroChoi.Rows[i].Cells[j].Value = Bang_Dau.Current_Sudoku[i * 9 + j] - '0';
                            }
                            else
                            {
                                dvgBangTroChoi.Rows[i].Cells[j].Value = null;
                            }
                        }

                    }
                Answer_status = false;
            }


        }

        private void btnHint_frmTB_Click(object sender, EventArgs e)
        {
            if (Help == 0)
            {
                MessageBox.Show("Bạn đã hết lượt gợi ý", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            } else 
               for(int i= 0; i < 9; i++)
                for(int j = 0; j < 9; j++)
                {
                    if (dvgBangTroChoi.Rows[i].Cells[j].ReadOnly == false)
                    {
                        if (dvgBangTroChoi.Rows[i].Cells[j].Value == null && Help > 0 )
                        {
                            dvgBangTroChoi.Rows[i].Cells[j].Value = Bang_Dau.Key_Sudoku[i * 9 + j] - '0';
                            Help--;
                            
                        }
                    }
                }
        }
    }
}