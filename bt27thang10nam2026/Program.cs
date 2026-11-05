using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt27thang10nam2026
{
    internal class Program
    {
        static void Main(string[] args)
        {
         teacher Mrninh = new teacher("Ninh", 176, 80, true, "GV103");
         student MrVuong = new student("Vuong", 160, 50, true, "5612.68");
            student MrQuan = new student("Quan", 170, 60, true, "5613.69");
            Mrninh.showMyIdentity();
            Mrninh.showPersonalInformation();
            Console.WriteLine();
            MrVuong.showMyIdentity();
            MrVuong.showPersonalInformation();
            Console.WriteLine();
            MrQuan.showMyIdentity();
            MrQuan.showPersonalInformation();
            Console.ReadLine();
        }
    }
}
