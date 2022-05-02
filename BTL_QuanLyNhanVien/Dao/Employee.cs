using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QuanLyNhanVien.Dao
{
    public class Employee
    { 
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public string GioiTinh { get; set; }
        public string DiDong { get; set; }
        public string ChuyenMon { get; set; }
        public string MaNhanVien { get; set; }
        public string ChucVu { get; set; }
        public double LuongCoBan { get; set; }
        public string PhongBan { get; set; }
        public double HeSoLuong { get; set; }
        public double PhuCap { get; set; }
        public string CCCD { get; set; }
    

        public Employee(string hoTen, DateTime ngaySinh, string diaChi, string email, string gioiTinh, string diDong, string chuyenMon, string maNhanVien, string chucVu, Double luongCoBan, string phongBan, Double heSoLuong, Double phuCap, string cCCD)
        {
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            DiaChi = diaChi;
            Email = email;
            GioiTinh = gioiTinh;
            DiDong = diDong;
            ChuyenMon = chuyenMon;
            MaNhanVien = maNhanVien;
            ChucVu = chucVu;
            LuongCoBan = luongCoBan;
            PhongBan = phongBan;
            HeSoLuong = heSoLuong;
            PhuCap = phuCap;
            CCCD = cCCD;

            
        }
        public Employee()
        {


        }
    }
    
}
