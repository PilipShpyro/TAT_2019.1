using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Word
    {
        int emphasis;
        string word;
        string str;
        public void SetStr(string str)
        {
            this.str = str;
            ConvertFromStr(str);
        }
        public string GetStr()
        {
            return str;
        }
        public string GetWord()
        {
            return word;
        }
        public void SetEmphasis(int emphasis)
        {
            this.emphasis = emphasis;
        }
        public int GetEmphasis()
        {
            emphasis = str.IndexOf('+');
            return emphasis;
        }
        private void ConvertFromStr(string str)
        {
            emphasis = str.IndexOf('+');
            if(emphasis > -1)
            {
                word = str.Remove(emphasis, 1);
            }
        }
    }
}
