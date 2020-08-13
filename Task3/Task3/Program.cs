using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] get_squares(int[] arr)
            {
                int[] arr_squares = new int[arr.Length];
                int i = 0;

                foreach (int number in arr)
                {
                    arr_squares[i] = number * number;
                    i++;
                }
                return arr_squares;
            }

            int[] get_indices_from_one(int[] arr)
            {
                int[] indexes = new int[arr.Length];

                for (int i = 0; i < arr.Length; i++)
                {
                    indexes[i] = i;
                }

                return indexes;
            }

            int get_max_element_index(int[] arr)
            {
                int max_elem = 0;
                int index_elem = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (max_elem < arr[i])
                    {
                        max_elem = arr[i];
                        index_elem = i;
                    }
                }
                return index_elem;
            }

            int get_first_three_index(int[] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == 3)
                    {
                        return i;
                    }
                }

                return -1;
            }

            int[] get_every_second_element(int[][] Arr, int m)
            {
                int[] arr_ = new int[m];
                int i = 0;

                while (i < m)
                {
                    foreach (int[] arr in Arr)
                    {
                        arr_[i] = arr[1];
                        i++;
                    }
                }

                return arr_;
            }


            int get_last_three_index(int[] arr)
            {
                int my_index = -1;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == 3)
                    {
                        my_index = i;
                    }
                }

                return my_index;
            }



            Console.WriteLine("Введите количество чисел в списке: ");
            int count = Convert.ToInt32(Console.ReadLine());
            int[] my_numbers = new int[count];

            Console.WriteLine("Введите числа: ");
            for (int i = 0; i < my_numbers.Length; i++)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                my_numbers[i] = num;
            }

            int[] numbers_squares = get_squares(my_numbers);
            Console.WriteLine('\n' + "Квадраты чисел: ");
            foreach (var value in numbers_squares)
            {
                Console.Write(value + ", ");
            }

            int[] new_numbers = get_indices_from_one(my_numbers);
            Console.WriteLine('\n' + "Список индексов: ");
            foreach (var value in new_numbers)
            {
                Console.Write(value + ", ");
            }

            Console.WriteLine('\n' + "Индекс максимального элемента: " + get_max_element_index(my_numbers));

            int n = 0;
            Console.WriteLine('\n' + "Введите количество списков: ");
            n = Convert.ToInt32(Console.ReadLine());
            int[][] big_arr = new int[n][];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine('\n' + "Введите количество чисел в " + (i + 1) + " списке: ");
                int count2 = Convert.ToInt32(Console.ReadLine());
                int[] arr = new int[count2];

                Console.WriteLine("Введите числа: ");
                for (int j = 0; j < arr.Length; j++)
                {
                    int num = Convert.ToInt32(Console.ReadLine());
                    arr[j] = num;
                }

                big_arr[i] = arr;
            }


            int[] new_arr = get_every_second_element(big_arr, n);
            Console.WriteLine('\n' + "Список вторых элементов: ");
            foreach (var value in new_arr)
            {
                Console.Write(value + ", ");
            }

            Console.ReadKey();


            Console.WriteLine("Введите количество чисел в списке: ");
            int new_count = Convert.ToInt32(Console.ReadLine());
            int[] my_arr = new int[new_count];

            Console.WriteLine("Введите числа: ");
            for (int i = 0; i < my_arr.Length; i++)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                my_arr[i] = num;
            }

            
            Console.WriteLine('\n' + "Индекс первой в списке тройки: " + get_first_three_index(my_arr));
            Console.WriteLine('\n' + "Индекс последней в списке тройки: " + get_last_three_index(my_arr));

            Console.ReadKey();
        }
    }
}
