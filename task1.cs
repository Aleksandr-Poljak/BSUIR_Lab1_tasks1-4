using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSUIR_Lab_1
{
    internal class Task1
    //Lab 1, task 1, variant 12.
    //Найти максимум из отрицательных элементов.
    {

        public void run_task()
        {
            int sizeArray, maxValue, minValue;
            int[] userArray;
            Random random = new Random();

            // Запрос у пользвателя  размера массива, а также минимальных и максимальных границ диапазона.
            while (true)
            {
                Console.WriteLine("Введите размер массива : ");

                if (int.TryParse(Console.ReadLine(), out sizeArray) && sizeArray > 0)
                {
                    userArray = new int[sizeArray];
                }
                else
                {
                    Console.WriteLine("Попробуйте снова...");
                    continue;
                }

                Console.WriteLine("Введите максимальное значение диапзона: ");
                if (int.TryParse(Console.ReadLine(), out maxValue)) { }
                else
                {
                    Console.WriteLine("Попробуйте снова...");
                    continue;
                }

                Console.WriteLine("Введите минимальное значение диапазона: ");
                if (int.TryParse(Console.ReadLine(), out minValue) && minValue < maxValue) { }
                else
                {
                    Console.WriteLine("Попробуйте снова...");
                    continue;
                }

                break;
            }

            //Заполнение массива
            for (int i = 0; i < sizeArray; i++)
            {
                userArray[i] = random.Next(minValue, maxValue+1);
            }

            //Вывод массива.
            Console.WriteLine("Ваш массив: \n");
            foreach (int value in userArray)
            {
                Console.WriteLine($"{value} ");
            }
            //Поиск максимума из отрицательных элементов.
            int sumMinElem = 0;
            foreach(int value in userArray)
            {
                if(value < 0)
                {
                    sumMinElem += value;
                }
            }
            Console.WriteLine($"Максимум из всех отрицательных элементов: {sumMinElem}");

        }
    }
}
