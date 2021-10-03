using GenMo.Domain.Common.Interfaces.Crossovers;
using GenMo.Domain.Common.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenMo.Domain.Crossovers.CrossoverPoints
{
    public static class SingleCrossoverPoint
    {
        public static int GetCrossoverPoints(int chromosomeLength)
        {
            return RandomUtil.Random(1, chromosomeLength - 1);
        }
    }
}
