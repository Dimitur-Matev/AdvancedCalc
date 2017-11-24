using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCalc.Commands
{
    interface ICommand
    {
        double GetResult();
        void AddArguments(double[] args);
    }
}
