using BUL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenThiMinh_KHMT4_k10
{
    public partial class QuanLyMonHoc : Form
    {
        public QuanLyMonHoc()
        {
            InitializeComponent();
        }
        MonHocBUL myMonHoc = new MonHocBUL();

        private void dgvMonHoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void QuanLyMonHoc_Load(object sender, EventArgs e)
        {
            cbCacMonHoc.DataSource = myMonHoc.LayDanhSachMonHoc();
            cbCacMonHoc.DisplayMember = "TenMon";
            cbCacMonHoc.ValueMember = "TenMon";
            dgvMonHoc.DataSource = myMonHoc.LayDanhSachMonHoc();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                MonHocBUL mh = new MonHocBUL();
                string MaMon = txtbMaMonHoc.Text;
                string TenMon = txtbTenMon.Text;
                int SoTiet = int.Parse(txtbSoTiet.Text);
                mh.Them(MaMon, TenMon, SoTiet);
                dgvMonHoc.DataSource = myMonHoc.LayDanhSachMonHoc();
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
                MonHocBUL mh = new MonHocBUL();
                string MaMon = txtbMaMonHoc.Text;
                string TenMon = txtbTenMon.Text;
                int SoTiet = int.Parse(txtbSoTiet.Text);
                mh.Sua(MaMon, TenMon, SoTiet);
                dgvMonHoc.DataSource = myMonHoc.LayDanhSachMonHoc();
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
                MonHocBUL mh = new MonHocBUL();
                string MaMon = txtbMaMonHoc.Text;
                mh.Xoa(MaMon);
                
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
               
                dgvMonHoc.DataSource = myMonHoc.LayDanhSachMonHoc();
                ClearMonHoc();
            }
        }
        private void ClearMonHoc()
        {
            txtbMaMonHoc.Clear();
            txtbTenMon.Clear();
            txtbSoTiet.Clear();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if (cbCacMonHoc.Text == "")
            {
                dgvMonHoc.DataSource = myMonHoc.LayDanhSachMonHoc();
            }
            if (cbCacMonHoc.Text != "")
            {
                MonHocBUL mh = new MonHocBUL();
                DataTable dt = mh.ComboBoxCacMonHoc();
                dgvMonHoc.DataSource = dt;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ClearMonHoc();
        }
    }
}
