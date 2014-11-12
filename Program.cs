using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMath
{
    class Program
    {
        static void Main(string[] args)
        {
            Student Adam = new Student(){Name = "Adam", Age = 7};
            Student Bob = new Student(){Name = "Bob", Age = 7};

            Student Liv = new Student(){Name = "Liv", Age = 6};
            Student Mik = new Student(){Name = "Mikkel", Age = 12};

            Console.WriteLine(GenericMath.Min(Liv, Mik));
            Console.WriteLine(GenericMath.Min(Adam, Bob));
            Console.WriteLine(GenericMath.Min(Bob, Adam));
        }
    }
}
