using GenMo.Domain.Common.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenMo.Domain.Crossovers.CrossoverPoints
{
    public static class CrossoverPoints
    {
        public static int GetSingle(int chromosomeLength) =>
            RandomUtil.Next(1, chromosomeLength - 1);

        public static (int, int) GetDouble(int chromosomeLength)
        {
            int valueA, valueB;

            while (true)
            {
                (valueA, valueB) = (RandomUtil.Next(0, chromosomeLength), RandomUtil.Next(0, chromosomeLength));

                if (valueA != valueB)
                {
                    return valueA < valueB
                        ? (valueA, valueB)
                        : (valueB, valueA);
                }
            }
        }
    }
}
