using System;
using System.Collections.Generic;
using System.Text;

namespace StudyTasks
{
    class Test4
    {
        public void Testum()
        {
            Console.WriteLine("Введите сумму вклада");
            double vklad = Convert.ToDouble(Console.ReadLine());
            if (vklad < 100)
            {
                vklad = vklad * 1.05;
            }
            else if (100 < vklad && vklad < 200)
            {
                vklad = vklad * 1.07;
            }
            else
            {
                vklad = vklad * 1.1;
            }
            Console.WriteLine($"Сумма вашего вклада будет составлять {vklad}");
        }
    }
}
