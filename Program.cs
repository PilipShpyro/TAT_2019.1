using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Word a = new Word();
                a.SetStr(Console.ReadLine());
                Rules b = new Rules();
                b.SetWord(a);
                Console.WriteLine(b.GetResult());
                Console.ReadKey();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
