using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eventyidelegaty
{
    class Simulation
    {
        public delegate void OnEvenThatCurrentTimeisEven(string msg);
        public event OnEvenThatCurrentTimeisEven listOfSubscribes;


        public int CurrentTime;

        public void simulate()
        {
            while (CurrentTime < 10)
            {
                if (CurrentTime % 2 == 0)
                {
                    Console.WriteLine(CurrentTime);
                    raiseEventCurrentTimeIsEven("Current Time is Even");
                }
                System.Threading.Thread.Sleep(100);
                CurrentTime++;

            }

        }
        public void raiseEventCurrentTimeIsEven(string msg)
        {
            if (listOfSubscribes != null)
                listOfSubscribes(msg);

        }

        public Simulation()
        {
            CurrentTime = 0;
        }
    }
}
