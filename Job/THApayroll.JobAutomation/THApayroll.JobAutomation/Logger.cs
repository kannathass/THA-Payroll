using System;
using System.Configuration;
using System.IO;

namespace THApayroll.JobAutomation
{
    public static class Logger
    {
        public static void WriteToFile(String text)
        {
            //String path = @"D:\THAlogFiles\ProcessedBiometricAttendance_Log.txt";
            String path = ConfigurationManager.AppSettings["LogFileLocation"];
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine($"{DateTime.Now.ToString("dd / MM / yyyy hh: mm : ss tt")} - {text}");
                writer.Close();
            }
        }
    }
}
