﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    public static class StringSum
    {
        public static int Sum(string num1, string num2) 
        {
            int pnum1 = 0;
            int pnum2 = 0;

            if (int.TryParse(num1, out pnum1)&&int.TryParse(num2, out pnum2))
            {
                if (pnum1 < 0)
                    pnum1 = 0;
                if (pnum2 < 0)
                    pnum2 = 0;
            }
            else
            {
                throw new ArgumentException();
            }
            
            return pnum1 + pnum2;
        }
    }
}
