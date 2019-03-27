using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Seminar
    {
        private List<string> tasks;
        private List<Question> questions;
        public void AddQuestion(string query, string answer)
        {
            questions.Add(new Question());
            questions[questions.Count - 1].Answer = answer;
            questions[questions.Count - 1].Query = query;
        }
        public void ShowQuestions()
        {
            foreach (Question q in questions)
            {
                Console.WriteLine(q.Query + "   " + q.Answer);
            }
        }
        public void AddTask(string task)
        {
            tasks.Add(task);
        }
        public void ShowTasks()
        {
            foreach (string s in tasks)
            {
                Console.WriteLine(s);
            }
        }
        public Seminar()
        {
            questions = new List<Question>();
            tasks = new List<string>();
        }
        public Seminar(string[] tasks, Question[] questions)
        {
            this.tasks.AddRange(tasks);
            this.questions.AddRange(questions);
        }
        public override string ToString()
        {
            return "Seminar";
        }
    }
}
