using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using AdvancedCalc.BinaryTree;
using AdvancedCalc.Commands;
using AdvancedCalc.Exeptions;

namespace AdvancedCalc.Parcer
{
    static class Parcer
    {
        private static BinaryTreeNode<ICommand> rootNode;
        private static int counter = 0;

        
        public static BinaryTreeNode<ICommand> Execute(string mathFormula)
        {
            foreach (char c in mathFormula)
            {
                try
                {
                    // +(25,33)
                    // +(+(2,2),1)
                    // +(s(12),33)
                    //return if its command or not 
                    //if command send two params (char of the command and stuff betweeen brakets)

                    ICommand currentCommand = CommandAnalyzer.Analyze(c);
                    string partOfMathFormula = RemoveCommandAndParentheses(mathFormula);
                    string[] partOfMathFormulaArray = partOfMathFormula.Split(new string[] { "," }, StringSplitOptions.None);
                    // add to current command the objects from recursion
                    // add it to node and return node 

                    int command = CommandAnalyzer.IsCommand(ReturnFirstChar(partOfMathFormulaArray[0]));
                    if (command ==1)
                    {
                        MessageBox.Show("ITS COMMAND");
                        //GoFurther();
                    }
                }
                catch (NotCommandExeption e)
                {

                }
                
            }

            return rootNode;
        }

        private static void GoFurther(string mathFormula)
        {
            foreach (char c in mathFormula)
            {
                try
                {
                    // 25,33
                    // +(2,2),1
                    // s(12),33
                    //return if its command or not 
                    //if command send two params (char of the command and stuff betweeen brakets)

                    ICommand currentCommand = CommandAnalyzer.Analyze(c);
                    string partOfMathFormula = RemoveCommandAndParentheses(mathFormula);
                    string [] partOfMathFormulaArray = partOfMathFormula.Split(new string[] { "," }, StringSplitOptions.None);
                    
                }
                catch (NotCommandExeption e)
                {

                }

            }
        }

        private static string RemoveCommandAndParentheses(string formula)
        {
            //TODO: Count the brakets 
            string result = "";
            DeveloperMode.Print(formula);
            int index = formula.IndexOf('(');
            if (index != -1)
            {
                result = formula.Remove(0, index +1);
                result = result.Remove(result.Length - 1, 1);
            }
            DeveloperMode.Print(result);
            return result;
        }

        private static char ReturnFirstChar(string arg)
        {
            return arg.Substring(0, 1).ToCharArray()[0];
        }
    }
}
