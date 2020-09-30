using System;

namespace LineComparisionProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            static int i = 1;

            public static Line CreateLine()
            {
                int x1 = 0, x2 = 0, y1 = 0, y2 = 0;

                Console.WriteLine("Enter the Line" + i++ + " coordinates");

                Console.WriteLine("Enter the coordinates");

                Console.WriteLine("x1: ");
                x1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("y1: ");
                y1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the coordinates of ");

                Console.WriteLine("x2: ");
                x2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("y2: ");
                y2 = Convert.ToInt32(Console.ReadLine());

                Line line = new Line(x1, x2, y1, y2);

                return line;
            }

            static void Main(string[] args)
            {

                // two lines creation

                Line line1 = CreateLine();

                // line1 length calc
                line1.CalulateLength();

                Line line2 = CreateLine();

                // line2 length calc
                line2.CalulateLength();

                Console.Out.WriteLine("Comparing two lies beased on End points\n-----------------------------------------");

                bool isequal = line1.IsEqual(line2);

                if (isequal)
                {
                    Console.Out.WriteLine("Both are equal\n");

                }
                else
                {
                    Console.Out.WriteLine("Both are not equal\n");
                }
                // comparing two lines length 
                Console.Out.WriteLine("Comparing two lies beased on length \n----------------------------------------");
                int k = line1.CompareLines(line2);


                if (k == 0)
                {
                    Console.WriteLine("Equal lines");
                }
                else if (k > 0)
                {
                    Console.WriteLine("Line1 is longer  than Line2");
                }
                else
                {
                    Console.WriteLine("Line1 is shorter  than Line2");
                }

            }
    }
}
