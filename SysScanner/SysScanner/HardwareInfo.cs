using System;
using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using System.Security;
using System.Collections.Generic;

namespace SysScanner
{

    public partial class HardwareInfo
    {
        public static string MachineName ; 
        public static List<MachineHardwareInfo> GetHardwareInfo(string computer, string domain, string username, string plaintextpassword)
        {
            MachineName = computer;
            List<MachineHardwareInfo> info = new List<MachineHardwareInfo>();

            SecureString securepassword = new SecureString();
            foreach (char c in plaintextpassword)
            {
                securepassword.AppendChar(c);
            }

            // create Credentials
            CimCredential Credentials = new CimCredential(PasswordAuthenticationMechanism.Default,
                                                          domain,
                                                          username,
                                                          securepassword);

            // create SessionOptions using Credentials
            WSManSessionOptions SessionOptions = new WSManSessionOptions();
            SessionOptions.AddDestinationCredentials(Credentials);

            // create Session using computer, SessionOptions
            using (CimSession Session = CimSession.Create(computer, SessionOptions))
            {
                var usb = Session.QueryInstances(@"root\cimv2", "WQL", "SELECT * FROM Win32_USBControllerDevice");
                var disks = Session.QueryInstances(@"root\cimv2", "WQL", "SELECT * FROM Win32_LogicalDisk");
                var ram = Session.QueryInstances(@"root\cimv2", "WQL", "SELECT * FROM Win32_PhysicalMemory");
                var processor = Session.QueryInstances(@"root\cimv2", "WQL", "SELECT * FROM Win32_Processor");
                var sound = Session.QueryInstances(@"root\cimv2", "WQL", "SELECT * FROM Win32_SoundDevice");
                info.AddRange(RamInfo(ram));
                info.AddRange(ProcessorInfo(processor));
                info.AddRange(USBInfo(usb));
                info.AddRange(DiskInfo(disks));
            }
            return info;
        }


        public static List<MachineHardwareInfo> RamInfo(IEnumerable<CimInstance> instances)
        {
            List<MachineHardwareInfo> info = new List<MachineHardwareInfo>();
            foreach (CimInstance oneVolume in instances)
            {

                var a = string.Format("Capacity ‘{0}’ bytes,  PartNumber {1}, Manufacturer {2}",
                                   oneVolume.CimInstanceProperties["Capacity"].Value,
                                   oneVolume.CimInstanceProperties["PartNumber"].Value,
                                   oneVolume.CimInstanceProperties["Manufacturer"].Value);
                info.Add(new MachineHardwareInfo { MachineName = MachineName, HardwareName = "Ram", HardwareValue = a });
            }

            return info;
        }
        public static List<MachineHardwareInfo> ProcessorInfo(IEnumerable<CimInstance> instances)
        {
            List<MachineHardwareInfo> info = new List<MachineHardwareInfo>();
            foreach (CimInstance oneVolume in instances)
            {

                var a = string.Format("Name = {0},  NumberOfCores = {1}, Manufacturer = {2}",
                                   oneVolume.CimInstanceProperties["Name"].Value,
                                   oneVolume.CimInstanceProperties["NumberOfCores"].Value,
                                   oneVolume.CimInstanceProperties["Manufacturer"].Value);
                info.Add(new MachineHardwareInfo { MachineName = MachineName, HardwareName = "Processor", HardwareValue = a });
            }

            return info;
        }
        public static List<MachineHardwareInfo> USBInfo(IEnumerable<CimInstance> instances)
        {
            List<MachineHardwareInfo> info = new List<MachineHardwareInfo>();
            foreach (CimInstance oneVolume in instances)
            {

                var a = string.Format("Antecedent = {0},  Dependent = {1}",
                                   oneVolume.CimInstanceProperties["Antecedent"].Value,
                                   oneVolume.CimInstanceProperties["Dependent"].Value);
                info.Add(new MachineHardwareInfo { MachineName = MachineName, HardwareName = "USB", HardwareValue = a });
            }

            return info;
        }
        public static List<MachineHardwareInfo> DiskInfo(IEnumerable<CimInstance> instances)
        {
            List<MachineHardwareInfo> info = new List<MachineHardwareInfo>();
            foreach (CimInstance oneVolume in instances)
            {

                var a = string.Format("DeviceId = {0},  Size = {1}, FreeSpace = {2}",
                                   oneVolume.CimInstanceProperties["DeviceID"].Value,
                                   oneVolume.CimInstanceProperties["Size"].Value,
                                   oneVolume.CimInstanceProperties["FreeSpace"].Value);
                info.Add(new MachineHardwareInfo { MachineName = MachineName, HardwareName = "Disk Drive", HardwareValue = a });
            }

            return info;
        }

    }
}
