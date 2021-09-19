﻿using System;

namespace CountSquare
{
    public static class Program
    {
        public static double Count(this int[] array, out bool is_right)
        {
            //for triangles
            if (array is null)
            {
                throw new ArgumentNullException();
            }
            double square = 0;
            is_right = false;
            if (array.Length == 3)
            {
                double a = array[0];
                double b = array[1];
                double c = array[2];

                //check if triangle is right
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
                square = Math.Sqrt(perimeter * (perimeter - a) * (perimeter - b) * (perimeter - c));
            }
            else
            {
                //for circles
                double radius = array[0];
                square = (radius * radius) * Math.PI;
            }
            return square;
        }
        public static void Main(string []str)
        {
            bool is_right = false;
            double res = Count(new int[] { 5}, out is_right);
        }
    }
}
