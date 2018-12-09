using DevExpress.XtraEditors;
using QuanLyBaoHiem.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBaoHiem.Linhtinh
{
    public class EmailSupport
    {
        public void guiemail(string manv)
        {
            try
            {
                NhanvienDao nvdao = new NhanvienDao();
                MailMessage mail = new MailMessage();

                //Server mail của Google
                SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("son.95.1112@gmail.com");
                // Email cần đến
                mail.To.Add(nvdao.getEmailcuanhanvien(manv)); 
                mail.Subject = ("Thông báo mật khẩu");
                mail.Body = "Mật khẩu của bạn là 123456!!\nVui lòng đổi mật khẩu lại ngay!!";
                
                smtpServer.Port = 587;
                smtpServer.Credentials = new NetworkCredential("son.95.1112@gmail.com", "ngocsonvipro456");
                smtpServer.EnableSsl = true;
                nvdao.resetmatkhaunhanvien(manv);
                smtpServer.Send(mail);
                XtraMessageBox.Show("Gửi email thành công đến: "+ nvdao.getEmailcuanhanvien(manv));
            }
            catch
            {
                XtraMessageBox.Show("Lổi xảy ra trong quá trình gửi mail");
            }
        }
    }
}
