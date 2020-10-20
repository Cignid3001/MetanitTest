using System;

namespace StudyTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите номер задания для проверки от 1 до 7");
            string choosen = Console.ReadLine();

            switch (choosen)
            {
                case "1":
                    Console.WriteLine("Вы выбрали проверку первого задания");
                    Test1 check1 = new Test1();
                    check1.Testum();
                    break;

                case "2":
                    Console.WriteLine("Вы выбрали проверку второго задания");
                    Test2 check2 = new Test2();
                    check2.Testum();
                    break;

                case "3":
                    Console.WriteLine("Вы выбрали проверку третьего задания");
                    Test3 check3 = new Test3();
                    check3.Testum();
                    break;

                case "4":
                    Console.WriteLine("Вы выбрали проверку четвертого задания");
                    Test4 check4 = new Test4();
                    check4.Testum();
                    break;

                case "5":
                    Console.WriteLine("Вы выбрали проверку пятого задания");
                    Test5 check5 = new Test5();
                    check5.Testum();
                    break;

                case "6":
                    Console.WriteLine("Вы выбрали проверку шестого задания");
                    Test6 check6 = new Test6();
                    check6.Testum();
                    break;

                case "7":
                    Console.WriteLine("Вы выбрали проверку седьмого задания");
                    Test7 check7 = new Test7();
                    check7.Testum();
                    break;

                default:
                    Console.WriteLine("К сожалению, задания с таким номером не существует");
                    break;
            }
            Console.ReadKey();
        }
    }
}
