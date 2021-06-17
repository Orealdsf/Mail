using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Mail
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "";
            string src = $@"C:/PDF/{fileName}.pdf";
            #region -- Mail通知 --
            MailMessage mail = new MailMessage();
            //前面是發信email後面是顯示的名稱
            mail.From = new MailAddress("", "");

            //收信者email
            mail.To.Add("");

            //設定優先權
            mail.Priority = MailPriority.Normal;

            //標題
            mail.Subject = "";

            //內容
            mail.Body = "";

            //這是附件部分~先用附件的物件把路徑指定進去
            Attachment attachment = new Attachment("");

            //郵件訊息中加入附件
            mail.Attachments.Add(attachment);

            //內容使用html
            mail.IsBodyHtml = true;

            //設定mail的smtp
            SmtpClient MySmtp = new SmtpClient("", 25);

            //您在mail的帳號密碼
            MySmtp.Credentials = new System.Net.NetworkCredential("", "");

            //開啟ssl
            MySmtp.EnableSsl = false;

            //發送郵件
            try { MySmtp.Send(mail); }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught in CreateTestMessage2(): {0}", ex.ToString());
            }

            //放掉宣告出來的MySmtp
            MySmtp = null;

            //放掉宣告出來的mail
            mail.Dispose();
            #endregion
        }
    }
}
