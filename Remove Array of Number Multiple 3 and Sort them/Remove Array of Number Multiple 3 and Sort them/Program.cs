using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Array_of_Number_Multiple_3_and_Sort_them
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 12, 9, 13, 6, 10, 4, 7, 2 };

            n = n.Where(x => x % 3 != 0).ToArray();
            Array.Sort(n);
            Console.WriteLine("n = [" + string.Join(",", n) + "]");
            Console.ReadKey();
        }
    }
}
