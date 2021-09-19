using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenMo.Domain.Common.Utils
{
    public static class RandomUtil
    {
        [ThreadStatic]
        private static Random _rnd;

        private static void Init()
        {
            _rnd ??= new Random();
        }

        public static int Random(int min, int max)
        {
            Init();

            return _rnd.Next(min, max);
        }
    }
}
