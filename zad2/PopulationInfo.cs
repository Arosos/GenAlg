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
    }
}