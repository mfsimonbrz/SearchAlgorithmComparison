using System.Collections.Generic;

namespace SearchAlgorithmComparison.algorithms.basic
{
    public class ExpandedNodesFinder
    {
        public static List<Node> ExpandNode(Node aNode)
        {
            List<Node> expandedNodes = new List<Node>();
            int line, column;
            FindZero(aNode, out line, out column);

            if (line == 0)
            {
                if (column == 0)
                {
                    //move 0 para a direita
                    int[,] firstMoveArray = (int[,])aNode.Value.Clone();
                    firstMoveArray[line, column] = firstMoveArray[line, column + 1];
                    firstMoveArray[line, column + 1] = 0;
                    Node firstNode = new Node(firstMoveArray);

                    //move 0 para baixo
                    int[,] secondMoveArray = (int[,])aNode.Value.Clone();
                    secondMoveArray[line, column] = secondMoveArray[line + 1, column];
                    secondMoveArray[line + 1, column] = 0;
                    Node secondNode = new Node(secondMoveArray);

                    firstNode.Level = aNode.Level + 1;
                    secondNode.Level = aNode.Level + 1;

                    expandedNodes.Add(firstNode);
                    expandedNodes.Add(secondNode);
                }

                if (column == 1)
                {
                    //move 0 para a esquerda
                    int[,] firstMoveArray = (int[,])aNode.Value.Clone();
                    firstMoveArray[line, column] = firstMoveArray[line, column - 1];
                    firstMoveArray[line, column - 1] = 0;
                    Node firstNode = new Node(firstMoveArray);

                    //move 0 para a direita
                    int[,] secondMoveArray = (int[,])aNode.Value.Clone();
                    secondMoveArray[line, column] = secondMoveArray[line, column + 1];
                    secondMoveArray[line, column + 1] = 0;
                    Node secondNode = new Node(secondMoveArray);

                    //move 0 para baixo
                    int[,] thirdMoveArray = (int[,])aNode.Value.Clone();
                    thirdMoveArray[line, column] = thirdMoveArray[line + 1, column];
                    thirdMoveArray[line + 1, column] = 0;
                    Node thirdNode = new Node(thirdMoveArray);

                    firstNode.Level = aNode.Level + 1;
                    secondNode.Level = aNode.Level + 1;
                    thirdNode.Level = aNode.Level + 1;

                    expandedNodes.Add(firstNode);
                    expandedNodes.Add(secondNode);
                    expandedNodes.Add(thirdNode);
                }

                if (column == 2)
                {
                    //move 0 para a esquerda
                    int[,] firstMoveArray = (int[,])aNode.Value.Clone();
                    firstMoveArray[line, column] = firstMoveArray[line, column - 1];
                    firstMoveArray[line, column - 1] = 0;
                    Node firstNode = new Node(firstMoveArray);

                    //move 0 para baixo
                    int[,] secondMoveArray = (int[,])aNode.Value.Clone();
                    secondMoveArray[line, column] = secondMoveArray[line + 1, column];
                    secondMoveArray[line + 1, column] = 0;
                    Node secondNode = new Node(secondMoveArray);

                    firstNode.Level = aNode.Level + 1;
                    secondNode.Level = aNode.Level + 1;

                    expandedNodes.Add(firstNode);
                    expandedNodes.Add(secondNode);
                }

            }

            if (line == 1)
            {
                if (column == 0)
                {
                    //move 0 para a direita
                    int[,] firstMoveArray = (int[,])aNode.Value.Clone();
                    firstMoveArray[line, column] = firstMoveArray[line, column + 1];
                    firstMoveArray[line, column + 1] = 0;
                    Node firstNode = new Node(firstMoveArray);

                    //move 0 para baixo
                    int[,] secondMoveArray = (int[,])aNode.Value.Clone();
                    secondMoveArray[line, column] = secondMoveArray[line + 1, column];
                    secondMoveArray[line + 1, column] = 0;
                    Node secondNode = new Node(secondMoveArray);

                    //move 0 para cima
                    int[,] thirdMoveArray = (int[,])aNode.Value.Clone();
                    thirdMoveArray[line, column] = thirdMoveArray[line - 1, column];
                    thirdMoveArray[line - 1, column] = 0;
                    Node thirdNode = new Node(thirdMoveArray);

                    firstNode.Level = aNode.Level + 1;
                    secondNode.Level = aNode.Level + 1;
                    thirdNode.Level = aNode.Level + 1;

                    expandedNodes.Add(firstNode);
                    expandedNodes.Add(secondNode);
                    expandedNodes.Add(thirdNode);
                }

                if (column == 1)
                {
                    //move 0 para a direita
                    int[,] firstMoveArray = (int[,])aNode.Value.Clone();
                    firstMoveArray[line, column] = firstMoveArray[line, column + 1];
                    firstMoveArray[line, column + 1] = 0;
                    Node firstNode = new Node(firstMoveArray);

                    //move 0 para baixo
                    int[,] secondMoveArray = (int[,])aNode.Value.Clone();
                    secondMoveArray[line, column] = secondMoveArray[line + 1, column];
                    secondMoveArray[line + 1, column] = 0;
                    Node secondNode = new Node(secondMoveArray);

                    //move 0 para cima
                    int[,] thirdMoveArray = (int[,])aNode.Value.Clone();
                    thirdMoveArray[line, column] = thirdMoveArray[line - 1, column];
                    thirdMoveArray[line - 1, column] = 0;
                    Node thirdNode = new Node(thirdMoveArray);

                    //move 0 para a esquerda
                    int[,] fourthMoveArray = (int[,])aNode.Value.Clone();
                    fourthMoveArray[line, column] = fourthMoveArray[line, column - 1];
                    fourthMoveArray[line, column - 1] = 0;
                    Node fourthNode = new Node(fourthMoveArray);

                    firstNode.Level = aNode.Level + 1;
                    secondNode.Level = aNode.Level + 1;
                    thirdNode.Level = aNode.Level + 1;
                    fourthNode.Level = aNode.Level + 1;

                    expandedNodes.Add(firstNode);
                    expandedNodes.Add(secondNode);
                    expandedNodes.Add(thirdNode);
                    expandedNodes.Add(fourthNode);
                }

                if (column == 2)
                {
                    //move 0 para a esquerda
                    int[,] firstMoveArray = (int[,])aNode.Value.Clone();
                    firstMoveArray[line, column] = firstMoveArray[line, column - 1];
                    firstMoveArray[line, column - 1] = 0;
                    Node firstNode = new Node(firstMoveArray);

                    //move 0 para baixo
                    int[,] secondMoveArray = (int[,])aNode.Value.Clone();
                    secondMoveArray[line, column] = secondMoveArray[line + 1, column];
                    secondMoveArray[line + 1, column] = 0;
                    Node secondNode = new Node(secondMoveArray);


                    //move 0 para cima
                    int[,] thirdMoveArray = (int[,])aNode.Value.Clone();
                    thirdMoveArray[line, column] = thirdMoveArray[line - 1, column];
                    thirdMoveArray[line - 1, column] = 0;
                    Node thirdNode = new Node(thirdMoveArray);

                    firstNode.Level = aNode.Level + 1;
                    secondNode.Level = aNode.Level + 1;
                    thirdNode.Level = aNode.Level + 1;

                    expandedNodes.Add(firstNode);
                    expandedNodes.Add(secondNode);
                    expandedNodes.Add(thirdNode);
                }
            }

            if (line == 2)
            {
                if (column == 0)
                {
                    //move 0 para a direita
                    int[,] firstMoveArray = (int[,])aNode.Value.Clone();
                    firstMoveArray[line, column] = firstMoveArray[line, column + 1];
                    firstMoveArray[line, column + 1] = 0;
                    Node firstNode = new Node(firstMoveArray);

                    //move 0 para cima
                    int[,] secondMoveArray = (int[,])aNode.Value.Clone();
                    secondMoveArray[line, column] = secondMoveArray[line - 1, column];
                    secondMoveArray[line - 1, column] = 0;
                    Node secondNode = new Node(secondMoveArray);

                    firstNode.Level = aNode.Level + 1;
                    secondNode.Level = aNode.Level + 1;

                    expandedNodes.Add(firstNode);
                    expandedNodes.Add(secondNode);
                }

                if (column == 1)
                {
                    //move 0 para a esquerda
                    int[,] firstMoveArray = (int[,])aNode.Value.Clone();
                    firstMoveArray[line, column] = firstMoveArray[line, column - 1];
                    firstMoveArray[line, column - 1] = 0;
                    Node firstNode = new Node(firstMoveArray);

                    //move 0 para a direita
                    int[,] secondMoveArray = (int[,])aNode.Value.Clone();
                    secondMoveArray[line, column] = secondMoveArray[line, column + 1];
                    secondMoveArray[line, column + 1] = 0;
                    Node secondNode = new Node(secondMoveArray);

                    //move 0 para cima
                    int[,] thirdMoveArray = (int[,])aNode.Value.Clone();
                    thirdMoveArray[line, column] = thirdMoveArray[line - 1, column];
                    thirdMoveArray[line - 1, column] = 0;
                    Node thirdNode = new Node(thirdMoveArray);

                    firstNode.Level = aNode.Level + 1;
                    secondNode.Level = aNode.Level + 1;
                    thirdNode.Level = aNode.Level + 1;

                    expandedNodes.Add(firstNode);
                    expandedNodes.Add(secondNode);
                    expandedNodes.Add(thirdNode);
                }

                if (column == 2)
                {
                    //move 0 para a esquerda
                    int[,] firstMoveArray = (int[,])aNode.Value.Clone();
                    firstMoveArray[line, column] = firstMoveArray[line, column - 1];
                    firstMoveArray[line, column - 1] = 0;
                    Node firstNode = new Node(firstMoveArray);

                    //move 0 para cima
                    int[,] secondMoveArray = (int[,])aNode.Value.Clone();
                    secondMoveArray[line, column] = secondMoveArray[line - 1, column];
                    secondMoveArray[line - 1, column] = 0;
                    Node secondNode = new Node(secondMoveArray);

                    firstNode.Level = aNode.Level + 1;
                    secondNode.Level = aNode.Level + 1;

                    expandedNodes.Add(firstNode);
                    expandedNodes.Add(secondNode);
                }
            }

            return expandedNodes;
        }

        private static void FindZero(Node aNode, out int line, out int column)
        {
            line = 0;
            column = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (aNode.Value[i, j] == 0)
                    {
                        line = i;
                        column = j;
                        break;
                    }
                }
            }
        }
    }
}
