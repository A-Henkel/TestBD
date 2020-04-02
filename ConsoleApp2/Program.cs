using System;
using System.Management;
using System.Management.Instrumentation;

namespace test
{
    class Program
    {
        public static void Main(string[] args)
        {
            ManagementObjectSearcher MOS =
                new ManagementObjectSearcher("root\\WMI",
        "SELECT * FROM MSAcpi_ThermalZoneTemperature");

            foreach (ManagementObject mo in MOS.Get())
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Win32_Keyboard   ");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("CurrentTemperature: {0}", mo["CurrentTemperature"]);
                //Console.WriteLine("Status: {0}", queryObj["Status"]);
            }

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}