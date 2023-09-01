using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac3
{
    class Program
    {
        public void Area(int r)
        {
            int b = r * r;
            double a;
            a = 3.14 * b;
            Console.WriteLine("Area of Circle having radius {0} is {1}", r, a);
        }
        public void circ(int r)
        {
            int b = 2 * r;
            double a = 3.14 * b;
            Console.WriteLine("Circumference of Circle having radius {0} is {1}", r, a);

        }
        static void Main(string[] args)
        {
            int r;
            Console.Write(" Enter the radius of circle : ");
            r = Convert.ToInt32(Console.ReadLine());
            Program obj = new Program();
            obj.Area(r);
            obj.circ(r);
            Console.ReadKey();
        }
    }
}
