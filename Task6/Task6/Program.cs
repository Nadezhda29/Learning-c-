using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            bool find_value(ref int [] arr, int target_value)
            {
                int right = arr.Length - 1;
                int left = 0;

                while (true)
                {
                    int value = (left + right) / 2;

                    if (value == target_value)
                    {
                        return true;
                    }
                    else if (value < target_value)
                    {
                        left = value;
                    }
                    else
                    {
                        right = value; 
                    }

                    if (right == left + 1)
                    {
                        return false;
                    } 
                }
            }


            Console.WriteLine("Введите кол-во элементов в массиве: ");
            int count = Convert.ToInt32(Console.ReadLine());

            int[] arr_ = new int [count];
            Console.WriteLine("Введите элементы массива: ");
            for (int i = 0; i < count; i++)
            {
                arr_[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Введите значение, которое нужно найти в массиве: ");
            int my_value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(find_value(ref arr_, my_value));

            Console.ReadKey();
        }
    }
}
