using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Lection
    {
        public string text
        {
            get
            {
                return text;
            }
            set
            {
                if (value.Length <= 10000)
                {
                    text = value;
                }
            }
        }
        Presentation presentation { get; set; }
        public void InitMaterial(string url, string type)
        {
            presentation = new Presentation();
            presentation.Format = type;
            presentation.Url = url;
        }
        public Lection()
        {
            presentation = new Presentation();
        }
        public Lection(string text, Presentation presentation)
        {
            presentation = new Presentation();
            this.text = text;
            this.presentation = presentation;
        }
        public Lection(string text, string presentation_url, string presentation_type)
        {
            presentation = new Presentation();
            presentation.Format = presentation_type;
            presentation.Url = presentation_url;
        }
        public override string ToString()
        {
            return "Lection";
        }
    }
}
