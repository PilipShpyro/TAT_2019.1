using System;

namespace ConsoleApp3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {

                if (args.Length > 0 && args[0].Length > 2)//Checking if the lenght of first argument more than two
                {
                    SearchAndDisplay a = new SearchAndDisplay();
                    for (int i = 0; i < args.Length; i++)//work with all arguments
                    {
                        a.GetStr(args[i]);
                        a.Work();
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Error {0}.", e.Message);
            }
        }
    }
}
