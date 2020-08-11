using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] reverse(int[] arr)
            {
                int[] reverse_arr = new int[arr.Length];

                for (int i = 0, j = (arr.Length - 1); j >= 0; i++, j--)
                {
                    reverse_arr[j] = arr[i];
                }

                return reverse_arr;
            }

            void reverse_inplace(ref int[] arr)
            {
                for (int i = 0, j = (arr.Length - 1); j > 0; i++, j--)
                {
                    int temp = arr[j];
                    arr[j] = arr[i];
                    arr[i] = temp;
                }
            }

            Console.WriteLine("Введите количество чисел в списке: ");
            int count = Convert.ToInt32(Console.ReadLine());
            int[] my_arr = new int[count];

            Console.WriteLine("Введите числа: ");
            for (int i = 0; i < my_arr.Length; i++)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                my_arr[i] = num;
            }

            int[] new_arr = reverse(my_arr);
            Console.WriteLine('\n' + "Новый список: ");
            foreach (var value in new_arr)
            {
                Console.Write(value + ", ");
            }

            Console.ReadKey();


            Console.WriteLine("Введите количество чисел в списке: ");
            int count2 = Convert.ToInt32(Console.ReadLine());
            int[] my_arr2 = new int[count2];

            Console.WriteLine("Введите числа: ");
            for (int i = 0; i < my_arr2.Length; i++)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                my_arr2[i] = num;
            }

            reverse_inplace(ref my_arr2);

            Console.WriteLine('\n' + "Измененный список: ");
            foreach (var value in my_arr2)
            {
                Console.Write(value + ", ");
            }

            Console.ReadKey();

        }
    }
}
