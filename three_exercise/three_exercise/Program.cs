using System;

namespace _3in1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\nЗадание 4.107 ");

            Console.WriteLine("Введите номер месяца");
            int mounthN = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите год");
            int year = Convert.ToInt32(Console.ReadLine());

            switch (mounthN)
            {
                case 1: Console.Write("\nЯнварь - 31 день"); break;
                case 2:
                    if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
                    {
                        Console.Write("\nФевраль - 29 дней");
                    }
                    else
                    {
                        Console.Write("\nФевраль - 28 дней");
                    }
                    break;
                case 3: Console.Write("\nМарт - 31 день"); break;
                case 4: Console.Write("\nАпрель - 30 дней"); break;
                case 5: Console.Write("\nМай - 31 день"); break;
                case 6: Console.Write("\nИюнь - 30 дней"); break;
                case 7: Console.Write("\nИюль - 31 день"); break;
                case 8: Console.Write("\nАвгуст - 31 день"); break;
                case 9: Console.Write("\nСентябрь - 30 дней"); break;
                case 10: Console.Write("\nОктябрь - 31 день"); break;
                case 11: Console.Write("\nНоябрь - 30 дней"); break;
                case 12: Console.Write("\nДекабрь - 31 день"); break;
            }


          


        }
    }
}