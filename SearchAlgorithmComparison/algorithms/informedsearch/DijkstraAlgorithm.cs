using SearchAlgorithmComparison.algorithms.basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgorithmComparison.algorithms.informedsearch
{
    public class DijkstraAlgorithm : BaseAlgorithm
    {

        public DijkstraAlgorithm()
        {
            //
        }
               
        protected override void Execute(Node puzzle)
        {            
            throw new NotImplementedException();
        }

        public int GetCost()
        {
            //at a first try, I'll just count pieces out of the right place
            //the less pieces it has, the better the path is;
            //the method's name will change as soon as I implement more heuristics
            throw new NotImplementedException("Não implementado!");
        }
    }
}
