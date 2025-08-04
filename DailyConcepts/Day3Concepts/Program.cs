using System;

namespace Day3Concepts
{
    public class Program
    {
        static void Main(string[] args)
        {
            ImplicitConversion();
            ExplicitConversion();
            ExplicitConversions();
            OverFlowExpection();
            Boxing();
            UnBoxing();
            Prase();
            TryPrase();
            DefaultValue();
            IntegerArrayExample();
            IntegerInLineExample();
            StringArrayExample();
            StringArrayInLineExample();
            Testmethod();
        }

        /// <summary>
        /// Conversions:-
        /// 1. Implicit Conversion => No loss
        /// 2. Explicit Conversion => Some loss => TypeCast Operator, Convert Class
        /// </summary>
        static void ImplicitConversion()
        {
            float originalFloat = 123.25F;
            Console.WriteLine(originalFloat);

            int convertedInt = (int)originalFloat;
            long convertedLong = (long)originalFloat;

            Console.WriteLine("After Conversion");
            Console.WriteLine(convertedInt);
            Console.WriteLine(convertedLong);
        }

        static void ExplicitConversion()
        {
            float originalFloatValue = 123.25F;
            Console.WriteLine(originalFloatValue);

            int convertedIntValue = (int)originalFloatValue;
            long convertedLongValue = (long)originalFloatValue;

            Console.WriteLine("After Conversion");
            Console.WriteLine(convertedIntValue);
            Console.WriteLine(convertedLongValue);
        }

        /// <summary>
        /// Typecaste Operator, 
        /// Convert Class
        /// </summary>
        static void ExplicitConversions()
        {
            float originalFloatValue = 123.25F;
            Console.WriteLine(originalFloatValue);

            int convertedIntValue1 = (int)originalFloatValue;
            int convertedIntValue2 = Convert.ToInt32(originalFloatValue);

            Console.WriteLine("After Conversion");
            Console.WriteLine(convertedIntValue1);
            Console.WriteLine(convertedIntValue2);
        }

        static void OverFlowExpection()
        {
            long maxLongValue = long.MaxValue;
            Console.WriteLine(maxLongValue);

            int truncatedIntValue = (int)maxLongValue;
            Console.WriteLine(truncatedIntValue);

            Console.WriteLine("After Conversion");

            // Uncommenting the next line will throw an overflow exception because the long value exceeds the range of an int 
            // int overflowIntValue = Convert.ToInt32(maxLongValue); 
            // Console.WriteLine(overflowIntValue);
        }

        /// <summary>
        /// Boxing => Value type to Reference type - implicit process
        /// value type => int, float, double, more
        /// Value Type to Object Type
        /// </summary>
        static void Boxing()
        {
            int value = 200;
            Console.WriteLine(value);

            // Boxing: Converting a value type to an object type
            object boxedValue = value;
            Console.WriteLine(boxedValue);
        }

        /// <summary>
        /// UnBoxing => Reference type to value type - Explicit process
        /// Reference type => object, string, array, more
        /// Object Type to Value Type
        /// </summary>
        static void UnBoxing()
        {
            object boxedValue = 100;
            Console.WriteLine(boxedValue);

            // Unboxing: Converting an object type back to a value type
            int unboxedValue = (int)boxedValue;
            Console.WriteLine(unboxedValue);
        }

        /// <summary>
        /// value types =>0
        /// Reference Type => null
        /// </summary>
        static void Prase()
        {
            string number = "256";
            int number1 = int.Parse(number);
            long number2 = long.Parse(number);

            Console.WriteLine(number1);
            Console.WriteLine(number2);
        }

        static void TryPrase()
        {
            Console.WriteLine("Enter First Number");
            int.TryParse(Console.ReadLine(), out int firstNumber);

            Console.WriteLine("Enter Second Number");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"sum of first number {firstNumber} and " +
                              $"second number {secondNumber} is {firstNumber + secondNumber}");
        }

        static string stringNumber;
        static void DefaultValue()
        {
            if (stringNumber == null)
            {
                Console.WriteLine("Null Value");
            }
            else
            {
                Console.WriteLine(stringNumber);
            }
        }

        static void NullableTypes()
        {
            string number = null;
            Nullable<int> number1 = null;
            int? number2 = null;
            long? number3 = null;
            bool? bool1 = null;

            bool? areYouMajor = null;
            areYouMajor = false;
            areYouMajor = true;
        }

        /// <summary>
        /// Arrays :-
        ///  DataTypes[] variablename;
        /// syntax:-
        ///  DataType[] variablename = new DataType[size];
        /// </summary>
        static void IntegerArrayExample()
        {
            int[] employeeIds = new int[5];
            employeeIds[0] = 12;
            employeeIds[1] = 25;
            employeeIds[2] = 36;
            employeeIds[3] = 48;
            employeeIds[4] = 53;
            Console.WriteLine(employeeIds[0]);
            Console.WriteLine(employeeIds[1]);
            Console.WriteLine(employeeIds[2]);
            Console.WriteLine(employeeIds[3]);
            Console.WriteLine(employeeIds[4]);
        }

        static void IntegerInLineExample()
        {
            int[] employeeIds = new int[5] { 25, 40, 36, 48, 53 };
            int[] employeeIds2 = new int[] { 25, 40, 65, 98, 100, 210, 123 };
            int[] employeeIds3 = { 25, 40, 65, 98, 100, 210, 123 };
            Console.WriteLine(employeeIds3[0]);
            Console.WriteLine(employeeIds3[1]);
            Console.WriteLine(employeeIds3[2]);
            Console.WriteLine(employeeIds3[3]);
            Console.WriteLine(employeeIds3[4]);
        }

        static void StringArrayExample()
        {
            string[] employeeNames = new string[4];
            employeeNames[0] = "Rohith";
            employeeNames[1] = "Vinay";
            employeeNames[2] = "babu";
            employeeNames[3] = "kiran";

            Console.WriteLine(employeeNames[0]);
            Console.WriteLine(employeeNames[1]);
            Console.WriteLine(employeeNames[2]);
            Console.WriteLine(employeeNames[3]);
        }

        static void StringArrayInLineExample()
        {
            string[] employeeNames1 = new string[4] { "Rohith", "Vinay", "babu", "kiran" };
            string[] employeeNames2 = new string[] { "Rohith", "Vinay", "babu", "kiran" };
            string[] employeeNames3 = { "Rohith", "Vinay", "babu", "kiran" };

            Console.WriteLine(employeeNames1[0]);
            Console.WriteLine(employeeNames1[1]);
            Console.WriteLine(employeeNames1[2]);
            Console.WriteLine(employeeNames1[3]);
        }

        // page or xml comment
        /// <summary>
        /// This is a Test Method for Testing Xml comment
        /// </summary>
        static void Testmethod()
        {
            //multiline comment
            /*Console.WriteLine("Test1");
              Console.WriteLine("Test2");
              Console.WriteLine("Test3");
              Console.WriteLine("Test4");
              Console.WriteLine("Test5");*/

            // single line comment
            //Console.WriteLine("Test6");
        }
    }
}
