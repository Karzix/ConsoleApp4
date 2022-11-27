using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Teacher : Person
    {
        public int LuongCoban;
        public int NamCongTac;
        
        public Teacher()
        {

        }
        public Teacher(string name, int age ,int luongCoban, int namCongTac) : base(name,age)
        {
            LuongCoban = luongCoban;
            NamCongTac = namCongTac;
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap luong co ban: ");
            LuongCoban=int.Parse(Console.ReadLine());
            Console.Write("Nhap nam cong tac: ");
            NamCongTac=int.Parse(Console.ReadLine());
        }
        private double TongLuong()
        {
            int batluong = (NamCongTac/3)+1;
            if (NamCongTac % 3 == 0)
            {
                batluong = NamCongTac / 3;
            }
            double tongluong = (2.34 + ((batluong-1)*0.33)) * LuongCoban;
            return tongluong;
        }

        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("Luong co ban: " + LuongCoban);
            Console.WriteLine("So nam cong tac: " + NamCongTac);
            Console.WriteLine("Tong luong: " + TongLuong());
        }
    }
}
