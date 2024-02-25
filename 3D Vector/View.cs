using MyMath;

namespace _3D_Vector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector3D a = new Vector3D(1f, 2f, 3f);
            Vector3D b = new Vector3D(2f, 3f, 4f);

            Console.WriteLine(" A = " + a);
            Console.WriteLine(" B = " + b);
            Console.WriteLine();
           
            Console.Write(" A+B = ");
            Console.WriteLine(a.Sum(b));

            Console.Write(" A-B = ");
            Console.WriteLine(a.Sub(b));

            Console.Write(" A*10 = ");
            Console.WriteLine(a.Mult(10));

            Console.Write(" A/10 = ");
            Console.WriteLine(a.Div(10));
          
            Console.Write(" AxB = ");
            Console.WriteLine(a.CrossProd(b));
            Console.WriteLine();

            float dotproduct = a.DotProd(b);
            Console.WriteLine(" A*B = " + dotproduct);
            Console.WriteLine();

            float alength = a.Length();
            Console.Write(" |A| = " + Math.Round(alength, 2));
            Console.WriteLine();
        }
    }
}
