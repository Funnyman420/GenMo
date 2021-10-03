using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenMo.Domain.Common.Interfaces.Crossovers
{
    public interface ICrossoverPoint<TReturn>
    {
        public TReturn PointValue { get; }

        static TReturn GetCrossoverPoints(int chromosomeLength)
            => throw new NotImplementedException();
    }
}
