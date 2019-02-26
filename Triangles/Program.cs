using System;

namespace Triangles
{
    public class Program
    {
        static void Main(string[] args)
        {
            Run();
        }

        static void Run()
        {
            Console.WriteLine("Please input 3 integers to determine the type of triangle.");
            checkInputs();
            Console.WriteLine("Press any key to exit");

            while (Console.ReadLine() != string.Empty)
            {
                
            }
        }

        private static void checkInputs()
        {
            int sideA,
                sideB,
                sideC;

            Console.Write("Side 1: ");
            if (int.TryParse(Console.ReadLine(), out sideA))
            {
                Console.Write("Side 2: ");
                if (int.TryParse(Console.ReadLine(), out sideB))
                {
                    Console.Write("Side 3: ");
                    if (int.TryParse(Console.ReadLine(), out sideC))
                    {
                        var triangleType = GetTriangleType(sideA, sideB, sideC);

                        Console.WriteLine("Triangle Type: " + triangleType);
                        return;
                    }
                }
            }

            Console.WriteLine("Please Input Integers");
            checkInputs();
        }

        public static string GetTriangleType(int a, int b, int c)
        {
            if (a == b && b == c)
            {
                return Constants.EQUILATERAL;
            }
            else if (a == b && b != c || b == c && c != a || a == c && a != b)
            {
                return Constants.ISOSCELES;
            }
            else
            {
                return Constants.SCALENE;
            }
        }
    }
}
