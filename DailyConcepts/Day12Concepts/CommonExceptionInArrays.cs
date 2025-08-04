using System;

namespace Day12Concepts
{
    class CommonExceptionInArraysConcept
    {
        public void CommonExceptionInArraysExample()
        {
            string[] planets = new string[2];
            planets[0] = "Mercury";
            planets[1] = "Venus";

            foreach (var planet in planets)
            {
                Console.WriteLine(planet);
            }

            Console.ReadKey();
        }
    }
}
