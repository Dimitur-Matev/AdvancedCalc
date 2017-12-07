using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdvancedCalc.Exeptions;

namespace AdvancedCalc.Commands
{
    static class CommandAnalyzer
    {
        public static ICommand Analyze(char arg)
        {
            ICommand resultCommand;
            switch (arg)
            {
                case '+':
                    resultCommand = new SumCommand();
                    break;
                case 'x':
                    resultCommand = new Variable();
                    break;

                default:
                    throw new NotCommandExeption();
            }
            return resultCommand;
        }

        public static int IsCommand(char arg)
        {
            switch (arg)
            {
                case '+':
                    return 1;
                case 'x':
                    return 1;

                default:
                    return 0;
            }
        }
    }
}
