using System;
using System.Collections.Generic;

namespace Day14Concepts
{
    class DictionaryConcepts
    {
        public void DictionaryMethods()
        {
            List<string> monthNames = new List<string>();
            monthNames.Add("January");
            monthNames.Add("February");
            monthNames.Add("March");
            monthNames.Add("April");
            monthNames.Add("May");
            monthNames.Add("June");
            monthNames.Add("July");
            monthNames.Add("August");
            monthNames.Add("September");
            monthNames.Add("October");
            monthNames.Add("November");
            monthNames.Add("December");

            var march  = monthNames[2];
            var april  = monthNames[2];

            var months  = new Dictionary<int, string>()
            {
                { 1, "January"},
                { 2, "February"},
                { 3, "March"},
                { 4, "April"},
                { 5, "May"},
                { 6, "June"},
            };
            months[7] = "July";
            months[8] = "August";

                months.Add(10, "October");
                months.Add(11, "November");
                months.Add(12, "December");

            var days = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

            days["sun"] = "Sunday";
            days["mon"] = "Monday";

            var sunday = days["sun"];
            Console.WriteLine("Accessed: " + sunday);

            if (days.TryGetValue("sun", out string sun))
            {
                Console.WriteLine("Found using TryGetValue: " + sun);
            }

            foreach (var kvp in days)
            {
                Console.WriteLine($"key: {kvp.Key}, value: {kvp.Value}");
            }

            foreach (var value in days.Values)
            {
                Console.WriteLine("Value: " + value);
            }

            if (days.ContainsValue("Sunday"))
            {
                Console.WriteLine("The value 'Sunday' exists in the dictionary.");
            }

            //if (days.ContainsKey("sun"))
            //{
            //    days.Remove("sun");
            //}

            Console.ReadKey();
        }
    }
}
