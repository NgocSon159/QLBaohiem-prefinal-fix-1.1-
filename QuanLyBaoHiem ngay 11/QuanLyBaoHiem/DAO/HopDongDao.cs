﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBaoHiem.Models;
using System.Data.Entity.Core.Objects;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;

namespace Model.Dao
{
    public class HopDongDao
    {
        QLBHContext db = null;
        public HopDongDao()
        {
            db = new QLBHContext();
        }
        public List<HopDong> LoadThongBaoHopDong(DateTime date)
        {
            List<HopDong> hopDongs = new List<HopDong>();
            foreach(var item in db.HopDongs)
            {
                
                if (item.MaChuKy=="YEAR")
                {
                    DateTime Previous = item.NgayHieuLuc.Value.AddDays(-3);
                    for (int i=1;i<=4;i++)
                    {
                        if ((date.Day == Previous.Day && date.Month == Previous.Month))
                        {
                            hopDongs.Add(item);
                        }
                        Previous = Previous.AddDays(1);
                    }
                }
                if(item.MaChuKy== "MONTH")
                {
                    DateTime Previous = item.NgayHieuLuc.Value.AddDays(-3);
                    for (int i = 1; i <= 4; i++)
                    {
                        if ((date.Day == Previous.Day))
                        {
                            hopDongs.Add(item);
                        }
                        Previous = Previous.AddDays(1);
                    }
                }
                if(item.MaChuKy== "QUATER")
                {
                    DateTime Previous = item.NgayHieuLuc.Value.AddMonths(3);
                    Previous = Previous.AddDays(-3);
                    for (int i = 1; i <= 4; i++)
                    {
                        if ((date.Day == Previous.Day&&date.Month == Previous.Month))
                        {
                            hopDongs.Add(item);
                        }
                        Previous = Previous.AddDays(1);
                    }
                }
                if(item.MaChuKy== "HALF")
                {
                    DateTime Previous = item.NgayHieuLuc.Value.AddMonths(6);
                    Previous = Previous.AddDays(-3);
                    for (int i = 1; i <= 4; i++)
                    {
                        if ((date.Day == Previous.Day && date.Month == Previous.Month))
                        {
                            hopDongs.Add(item);
                        }
                        Previous = Previous.AddDays(1);
                    }
                }
            }
            return hopDongs;
        }

        public List<HopDong> Load()
        {
            return db.HopDongs.Where(x => x.Status == true).ToList();
        }

        public List<HopDong> loadtheoyeucau(string macv, string manv)
        {
            if (macv == "QL")
            {
                return db.HopDongs.Where(x => x.Status == true).ToList();
            }
            else
            {
                if (macv == "TP")
                {
                    List<HopDong> hopdong = new List<HopDong>();
                    var listnhanviencuatruongphong = db.NhanViens.Where(p => p.Status == true).Where(p=>p.MaNVQuanLi==manv).Select(l=>l.MaNV).ToList();
                    foreach (var item in listnhanviencuatruongphong)
                    {
                        var hd = db.HopDongs.Where(p => p.Status == true).Where(p => p.MaNV == item).ToList();
                        foreach (var item1 in hd)
                        {
                            hopdong.Add(item1);
                        }
                    }
                    return hopdong;
                }
                else
                {
                    return db.HopDongs.Where(x => x.Status == true).Where(p => p.MaNV == manv).ToList();
                }
            }

        }





        public void ThemHD(string MaHD, string MaGHD, string MaCK, string MaNV, string MaKH, string NgayHL)
        {
            HopDong hd = new HopDong();
            hd.MaHD = MaHD;
            hd.MaGoiHD = MaGHD;
            hd.MaChuKy = MaCK;
            hd.MaNV = MaNV;
            hd.MaKHChinh = MaKH;
            hd.NgayHieuLuc = Convert.ToDateTime(NgayHL);
            hd.Status = true;
            db.HopDongs.Add(hd);
            db.SaveChanges();
        }

        public void SuaHD(string MaHD, string MaGHD, string MaCK, string MaNV, string MaKH, DateTime NgayHL)
        {
            var hd = db.HopDongs.FirstOrDefault(x => x.MaHD == MaHD);
            hd.MaGoiHD = MaGHD;
            hd.MaChuKy = MaCK;
            hd.MaNV = MaNV;
            hd.MaKHChinh = MaKH;
            hd.NgayHieuLuc = NgayHL;
            db.SaveChanges();
        }
        public void XoaHD(string MaHD)
        {
            var hd = db.HopDongs.FirstOrDefault(x => x.MaHD == MaHD);
            hd.Status = false;
            db.SaveChanges();
        }
        public string getlasthopdong()
        {
            var countRow = db.HopDongs.Count();
            int getCount = countRow + 1;
            string newMaSP = "HD";
            if (getCount < 10) newMaSP += "00" + getCount.ToString();
            else if (getCount < 100) newMaSP += "0" + getCount.ToString();
            return newMaSP;
        }
    }
}
