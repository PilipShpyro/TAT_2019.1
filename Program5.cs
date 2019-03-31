using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point();
            point.X = 100000;
            point.Y = 200000;
            point.Z = 800000;
            IFlyable flyable;
            SomethingInAir[] a = new SomethingInAir[3];
            a[0] = new Bird();
            a[1] = new Plane();
            a[2] = new SpaceShip();
            foreach(var t in a)
            {
                flyable = t;
                flyable.FlyTo(point);
                Console.WriteLine(flyable.GetFlyTime() + " Seconds - " + flyable.WhoAmI());
            }
        }
    }
}
