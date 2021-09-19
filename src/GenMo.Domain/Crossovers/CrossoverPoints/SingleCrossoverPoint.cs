using GeneSharp.Domain.Common.Interfaces.Crossovers;
using GeneSharp.Domain.Common.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneSharp.Domain.Crossovers.CrossoverPoints
{
    public struct SingleCrossoverPoint : ICrossoverPoint
    {
        public int PointValue { get; private init; }

        private SingleCrossoverPoint(int chromosomeLength)
        {
            PointValue = RandomUtil.Random(0, chromosomeLength);
        }

        public static SingleCrossoverPoint GetCrossoverPoints(int chromosomeLength)
        {
            return new SingleCrossoverPoint(chromosomeLength);
        }
    }
}
