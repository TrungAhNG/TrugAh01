using System;
using System.Collections.Generic;
using System.Text;

namespace ProductManager.Models
{
    public class Product
    {
        public string MaSP { get; set; } = string.Empty; //
        public string TenSP { get; set; } = string.Empty; //
        public string LoaiSP { get; set; } = string.Empty; //
        public decimal DonGia { get; set; } //
        public int SoLuong { get; set; } //
        public DateTime NgayNhap { get; set; } = DateTime.Now; //
        public bool ConKinhDoanh { get; set; } = true; //
        public string DuongDanAnh { get; set; } = string.Empty; //

        // Thuộc tính tự động tính toán (Read-only) hiển thị lên DataGridView
        public decimal ThanhTien => DonGia * SoLuong; //[cite: 2]
    }
}