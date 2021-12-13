using System;

namespace Console_Z03_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("| Нахождение Y если X принадлежит A,B.");
            bool repit = true;
            while (repit == true)
            {   
                try
                {
                    Console.WriteLine("| Введите промежуток.");
                    Console.Write("| A : ");
                    double a = Convert.ToDouble(Console.ReadLine()); ;
                    Console.Write("| B : ");
                    double b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("| Введите шаг.");
                    Console.Write("| H : ");
                    double h = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("|----------------------------------");
                    if (a < b)
                    {   
                        if (h > 0)
                        {
                            while (a <= b)
                            {
                                f(a);
                                a = a + h;
                            }

                            Console.WriteLine("|----------------------------------");
                            rep(out repit);
                        }
                        else
                        {
                            Console.WriteLine("| H должно быть больше 0!");
                            rep(out repit);
                        }   
                    }
                    else
                    {
                        Console.WriteLine("| A должно быть меньше B!");
                        rep(out repit);
                    }                    
                }
                catch (Exception)
                {
                    Console.WriteLine("|----------------------------------");
                    Console.WriteLine("| Некорректный ввод данных!");
                    rep(out repit);
                }
            }
        }
        static void f(double x)
        {
            double y;
            if (x < 1) 
                Console.WriteLine("| x = {0}, y = {1}", Math.Round(x, 3), Math.Round(y = ((x * x) - 1) * ((x * x) - 1), 3));
            else if (x > 1)
                Console.WriteLine("| x = {0}, y = {1}", Math.Round(x, 3), Math.Round(y = 1 / ((1 + x) * (1 + x)), 3)); 
            else if (x == 1)
                Console.WriteLine("| x = {0}, y = {1}", Math.Round(x, 3), Math.Round(y = 0, 3));
        }
        
        static void rep(out bool repit)
        {
            Console.WriteLine("| Попробовать снова? Да / Нет");
            Console.Write("| : ");
            string repitTxT = Convert.ToString(Console.ReadLine());

            if (repitTxT == "Да")
            {
                repit = true;
                Console.WriteLine("|----------------------------------");
            }
            else if (repitTxT == "Нет")
                repit = false;
            else
            {
                Console.WriteLine("|----------------------------------");
                Console.WriteLine("| Некорректный ввод данных!");
                repit = false;
            }
        }
    }
}
