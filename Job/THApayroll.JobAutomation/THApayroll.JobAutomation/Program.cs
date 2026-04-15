using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace THApayroll.JobAutomation
{
    class Program
    {
        static void Main(string[] args)
        {
            #region BiometricActivity
            Logger.WriteToFile("GetAndUpdateBiometricUserInfo Started");
            BiometricProcess biometricProcess = new BiometricProcess();
            biometricProcess.GetAndUpdateBiometricUserInfo();
            Logger.WriteToFile("GetAndUpdateBiometricUserInfo Finished");

            Logger.WriteToFile("FunProcessBiometricAttendance Started");
            ConnectSQL.FunProcessBiometricAttendance();
            Logger.WriteToFile("FunProcessBiometricAttendance Finished");
            #endregion

            #region EmailNotification
            Logger.WriteToFile("Email notification Started");
            ConnectSQL.FunProcessNightShiftForReport();

            GenerateReport.SendEmailWithAttachement();
            Logger.WriteToFile("Email notification Finished");
            #endregion
        }
    }
}

