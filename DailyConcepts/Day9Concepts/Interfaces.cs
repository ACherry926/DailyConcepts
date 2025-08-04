using System;

namespace Day9Concepts
{
    class InterfaceExamples
    {
        public void InterfaceMethod()
        {
            Customer customer = new Customer();
            customer.Print1();
            customer.Print2();
        }
        interface ICustomer1
        {
            void Print1();
        }
        interface ICustomer2 : ICustomer1
        {
            void Print2();
        }
        class Customer : ICustomer2
        {
            public void Print2()
            {
                Console.WriteLine("Interface print Method");
            }
            public void Print1()
            {
                Console.WriteLine("I2 Method");
            }
        }

        /// <summary>
        /// ExplictInterfaceImplementation
        /// </summary>
        public void ExplictInterfaceExamplemethod()
        {
            //TypeCasting
            OperationsManager manager = new OperationsManager();
            ((IOperations)manager).PerformOperation();
            ((IActions)manager).PerformAction();

            IOperations operations = new OperationsManager();
            IActions actions = new OperationsManager();
            operations.PerformOperation();
            actions.PerformAction();
        }
        interface IOperations
        {
            void PerformOperation();
        }
        interface IActions
        {
            void PerformAction();
        }
        public class OperationsManager : IOperations, IActions
        {
            void IOperations.PerformOperation()
            {
                Console.WriteLine("IOperations Interface Method");
            }
            void IActions.PerformAction()
            {
                Console.WriteLine("IActions Interface Method");
            }
        }

        /// <summary>
        /// DefaultInterfaceImplementation
        /// </summary>
        public void DefaultInterfaceExampleMethod()
        {
            Teacher teacher = new Teacher();
            // Calling the default implementation
            teacher.InterfaceMethod1();
            // Calling the explicit implementation via type casting
            ((ISecondaryMethod)teacher).InterfaceMethod1();
        }
        interface IPrimaryMethod
        {
            void InterfaceMethod1();
        }
        interface ISecondaryMethod
        {
            void InterfaceMethod1();
        }
        public class Teacher : IPrimaryMethod, ISecondaryMethod
        {
            public void InterfaceMethod1()
            {
                Console.WriteLine("IPrimaryMethod Default Interface Method");
            }
            void ISecondaryMethod.InterfaceMethod1()
            {
                Console.WriteLine("ISecondaryMethod Default Interface Method");
            }
        }
    }
}
