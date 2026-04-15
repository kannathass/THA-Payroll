using BioMetrixCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace THApayroll.JobAutomation
{
    public class ConnectSQL
    {
        static SqlConnection con = new SqlConnection();
        static SqlCommand cmd = new SqlCommand();
        static SqlDataReader dr;

        public ConnectSQL()
        {
            string constring;
            string ServerName;
            string DBName;
            string UID;
            string PWD;

            ServerName = ConfigurationManager.AppSettings["ServerName"];
            DBName = ConfigurationManager.AppSettings["DBName"];
            UID = ConfigurationManager.AppSettings["UID"];
            PWD = ConfigurationManager.AppSettings["PWD"];
            constring = "Data Source=" + ServerName + ";Initial Catalog=" + DBName + ";uid=" + UID + ";pwd=" + PWD + ";Connection Timeout=45000;";

            con.ConnectionString = constring;
        }

        public static void FunProcessBiometricAttendance()
        {

            try
            {
                //ConnectSql()
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "processingbiometricattendance";
                cmd.Parameters.Clear();

                cmd.CommandTimeout = 0;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Logger.WriteToFile(ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }

        }

        public void FunInsertTempLogDetails(ICollection<MachineInfo> lstMachineInfo)
        {

            try
            {
                con.Open();
                foreach (MachineInfo machineInfo in lstMachineInfo)
                {

                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "InsertTempLogDetails";
                    cmd.Parameters.Clear();

                    cmd.Parameters.AddWithValue("@MacId", machineInfo.MachineNumber);
                    cmd.Parameters.AddWithValue("@EnrollNo", machineInfo.IndRegID);
                    cmd.Parameters.AddWithValue("@EnrollDate", Convert.ToDateTime(machineInfo.DateTimeRecord));
                    //cmd.CommandTimeout = 0;

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Logger.WriteToFile(ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }

        }

        public static Reports.AttendanceList GetDataUsingQuery(string query)
        {
            cmd = new SqlCommand(query);
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ConnectionString))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter())
                {
                    cmd.Connection = con;

                    sda.SelectCommand = cmd;
                    using (Reports.AttendanceList dsAttendance = new Reports.AttendanceList())
                    {
                        sda.Fill(dsAttendance, "Employees");
                        return dsAttendance;
                    }
                }
            }
        }

        public static void FunProcessNightShiftForReport()
        {

            try
            {
                ConnectSQL sql = new ConnectSQL();

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Report_ProcessNightShift";
                cmd.Parameters.Clear();

                cmd.CommandTimeout = 0;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Logger.WriteToFile(ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }

        }

        //public DeviceInfo update_grid()
        //{
        //    DeviceInfo deviceInfo = new DeviceInfo();
        //    try
        //    {
        //        con.Open();
        //        cmd.Connection = con;
        //        cmd.CommandType = CommandType.Text;
        //        cmd.CommandText = "Select * from FPDevCon";
        //        dr = cmd.ExecuteReader();
        //        while (dr.Read())
        //        {
        //            deviceInfo.DevId = Convert.ToInt16(dr.GetValue(0));
        //            deviceInfo.DevIP = Convert.ToString(dr.GetValue(1));
        //            deviceInfo.DevPort = Convert.ToString(dr.GetValue(2));
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        Logger.WriteToFile(ex.Message.ToString());
        //    }
        //    finally
        //    {
        //        dr.Close();
        //        con.Close();
        //    }
        //    return deviceInfo;
        //}
    }
}
