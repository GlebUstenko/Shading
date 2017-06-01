using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using Cg1Model;

namespace Cg1WinForm
{
    public static class VectorHelper
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static PointF[] CastToPointF(this IList<Vector> points)
        {
            var result = new PointF[points.Count];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = new PointF((float)points[i].X, (float)points[i].Y);
            }
            return result;
        }
    }
}