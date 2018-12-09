using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.Entity;
using QuanLyBaoHiem.Models;
using QuanLyBaoHiem.DAO;

namespace QuanLyBaoHiem
{
    public partial class ucQuanLyChucVuNV : DevExpress.XtraEditors.XtraUserControl
    {
        QLBHContext db = new QLBHContext();
        List<ChucVu> listchucvu = new List<ChucVu>();
        List<NhanVien> listnvquanly = new List<NhanVien>();
        string macvhientai = "";

        public ucQuanLyChucVuNV()
        {
            InitializeComponent();
            loadcomboboxMaCVvaTenCV();
            loaddatabse();
            
        }
        public void loaddatabse()
        {
            QuanLyBaoHiem.Models.QLBHContext dbContext = new QuanLyBaoHiem.Models.QLBHContext();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.NhanViens.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                gridChucvu.DataSource = (from a in dbContext.NhanViens
                                          join b in dbContext.ChucVus
                                          on a.MaCV equals b.MaCV
                                          where a.Status==true && a.MaCV == "TP" || a.MaCV == "NV"
                                         
                                          select new
                                          {
                                              a.MaNV,
                                              a.TenNV,
                                              b.TenCV,
                                              a.MaCV,
                                              a.MaNVQuanLi
                                          }).ToList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        public void loadcomboboxMaCVvaTenCV()
        {
            listchucvu = db.ChucVus.Where(l => l.MaCV == "TP" || l.MaCV == "NV").ToList();
            listnvquanly = db.NhanViens.Where(p => p.Status == true && p.MaCV=="TP" || p.MaCV=="QL").ToList();
            
            foreach (var a in listchucvu)
            {
                
                cboTenCV.Properties.Items.Add(a.TenCV);

            }

            foreach (var a in listnvquanly)
            {
                cboMaNVQL.Properties.Items.Add(a.MaNV);
            }
            
        }
        private void gridChucvu_Click(object sender, EventArgs e)
        {
            txtMaNV.Text = gridView2.GetFocusedRowCellValue(colMaNV).ToString();
            txtTenNV.Text = gridView2.GetFocusedRowCellValue(colTenNV).ToString();
            cboTenCV.Text = gridView2.GetFocusedRowCellValue(colTenCV).ToString();
            cboMaNVQL.Text = gridView2.GetFocusedRowCellValue(colMaNVQL).ToString();
            macvhientai= gridView2.GetFocusedRowCellValue(colMaCV).ToString();

            cboMaNVQL.Enabled = false;
            btnHuy.Visible = true;
            btnLuu.Visible = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
            int sothutu = cboTenCV.SelectedIndex;
            
            NhanvienDao nvdao = new NhanvienDao();
            nvdao.suachucvunhanvien(txtMaNV.Text, listchucvu[sothutu].MaCV,cboMaNVQL.Text);
            XtraMessageBox.Show("Đã sửa thành công!!");
            loaddatabse();

            //claer
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            cboTenCV.Text = "";
            cboMaNVQL.Text = "";
            cboMaNVQL.Enabled = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnHuy.Visible = false;
            btnLuu.Visible = false;
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            cboTenCV.Text = "";
            cboMaNVQL.Text = "";

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        //Clear text tìm kiểm
        private void textEdit1_TextChanged(object sender, EventArgs e)
        {
            gridView2.FindFilterText = textEdit1.Text;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            textEdit1.Text = "";
        }

        public void loadlaicomboboxMaNVQL()
        {
            //Xóa dữ liệu trong combobox
            for(int i= cboMaNVQL.Properties.Items.Count; i>0;i--)
            {
                cboMaNVQL.Properties.Items.RemoveAt(i-1);
            }
            cboMaNVQL.Text = "";

            //Load lại combobox Mã nv quản lí mà ko có admin chỉ có trưởng phòng
            listnvquanly.Clear();
            listnvquanly = db.NhanViens.Where(p => p.Status == true && p.MaCV == "TP").ToList();
            foreach (var a in listnvquanly)
            {
                cboMaNVQL.Properties.Items.Add(a.MaNV);
            }
            cboMaNVQL.SelectedIndex = 0;
        }

        private void cboTenCV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(macvhientai=="TP" && cboTenCV.SelectedIndex==0)
            {
                cboMaNVQL.Enabled = true;
                loadlaicomboboxMaNVQL();
            }
            if(macvhientai=="NV" && cboTenCV.SelectedIndex==1)
            {
                cboMaNVQL.Text = "NV0001";
            }
        }
    }
}
