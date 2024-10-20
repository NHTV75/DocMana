using QuanLyHoSoDuAn.Usercontrol;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHoSoDuAn
{
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
        }

       

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            pnlChinh.Controls.Clear();
            TrangChuControl trangChu = new TrangChuControl();
            trangChu.Dock = DockStyle.Fill;
            pnlChinh.Controls.Add(trangChu);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            pnlChinh.Controls.Clear();
            HoSoControl hoSo = new HoSoControl();
            hoSo.Dock = DockStyle.Fill;
            pnlChinh.Controls.Add(hoSo);
        }

       
    }
}
