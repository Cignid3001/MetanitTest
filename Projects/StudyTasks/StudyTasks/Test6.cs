using System;
using System.Collections.Generic;
using System.Text;

namespace StudyTasks
{
    class Test6
    {
        public void Testum()
        {
            Console.WriteLine("Введите номер операции:\n1.Сложение\n2.Вычитание\n3.Умножение");
            string chaise = Console.ReadLine();
            switch (chaise)
            {
                case "1":
                    Console.WriteLine("Вы выбрали \"сложение\"");
                    break;

                case "2":
                    Console.WriteLine("Вы выбрали \"вычитание\"");
                    break;

                case "3":
                    Console.WriteLine("Вы выбрали \"умножение\"");
                    break;

                default:
                    Console.WriteLine("Неправильный номер операции");
                    break;
            }
        }
    }
}
