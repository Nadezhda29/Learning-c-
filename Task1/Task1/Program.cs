using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int get_middle_value(int num1, int num2, int num3)
            {
                if ((num1 < num2) && (num1 > num3))
                {
                    return num1;
                }
                else if ((num2 < num3) && (num2 > num1))
                {
                    return num2;
                }
                else
                {
                    return num3;
                }
            }

            Console.WriteLine("Введите три числа: ");
            int my_num1 = Convert.ToInt32(Console.ReadLine());
            int my_num2 = Convert.ToInt32(Console.ReadLine());
            int my_num3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Среднее значение чисел: " + get_middle_value(my_num1, my_num2, my_num3));

            Console.ReadKey();
        }
    }
}
