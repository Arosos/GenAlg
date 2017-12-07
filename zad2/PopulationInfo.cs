using System;
using System.IO;
using System.Drawing;

namespace zad2
{
    public static class PopulationInfo
    {
        public const int maxPopulation = 100, maxString = 30;
        public const double pcross = 0.7;

        public static int firstGenerationSize, populationSize = 10, stringSize, generationNumber = 15;

        public static double pmutation = 0.2;

        public static Point[] points = new Point[populationSize];

        public static void GetInfo(string filename, int populationSize, int generationNumber, double pmutation)
        {
            PopulationInfo.populationSize = populationSize;
            PopulationInfo.generationNumber = generationNumber;
            PopulationInfo.pmutation = pmutation;
            try
            {
                using (StreamReader streamReader = new StreamReader(filename))
                {
                    string line;
                    int counter = 0;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        string[] coordinates = line.Split(' ');
                        points[counter].X = int.Parse(coordinates[0]);
                        points[counter++].Y = int.Parse(coordinates[1]);
                    }
                    stringSize = counter;
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("File not found");
                Console.WriteLine(e.Message);
            }
        }

        public static double Function(int[] x)
        {
            double sum = 0.0;
            
            for (int i = 1; i < x.Length; i++)
            {
                Point point1 = points[x[i - 1]];
                Point point2 = points[x[i]];
                sum += Distance(point1, point2);
            }
            sum += Distance(points[x[x.Length - 1]], points[x[0]]);

            return Math.Pow(1 / sum, 7);
        }

        static double Distance(Point x, Point y)
        {
            return Math.Sqrt(Math.Pow(x.X - y.X, 2) + Math.Pow(x.Y - y.Y, 2));
        }
    }
}