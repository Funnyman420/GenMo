using GenMo.Domain.Common.Interfaces.Crossovers;
using GenMo.Domain.Crossovers.CrossoverPoints;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GenMo.Domain.Crossovers
{
    public class OnePointCrossover : ICrossover<SingleCrossoverPoint>
    {
        public (IList<int>, IList<int>) Breed(IList<int> parentA, IList<int> parentB)
        {
            var crossoverPoint = SingleCrossoverPoint
                .GetCrossoverPoints(parentA.Count);

            return (GenerateOffspring(parentA, parentB, crossoverPoint), GenerateOffspring(parentB, parentA, crossoverPoint));
        }

        public IList<int> GenerateOffspring(IList<int> leadingParent, IList<int> secondaryParent, SingleCrossoverPoint crossoverPoint)
        {
            var offspring = leadingParent.Take(crossoverPoint.PointValue).ToList();

            foreach (var gene in secondaryParent)
            {
                if (!offspring.Contains(gene))
                {
                    offspring.Add(gene);
                }
            }

            return offspring;
        }
    }
}
