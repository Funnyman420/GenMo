using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenMo.Domain.Common.Utils
{
    public static class ArrayUtil
    {
        public static IList<T> Shuffle<T>(this IList<T> array)
        {
            var arrayLength = array.Count;

            if (arrayLength == 0)
            {
                return array;
            }
            else
            {
                while (arrayLength > 1)
                {
                    var swapPosition = RandomUtil.Next(0, arrayLength--);
                    var tempValue = array[arrayLength];
                    array[arrayLength] = array[swapPosition];
                    array[swapPosition] = tempValue;
                }
                return array;
            }
        }
    }
}
