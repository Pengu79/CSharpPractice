using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractCsharp
{
    class Cat : Animal
    {
        private string djur = "katt";
        public override void PrintInfo()
        {
            Console.WriteLine(djur);
        }
        public override string ToString() => base.ToString() + $" Animal:{djur}";
       
    }
}
