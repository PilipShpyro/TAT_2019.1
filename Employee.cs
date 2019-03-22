using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Employee
    {
        public string jobName { get; set; }
        public int skill { get; set; }
        public int salary { get; set; }
        public int Earns()
        {
            return salary;
        }
        public int Works()
        {
            return skill;
        }
        public double Efficienty()
        {
            return ((double)skill) / ((double)salary);
        }
    }
}
