using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GenMo.Domain.Common.Utils
{
    public static class RandomUtil
    {
        public static int Next(int min, int max)
        {
            if (min > max)
            {
                throw new ArgumentOutOfRangeException(nameof(min));
            }

            if (min == max)
            {
                return min;
            }

            using (var rng = new RNGCryptoServiceProvider())
            {
                var data = new byte[4];
                rng.GetBytes(data);

                var generatedValue = Math.Abs(BitConverter.ToInt32(data, startIndex: 0));

                var diff = max - min;
                var mod = generatedValue % diff;
                var normalizedNumber = min + mod;

                return normalizedNumber;
            }
        }
    }
}
