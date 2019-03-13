using System;

namespace ConsoleApp3
{
    class SearchAndDisplay
    {
        private string str; //string with which this class will work
        public void GetStr(string _str) //getting string with which this class will work
        {
            str = _str;
        }
        public bool TwoOrderEqual(string x) //returns true if string x (parameter string) contains two consecutively equal elements
        {
            for (int t = 0; t < x.Length - 1; t++)
            {
                if (x[t] == x[t + 1])
                {
                    return true;
                }
            }
            return false;
        }
        public void Work() //the work of search operation
        {
            int l = 0;
            for (int i = 0; i < str.Length; i++)
            {
                for (int k = 2; k < str.Length - i + 1; k++, l++)
                {
                    if (TwoOrderEqual((str.Substring(i, k))))
                    {
                        break;
                    }
                    Console.WriteLine(str.Substring(i, k));
                }
            }
        }
    }
}
