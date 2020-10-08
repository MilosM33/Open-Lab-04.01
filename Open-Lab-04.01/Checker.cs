using System;
using System.Linq;

namespace Open_Lab_04._01
{
    public class Checker
    {
        public bool DoubleLetters(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if(i+1<str.Length && str[i] == str[i + 1])
                {
                    return true;
                }
            }
            return false;
        }
        
    }
}
