using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using SearchAlgorithmComparison.algorithms.uninformedsearch;

namespace SearchAlgorithmComparison.algorithms.basic
{
    /*
    Esta classe implementa a base dos algoritmos de busca, que consiste em um array com a solução do jogo do 8
    e o cálculo do tempo de execução do algoritmo.
    */
    public abstract class BaseAlgorithm
    {
        private readonly Stopwatch _stopwatch;
        private Node _solution;

        protected List<Node> _visitedNodes;

        public BaseAlgorithm()
        {            
            _solution = new Node(InitializeArray());
            _stopwatch = new Stopwatch();
            _visitedNodes = new List<Node>();
        }

        protected abstract void Execute(Node puzzle);

        public void Run(Node puzzle)
        {
            Console.WriteLine("Começou\n");
            _stopwatch.Reset();
            _stopwatch.Start();            
            Execute(puzzle);
            _stopwatch.Stop();            
            Console.WriteLine("Terminou.\nTempo: {0} ms.", GetElapsedTime());
        }

        private int[,] InitializeArray()
        {
            var array = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 0 } };

            return array;
        } 

        public bool IsEqualToSolution(Node aNode)
        {
            bool equal = false;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    equal = aNode.Value[i, j] == _solution.Value[i, j];
                    if (!equal)
                    {
                        break;
                    }
                }

                if (!equal)
                {
                    break;
                }
            }

            return equal;
        }

        protected void PrintList()
        {
            Console.WriteLine("Lista de nós visitados\n");
            foreach (Node node in _visitedNodes)
            {
                Console.WriteLine("Valor: {0} ==== Nivel: {1}", node.ToString(), node.Level);
            }
            Console.WriteLine("{0} nós visitados", _visitedNodes.Count);
        }

        private long GetElapsedTime()
        {
            return _stopwatch.ElapsedMilliseconds;
        }

    }
}
