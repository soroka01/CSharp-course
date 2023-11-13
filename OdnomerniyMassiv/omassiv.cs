using System;

namespace OdnomerniyMassiv
{
    internal class Omassiv
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введи размер массива: ");
            int size = int.Parse(Console.ReadLine());

            int[] myArray = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write("Введи элемент массива " + (i + 1) + " ");
                myArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Введенный массив в обратном порядке: ");

            for (int i = size - 1; i >= 0; i--)
            {
                Console.Write(myArray[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Четные элементы массива: ");

            for (int i = 0; i < size; i++)
            {
                if (myArray[i] % 2 == 0)
                    Console.Write(myArray[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Наименьший элемент массива: ");

            int minel = 2147483647;
            for (int i = 0; i < size; i++)
            {
                if (myArray[i] < minel)
                {
                    minel = myArray[i];
                }
            }

            Console.WriteLine(minel);


            Console.ReadLine();
        }
    }
}
