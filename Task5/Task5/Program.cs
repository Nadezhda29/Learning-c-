using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] get_join_arr(int[] arr1, int[] arr2)
            {
                int count = arr1.Length + arr2.Length;
                int[] join_arr = new int[count];
                int i = 0;
                int j = 0;
                int k = 0;

                while ((i < arr1.Length) && (j < arr2.Length))
                {
                    if (arr1[i] < arr2[j])
                    {
                        join_arr[k] = arr1[i];
                        i++;
                        k++;
                    }
                    else
                    {
                        join_arr[k] = arr2[j];
                        j++;
                        k++;
                    }
                }

                if (i == arr1.Length)
                {
                    while (j < arr2.Length)
                    {
                        join_arr[k] = arr2[j];
                        j++;
                        k++;
                    }

                }
                else
                {
                    while (i < arr1.Length)
                    {
                       join_arr[k] = arr1[i];
                       i++;
                       k++;
                    }
                }

                return join_arr;
            }



            Console.WriteLine("Введите количество чисел в 1 списке: ");
            int count1 = Convert.ToInt32(Console.ReadLine());
            int[] my_arr1 = new int[count1];

            Console.WriteLine("Введите числа: ");
            for (int i = 0; i < my_arr1.Length; i++)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                my_arr1[i] = num;
            }

            Console.WriteLine('\n' + "Введите количество чисел во 2 списке: ");
            int count2 = Convert.ToInt32(Console.ReadLine());
            int[] my_arr2 = new int[count2];

            Console.WriteLine("Введите числа: ");
            for (int i = 0; i < my_arr2.Length; i++)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                my_arr2[i] = num;
            }

            int[] new_arr = get_join_arr(my_arr1, my_arr2);
            Console.WriteLine('\n' + "Новый список: ");
            foreach (var value in new_arr)
            {
                Console.Write(value + ", ");
            }

            Console.ReadKey();

        }
    }
}
