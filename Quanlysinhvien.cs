using System;
using System.Collections.Generic;

class SinhVien
{
    public string hoTen { get; set; }
    public double diem { get; set; }

    public SinhVien(string tenInput, double diemInput)
    {
        hoTen = tenInput;
        diem = diemInput;
    }
}

class QuanLyLopHoc
{
    public List<SinhVien> danhSachSinhVien { get; set; }

    public QuanLyLopHoc()
    {
        danhSachSinhVien = new List<SinhVien>();
    }

    public void nhapThongTin()
    {
        int soLuong = 0;
        while (soLuong <= 0)
        {
            Console.Write("Nhap so luong sinh vien (n > 0): ");
            int.TryParse(Console.ReadLine(), out soLuong);
        }

        for (int i = 0; i < soLuong; i++)
        {
            Console.Write($"Nhap ho ten sinh vien thu {i + 1}: ");
            string tenInput = Console.ReadLine();

            Console.Write($"Nhap diem sinh vien thu {i + 1}: ");
            double diemInput = 0;
            double.TryParse(Console.ReadLine(), out diemInput);

            danhSachSinhVien.Add(new SinhVien(tenInput, diemInput));
        }
    }

    public void inBangDanhSach()
    {
        Console.WriteLine("\n--- DANH SACH SINH VIEN ---");
        Console.WriteLine(String.Format("{0,-20} | {1,-10}", "Ho ten", "Diem"));
        Console.WriteLine("----------------------------------");
        foreach (SinhVien sv in danhSachSinhVien)
        {
            Console.WriteLine(String.Format("{0,-20} | {1,-10}", sv.hoTen, sv.diem));
        }
    }

    public void inThongKe()
    {
        if (danhSachSinhVien.Count == 0) return;

        double tongDiem = 0;
        double diemMax = danhSachSinhVien[0].diem;
        string sinhVienMax = danhSachSinhVien[0].hoTen;
        int soLuongDat = 0;

        foreach (SinhVien sv in danhSachSinhVien)
        {
            tongDiem += sv.diem;

            if (sv.diem > diemMax)
            {
                diemMax = sv.diem;
                sinhVienMax = sv.hoTen;
            }

            if (sv.diem >= 5.0)
            {
                soLuongDat++;
            }
        }

        double diemTrungBinh = tongDiem / danhSachSinhVien.Count;

        Console.WriteLine();
        Console.WriteLine($"- Diem trung binh: {diemTrungBinh}");
        Console.WriteLine($"- Diem cao nhat lop: {diemMax}");
        Console.WriteLine($"- Sinh vien co diem cao nhat: {sinhVienMax}");
        Console.WriteLine($"- So luong sinh vien dat (diem >= 5): {soLuongDat}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        QuanLyLopHoc lopHoc = new QuanLyLopHoc();
        lopHoc.nhapThongTin();
        lopHoc.inBangDanhSach();
        lopHoc.inThongKe();
    }
}
