using System;
using System.Collections.Generic;
using System.Text;

namespace StudyTasks
{
    class Test5
    {
        public void Testum()
        {
            Console.WriteLine("Введите сумму вклада");
            double vklad = Convert.ToDouble(Console.ReadLine());
            if (vklad < 100)
            {
                vklad = vklad * 1.05 + 15;
            }
            else if (100 < vklad && vklad < 200)
            {
                vklad = vklad * 1.07 + 15;
            }
            else
            {
                vklad = vklad * 1.1 + 15;
            }
            Console.WriteLine($"Сумма вашего вклада будет составлять {vklad}");
        }
    }
}
