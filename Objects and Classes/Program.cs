using System.ComponentModel.Design.Serialization;

namespace Objects_and_Classes
{

    public class Program
    {
        static void Main(string[] args)
        {

            int numberOfStudents;
        label1:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Please enter the number of students");
            if (!int.TryParse(Console.ReadLine(), out numberOfStudents) || numberOfStudents <= 0)
            {
                goto label1;
            }
            Console.ForegroundColor = ConsoleColor.White;
            Student[] individual = new Student[numberOfStudents];
            for (int i = 0; i < numberOfStudents; i++)
            {
                
                Student student = new Student();
                
                l2:
                Console.Write($"Student number {i + 1} surname:");
                student.surname = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(student.surname))
                {
                    goto l2;
                }

                l3:
                Console.Write($"Student number {+1} age:");
                student.age = int.Parse(Console.ReadLine()); // use tryparse later and write in your notepad 
                if (student.age==0)
                {
                    goto l3;
                }

                l4:
                Console.Write($"Student number {i + 1} speciality:");
                student.speciality = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(student.speciality))
                {
                    goto l4;
                }
                Console.Write($"Student number {i + 1} Group number:");
                student.groupNo = int.Parse(Console.ReadLine());


                individual[i] = student;
                ;

            }
                Console.ForegroundColor= ConsoleColor.Green;
                for (int i2 = 0; i2 < numberOfStudents; i2++)
                {
                    Console.WriteLine(individual[i2]);
                }
            Console.ForegroundColor = ConsoleColor.White;



            //}
            //individual[0] = new Student();
            //individual[0].name = "Johnathan";
            //individual[0].surname = "Smith";
            //individual[0].age = 20;
            //individual[0].speciality = "Engineering";
            //individual[0].groupNo = 710;


            //// second style object creation
            //Student Steve= new Student();
            //Steve.name = "Steven";
            //Steve.surname = "Jobs";
            //Steve.age = 21;
            //Steve.speciality = "Doctor";
            //Steve.groupNo = 711;
            ////is right here
            //individual[1] = Steve;
        }


        }
    }
