using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Plane:SomethingInAir
    {
        public override string WhoAmI()
        {
            return "Plane";
        }
        private double Distance()// distance
        {
            return Math.Sqrt(Point.X * Point.X + Point.Y * Point.Y + Point.Z * Point.Z);
        }
        private double PlaneSpeed()// count the plane speed
        {
            double planeSpeed = 200;
            for(double i = Distance();i>=0;i-=10000)
            {
                planeSpeed += 10;
            }
            return planeSpeed/3.6;
        }
        public Plane()
        {
            Speed = PlaneSpeed();
        }
    }
}
