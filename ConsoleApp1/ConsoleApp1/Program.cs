﻿using System;
using System.Management;

namespace test
{
    class Program
    {
        public static void Main(string[] args)
        {
            ManagementObjectSearcher searcher =
                new ManagementObjectSearcher("root\\CIMV2",
                "SELECT * FROM Win32_Volume");

            foreach (ManagementObject queryObj in searcher.Get())
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Win32_Volume instance");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Capacity: {0}", queryObj["Capacity"]);
                Console.WriteLine("Caption: {0}", queryObj["Caption"]);
                Console.WriteLine("DriveLetter: {0}", queryObj["DriveLetter"]);
                Console.WriteLine("DriveType: {0}", queryObj["DriveType"]);
                Console.WriteLine("FileSystem: {0}", queryObj["FileSystem"]);
                Console.WriteLine("FreeSpace: {0}", queryObj["FreeSpace"]);
            }

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}