using System;
using System.Collections.Generic;
using System.Text;

namespace StudyTasks
{
    class TestCircle1
    {
        public void Testum()
        {
            Console.WriteLine("Введите сумму вклада");
            decimal vklad = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Введите срок хранения вклада в месяцах");
            int month = Convert.ToInt32(Console.ReadLine());
            for (int timer = 0; timer < month; timer++)
            {
                vklad *= 0.07M;
            }
            Console.WriteLine($"Сумма вклада через указанное вами количество месяцев будет составлять {vklad}");
        }
    }
}
