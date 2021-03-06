﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLyBaoHiem.DAO;
using Model.Dao;

namespace QuanLyBaoHiem
{
    public partial class ThemGoiHD : DevExpress.XtraEditors.XtraForm
    {
        ucThongTinChinhSachBaoHiem f;
        public ThemGoiHD()
        {
            InitializeComponent();
        }

        public ThemGoiHD(ucThongTinChinhSachBaoHiem ff)
        {
            InitializeComponent();
            f = ff;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaGHD.Text == "" || txtMucPhi.Text == "" || txtGiaTriBaoHiem.Text == "" ||
                    txtThoiHanBaoHiem.Text == "" || txtThoiHanDongPhi.Text == "")
                    XtraMessageBox.Show("Điền đầy đủ thông tin", "Thông báo");
                else
                {
                    GoiHopDongDao ghd = new GoiHopDongDao();
                    ghd.ThemGHD(txtMaGHD.Text, txtMucPhi.Text, txtGiaTriBaoHiem.Text, Convert.ToInt32(txtThoiHanBaoHiem.Text), Convert.ToInt32(txtThoiHanDongPhi.Text));
                    XtraMessageBox.Show("Thêm thành công", "Thông báo");
                    f.refreshdata();
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Có lỗi xảy ra", "Thông báo");
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {           
                this.Close();
        }
    }
}