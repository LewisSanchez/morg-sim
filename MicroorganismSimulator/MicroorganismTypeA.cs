using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroorganismSimulator
{
    class MicroorganismTypeA : Microorganism
    {
        public MicroorganismTypeA(string name, string type, int xCoordinate, int yCoodinate, int xVelocity, int yVelocity) : base(name, type, xCoordinate, yCoodinate, xVelocity, yVelocity)
        {
        }
    }
}
