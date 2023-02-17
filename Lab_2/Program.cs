using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ввод
            Console.WriteLine("Введите размерность массива");
            int length = Convert.ToInt32(Console.ReadLine());
            int[] myArray = new int[length];
            Console.WriteLine("Заполните массив целыми числами");
            for(int i = 0; i < length; i++)
            {
                myArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            //Сортировка
            for(int i = 1; i < length; i++)
            {
                int correctNumber = myArray[i];
                int j = i - 1;
                while(j >= 0 && myArray[j] > correctNumber)
                {
                    myArray[i] = myArray[j];
                    myArray[j] = correctNumber;
                    j--;
                }
            }

            //Вывод
            foreach(int i in myArray)
            {
                Console.Write(i + " ");
            }
        }
    }
}
