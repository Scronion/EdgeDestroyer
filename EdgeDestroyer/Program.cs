using System;
using System.IO;

namespace EdgeDestroyer
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\Public\\Desktop\\Microsoft Edge.lnk";
            if(File.Exists(path))
            {
                File.Delete(path);
            }
            return;
        }
    }
}