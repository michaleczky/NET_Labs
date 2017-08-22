using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    // concrete strategy
    public class Deduct : ICalculator
    {
        public int Calculate(int val1, int val2)
        {
            return val1 - val2;
        }
    }
}
