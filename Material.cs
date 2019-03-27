using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Material
    {
        private List<Lection> lection;
        private List<Lab> lab;
        private List<Seminar> seminar;
        public void AddLection(Lection lection)
        {
            this.lection.Add(lection);
        }
        public void AddLab(Lab lab)
        {
            this.lab.Add(lab);
        }
        public void AddSeminar(Seminar seminar)
        {
            this.seminar.Add(seminar);
        }
        public Material()
        {
            lection = new List<Lection>();
            lab = new List<Lab>();
            seminar = new List<Seminar>();
        }
        public override string ToString()
        {
            return "Material";
        }
    }
}
