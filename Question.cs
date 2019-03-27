using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Question //Contains query and question
    {
        public string Query { get; set; }
        public string Answer { get; set; }
        public override string ToString()
        {
            return "Question";
        }
    }
}
