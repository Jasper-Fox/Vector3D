﻿namespace MyMath
{
    public struct Vector3D
    {
        public float X;
        public float Y;
        public float Z;
        public Vector3D(float x, float y, float z) {  X = x; Y = y; Z = z; }
        public Vector3D Sum(Vector3D a)
        {
            X += a.X;
            Y += a.Y;
            Z += a.Z;
            return this;
        }

        public Vector3D Sub(Vector3D a)
        {
            a.Mult(-1);
            Sum(a);
            return this;
        }

        public Vector3D Mult(float a)
        {
            X *= a;
            Y *= a;
            Z *= a;
            return this;
        }

        public Vector3D Div(float a)
        {
            X /= a;
            Y /= a;
            Z /= a;
            return this;
        }

        public Vector3D CrossProd(Vector3D a)
        {
            Vector3D b = new Vector3D();
            b.X = Y * a.Z - Z * a.Y;
            b.Y = Z * a.X - X * a.Z;
            b.Z = X * a.Y - Y * a.X;
            return b;
        }

        private static float Root(float a)
        {
            float min = 0;
            float max = a;
            float result = Rootbody(a, min, max);
            return result;
        }
        private static float Rootbody(float a, float min, float max)
        {
            float average = (min + max) / 2;
            float result = a / average;
            if (Math.Round(result, 6) < Math.Round(average, 6))
            {
                max = average;
                result = Rootbody(a, min, max);
            }
            if (Math.Round(result, 6) > Math.Round(average, 6))
            {
                min = average;
                result = Rootbody(a, min, max);
            }
            return result;
        }

        public float DotProd(Vector3D a)
        {
            float norm = X * a.X + Y * a.Y + Z * a.Z;
            return norm;
        }

        public float Length()
        {
            float norm = DotProd(this);
            return Root(norm);
        }

        public override string ToString()
        {
            return "{" + X + " " + Y + " " + Z +"}";
        }
    }
    
}
