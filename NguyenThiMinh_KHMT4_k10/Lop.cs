﻿using BUL;
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
    public partial class Lop : Form
    {
        public Lop()
        {
            InitializeComponent();
        }
        LopBUL myLop = new LopBUL();
        CanBoGiaoVienBUL myCanBoGiaoVien = new CanBoGiaoVienBUL();
        private void Lop_Load(object sender, EventArgs e)
        {
            dgvLop.AutoGenerateColumns = false;
            cbGiaoVienChuNhiem.DataSource = myCanBoGiaoVien.LayDsCanBo();
            cbGiaoVienChuNhiem.DisplayMember = "HoTen";
            cbGiaoVienChuNhiem.ValueMember = "MaCanBoGiaoVien";
            //groupBox1.Visible = false;
            //KHÔNG HIỂN THỊ GROUPBOX
        }

        private void dgvLop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvLop.DataSource = myLop.LayDsLop();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            LopBUL lp = new LopBUL();
            string MaLop = txtbMaLop.Text;
            string TenLop = txtbTenLop.Text;
            string NienKhoa = txtbNienKhoa.Text;
            int SiSo = int.Parse(txtbSiSo.Text);
            string GiaoVienChuNhiem =(string) cbGiaoVienChuNhiem.SelectedValue;
            lp.Them(MaLop, TenLop, NienKhoa, SiSo, GiaoVienChuNhiem);
            dgvLop.DataSource = myLop.LayDsLop();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            LopBUL lp = new LopBUL();
            string MaLop = txtbMaLop.Text;
            string TenLop = txtbTenLop.Text;
            string NienKhoa = txtbNienKhoa.Text;
            int SiSo = int.Parse(txtbSiSo.Text);
            string GiaoVienChuNhiem = (string)cbGiaoVienChuNhiem.SelectedValue;
            lp.Sua(MaLop, TenLop, NienKhoa, SiSo, GiaoVienChuNhiem);
            dgvLop.DataSource = myLop.LayDsLop();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            try
            {
                LopBUL lop = new LopBUL();
                string MaLop = txtbMaLop.Text;
                lop.Xoa(MaLop);

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

                dgvLop.DataSource = myLop.LayDsLop();
                ClearLop();
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {

        }
        private void ClearLop()
        {
            txtbMaLop.Clear();
            txtbTenLop.Clear();
            txtbNienKhoa.Clear();
            txtbSiSo.Clear();
            
        }


        private void btnHuy_Click(object sender, EventArgs e)
        {
            ClearLop();
        }

        
        private void cbGiaoVienChuNhiem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
