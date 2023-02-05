using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace kFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesi ime: ");
            string name = Console.ReadLine();

            string file = "name.txt";

            if (File.Exists(file))
            {
                if (!Directory.Exists("backup"))
                {
                    Directory.CreateDirectory("backup");
                }

                File.Copy(file, @"backup\name_"+ DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss")+ ".txt");
                File.Delete(file);
            }

            File.WriteAllText(file, name);

            Console.ReadKey();
        }
    }
}
