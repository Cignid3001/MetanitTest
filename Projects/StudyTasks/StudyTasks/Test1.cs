using System;
using System.Collections.Generic;
using System.Text;

namespace StudyTasks
{
    public class Test1
    {
        public void Testum()
        {
            Console.WriteLine("Введите первое число:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2)
            {
                Console.WriteLine("Первое число больше второго");
            }
            else if (num2 > num1)
            {
                Console.WriteLine("Второе число больше первого");
            }
            else
            {
                Console.WriteLine("Числа равны");
            }
        }
    }
}
