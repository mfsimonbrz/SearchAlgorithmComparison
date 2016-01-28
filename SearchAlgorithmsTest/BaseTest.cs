using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchAlgorithmComparison.algorithms;
using SearchAlgorithmComparison.algorithms.uninformedsearch;
using SearchAlgorithmComparison.algorithms.basic;
using System.Collections.Generic;

namespace SearchAlgorithmsTest
{
    [TestClass]
    public class BaseTest
    {
        [TestMethod]
        public void EqualityTest()
        {
            BaseAlgorithm bfs = new BreadthFirstSearch();
            int[,] solution = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 0 } };
            Node aNode = new Node(solution);

            Assert.IsTrue(bfs.IsEqualToSolution(aNode));
        }

        [TestMethod]
        public void DifferenceTest()
        {
            BaseAlgorithm bfs = new BreadthFirstSearch();
            int[,] solution = new int[,] { { 1, 5, 3 }, { 8, 4, 6 }, { 7, 2, 0 } };
            Node aNode = new Node(solution);

            Assert.IsFalse(bfs.IsEqualToSolution(aNode));
        }

        [TestMethod]
        public void NodeListHasNode()
        {
            List<Node> list = new List<Node>();
            int[,] solution = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 0 } };
            Node aNode = new Node(solution);
            list.Add(aNode);            
            Node anotherNode = new Node(solution);

            Assert.IsTrue(list.HasNode(anotherNode));

        }

    }
}
