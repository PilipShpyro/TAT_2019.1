using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Rules
    {
        public string Change(string st,int n, string t)
        {
            st = st.Remove(n, 1);
            st = st.Insert(n, t);
            return st;
        }
        private Word word;
        private string result;
        public void SetWord(Word word)
        {
            this.word = word;
        }
        public string GetResult()
        {
            result = word.GetWord();
            Rule1();
            Rule2();
            return result;
        }
        private void Rule1()
        {
            for(int i = 0;i<result.Length;i++)
            {
                if (result[i]=='о' && word.GetEmphasis()!=i+1)
                {
                    result = Change(result, i, "а");
                }
            }
        }
        private void Rule2()
        {
            for(int i=0;i<result.Length;i++)
            {
                if (result[i] == 'ю')
                {

                }
                if (result[i] == 'я')
                {
                }
                if (result[i] == 'ё')
                {
                }
                if (result[i] == 'е')
                {
                }
            }
        }
        private void Rule3()
        {

        }
        private void Rule4()
        {

        }
    }
}
