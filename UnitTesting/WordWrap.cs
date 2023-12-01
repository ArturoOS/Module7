using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    public static class WordWrap
    {
        public static int Wrap(string word)
        {
            int count = 0;
            word = word.Trim().Replace("\n","");
            string[] words = word.Split(null);
            foreach (string w in words) 
            {
                if(!string.IsNullOrWhiteSpace(w)&&!string.IsNullOrEmpty(w))
                    count++;
            }
            return count-1;
        }
    }
}
