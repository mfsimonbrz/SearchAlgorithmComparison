using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchAlgorithmComparison.algorithms;
using SearchAlgorithmComparison.algorithms.uninformedsearch;
using SearchAlgorithmComparison.algorithms.basic;

namespace SearchAlgorithmsTest
{
    [TestClass]
    public class BaseTest
    {
        [TestMethod]
        public void EqualityTest()
        {
            BaseAlgorithm bfs = new BreadthFirstAlgorithm();
            int[,] solution = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 0 } };
            Node aNode = new Node(solution);

            Assert.IsTrue(bfs.IsEqualToSolution(aNode));
        }

        [TestMethod]
        public void DifferenceTest()
        {
            BaseAlgorithm bfs = new BreadthFirstAlgorithm();
            int[,] solution = new int[,] { { 1, 5, 3 }, { 8, 4, 6 }, { 7, 2, 0 } };
            Node aNode = new Node(solution);

            Assert.IsFalse(bfs.IsEqualToSolution(aNode));
        }

    }
}
