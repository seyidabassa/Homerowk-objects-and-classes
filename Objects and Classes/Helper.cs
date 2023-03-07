using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects_and_Classes
{
    internal class Helper
    {
        static public string ReadString(string question)
        {
        l1:
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(question);
            Console.ForegroundColor = ConsoleColor.White;
            string name = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(name))
            {
                goto l1;
            }
            return name;

        }
        
        static public int ReadInt(string question)
        {
            int value;
        l2: 
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(question);
            Console.ForegroundColor = ConsoleColor.White;
            string valueStr = Console.ReadLine();  
               //student.age = int.Parse(Console.ReadInt()); // use tryparse later and write in your notepad 
                if (!int.TryParse(valueStr, out value))
                {
             
                Console.WriteLine($"{valueStr} is not correct");
                    goto l2;
                }
            return value;
        }   

     }
}
