﻿using System;
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
using QuanLyBaoHiem.DAO;
using Model.Dao;

namespace QuanLyBaoHiem
{
    public partial class ucQuanlyCapdo : DevExpress.XtraEditors.XtraUserControl
    {
        public ucQuanlyCapdo()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            QuanLyBaoHiem.Models.QLBHContext dbContext = new QuanLyBaoHiem.Models.QLBHContext();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.CapDoes.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                capDoesBindingSource.DataSource = dbContext.CapDoes.Where(p => p.Status == true).ToList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());

            
        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridControl2_Click(object sender, EventArgs e)
        {
            txtMaCD.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "MaCD").ToString();
            txtTenCD.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "TenCD").ToString();
            btnLuu.Visible = true;
            btnHuy.Visible = true;
        }

        private void textEdit1_TextChanged(object sender, EventArgs e)
        {
            gridView2.FindFilterText = textEdit1.Text;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemCapDo tcd = new ThemCapDo();
            tcd.ShowDialog();
            CapDoDao cd = new CapDoDao();
            capDoesBindingSource.DataSource = cd.Load();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            CapDoDao cd = new CapDoDao();
            capDoesBindingSource.DataSource = cd.Load();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaCD.Text == "")
            {
                XtraMessageBox.Show("Bạn chưa chọn dòng!!");
            }
            else
            {
                DialogResult dialogResult = XtraMessageBox.Show("Xác nhận", "Bạn thực sự muốn xóa?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    CapDoDao cd = new CapDoDao();
                    cd.XoaCD(txtMaCD.Text);
                    XtraMessageBox.Show("Xóa thành công!!");
                    capDoesBindingSource.DataSource = cd.Load();
                    reset();




                }
            }


            
        }

        public void reset()
        {
            txtMaCD.Text = "";
            txtTenCD.Text = "";

            btnLuu.Visible = false;
            btnHuy.Visible = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaCD.Text = "";
            txtTenCD.Text = "";
            
            btnLuu.Visible = false;
            btnHuy.Visible = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaCD.Text == "" || txtTenCD.Text == "" )
                {
                    XtraMessageBox.Show("Điền Đầy Đủ Thông Tin", "Thông báo");
                }
                else
                {
                    CapDoDao cd = new CapDoDao();
                    cd.SuaCD(txtMaCD.Text, txtTenCD.Text);
                    XtraMessageBox.Show("Sửa thành công", "Thông báo");
                    capDoesBindingSource.DataSource = cd.Load();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Có lỗi xảy ra", "Thông báo");
            }
        }
    }
}
