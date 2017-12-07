using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCalc.Commands
{
    class Variable:ICommand
    {
        public Type Type { get; set; }

        public Variable() {}

        public void AddArguments(List<ICommand> arg) { }

        public double GetValue(double x)
        {
            return x;
        }
    }
}
