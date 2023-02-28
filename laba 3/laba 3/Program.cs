using System;

namespace laba_3
{
    internal class Program
    {
        enum Day
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday 
        }
         enum Time
        {
            morning,
            day,
            evening,
            night
        }

        static void dayr (int days)
        {
            Day day = (Day)days;

            switch (day)
            {
                case Day.Monday:
                    Console.WriteLine("Понедельник");
                    break;
                case Day.Tuesday:
                    Console.WriteLine("Вторник");
                    break;
                case Day.Wednesday:
                    Console.WriteLine("Среда");
                    break;
                case Day.Thursday:
                    Console.WriteLine("Четверг");
                    break;
                case Day.Friday:
                    Console.WriteLine("Пятница");
                    break;
                case Day.Saturday:
                    Console.WriteLine("Суббота");
                    break;
                case Day.Sunday:
                    Console.WriteLine("Воскресенье");
                    break;
            }
        }

        static void sutkir (int sutki)
        {
            if (sutki >= 7 & sutki <= 12)
            {
                Console.WriteLine("утро");
            }
            if (sutki >= 13 & sutki <= 18)
            {
                Console.WriteLine("день");
            }
            if (sutki >= 19 & sutki <= 23)
            {
                Console.WriteLine("вечер");
            }
            if (sutki >= 0 & sutki <= 6)
            {
                Console.WriteLine("ночь");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("введите день недели от 1 до 7:");
            int days = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("введите данные по типу: утро, день, вечер и ночь");
            int sutki = Convert.ToInt32(Console.ReadLine());

            if (days <= 7){
                Console.WriteLine("информация:");

                dayr(days);
                sutkir(sutki);
            }
            else
            {
                Console.WriteLine("Ошибка");
            }
           
            
        }
    }
}
