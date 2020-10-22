using System;
using System.Collections.Generic;
using System.Text;

namespace StudyTasks
{
    class TestCircle3
    {
        public void Testum()
        {
            for (int first = 0; first <= 10; first++)
            {
                for (int second = 0; second <= 10; second++)
                {
                    Console.Write($"{first} * {second} = {first * second}\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
