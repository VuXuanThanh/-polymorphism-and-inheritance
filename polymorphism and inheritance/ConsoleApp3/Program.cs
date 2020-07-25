using System;

namespace ConsoleApp3
{
   
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("\nNhap vao so luong nhan vien trong cong ty:");
            n = Convert.ToInt32(Console.ReadLine());
            NhanVien[] mangNhanVien = new NhanVien[n];

            for(int i = 0; i < n; i++)
            {
                Console.Write("\tTen nhan vien thu {0}: ", i+1);
                string ten = Convert.ToString(Console.ReadLine());
                Console.WriteLine("La nhan vien nao(1 or 2): 1-Fulltime; 2-Parttime");
                int laNhanVien = Convert.ToInt32(Console.ReadLine());
                if (laNhanVien == 1)
                {
                    Console.WriteLine("Chuc vu la 1-truong phong; 2-nhan vien");
                    int loaiChucVu = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("so ngay lam them: ");
                    int ngayLamThem = Convert.ToInt32(Console.ReadLine());
                    mangNhanVien[i] = new nhanVienFullTime(ten, ngayLamThem, loaiChucVu);
                }
                else
                {
                    Console.WriteLine("Gio lam: ");
                    int gioLamViec = Convert.ToInt32(Console.ReadLine());
                    mangNhanVien[i] = new nhanVienPartTime(ten, gioLamViec);
                }
            }

            Console.WriteLine("\n=====Ket qua tinh luong======: ");
            
            foreach(NhanVien nhanVien in mangNhanVien)
            {
                nhanVien.tinhLuong();
                nhanVien.xuatThongTin();
            }

        }
    }
}
