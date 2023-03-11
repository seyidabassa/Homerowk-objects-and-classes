using System.ComponentModel.Design.Serialization;

namespace Objects_and_Classes
{

    public class Program
    {
        static void Main(string[] args)
        {

            int numberOfStudents;
        label1:
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Please enter the number of students");
            Console.ForegroundColor = ConsoleColor.White;
            if (!int.TryParse(Console.ReadLine(), out numberOfStudents) || numberOfStudents <= 0)
            {
                goto label1;
            }
            Console.ForegroundColor = ConsoleColor.White;
            Student[] individual = new Student[numberOfStudents];
            for (int i = 0; i < numberOfStudents; i++)
            {
                Student student = new Student(); // pod klassom Student sozdaem object student
                //Helper helper = new Helper();//Dayom znakomstvo, reference s Helper, pod classom Helper sozdaem object helper
                student.name = Helper.ReadString($"Student {i + 1} Name:"); //calling our method from Helper class (if static)
                student.surname = Helper.ReadString($"Student {i + 1} Surname:");
                student.age = Helper.ReadInt($"Student {i + 1} age:");
                student.speciality = Helper.ReadString($"Student {i + 1} Speciality:");
                student.groupNo = Helper.ReadInt($"Student {i + 1} Group number:");
                individual[i] = student;

            }
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i2 = 0; i2 < numberOfStudents; i2++)
            {
                Console.WriteLine($"{individual[i2]}");
            }
            Console.ForegroundColor = ConsoleColor.White;
        }

        //    class Elshen : Student //inheritance
        //{
        //    public int IQ;
        //    public void _name()
        //    {
        //        Console.WriteLine("Gagam");
        //    }
        //}


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
    
