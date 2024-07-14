using System;
namespace Student.SharpInstructions
{
    class Program
    {

        static void Main()
        {
            while(true) 
            {
                Console.WriteLine("Для вызова выполняемой подпрограммы укажите ее номер и нажните Enter:\r\n1 - IF ELSE\r\n2 - WHILE\r\n3 - DO WHILE\r\n4 - FOR\r\n5 - FOREACH\r\n6 - SWITCH");
                switch (Console.ReadLine())
                {
                    case "1":
                        IF_ELSE();
                        break;
                    case "2":
                        WHILE();
                        break;
                    case "3":
                        DO_WHILE();
                        break;
                    case "4":
                        FOR();
                        break;
                    case "5":
                        FOREACH();
                        break;
                    case "6":
                        SWITCH();
                        break;
                }
            }
        }
        static void IF_ELSE()
        {
            while (true)
            {
                Console.WriteLine("Для выполнения подпрограммы IF ELSE введите число нажмите Enter\r\n\t");
                int number = int.Parse(Console.ReadLine());
                if (number > 0)
                {
                    Console.WriteLine("Число положительное.");
                }
                else if (number < 0)
                {
                    Console.WriteLine("Число отрицательное.");
                }
                else
                {
                    Console.WriteLine("Число равно нулю.");
                }
                Console.WriteLine("Для повтора выполнения подпрограммы нажмите Enter, для возврата к списку подпрограмм нажмите Esc:\r\n");
                if (EXIT())
                {
                    break;
                }
                else
                {
                    continue;
                }
            }
        }
        static void WHILE()
        {
            while (true)
            {
                Console.WriteLine("Для выполнения подпрограммы WHILE введите число нажмите Enter\r\n\t");
                int count = 0;
                int maxCount = int.Parse(Console.ReadLine());

                while (count < maxCount)
                {
                    Console.WriteLine($"Повторение номер {count + 1}");
                    count++;
                }
                Console.WriteLine("Для повтора выполнения подпрограммы нажмите Enter, для возврата к списку подпрограмм нажмите Esc:\r\n");
                if (EXIT())
                {
                    break;
                }
                else
                {
                    continue;
                }
            }
        }
        static void DO_WHILE()
        {
            while(true)
            {
                Console.WriteLine("Для выполнения подпрограммы DO_WHILE введите число нажмите Enter\r\n\t");
                int count = 0;
                int maxCount = int.Parse(Console.ReadLine());
                do
                {
                    Console.WriteLine($"Повторение номер {count + 1}");
                    count++;
                } while (count < maxCount);
                Console.WriteLine("Для повтора выполнения подпрограммы нажмите Enter, для возврата к списку подпрограмм нажмите Esc:\r\n");
                if (EXIT())
                {
                    break;
                }
                else
                {
                    continue;
                }
            }
        }
        static void FOR()
        {
            while (true)
            {
                Console.WriteLine("Для выполнения подпрограммы FOR введите начальное число и количество повторений последовательно через Enter\r\n\t");
                int a1 = int.Parse(Console.ReadLine());
                int a2 = int.Parse(Console.ReadLine());
                int[] a = new int[2] { a1, a2 };
                for (int i = a[0]; i <= a[1]; i++)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("Для повтора выполнения подпрограммы нажмите Enter, для возврата к списку подпрограмм нажмите Esc:\r\n");
                if (EXIT())
                {
                    break;
                }
                else
                {
                    continue;
                }

            }
        }
        static void FOREACH()
        {
            while (true)
            {
                List<string> items = new List<string> { "яблоко", "банан", "апельсин" };

                foreach (string item in items)
                {
                    Console.WriteLine($"Элемент: {item}");
                }
                Console.WriteLine("Для повтора выполнения подпрограммы нажмите Enter, для возврата к списку подпрограмм нажмите Esc:\r\n");
                if (EXIT())
                {
                    break;
                }
                else
                {
                    continue;
                }
            }
        }
        static void SWITCH()
        {
            while (true)
            {
                Console.WriteLine("Для выполнения подпрограммы SWITCH введите одно число в диапозоне от 1 до 7 нажмите Enter\r\n\t");
                int day = int.Parse(Console.ReadLine());

                switch (day)
                {
                    case 1:
                        Console.WriteLine("Понедельник");
                        break;
                    case 2:
                        Console.WriteLine("Вторник");
                        break;
                    case 3:
                        Console.WriteLine("Среда");
                        break;
                    case 4:
                        Console.WriteLine("Четверг");
                        break;
                    case 5:
                        Console.WriteLine("Пятница");
                        break;
                    case 6:
                        Console.WriteLine("Суббота");
                        break;
                    case 7:
                        Console.WriteLine("Воскресенье");
                        break;
                    default:
                        Console.WriteLine("Некорректный ввод. Введите число от 1 до 7.");
                        break;
                }
                Console.WriteLine("Для повтора выполнения подпрограммы нажмите Enter, для возврата к списку подпрограмм нажмите Esc:\r\n");
                if (EXIT())
                {
                    break;
                }
                else
                {
                    continue;
                }
            }
        }
        static bool EXIT()
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);

            if (keyInfo.Key == ConsoleKey.Escape)
            {
                Console.WriteLine("...");
                return true;
            }
            return false;
        }
    }
}