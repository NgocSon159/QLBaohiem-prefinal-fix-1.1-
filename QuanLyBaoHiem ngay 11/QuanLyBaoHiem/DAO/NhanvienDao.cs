﻿using QuanLyBaoHiem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBaoHiem.DAO
{
    class NhanvienDao
    {
        QLBHContext db = new QLBHContext();
        public string tenchucvu(string macv)
        {
            var chucvu = db.ChucVus.Find(macv);
            return chucvu.TenCV;
        }
        public List<NhanVien> Load()
        {
            return db.NhanViens.Where(x => x.Status == true).ToList();
        }

        public List<NhanVien> loadonlynhanvien()
        {
            return db.NhanViens.Where(x => x.Status == true).Where(p=>p.MaCV=="NV").ToList();
        }

        public string LayTenNhanVien(string MaNVQL)
        {
            return db.NhanViens.FirstOrDefault(x => x.MaNV == MaNVQL).TenNV;
        }
        public void suanhanvien(string manv,string macv,string tennv,string sdt,bool gioitinh,string diachi,string manvql,DateTime ngaysinh)
        {
            var nv = db.NhanViens.Find(manv);
            nv.MaCV = macv;
            nv.TenNV = tennv;
            nv.GioiTinh = gioitinh;
            nv.NgaySinh = ngaysinh;
            nv.MaNVQuanLi = manvql;
            nv.DiaChi = diachi;
            nv.Sdt = sdt;
            
            db.SaveChanges();
            

        }
        public string getlastnhanvien()
        {
            var countRow = db.NhanViens.Count();
            int getCount = countRow + 1;
            string newMaSP = "NV";
            if (getCount < 10) newMaSP += "00" + getCount.ToString();
            else if (getCount < 100) newMaSP += "00" + getCount.ToString();
            return newMaSP;
        }
        public void themnhanvien(NhanVien nv)
        {
            db.NhanViens.Add(nv);
            db.SaveChanges();
        }
        public void suathongtincanhan(string manv, string tennv, string sdt, bool gioitinh, string diachi, DateTime ngaysinh)
        {
            var nv = db.NhanViens.Find(manv);
            
            nv.TenNV = tennv;
            nv.GioiTinh = gioitinh;
            nv.NgaySinh = ngaysinh;
            
            nv.DiaChi = diachi;
            nv.Sdt = sdt;
            
            db.SaveChanges();
        }
        public void suachucvunhanvien(string manv,string macv,string manvql)
        {
            var nv = db.NhanViens.Find(manv);
            if(macv=="TP")
            {
                nv.MaCV = macv;
                nv.MaNVQuanLi = "NV0001";
            }
            else
            {
                nv.MaCV = macv;
                nv.MaNVQuanLi = manvql;
            }
            
            db.SaveChanges();
        }

        public string getchucvutunhanvien(string manv)
        {
            return db.NhanViens.Where(p => p.Status == true).Where(p => p.MaNV == manv).Select(m => m.MaCV).SingleOrDefault();
        }

        public void xoanhanvien(string manv)
        {
            var nv = db.NhanViens.Find(manv);
            nv.Status = false;
            db.SaveChanges();
        }

        public bool kiemtrataikhoantontai(string manv)
        {
            var nv= db.NhanViens.Find(manv);
            if(nv==null)
            {
                return false;
            }
            return true;
        }

        public string getEmailcuanhanvien(string manv)
        {
            return db.NhanViens.Where(p => p.MaNV == manv).Select(l => l.Email).SingleOrDefault();
        }

        public void resetmatkhaunhanvien(string manv)
        {
            var nv = db.NhanViens.Find(manv);
            nv.MatKhau = "123456";
            db.SaveChanges();
        }

        
    }
}
