using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class SomethingInAir : IFlyable
    {
        private Point point;
        private double speed;
        public Point Point
        {
            get
            {
                return point;
            }
            set
            {
                point = value;
            }
        }
        private double getDistance()//returns the distance from (0;0;0) to (Point.X;Point.Y;Point.Z)
        {
            return Math.Sqrt(Point.X * Point.X + Point.Y * Point.Y + Point.Z * Point.Z);
        }
        public double Speed
        {
            get
            {
                return speed;
            }
            set
            {
                speed = value;
            }
        }
        public void FlyTo(Point newPoint)
        {
            Point = newPoint;
        }
        public virtual string WhoAmI()
        {
            return "SomethingInAir";
        }
        public double GetFlyTime()
        {
            return getDistance() / Speed;
        }
    }
}
