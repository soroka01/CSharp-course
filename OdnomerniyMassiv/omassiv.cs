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
                Console.Write("Введи элемент массива " + (i + 1) + ": ");
                myArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Введенный массив в обратном порядке: ");

            for (int i = size - 1; i >= 0; i--)
            {
                Console.Write(myArray[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Четные элементы массива: ");

            PrintEvenElements(myArray);

            Console.WriteLine();
            Console.WriteLine("Сумма четных элементов массива: " + SumEvenElements(myArray));

            Console.WriteLine();
            Console.WriteLine("Наименьший элемент массива: ");

            int minel = int.MaxValue;
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

        static void PrintEvenElements(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                    Console.Write(array[i] + " ");
            }
        }

        static int SumEvenElements(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    sum += array[i];
                }
            }
            return sum;
        }
    }
}
