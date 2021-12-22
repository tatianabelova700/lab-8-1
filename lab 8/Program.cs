using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_8
{
    internal class Directory
    {
        static void Main(string[] args)
        {
            string dirName = "C:\\Program Files";

            DirectoryInfo dirInfo = new DirectoryInfo(dirName);

            Console.WriteLine($"Название каталога: {dirInfo.Name}");
            Console.WriteLine($"Полное название каталога: {dirInfo.FullName}");
            Console.WriteLine($"Время создания каталога: {dirInfo.CreationTime}");
            Console.WriteLine($"Корневой каталог: {dirInfo.Root}");
            Console.ReadKey();
        }
    }
}
