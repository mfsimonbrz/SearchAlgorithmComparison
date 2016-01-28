using SearchAlgorithmComparison.algorithms.basic;
using SearchAlgorithmComparison.algorithms.uninformedsearch;
using System;

namespace SearchAlgorithmComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[,] array = new int[3, 3] { { 1, 3, 2 }, { 4, 0, 6 }, { 5, 7, 8 } };            
            int[,] array = new int[3, 3] { { 1, 2, 3 }, { 4, 0, 6 }, { 7, 5, 8 } };
            Node aNode = new Node(array);
            BaseAlgorithm bfs = new BreadthFirstSearch();
            bfs.Run(aNode);
            Console.ReadKey();           
        }        
    }
}
