using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneSharp.Domain.Common.Interfaces.Crossovers
{
    public interface ICrossoverPoint
    {
        static T GetCrossoverPoints<T>(int chromosomeLength) where T : ICrossoverPoint
            => throw new NotImplementedException();
    }
}
