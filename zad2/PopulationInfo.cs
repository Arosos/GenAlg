using System;
using System.IO;
using System.Drawing;

namespace zad2
{
    public static class PopulationInfo
    {
        public const int maxPopulation = 100, maxString = 30, generationNumber = 15;
        public const double pcross = 0.7, pmutation = 0.2;

        public static int firstGenerationSize, populationSize, stringSize;

        public static Point[] points;

        public static void GetInfo(string filename)
        {
            Console.WriteLine(filename);
            try
            {
                using (StreamReader streamReader = new StreamReader(filename))
                {
                    string[] data = streamReader.ReadToEnd().Split('\n');
                    int counter = 0;
                    foreach (string s in data)
                    {
                        string[] coordinates = s.Split(' ');
                        points[counter].X = int.Parse(coordinates[0]);
                        points[counter++].Y = int.Parse(coordinates[1]);
                    }
                    Console.WriteLine(points);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("File not found");
                Console.WriteLine(e.Message);
            }
        }

        /*public static double Function(int x)
        {
            double sum = 0.0;

            for (int i = 0; i < coefficients.Length; i++)
            {
                sum += Math.Pow(x, coefficients.Length - i - 1) * coefficients[i];
            }

            return sum;
        }*/
    }
}