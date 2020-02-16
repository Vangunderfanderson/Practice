using System;
using System.Collections.Generic;
using System.Text;

namespace Search.Classes
{
    public class Node<T>
    {
        public T Value { get; set; }
        public List<Node<T>> Children { get; set; }

        public Node(T value)
        {
            Value = value;
            Children = new List<Node<T>>();
        }

        public bool IsLeaf()
            => Children.Count <= 0;
    }
}
