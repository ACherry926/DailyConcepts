using System;
using System.Linq;

namespace Day12Concepts
{
    class ArraysComparisionConcept
    {
        public void ArraysComparisionExample()
        {
            string[] daysOfWeekday1 =
            {
                "Sunday",
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday"
            };

            string[] daysOfWeekday2 =
            {
                 "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"
            };

            bool isEqual = daysOfWeekday1 == daysOfWeekday2;
            Console.WriteLine($"is daysOfWeek_day1 == daysOfWeek_day2:{isEqual}");
            bool isSequenceEqual = daysOfWeekday1.SequenceEqual(daysOfWeekday2);
            Console.WriteLine($"\nisSequenceEqual = {isSequenceEqual}");
        }
    }
}
