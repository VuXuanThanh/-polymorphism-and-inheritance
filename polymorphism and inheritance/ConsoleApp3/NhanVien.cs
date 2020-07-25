using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
   public class NhanVien
    {
        protected string ten;
        protected long luong;

        public NhanVien() { }
        public NhanVien(string ten)
        {
            this.ten = ten;
        }
        public virtual String loaiNhanVien()
        {
            return "";
        }
        public virtual long tinhLuong(){
            return luong = 0;
        }
        public void xuatThongTin()
        {
            Console.WriteLine("=====nhan vien: " + ten + "======");
            Console.WriteLine("-Loai nhan vien:" + loaiNhanVien());
            Console.WriteLine("-Luong: "+tinhLuong());
            
        } 

    }
}
