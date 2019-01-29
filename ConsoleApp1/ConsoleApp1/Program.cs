using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            for(int t = 0; t < T; t++)
            {
                long sum = 0;
                string line = Console.ReadLine();
                string[] space = line.Split('\n');
                long num = long.Parse(space[0]);
                sum = briangle(num - 1);
                Console.WriteLine(sum);
            }
        }
        public static long briangle(long n)
        {
            long rem;
            rem = (long)(2 * Math.Pow(n, 2));
            return rem;
        }
    }
}
