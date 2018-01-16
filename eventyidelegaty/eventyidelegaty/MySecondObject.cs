using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eventyidelegaty
{
    class MySecondObject
    {
        public void Print(string msg)
        {
            Console.WriteLine(msg+ " Second Object");
        }
        public MySecondObject(Simulation simulation)
        {
           simulation.listOfSubscribes += Print;
        }
    }
}
