using System;

namespace ____
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                {
                    Console.Write("Hur många numer vill du skriva in: ");
                    int mängd = int.Parse(Console.ReadLine());
                    int högsta = 0, lägsta = Int32.MaxValue, summa = 0;

                    for (int i = 1; i <= mängd; i++)
                    {
                        Console.Write($"Tal {i}: ");

                        int nummer = int.Parse(Console.ReadLine());
                        if (nummer > högsta)
                        {
                            högsta = nummer;
                        }
                        else if (nummer < lägsta)
                        {
                            lägsta = nummer;
                        }

                        summa += nummer;
                    }

                    Console.WriteLine($"Högsta talet: {högsta}");
                    Console.WriteLine($"Lägsta talet: {lägsta}");
                    Console.WriteLine($"Genomsnitt: {summa / mängd}");
                }
            }
        }
    }
}

