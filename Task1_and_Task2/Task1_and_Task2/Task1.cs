using System;
using System.Collections.Generic;
using System.Text;

namespace Task1_and_Task2
{
    public class Task1
    {
        public void Tasks1()
        {
            int SideA, SideB, SideC;

            if (int.TryParse(Console.ReadLine(), out SideA) && int.TryParse(Console.ReadLine(), out SideB) && int.TryParse(Console.ReadLine(), out SideC))
            {
                int[] arr = { SideA, SideB, SideC };

                Console.WriteLine("Positivity Test: " + PositivityTest(arr));
                Console.WriteLine("Triangle Formation Test: " + TriangleFormationTest(arr));

                if (PositivityTest(arr) == true && TriangleFormationTest(arr) == true)
                {
                    Console.WriteLine("Perimeter of the triangle: " + PerimeterTriangle(arr));
                    Console.WriteLine("Area of the triangle (Heron's formula): " + AreaTriangleHeron(arr));
                    TriangleType(arr);
                }
            }
        }

        private static bool PositivityTest(int[] arr)
        {
            foreach (int number in arr)
            {
                if (number <= 0)
                {
                    return false;
                }
            }
            return true;
        }

        private static bool TriangleFormationTest(int[] arr)
        {
            if (!(arr[0] + arr[1] <= arr[2]) || !(arr[1] + arr[2] <= arr[0]) || !(arr[2] + arr[0] <= arr[1]))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static int PerimeterTriangle(int[] arr)
        {
            return arr[0] + arr[1] + arr[2];
        }

        private static double AreaTriangleHeron(int[] arr)
        {
            double s = PerimeterTriangle(arr) / 2.0;
            return Math.Sqrt(s * (s - arr[0]) * (s - arr[1]) * (s - arr[2]));
        }

        private static void TriangleType(int[] arr)
        {
            double a = Math.Pow(arr[0], 2);
            double b = Math.Pow(arr[1], 2);
            double c = Math.Pow(arr[2], 2);

            if (arr[0] == arr[1] && arr[1] == arr[2])
            {
                Console.WriteLine("The triangle is equilateral.");
            }
            else if (arr[0] == arr[1] || arr[1] == arr[2] || arr[0] == arr[2])
            {
                Console.WriteLine("The triangle is isosceles.");
            }
            else if (a + b == c || a + c == b || b + c == a)
            {
                Console.WriteLine("The triangle is right-angled.");
            }
            else
            {
                Console.WriteLine("The triangle is arbitrary");
            }
        }
    }
}
