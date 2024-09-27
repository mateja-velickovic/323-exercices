using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _323_matvelickov_ncdu
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string startPath = "C:/Users/pe04uhp/";

            DirectoryInfo dir = new DirectoryInfo(startPath);
            var fileList = dir.GetDirectories("*.*", SearchOption.TopDirectoryOnly);

            var fileQuery = from file in fileList
                            orderby file.Name
                            select file;

            foreach (DirectoryInfo di in fileQuery)
            {
                Console.WriteLine($"{di}");
            }

            Console.ReadLine();
        }
    }
}
