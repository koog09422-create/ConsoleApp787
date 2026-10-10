using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp787
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UNV[] x = new UNV[2];
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = new UNV();
                Console.WriteLine("name unv :");
                string name = Console.ReadLine();
                Console.WriteLine("ty unv :");
                string ty = Console.ReadLine();
                Console.WriteLine("count halls");
                int count = int.Parse(Console.ReadLine());
                x[i].ADD(name, ty, count);
                
            }
            for (int i = 0; i < x.Length; i++)
            {
                x[i].print_u();
            }
        }
    }
}
