using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Bird:SomethingInAir
    {
        public override string WhoAmI()
        {
            return "Bird";
        }
        public Bird()
        {
            Random random = new Random();
            Speed = (random.NextDouble()*20)/3.6;
        }
    }
}
