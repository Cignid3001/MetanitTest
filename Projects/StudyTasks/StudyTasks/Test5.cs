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
            double mnojitel = 0;
            if (vklad >= 0)
                if (vklad <= 100)
                {
                    mnojitel = 1.05;
                }
                else if (vklad <= 200)
                {
                    mnojitel = 1.07;
                }
                else
                {
                    mnojitel = 1.1;
                }
            else
            {
                Console.WriteLine("Сумма вклада не может быть меньше 0");
                return;
            }
            Console.WriteLine($"Сумма вашего вклада будет составлять {vklad * mnojitel}");
        }
    }
}
