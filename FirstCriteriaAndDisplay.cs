using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    enum Jobs
    {
        Junior = 0, Middle = 1, Senior = 2, Lead = 3
    };
    class FirstCriteriaAndDisplay
    {
        private int EffectForSum(int sum, int n)//the most effectiove employee type for sum, n is amount of employee types
        {
            Employee[] employees = new Employee[n];
            for (int i = 0; i < n; i++)
            {
                switch (i)
                {
                    case (0):
                        employees[i] = new Junior();
                        break;
                    case (1):
                        employees[i] = new Middle();
                        break;
                    case (2):
                        employees[i] = new Senior();
                        break;
                    case (3):
                        employees[i] = new Lead();
                        break;
                }
            }
            double maxEff = 0.0;
            int maxEffHas = 0;
            for (int i = 0; i < n; i++)
            {
                if (maxEff < employees[i].Efficienty() && sum >= employees[i].Earns())
                {
                    maxEff = employees[i].Efficienty();
                    maxEffHas = i;
                }
            }
            return maxEffHas;
        }
        private bool needLead(int sum) //if it possible, hire a lead
        {
            Employee employee = new Lead();
            return sum >= employee.Earns();
        }
        private int theCheapest() //who earns the lowest salary
        {
            Employee[] employees = new Employee[4];
            employees[0] = new Junior();
            employees[1] = new Middle();
            employees[2] = new Senior();
            employees[3] = new Lead();
            int id = 0;
            int salary = employees[0].Earns();
            for (int i = 1; i < 3; i++)
            {
                if (employees[i].Earns() < salary)
                {
                    salary = employees[i].Earns();
                    id = i;
                }
            }
            return id;
        }
        private void Choose1(int cash)
        {
            Employee[] employees = new Employee[4];
            employees[0] = new Junior();
            employees[1] = new Middle();
            employees[2] = new Senior();
            employees[3] = new Lead();
            int[] employeesAmounts = new int[4];
            for (int i = 0; i < 4; i++) //at the beginning we need 0 juns, 0 mids, 0 seniors, 0 leads
            {
                employeesAmounts[i] = 0;
            }
            if (needLead(cash)) //if it possible, hire one lead
            {
                employeesAmounts[3]++;
                cash = cash - employees[3].Earns();
            }
            for (int i = cash; i >= employees[theCheapest()].Earns(); i -= employees[EffectForSum(i, 3)].Earns()) //if we have more cash we'll hire the most effective employees
            {
                employeesAmounts[EffectForSum(i, 3)]++;
            }
            for (int i = 3; i >= 0; i--) //show the table of employees
            {
                Console.WriteLine(employeesAmounts[i] + " {0}", employees[i].jobName);
            }
        }
        public FirstCriteriaAndDisplay(int sum) //sorry for bad realization, but there's no time...
        {
            Choose1(sum);
        }
    }
}
