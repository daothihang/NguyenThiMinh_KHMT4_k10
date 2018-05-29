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
    public partial class CanBoGiaoVien : Form
    {
        public CanBoGiaoVien()
        {
            InitializeComponent();
        }

        CanBoGiaoVienBUL myCB = new CanBoGiaoVienBUL();
        private void CanBoGiaoVien_Load(object sender, EventArgs e)
        {
            cboLoaiTK.DataSource = myCB.LayDsCanBo();
            cboLoaiTK.DisplayMember = "LoaiTaiKhoan";
            cboLoaiTK.ValueMember = "LoaiTaiKhoan";
            dgvCBGV.DataSource = myCB.LayDsCanBo();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                CanBoGiaoVienBUL myCB = new CanBoGiaoVienBUL();
                string MaCanBoGiaoVien = txtMCBGV.Text;
                string HoTen = txtHoTen.Text;
                string DiaChi = txtDiaChi.Text;
                string SoDienThoai = txtSDT.Text;
                string TaiKhoan = txtTaiKhoan.Text;
                string MatKhau = txtMatKhau.Text;          
                string LoaiTaiKhoan = (string)cboLoaiTK.SelectedValue;
                myCB.Them(MaCanBoGiaoVien, HoTen, DiaChi, SoDienThoai, TaiKhoan, MatKhau, LoaiTaiKhoan);
                dgvCBGV.DataSource = myCB.LayDsCanBo();
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm mới không hợp lệ!!!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                CanBoGiaoVienBUL myCB = new CanBoGiaoVienBUL();
                string MaCanBoGiaoVien = txtMCBGV.Text;
                string HoTen = txtHoTen.Text;
                string DiaChi = txtDiaChi.Text;
                string SoDienThoai = txtSDT.Text;
                string TaiKhoan = txtTaiKhoan.Text;
                string MatKhau = txtMatKhau.Text;
                string LoaiTaiKhoan = (string)cboLoaiTK.SelectedValue;
                myCB.Sua(MaCanBoGiaoVien, HoTen, DiaChi, SoDienThoai, TaiKhoan, MatKhau, LoaiTaiKhoan);
                dgvCBGV.DataSource = myCB.LayDsCanBo();
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
                CanBoGiaoVienBUL myCB = new CanBoGiaoVienBUL();
                string MaCanBoGiaoVien = txtMCBGV.Text;
                myCB.Xoa(MaCanBoGiaoVien);

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

                dgvCBGV.DataSource = myCB.LayDsCanBo();
                ClearCanBoGiaoVien();
            }
        }
        private void ClearCanBoGiaoVien()
        {
            txtMCBGV.Clear();
            txtHoTen.Clear();
            txtDiaChi.Clear();
            txtSDT.Clear();
            txtTaiKhoan.Clear();
            txtMatKhau.Clear();
           
        }
    }
}
