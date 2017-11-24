using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCalc.Commands
{
    class SumCommand : ICommand
    {
        private double _num1, _num2;

        public SumCommand()
        {
            _num1 = _num2 = 0;
        }

        public void AddArguments(double[] arg)
        {
            _num1 = arg[0];
            _num2 = arg[1];
        }

        public double GetResult()
        {
            return _num1 + _num2;
        }
    }
}
