using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Aircnc.FrontStage.Services.Common
{
    public class MailService 
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public MailService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        public void SendVerifyMail(string mailTo, int userId)
        {
            //SMTP @gmail.com
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.Credentials = new NetworkCredential("bsdevteam01@gmail.com", "bs53741405P@ssw0rd");
            client.EnableSsl = true;

            //Mail
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("bsdevteam01@gmail.com", "Aircnc_Official");
            mail.To.Add(mailTo);
            mail.Priority = MailPriority.Normal;
            mail.Subject = "Aircnc_驗證信";
            mail.IsBodyHtml = true;
            mail.Body = @$"
                <h1>點擊以下連結，啟用帳戶</h1>
                <a href='https://{_httpContextAccessor.HttpContext.Request.Host.Value}/Account/Verify?user={userId}' target='_blank'>驗證</a>
            ";

            client.Send(mail);
        }
    }
}
