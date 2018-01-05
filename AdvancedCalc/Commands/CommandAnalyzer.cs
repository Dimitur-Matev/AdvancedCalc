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
        public static ICommand Analyze(string arg)
        {
            ICommand resultCommand = null;
            //DeveloperMode.Print(arg);
            char firstChar = arg.ToCharArray()[0];
            switch (firstChar)
            {
                case '+':
                    DeveloperMode.Print("START SUM");
                    resultCommand = new SumCommand();
                    DeveloperMode.Print("END SUM");
                    break;
                case 'x':
                    DeveloperMode.Print("START VARIABLE");
                    resultCommand = new Variable();
                    DeveloperMode.Print("END VARIABLE");
                    break;
            }

            if (resultCommand == null)
            {
                
                DeveloperMode.Print("START NUMBER");
                double number = double.Parse(arg);
                resultCommand = new Constant(number);
                DeveloperMode.Print("END NUMBER");
                
            }

            return resultCommand;
        }

    }
}
