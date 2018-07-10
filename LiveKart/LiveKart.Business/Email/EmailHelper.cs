using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Mail;
using LiveKart.Business.ConfigSettings;
using LiveKart.LogService;

namespace LiveKart.Business.Email
{
    public class EmailHelper
    {
        static ILogService logging = new FileLogService(typeof(EmailHelper));

        public static bool SendEmail(string subject, string emailTo, string emailBody)
        {
            try
            {
                MailMessage mm = new MailMessage();
                mm.From = new MailAddress("ariengage@droisys.com", "Admin");
                MailAddress replyTo = new MailAddress("ariengage@droisys.com");
                mm.ReplyToList.Add(replyTo);
                mm.To.Add(emailTo);
                mm.Subject = subject;
                mm.Body = emailBody;
                mm.IsBodyHtml = true;
                mm.Priority = MailPriority.High;
                mm.BodyEncoding = Encoding.Unicode;
                SmtpClient client = new SmtpClient(ConfigSettings.ConfigSettings.ReadConfigValue("SMTPServer", ""), Convert.ToInt32(ConfigSettings.ConfigSettings.ReadConfigValue("SMTPPort", "0")));
                client.Credentials = new NetworkCredential("ariengage@droisys.com", "iengage@123");
                client.EnableSsl = true;
                client.Send(mm);
                client.Timeout = 120;
            }
            catch(Exception ex)
            {
                logging.Error(ex.ToString());
                return false;
            }
            return true;
        }
    }
}
