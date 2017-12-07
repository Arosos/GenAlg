using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace zad2
{
    public static class Genetics
    {
        static Random random = new Random();

        public static Individual Select(Generation generation)
        {
            double rand = random.NextDouble() * generation.sumfitness;
            int j = -1;
            double partsum = 0.0;
            do
            {
                j++;
                partsum += generation.population[j].fitness;
            } while (partsum < rand && j != generation.population.Length);

            return generation.population[j];
        }

        public static void Crossover(Individual parent1, Individual parent2, out Individual child1, out Individual child2)
        {
            int crossoverPoint1 = random.Next(0, PopulationInfo.stringSize - 1);
            int crossoverPoint2 = random.Next(0, PopulationInfo.stringSize - 1);
            Console.WriteLine(crossoverPoint1 + " " + crossoverPoint2);
            child1 = Cross(parent1, parent2, crossoverPoint1, crossoverPoint2);
            child2 = Cross(parent2, parent1, crossoverPoint1, crossoverPoint2);
        }

        static Individual Cross(Individual parent1, Individual parent2, int crossoverPoint1, int crossoverPoint2)
        {
            int[] chromosome = new int[PopulationInfo.stringSize];

            for (int i = 0; i < chromosome.Length; i++)
                chromosome[i] = -1;

            int lessPoint = crossoverPoint1 > crossoverPoint2 ? crossoverPoint2 : crossoverPoint1;
            int greaterPoint = crossoverPoint1 < crossoverPoint2 ? crossoverPoint2 : crossoverPoint1;
            for (int i = lessPoint; i < greaterPoint + 1; i++)
                chromosome[i] = parent1.chromosome[i];

            List<Point> noCopied = new List<Point>();
            for (int i = lessPoint; i < greaterPoint + 1; i++)
                if (!chromosome.Contains(parent2.chromosome[i]))
                    noCopied.Add(new Point(parent2.chromosome[i], chromosome[i]));

            foreach (Point p in noCopied)
            {
                Point point = p;
                bool isPlaced = false;
                while (!isPlaced)
                {
                    int indexOfYInParent2 = Array.IndexOf(parent2.chromosome, point.Y);
                    if (chromosome[indexOfYInParent2] == -1)
                    {
                        chromosome[indexOfYInParent2] = p.X;
                        isPlaced = true;
                    }
                    else
                        point.Y = parent1.chromosome[indexOfYInParent2];
                }
            }

            foreach (int i in parent2.chromosome)
            {
                if (!chromosome.Contains(i))
                    chromosome[Array.IndexOf(chromosome, -1)] = i;
            }

            return new Individual(chromosome, parent1, parent2);
        }

        public static void Mutation(Individual i)
        {
            if (Flip(PopulationInfo.pmutation))
            {
                int jmutation1 = random.Next(0, PopulationInfo.stringSize);
                int jmutation2 = random.Next(0, PopulationInfo.stringSize);
                int temp = i.chromosome[jmutation1];
                i.chromosome[jmutation1] = i.chromosome[jmutation2];
                i.chromosome[jmutation2] = temp;
            }
        }

        public static bool Flip(double p) => p > random.NextDouble();
    }
}