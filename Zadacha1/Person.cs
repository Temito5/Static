using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha1
{
    internal class Person
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        private static int count = 0;

            public Person(string name, int age)
            {
                this.Name = name; 
                this.Age = age;
                Person.count += 1;

            }

            public static int Count
            { 
                get { return count; }
            }

    }
}
