using System;

namespace Cg1Model
{
    public class Vector : IEquatable<Vector>
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Vector(double x, double y, double z) 
        {
            X = x;
            Y = y;
            Z = z;
        }

        public Vector Clone()
        {
            return new Vector(X, Y, Z);
        }

        private Matrix XyzMatrix
        {
            get
            {
                return new[,] {{X, Y, Z}};
            }
        }

        public double Length
        {
            get
            {
                return Math.Sqrt(X*X + Y*Y + Z*Z);
            }
        }

        public void RotateX(double angle)
        {
            double[,] rotateMatrix =
            {
                {1, 0, 0},
                {0, Math.Cos(angle), -Math.Sin(angle)},
                {0, Math.Sin(angle), Math.Cos(angle)}
            };
            AffineTransform(rotateMatrix);
        }

        public void RotateY(double angle)
        {
            double[,] rotateMatrix =
            {
                {Math.Cos(angle), 0, Math.Sin(angle)},
                {0, 1, 0},
                {-Math.Sin(angle), 0, Math.Cos(angle)}
            };
            AffineTransform(rotateMatrix);
        }

        public void RotateZ(double angle)
        {
            double[,] rotateMatrix =
            {
                {Math.Cos(angle), -Math.Sin(angle), 0},
                {Math.Sin(angle), Math.Cos(angle), 0},
                {0, 0, 1}
            };
            AffineTransform(rotateMatrix);
        }

        public void ReflectX()
        {
            X = -X;
        }
        public void ReflectY()
        {
            Y = -Y;
        }
        public void ReflectZ()
        {
            Z = -Z;
        }

        public void AffineTransform(double[,] rotateMatrix)
        {
            var xyz1 = XyzMatrix;
            var result = xyz1*rotateMatrix;

            X = result[0, 0];
            Y = result[0, 1];
            Z = result[0, 2];
        }

        public void Move(Vector vector)
        {
            X += vector.X;
            Y += vector.Y;
            Z += vector.Z;
        }

        public static Vector operator +(Vector a, Vector b)
        {
            return new Vector(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
        }

        public static Vector operator -(Vector a, Vector b)
        {
            return new Vector(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
        }

        public static Vector operator -(Vector a)
        {
            return new Vector(-a.X, -a.Y, -a.Z);
        }

        public bool Equals(Vector other)
        {
            if (ReferenceEquals(null, other))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            return X.Equals(other.X) && Y.Equals(other.Y) && Z.Equals(other.Z);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            if (ReferenceEquals(this, obj))
                return true;
            if (obj.GetType() != GetType())
                return false;
            return Equals((Vector) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = X.GetHashCode();
                hashCode = (hashCode*397) ^ Y.GetHashCode();
                hashCode = (hashCode*397) ^ Z.GetHashCode();
                return hashCode;
            }
        }

        public static bool operator ==(Vector left, Vector right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Vector left, Vector right)
        {
            return !Equals(left, right);
        }

        public static Vector operator *(Vector left, Vector right)
        {
            return new Vector(left.Y*right.Z - left.Z*right.Y,
                              left.Z*right.X - left.X*right.Z,
                              left.X*right.Y - left.Y*right.X);
        }

        public static Vector operator /(Vector vector, double scallar)
        {
            return vector * (1.0 / scallar);
        }

        public static Vector operator *(Vector left, double scallar)
        {
            return new Vector(left.X*scallar, left.Y*scallar, left.Z*scallar);
        }

        public Vector Normalize()
        {
            var mult = 1.0/Length;
            X *= mult;
            Y *= mult;
            Z *= mult;
            return this;
        }
    }
}