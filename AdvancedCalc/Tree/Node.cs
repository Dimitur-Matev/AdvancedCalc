using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCalc.Tree
{
    public class Node<ICommand>
    {
        
        private ICommand data;
        private NodeList<ICommand> children;
        private Node<ICommand> rootNode;

        public Node() { }
        public Node(ICommand data) : this(data, null, null) { }
        public Node(ICommand data, NodeList<ICommand> children, Node<ICommand> rootNode)
        {
            this.data = data;
            this.children = children;
            this.rootNode = rootNode;
        }

        public Node(Node<ICommand> rootNode, ICommand data)
        {
            this.data = data;
            this.rootNode = rootNode;
        }

        public void addChildNode(Node<ICommand> childNode)
        {
            if(children == null)
                children = new NodeList<ICommand>();
            children.Add(childNode);
        }

        public void addRootNode(Node<ICommand> node)
        {
            this.rootNode = node;
        }

        public void removeNode(Node<ICommand> nodeToRemove)
        {
            Node<ICommand> temp = children.FindByValue(nodeToRemove.Value);
            children.Remove(temp);
        }

        public ICommand Value
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
            }
        }

        protected NodeList<ICommand> Children
        {
            get
            {
                return children;
            }
            set
            {
                children = value;
            }
        }
    }
}

