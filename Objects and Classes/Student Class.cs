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
        public string name;
        public string surname;
        public int age;
        public string speciality;
        public int groupNo;

        public override string ToString()
        {
            return $"Student name is:{name} \nStudent Surname is:{surname} \nStudent age is:{age}\nStudent speciality is:{speciality}\nStudent group is:{groupNo}\n";


        }
        // 
    }
}
