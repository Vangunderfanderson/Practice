using Classes.MessageWriter;
using Search.Classes;

namespace Search
{
    class Program
    {
        static void Main(string[] args)
        {
            var writer = new ConsoleMessageWriter();
            var rootNode = GetTreeOfInts();
            var bfs = new BreadthFirstSearch<int>();
            TestSearchAlgorithmIntegers(bfs, rootNode, writer);

            var dfs = new DepthFirstSearch<int>();
            TestSearchAlgorithmIntegers(dfs, rootNode, writer);
        }

        private static void TestSearchAlgorithmIntegers(ITreeSearcher<int> searchAlgorithm, Node<int> rootNode, IMessageWriter writer)
        {
            writer.WriteMessage($"Testing algorithm: '{searchAlgorithm.Name}'");
            writer.WriteMessage("Looking for value 11");
            var result = searchAlgorithm.GetNodeByValue(rootNode, 11);
            writer.WriteMessage(result.Succeeded ? "Found it" : "Could not find it");

            writer.WriteMessage("Does value 15 exist in the tree?");
            var valueExists = searchAlgorithm.ContainsValue(rootNode, 15);
            writer.WriteMessage(valueExists ? "It does!" : "No it does not!");
        }


        private static Node<int> GetTreeOfInts()
        {
            //                1
            //             /     \
            //            2       3
            //         / / \ \   / \
            //        4 5  6 7  8   9
            //       /    / \        \
            //      10   11  12      13

            // Root
            var node11 = new Node<int>(1);

            // Second level
            var node21 = new Node<int>(2);
            var node22 = new Node<int>(3);
            node11.Children.Add(node21);
            node11.Children.Add(node22);

            // Third level
            var node31 = new Node<int>(4);
            var node32 = new Node<int>(5);
            var node33 = new Node<int>(6);
            var node34 = new Node<int>(7);
            node21.Children.Add(node31);
            node21.Children.Add(node32);
            node21.Children.Add(node33);
            node21.Children.Add(node34);

            var node35 = new Node<int>(8);
            var node36 = new Node<int>(9);
            node22.Children.Add(node35);
            node22.Children.Add(node36);

            // Fourth level
            var node41 = new Node<int>(10);
            node31.Children.Add(node41);

            var node42 = new Node<int>(11);
            var node43 = new Node<int>(12);
            node33.Children.Add(node42);
            node33.Children.Add(node43);

            var node44 = new Node<int>(13);
            node36.Children.Add(node44);

            return node11;
        }
    }
}
