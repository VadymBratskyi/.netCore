using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace RepeatAdndTestSharp8.FilesDirectories
{
    class DiscsInfo
    {
        public void GetDriveInfo() {

            DriveInfo[] driveInfo = DriveInfo.GetDrives();
            foreach (var dr in driveInfo) {
                Console.WriteLine(dr.Name);
                Console.WriteLine("AvailableFreeSpace: "+ ConvertHelper.ConvertToGb(dr.AvailableFreeSpace)+"Gb");
                Console.WriteLine("DriveFormat: " + dr.DriveFormat);
                Console.WriteLine("IsReady: "+dr.IsReady);
                Console.WriteLine("TotalFreeSpace: "+ ConvertHelper.ConvertToGb(dr.TotalFreeSpace) + "Gb");
                Console.WriteLine("TotalSize: "+ConvertHelper.ConvertToGb(dr.TotalSize) + "Gb");
                Console.WriteLine(dr.VolumeLabel);
            }            
        }

       
    }
}
