using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Arv
{
    class Program
    {
        static void Main(string[] args)
        {
            Object apa;
            int helTal = 0;
            double dubbel = 0d;
            string strang = "test";
            char bokstav = 'b';
            bool trueFalse = false;
            trueFalse = int.TryParse(strang, out helTal);
            apa = dubbel;
            apa = trueFalse;
            apa = bokstav;
            apa = helTal;
            apa = strang;
            strang = bokstav;
            strang = helTal;
            strang = dubbel;
            dubbel = helTal;
            bokstav = strang;
            strang = bokstav;
            helTal = dubbel;
        }
    }
}
