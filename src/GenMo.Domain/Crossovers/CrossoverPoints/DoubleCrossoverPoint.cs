using GeneSharp.Domain.Common.Interfaces.Crossovers;
using GeneSharp.Domain.Common.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneSharp.Domain.Crossovers.CrossoverPoints
{
    public struct DoubleCrossoverPoint : ICrossoverPoint
    {
        public readonly int FirstPointValue { get; private init; }
        public readonly int SecondPointValue { get; private init; }

        private DoubleCrossoverPoint(int chromosomeLength)
        {
            int valueA;
            int valueB;

            while (true)
            {
                (valueA, valueB) = (RandomUtil.Random(0, chromosomeLength), RandomUtil.Random(0, chromosomeLength));

                if (valueA != valueB)
                {
                    (FirstPointValue, SecondPointValue) = valueA < valueB
                        ? (valueA, valueB)
                        : (valueB, valueA);

                    break;
                }
            }
        }

        public static ICrossoverPoint GetCrossoverPoints(int chromosomeLength)
        {
            return new DoubleCrossoverPoint(chromosomeLength);
        }
    }
}
