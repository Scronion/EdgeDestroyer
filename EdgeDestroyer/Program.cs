using System;
using System.IO;

namespace EdgeDestroyer
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\Microsoft Edge.lnk";

            if(File.Exists(path))
            {
                File.Delete(path);
            }

            path = Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory) + "\\Microsoft Edge.lnk";

            if (File.Exists(path))
            {
                File.Delete(path);
            }

            return;
        }
    }
}