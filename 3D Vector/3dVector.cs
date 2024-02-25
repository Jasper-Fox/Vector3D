namespace MyMath
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
            if (a < 0)
            {
                Console.WriteLine("Incorrect Value");
                return 0;
            }
            else
            {
                float min = 0;
                float max = a;
                float result = Rootrec(a, min, max);
                return result;
            }
        }
        private static float Rootrec(float a, float min, float max)
        {
            float average = (min + max) / 2;
            float result = a / average;           
            if (result - average < -0.000001)
            {
                max = average;
                result = Rootrec(a, min, max);
            }
            if (result - average > 0.000001)
            {
                min = average;
                result = Rootrec(a, min, max);
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
