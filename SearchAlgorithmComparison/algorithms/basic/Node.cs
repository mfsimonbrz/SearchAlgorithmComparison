using System.Collections.Generic;
using System.Text;

namespace SearchAlgorithmComparison.algorithms.basic
{
    public class Node
    {
        public int[,] Value { get; }

        public ENodeState State { get; set; }

        public int Level { get; set; }

        public PathCostCalculationDelegate PathCost;
        
        public Node(int[,] puzzle)
        {
            Value = puzzle;
            State = ENodeState.White;
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
            
        public int GetCost()
        {
            if (PathCost == null)
            {
                throw new System.NotImplementedException("PathCostCalculationDelegate não implentado!");
            }

            return PathCost();
        }
    }    

}
