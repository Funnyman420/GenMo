using GeneSharp.Domain.Common.Interfaces;
using GeneSharp.Domain.Common.Interfaces.Crossovers;
using GeneSharp.Domain.Crossovers.CrossoverPoints;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GeneSharp.Domain.Crossovers
{
    public class OnePointCrossover : ICrossover
    {
        public override (IList<int>, IList<int>) Breed(IList<int> parentA, IList<int> parentB)
        {
            var crossoverPoint = SingleCrossoverPoint
                .GetCrossoverPoints(parentA.Count)
                .PointValue;

            return (GenerateOffspring(parentA, parentB), GenerateOffspring(parentB, parentA));
        }

        //public IList<int> GetOffspring(IList<int> leadingParent, IList<int> secondaryParent)
        //{
        //    var offspring = leadingParent.Take(FirstCrossoverPoint).ToList();

        //    foreach (var gene in secondaryParent)
        //    {
        //        if (!offspring.Contains(gene))
        //        {
        //            offspring.Add(gene);
        //        }
        //    }

        //    return offspring;
        //}

        public IList<int> GenerateOffspring(IList<int> leadingParent, IList<int> secondaryParent)
        {
            throw new NotImplementedException();
        }
    }
}
