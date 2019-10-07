using System;
using System.Globalization;

namespace lab_just_do_it_17_enum_with_tests
{
    public class Program
    {
        enum days { NONE, MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY };
        enum months { NONE, JANUARY, FEBRUARY, MARCH, APRIL, MAY, JUNE, JULY, AUGUST, SEPTEMBER, OCTOBER, NOVEMEBER, DECEMBER };
        static void Main(string[] args)
        {

            days myDay = days.WEDNESDAY;
            months myMonth = months.DECEMBER;


            var test = TestEnums.GetDayMonth((int)myDay, (int)myMonth);

            Console.WriteLine($"day: {test.Item1}, Month {test.Item2}");

        }
    }

    public class TestEnums
    {
        public static (string, string) GetDayMonth(int day, int month)
        {
            DateTimeFormatInfo dt = new DateTimeFormatInfo();

            return (dt.GetDayName((DayOfWeek)day), dt.GetMonthName(month));
        }
    }
}