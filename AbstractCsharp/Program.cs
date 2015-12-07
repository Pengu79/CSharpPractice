using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Cat() { Age = 22, Name = "Catty" };
            Animal dog = new Dog() { Age = 33, Name = "Dogge" };
            Console.WriteLine(cat.ToString());
            Console.WriteLine(dog.ToString());
        }
    }
}
