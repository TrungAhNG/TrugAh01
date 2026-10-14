using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ProductManager.Models;

namespace ProductManager
{
    public partial class FrmProduct : Form
    {
        private BindingList<Product> products = new BindingList<Product>();
        private BindingSource productSource = new BindingSource();

        public FrmProduct()
        {
            InitializeComponent();
        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            cboLoaiSP.Items.Clear();
            cboLoaiSP.Items.AddRange(new string[] { "Điện tử", "Văn phòng", "Gia dụng", "Thời trang" });
            cboLoaiSP.SelectedIndex = 0;

            productSource.DataSource = products;
            dgvProducts.DataSource = productSource;

            if (dgvProducts.Columns["DonGia"] != null)
                dgvProducts.Columns["DonGia"].DefaultCellStyle.Format = "N0";
            if (dgvProducts.Columns["NgayNhap"] != null)
                dgvProducts.Columns["NgayNhap"].DefaultCellStyle.Format = "dd/MM/yyyy";

            UpdateStatus("Sẵn sàng");
        }

        private bool ValidateInput(bool isEditing = false)
        {
            errorProvider1.Clear();
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(txtMaSP.Text))
            {
                errorProvider1.SetError(txtMaSP, "Mã sản phẩm không được rỗng!");
                isValid = false;
            }
            else if (!isEditing && products.Any(p => p.MaSP.Equals(txtMaSP.Text.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                errorProvider1.SetError(txtMaSP, "Mã sản phẩm đã tồn tại!");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtTenSP.Text))
            {
                errorProvider1.SetError(txtTenSP, "Tên sản phẩm không được rỗng!");
                isValid = false;
            }

            if (numDonGia.Value <= 0)
            {
                errorProvider1.SetError(numDonGia, "Đơn giá phải lớn hơn 0!");
                isValid = false;
            }

            if (numSoLuong.Value < 0)
            {
                errorProvider1.SetError(numSoLuong, "Số lượng không được nhỏ hơn 0!");
                isValid = false;
            }

            if (dtpNgayNhap.Value.Date > DateTime.Now.Date)
            {
                errorProvider1.SetError(dtpNgayNhap, "Ngày nhập không được lớn hơn ngày hiện tại!");
                isValid = false;
            }

            return isValid;
        }

        private void UpdateStatus(string message)
        {
            lblStatus.Text = message;
            decimal tongGiaTri = products.Sum(p => p.ThanhTien);
            lblTongSo.Text = $"Tổng số: {products.Count} SP | Tổng tồn kho: {tongGiaTri:N0} VNĐ";
        }
        private void ClearInput()
        {
            errorProvider1.Clear();
            txtMaSP.Clear();
            txtTenSP.Clear();
            if (cboLoaiSP.Items.Count > 0) cboLoaiSP.SelectedIndex = 0;
            numDonGia.Value = 0;
            numSoLuong.Value = 0;
            dtpNgayNhap.Value = DateTime.Now;
            chkConKinhDoanh.Checked = true;
            picSanPham.Image = null;
            picSanPham.Tag = null;
            txtMaSP.ReadOnly = false;
            txtMaSP.Focus();
        }

        private void tsbThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInput(isEditing: false)) return;

                Product p = new Product
                {
                    MaSP = txtMaSP.Text.Trim(),
                    TenSP = txtTenSP.Text.Trim(),
                    LoaiSP = cboLoaiSP.Text,
                    DonGia = numDonGia.Value,
                    SoLuong = (int)numSoLuong.Value,
                    NgayNhap = dtpNgayNhap.Value,
                    ConKinhDoanh = chkConKinhDoanh.Checked,
                    DuongDanAnh = picSanPham.Tag?.ToString() ?? string.Empty
                };

                products.Add(p);
                UpdateStatus($"Đã thêm sản phẩm {p.TenSP} thành công!");
                ClearInput();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi hệ thống: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbSua_Click(object sender, EventArgs e)
        {
            if (productSource.Current is Product p)
            {
                if (!ValidateInput(isEditing: true)) return;

                p.TenSP = txtTenSP.Text.Trim();
                p.LoaiSP = cboLoaiSP.Text;
                p.DonGia = numDonGia.Value;
                p.SoLuong = (int)numSoLuong.Value;
                p.NgayNhap = dtpNgayNhap.Value;
                p.ConKinhDoanh = chkConKinhDoanh.Checked;
                p.DuongDanAnh = picSanPham.Tag?.ToString() ?? p.DuongDanAnh;

                productSource.ResetCurrentItem();
                UpdateStatus($"Đã cập nhật sản phẩm {p.MaSP} thành công!");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ThucHienXoa()
        {
            if (productSource.Current is Product p)
            {
                DialogResult dr = MessageBox.Show($"Bạn có chắc muốn xóa sản phẩm {p.TenSP} ({p.MaSP})?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    products.Remove(p);
                    UpdateStatus($"Đã xóa sản phẩm {p.MaSP} thành công!");
                    ClearInput();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tsbXoa_Click(object sender, EventArgs e) => ThucHienXoa();
        private void mnuXoa_Click(object sender, EventArgs e) => ThucHienXoa();
        private void ctxXoa_Click(object sender, EventArgs e) => ThucHienXoa();

        private void tsbLamMoi_Click(object sender, EventArgs e)
        {
            ClearInput();
            dgvProducts.DataSource = productSource;
            UpdateStatus("Đã làm mới dữ liệu.");
        }

        private void tsbTim_Click(object sender, EventArgs e)
        {
            string keyword = txtMaSP.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(keyword))
            {
                dgvProducts.DataSource = productSource;
                UpdateStatus("Hiển thị toàn bộ danh sách.");
                return;
            }

            var filtered = products.Where(p => p.MaSP.ToLower().Contains(keyword) || p.TenSP.ToLower().Contains(keyword)).ToList();
            dgvProducts.DataSource = filtered;
            UpdateStatus($"Tìm thấy {filtered.Count} sản phẩm.");
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Tệp hình ảnh (*.jpg; *.png)|*.jpg;*.png";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    picSanPham.Image = Image.FromFile(ofd.FileName);
                    picSanPham.Tag = ofd.FileName;
                    UpdateStatus("Đã chọn ảnh sản phẩm.");
                }
            }
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (productSource.Current is Product p)
            {
                txtMaSP.Text = p.MaSP;
                txtMaSP.ReadOnly = true;
                txtTenSP.Text = p.TenSP;
                cboLoaiSP.Text = p.LoaiSP;
                numDonGia.Value = p.DonGia;
                numSoLuong.Value = p.SoLuong;
                dtpNgayNhap.Value = p.NgayNhap;
                chkConKinhDoanh.Checked = p.ConKinhDoanh;

                if (!string.IsNullOrEmpty(p.DuongDanAnh) && File.Exists(p.DuongDanAnh))
                {
                    picSanPham.Image = Image.FromFile(p.DuongDanAnh);
                    picSanPham.Tag = p.DuongDanAnh;
                }
                else
                {
                    picSanPham.Image = null;
                    picSanPham.Tag = null;
                }
            }
        }

        private void tsbXuatFile_Click(object sender, EventArgs e)
        {
            if (products.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Text files (*.txt)|*.txt"; // Mở hộp thoại lưu file txt
                sfd.FileName = "DanhSachSanPham.txt";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(sfd.FileName))
                    {
                        sw.WriteLine("MÃ SP\tTÊN SẢN PHẨM\tLOẠI\tĐƠN GIÁ\tSỐ LƯỢNG\tTHÀNH TIỀN");
                        sw.WriteLine(new string('-', 80));

                        foreach (var p in products)
                        {
                            sw.WriteLine($"{p.MaSP}\t{p.TenSP}\t{p.LoaiSP}\t{p.DonGia}\t{p.SoLuong}\t{p.ThanhTien}");
                        }
                    }
                    UpdateStatus("Đã xuất danh sách ra file .txt thành công!");
                }
            }
        }

        private void tsbSapXep_Click(object sender, EventArgs e)
        {
            if (products.Count == 0) return;

            var sortedList = products.OrderByDescending(p => p.SoLuong).ThenBy(p => p.DonGia).ToList();

            products.Clear();
            foreach (var item in sortedList)
            {
                products.Add(item);
            }

            UpdateStatus("Đã sắp xếp danh sách theo Số lượng & Đơn giá.");
        }
    }
}