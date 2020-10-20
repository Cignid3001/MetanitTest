using System;
using System.Collections.Generic;
using System.Text;

namespace StudyTasks
{
    class Test3
    {
        public void Testum()
        {
            Console.WriteLine("Введите число");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num == 5 || num == 10)
            {
                Console.WriteLine("Данное число либо равно 5, либо равно 10");
            }
            else
            {
                Console.WriteLine("Неизвестное число");
            }
        }
    }
}
