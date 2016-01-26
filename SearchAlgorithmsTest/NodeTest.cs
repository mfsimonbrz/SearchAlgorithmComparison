using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchAlgorithmComparison.algorithms.basic;
using System.Collections.Generic;

namespace SearchAlgorithmsTest
{
    [TestClass]
    public class NodeTest
    {
        [TestMethod]
        /* testa 0 movido da posição {0,0} para {0,1} */
        public void FirstMoveTest()
        {
            int[,] array = new int[3, 3] { { 0, 2, 3 }, { 4, 5, 6 }, { 7, 8, 1 } };
            Node aNode = new Node(array);
            List<Node> nodeList = aNode.Expand();
            Node answerNode = nodeList.ToArray()[0];                                                   
            Assert.AreEqual(answerNode.ToString(), "2 0 3 4 5 6 7 8 1 ");            
        }

        [TestMethod]
        /* testa o 0 movido da posicao {0,0} para {1,0} */
        public void SecondMoveTest() 
        {
            int[,] array = new int[3, 3] { { 0, 2, 3 }, { 4, 5, 6 }, { 7, 8, 1 } };
            Node aNode = new Node(array);
            List<Node> nodeList = aNode.Expand();
            Node answerNode = nodeList.ToArray()[1];
            Assert.AreEqual(answerNode.ToString(), "4 2 3 0 5 6 7 8 1 ");
        }

        [TestMethod]
        public void ThirdMoveTest()
        {
            int[,] array = new int[3, 3] { { 1, 0, 3 }, { 4, 2, 6 }, { 7, 8, 5 } };
            Node aNode = new Node(array);
            List<Node> nodeList = aNode.Expand();
            Node answerNode = nodeList.ToArray()[0];
            Assert.AreEqual(answerNode.ToString(), "0 1 3 4 2 6 7 8 5 ");
        }

        [TestMethod]
        public void FourthMoveTest()
        {
            int[,] array = new int[3, 3] { { 1, 0, 3 }, { 4, 2, 6 }, { 7, 8, 5 } };
            Node aNode = new Node(array);
            List<Node> nodeList = aNode.Expand();
            Node answerNode = nodeList.ToArray()[1];
            Assert.AreEqual(answerNode.ToString(), "1 3 0 4 2 6 7 8 5 ");
        }

        [TestMethod]
        public void FifthMoveTest()
        {
            int[,] array = new int[3, 3] { { 1, 0, 3 }, { 4, 2, 6 }, { 7, 8, 5 } };
            Node aNode = new Node(array);
            List<Node> nodeList = aNode.Expand();
            Node answerNode = nodeList.ToArray()[2];
            Assert.AreEqual(answerNode.ToString(), "1 2 3 4 0 6 7 8 5 ");
        }

        [TestMethod]
        public void SixthMoveTest()
        {
            int[,] array = new int[3, 3] { { 1, 2, 0 }, { 4, 5, 6 }, { 7, 8, 3 } };
            Node aNode = new Node(array);
            List<Node> nodeList = aNode.Expand();
            Node answerNode = nodeList.ToArray()[0];
            Assert.AreEqual(answerNode.ToString(), "1 0 2 4 5 6 7 8 3 ");
        }

        [TestMethod]
        public void SeventhMoveTest()
        {
            int[,] array = new int[3, 3] { { 1, 2, 0 }, { 4, 5, 6 }, { 7, 8, 3 } };
            Node aNode = new Node(array);
            List<Node> nodeList = aNode.Expand();
            Node answerNode = nodeList.ToArray()[1];
            Assert.AreEqual(answerNode.ToString(), "1 2 6 4 5 0 7 8 3 ");
        }

        [TestMethod]
        public void EighthMoveTest()
        {
            int[,] array = new int[3, 3] { { 4, 2, 3 }, { 0, 5, 6 }, { 7, 8, 1 } };
            Node aNode = new Node(array);
            List<Node> nodeList = aNode.Expand();
            Node answerNode = nodeList.ToArray()[0];
            Assert.AreEqual(answerNode.ToString(), "4 2 3 5 0 6 7 8 1 ");
        }

        [TestMethod]
        public void NinethMoveTest()
        {
            int[,] array = new int[3, 3] { { 4, 2, 3 }, { 0, 5, 6 }, { 7, 8, 1 } };
            Node aNode = new Node(array);
            List<Node> nodeList = aNode.Expand();
            Node answerNode = nodeList.ToArray()[2];
            Assert.AreEqual(answerNode.ToString(), "0 2 3 4 5 6 7 8 1 ");
        }

        [TestMethod]
        public void TenthMoveTest()
        {
            int[,] array = new int[3, 3] { { 4, 2, 3 }, { 0, 5, 6 }, { 7, 8, 1 } };
            Node aNode = new Node(array);
            List<Node> nodeList = aNode.Expand();
            Node answerNode = nodeList.ToArray()[1];
            Assert.AreEqual(answerNode.ToString(), "4 2 3 7 5 6 0 8 1 ");            
        }

        [TestMethod]
        public void EleventhMoveTest()
        {
                int[,] array = new int[3, 3] { { 4, 2, 3 }, { 5, 0, 6 }, { 7, 8, 1 } };
                Node aNode = new Node(array);
                List<Node> nodeList = aNode.Expand();
                Node answerNode = nodeList.ToArray()[0];
                Assert.AreEqual(answerNode.ToString(), "4 2 3 5 6 0 7 8 1 ");
        }

        [TestMethod]
        public void TwelvethMoveTest()
        {
            int[,] array = new int[3, 3] { { 4, 2, 3 }, { 5, 0, 6 }, { 7, 8, 1 } };
            Node aNode = new Node(array);
            List<Node> nodeList = aNode.Expand();
            Node answerNode = nodeList.ToArray()[1];
            Assert.AreEqual(answerNode.ToString(), "4 2 3 5 8 6 7 0 1 ");            
        }

        [TestMethod]
        public void ThirteenthMoveTest()
        {
            int[,] array = new int[3, 3] { { 4, 2, 3 }, { 5, 0, 6 }, { 7, 8, 1 } };
            Node aNode = new Node(array);
            List<Node> nodeList = aNode.Expand();
            Node answerNode = nodeList.ToArray()[2];
            Assert.AreEqual(answerNode.ToString(), "4 0 3 5 2 6 7 8 1 ");
        }

        [TestMethod]
        public void FourteenthMoveTest()
        {
            int[,] array = new int[3, 3] { { 4, 2, 3 }, { 5, 0, 6 }, { 7, 8, 1 } };
            Node aNode = new Node(array);
            List<Node> nodeList = aNode.Expand();
            Node answerNode = nodeList.ToArray()[3];
            Assert.AreEqual(answerNode.ToString(), "4 2 3 0 5 6 7 8 1 ");
        }

        [TestMethod]
        public void FifteenthMoveTest()
        {
            int[,] array = new int[3, 3] { { 4, 2, 3 }, { 5, 6, 0 }, { 7, 8, 1 } };
            Node aNode = new Node(array);
            List<Node> nodeList = aNode.Expand();
            Node answerNode = nodeList.ToArray()[0];
            Assert.AreEqual(answerNode.ToString(), "4 2 3 5 0 6 7 8 1 ");
        }

        [TestMethod]
        public void SixteenthMoveTest()
        {
            int[,] array = new int[3, 3] { { 4, 2, 3 }, { 5, 6, 0 }, { 7, 8, 1 } };
            Node aNode = new Node(array);
            List<Node> nodeList = aNode.Expand();
            Node answerNode = nodeList.ToArray()[0];
            Assert.AreEqual(answerNode.ToString(), "4 2 3 5 0 6 7 8 1 ");
        }

        [TestMethod]
        public void SeventeenthMoveTest()
        {
            int[,] array = new int[3, 3] { { 4, 2, 3 }, { 5, 6, 0 }, { 7, 8, 1 } };
            Node aNode = new Node(array);
            List<Node> nodeList = aNode.Expand();
            Node answerNode = nodeList.ToArray()[1];
            Assert.AreEqual(answerNode.ToString(), "4 2 3 5 6 1 7 8 0 ");
        }

        [TestMethod]
        public void EighteenthMoveTest()
        {
            int[,] array = new int[3, 3] { { 4, 2, 3 }, { 5, 6, 0 }, { 7, 8, 1 } };
            Node aNode = new Node(array);
            List<Node> nodeList = aNode.Expand();
            Node answerNode = nodeList.ToArray()[2];
            Assert.AreEqual(answerNode.ToString(), "4 2 0 5 6 3 7 8 1 ");
        }

        public void NineteenthMoveTest()
        {
            int[,] array = new int[3, 3] { { 7, 2, 3 }, { 4, 5, 6 }, { 0, 8, 1 } };
            Node aNode = new Node(array);
            List<Node> nodeList = aNode.Expand();
            Node answerNode = nodeList.ToArray()[0];
            Assert.AreEqual(answerNode.ToString(), "7 2 3 4 5 6 8 0 1 ");
        }

        [TestMethod]        
        public void TwentiethMoveTest()
        {
            int[,] array = new int[3, 3] { { 7, 2, 3 }, { 4, 5, 6 }, { 0, 8, 1 } };
            Node aNode = new Node(array);
            List<Node> nodeList = aNode.Expand();
            Node answerNode = nodeList.ToArray()[1];
            Assert.AreEqual(answerNode.ToString(), "7 2 3 0 5 6 4 8 1 ");
        }

        [TestMethod]
        public void TwentyFirstMoveTest()
        {
            int[,] array = new int[3, 3] { { 7, 2, 3 }, { 4, 8, 6 }, { 5, 0, 1 } };
            Node aNode = new Node(array);
            List<Node> nodeList = aNode.Expand();
            Node answerNode = nodeList.ToArray()[0];
            Assert.AreEqual(answerNode.ToString(), "7 2 3 4 8 6 0 5 1 ");
        }

        [TestMethod]
        public void TwentySecondMoveTest()
        {
            int[,] array = new int[3, 3] { { 7, 2, 3 }, { 4, 8, 6 }, { 5, 0, 1 } };
            Node aNode = new Node(array);
            List<Node> nodeList = aNode.Expand();
            Node answerNode = nodeList.ToArray()[1];
            Assert.AreEqual(answerNode.ToString(), "7 2 3 4 8 6 5 1 0 ");
        }

        [TestMethod]
        public void TwentyThirdMoveTest()
        {
            int[,] array = new int[3, 3] { { 7, 2, 3 }, { 4, 8, 6 }, { 5, 0, 1 } };
            Node aNode = new Node(array);
            List<Node> nodeList = aNode.Expand();
            Node answerNode = nodeList.ToArray()[2];
            Assert.AreEqual(answerNode.ToString(), "7 2 3 4 0 6 5 8 1 ");
        }



    }
}
