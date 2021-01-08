using System;
using System.Collections.Generic;

namespace Day5
{
    class DatePrinter
    {
        public static DateTime ParseDate()
        {
            Console.WriteLine("Введите час:");
            string input = Console.ReadLine();
            int hour;

            try
            {
                hour = Convert.ToInt32(input);
            }
            catch
            {
                Console.WriteLine("Введите час в числовом формате!");
                hour = -1;
            }
            if (hour < 0 || hour > 23)
            {
                Console.WriteLine("Введите время в промежутке от 0 до 23!");
                return DateTime.MinValue; //сигнал о том, что что-то пошло не так
            }

            DateTime date = new DateTime(2020, 01, 01, hour, 0, 0);
            return date;
        }

        public static void PrintDate(DateTime date)
        {
            if (date == DateTime.MinValue) //проверяем, не пошло-ли что-то не так в функции ParseDate
                return; 

            int hour = date.Hour;
            string dayPart;
            string[] weather = { "солнечная", "дождливая" };
            Random random = new Random();
            int index = random.Next(weather.Length);

            if (hour >= 0 && hour < 6)
                dayPart = "ночи";
            else if (hour >= 6 && hour < 12)
                dayPart = "утра";
            else if (hour >= 12 && hour < 18)
                dayPart = "дня";
            else
                dayPart = "вечера";

            Console.WriteLine($"Сейчас {date:hh} час/часа/часов {dayPart}, погода {weather[index]}");
        }
    }
}
