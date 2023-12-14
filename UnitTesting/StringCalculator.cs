using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    public static class StringCalculator
    {
        public static int Add(string numbers) 
        {
            int sum = 0;
            var pnumbers = numbers.Split(new char[] { ',','\n',';'});
            foreach (var number in pnumbers)
            {
                if (int.TryParse(number,out int num))
                {
                    if (num < 0)
                        throw new ArgumentException("negatives not allowed");
                    if (num > 1000)
                        num = 0;
                    sum = sum + num;
                }
                else
                    throw new ArgumentException();
            }
            return sum;
        }
    }
}
