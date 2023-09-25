using Indexers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    internal class Employee
    {
        private int[] Age = new int[10];

        public int this[int index]
        {
            set
            {
                if (index >= 0 && index < Age.Length)
                {
                    if (value > 0)
                    {
                        Age[index] = value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid  value:");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid index");
                }
            }
            get
            {
                return Age[index];
            }










        }
    }
}
    class Program
{
    static void Main(string[] args)
    {
        Employee emp = new Employee();
        emp[0] = -8;
        Console.WriteLine(emp[3]);
        Console.ReadLine();
    }
}


  