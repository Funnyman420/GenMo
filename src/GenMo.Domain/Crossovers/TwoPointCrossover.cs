using GenMo.Domain.Common.Interfaces.Crossovers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenMo.Domain.Crossovers
{
    public class TwoPointCrossover : ICrossover
    {
        public static (IList<int>, IList<int>) Breed(IList<int> parentA, IList<int> parentB)
        {
            throw new NotImplementedException();
        }
    }
}
