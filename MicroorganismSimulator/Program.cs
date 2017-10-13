using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroorganismSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            MicroorganismTypeA morgA = new MicroorganismTypeA("Bart", 1, 1, 1, 1);
            morgA.MoveBehavior = new MoveByOozing();
            morgA.Move();

            MicroorganismTypeA morgB = new MicroorganismTypeA("Lisa", 4, 4, 1, 1);
            morgB.MoveBehavior = new MoveByPaddling();
            morgB.Move();
        }
    }
}
