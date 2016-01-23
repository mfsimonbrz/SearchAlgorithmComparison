using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgorithmComparison.algorithms
{
    public static class NodeListExtensions
    {
        public static bool NodeIsIn(this List<Node> list, Node aNode)
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
