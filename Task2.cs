using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSUIR_Lab_1
{
    internal class Task2
    //Подсчитать норму матрицы .Сумма максимумов столбцов
    //Lab 1, task 2, variant 12.
    {
        public void run_task() {
            int sizeArr, maxValue, minValue, sumMaxValues = 0 ;
            int[,] matrix;
            Random random = new Random();

            // Запрос размера матрицы и границ диапазона масимальных и минимальных значений.
            while (true)
            {
                Console.WriteLine("Введите размер квадратной матрицы (минимум 4): ");
                if(int.TryParse(Console.ReadLine(), out sizeArr) && sizeArr >= 4)
                {
                    matrix = new int[sizeArr, sizeArr];
                }
                else
                {
                    Console.WriteLine("Неверный ввод. попробуйте снова.");
                    continue;
                }

                Console.WriteLine("Введите минимальную границу диапазона чисел матрицы.");
                if(int.TryParse(Console.ReadLine(),out minValue)) { }
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

            // Заполнение и вывод матрицы.
            Console.WriteLine("Ваша матрица: ");
            for(int i = 0; i < sizeArr; i++)
            {
                for(int j = 0; j < sizeArr; j++) {
                    matrix[i,j] = random.Next(minValue, maxValue);
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.Write("\n");
            }

            //Цикл по столбцам матрицы.Поиск суммы максимума столбцов
            for(int i = 0; i < sizeArr; i++)
            {
                int[] tempValues = new int[matrix.Length]; //Временный массив для храанения элментов столбца матрицы
                for (int j = 0;j < sizeArr; j++)
                {
                    tempValues[j] = matrix[j,i];
                }
                sumMaxValues += tempValues.Max(); //Суммирование максимумов столбцов
            }
            Console.WriteLine($"Сумма максимумов столбцов: {sumMaxValues}");
        }
    }
}
