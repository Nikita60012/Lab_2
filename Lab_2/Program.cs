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

            Console.WriteLine("Выберите тип сортировки:");
            Console.WriteLine("введите u для того, чтобы отсортировать по возрастанию или введите d для того, чтобы отсортировать по убыванию");
            char mode = Convert.ToChar(Console.ReadLine());

            //Сортировка
            for (int i = 1; i < length; i++)
            {
                int correctNumber = myArray[i];
                int j = i - 1;


                while (j >= 0)
                {
                    if (mode == 'u')
                    {
                        if (myArray[j] > correctNumber)
                        {
                            myArray[j + 1] = myArray[j];
                            myArray[j] = correctNumber;
                            j--;
                        }
                        else
                        {
                            break;
                        }
                    }
                    else if (mode == 'd')
                    {
                        if (myArray[j] < correctNumber)
                        {
                            myArray[j + 1] = myArray[j];
                            myArray[j] = correctNumber;
                            j--;
                        }
                        else
                        {
                            break;
                        }
                    }
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
