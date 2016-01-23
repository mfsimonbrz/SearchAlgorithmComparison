using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgorithmComparison.algorithms
{
    public class Node
    {
        public int[,] Value { get; }

        public ENodeState State { get; set; }

        public int Level { get; set; }

        public Node(int[,] puzzle)
        {
            Value = puzzle;
            State = ENodeState.White;
        }

        public List<Node> Expand()
        {
            List<Node> expandedNodes = new List<Node>();
            int line, column;
            FindZero(out line, out column);

            if(line == 0)
            {
                if(column == 0)
                {     
                    //move 0 para a direita
                    int[,] firstMoveArray = (int[,]) Value.Clone();
                    firstMoveArray[line, column] = firstMoveArray[line, column + 1];
                    firstMoveArray[line, column + 1] = 0;
                    Node firstNode = new Node(firstMoveArray);                    

                    //move 0 para baixo
                    int[,] secondMoveArray = (int[,]) Value.Clone();
                    secondMoveArray[line, column] = secondMoveArray[line + 1, column];
                    secondMoveArray[line + 1, column] = 0;
                    Node secondNode = new Node(secondMoveArray);

                    firstNode.Level = Level + 1;
                    secondNode.Level = Level + 1;

                    expandedNodes.Add(firstNode);
                    expandedNodes.Add(secondNode);
                }
                
                if(column == 1)
                {
                    //move 0 para a esquerda
                    int[,] firstMoveArray = (int[,]) Value.Clone();
                    firstMoveArray[line, column] = firstMoveArray[line, column - 1];
                    firstMoveArray[line, column - 1] = 0;
                    Node firstNode = new Node(firstMoveArray);

                    //move 0 para a direita
                    int[,] secondMoveArray = (int[,]) Value.Clone();
                    secondMoveArray[line, column] = secondMoveArray[line, column + 1];
                    secondMoveArray[line, column + 1] = 0;
                    Node secondNode = new Node(secondMoveArray);

                    //move 0 para baixo
                    int[,] thirdMoveArray = (int[,]) Value.Clone();
                    thirdMoveArray[line, column] = thirdMoveArray[line + 1, column];
                    thirdMoveArray[line + 1, column] = 0;
                    Node thirdNode = new Node(thirdMoveArray);

                    firstNode.Level = Level + 1;
                    secondNode.Level = Level + 1;
                    thirdNode.Level = Level + 1;

                    expandedNodes.Add(firstNode);
                    expandedNodes.Add(secondNode);
                    expandedNodes.Add(thirdNode);
                }
                
                if(column == 2)
                {
                    //move 0 para a esquerda
                    int[,] firstMoveArray = (int[,]) Value.Clone();
                    firstMoveArray[line, column] = firstMoveArray[line, column - 1];
                    firstMoveArray[line, column - 1] = 0;
                    Node firstNode = new Node(firstMoveArray);

                    //move 0 para baixo
                    int[,] secondMoveArray = (int[,]) Value.Clone();
                    secondMoveArray[line, column] = secondMoveArray[line + 1, column];
                    secondMoveArray[line + 1, column] = 0;
                    Node secondNode = new Node(secondMoveArray);

                    firstNode.Level = Level + 1;
                    secondNode.Level = Level + 1;                    

                    expandedNodes.Add(firstNode);
                    expandedNodes.Add(secondNode);
                }

            }

            if (line == 1)
            {
                if(column == 0)
                {
                    //move 0 para a direita
                    int[,] firstMoveArray = (int[,]) Value.Clone();
                    firstMoveArray[line, column] = firstMoveArray[line, column + 1];
                    firstMoveArray[line, column + 1] = 0;
                    Node firstNode = new Node(firstMoveArray);

                    //move 0 para baixo
                    int[,] secondMoveArray = (int[,]) Value.Clone();
                    secondMoveArray[line, column] = secondMoveArray[line + 1, column];
                    secondMoveArray[line + 1, column] = 0;
                    Node secondNode = new Node(secondMoveArray);

                    //move 0 para cima
                    int[,] thirdMoveArray = (int[,]) Value.Clone();
                    thirdMoveArray[line, column] = thirdMoveArray[line - 1, column];
                    thirdMoveArray[line - 1, column] = 0;
                    Node thirdNode = new Node(thirdMoveArray);

                    firstNode.Level = Level + 1;
                    secondNode.Level = Level + 1;
                    thirdNode.Level = Level + 1;

                    expandedNodes.Add(firstNode);
                    expandedNodes.Add(secondNode);
                    expandedNodes.Add(thirdNode);
                }

                if(column == 1)
                {
                    //move 0 para a direita
                    int[,] firstMoveArray = (int[,])Value.Clone();
                    firstMoveArray[line, column] = firstMoveArray[line, column + 1];
                    firstMoveArray[line, column + 1] = 0;
                    Node firstNode = new Node(firstMoveArray);

                    //move 0 para baixo
                    int[,] secondMoveArray = (int[,])Value.Clone();
                    secondMoveArray[line, column] = secondMoveArray[line + 1, column];
                    secondMoveArray[line + 1, column] = 0;
                    Node secondNode = new Node(secondMoveArray);

                    //move 0 para cima
                    int[,] thirdMoveArray = (int[,])Value.Clone();
                    thirdMoveArray[line, column] = thirdMoveArray[line - 1, column];
                    thirdMoveArray[line - 1, column] = 0;
                    Node thirdNode = new Node(thirdMoveArray);

                    //move 0 para a esquerda
                    int[,] fourthMoveArray = (int[,])Value.Clone();
                    fourthMoveArray[line, column] = fourthMoveArray[line, column-1];
                    fourthMoveArray[line, column-1] = 0;
                    Node fourthNode = new Node(fourthMoveArray);

                    firstNode.Level = Level + 1;
                    secondNode.Level = Level + 1;
                    thirdNode.Level = Level + 1;
                    fourthNode.Level = Level + 1;

                    expandedNodes.Add(firstNode);
                    expandedNodes.Add(secondNode);
                    expandedNodes.Add(thirdNode);
                    expandedNodes.Add(fourthNode);
                }

                if(column == 2)
                {
                    //move 0 para a esquerda
                    int[,] firstMoveArray = (int[,])Value.Clone();
                    firstMoveArray[line, column] = firstMoveArray[line, column - 1];
                    firstMoveArray[line, column - 1] = 0;
                    Node firstNode = new Node(firstMoveArray);

                    //move 0 para baixo
                    int[,] secondMoveArray = (int[,])Value.Clone();
                    secondMoveArray[line, column] = secondMoveArray[line + 1, column];
                    secondMoveArray[line + 1, column] = 0;
                    Node secondNode = new Node(secondMoveArray);


                    //move 0 para cima
                    int[,] thirdMoveArray = (int[,])Value.Clone();
                    thirdMoveArray[line, column] = thirdMoveArray[line - 1, column];
                    thirdMoveArray[line - 1, column] = 0;
                    Node thirdNode = new Node(thirdMoveArray);

                    firstNode.Level = Level + 1;
                    secondNode.Level = Level + 1;
                    thirdNode.Level = Level + 1;

                    expandedNodes.Add(firstNode);
                    expandedNodes.Add(secondNode);
                    expandedNodes.Add(thirdNode);
                }
            }

            if(line == 2)
            {
                if(column == 0)
                {
                    //move 0 para a direita
                    int[,] firstMoveArray = (int[,])Value.Clone();
                    firstMoveArray[line, column] = firstMoveArray[line, column + 1];
                    firstMoveArray[line, column + 1] = 0;
                    Node firstNode = new Node(firstMoveArray);

                    //move 0 para cima
                    int[,] secondMoveArray = (int[,])Value.Clone();
                    secondMoveArray[line, column] = secondMoveArray[line - 1, column];
                    secondMoveArray[line - 1, column] = 0;
                    Node secondNode = new Node(secondMoveArray);

                    firstNode.Level = Level + 1;
                    secondNode.Level = Level + 1;                    

                    expandedNodes.Add(firstNode);
                    expandedNodes.Add(secondNode);
                }

                if(column == 1)
                {
                    //move 0 para a esquerda
                    int[,] firstMoveArray = (int[,])Value.Clone();
                    firstMoveArray[line, column] = firstMoveArray[line, column - 1];
                    firstMoveArray[line, column - 1] = 0;
                    Node firstNode = new Node(firstMoveArray);

                    //move 0 para a direita
                    int[,] secondMoveArray = (int[,])Value.Clone();
                    secondMoveArray[line, column] = secondMoveArray[line, column + 1];
                    secondMoveArray[line, column + 1] = 0;
                    Node secondNode = new Node(secondMoveArray);

                    //move 0 para cima
                    int[,] thirdMoveArray = (int[,])Value.Clone();
                    thirdMoveArray[line, column] = thirdMoveArray[line - 1, column];
                    thirdMoveArray[line - 1, column] = 0;
                    Node thirdNode = new Node(thirdMoveArray);

                    firstNode.Level = Level + 1;
                    secondNode.Level = Level + 1;
                    thirdNode.Level = Level + 1;

                    expandedNodes.Add(firstNode);
                    expandedNodes.Add(secondNode);
                    expandedNodes.Add(thirdNode);
                }

                if(column == 2)
                {
                    //move 0 para a esquerda
                    int[,] firstMoveArray = (int[,])Value.Clone();
                    firstMoveArray[line, column] = firstMoveArray[line, column - 1];
                    firstMoveArray[line, column - 1] = 0;
                    Node firstNode = new Node(firstMoveArray);

                    //move 0 para cima
                    int[,] secondMoveArray = (int[,])Value.Clone();
                    secondMoveArray[line, column] = secondMoveArray[line - 1, column];
                    secondMoveArray[line - 1, column] = 0;
                    Node secondNode = new Node(secondMoveArray);

                    firstNode.Level = Level + 1;
                    secondNode.Level = Level + 1;
                    
                    expandedNodes.Add(firstNode);
                    expandedNodes.Add(secondNode);
                }
            }

            return expandedNodes;
        }

        private void FindZero(out int line,out int column)
        {
            line = 0;
            column = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if(Value[i,j] == 0)
                    {
                        line = i;
                        column = j;
                        break;
                    }
                }
            }
        }

        public override string ToString()
        {            
            StringBuilder result = new StringBuilder();            
            for (int i = 0; i < 3; i++)
            {                
                for (int j = 0; j < 3; j++)
                {
                    result.Append(Value[i,j] + " ");
                }                
            }

            return result.ToString();            
        }

        public bool IsEqual(Node aNode)
        {
            bool equal = false;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    equal = aNode.Value[i, j] == Value[i, j];

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
                         
            
    }    

}
