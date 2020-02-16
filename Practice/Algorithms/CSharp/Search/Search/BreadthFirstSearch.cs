using Classes.Result;
using Search.Classes;
using System.Collections.Generic;

namespace Search
{
    public class BreadthFirstSearch<T> : ITreeSearcher<T>
    {
        public string Name => "Breadth First Search";

        public bool ContainsValue(Node<T> root, T value)
            => GetNodeByValue(root, value).Succeeded;

        public IResult<Node<T>> GetNodeByValue(Node<T> root, T value)
        {
            var nodesToVisit = new Queue<Node<T>>();
            nodesToVisit.Enqueue(root);
            while(nodesToVisit.Count > 0)
            {
                var node = nodesToVisit.Dequeue();
                if (node.Value.Equals(value))
                    return Result.Success(node);

                if (!node.IsLeaf())
                    node.Children.ForEach(child => nodesToVisit.Enqueue(child));
            }
            return Result.Fail<Node<T>>("Unable to find value in the given tree");
        }
    }
}
