using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSUIR_Lab_1
{
    internal class Task4
    //Lab 1, task 4, variant 12.
    {
        public bool array_trim(Index start, Index end, ref string[] arrayString )
            //Метод принимает массив и 2 индекса (Index).
            //Оставляет в массиве только элементы между индексами(замена массива).
        {
            if (arrayString.Length< start.Value || arrayString.Length < end.Value || start.Value > end.Value)
                //проверка корректности  переданых индексов .
            {
                return false;
            }
            else
            {
                Range range = start..end;
                arrayString = arrayString[range];
                return true;
            }

        }

        public void run_task()
        {
            string[] array1 = { "1_el", "2_el", "3_el", "4_el", "5_el", "6_el", "7_el", "8_el", "9_el", "10_el" };
            string[] array2 = { "1_it", "2_it", "3_it", "4_it", "5_it", "6_it", "7_it", "8_it"};

            foreach(string s in array1 )
            {
                Console.Write( s+ " " );

            }
            Console.WriteLine();

            foreach (string s in array2)
            {
                Console.Write(s+" ");
                
            }
            Console.WriteLine();

            //Урезание по индексам 
            Index start = 2;
            Index end = 5;
            bool flag1 = array_trim(start , end, ref array1);
            bool flag2 = array_trim(start.Value+1, end.Value+2, ref array2);
            Console.WriteLine($"Резульаты выполенения метода : {flag1}, {flag2}");

            foreach (string s in array1)
            {
                Console.Write(s + " ");

            }
            Console.WriteLine();

            foreach (string s in array2)
            {
                Console.Write(s + " ");

            }
            Console.WriteLine();
        }
    }

   
}
