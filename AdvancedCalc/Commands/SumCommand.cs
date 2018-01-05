using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCalc.Commands
{
    class SumCommand : ICommand
    {
        private List<ICommand> _values;

        public Type Type { get; set; }

        public SumCommand()
        {
            _values = new List<ICommand>();
            Type = Type.Command;
        }

        public void AddArguments(List<ICommand> arg)
        {
            _values = arg;
        }

        public double GetValue(double x)
        {
            double sum = 0;
            foreach (var val in _values)
            {
                sum += val.GetValue(x);
            }
            return sum;
        }
    }
}
