namespace QuanLyBaoHiem
{
    partial class ucTkKhachHang
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
            this.MaCD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaGoiHD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ngaysinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GioiTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Sdt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HinhAnh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnHienThi = new DevExpress.XtraEditors.SimpleButton();
            this.txtTenKH = new DevExpress.XtraEditors.TextEdit();
            this.radCMND = new System.Windows.Forms.RadioButton();
            this.radMaKH = new System.Windows.Forms.RadioButton();
            this.radSdt = new System.Windows.Forms.RadioButton();
            this.radTenKH = new System.Windows.Forms.RadioButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnTim = new DevExpress.XtraEditors.SimpleButton();
            this.txtSdt = new DevExpress.XtraEditors.TextEdit();
            this.txtMaKH = new DevExpress.XtraEditors.TextEdit();
            this.txtCMND = new DevExpress.XtraEditors.TextEdit();
            this.TenNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSdt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCMND.Properties)).BeginInit();
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
            this.dgvDanhSach.TabIndex = 8;
            this.dgvDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaCD,
            this.MaGoiHD,
            this.MaKH,
            this.Ngaysinh,
            this.GioiTinh,
            this.Sdt,
            this.CMND,
            this.DiaChi,
            this.HinhAnh});
            this.gridView1.GridControl = this.dgvDanhSach;
            this.gridView1.Name = "gridView1";
            // 
            // MaCD
            // 
            this.MaCD.Caption = "Mã cấp độ";
            this.MaCD.FieldName = "MaCD";
            this.MaCD.Name = "MaCD";
            this.MaCD.Visible = true;
            this.MaCD.VisibleIndex = 2;
            this.MaCD.Width = 71;
            // 
            // MaGoiHD
            // 
            this.MaGoiHD.Caption = "Tên khách hàng";
            this.MaGoiHD.FieldName = "TenKH";
            this.MaGoiHD.Name = "MaGoiHD";
            this.MaGoiHD.Visible = true;
            this.MaGoiHD.VisibleIndex = 1;
            this.MaGoiHD.Width = 93;
            // 
            // MaKH
            // 
            this.MaKH.Caption = "Mã khách hàng";
            this.MaKH.FieldName = "MaKH";
            this.MaKH.Name = "MaKH";
            this.MaKH.Visible = true;
            this.MaKH.VisibleIndex = 0;
            this.MaKH.Width = 93;
            // 
            // Ngaysinh
            // 
            this.Ngaysinh.Caption = "Ngày sinh";
            this.Ngaysinh.FieldName = "Ngaysinh";
            this.Ngaysinh.Name = "Ngaysinh";
            this.Ngaysinh.Visible = true;
            this.Ngaysinh.VisibleIndex = 3;
            this.Ngaysinh.Width = 96;
            // 
            // GioiTinh
            // 
            this.GioiTinh.Caption = "Giới tính";
            this.GioiTinh.FieldName = "GioiTinh";
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Visible = true;
            this.GioiTinh.VisibleIndex = 4;
            this.GioiTinh.Width = 96;
            // 
            // Sdt
            // 
            this.Sdt.Caption = "Số điện thoại";
            this.Sdt.FieldName = "Sdt";
            this.Sdt.Name = "Sdt";
            this.Sdt.Visible = true;
            this.Sdt.VisibleIndex = 5;
            this.Sdt.Width = 96;
            // 
            // CMND
            // 
            this.CMND.Caption = "Chứng minh nhân dân";
            this.CMND.FieldName = "CMND";
            this.CMND.Name = "CMND";
            this.CMND.Visible = true;
            this.CMND.VisibleIndex = 6;
            this.CMND.Width = 102;
            // 
            // DiaChi
            // 
            this.DiaChi.Caption = "Địa chỉ";
            this.DiaChi.FieldName = "DiaChi";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Visible = true;
            this.DiaChi.VisibleIndex = 7;
            this.DiaChi.Width = 93;
            // 
            // HinhAnh
            // 
            this.HinhAnh.Caption = "Hình ảnh";
            this.HinhAnh.FieldName = "HìnhAnh";
            this.HinhAnh.Name = "HinhAnh";
            this.HinhAnh.Visible = true;
            this.HinhAnh.VisibleIndex = 8;
            this.HinhAnh.Width = 102;
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.btnHienThi);
            this.groupControl1.Controls.Add(this.txtTenKH);
            this.groupControl1.Controls.Add(this.radCMND);
            this.groupControl1.Controls.Add(this.radMaKH);
            this.groupControl1.Controls.Add(this.radSdt);
            this.groupControl1.Controls.Add(this.radTenKH);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.btnHuy);
            this.groupControl1.Controls.Add(this.btnTim);
            this.groupControl1.Controls.Add(this.txtSdt);
            this.groupControl1.Controls.Add(this.txtMaKH);
            this.groupControl1.Controls.Add(this.txtCMND);
            this.groupControl1.Location = new System.Drawing.Point(20, 25);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(860, 179);
            this.groupControl1.TabIndex = 7;
            this.groupControl1.Text = "Nhập các thông tin";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
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
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(369, 59);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(250, 20);
            this.txtTenKH.TabIndex = 37;
            // 
            // radCMND
            // 
            this.radCMND.AutoSize = true;
            this.radCMND.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCMND.Location = new System.Drawing.Point(216, 114);
            this.radCMND.Name = "radCMND";
            this.radCMND.Size = new System.Drawing.Size(150, 20);
            this.radCMND.TabIndex = 32;
            this.radCMND.TabStop = true;
            this.radCMND.Text = "Chứng minh nhân dân";
            this.radCMND.UseVisualStyleBackColor = true;
            // 
            // radMaKH
            // 
            this.radMaKH.AutoSize = true;
            this.radMaKH.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMaKH.Location = new System.Drawing.Point(216, 31);
            this.radMaKH.Name = "radMaKH";
            this.radMaKH.Size = new System.Drawing.Size(113, 20);
            this.radMaKH.TabIndex = 31;
            this.radMaKH.TabStop = true;
            this.radMaKH.Text = "Mã khách hàng";
            this.radMaKH.UseVisualStyleBackColor = true;
            // 
            // radSdt
            // 
            this.radSdt.AutoSize = true;
            this.radSdt.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSdt.Location = new System.Drawing.Point(216, 88);
            this.radSdt.Name = "radSdt";
            this.radSdt.Size = new System.Drawing.Size(99, 20);
            this.radSdt.TabIndex = 30;
            this.radSdt.TabStop = true;
            this.radSdt.Text = "Số điện thoại";
            this.radSdt.UseVisualStyleBackColor = true;
            // 
            // radTenKH
            // 
            this.radTenKH.AutoSize = true;
            this.radTenKH.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTenKH.Location = new System.Drawing.Point(216, 59);
            this.radTenKH.Name = "radTenKH";
            this.radTenKH.Size = new System.Drawing.Size(115, 20);
            this.radTenKH.TabIndex = 29;
            this.radTenKH.TabStop = true;
            this.radTenKH.Text = "Tên khách hàng";
            this.radTenKH.UseVisualStyleBackColor = true;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(14, 33);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(202, 15);
            this.labelControl1.TabIndex = 27;
            this.labelControl1.Text = "Tìm kiếm thông tin khách hàng theo:";
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
            // txtSdt
            // 
            this.txtSdt.EditValue = "";
            this.txtSdt.Location = new System.Drawing.Point(369, 88);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Properties.NullText = "[EditValue is null]";
            this.txtSdt.Size = new System.Drawing.Size(250, 20);
            this.txtSdt.TabIndex = 38;
            // 
            // txtMaKH
            // 
            this.txtMaKH.EditValue = "";
            this.txtMaKH.Location = new System.Drawing.Point(369, 31);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Properties.NullText = "[EditValue is null]";
            this.txtMaKH.Size = new System.Drawing.Size(250, 20);
            this.txtMaKH.TabIndex = 39;
            // 
            // txtCMND
            // 
            this.txtCMND.EditValue = "";
            this.txtCMND.Location = new System.Drawing.Point(369, 114);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Properties.NullText = "[EditValue is null]";
            this.txtCMND.Size = new System.Drawing.Size(250, 20);
            this.txtCMND.TabIndex = 40;
            this.txtCMND.EditValueChanged += new System.EventHandler(this.txtTheLoai_EditValueChanged);
            // 
            // TenNV
            // 
            this.TenNV.Caption = "Tên nhân viên";
            this.TenNV.FieldName = "TenNV";
            this.TenNV.Name = "TenNV";
            this.TenNV.Visible = true;
            this.TenNV.VisibleIndex = 0;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã gói HĐ";
            this.gridColumn1.FieldName = "MaGoiHD";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Mã gói HĐ";
            this.gridColumn2.FieldName = "MaGoiHD";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Mã gói HĐ";
            this.gridColumn3.FieldName = "MaGoiHD";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // TenKH
            // 
            this.TenKH.Caption = "Tên khách hàng";
            this.TenKH.FieldName = "TenKH";
            this.TenKH.Name = "TenKH";
            this.TenKH.Visible = true;
            this.TenKH.VisibleIndex = 3;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Tên khách hàng";
            this.gridColumn4.FieldName = "TenKH";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Tên khách hàng";
            this.gridColumn5.FieldName = "TenKH";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            // 
            // ucTkKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvDanhSach);
            this.Controls.Add(this.groupControl1);
            this.Name = "ucTkKhachHang";
            this.Size = new System.Drawing.Size(900, 500);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSdt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCMND.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgvDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MaCD;
        private DevExpress.XtraGrid.Columns.GridColumn MaGoiHD;
        private DevExpress.XtraGrid.Columns.GridColumn MaKH;
        private DevExpress.XtraGrid.Columns.GridColumn Ngaysinh;
        private DevExpress.XtraGrid.Columns.GridColumn GioiTinh;
        private DevExpress.XtraGrid.Columns.GridColumn Sdt;
        private DevExpress.XtraGrid.Columns.GridColumn CMND;
        private DevExpress.XtraGrid.Columns.GridColumn DiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn HinhAnh;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnHienThi;
        private DevExpress.XtraEditors.TextEdit txtTenKH;
        private System.Windows.Forms.RadioButton radCMND;
        private System.Windows.Forms.RadioButton radMaKH;
        private System.Windows.Forms.RadioButton radSdt;
        private System.Windows.Forms.RadioButton radTenKH;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnTim;
        private DevExpress.XtraEditors.TextEdit txtSdt;
        private DevExpress.XtraEditors.TextEdit txtMaKH;
        private DevExpress.XtraEditors.TextEdit txtCMND;
        private DevExpress.XtraGrid.Columns.GridColumn TenNV;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn TenKH;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
    }
}
