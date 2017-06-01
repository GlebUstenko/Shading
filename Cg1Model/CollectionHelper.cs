using System;
using System.Collections.Generic;

namespace Cg1Model
{
    public static class CollectionHelper
    {
        public static TResult[] SelectToArray<T, TResult>(this ICollection<T> source, Func<T, TResult> selector)
        {
            if (source == null)
                throw new ArgumentNullException("source");
            if (selector == null)
                throw new ArgumentNullException("selector");
            var result = new TResult[source.Count];
            int i = 0;
            foreach (T t in source)
            {
                result[i] = selector(t);
                i++;
            }
            return result;
        }
    }
}