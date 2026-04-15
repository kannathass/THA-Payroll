using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BioMetrixCore;
using System.Configuration;

namespace THApayroll.JobAutomation
{
    public class BiometricProcess
    {
        DeviceManipulator manipulator = new DeviceManipulator();
        public ZkemClient objZkeeper;
        bool isDeviceConnected = false;

        public bool IsDeviceConnected
        {
            get { return isDeviceConnected; }
            set
            {
                isDeviceConnected = value;
                if (isDeviceConnected)
                {
                    Logger.WriteToFile("The device is connected !!");

                    //ShowStatusBar("The device is connected !!", true);
                    //btnConnect.Text = "Disconnect";
                    //ToggleControls(true);
                }
                else
                {
                    //ShowStatusBar("The device is diconnected !!", true);
                    objZkeeper.Disconnect();
                    Logger.WriteToFile("The device is diconnected !!");

                    //btnConnect.Text = "Connect";
                    //ToggleControls(false);
                }
            }
        }

        public void GetAndUpdateBiometricUserInfo()
        {
            try
            {
                string ipAddress = ConfigurationManager.AppSettings["BiometricIPAddress"];
                string port = ConfigurationManager.AppSettings["BiometricPort"];
                int machineNumber = Convert.ToInt16(ConfigurationManager.AppSettings["BiometricMachineNo"]);
                if (ipAddress == string.Empty || port == string.Empty)
                    Logger.WriteToFile("The Device IP Address and Port is mandotory !!");
                //throw new Exception("The Device IP Address and Port is mandotory !!");

                //int portNumber = 4370;
                int portNumber;

                if (!int.TryParse(port, out portNumber))
                    Logger.WriteToFile("Not a valid port number");
                //throw new Exception("Not a valid port number");

                bool isValidIpA = UniversalStatic.ValidateIP(ipAddress);
                if (!isValidIpA)
                    Logger.WriteToFile("The Device IP is invalid !!");

                //throw new Exception("The Device IP is invalid !!");

                isValidIpA = UniversalStatic.PingTheDevice(ipAddress);
                if (!isValidIpA)
                    Logger.WriteToFile("The device at " + ipAddress + ":" + port + " did not respond!!");

                //throw new Exception("The device at " + ipAddress + ":" + port + " did not respond!!");

                objZkeeper = new ZkemClient(RaiseDeviceEvent);
                IsDeviceConnected = objZkeeper.Connect_Net(ipAddress, portNumber);

                if (IsDeviceConnected)
                {
                    ConnectSQL connectSql = new ConnectSQL();

                    ICollection<MachineInfo> lstMachineInfo = manipulator.GetLogData(objZkeeper, machineNumber);
                    if (lstMachineInfo != null && lstMachineInfo.Count > 0)
                    {
                        Logger.WriteToFile(lstMachineInfo.Count + " records found !!");
                        connectSql.FunInsertTempLogDetails(lstMachineInfo);
                        //BindToGridView(lstMachineInfo);
                        //ShowStatusBar(lstMachineInfo.Count + " records found !!", true);
                    }
                    else
                        Logger.WriteToFile("No records found");
                    //DisplayListOutput("No records found");
                }
            }
            catch (Exception ex)
            {
                Logger.WriteToFile(ex.Message.ToString());
                //DisplayListOutput(ex.Message);
            }

        }

        /// <summary>
        /// Your Events will reach here if implemented
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="actionType"></param>
        private static void RaiseDeviceEvent(object sender, string actionType)
        {
            switch (actionType)
            {
                case UniversalStatic.acx_Disconnect:
                    {
                        Logger.WriteToFile("The device is switched off");

                        //ShowStatusBar("The device is switched off", true);
                        //DisplayEmpty();
                        //btnConnect.Text = "Connect";
                        //ToggleControls(false);
                        break;
                    }

                default:
                    break;
            }

        }

    }
}
