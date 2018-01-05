using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using AdvancedCalc.Tree;
using AdvancedCalc.Commands;
using AdvancedCalc.Exeptions;

namespace AdvancedCalc.Parcer
{
    static class Parcer
    {
        private static Node<ICommand> rootNode = new Node<ICommand>();
        private static int counter = 0;

        
        public static Node<ICommand> Execute(string mathFormula)
        {
            string[] partOfMathFormulaArray;
            
            try
            {
                // +(25,33)
                // +(+(2,2),1)
                // +(s(12),33)
                //return if its command or not 
                //if command send two params (char of the command and stuff betweeen brakets)

                ICommand currentCommand = CommandAnalyzer.Analyze(mathFormula);
                rootNode.Value = currentCommand;
                // we remove the command sign and parentheses here
                string partOfMathFormula = RemoveCommandAndParentheses(mathFormula);
                partOfMathFormulaArray = partOfMathFormula.Split(new string[] { "," }, StringSplitOptions.None);

                foreach (var formula in partOfMathFormulaArray)
                {
                    Node<ICommand> tempNode = GoFurther(formula);
                    tempNode.addRootNode(rootNode);
                    rootNode.addChildNode(tempNode);
                }
                
                // add to current command the objects from recursion
                // add it to node and return node 

//                int command = CommandAnalyzer.IsCommand(ReturnFirstChar(partOfMathFormulaArray[0]));
//                if (command ==1)
//                {
//                    MessageBox.Show("ITS COMMAND");
//                    //GoFurther();
//                }
            }
            catch (NotCommandExeption e)
            {

            }

            return rootNode;
        }

        private static Node<ICommand> GoFurther(string mathFormula)
        {
            Node<ICommand> thisNode = new Node<ICommand>();
            string[] partOfMathFormulaArray;

            try
            {
                // +(25,33)
                // +(+(2,2),1)
                // +(s(12),33)
                //return if its command or not 
                //if command send two params (char of the command and stuff betweeen brakets)

                // we take the command here
                ICommand currentCommand = CommandAnalyzer.Analyze(mathFormula);
                thisNode.Value = currentCommand;
                // we remove the command sign and parentheses here
                string partOfMathFormula = RemoveCommandAndParentheses(mathFormula);
                
                if (partOfMathFormula != "NOTHING HERE")
                {
                    partOfMathFormulaArray = partOfMathFormula.Split(new string[] { "," }, StringSplitOptions.None);

                    //thisNode = new Node<ICommand>(currentCommand);

                    foreach (var formula in partOfMathFormulaArray)
                    {
                        Node<ICommand> tempNode = GoFurther(formula);
                        tempNode.addRootNode(thisNode);
                        thisNode.addChildNode(tempNode);
                    }
                }
                

                // add to current command the objects from recursion
                // add it to node and return node 

                // int command = CommandAnalyzer.IsCommand(ReturnFirstChar(partOfMathFormulaArray[0]));
                // if (command ==1)
                // {
                //     MessageBox.Show("ITS COMMAND");
                //     //GoFurther();
                // }
            }
            catch (NotCommandExeption e)
            {
                
            }

            

            return thisNode;
        }

        private static string RemoveCommandAndParentheses(string formula)
        {
            
            string result = "NOTHING HERE";
            DeveloperMode.Print(formula);
            int index = formula.IndexOf('(');
            if (index != -1)
            {
                formula = formula.Remove(0, index +1);
//                result = result.Remove(result.Length - 1, 1);
                int counterBrakets = 1;
                int counterLoop = 0;
                foreach (char c in formula)
                {
                    
                    switch (c)
                    {
                        case '(':
                            counterBrakets++;
                            break;
                        case ')':
                            counterBrakets--;
                            break;
                  
                    }
                    if (counterBrakets == 0)
                    {
                        result = formula.Remove(counterLoop, 1);
                    }
                    counterLoop++;
                }
                
            }
            DeveloperMode.Print(result);
            return result;
        }

    }
}
