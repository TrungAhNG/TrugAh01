using System;
using System.Collections.Generic;

namespace Lab03_QuanLySinhVienOOP
{
    class Program
    {
        static QuanLySinhVien qlsv = new QuanLySinhVien();

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; // Hỗ trợ in tiếng Việt
            int chon = -1;

            while (chon != 0)
            {
                Console.WriteLine("\n===== QUAN LY SINH VIEN =====");
                Console.WriteLine("1. Them sinh vien");
                Console.WriteLine("2. Xuat danh sach");
                Console.WriteLine("3. Tim sinh vien theo ma");
                Console.WriteLine("4. Tim sinh vien theo ten");
                Console.WriteLine("5. Sua diem trung binh");
                Console.WriteLine("6. Xoa sinh vien");
                Console.WriteLine("7. Sap xep theo diem giam dan");
                Console.WriteLine("8. Loc sinh vien dat");
                Console.WriteLine("0. Thoat");
                Console.Write("Chon chuc nang: ");

                if (!int.TryParse(Console.ReadLine(), out chon))
                {
                    Console.WriteLine("Vui lòng nhập số hợp lệ!");
                    continue;
                }

                switch (chon)
                {
                    case 1: FuncThemSinhVien(); break;
                    case 2: FuncXuatDanhSach(qlsv.LayDanhSach()); break;
                    case 3: FuncTimTheoMa(); break;
                    case 4: FuncTimTheoTen(); break;
                    case 5: FuncSuaDiem(); break;
                    case 6: FuncXoaSinhVien(); break;
                    case 7: FuncXuatDanhSach(qlsv.SapXepTheoDiem()); break;
                    case 8: FuncXuatDanhSach(qlsv.LayDanhSachDat()); break;
                    case 0: Console.WriteLine("Đã thoát chương trình."); break;
                    default: Console.WriteLine("Chức năng không tồn tại. Vui lòng chọn lại."); break;
                }
            }
        }

        static void FuncThemSinhVien()
        {
            try
            {
                Console.Write("Nhập mã sinh viên: ");
                string ma = Console.ReadLine();
                Console.Write("Nhập họ tên: ");
                string ten = Console.ReadLine();
                
                Console.Write("Nhập ngày sinh (dd/MM/yyyy): ");
                DateTime ngaySinh = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

                Console.Write("Nhập mã lớp: ");
                string maLop = Console.ReadLine();

                Console.Write("Nhập điểm trung bình: ");
                double diem = double.Parse(Console.ReadLine());

                SinhVien sv = new SinhVien(ma, ten, ngaySinh, maLop, diem);
                qlsv.Them(sv);
                Console.WriteLine("Thêm sinh viên thành công!");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Lỗi dữ liệu: {ex.ParamName}"); // Lỗi điểm < 0 hoặc > 10[cite: 1]
            }
            catch (FormatException)
            {
                Console.WriteLine("Lỗi: Nhập sai định dạng ngày tháng hoặc số!"); // Lỗi kiểu dữ liệu[cite: 1]
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi: {ex.Message}"); // Lỗi trùng mã SV[cite: 1]
            }
        }

        static void FuncXuatDanhSach(List<SinhVien> list)
        {
            if (list.Count == 0)
            {
                Console.WriteLine("Danh sách trống!");
                return;
            }
            Console.WriteLine("\n--- DANH SÁCH SINH VIÊN ---");
            foreach (var sv in list)
            {
                Console.WriteLine(sv.LayThongTin());
            }
        }

        static void FuncTimTheoMa()
        {
            Console.Write("Nhập mã sinh viên cần tìm: ");
            string ma = Console.ReadLine();
            SinhVien sv = qlsv.TimTheoMa(ma);
            if (sv != null)
                Console.WriteLine(sv.LayThongTin());
            else
                Console.WriteLine("Không tìm thấy sinh viên!");
        }

        static void FuncTimTheoTen()
        {
            Console.Write("Nhập từ khóa họ tên: ");
            string tuKhoa = Console.ReadLine();
            List<SinhVien> kq = qlsv.TimTheoTen(tuKhoa);
            if (kq.Count > 0)
                FuncXuatDanhSach(kq);
            else
                Console.WriteLine("Không tìm thấy sinh viên nào khớp với từ khóa!");
        }

        static void FuncSuaDiem()
        {
            Console.Write("Nhập mã sinh viên cần sửa điểm: ");
            string ma = Console.ReadLine();
            
            if (qlsv.TimTheoMa(ma) == null)
            {
                Console.WriteLine("Không tìm thấy mã sinh viên này!");
                return;
            }

            try
            {
                Console.Write("Nhập điểm mới: ");
                double diemMoi = double.Parse(Console.ReadLine());
                if (qlsv.SuaDiem(ma, diemMoi))
                    Console.WriteLine("Cập nhật điểm thành công!");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Lỗi: Điểm trung bình phải từ 0 đến 10.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Lỗi: Vui lòng nhập số!");
            }
        }

        static void FuncXoaSinhVien()
        {
            Console.Write("Nhập mã sinh viên cần xóa: ");
            string ma = Console.ReadLine();
            if (qlsv.Xoa(ma))
                Console.WriteLine("Xóa thành công!");
            else
                Console.WriteLine("Không tìm thấy mã sinh viên để xóa!");
        }
    }
}