using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] get_list_numbers(string[] numbers)
            {
                for (int k = 0, j = 0; k < numbers.Length; k++)
                {
                    j = Convert.ToInt32(numbers[k]);

                    if ((j % 3 == 0) && (j % 5 == 0))
                        numbers[k] = "FizzBuzz";
                    else if (j % 5 == 0)
                        numbers[k] = "Buzz";
                    else if (j % 3 == 0)
                        numbers[k] = "Fizz";
                }
                return numbers;
            }

            Console.WriteLine("Введите количество чисел в списке: ");
            int count = Convert.ToInt32(Console.ReadLine());

            string[] my_numbers = new string[count];
            Console.WriteLine("Введите числа: ");

            for (int i = 0; i < my_numbers.Length; i++)
            {
                string num = Console.ReadLine();
                my_numbers[i] = num;
            }

            string[] new_numbers = get_list_numbers(my_numbers);
            Console.WriteLine("Полученный список: ");

            foreach (var value in new_numbers)
            {
                Console.Write(value + ", ");
            }

            Console.ReadKey();
        }

    }
}
