using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int sum, productivity, criteria;
            Console.WriteLine("Сумма");
            sum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Продуктивность");
            productivity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Критерий выбора");
            criteria = Convert.ToInt32(Console.ReadLine());
            if (criteria == 1)
            {
                Console.WriteLine("----------------");
                FirstCriteriaAndDisplay a = new FirstCriteriaAndDisplay(sum);
                Console.WriteLine("----------------");
            }
            Console.ReadKey();
        }
    }
}
