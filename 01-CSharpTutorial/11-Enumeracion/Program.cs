using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Enumeracion
{
    class Program
    {
        static void Main(string[] args)
        {
            WeekDays dia1 = WeekDays.monday;
            WeekDays dia2 = WeekDays.tuesday;
            WeekDays dia3 = WeekDays.thursday;
            Console.WriteLine((int)dia1);
            Console.WriteLine((int)dia2);

            Console.WriteLine(dia1);
            Console.WriteLine(dia2);
            Console.WriteLine(dia3);

            Console.WriteLine((int)WeekDays.monday);
            Console.WriteLine((int)WeekDays.tuesday);
            Console.WriteLine((int)WeekDays.thursday);

            Console.WriteLine(WeekDays.monday);
            Console.WriteLine(WeekDays.tuesday);
            Console.WriteLine(WeekDays.thursday);

            categories categoria1 = categories.Automotive;
            categories categoria2 = categories.Arts;
            Console.WriteLine((int)categoria1);
            Console.WriteLine((int)categoria2);

            int day = (int)WeekDays.friday;
            Console.WriteLine(day);

            WeekDays weekday = (WeekDays)5;
            Console.WriteLine(weekday);

            Categories2 categoria3 = Categories2.Automotive;
            Categories2 categoria4 = Categories2.Fashion;
            Categories2 categoria5 = Categories2.WomanFashion;
            Console.WriteLine("-------------------------------------");
            Console.WriteLine((int)categoria3);
            Console.WriteLine((int)categoria4);
            Console.WriteLine((int)categoria5);

        }
    }

    enum Categories2: byte 
    {

        Automotive = 255,
        electronics = 1,
        food = 5,
        Arts = 10,
        BeautyCare = 11,
        Fashion = 15,
        WomanFashion = 15

    }

    enum WeekDays
    {
        monday,
        tuesday,
        wendnesday,
        thursday,
        friday,
        saturday,
        sunday
    }

    enum categories
    {
        Electronics,    // 0
        Food,           // 1
        Automotive = 6, // 6
        Arts,           // 7
        BeautyCare,     // 8
        Fashion         // 9
    }

}
