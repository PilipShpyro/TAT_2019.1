using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Subject
    {
        public int id { get; set; }
        public string name
        {
            get
            {
                return name;
            }
            set
            {
                if (value.Length <= 256)
                {
                    name = value;
                }
            }
        }
        Material material { get; set; }
        public void AddLection()
        {
            Lection lection = new Lection();
            material.AddLection(lection);
        }
        public void AddLection(string text, Presentation presentation)
        {
            Lection lection = new Lection(text, presentation);
            material.AddLection(lection);
        }
        public void AddLection(string text, string presentation_url, string presentation_type)
        {
            Lection lection = new Lection(text, presentation_url, presentation_type);
            material.AddLection(lection);
        }
        public void AddSeminar()
        {
            Seminar seminar = new Seminar();
            material.AddSeminar(seminar);
        }
        public void AddSeminar(string[] tasks, Question[] questions)
        {
            Seminar seminar = new Seminar(tasks, questions);
            material.AddSeminar(seminar);
        }
        public void AddLab()
        {
            Lab lab = new Lab();
            material.AddLab(lab);
        }
        public Subject()
        {
            material = new Material();
        }
        public Subject(int id, string name)
        {
            this.id = id;
            this.name = name;
            material = new Material();
        }
        public override string ToString()
        {
            return "Subject";
        }
    }
}
