using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Hristo",17);
            Person person2 = new Person("Temi", 15);
            Console.WriteLine($"Брой обекти:{Person.Count}");

        }
    }
}
