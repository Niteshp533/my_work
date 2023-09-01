using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2
{
    class Program
    {   
        public void Add(int a, int b)
        {
            int c = a + b;
            Console.WriteLine(" The sum of two given integers is {0}", c);
        }
        static void Main(string[] args)
        {
            int a;
            int b;
            Console.WriteLine("Enter Two integer : ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Program obj = new Program();
            obj.Add(a, b);
            Console.ReadKey();

        }
    
    }
}
