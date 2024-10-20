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
    public partial class TaiLieuConTrol : UserControl
    {
        public TaiLieuConTrol()
        {
            InitializeComponent();
        }

        private void MyUserControlTaiLieu_Load(object sender, EventArgs e)
        {
            // Xóa các hàng cũ (nếu có)
            guna2DataGridView1.Rows.Clear();

            // Thêm dữ liệu test vào DataGridView
            guna2DataGridView1.Rows.Add("2024.10.14_TDT.N1_DocMana.0_SRS.0", "Đặc tả yêu cầu phần mềm", "Đang xử lý", "0");
            guna2DataGridView1.Rows.Add("2024.10.14_TDT.N1_DocMana.0_SRS.2", "Đặc tả yêu cầu phần mềm", "Đang xử lý", "2");
            
        }

        public void SetHoSo(string tenHoSo)
        {
            // Cập nhật giao diện với thông tin hồ sơ tương ứng
            labelTenHoso.Text = tenHoSo;
            // Hoặc load dữ liệu liên quan đến hồ sơ đó
        }
    }
}
