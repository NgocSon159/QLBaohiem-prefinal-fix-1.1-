namespace QuanLyBaoHiem
{
    partial class ucTkThongTin
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
            this.dgvDanhSach = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaHD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaGoiHD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaChuKy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ThoiHanHD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayHieuLucHD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MucPhi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaTriBaoHiem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ThoiGianChuKy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnHienThi = new DevExpress.XtraEditors.SimpleButton();
            this.txtTenSach = new DevExpress.XtraEditors.TextEdit();
            this.txtMaSach = new DevExpress.XtraEditors.TextEdit();
            this.radMaChuKy = new System.Windows.Forms.RadioButton();
            this.radMaKH = new System.Windows.Forms.RadioButton();
            this.radMaNV = new System.Windows.Forms.RadioButton();
            this.radMaGoiHD = new System.Windows.Forms.RadioButton();
            this.radMaHD = new System.Windows.Forms.RadioButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnTim = new DevExpress.XtraEditors.SimpleButton();
            this.txtNXB = new DevExpress.XtraEditors.TextEdit();
            this.txtTacGia = new DevExpress.XtraEditors.TextEdit();
            this.txtTheLoai = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSach.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSach.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNXB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTacGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTheLoai.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDanhSach.Location = new System.Drawing.Point(20, 210);
            this.dgvDanhSach.MainView = this.gridView1;
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.Size = new System.Drawing.Size(860, 265);
            this.dgvDanhSach.TabIndex = 6;
            this.dgvDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaHD,
            this.MaGoiHD,
            this.TenNV,
            this.TenKH,
            this.MaChuKy,
            this.ThoiHanHD,
            this.NgayHieuLucHD,
            this.MucPhi,
            this.GiaTriBaoHiem,
            this.ThoiGianChuKy});
            this.gridView1.GridControl = this.dgvDanhSach;
            this.gridView1.Name = "gridView1";
            // 
            // MaHD
            // 
            this.MaHD.Caption = "Mã hợp đồng";
            this.MaHD.FieldName = "MaHD";
            this.MaHD.Name = "MaHD";
            this.MaHD.Visible = true;
            this.MaHD.VisibleIndex = 0;
            // 
            // MaGoiHD
            // 
            this.MaGoiHD.Caption = "Mã gói HĐ";
            this.MaGoiHD.FieldName = "MaGoiHD";
            this.MaGoiHD.Name = "MaGoiHD";
            this.MaGoiHD.Visible = true;
            this.MaGoiHD.VisibleIndex = 1;
            // 
            // TenNV
            // 
            this.TenNV.Caption = "Tên nhân viên";
            this.TenNV.FieldName = "TenNV";
            this.TenNV.Name = "TenNV";
            this.TenNV.Visible = true;
            this.TenNV.VisibleIndex = 2;
            // 
            // TenKH
            // 
            this.TenKH.Caption = "Tên khách hàng";
            this.TenKH.FieldName = "TenKH";
            this.TenKH.Name = "TenKH";
            this.TenKH.Visible = true;
            this.TenKH.VisibleIndex = 3;
            // 
            // MaChuKy
            // 
            this.MaChuKy.Caption = "Mã chu kỳ";
            this.MaChuKy.FieldName = "MaChuKy";
            this.MaChuKy.Name = "MaChuKy";
            this.MaChuKy.Visible = true;
            this.MaChuKy.VisibleIndex = 4;
            // 
            // ThoiHanHD
            // 
            this.ThoiHanHD.Caption = "Thời hạn HĐ";
            this.ThoiHanHD.FieldName = "ThoiHanHD";
            this.ThoiHanHD.Name = "ThoiHanHD";
            this.ThoiHanHD.Visible = true;
            this.ThoiHanHD.VisibleIndex = 5;
            // 
            // NgayHieuLucHD
            // 
            this.NgayHieuLucHD.Caption = "Ngày hiệu lực hợp đồng";
            this.NgayHieuLucHD.FieldName = "NgayHieuLucHD";
            this.NgayHieuLucHD.Name = "NgayHieuLucHD";
            this.NgayHieuLucHD.Visible = true;
            this.NgayHieuLucHD.VisibleIndex = 6;
            // 
            // MucPhi
            // 
            this.MucPhi.Caption = "Mức Phí";
            this.MucPhi.FieldName = "MucPhi";
            this.MucPhi.Name = "MucPhi";
            this.MucPhi.Visible = true;
            this.MucPhi.VisibleIndex = 7;
            // 
            // GiaTriBaoHiem
            // 
            this.GiaTriBaoHiem.Caption = "Giá trị bảo hiểm";
            this.GiaTriBaoHiem.FieldName = "GiaTriBaoHiem";
            this.GiaTriBaoHiem.Name = "GiaTriBaoHiem";
            this.GiaTriBaoHiem.Visible = true;
            this.GiaTriBaoHiem.VisibleIndex = 8;
            // 
            // ThoiGianChuKy
            // 
            this.ThoiGianChuKy.Caption = "Thời gian chu kỳ";
            this.ThoiGianChuKy.FieldName = "ThoiGianChuKy";
            this.ThoiGianChuKy.Name = "ThoiGianChuKy";
            this.ThoiGianChuKy.Visible = true;
            this.ThoiGianChuKy.VisibleIndex = 9;
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.btnHienThi);
            this.groupControl1.Controls.Add(this.txtTenSach);
            this.groupControl1.Controls.Add(this.txtMaSach);
            this.groupControl1.Controls.Add(this.radMaChuKy);
            this.groupControl1.Controls.Add(this.radMaKH);
            this.groupControl1.Controls.Add(this.radMaNV);
            this.groupControl1.Controls.Add(this.radMaGoiHD);
            this.groupControl1.Controls.Add(this.radMaHD);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.btnHuy);
            this.groupControl1.Controls.Add(this.btnTim);
            this.groupControl1.Controls.Add(this.txtNXB);
            this.groupControl1.Controls.Add(this.txtTacGia);
            this.groupControl1.Controls.Add(this.txtTheLoai);
            this.groupControl1.Location = new System.Drawing.Point(20, 25);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(860, 179);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "Nhập các thông tin";
            // 
            // btnHienThi
            // 
            this.btnHienThi.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienThi.Appearance.Options.UseFont = true;
            this.btnHienThi.ImageOptions.Image = global::QuanLyBaoHiem.Properties.Resources.find;
            this.btnHienThi.Location = new System.Drawing.Point(699, 76);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(126, 36);
            this.btnHienThi.TabIndex = 41;
            this.btnHienThi.Text = "Hiển thị Tất cả";
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(369, 59);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(250, 20);
            this.txtTenSach.TabIndex = 37;
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(369, 31);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(250, 20);
            this.txtMaSach.TabIndex = 36;
            // 
            // radMaChuKy
            // 
            this.radMaChuKy.AutoSize = true;
            this.radMaChuKy.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMaChuKy.Location = new System.Drawing.Point(216, 146);
            this.radMaChuKy.Name = "radMaChuKy";
            this.radMaChuKy.Size = new System.Drawing.Size(89, 20);
            this.radMaChuKy.TabIndex = 32;
            this.radMaChuKy.TabStop = true;
            this.radMaChuKy.Text = "Mã Chu Kỳ";
            this.radMaChuKy.UseVisualStyleBackColor = true;
            // 
            // radMaKH
            // 
            this.radMaKH.AutoSize = true;
            this.radMaKH.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMaKH.Location = new System.Drawing.Point(216, 117);
            this.radMaKH.Name = "radMaKH";
            this.radMaKH.Size = new System.Drawing.Size(113, 20);
            this.radMaKH.TabIndex = 31;
            this.radMaKH.TabStop = true;
            this.radMaKH.Text = "Mã khách hàng";
            this.radMaKH.UseVisualStyleBackColor = true;
            // 
            // radMaNV
            // 
            this.radMaNV.AutoSize = true;
            this.radMaNV.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMaNV.Location = new System.Drawing.Point(216, 88);
            this.radMaNV.Name = "radMaNV";
            this.radMaNV.Size = new System.Drawing.Size(102, 20);
            this.radMaNV.TabIndex = 30;
            this.radMaNV.TabStop = true;
            this.radMaNV.Text = "Mã nhân viên";
            this.radMaNV.UseVisualStyleBackColor = true;
            // 
            // radMaGoiHD
            // 
            this.radMaGoiHD.AutoSize = true;
            this.radMaGoiHD.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMaGoiHD.Location = new System.Drawing.Point(216, 59);
            this.radMaGoiHD.Name = "radMaGoiHD";
            this.radMaGoiHD.Size = new System.Drawing.Size(88, 20);
            this.radMaGoiHD.TabIndex = 29;
            this.radMaGoiHD.TabStop = true;
            this.radMaGoiHD.Text = "Mã gói HĐ";
            this.radMaGoiHD.UseVisualStyleBackColor = true;
            // 
            // radMaHD
            // 
            this.radMaHD.AutoSize = true;
            this.radMaHD.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMaHD.Location = new System.Drawing.Point(216, 31);
            this.radMaHD.Name = "radMaHD";
            this.radMaHD.Size = new System.Drawing.Size(100, 20);
            this.radMaHD.TabIndex = 28;
            this.radMaHD.TabStop = true;
            this.radMaHD.Text = "Mã hợp đồng";
            this.radMaHD.UseVisualStyleBackColor = true;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(14, 33);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(187, 15);
            this.labelControl1.TabIndex = 27;
            this.labelControl1.Text = "Tìm kiếm thông tin hợp đồng theo:";
            // 
            // btnHuy
            // 
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.ImageOptions.Image = global::QuanLyBaoHiem.Properties.Resources.cancel32;
            this.btnHuy.Location = new System.Drawing.Point(699, 120);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(126, 36);
            this.btnHuy.TabIndex = 7;
            this.btnHuy.Text = "Hủy bỏ";
            // 
            // btnTim
            // 
            this.btnTim.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Appearance.Options.UseFont = true;
            this.btnTim.ImageOptions.Image = global::QuanLyBaoHiem.Properties.Resources.search;
            this.btnTim.Location = new System.Drawing.Point(699, 34);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(126, 36);
            this.btnTim.TabIndex = 6;
            this.btnTim.Text = "Tìm Kiếm";
            // 
            // txtNXB
            // 
            this.txtNXB.EditValue = "";
            this.txtNXB.Location = new System.Drawing.Point(369, 88);
            this.txtNXB.Name = "txtNXB";
            this.txtNXB.Properties.NullText = "[EditValue is null]";
            this.txtNXB.Size = new System.Drawing.Size(250, 20);
            this.txtNXB.TabIndex = 38;
            // 
            // txtTacGia
            // 
            this.txtTacGia.EditValue = "";
            this.txtTacGia.Location = new System.Drawing.Point(369, 117);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Properties.NullText = "[EditValue is null]";
            this.txtTacGia.Size = new System.Drawing.Size(250, 20);
            this.txtTacGia.TabIndex = 39;
            // 
            // txtTheLoai
            // 
            this.txtTheLoai.EditValue = "";
            this.txtTheLoai.Location = new System.Drawing.Point(369, 146);
            this.txtTheLoai.Name = "txtTheLoai";
            this.txtTheLoai.Properties.NullText = "[EditValue is null]";
            this.txtTheLoai.Size = new System.Drawing.Size(250, 20);
            this.txtTheLoai.TabIndex = 40;
            // 
            // tkThongTin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvDanhSach);
            this.Controls.Add(this.groupControl1);
            this.Name = "tkThongTin";
            this.Size = new System.Drawing.Size(900, 500);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSach.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSach.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNXB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTacGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTheLoai.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgvDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnHienThi;
        private DevExpress.XtraEditors.TextEdit txtTenSach;
        private DevExpress.XtraEditors.TextEdit txtMaSach;
        private System.Windows.Forms.RadioButton radMaChuKy;
        private System.Windows.Forms.RadioButton radMaKH;
        private System.Windows.Forms.RadioButton radMaNV;
        private System.Windows.Forms.RadioButton radMaGoiHD;
        private System.Windows.Forms.RadioButton radMaHD;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnTim;
        private DevExpress.XtraGrid.Columns.GridColumn MaHD;
        private DevExpress.XtraGrid.Columns.GridColumn MaGoiHD;
        private DevExpress.XtraGrid.Columns.GridColumn TenNV;
        private DevExpress.XtraGrid.Columns.GridColumn TenKH;
        private DevExpress.XtraGrid.Columns.GridColumn MaChuKy;
        private DevExpress.XtraGrid.Columns.GridColumn ThoiHanHD;
        private DevExpress.XtraGrid.Columns.GridColumn NgayHieuLucHD;
        private DevExpress.XtraGrid.Columns.GridColumn MucPhi;
        private DevExpress.XtraGrid.Columns.GridColumn GiaTriBaoHiem;
        private DevExpress.XtraGrid.Columns.GridColumn ThoiGianChuKy;
        private DevExpress.XtraEditors.TextEdit txtNXB;
        private DevExpress.XtraEditors.TextEdit txtTacGia;
        private DevExpress.XtraEditors.TextEdit txtTheLoai;
    }
}
