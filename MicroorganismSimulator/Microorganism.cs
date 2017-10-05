using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroorganismSimulator
{
    public class Microorganism
    {
        private IMoveBehavior _movementBehavior;
        private IFeedBehavior _feedingBehavior;
        private string _name;
        private string _type;
        private bool _isAlive;
        private int _xCoordinate;
        private int _yCoordinate;
        private int _xVelocity;
        private int _yVelocity;

        protected Microorganism(string name, string type, int xCoordinate, int yCoordinate, int xVelocity, int yVelocity)
        {
            this._movementBehavior = null;
            this._feedingBehavior = null;
            this._name = name;
            this._type = type;
            this._isAlive = true;
            this._xCoordinate = xCoordinate;
            this._yCoordinate = yCoordinate;
        }

        public string Name => _name;

        public bool Alive => _isAlive;

        public string Type => _type;

        public void Move()
        {
            Console.WriteLine("{0} is moving from {1}, {2}", _name, _xCoordinate, _yCoordinate);
            Console.WriteLine("{0} is moving by...");
            //_movementBehavior.Move(); <- TODO: Describe movement behavior
            _xCoordinate += _xVelocity;
            _yCoordinate += _yVelocity;
            Console.WriteLine("{0} is now at {1}, {2}", _name, _xCoordinate, _yCoordinate);
        }

        public void Feed()
        {
            //_feedBehavior.Feed(); <- TODO: Describe feeding behavior
        }

        public void Kill()
        {
            _isAlive = false;
        }
    }
}
