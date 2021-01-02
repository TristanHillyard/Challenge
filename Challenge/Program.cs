using System;

namespace Challenge
{
    class Program
    {
        enum DaysOftheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the current day of the week");
            string today = Console.ReadLine();
            DayOfWeek day;
            try
            {
                day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), today);
            }
            catch
            {
                Console.WriteLine("Please enter an actual day of the week");
            }
        }
    }
}
