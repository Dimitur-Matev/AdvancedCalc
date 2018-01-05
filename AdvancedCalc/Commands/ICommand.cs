using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCalc.Commands
{
    enum Type
    {
        Variable,
        Constant,
        Command
    }
    interface ICommand
    {
        Type Type { get; set; }
        double GetValue(double x);
        void AddArguments(List<ICommand> args);  
    }
}
