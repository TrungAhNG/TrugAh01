namespace ProductManager
{
    partial class FrmProduct
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProduct));
            mnuMain = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            quảnLýToolStripMenuItem = new ToolStripMenuItem();
            mnuXoa = new ToolStripMenuItem();
            trợGiúpToolStripMenuItem = new ToolStripMenuItem();
            tsMain = new ToolStrip();
            tsbThem = new ToolStripButton();
            tsbSua = new ToolStripButton();
            tsbXoa = new ToolStripButton();
            tsbLamMoi = new ToolStripButton();
            tsbTim = new ToolStripButton();
            toolStripLabel1 = new ToolStripLabel();
            tsbXuatFile = new ToolStripButton();
            statusMain = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            lblTongSo = new ToolStripStatusLabel();
            gbThongTin = new GroupBox();
            btnChonAnh = new Button();
            label7 = new Label();
            picSanPham = new PictureBox();
            chkConKinhDoanh = new CheckBox();
            label6 = new Label();
            dtpNgayNhap = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            numSoLuong = new NumericUpDown();
            numDonGia = new NumericUpDown();
            cboLoaiSP = new ComboBox();
            txtTenSP = new TextBox();
            txtMaSP = new TextBox();
            dgvProducts = new DataGridView();
            ctxGrid = new ContextMenuStrip(components);
            ctxXoa = new ToolStripMenuItem();
            errorProvider1 = new ErrorProvider(components);
            tsbSapXep = new ToolStripButton();
            toolStripLabel2 = new ToolStripLabel();
            mnuMain.SuspendLayout();
            tsMain.SuspendLayout();
            statusMain.SuspendLayout();
            gbThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picSanPham).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDonGia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            ctxGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // mnuMain
            // 
            mnuMain.ImageScalingSize = new Size(20, 20);
            mnuMain.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, quảnLýToolStripMenuItem, trợGiúpToolStripMenuItem });
            mnuMain.Location = new Point(0, 0);
            mnuMain.Name = "mnuMain";
            mnuMain.Size = new Size(821, 28);
            mnuMain.TabIndex = 0;
            mnuMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // quảnLýToolStripMenuItem
            // 
            quảnLýToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuXoa });
            quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            quảnLýToolStripMenuItem.Size = new Size(73, 24);
            quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // mnuXoa
            // 
            mnuXoa.Name = "mnuXoa";
            mnuXoa.Size = new Size(118, 26);
            mnuXoa.Text = "Xóa";
            mnuXoa.Click += mnuXoa_Click;
            // 
            // trợGiúpToolStripMenuItem
            // 
            trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            trợGiúpToolStripMenuItem.Size = new Size(78, 24);
            trợGiúpToolStripMenuItem.Text = "Trợ giúp";
            // 
            // tsMain
            // 
            tsMain.ImageScalingSize = new Size(20, 20);
            tsMain.Items.AddRange(new ToolStripItem[] { tsbThem, tsbSua, tsbXoa, tsbLamMoi, tsbTim, tsbXuatFile, toolStripLabel1, tsbSapXep, toolStripLabel2 });
            tsMain.Location = new Point(0, 28);
            tsMain.Name = "tsMain";
            tsMain.Size = new Size(821, 27);
            tsMain.TabIndex = 1;
            tsMain.Text = "toolStrip1";
            // 
            // tsbThem
            // 
            tsbThem.Image = (Image)resources.GetObject("tsbThem.Image");
            tsbThem.ImageTransparentColor = Color.Magenta;
            tsbThem.Name = "tsbThem";
            tsbThem.Size = new Size(70, 24);
            tsbThem.Text = "Thêm";
            tsbThem.Click += tsbThem_Click;
            // 
            // tsbSua
            // 
            tsbSua.Image = (Image)resources.GetObject("tsbSua.Image");
            tsbSua.ImageTransparentColor = Color.Magenta;
            tsbSua.Name = "tsbSua";
            tsbSua.Size = new Size(58, 24);
            tsbSua.Text = "Sửa";
            tsbSua.Click += tsbSua_Click;
            // 
            // tsbXoa
            // 
            tsbXoa.Image = (Image)resources.GetObject("tsbXoa.Image");
            tsbXoa.ImageTransparentColor = Color.Magenta;
            tsbXoa.Name = "tsbXoa";
            tsbXoa.Size = new Size(59, 24);
            tsbXoa.Text = "Xóa";
            tsbXoa.Click += tsbXoa_Click;
            // 
            // tsbLamMoi
            // 
            tsbLamMoi.Image = (Image)resources.GetObject("tsbLamMoi.Image");
            tsbLamMoi.ImageTransparentColor = Color.Magenta;
            tsbLamMoi.Name = "tsbLamMoi";
            tsbLamMoi.Size = new Size(91, 24);
            tsbLamMoi.Text = "Làm mới";
            tsbLamMoi.Click += tsbLamMoi_Click;
            // 
            // tsbTim
            // 
            tsbTim.Image = (Image)resources.GetObject("tsbTim.Image");
            tsbTim.ImageTransparentColor = Color.Magenta;
            tsbTim.Name = "tsbTim";
            tsbTim.Size = new Size(58, 24);
            tsbTim.Text = "Tìm";
            tsbTim.Click += tsbTim_Click;
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(64, 24);
            toolStripLabel1.Text = "Xuất file";
            // 
            // tsbXuatFile
            // 
            tsbXuatFile.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbXuatFile.Image = (Image)resources.GetObject("tsbXuatFile.Image");
            tsbXuatFile.ImageTransparentColor = Color.Magenta;
            tsbXuatFile.Name = "tsbXuatFile";
            tsbXuatFile.Size = new Size(29, 24);
            tsbXuatFile.Text = "toolStripButton1";
            tsbXuatFile.Click += tsbXuatFile_Click;
            // 
            // statusMain
            // 
            statusMain.ImageScalingSize = new Size(20, 20);
            statusMain.Items.AddRange(new ToolStripItem[] { lblStatus, lblTongSo });
            statusMain.Location = new Point(0, 424);
            statusMain.Name = "statusMain";
            statusMain.Size = new Size(821, 26);
            statusMain.TabIndex = 2;
            statusMain.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(68, 20);
            lblStatus.Text = "Sẵn sàng";
            // 
            // lblTongSo
            // 
            lblTongSo.Name = "lblTongSo";
            lblTongSo.Size = new Size(77, 20);
            lblTongSo.Text = "Tổng số: 0";
            // 
            // gbThongTin
            // 
            gbThongTin.Controls.Add(btnChonAnh);
            gbThongTin.Controls.Add(label7);
            gbThongTin.Controls.Add(picSanPham);
            gbThongTin.Controls.Add(chkConKinhDoanh);
            gbThongTin.Controls.Add(label6);
            gbThongTin.Controls.Add(dtpNgayNhap);
            gbThongTin.Controls.Add(label5);
            gbThongTin.Controls.Add(label4);
            gbThongTin.Controls.Add(label3);
            gbThongTin.Controls.Add(label2);
            gbThongTin.Controls.Add(label1);
            gbThongTin.Controls.Add(numSoLuong);
            gbThongTin.Controls.Add(numDonGia);
            gbThongTin.Controls.Add(cboLoaiSP);
            gbThongTin.Controls.Add(txtTenSP);
            gbThongTin.Controls.Add(txtMaSP);
            gbThongTin.Location = new Point(12, 70);
            gbThongTin.Name = "gbThongTin";
            gbThongTin.Size = new Size(387, 351);
            gbThongTin.TabIndex = 3;
            gbThongTin.TabStop = false;
            gbThongTin.Text = "Thông tin sản phẩm";
            // 
            // btnChonAnh
            // 
            btnChonAnh.Location = new Point(257, 268);
            btnChonAnh.Name = "btnChonAnh";
            btnChonAnh.Size = new Size(94, 29);
            btnChonAnh.TabIndex = 16;
            btnChonAnh.Text = "Chọn ảnh...";
            btnChonAnh.UseVisualStyleBackColor = true;
            btnChonAnh.Click += btnChonAnh_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 272);
            label7.Name = "label7";
            label7.Size = new Size(114, 20);
            label7.TabIndex = 15;
            label7.Text = "Ảnh sản phẩm : ";
            // 
            // picSanPham
            // 
            picSanPham.BorderStyle = BorderStyle.FixedSingle;
            picSanPham.Location = new Point(126, 251);
            picSanPham.Name = "picSanPham";
            picSanPham.Size = new Size(125, 62);
            picSanPham.SizeMode = PictureBoxSizeMode.Zoom;
            picSanPham.TabIndex = 14;
            picSanPham.TabStop = false;
            // 
            // chkConKinhDoanh
            // 
            chkConKinhDoanh.AutoSize = true;
            chkConKinhDoanh.Location = new Point(6, 221);
            chkConKinhDoanh.Name = "chkConKinhDoanh";
            chkConKinhDoanh.Size = new Size(134, 24);
            chkConKinhDoanh.TabIndex = 13;
            chkConKinhDoanh.Text = "Còn kinh doanh";
            chkConKinhDoanh.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 195);
            label6.Name = "label6";
            label6.Size = new Size(92, 20);
            label6.TabIndex = 12;
            label6.Text = "Ngày nhập : ";
            // 
            // dtpNgayNhap
            // 
            dtpNgayNhap.Format = DateTimePickerFormat.Short;
            dtpNgayNhap.Location = new Point(126, 188);
            dtpNgayNhap.Name = "dtpNgayNhap";
            dtpNgayNhap.Size = new Size(250, 27);
            dtpNgayNhap.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 162);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 10;
            label5.Text = "Số lượng : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 132);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 9;
            label4.Text = "Đơn giá : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 98);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 8;
            label3.Text = "Loại sản phẩm : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 64);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 7;
            label2.Text = "Tên sản phẩm : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 33);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 6;
            label1.Text = "Mã sản phẩm : ";
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(126, 155);
            numSoLuong.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(150, 27);
            numSoLuong.TabIndex = 4;
            // 
            // numDonGia
            // 
            numDonGia.Location = new Point(126, 125);
            numDonGia.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numDonGia.Name = "numDonGia";
            numDonGia.Size = new Size(150, 27);
            numDonGia.TabIndex = 4;
            // 
            // cboLoaiSP
            // 
            cboLoaiSP.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLoaiSP.FormattingEnabled = true;
            cboLoaiSP.Location = new Point(126, 90);
            cboLoaiSP.Name = "cboLoaiSP";
            cboLoaiSP.Size = new Size(151, 28);
            cboLoaiSP.TabIndex = 4;
            // 
            // txtTenSP
            // 
            txtTenSP.Location = new Point(126, 57);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(125, 27);
            txtTenSP.TabIndex = 5;
            // 
            // txtMaSP
            // 
            txtMaSP.Location = new Point(126, 26);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(125, 27);
            txtMaSP.TabIndex = 4;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.ContextMenuStrip = ctxGrid;
            dgvProducts.Location = new Point(405, 70);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(404, 351);
            dgvProducts.TabIndex = 4;
            dgvProducts.CellClick += dgvProducts_CellClick;
            // 
            // ctxGrid
            // 
            ctxGrid.ImageScalingSize = new Size(20, 20);
            ctxGrid.Items.AddRange(new ToolStripItem[] { ctxXoa });
            ctxGrid.Name = "ctxGrid";
            ctxGrid.Size = new Size(105, 28);
            // 
            // ctxXoa
            // 
            ctxXoa.Name = "ctxXoa";
            ctxXoa.Size = new Size(104, 24);
            ctxXoa.Text = "Xóa";
            ctxXoa.Click += ctxXoa_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // tsbSapXep
            // 
            tsbSapXep.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbSapXep.Image = (Image)resources.GetObject("tsbSapXep.Image");
            tsbSapXep.ImageTransparentColor = Color.Magenta;
            tsbSapXep.Name = "tsbSapXep";
            tsbSapXep.Size = new Size(29, 24);
            tsbSapXep.Text = "toolStripButton1";
            tsbSapXep.Click += tsbSapXep_Click;
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(62, 24);
            toolStripLabel2.Text = "Sắp xếp";
            // 
            // FrmProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 450);
            Controls.Add(dgvProducts);
            Controls.Add(gbThongTin);
            Controls.Add(statusMain);
            Controls.Add(tsMain);
            Controls.Add(mnuMain);
            MainMenuStrip = mnuMain;
            Name = "FrmProduct";
            Text = "Quản lý sản phẩm";
            Load += FrmProduct_Load;
            mnuMain.ResumeLayout(false);
            mnuMain.PerformLayout();
            tsMain.ResumeLayout(false);
            tsMain.PerformLayout();
            statusMain.ResumeLayout(false);
            statusMain.PerformLayout();
            gbThongTin.ResumeLayout(false);
            gbThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picSanPham).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDonGia).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ctxGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnuMain;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem quảnLýToolStripMenuItem;
        private ToolStripMenuItem mnuXoa;
        private ToolStripMenuItem trợGiúpToolStripMenuItem;
        private ToolStrip tsMain;
        private ToolStripButton tsbThem;
        private ToolStripButton tsbSua;
        private ToolStripButton tsbXoa;
        private ToolStripButton tsbLamMoi;
        private ToolStripButton tsbTim;
        private StatusStrip statusMain;
        private ToolStripStatusLabel lblStatus;
        private ToolStripStatusLabel lblTongSo;
        private GroupBox gbThongTin;
        public ComboBox cboLoaiSP;
        private TextBox txtTenSP;
        private TextBox txtMaSP;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private NumericUpDown numSoLuong;
        private NumericUpDown numDonGia;
        private CheckBox chkConKinhDoanh;
        private Label label6;
        private DateTimePicker dtpNgayNhap;
        private PictureBox picSanPham;
        private Label label7;
        private Button btnChonAnh;
        private DataGridView dgvProducts;
        private ContextMenuStrip ctxGrid;
        private ToolStripMenuItem ctxXoa;
        private ErrorProvider errorProvider1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripButton tsbXuatFile;
        private ToolStripButton tsbSapXep;
        private ToolStripLabel toolStripLabel2;
    }
}