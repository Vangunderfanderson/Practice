using Classes.Result;
using Search.Classes;
using System;

namespace Search
{
    public class DepthFirstSearch<T> : ITreeSearcher<T>
    {
        public string Name => "Depth First Search";

        public bool ContainsValue(Node<T> root, T value)
            => GetNodeByValue(root, value).Succeeded;

        public IResult<Node<T>> GetNodeByValue(Node<T> root, T value)
        {
            if (root.Value.Equals(value))
                return Result.Success(root);
                        
            foreach (var node in root.Children)
            {
                var result = GetNodeByValue(node, value);
                if (result.Succeeded)
                    return result;
            }

            return Result.Fail<Node<T>>("Did not find the value");
        }        
    }
}
