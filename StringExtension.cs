using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public static class StringExtension
    {
        public static int GenerId(this string str)
        {
            Random random = new Random();
            return random.Next(255);
        }
    }
}
