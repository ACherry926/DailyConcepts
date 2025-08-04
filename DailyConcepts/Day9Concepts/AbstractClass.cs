using System;

namespace Day9Concepts
{
    class AbstractClassExamples
    {
        public void AbstractClassmethod()
        {
            Customer customer = new Worker();
            customer.PrintAbstract();
        }
        public abstract class Customer
        {
            public abstract void PrintAbstract();
        }
        public class Worker : Customer
        {
            public override void PrintAbstract()
            {
                Console.WriteLine("Print Abstract  Method");
            }
        }

        /// <summary>
        /// Abstract Class Vs Interfaces
        /// Abstract Class members can have acceess modifiers
        /// </summary>
        public abstract class Customers
        {
            int Id;
            public void PrintAbstract()
            {
                Console.WriteLine("Print");
            }
        }

        /// <summary>
        /// A class can Inherit from Multiple interfaces at the same time
        /// </summary>
        public interface ICustomers
        {
            void PrintInterface();
        }

        /// <summary>
        /// Multiple Class Inheritance
        /// </summary>
        public void MultipleClassInheritancemethod()
        {
            Dclass dclass = new Dclass();
            dclass.Print();
        }
        class Aclass
        {
            public virtual void Print()
            {
                Console.WriteLine("A Implementation");
            }
        }
        class Bclass : Aclass
        {
            public override void Print()
            {
                Console.WriteLine("B Implementation");
            }
        }
        class Cclass : Aclass
        {
            public override void Print()
            {
                Console.WriteLine("C Implementation");
            }
        }
        class Dclass : Bclass
        {

        }

        /// <summary>
        /// Multiple Interface Inheritance
        /// </summary>
        public void MultipleClassInheritanceUsingInterfaceMethod()
        {
            AB ab = new AB();
            ab.AMethod();
            ab.BMethod();
        }
        interface IA
        {
            void AMethod();
        }
        class A1 : IA
        {
            public void AMethod()
            {
                Console.WriteLine("A");
            }
        }
        interface IB
        {
            void BMethod();
        }
        class B1 : IB
        {
            public void BMethod()
            {
                Console.WriteLine("B");
            }
        }
        class AB : IA, IB
        {
            A1 a = new A1();
            B1 b = new B1();
            public void AMethod()
            {
                a.AMethod();
            }
            public void BMethod()
            {
                b.BMethod();
            }
        }
    }
}
