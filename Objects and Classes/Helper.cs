using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects_and_Classes
{
    internal class Helper
    {
        public string ReadName()
        {
        l1:
            Console.Write($"Student name:");
            string name = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(name))
            {
                goto l1;
            }
            return name;
        }
    }
}
