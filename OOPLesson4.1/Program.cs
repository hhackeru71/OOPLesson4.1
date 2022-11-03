using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //אבא  base 
            Person person = new Person()
            {
                FirstName = "sdf",
                LastName = "sdf"
            };


            //ילד  Derived
            Students st = new Students
            {
                FirstName = "dd",
                Grade = 13,
                LastName = "sdf"
            };

            //Dervied נכד
            SuperStudents super = new SuperStudents
            {
                Age = 30,
                FirstName = "sdf",
                Grade = 30,
                LastName = "sdfsd"
            };
            Console.WriteLine($"{st.LastName},{st.FirstName},{st.Grade}");




        }
    }


    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Students : Person
    {
        public int Grade { get; set; }
        //public Students(int grade)
        //{
        //    Grade = grade;
        //}
    }

    class SuperStudents : Students
    {
        public int Age { get; set; }

    }
}