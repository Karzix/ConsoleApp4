using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XuLy a = new XuLy();
            a.menu();
            a.DiemTBSVCN();
            //double m = a.Students.Max(x => x.DiemTrungBinh);
            //Console.Write(m);
            a.DSSVDiemNhoHon5();
            a.DSTen();
            Console.ReadLine();
        }
    }
}
