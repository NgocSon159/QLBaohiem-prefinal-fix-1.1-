using System;
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
    public partial class ThemCapDo : DevExpress.XtraEditors.XtraForm
    {
        public ThemCapDo()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaCD.Text == "" || txtTenCD.Text == "" )
                    XtraMessageBox.Show("Điền đầy đủ thông tin", "Thông báo");
                else
                {
                    CapDoDao cd = new CapDoDao();
                    cd.ThemCD(txtMaCD.Text, txtTenCD.Text);
                    XtraMessageBox.Show("Thêm thành công", "Thông báo");
                }

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Có lỗi xảy ra", "Thông báo");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}