using System;

namespace VlozhenyeCikli
{
    internal class trianglewithfor
    {
        static void Main()
        {
            Console.WriteLine("Введите высоту: ");
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine();
            PrintTriangle1(height);
            Console.WriteLine();

            PrintTriangle2(height);
            Console.WriteLine();

            PrintTriangle3(height);
            Console.WriteLine();

            PrintTriangle4(height);
            Console.WriteLine();
        }

        static void PrintTriangle1(int height)
        {
            for (int i = 1; i <= height; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }

        static void PrintTriangle2(int height)
        {
            for (int i = height; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }

        static void PrintTriangle3(int height)
        {
            for (int i = 1; i <= height; i++)
            {
                for (int j = height; j >= 1; j--)
                {
                    if (j > i)
                        Console.Write(" ");
                    else
                        Console.Write("#");
                }
                Console.WriteLine();
            }
        }

        static void PrintTriangle4(int height)
        {
            for (int i = height; i >= 1; i--)
            {
                for (int j = height; j >= 1; j--)
                {
                    if (j > i)
                        Console.Write(" ");
                    else
                        Console.Write("#");
                }
                Console.WriteLine();
            }
        }
    }
}