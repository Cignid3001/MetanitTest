using System;
using System.Collections.Generic;
using System.Text;

namespace StudyTasks
{
    class TestCircle2
    {
        public void Testum()
        {
            Console.WriteLine("Введите сумму вклада");
            decimal vklad = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Введите срок хранения вклада в месяцах");
            int month = Convert.ToInt32(Console.ReadLine());
            while (month > 0)
            {
                vklad = vklad * 1.07M;
                month -= 1;
            }
            Console.WriteLine($"Сумма вклада через указанное вами количество месяцев будет составлять {vklad}");
        }
    }
}
