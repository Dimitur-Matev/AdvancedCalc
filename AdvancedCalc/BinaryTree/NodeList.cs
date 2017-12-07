using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCalc.BinaryTree
{
    public class NodeList<ICommand> : Collection<Node<ICommand>>
    {
        public NodeList() : base() { }

        public NodeList(int initialSize)
        {
            // Add the specified number of items
            for (int i = 0; i < initialSize; i++)
                base.Items.Add(default(Node<ICommand>));
        }

        public Node<ICommand> FindByValue(ICommand value)
        {
            // search the list for the value
            foreach (Node<ICommand> node in Items)
                if (node.Value.Equals(value))
                    return node;

            // if we reached here, we didn't find a matching node
            return null;
        }
    }
}
