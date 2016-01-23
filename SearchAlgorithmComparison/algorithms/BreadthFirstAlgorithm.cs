using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgorithmComparison.algorithms
{
    /*
    Implementação do algoritmo de busca em largura para a resolução do 
    problema do jogo do oito.
    O algoritmo abre os nodos adjacentes de cada nodo e os compara com a
    solução. Trata-se de um algoritmo de busca cega e sua complexidade
    de tempo é O(b^d) , onde b é o fator de adjacências e o d é a 
    profundidade da solução.
        
    */
    public class BreadthFirstAlgorithm : BaseAlgorithm
    {
        private Queue<Node> _queue;
        

        public BreadthFirstAlgorithm()
        {
            _queue = new Queue<Node>();            
        }
        protected override void Execute(Node puzzle)
        {
            _queue.Enqueue(puzzle);
            while(_queue.Count != 0)
            {
                Node node = _queue.Dequeue();                
                if (!_visitedNodes.NodeIsIn(node))
                {
                    node.State = ENodeState.Gray;
                    _visitedNodes.Add(node);
                }

                if (IsEqualToSolution(node))
                {
                    PrintList();
                    break;
                }
                else
                {
                    List<Node> nodeList = node.Expand();
                    foreach (Node expandedNode in nodeList)
                    {
                        if (!_visitedNodes.NodeIsIn(expandedNode))
                        {                            
                            _queue.Enqueue(expandedNode);
                            expandedNode.State = ENodeState.Gray;
                            _visitedNodes.Add(expandedNode);
                        }
                    }
                }

                node.State = ENodeState.Black;

            }            
        }        
    }
}
