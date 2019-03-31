using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class SpaceShip:SomethingInAir
    {
        public override string WhoAmI()
        {
            return "SpaceShip";
        }
        public SpaceShip()
        {
            Speed = 8000000;
        }
    }
}
