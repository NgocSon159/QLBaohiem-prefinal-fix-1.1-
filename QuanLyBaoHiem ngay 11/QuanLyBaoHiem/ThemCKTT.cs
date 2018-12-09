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
using Model.Dao;
namespace QuanLyBaoHiem
{
    public partial class ThemCKTT : DevExpress.XtraEditors.XtraForm
    {
        List<string> list = new List<string>();
        public ucThongTinChuKyThanhToan f;
        public ThemCKTT(ucThongTinChuKyThanhToan ff)
        {
            InitializeComponent();
            f = ff;
            cbothang.Properties.Items.Add("tháng");

            cbothang.SelectedIndex = 0;
            loaddata();
        }

        public void loaddata()
        {
            for (int i = 1; i <= 12; i++)
            {
                list.Add(i.ToString());
            }


            foreach (var item in list)
            {
                cboSothang.Properties.Items.Add(item);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            f.refresh();
            this.Close();

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if(cboSothang.Text=="" || txtMaCK.Text=="")
                {
                    XtraMessageBox.Show("Nhập Đầy Đủ Thông Tin");
                }
                else
                {
                    ChuKyThanhToanDao ck = new ChuKyThanhToanDao();
                    string chuky = cboSothang.Text + " " + cbothang.Text;
                    ck.ThemCKTT(txtMaCK.Text, chuky);
                    XtraMessageBox.Show("Thêm Thành Công");
                    
                    f.refresh();
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show("Có Lỗi Xảy Ra");
            }
        }
    }
}