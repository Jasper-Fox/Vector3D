using MyMath;

namespace _3D_Vector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector3D a = new Vector3D(1f, 2f, 3f);
            Vector3D b = new Vector3D(2f, 3f, 4f);
            Vector3D c = new Vector3D();
           
            Console.Write(" A+B = ");
            Console.WriteLine(c = a.Sum(b));

            Console.Write(" A-B = ");
            Console.WriteLine(c = a.Sub(b));

            Console.Write(" A*10 = ");
            Console.WriteLine(c = a.Mult(10));

            Console.Write(" A/10 = ");
            Console.WriteLine(c = a.Div(10));
          
            Console.Write(" AxB = ");
            Console.WriteLine(c = a.CrossProd(b));
            Console.WriteLine();

            float dotproduct = a.DotProd(b);
            Console.WriteLine(" A*B = " + dotproduct);
            Console.WriteLine();

            float alength = a.Length();
            Console.Write(" |A| = " + alength);
            Console.WriteLine();
        }
    }
}
