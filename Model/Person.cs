using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Person
    {
        public string Name;
        public int Age;
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public Person()
        {

        }
        public virtual void Nhap()
        {
            Console.Write("Nhap ho va ten: ");
            Name=Console.ReadLine();
            do
            {   
                Console.Write("Nhap tuoi: ");
                Age = int.Parse(Console.ReadLine());
            } while (Age < 0 || Age > 120);
        }
        public virtual void xuat()
        {
            Console.WriteLine("Ho va ten: " + Name);
            Console.WriteLine("Tuoi: " + Age);
        }
    }
}
