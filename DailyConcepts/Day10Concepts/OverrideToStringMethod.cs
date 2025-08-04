using System;

namespace Day10Concepts
{
    class OverrideToStringMethodExamples
    {
        public void OverrideToStringMethod()
        {
            int number = 10;
            Console.WriteLine(number.ToString());

            Barrier barrier = new Barrier();
            barrier.FirstName = "Simon";
            barrier.LastName = "Tan";
            Console.WriteLine(Convert.ToString(barrier));
        }

        /// <summary>
        /// Override To String Method
        /// </summary>
        public class Barrier
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public override string ToString()
            {
                return this.LastName + " , " + this.FirstName;
            }
        }
    }
}
