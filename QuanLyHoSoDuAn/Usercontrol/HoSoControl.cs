using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHoSoDuAn.Usercontrol
{
    public partial class HoSoControl : UserControl
    {
        public HoSoControl()
        {
            InitializeComponent();
        }

        private void MyUserControlHoSo_Load(object sender, EventArgs e)
        {
            // Xóa các hàng cũ (nếu có)
            guna2DataGridViewHoSo.Rows.Clear();

            // Thêm dữ liệu test vào DataGridView
            guna2DataGridViewHoSo.Rows.Add("Hồ sơ pháp lý", "Nhóm pháp lý","20/10/2024");
            guna2DataGridViewHoSo.Rows.Add("Hồ sơ thi công", "Nhóm thi công", "5/10/2024");

        }

        private void guna2DataGridViewHoSo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy dòng được chọn
                DataGridViewRow selectedRow = guna2DataGridViewHoSo.Rows[e.RowIndex];
                string tenHoSo = selectedRow.Cells["TenHoSo"].Value.ToString();

                // Chuyển sang TaiLieuControl
                LoadTaiLieuControl(tenHoSo);
            }
        }

        private void LoadTaiLieuControl(string tenHoSo)
        {
            // Tạo đối tượng của TaiLieuControl
            TaiLieuConTrol taiLieuControl = new TaiLieuConTrol();

            // Truyền dữ liệu hồ sơ vào TaiLieuControl
            taiLieuControl.SetHoSo(tenHoSo);

            // Xóa các UserControl hiện tại trong Panel chính (panelContent là Panel bạn chứa UserControl)
            pnlChinh.Controls.Clear();

            // Thêm TaiLieuControl vào Panel chính
            taiLieuControl.Dock = DockStyle.Fill;
            pnlChinh.Controls.Add(taiLieuControl);
        }
    }
}
