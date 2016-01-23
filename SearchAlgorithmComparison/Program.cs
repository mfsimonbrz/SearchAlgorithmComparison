using SearchAlgorithmComparison.algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgorithmComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[3, 3] { {1 , 2, 3 }, { 4, 5, 6 }, { 7, 0, 8 } };
            //int[,] array = new int[3, 3] { { 1, 2, 3 }, { 4, 0, 6 }, { 7, 5, 8 } };
            //esse array fica um tempão e não chega na solução
            //int[,] array = new int[3, 3] { { 1, 7, 0 }, { 4, 2, 6 }, { 3, 8, 5 } };
            Node aNode = new Node(array);
            BaseAlgorithm bfs = new BreadthFirstAlgorithm();
            bfs.Run(aNode);
            //BaseAlgorithm dfs = new DepthFirstSearch();
            //dfs.Run(aNode);

        }
    }
}
