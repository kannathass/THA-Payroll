using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Net;

namespace THApayroll.JobAutomation
{
    public class EmailNotification
    {
        public void SendEmail()
        {
            //try
            //{
            //    string body = this.PopulateBody("THA",
            //    "test title",
            //    "www.thaSolutions.com",
            //    "test email notification. please ignore it.");
            //    this.SendHtmlFormattedEmail("Automated test mail!", body);
            //}
            //catch (Exception ex)
            //{
            //    Logger.WriteToFile(ex.Message.ToString());
            //}
        }

        public static string PopulateBody(string userName, string description, string sendBy)
        {
            string body = string.Empty;
            string path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "EmailTemplates\\AttendanceList.html");

            using (StreamReader reader = new StreamReader(path))
            {
                body = reader.ReadToEnd();
            }
            body = body.Replace("{UserName}", userName);
            body = body.Replace("{Description}", description);
            body = body.Replace("{SendBy}", sendBy);
            return body;
        }


        private void SendHtmlFormattedEmail(string subject, string body)
        {
            using (MailMessage mailMessage = new MailMessage())
            {
                mailMessage.From = new MailAddress(ConfigurationManager.AppSettings["UserName"]);
                mailMessage.Subject = subject;
                mailMessage.Body = body;
                mailMessage.IsBodyHtml = true;
                mailMessage.To.Add(new MailAddress(ConfigurationManager.AppSettings["ToMailAddress"]));
                mailMessage.CC.Add(new MailAddress(ConfigurationManager.AppSettings["CCMailAddress"]));
                SmtpClient smtp = new SmtpClient();
                smtp.Host = ConfigurationManager.AppSettings["Host"];
                smtp.EnableSsl = Convert.ToBoolean(ConfigurationManager.AppSettings["EnableSsl"]);
                System.Net.NetworkCredential NetworkCred = new System.Net.NetworkCredential();
                NetworkCred.UserName = ConfigurationManager.AppSettings["UserName"];
                NetworkCred.Password = ConfigurationManager.AppSettings["Password"];
                smtp.UseDefaultCredentials = true;
                smtp.Credentials = NetworkCred;
                smtp.Port = int.Parse(ConfigurationManager.AppSettings["Port"]);
                smtp.Send(mailMessage);
            }
        }

        public static void SendCrystalReportEmail(ReportDocument crystalReportPresentEmployees, ReportDocument crystalReportAbsentEmployees, string subject, string body)
        {
            try
            {
                //using (MailMessage mm = new MailMessage(ConfigurationManager.AppSettings["UserName"], ConfigurationManager.AppSettings["ToMailAddress"], subject, body))
                using (MailMessage mm = new MailMessage())
                {
                    mm.Subject = subject;
                    mm.Body = body;
                    mm.Attachments.Add(new Attachment(crystalReportPresentEmployees.ExportToStream(ExportFormatType.PortableDocFormat), "Today_EmployeesAttendance.pdf"));
                    mm.Attachments.Add(new Attachment(crystalReportAbsentEmployees.ExportToStream(ExportFormatType.PortableDocFormat), "Yesterday_EmployeesAttendance.pdf"));

                    mm.IsBodyHtml = true;
                    mm.From = new MailAddress(ConfigurationManager.AppSettings["UserName"], "CB Dyeing");
                    foreach (var toAddress in ConfigurationManager.AppSettings["ToMailAddress"].Split(';'))
                    {
                        mm.To.Add(new MailAddress(toAddress.Trim(), ""));
                    }
                    foreach (var ccAddress in ConfigurationManager.AppSettings["CCMailAddress"].Split(';'))
                    {
                        mm.CC.Add(new MailAddress(ccAddress.Trim(), ""));
                    }
                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = ConfigurationManager.AppSettings["Host"];
                    smtp.EnableSsl = Convert.ToBoolean(ConfigurationManager.AppSettings["EnableSsl"]);
                    NetworkCredential credential = new NetworkCredential();
                    credential.UserName = ConfigurationManager.AppSettings["UserName"];
                    credential.Password = ConfigurationManager.AppSettings["Password"];
                    smtp.UseDefaultCredentials = true;
                    smtp.Credentials = credential;
                    smtp.Port = int.Parse(ConfigurationManager.AppSettings["Port"]);
                    //smtp.EnableSsl = true;
                    smtp.Send(mm);
                }
            }
            catch (Exception ex)
            {
                Logger.WriteToFile(ex.Message.ToString());

            }
            //using (MailMessage mailMessage = new MailMessage())
            //{
            //    mailMessage.From = new MailAddress(ConfigurationManager.AppSettings["UserName"]);
            //    mailMessage.Subject = subject;
            //    mailMessage.Body = body;
            //    mailMessage.IsBodyHtml = true;
            //    mailMessage.To.Add(new MailAddress(ConfigurationManager.AppSettings["ToMailAddress"]));
            //    mailMessage.CC.Add(new MailAddress(ConfigurationManager.AppSettings["CCMailAddress"]));
            //    SmtpClient smtp = new SmtpClient();
            //    smtp.Host = ConfigurationManager.AppSettings["Host"];
            //    smtp.EnableSsl = Convert.ToBoolean(ConfigurationManager.AppSettings["EnableSsl"]);
            //    System.Net.NetworkCredential NetworkCred = new System.Net.NetworkCredential();
            //    NetworkCred.UserName = ConfigurationManager.AppSettings["UserName"];
            //    NetworkCred.Password = ConfigurationManager.AppSettings["Password"];
            //    smtp.UseDefaultCredentials = true;
            //    smtp.Credentials = NetworkCred;
            //    smtp.Port = int.Parse(ConfigurationManager.AppSettings["Port"]);
            //    smtp.Send(mailMessage);
            //}
        }
    }
}
