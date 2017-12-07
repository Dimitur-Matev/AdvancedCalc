using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCalc.Commands
{
    class Constant : ICommand
    {
        private double _value;
        public Type Type { get; set; }

        public Constant(double val)
        {
            _value = val;
        }


        public void AddArguments(List<ICommand> arg) {} 

        public double GetValue(double x)
        {
            return _value;
        }
    }
}
