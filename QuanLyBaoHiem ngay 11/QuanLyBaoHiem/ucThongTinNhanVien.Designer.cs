namespace QuanLyBaoHiem
{
    partial class ucThongTinNhanVien
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaCV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GioiTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MatKhau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoDienThoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaNVQL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.QuyenHan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ngaysinh = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(900, 500);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaNV,
            this.MaCV,
            this.TenNV,
            this.GioiTinh,
            this.Ngaysinh,
            this.MatKhau,
            this.SoDienThoai,
            this.DiaChi,
            this.MaNVQL,
            this.QuyenHan});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // MaNV
            // 
            this.MaNV.Caption = "Mã nhân viên";
            this.MaNV.FieldName = "MaNV";
            this.MaNV.Name = "MaNV";
            this.MaNV.Visible = true;
            this.MaNV.VisibleIndex = 0;
            // 
            // MaCV
            // 
            this.MaCV.Caption = "Mã chức vụ";
            this.MaCV.FieldName = "MaCV";
            this.MaCV.Name = "MaCV";
            this.MaCV.Visible = true;
            this.MaCV.VisibleIndex = 1;
            // 
            // TenNV
            // 
            this.TenNV.Caption = "Tên nhân viên";
            this.TenNV.FieldName = "TenNV";
            this.TenNV.Name = "TenNV";
            this.TenNV.Visible = true;
            this.TenNV.VisibleIndex = 2;
            // 
            // GioiTinh
            // 
            this.GioiTinh.Caption = "Giới tính";
            this.GioiTinh.FieldName = "GioiTinh";
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Visible = true;
            this.GioiTinh.VisibleIndex = 4;
            // 
            // MatKhau
            // 
            this.MatKhau.Caption = "Mật khẩu";
            this.MatKhau.FieldName = "MatKhau";
            this.MatKhau.Name = "MatKhau";
            this.MatKhau.Visible = true;
            this.MatKhau.VisibleIndex = 7;
            // 
            // SoDienThoai
            // 
            this.SoDienThoai.Caption = "Số điện thoại";
            this.SoDienThoai.FieldName = "SoDienThoai";
            this.SoDienThoai.Name = "SoDienThoai";
            this.SoDienThoai.Visible = true;
            this.SoDienThoai.VisibleIndex = 5;
            // 
            // DiaChi
            // 
            this.DiaChi.Caption = "Địa chỉ";
            this.DiaChi.FieldName = "DiaChi";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Visible = true;
            this.DiaChi.VisibleIndex = 6;
            // 
            // MaNVQL
            // 
            this.MaNVQL.Caption = "Mã Nhân Viên Quản Lý";
            this.MaNVQL.FieldName = "MaNVQL";
            this.MaNVQL.Name = "MaNVQL";
            this.MaNVQL.Visible = true;
            this.MaNVQL.VisibleIndex = 3;
            // 
            // QuyenHan
            // 
            this.QuyenHan.Caption = "Quyền Hạn";
            this.QuyenHan.FieldName = "QuyenHan";
            this.QuyenHan.Name = "QuyenHan";
            this.QuyenHan.Visible = true;
            this.QuyenHan.VisibleIndex = 8;
            // 
            // Ngaysinh
            // 
            this.Ngaysinh.Caption = "Ngày sinh";
            this.Ngaysinh.FieldName = "Ngaysinh";
            this.Ngaysinh.Name = "Ngaysinh";
            this.Ngaysinh.Visible = true;
            this.Ngaysinh.VisibleIndex = 9;
            // 
            // ucThongTinNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Name = "ucThongTinNhanVien";
            this.Size = new System.Drawing.Size(900, 500);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MaNV;
        private DevExpress.XtraGrid.Columns.GridColumn MaCV;
        private DevExpress.XtraGrid.Columns.GridColumn TenNV;
        private DevExpress.XtraGrid.Columns.GridColumn GioiTinh;
        private DevExpress.XtraGrid.Columns.GridColumn MatKhau;
        private DevExpress.XtraGrid.Columns.GridColumn SoDienThoai;
        private DevExpress.XtraGrid.Columns.GridColumn DiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn MaNVQL;
        private DevExpress.XtraGrid.Columns.GridColumn QuyenHan;
        private DevExpress.XtraGrid.Columns.GridColumn Ngaysinh;
    }
}
