using System;

namespace CountSquare
{
    public static class Program
    {
        public static double max(double a, double b, double c)
        {
            double max = 0;
            if (a >= b && a >= c)
            {
                max =  a;
            }
            if (b >= a && b >= c)
            {
                max =  b;
            }
            if (c >= a && c >= b)
            {
                max =  c;
            }
            return max;
        }
        public static double Count(this int[] array)
        {
            string str = "number";
            int i = 0;
            //int[] array = {-1, -1, -1, -1, -1};
            /*
            while (str != "!")
            {
                str = Console.ReadLine();
                int number = -1;
                if (str != "!")
                {
                    Int32.TryParse(str, out number);
                    array[i] = number;
                }
                i++;
                //Console.WriteLine(number);
            }
            */
            //for triangles
            if (array is null)
            {
                throw new ArgumentNullException();
            }
            /*
            double a = array[0];
            double b = array[1];
            double c = array[2];
            //check if triangle is right
            bool is_right = false;
            if (a >= b && a >= c)
            {
                if ((a * a) == (b * b + c * c))
                {
                    is_right = true;
                }
            }
            if (b >= a && b >= c)
            {
                if ((b * b) == (a * a + c * c))
                {
                    is_right = true;
                }
            }
            if (c >= a && c >= b)
            {
                if ((c * c) == (b * b + a * a))
                {
                    is_right = true;
                }
            }
            double perimeter = (a + b + c) / 2;
            double square = Math.Sqrt(perimeter * (perimeter - a) * (perimeter - b) * (perimeter - c));
            //Console.WriteLine(square);
            */
            //for circles
            double radius = array[0];
            double circle_sq = (radius * radius) * Math.PI;
            Console.WriteLine(circle_sq);
            double square = 0;
            return square;
        }
        public static void Main(string []str)
        {

            double res = Count(new int[] { 5});
        }
    }
}
