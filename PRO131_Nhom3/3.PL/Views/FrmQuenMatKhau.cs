using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2.BUS.IServices;
using _2.BUS.Services;
using System.Text.RegularExpressions;

namespace _3.PL.Views
{
    public partial class FrmQuenMatKhau : Form
    {
        private INhanVienServices _iNhanVienServices;
        private static Random random = new Random();
        public FrmQuenMatKhau()
        {
            InitializeComponent();
            _iNhanVienServices = new NhanVienServices();
            this.CenterToScreen();
        }
        

        public static string RandomString(int length)
        {
            const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void MailSendThruGmail(string email, string pw)
        {
            MailAddress fromAddress = new MailAddress("anhptph25812@fpt.edu.vn", "Admin");
            MailAddress toAddress = new MailAddress(email, "User");
            const string subject = "Reset mật khẩu App BeeMart";
            string body = @"Bạn đã yêu cầu đổi mật khẩu. Mật khẩu mới của bạn là: <b>" + pw + "</b>";

            System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage(fromAddress.Address, toAddress.Address, subject, body);
            msg.IsBodyHtml = true;

            var client = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential("anhptph25812@fpt.edu.vn", ""),
                EnableSsl = true
            };

            try
            {
                client.Send(msg);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_xacNhan_Click(object sender, EventArgs e)
        {

        }
        
    }
}
