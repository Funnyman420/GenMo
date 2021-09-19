using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneSharp.Domain.Common.Interfaces.Crossovers
{
    public interface ICrossover
    {
        (IList<int>, IList<int>) Breed(IList<int> parentA, IList<int> parentB);

        IList<int> GenerateOffspring(IList<int> leadingParent, IList<int> secondaryParent);
    }
}
