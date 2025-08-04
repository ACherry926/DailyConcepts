using System;

namespace Day8Concepts
{
    class GetSetProperties
    {
        /// <summary>
        /// Get SET Properties
        /// </summary>
        public void GetSetPropertiesMethod()
        {
            Student student = new Student(); ;
            student.SetId(101);
            student.SetName("Mark");

            Console.WriteLine("Student Id = {0}", student.GetId());
            Console.WriteLine("Student Name = {0}", student.GetName());
            Console.WriteLine("PassMark = {0}", student.GetPassMark());
        }       
        public class Student
        {
            private int _id;
            private string _name;
            private int _passMark = 35;

            public void SetId(int Id)
            {
                if (Id <= 0)
                {
                    throw new Exception("Student Id cannote be Negative");
                }
                this._id = Id;
            }

            public int GetId()
            {
                return this._id;
            }

            public void SetName(string Name)
            {

                if (string.IsNullOrEmpty(Name))
                {
                    throw new Exception("Name cannot be Null or Empty");
                }
                this._name = Name;
            }
            public string GetName()
            {
                return string.IsNullOrEmpty(this._name) ? "No Name" : this._name;
                //if (string.IsNullOrEmpty(_name))
                //{
                //    return "No Name";
                //}
                //else
                //{
                //    return this._name;
                //}
            }

            public int GetPassMark()
            {
                return this._passMark;
            }
        }

        /// <summary>
        /// Read Write Properties
        /// </summary>
        public void ReadWritePropertiesMethod()
        {
            Student1 student1 = new Student1();
            student1.Id = 101;
            student1.Name = "Mark";

            Console.WriteLine("Student ID = {0}", student1.Id);
            Console.WriteLine("Student Name = {0}", student1.Name);
            Console.WriteLine("PassMark = {0}", student1.PassMark);
        }
        public class Student1
        {
            private int _Id;
            private string _Name;
            private int _PassMark = 35;
            private string _City;

            public string Email { get; set; }

            public string City
            {
                get
                {
                    return this._City;
                }
                set
                {
                    this._City = value;
                }
            }

            public int Id
            {
                set
                {
                    if (value <= 0)
                    {
                        throw new Exception("Student Id cannote be Negative");
                    }
                    this._Id = value;
                }
                get
                {
                    return this._Id;
                }

            }
            public string Name
            {
                set
                {

                    if (string.IsNullOrEmpty(value))
                    {
                        throw new Exception("Name cannot be Null or Empty");
                    }
                    this._Name = value;
                }
                get
                {
                    return string.IsNullOrEmpty(this._Name) ? "No Name" : this._Name;
                }
            }
            public int PassMark
            {
                get
                {
                    return this._PassMark;
                }

            }
        }
    }
}
