using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            int find_min_sort(ref int[] arr)
            {
                return arr[0];
            }

            int find_min(ref int[] arr)
            {
                int min_elem = arr[0];
                
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] < min_elem)
                    {
                        min_elem = arr[i];
                    }
                }

                return min_elem; 
            }


            Console.WriteLine("Введите кол-во элементов в массиве: ");
            int count = Convert.ToInt32(Console.ReadLine());

            int[] arr1 = new int[count];
            Console.WriteLine("Введите элементы в массив в порядке возрастания: ");
            for (int i = 0; i < count; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Минимум: " + find_min_sort(ref arr1));

            Console.WriteLine("Введите кол-во элементов в массиве: ");
            int count2 = Convert.ToInt32(Console.ReadLine());

            int[] arr2 = new int[count2];
            Console.WriteLine("Введите элементы в циклически сдвинутый массив: ");
            for (int i = 0; i < count2; i++)
            {
                arr2[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Минимум = " + find_min(ref arr2));

            Console.ReadKey();
        }

    }
}
