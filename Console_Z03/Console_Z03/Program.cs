using System;

namespace Console_Z03
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repit = true;
            while (repit == true)
            {
                try
                {
                    Console.WriteLine("| Введите число.");
                    Console.Write("| : ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("|-------------------------------------------------");

                    Console.WriteLine("| Бесполезный цикл для демонстрации");
                    if (n < 999)
                    {
                        for (int i = 0; i < n + 1; i++) // Бесполезная демонстрация
                        {
                            switch (i.ToString().Length)
                            {
                                case 1:
                                    Console.Write("| i = {0},   f(i) = {1}\n", i, f(i));
                                    break;
                                case 2:
                                    Console.Write("| i = {0},  f(i) = {1}\n", i, f(i));
                                    break;
                                case 3:
                                    Console.Write("| i = {0}, f(i) = {1}\n", i, f(i));
                                    break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("|-------------------------------------------------");
                        Console.WriteLine("| Приложение не созданно для форматирования цикла больше чем 999");
                    }

                    Console.WriteLine("|-------------------------------------------------");
                    if (f(n) != 0)
                        Console.WriteLine("| Число {0} четное, произведена операция\n| деление на 2. Ответ: {1}", n, f(n));
                    else
                        Console.WriteLine("| Число {0} не четное, произведена операция\n| замена на 0. Ответ: {1}", n, f(n));
                    rep(out repit);
                }
                catch (Exception)
                {
                    Console.WriteLine("|-------------------------------------------------");
                    Console.WriteLine("| Некорректный ввод данных!");
                    rep(out repit);
                }
            }
        }
        private static int f(int x)
        {
            if (x % 2 == 0)
                return x / 2;
            else
                return 0;
        }
        static void rep(out bool repit) //Просто продолжение вынес в метод
        {
            Console.WriteLine("|-------------------------------------------------");
            Console.WriteLine("| Попробовать снова? Да / Нет");
            Console.Write("| : ");
            string repitTxT = Convert.ToString(Console.ReadLine());

            if (repitTxT == "Да")
            {
                repit = true;
                Console.WriteLine("|-------------------------------------------------");
            }
            else if (repitTxT == "Нет")
                repit = false;
            else
            {
                Console.WriteLine("|-------------------------------------------------");
                Console.WriteLine("| Некорректный ввод данных!");
                repit = false;
            }
        }
    }
}