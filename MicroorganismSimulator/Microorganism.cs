using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroorganismSimulator
{
    abstract class Microorganism
    {
        private string _name;
        private string _type;
        private bool _isAlive;
        private int _xCoordinate;
        private int _yCoordinate;
        private int _xVelocity;
        private int _yVelocity;
        private IMoveBehavior _moveBehavior;
        private IFeedBehavior _feedBehavior;

        public Microorganism(string name, int xCoordinate, int yCoordinate, int xVelocity, int yVelocity)
        {
            this._name = name;
            this._type = null;
            this._isAlive = true;
            this._xCoordinate = xCoordinate;
            this._yCoordinate = yCoordinate;
            this._xVelocity = xVelocity;
            this._yVelocity = yVelocity;
            this._moveBehavior = null;
            this._feedBehavior = null;
        }

        public string Name => _name;

        public bool Alive => _isAlive;

        public string Type => _type;

        public IMoveBehavior MoveBehavior
        {
            get { return _moveBehavior; }
            set { _moveBehavior = value; }
        }

        public IFeedBehavior FeedBehavior
        {
            get { return _feedBehavior; }
            set { _feedBehavior = value; }
        }

        public void Move()
        {
            Console.WriteLine("{0} is moving from {1}, {2}", _name, _xCoordinate, _yCoordinate);
            Console.Write("{0} is moving by ", _name);
            _moveBehavior.Move();
            _xCoordinate += _xVelocity;
            _yCoordinate += _yVelocity;
            Console.WriteLine("{0} is now at {1}, {2}", _name, _xCoordinate, _yCoordinate);
        }

        public void Feed()
        {
            _feedBehavior.Feed();
        }

        public void Kill()
        {
            _isAlive = false;
        }
    }
}
