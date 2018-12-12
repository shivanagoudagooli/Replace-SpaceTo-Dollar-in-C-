using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingAlgorithms
{ 

    public static class ReplaceSpace
    {
        public static string Replace(string s)
        {
            
            s = s.Trim();
            s = s.Replace(" ", "$");
            return s;
        }
    }
}