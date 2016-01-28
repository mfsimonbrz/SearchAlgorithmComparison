using System.Collections.Generic;

namespace SearchAlgorithmComparison.algorithms.basic
{
    public static class NodeListExtensions
    {
        public static bool HasNode(this List<Node> list, Node aNode)
        {            
            bool result = false;

            foreach(Node node in list)
            {
                result = node.IsEqual(aNode);
                if (result)
                {
                    break;
                }
            }

            return result;            
        }
    }
}
