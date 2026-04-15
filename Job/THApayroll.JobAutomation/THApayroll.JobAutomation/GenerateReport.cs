using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using System.Net.Mail;
using System.Net;
using CrystalDecisions.Shared;

namespace THApayroll.JobAutomation
{
    public class GenerateReport
    {
        public static void SendEmailWithAttachement()
        {
            try
            {
                Reports.AttendanceList dsAttendanceCurrentDay;
                //ConnectSQL.FunProcessNightShiftForReport();

                ReportDocument crystalReportPresentEmployees = new ReportDocument();
                string pathCurrentDayAttendance = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Reports\\PresentEmployees.rpt");
                //crystalReport.Load(Server.MapPath("~/CustomerReport.rpt"));
                crystalReportPresentEmployees.Load(pathCurrentDayAttendance);

                string strQryCurrentDayAttendance = "select * from Report_Job_PresentEmployees_CurrentDay order by SNo";
                
                dsAttendanceCurrentDay = ConnectSQL.GetDataUsingQuery(strQryCurrentDayAttendance);
                crystalReportPresentEmployees.SetDataSource(dsAttendanceCurrentDay);

                ReportDocument crystalReportPreviousDayAttenance = new ReportDocument();
                string pathPreviousDayAttendance = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Reports\\PresentEmployeesPreviousDay.rpt");
                crystalReportPreviousDayAttenance.Load(pathPreviousDayAttendance);

                string strQryPreviousDayAttenance = "select * from Report_Job_PresentEmployees_PreviousDay order by SNo";
                Reports.AttendanceList dsAttendancePreviousDay;
                //dsAttendance = new Reports.AttendanceList();
                dsAttendancePreviousDay = ConnectSQL.GetDataUsingQuery(strQryPreviousDayAttenance);
                crystalReportPreviousDayAttenance.SetDataSource(dsAttendancePreviousDay);

                string body = EmailNotification.PopulateBody("Sir",
                    "Please find attached Attendance Register Report for the date of " + DateTime.Now.ToShortDateString(),
                    "IT Team");
                //EmailNotification.SendHtmlFormattedEmail("Automated test mail!", body);
                EmailNotification.SendCrystalReportEmail(crystalReportPresentEmployees, crystalReportPreviousDayAttenance, "Employee Attendance Register " + DateTime.Now.ToShortDateString(), body);

            }
            catch (Exception ex)
            {
                Logger.WriteToFile(ex.Message.ToString());
            }
        }
    }
}
