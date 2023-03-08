using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Objects_and_Classes
{
    internal class Student
    {
        public string name;// could be name="Elshen"; example of using class
        public string surname;
        public int age;
        public string speciality;
        public int groupNo;

        //public Student() // another example of using the class
        //{
        //    name = "Elshen";
        //}

        //or

        //Another example

        //public Student(string _name, int _age, string _surname, int _groupNo)
        //{
        //    this.name = _name;
        //}

        public override string ToString()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            return $"Student name is:{name} \nStudent Surname is:{surname} \nStudent age is:{age}\nStudent speciality is:{speciality}\nStudent group is:{groupNo}\n=====================";
            Console.ForegroundColor = ConsoleColor.White;

        }
        
        static void PrintError(string ErrorMessage) //creating method to show errors in red
        {
            ConsoleColor defaultcolor= Console.ForegroundColor; // ?
            Console.ForegroundColor = ConsoleColor.Red; 
            Console.WriteLine(ErrorMessage);
            Console.ForegroundColor = defaultcolor;

        }
    }
}
