using System;
using System.IO;
using System.Drawing;
using System.Linq;

namespace zad2
{
    public static class PopulationInfo
    {
        public const int maxPopulation = 100, maxString = 30;

        public static int firstGenerationSize, populationSize = 10, stringSize, generationNumber = 15;

        public static double pmutation = 0.2, pcross = 0.7;

        public static Point[] points;

        public static void GetInfo(string filename, int populationSize, int generationNumber, double pmutation, double pcross)
        {
            PopulationInfo.populationSize = populationSize;
            PopulationInfo.generationNumber = generationNumber;
            PopulationInfo.pmutation = pmutation;
            PopulationInfo.pcross = pcross;
            stringSize = File.ReadLines(filename).Count();
            points = new Point[stringSize];
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