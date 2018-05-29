using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUL;


namespace NguyenThiMinh_KHMT4_k10
{
    public partial class HoSoHocSinh : Form
    {
        public HoSoHocSinh()
        {
            InitializeComponent();
        }
        HoSoHocSinhBUL myHSHS = new HoSoHocSinhBUL();
        private void HoSoHocSinh_Load(object sender, EventArgs e)
        {
            cboGT.DataSource = myHSHS.LayDanhSachHoSoHocSinh();
            cboGT.DisplayMember = "GioiTinh";
            cboGT.ValueMember = "GioiTinh";
            cboMaLop.DataSource = myHSHS.LayDanhSachHoSoHocSinh();
            cboMaLop.DisplayMember = "MaLop";
            cboMaLop.ValueMember = "MaLop";
            dgvHSHS.DataSource = myHSHS.LayDanhSachHoSoHocSinh();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                HoSoHocSinhBUL hs = new HoSoHocSinhBUL();
                string MaHocSinh = txtMaHS.Text;
                string HoTen = txtHoTen.Text;
                string NgaySinh = dateTimePicker1.Value.ToString();
                string GioiTinh = (string)cboGT.SelectedValue;
                string DiaChi = txtĐiaChi.Text;               
                float DiemVaoTruong = float.Parse(txtDiemVT.Text);
                string HoTenBoMe = txtTenBM.Text;
                string SoDienThoai = txtSDT.Text;
                string MaLop = (string)cboMaLop.SelectedValue;
                hs.Them(MaHocSinh, HoTen, NgaySinh ,GioiTinh, DiaChi, DiemVaoTruong,
                    HoTenBoMe, SoDienThoai, MaLop);
                dgvHSHS.DataSource = myHSHS.LayDanhSachHoSoHocSinh();
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm mới không hợp lệ!!!");
            }
        }

        private void cboGT_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboGT.DataSource = myHSHS.LayDanhSachHoSoHocSinh();
            cboGT.DisplayMember = "GioiTinh";
            cboGT.ValueMember = "GioiTinh";
        }

        private void cboMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                HoSoHocSinhBUL hs = new HoSoHocSinhBUL();
                string MaHocSinh = txtMaHS.Text;
                string HoTen = txtHoTen.Text;
                string NgaySinh = dateTimePicker1.Value.ToString();
                string GioiTinh = (string)cboGT.SelectedValue;
                string DiaChi = txtĐiaChi.Text;
                float DiemVaoTruong = float.Parse(txtDiemVT.Text);
                string HoTenBoMe = txtTenBM.Text;
                string SoDienThoai = txtSDT.Text;
                string MaLop = (string)cboMaLop.SelectedValue;
                hs.Sua(MaHocSinh, HoTen, NgaySinh, GioiTinh, DiaChi, DiemVaoTruong,
                    HoTenBoMe, SoDienThoai, MaLop);
                dgvHSHS.DataSource = myHSHS.LayDanhSachHoSoHocSinh();
            }
            catch (Exception)
            {
                MessageBox.Show("Sửa thông tin  không hợp lệ!!!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                HoSoHocSinhBUL hs = new HoSoHocSinhBUL();
                string MaHocSinh = txtMaHS.Text;
                hs.Xoa(MaHocSinh);

            }
            catch (Exception)
            {
                MessageBox.Show("Xóa thông tin  không hợp lệ!!!");
            }
            DialogResult dlr = MessageBox.Show("Thông báo xác nhận xóa",
            "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.No)
            {

            }
            if (dlr == DialogResult.Yes)
            {

                dgvHSHS.DataSource = myHSHS.LayDanhSachHoSoHocSinh();
                ClearHoSoHocSinh();
            }          
        }
        private void ClearHoSoHocSinh()
        {
            txtMaHS.Clear();
            txtHoTen.Clear();
           
            txtĐiaChi.Clear();
            txtDiemVT.Clear();
            txtTenBM.Clear();
            txtSDT.Clear();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            XemHoSoHocSinh hshs = new XemHoSoHocSinh();
            hshs.Show();
        }
    }
}
