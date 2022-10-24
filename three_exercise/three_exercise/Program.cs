using System;

class Program
    {
        static void Main(string[] args)
        {
        
            Console.WriteLine("Введите номер месяца");
            int mounthN = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите год");
            int year = Convert.ToInt32(Console.ReadLine());

            switch (mounthN)
            {
                case 1: Console.Write("Январь - 31 день"); break;
                case 2:
                    if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
                    {
                        Console.Write("Февраль - 29 дней");
                    }
                    else
                    {
                        Console.Write("Февраль - 28 дней");
                    }
                    break;
                case 3: Console.Write("Март - 31 день"); break;
                case 4: Console.Write("Апрель - 30 дней"); break;
                case 5: Console.Write("Май - 31 день"); break;
                case 6: Console.Write("Июнь - 30 дней"); break;
                case 7: Console.Write("Июль - 31 день"); break;
                case 8: Console.Write("Август - 31 день"); break;
                case 9: Console.Write("Сентябрь - 30 дней"); break;
                case 10: Console.Write("Октябрь - 31 день"); break;
                case 11: Console.Write("Ноябрь - 30 дней"); break;
                case 12: Console.Write("Декабрь - 31 день"); break;
            }


        }
}
