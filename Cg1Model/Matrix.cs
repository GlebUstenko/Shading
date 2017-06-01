using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Cg1Model
{
    public class Matrix : IEnumerable<double>
    {
        const string DimentionExceptionMessage = "Invalid matrix dimentions";
        public static Matrix GetE(int n)
        {
            var result = new Matrix(n, n);
            for (int i = 0; i < n; i++)
            {
                result[i, i] = 1.0;
            }
            return result;
        }

        private readonly double[,] _value;

        public Matrix(int rows, int cols)
            : this(new double[rows, cols])
        {
        }

        public Matrix(double[,] value)
        {
            _value = (double[,])value.Clone();
        }

        public static Matrix operator *(Matrix one, Matrix other)
        {
            return new Matrix(Multiply(one._value, other._value));
        }

        public static Matrix operator *(double scalar, Matrix matrix)
        {
            var result = (double[,]) matrix._value.Clone();
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    result[i, j] *= scalar;
                }
            }
            return result;
        }

        public static Matrix operator *(Matrix matrix, double scalar)
        {
            return scalar * matrix;
        }

        public static Matrix operator +(Matrix one, Matrix another)
        {
            return GetMatrix(one, another, 1);
        }

        public static Matrix operator -(Matrix one, Matrix another)
        {
            return GetMatrix(one, another, -1);
        }

        private static Matrix GetMatrix(Matrix one, Matrix another, int sign)
        {
            var m = GetDim(one, another, 0);
            int n = GetDim(one, another, 1);
            var res = new double[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    res[i, j] = one[i, j] + another[i, j]*sign;
                }
            }
            return new Matrix(res);
        }

        private static int GetDim(Matrix one, Matrix another, int dim)
        {
            int dimOne = one._value.GetLength(dim);
            int dimAnother = another._value.GetLength(dim);

            if (dimOne != dimAnother)
            {
                
                throw new ArgumentException(DimentionExceptionMessage);
            }
            return dimOne;
        }

        public static Matrix operator /(Matrix matrix, double scalar)
        {
            return matrix*(1.0/scalar);
        }

        public double this[int i, int j]
        {
            get { return _value[i,j]; }
            set { _value[i,j ] = value; }
        }

        public IEnumerator<double> GetEnumerator()
        {
            // ReSharper disable once LoopCanBeConvertedToQuery
            foreach (double d in _value)
            {
                yield return d;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public static implicit operator Matrix(double[,] doubles)
        {
            return new Matrix(doubles);
        }

        public static explicit operator double[,](Matrix matrix)
        {
            return matrix._value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static double[,] Multiply(double[,] a, double[,] b)
        {
            if (a.GetLength(1) != b.GetLength(0))
                throw new ArgumentException(DimentionExceptionMessage);
            var result = new double[a.GetLength(0), b.GetLength(1)];
            Parallel.For(0, a.GetLength(0),i =>
                         {
                             for (int j = 0; j < b.GetLength(1); j++)
                                 result[i, j] = MultiplyR(a, b, i, j);
                         });
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static double MultiplyR(double[,] a, double[,] b, int i, int j)
        {
            double result = 0;
            for (int k = 0; k < a.GetLength(1); k++)
                result += a[i, k] * b[k, j];
            return result;
        }

        public int GetLength(int dim)
        {
            return _value.GetLength(dim);
        }
    }
}