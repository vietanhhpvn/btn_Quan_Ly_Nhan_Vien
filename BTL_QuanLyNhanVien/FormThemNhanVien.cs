using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QuanLyNhanVien
{
    public partial class FormThemNhanVien : Form
    {
        public FormThemNhanVien()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string HoTen = txbHoTenMain.Text;
            DateTime NgaySinh = dtpNgaySinhMain.Value;
            string DiaChi = txbDiaChi.Text;
            string Email = txbEmail.Text;
            string GioiTinh = cbbGioiTinhMain.Text;
            string DiDong = txbDiDongMain.Text;
            string ChuyenMon = txbChuyenMonMain.Text;
            string CCCD = txbCCCDMain.Text;

            string MaNhanVien = txbMaNhanVien.Text;
            string PhongBan = cbbPhongBan.Text;
            string ChucVu = txbChucVu.Text;
            double HeSoLuong = Convert.ToDouble(txbHeSoLuong.Text);
            double LuongCoBan = Convert.ToDouble(txbLuongCoBan.Text);
            double PhuCap = Convert.ToDouble(txbPhuCap.Text);
            Dao.Const.NewEmploy = new Dao.Employee(HoTen, NgaySinh, DiaChi, Email, GioiTinh, DiDong, ChuyenMon, MaNhanVien, ChucVu, LuongCoBan, PhongBan, HeSoLuong, PhuCap, CCCD);

            AccountDao.AccountDao.Instance.ThemNhanVien(Dao.Const.NewEmploy);
            this.Close();
        }
        
        private void FormThemNhanVien_Load(object sender, EventArgs e)
        {

            cbbGioiTinhMain.DataSource = Dao.Const.listGioiTinh;
            cbbPhongBan.DataSource = Dao.Const.listPhongBan; 
        }

        private void grbThongTinCaNhan_Enter(object sender, EventArgs e)
        {

        }
    }
}
