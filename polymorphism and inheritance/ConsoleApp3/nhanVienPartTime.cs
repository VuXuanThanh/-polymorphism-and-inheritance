using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class nhanVienPartTime : NhanVien
    {
        int sogioLam;

        public nhanVienPartTime(string ten, int sogioLam) : base(ten)
        {
            this.sogioLam = sogioLam;
        }

        public override string loaiNhanVien()
        {
            return "Nhan vien part time";
        }

        public override long tinhLuong()
        {
            return luong = Config.luongPartTimeTheoGio * sogioLam;
        }
    }
}
