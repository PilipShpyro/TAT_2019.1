using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Presentation //Contains URl and format of presentation
    {
        private string format;
        public string Url { get; set; }
        public string Format
        {
            get
            {
                return format;
            }
            set
            {
                if (value == "" || value == "ppt" || value == "pdf")
                {
                    format = value;
                }
            }
        }
        public override string ToString()
        {
            return "Presentation";
        }
    }
}
