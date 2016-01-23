using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgorithmComparison.algorithms

{
    /*
    Implementação do algoritmo de busca em profundidade para a resolução do 
    problema do jogo do oito.
    O algoritmo abre recursivamente os nodos adjacentes de cada nodo e os compara com a
    solução. Trata-se de um algoritmo de busca cega e sua complexidade
    de tempo é xxxx.
    */
    public class DepthFirstSearch : BaseAlgorithm
    {

        private bool _solved;

        protected override void Execute(Node puzzle)
        {            
            if (!_visitedNodes.NodeIsIn(puzzle))
            {
                puzzle.State = ENodeState.Gray;
                _visitedNodes.Add(puzzle);
            }

            if (IsEqualToSolution(puzzle))
            {
                PrintList();
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
                    if (!_visitedNodes.NodeIsIn(node))
                    {
                        Execute(node);
                    }
                }
            }

            puzzle.State = ENodeState.Black;
        }
    }
}
