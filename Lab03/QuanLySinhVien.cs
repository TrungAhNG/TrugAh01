using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab03_QuanLySinhVienOOP
{
    public class QuanLySinhVien
    {
        private List<SinhVien> danhSach;

        public QuanLySinhVien()
        {
            danhSach = new List<SinhVien>();
        }

        // Lấy danh sách toàn bộ sinh viên
        public List<SinhVien> LayDanhSach()
        {
            return danhSach;
        }

        // 1. Thêm sinh viên (Kiểm tra mã trùng)
        public void Them(SinhVien sv)
        {
            if (danhSach.Any(s => s.MaSinhVien.Equals(sv.MaSinhVien, StringComparison.OrdinalIgnoreCase)))
            {
                throw new Exception("Mã sinh viên đã tồn tại!");
            }
            danhSach.Add(sv);
        }

        // 3. Tìm theo mã bằng LINQ
        public SinhVien TimTheoMa(string maSinhVien)
        {
            return danhSach.FirstOrDefault(s => s.MaSinhVien.Equals(maSinhVien, StringComparison.OrdinalIgnoreCase));
        }

        // 4. Tìm theo tên (chứa từ khóa) bằng LINQ
        public List<SinhVien> TimTheoTen(string tuKhoa)
        {
            return danhSach.Where(s => s.HoTen.IndexOf(tuKhoa, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
        }

        // 5. Sửa điểm
        public bool SuaDiem(string maSinhVien, double diemMoi)
        {
            SinhVien sv = TimTheoMa(maSinhVien);
            if (sv != null)
            {
                sv.DiemTrungBinh = diemMoi; // Tự động gọi property set để kiểm tra 0-10
                return true;
            }
            return false;
        }

        // 6. Xóa sinh viên
        public bool Xoa(string maSinhVien)
        {
            SinhVien sv = TimTheoMa(maSinhVien);
            if (sv != null)
            {
                danhSach.Remove(sv);
                return true;
            }
            return false;
        }

        // 7. Sắp xếp theo điểm giảm dần bằng LINQ[cite: 1]
        public List<SinhVien> SapXepTheoDiem()
        {
            return danhSach.OrderByDescending(s => s.DiemTrungBinh).ToList();
        }

        // 8. Lọc sinh viên đạt (Điểm >= 5) bằng LINQ
        public List<SinhVien> LayDanhSachDat()
        {
            return danhSach.Where(s => s.DiemTrungBinh >= 5.0).ToList();
        }
    }
}