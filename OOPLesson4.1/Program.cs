using OOPLesson4._1;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //ליצור מחלקה מוסך
            // prop 
            //סוג מכונית

            //ליצור בנאי שמקבל את סוג המכונית ושם את הערך בתוך הprop 

            // פונקציה שמחזירה מחרוזת של סוג המכונית
            
            //
            //ליצור מחלקת רכב
            // prop צבע המכונית 

            //בנאי שמקבל את סוג המכונית וגם את צבע המכונית
            //עושה השמה לprop  בשימוש base 
            //פונקציה שמחזירה מחרוזת של סוג המכונית + צבע המכונית להשתמש  base

            //להדפיס בmain




            //Dog dog = new Dog
            //{
            //    Age = 30,
            //    Life = 30,
            //    Name = "asd"
            //};
            //Console.WriteLine($"{dog.Name}{dog.Life}{dog.Age}");
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
            //Person person = new Person()
            //{
            //    FirstName = "sdf",
            //    LastName = "sdf"
            //};
            //person.Print();

            //ילד  Derived
            Students st = new Students("yarin", "sh", 80);
            Console.WriteLine($"{st.LastName},{st.FirstName},{st.Grade}");


            ////Dervied נכד
            //SuperStudents super = new SuperStudents
            //{
            //    Age = 30,
            //    FirstName = "sdf",
            //    Grade = 30,
            //    LastName = "sdfsd"
            //};


        }
    }



    //base
    class Person
    {

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Print()
        {
            return $"{FirstName},{LastName}";
        }
    }

    //Inheritance הורשה 
    class Students : Person
    {
        public Students(string firstName, string lastName,int grade)
         :base(firstName, lastName)
        {
            Grade = grade;
        }
         
        public int Grade { get; set; }

        public new string Print()
        {
            return base.Print() + $"{Grade}";
        }

    }
    ////Inheritance 
    //class SuperStudents : Students
    //{
    //    public int Age { get; set; }

    //}
}