using System;
using System.Collections.Generic;
using System.Linq;

namespace Day21Concepts
{
    public class FirstVsFirstOrDefault
    {
        public void FirstExample() 
        {
            List<int> numbers = LastVsLastOrDefault.GetNumbers();

            var methodSyntax = numbers.First();
            var methodSyntax1 = numbers.Where(number => number > 5).First();
            var methodSyntax2 = numbers.First(number => number > 6); // It is best to use

            Console.WriteLine(methodSyntax);
        }

        public void FirstOrDefaultExample()
        {
            List<int> numbers = LastVsLastOrDefault.GetNumbers();

            var methodSyntax = numbers.FirstOrDefault(number => number > 10);

            Console.WriteLine(methodSyntax);
        }

        public void FirstVsFirstOrDefaultForStringExample()
        {
            var users = new List<User>()
            {
                new User() { Id = 1, UserName = "Admin", Password = "Admin" },
                new User() { Id = 1, UserName = "UserA", Password = "UserA" },
                new User() { Id = 1, UserName = "UserB", Password = "UserB" },
                new User() { Id = 1, UserName = "UserC", Password = "UserC" }
            };

            var methodSyntax = users.First(x => x.UserName == "Admin" && x.Password == "Admin");
            var mixedSyntax = (from user in users
                               select user).First(x => x.UserName == "UserA" && x.Password == "UserA");

            Console.WriteLine(methodSyntax);
        }
    }
}
