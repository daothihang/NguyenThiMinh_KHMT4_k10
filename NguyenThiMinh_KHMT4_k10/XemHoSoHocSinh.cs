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
using DTO;
using System.Data.SqlClient;
namespace NguyenThiMinh_KHMT4_k10
{
    public partial class XemHoSoHocSinh : Form
    {
        public XemHoSoHocSinh()
        {
            InitializeComponent();
        }
        HoSoHocSinhBUL myHSHS = new HoSoHocSinhBUL();
        private void XemHoSoHocSinh_Load(object sender, EventArgs e)
        {
            cboMaLop.DataSource = myHSHS.LayDanhSachHoSoHocSinh();
            cboMaLop.DisplayMember = "MaLop";
            cboMaLop.ValueMember = "MaLop";
            dgvHienThi.DataSource = myHSHS.LayDanhSachHoSoHocSinh();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if(cboMaLop.ValueMember == "")
            {
                dgvHienThi.DataSource = myHSHS.LayDanhSachHoSoHocSinh();
            }
            else
            {
                List<HoSoHocSinhDTO> ds = new List<HoSoHocSinhDTO>();
             //   KetNoiCoSoDuLieu.MoKetNoi();
            //    string sqlSELECT = "SELECT MaHocSinh,  HoTen,NgaySinh, GioiTinh, DiaChi, DiemVaoTruong,HoTenBoMe,SoDienThoai, MaLop FROM HoSoHocSinh where MaLop=@MaLop ";
            //    SqlCommand cmd = new SqlCommand(sqlSELECT, KetNoiCoSoDuLieu.KetNoi);
           //     SqlDataReader dr = cmd.ExecuteReader();
           //     while (dr.Read())
            //    {
            //        HoSoHocSinhDTO hshs = new HoSoHocSinhDTO(
           //             dr["MaHocSinh"].ToString(),
           //             dr["HoTen"].ToString(),
           //             dr["NgaySinh"].ToString(),
           //             dr["GioiTinh"].ToString(),
           //             dr["DiaChi"].ToString(),
           //             Convert.ToInt32(dr["DiemVaoTruong"]),
           //             dr["HoTenBoMe"].ToString(),
            //            dr["SoDienThoai"].ToString(),
           //             dr["MaLop"].ToString());
            //        ds.Add(hshs);
            //    }
           //     KetNoiCoSoDuLieu.DongKetNoi();
            //    return ds;
            }
        }
    }
}
