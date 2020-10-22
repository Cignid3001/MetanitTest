using System;

namespace StudyTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Какой блок заданий вы хотите проверить? \n1.Условные конструкции\n2.Циклы\n3.Массивы");
            string expl = Console.ReadLine();
            switch (expl)
            {
                case "1":
                    Console.WriteLine("Тема 1. Условные конструкции.\nВыберите номер задания для проверки от 1 до 7");
                    string choosen1 = Console.ReadLine();

                    switch (choosen1)
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
                    break;

                case "2":
                    Console.WriteLine("Тема 2. Циклы. Выберите номер задания от 1 до 4");
                    string choosen2 = Console.ReadLine();
                    switch (choosen2)
                    {
                        case "1":
                            Console.WriteLine("Вы выбрали проверку первого задания");
                            TestCircle1 check11 = new TestCircle1();
                            check11.Testum();
                            break;

                        case "2":
                            Console.WriteLine("Вы выбрали проверку второго задания");
                            TestCircle2 check12 = new TestCircle2();
                            check12.Testum();
                            break;

                        case "3":
                            Console.WriteLine("Вы выбрали проверку третьего задания");
                            TestCircle3 check13 = new TestCircle3();
                            check13.Testum();
                            break;

                        case "4":
                            Console.WriteLine("Вы выбрали проверку четвертого задания");
                            TestCircle4 check14 = new TestCircle4();
                            check14.Testum();
                            break;

                        default:
                            Console.WriteLine("К сожалению, задания с таким номером не существует");
                            break;
                    }

                    break;
            }
            Console.ReadKey();
        }
    }
}
