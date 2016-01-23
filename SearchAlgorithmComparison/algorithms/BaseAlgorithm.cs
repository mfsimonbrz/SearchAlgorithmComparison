using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace SearchAlgorithmComparison.algorithms
{
    /*
    Esta classe implementa a base dos algoritmos de busca, que consiste em um array com a solução do jogo do 8
    e o cálculo do tempo de execução do algoritmo.
    */
    public abstract class BaseAlgorithm
    {
        private Stopwatch _Stopwatch;
        public Node Solution { get; private set; }

        protected List<Node> _visitedNodes;

        public long TimeElpased
        {
            get
            {                
                return _Stopwatch.ElapsedMilliseconds;
            }
        }

        public BaseAlgorithm()
        {            
            Solution = new Node(InitializeArray());
            _Stopwatch = new Stopwatch();
            _visitedNodes = new List<Node>();
        }

        protected abstract void Execute(Node puzzle);

        public void Run(Node puzzle)
        {
            Console.WriteLine("Começou\n");
            _Stopwatch.Reset();
            _Stopwatch.Start();            
            Execute(puzzle);
            _Stopwatch.Stop();            
            Console.WriteLine("Terminou.\nTempo: {0} ms.", TimeElpased);
        }

        private int[,] InitializeArray()
        {
            int[,] array = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 0 } };

            return array;
        } 

        public bool IsEqualToSolution(Node aNode)
        {
            bool equal = false;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    equal = aNode.Value[i, j] == Solution.Value[i, j];
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

    }
}
