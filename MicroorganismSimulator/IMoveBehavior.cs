using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroorganismSimulator
{
    interface IMoveBehavior
    {
        void Move();
    }

    class MoveByPaddling : IMoveBehavior
    {
        public void Move()
        {
            Console.WriteLine("Paddling");
        }
    }

    class MoveByOozing : IMoveBehavior
    {
        public void Move()
        {
            Console.WriteLine("Oozing");
        }
    }
}
