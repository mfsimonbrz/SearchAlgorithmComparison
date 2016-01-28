using SearchAlgorithmComparison.algorithms.basic;
using System.Collections.Generic;

namespace SearchAlgorithmComparison.algorithms.uninformedsearch
{
    /*
    This is an implementation of the Breadth First Search algorithm
    to solve the 8-puzzle.
    The algorithm searches in the adjacent nodes on the same level and
    compares to the solution. It is a blind search algorithm, also
    called uninformed search algorithm.            
    */
    public class BreadthFirstSearch : BaseAlgorithm
    {
        private Queue<Node> _queue;


        public BreadthFirstSearch()
        {
            _queue = new Queue<Node>();
        }
        protected override void Execute(Node puzzle)
        {
            _queue.Enqueue(puzzle);
            while (_queue.Count != 0)
            {
                Node node = _queue.Dequeue();
                if (!base._visitedNodes.HasNode(node))
                {
                    node.State = ENodeState.Gray;
                    base._visitedNodes.Add(node);
                }

                if (base.IsEqualToSolution(node))
                {
                    base.PrintList();
                    break;
                }

                List<Node> nodeList = ExpandedNodesFinder.ExpandNode(node);
                foreach (Node expandedNode in nodeList)
                {
                    if (!base._visitedNodes.HasNode(expandedNode))
                    {
                        _queue.Enqueue(expandedNode);
                        expandedNode.State = ENodeState.Gray;
                        base._visitedNodes.Add(expandedNode);
                    }
                }

                node.State = ENodeState.Black;

            }
        }
    }
}
