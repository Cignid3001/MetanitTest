using System;
using System.Collections.Generic;
using System.Text;

namespace StudyTasks
{
    class Test2
    {
        public void Testum()
        {
            Console.WriteLine("Введите число:");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num > 5 && num < 10)
            {
                Console.WriteLine($"Число {num} меньше 10 и больше 5") ;
            }
            else
            {
                Console.WriteLine("Неизвестное число");
            }
        }
    }
}
