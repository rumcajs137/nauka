using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eventyidelegaty
{
    class MyObject
    {
        public void Print(string msg)
        {
            Console.WriteLine(msg+" Object");
        }
        public MyObject(Simulation simulation)
        {
           simulation.listOfSubscribes += Print;

        }
    }
}
