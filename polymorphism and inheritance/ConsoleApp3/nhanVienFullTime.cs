using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class nhanVienFullTime : NhanVien
    {
        int loaiChucVu;
        int ngayLamThem;

        public nhanVienFullTime(string ten, int ngayLamThem, int loaiChucVu) : base(ten)
        {
            this.loaiChucVu = loaiChucVu;
            this.ngayLamThem = ngayLamThem;
        }

        public override string loaiNhanVien()
        {
            if (loaiChucVu == Config.truongPhong)
            {
                return "Truong phong "+ (ngayLamThem > 0 ? " (có làm thêm ngày)" : "");
            }
            else
            {
                return "Nhan vien "+ (ngayLamThem > 0 ? " (có làm thêm ngày)" : "");
            }
        }

        public override long tinhLuong()
        {
           if(loaiChucVu == Config.truongPhong)
            {
                return luong = Config.luongTruongPhong + ngayLamThem * Config.luongLamThemTheoNgay;
            }
            else
            {
                return luong = Config.luongNhanVien + ngayLamThem * Config.luongLamThemTheoNgay;
            }
        }
    }
}

