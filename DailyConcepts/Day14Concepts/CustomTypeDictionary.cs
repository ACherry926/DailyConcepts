using System;
using System.Collections.Generic;

namespace Day14Concepts
{
    class CustomTypeDictionary
    {
        public void CustomTypeDictionaryMethod()
        {
            var ambassadors = new Dictionary<CountryCode, Ambassador>();

            Ambassador england = new Ambassador
            {
                CountryCode = new CountryCode("england"),
                Name = "jhon",
                Age = 25
            };

            Ambassador austriala = new Ambassador
            {
                CountryCode = new CountryCode("austriala"),
                Name = "Martin",
                Age = 49
            };

            ambassadors.Add(england.CountryCode, austriala);
            ambassadors.Add(austriala.CountryCode, austriala);

            Console.WriteLine("Enter Country Code: ");
            var code = Console.ReadLine(); 
            
            if (ambassadors.TryGetValue(new CountryCode(code), out Ambassador ambassador))
            {
                Console.WriteLine($"The ambassador is {ambassador.Name}");
            }
            else
            {
                Console.WriteLine("The ambassador with the given code dose not exist" + "in the Dictionary");
            }
            Console.ReadKey();  
        }
    }

    public class CountryCode
    {
        public string Code { get; set; }

        public CountryCode(string code) 
        { 
            Code = code;
        }

        public override bool Equals(object other)
        {
            if(other == null)
            {
                return false;
            }
            if(!(other is CountryCode))
            {
                return false;
            }
            return StringComparer.OrdinalIgnoreCase.Equals(this.Code, ((CountryCode)other).Code);
        }
        public override int GetHashCode()
        {
            return StringComparer.OrdinalIgnoreCase.GetHashCode(this.Code); 
        }
    }

    public class Ambassador
    {
        public CountryCode CountryCode { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
