using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    //The strategy interface
    public interface ICalculator
    {
        int Calculate(int val1, int val2);
    }
}
