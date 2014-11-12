using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace GenericMath
{
    class Student : IComparable<Student>
    {
        public String Name { get; set; }

        public int Age { get; set; }

        public int CompareTo(Student other)
        {
            //return Age.CompareTo(other.Age);
            if (Age.CompareTo(other.Age) == 0)
            {
                return Name.CompareTo(other.Name);
            }
            return Age.CompareTo(other.Age);

        }

        public override string ToString()
        {
            return Name + ", " + Age;
        }
    }
}
