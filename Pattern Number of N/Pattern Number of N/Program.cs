using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Number_of_N
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
                    Console.WriteLine("Pola a");
                    for (int i = 1; i <= number; i++)
                    {
                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write(i);
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    Console.WriteLine("Pola b");
                    for (int i = 1; i <= number; i++)
                    {
                        for (int j = i; j > 0; j--)
                        {
                            Console.Write(j);
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine() ;
                    Console.WriteLine("Pola c");
                    for (int i = 1; i <= number; i++)
                    {
                        int num = i;
                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write(num);
                            if (num == i && i < number)
                                num++;
                            else if (num == i && i == number)
                                num--;
                            else
                                num--;
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    Console.WriteLine("Pola d");
                    for (int i = 1; i <= number; i++)
                    {
                        int num = i;
                        for (int j = 1; j <= number; j++)
                        {
                            Console.Write(num + " ");
                            num += number;
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Input tidak valid. Silakan masukkan angka bulat lebih dari 0");
                }
            }
            Console.ReadKey();

        }
    }
}
