using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_Three_and_Four_Say_OK_or_YES
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            bool isValidInput = false;
            while (!isValidInput)
            {
                Console.Write("Masukkan panjang deret angak = ");
                string input = Console.ReadLine();
                isValidInput = int.TryParse(input, out number);
                if (isValidInput == true)
                {
                    for (int i = 1; i <= number; i++)
                    {
                        if (i % 3 == 0 && i % 4 == 0)
                        {
                            Console.Write("OKYES ");
                        } else if(i % 4 == 0)
                        {
                            Console.Write("YES ");
                        } else if (i % 3 == 0)
                        {
                            Console.Write("OK ");
                        } else
                        {
                            Console.Write(i + " ");
                        }
                    }   

                } else
                {
                    Console.WriteLine("Input tidak valid. Silakan masukkan angka bulat lebih dari 0");
                }
            }
            Console.ReadKey();
        }
    }
}
