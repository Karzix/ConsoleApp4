using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
   public class Student : Person
    {
        public string Khoa;
        public double DiemTrungBinh;

        public Student()
        {

        }
        public Student(string name, int age, string khoa, int diemTrungBinh) : base(name,age)
        {
            Khoa = khoa;
            DiemTrungBinh = diemTrungBinh;
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap ten khoa: ");
            Khoa = Console.ReadLine();
            Console.Write("Nhap diem trung binh: ");
            DiemTrungBinh=int.Parse(Console.ReadLine());
        }

        private string XepLoai()
        {
            if (DiemTrungBinh <= 4.0)
            {
                return "yeu";
            }
            else if(DiemTrungBinh <= 6.0)
            {
                return "trung binh";
            }
            else if(DiemTrungBinh <= 8.4)
            {
                return "kha";
            }
            else
            {
                return "gioi";
            }
        }

        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("Ten khoa: " + Khoa);
            Console.WriteLine("Diem trung binh: " + DiemTrungBinh);
            Console.WriteLine("Xep loai: " + XepLoai());
        }
    }
}
