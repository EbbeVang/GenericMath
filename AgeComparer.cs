using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMath
{
    class StudentAgeComparer : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            if (x.Age < y.Age) return -1;
            if (x.Age == y.Age) return 0;
            return 1;
        }
    }
}
