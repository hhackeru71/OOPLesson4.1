using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //base
            //ליצור מחלקה של חיות
            //prop
            //שם של החיה
            //גיל החיה
            //

            //dervied
            //ליצור מחלקה של כלב
            //prop
            // כמה שנים עוד נותר לחיה לחיות

            //לרשת מתוך המחלקה חיות למחלקה כלב 
            //לתת ערכים לכל הprop
            //ולהדפיס את כל הprop מתוך מחלקה כלב


            //אבא  base 
            Person person = new Person()
            {
                FirstName = "sdf",
                LastName = "sdf"
            };
            //person.Print();

            //ילד  Derived
            Students st = new Students
            {
                FirstName = "dd",
                Grade = 13,
                LastName = "sdf"
            };
            st.Print();

           

            //Dervied נכד
            SuperStudents super = new SuperStudents
            {
                Age = 30,
                FirstName = "sdf",
                Grade = 30,
                LastName = "sdfsd"
            };
           // Console.WriteLine($"{st.LastName},{st.FirstName},{st.Grade}");

        }
    }


    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public  void Print()
        {
            Console.WriteLine("person");
        }
    }

    //Inheritance הורשה 
    class Students : Person
    {
        public int Grade { get; set; }

        //public new void Print()
        //{
        //    Console.WriteLine("Students");
        //}

    }
    //Inheritance 
    class SuperStudents : Students
    {
        public int Age { get; set; }

    }
}