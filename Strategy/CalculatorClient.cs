using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    //The strategy client
    public class CalculatorClient
    {
        public ICalculator _calculator { get; set; }

        public CalculatorClient(ICalculator calculator)
        {
            this._calculator = calculator;
        }

        public int Calculate(int val1, int val2)
        {
            return _calculator.Calculate(val1, val2);
        }
    }
}
