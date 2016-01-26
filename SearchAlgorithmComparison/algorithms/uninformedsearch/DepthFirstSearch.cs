using SearchAlgorithmComparison.algorithms.basic;
using System.Collections.Generic;

namespace SearchAlgorithmComparison.algorithms.uninformedsearch

{    
    /*
    This is an implementation of the Depth First Search algorithm
    to solve the 8-puzzle.
    The algorithm recursively searches in the adjacent nodes of each node
    and compares to the solution. It is a blind search algorithm, also
    called uninformed search algorithm.            
    */
    public class DepthFirstSearch : BaseAlgorithm
    {

        private bool _solved;

        protected override void Execute(Node puzzle)
        {            
            if (!base._visitedNodes.HasNode(puzzle))
            {
                puzzle.State = ENodeState.Gray;
                base._visitedNodes.Add(puzzle);
            }

            if (IsEqualToSolution(puzzle))
            {
                base.PrintList();
                _solved = true;
                return;                
            }
            else
            {
                if (_solved)
                {
                    return;
                }

                List<Node> expandedNodes = puzzle.Expand();
                foreach(Node node in expandedNodes)
                {
                    if (!base._visitedNodes.HasNode(node))
                    {
                        Execute(node);
                    }
                }
            }

            puzzle.State = ENodeState.Black;
        }
    }
}
