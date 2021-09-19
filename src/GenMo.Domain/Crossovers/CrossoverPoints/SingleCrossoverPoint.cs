using GenMo.Domain.Common.Interfaces.Crossovers;
using GenMo.Domain.Common.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenMo.Domain.Crossovers.CrossoverPoints
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
