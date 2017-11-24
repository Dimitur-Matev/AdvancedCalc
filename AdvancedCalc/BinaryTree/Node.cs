using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCalc.BinaryTree
{
    public class Node<T>
    {
        private T data;
        private NodeList<T> children = null;

        public Node() { }
        public Node(T data) : this(data, null) { }
        public Node(T data, NodeList<T> children)
        {
            this.data = data;
            this.children = children;
        }

        public T Value
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

        protected NodeList<T> Children
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

