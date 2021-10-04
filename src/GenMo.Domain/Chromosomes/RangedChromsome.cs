using System.Collections.Generic;
using System.Linq;
using GenMo.Domain.Common.Utils;

namespace GenMo.Domain.Chromosomes
{
    public struct RangedChromsome
    {
        public IList<int> Genes { get; private init; }

        public RangedChromsome(int chromosomeLength) =>
            Genes = Enumerable.Range(0, chromosomeLength)
                .ToArray()
                .Shuffle();


        public RangedChromsome(IList<int> genome)
            => Genes = genome;

        public override string ToString() =>
            string.Join(", ", Genes);
    }
}
