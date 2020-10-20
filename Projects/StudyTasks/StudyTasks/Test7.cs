using System;
using System.Collections.Generic;
using System.Text;

namespace StudyTasks
{
    class Test7
    {
        public void Testum()
        {
            Console.WriteLine("Введите первое число:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Выберите номер операции:\n1.Сложение\n2.Вычитание\n3.Умножение");
            string chaise = Console.ReadLine();
            switch (chaise)
            {
                case "1":
                    Console.WriteLine($"Вы выбрали операцию \"сложение\"\nРезультатом ваших вычислений будет число {num1 + num2}");
                    break;

                case "2":
                    Console.WriteLine($"Вы выбрали операцию \"вычитание\"\nРезультатом ваших вычислений будет число {num1 - num2}");
                    break;

                case "3":
                    Console.WriteLine($"Вы выбрали операцию \"умножение\"\nРезультатом ваших вычислений будет число {num1 * num2}");
                    break;

                default:
                    Console.WriteLine("Некоректный выбор операции");
                    break;
            }
        }
    }
}
