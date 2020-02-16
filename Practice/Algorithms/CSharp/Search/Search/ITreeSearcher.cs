using Classes.Result;
using Search.Classes;

namespace Search
{
    public interface ITreeSearcher<T>
    {
        string Name { get; }

        bool ContainsValue(Node<T> root, T value);

        IResult<Node<T>> GetNodeByValue(Node<T> root, T value);        
    }
}
