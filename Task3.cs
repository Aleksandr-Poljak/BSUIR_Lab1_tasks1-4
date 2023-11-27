using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSUIR_Lab_1
{
    internal class Task3
    //Lab 1, task 2, variant 12
    // Для каждой строки найти номер первого отрицательного элемента и записать данные в новый массив.
    {
        public void run_task()
        {
            int heightArr, maxValue, minValue;
            int[][] matrix;
            int[] numbersNegativElem; //для хранения номеров первых отрицательных элементов каждой строки зубчатого массива.
            Random random = new Random();

            // Запрос высоты зубчатого массива и границ диапазона масимальных и минимальных значений.
            while (true)
            {
                Console.WriteLine("Введите высоту зубчатого массива. Длина каждой строки сгенирируется автоматически: ");
                if (int.TryParse(Console.ReadLine(), out heightArr) && heightArr >= 2)
                {
                    matrix = new int[heightArr][];
                    numbersNegativElem = new int[heightArr];
                }
                else
                {
                    Console.WriteLine("Неверный ввод. попробуйте снова.");
                    continue;
                }

                Console.WriteLine("Введите минимальную границу диапазона чисел матрицы.");
                if (int.TryParse(Console.ReadLine(), out minValue)) { }
                else
                {
                    Console.WriteLine("Неверный ввод. попробуйте снова.");
                    continue;
                }

                Console.WriteLine("Введите максимальную границу диапазона чисел матрицы.");
                if (int.TryParse(Console.ReadLine(), out maxValue) && maxValue > minValue) { }
                else
                {
                    Console.WriteLine("Неверный ввод. попробуйте снова.");
                    continue;
                }
                break;
            }
            
            //генерация строк зубчатого массива и их заполнение. Вывод массива. 
            Console.WriteLine("Ваш массив: ");
            for(int i = 0; i < heightArr; i++)
            {
                matrix[i] = new int[random.Next(1, heightArr +1)]; //Создание строки зубчатого массива.
                for(int j=0; j < matrix[i].Length; j++)
                {
                    matrix[i][j] = random.Next(minValue, maxValue+1);
                    Console.Write($"{matrix[i][j]} ");
                }
                Console.Write("\n");
            }

            //Поиск первого отрицательнго эллемента в строке. И запись номера в массив.
           for(int i = 0;i < heightArr; i++)
            {
                numbersNegativElem[i] = Array.FindIndex(matrix[i], value => value < 0); 
            }

            Console.WriteLine("Номера первых отрицательных элементов в каждой строке зубчатого массива:");
            Console.WriteLine("Значение -1 указывает на отсуствие в строке отрицательных элментов.");
            foreach(int value in numbersNegativElem)
            {
                Console.Write($"{value} ");
            }


           
        }

    }
}
