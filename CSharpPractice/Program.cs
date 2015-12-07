using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInt = 5;
            Program program = new Program();
            program.Add(ref myInt);
            program.Multiply(ref myInt);
            Console.WriteLine(myInt);
            System.Threading.Thread.Sleep(2000);
        }
        public void Add(ref int tal) {  tal+= 10; }
        public void Multiply(ref int tal) {tal*= 10; }

    }
}
