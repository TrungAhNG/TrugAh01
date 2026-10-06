using System;
using System.Collections.Generic;
using System.Linq;

namespace QuanLySinhVien
{
    public abstract class Nguoi
    {
        public string HoTen { get; set; }

        public Nguoi(string hoTen)
        {
            HoTen = hoTen;
        }

        public virtual string LayThongTin()
        {
            return $"Ho ten: {HoTen}";
        }
    }

    public class SinhVien : Nguoi
    {
        public string MaSV { get; set; }
        public double Diem { get; set; }

        public SinhVien(string maSV, string hoTen, double diem) : base(hoTen)
        {
            MaSV = maSV;
            Diem = diem;
        }

        public override string LayThongTin()
        {
            return string.Format("{0,-10} | {1,-20} | {2,-10}", MaSV, HoTen, Diem);
        }

        public override string ToString()
        {
            return LayThongTin();
        }
    }

    class QuanLyLopHoc
    {
        private List<SinhVien> danhSachSinhVien;

        public QuanLyLopHoc()
        {
            danhSachSinhVien = new List<SinhVien>();
        }

        private string GetValidString(string prompt)
        {
            string input;
            do
            {
                Console.Write(prompt);
                input = Console.ReadLine()?.Trim();
                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Loi: Thong tin khong duoc de trong!");
                }
            } while (string.IsNullOrEmpty(input));
            return input;
        }

        private double GetValidDouble(string prompt, double min, double max)
        {
            double value;
            while (true)
            {
                Console.Write(prompt);
                if (double.TryParse(Console.ReadLine(), out value) && value >= min && value <= max)
                {
                    return value;
                }
                Console.WriteLine($"Loi: Vui long nhap so hop le tu {min} den {max}!");
            }
        }

        public void ThemSinhVien()
        {
            Console.WriteLine("\n--- THEM SINH VIEN ---");
            string maSV;
            while (true)
            {
                maSV = GetValidString("Nhap ma sinh vien: ");
                if (danhSachSinhVien.Any(sv => sv.MaSV.Equals(maSV, StringComparison.OrdinalIgnoreCase)))
                {
                    Console.WriteLine("Loi: Ma sinh vien da ton tai!");
                }
                else
                {
                    break;
                }
            }
            
            string hoTen = GetValidString("Nhap ho ten: ");
            double diem = GetValidDouble("Nhap diem (0-10): ", 0, 10);

            danhSachSinhVien.Add(new SinhVien(maSV, hoTen, diem));
            Console.WriteLine("=> Them sinh vien thanh cong!");
        }

        public void HienThiDanhSach()
        {
            Console.WriteLine("\n--- DANH SACH SINH VIEN ---");
            if (danhSachSinhVien.Count == 0)
            {
                Console.WriteLine("Danh sach trong!");
                return;
            }

            Console.WriteLine(string.Format("{0,-10} | {1,-20} | {2,-10}", "Ma SV", "Ho Ten", "Diem"));
            Console.WriteLine(new string('-', 47));
            foreach (var sv in danhSachSinhVien)
            {
                Console.WriteLine(sv.ToString());
            }
        }

        public void SuaSinhVien()
        {
            string ma = GetValidString("Nhap ma sinh vien can sua: ");
            var sv = danhSachSinhVien.FirstOrDefault(x => x.MaSV.Equals(ma, StringComparison.OrdinalIgnoreCase));
            
            if (sv != null)
            {
                sv.HoTen = GetValidString("Nhap ho ten moi: ");
                sv.Diem = GetValidDouble("Nhap diem moi (0-10): ", 0, 10);
                Console.WriteLine("=> Cap nhat thanh cong!");
            }
            else
            {
                Console.WriteLine("=> Khong tim thay sinh vien voi ma nay!");
            }
        }

        public void XoaSinhVien()
        {
            string ma = GetValidString("Nhap ma sinh vien can xoa: ");
            var sv = danhSachSinhVien.FirstOrDefault(x => x.MaSV.Equals(ma, StringComparison.OrdinalIgnoreCase));

            if (sv != null)
            {
                danhSachSinhVien.Remove(sv);
                Console.WriteLine("=> Xoa thanh cong!");
            }
            else
            {
                Console.WriteLine("=> Khong tim thay sinh vien voi ma nay!");
            }
        }

        public void TimKiemVaSapXep()
        {
            if (danhSachSinhVien.Count == 0)
            {
                Console.WriteLine("\n=> Danh sach trong!");
                return;
            }

            Console.WriteLine("\n--- DANH SACH SINH VIEN DA QUA MON (Diem >= 5) & SAP XEP GIAM DAN ---");
            
            var svQuaMon = danhSachSinhVien
                .Where(sv => sv.Diem >= 5.0)
                .OrderByDescending(sv => sv.Diem)
                .ToList();

            if (svQuaMon.Count > 0)
            {
                Console.WriteLine(string.Format("{0,-10} | {1,-20} | {2,-10}", "Ma SV", "Ho Ten", "Diem"));
                Console.WriteLine(new string('-', 47));
                foreach (var sv in svQuaMon)
                {
                    Console.WriteLine(sv.ToString());
                }
            }
            else
            {
                Console.WriteLine("Khong co sinh vien nao qua mon.");
            }
        }

        public void ThongKeBangLINQ()
        {
            if (danhSachSinhVien.Count == 0)
            {
                Console.WriteLine("\n=> Danh sach trong!");
                return;
            }

            double dtb = danhSachSinhVien.Average(sv => sv.Diem);
            double diemMax = danhSachSinhVien.Max(sv => sv.Diem);
            var dsThuKhoa = danhSachSinhVien.Where(sv => sv.Diem == diemMax).ToList();

            Console.WriteLine("\n--- THONG KE ---");
            Console.WriteLine($"- Diem trung binh chung: {Math.Round(dtb, 2)}");
            Console.WriteLine($"- Diem cao nhat: {diemMax}");
            Console.WriteLine("- Danh sach thu khoa:");
            foreach (var sv in dsThuKhoa)
            {
                Console.WriteLine($"  + {sv.HoTen} ({sv.MaSV})");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            QuanLyLopHoc lopHoc = new QuanLyLopHoc();
            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("\n=========== MENU QUAN LY ===========");
                Console.WriteLine("1. Them sinh vien (Create)");
                Console.WriteLine("2. Hien thi danh sach (Read)");
                Console.WriteLine("3. Sua thong tin (Update)");
                Console.WriteLine("4. Xoa sinh vien (Delete)");
                Console.WriteLine("5. Loc va sap xep sinh vien (LINQ)");
                Console.WriteLine("6. Thong ke diem (LINQ)");
                Console.WriteLine("0. Thoat");
                Console.Write("Moi chon chuc nang: ");
                
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": lopHoc.ThemSinhVien(); break;
                    case "2": lopHoc.HienThiDanhSach(); break;
                    case "3": lopHoc.SuaSinhVien(); break;
                    case "4": lopHoc.XoaSinhVien(); break;
                    case "5": lopHoc.TimKiemVaSapXep(); break;
                    case "6": lopHoc.ThongKeBangLINQ(); break;
                    case "0": isRunning = false; break;
                    default: Console.WriteLine("Loi: Vui long chon chuc nang tu 0-6!"); break;
                }
            }
        }
    }
}
