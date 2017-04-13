using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMHISharp
{
    public static class ArrayExtensions
    {
        public static Dictionary<TKey, TValue> ToDictionary<TKey, TValue>(this TValue[] array, Func<TValue, TKey> key)
        {
            var result = new Dictionary<TKey, TValue>(array.Length);

            foreach(var value in array)
            {
                result.Add(key(value), value);
            }

            return result;
        }
    }
}
