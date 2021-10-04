using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenMo.Domain.Common.Interfaces.Crossovers
{
    public interface ICrossover
    {
        static (IList<int>, IList<int>) Breed(IList<int> parentA, IList<int> parentB)
            => throw new NotImplementedException();
    }
}
