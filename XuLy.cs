using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class XuLy
    {
        public List<Teacher> Teachers= new List<Teacher>();
        public List<Student> Students= new List<Student>();

        public void menu()
        {
            do
            {
                Console.WriteLine("1: Nhap teacher\n2: Nhap student\n3: xuat tat ca thong tin\n4: dung chuong trinh");
                int n = int.Parse(Console.ReadLine());
                if (n == 1)
                {
                    var tc = new Teacher();
                    tc.Nhap();
                    Console.Clear();
                    Teachers.Add(tc);
                }
                if (n == 2)
                {
                    var sd= new Student();
                    sd.Nhap();
                    Console.Clear();
                    Students.Add(sd);
                }
                if (n == 3)
                {
                    xuat();
                }
                if (n == 4)
                {
                    break;
                }
            }while(true);
        }
        public void xuat()
        {
            Console.WriteLine("\nThong tin teacher");
            foreach (var i in Teachers)
            {
                i.xuat();
            }
            Console.WriteLine("\nThong tin student");
            foreach (var i in Students)
            {
                i.xuat();
            }
        }
        List<Student> TimTheoTenKhoa(string tenkhoa)
        {
            List<Student> data = new List<Student>();
            //double m = Students.Max(x => x.DiemTrungBinh);
            foreach(var i in Students)
            {
                if (i.Khoa == tenkhoa)
                {
                    data.Add(i);
                }
            }
            return data;
        }
        public void DiemTBSVCN()
        {
            
            Console.WriteLine("\nSinh Vien co diem tb cao nhat cua khoa cntt ");
            var max = Students[0];
            foreach(var i in TimTheoTenKhoa("cntt"))
            {
                if (i.DiemTrungBinh > max.DiemTrungBinh)
                {
                    max = i;
                }
            }

            max.xuat();
        }
        public void DSSVDiemNhoHon5()
        {
            Console.WriteLine("\nDS sinh vien co diemtb <5 cua khoa cntt: ");
            foreach (var i in TimTheoTenKhoa("cntt"))
            {
                if (i.DiemTrungBinh < 5)
                {
                    i.xuat();
                }
            }
        }
        public void DSTen()
        {
            Console.Write("\nNhap ten can tim: ");
            string ten = Console.ReadLine();
            Console.WriteLine("Danh sach nhung nguoi co ten: "+ ten);
            foreach(var i in Teachers)
            {
                if (i.Name == ten)
                {
                    i.xuat();
                }
            }
            foreach(var i in Students)
            {
                if(i.Name == ten)
                {
                    i.xuat();
                }
            }
        }
    }
}
