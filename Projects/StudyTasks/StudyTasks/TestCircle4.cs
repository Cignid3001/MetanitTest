using System;
using System.Collections.Generic;
using System.Text;

namespace StudyTasks
{
    class TestCircle4
    {
        public void Testum()
        {
            while (true)
            {
                Console.WriteLine("Введите первое число:");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите второе число:");
                int num2 = Convert.ToInt32(Console.ReadLine());
                if (num1 < 0 || num1 > 10 || num2 < 0 || num2 > 10)
                {
                    Console.WriteLine("Ваши числа не должны быть больше 10 и меньше 0");
                }
                else
                {
                    Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                    break;
                }
            }
        }
    }
}
