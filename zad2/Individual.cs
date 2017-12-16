using System;
using System.Collections;
using System.Drawing;

namespace zad2
{
    public class Individual
    {
        public int[] chromosome;
        public double fitness;
        public Individual parent1, parent2;

        public Individual(int[] chromosome, Individual parent1, Individual parent2)
        {
            this.chromosome = chromosome;
            this.parent1 = parent1;
            this.parent2 = parent2;
            fitness = Function(chromosome);
        }

        public Individual(Individual i)
        {
            chromosome = i.chromosome;
            parent1 = i.parent1;
            parent2 = i.parent2;
            fitness = i.fitness;
        }

        public override string ToString()
        {
            string s = "Chromosome:\n";
            foreach (int i in chromosome)
                s += i.ToString() + ' ';
            s += "\nFitness: " + fitness;

            return s;
        }

        double Function(int[] x)
        {
            double sum = 0.0;

            for (int i = 1; i < x.Length; i++)
            {
                Point point1 = PopulationInfo.points[x[i - 1]];
                Point point2 = PopulationInfo.points[x[i]];
                sum += Distance(point1, point2);
            }
            sum += Distance(PopulationInfo.points[x[x.Length - 1]], PopulationInfo.points[x[0]]);

            return Math.Pow(1 / sum, 7);
        }

        double Distance(Point x, Point y)
        {
            return Math.Sqrt(Math.Pow(x.X - y.X, 2) + Math.Pow(x.Y - y.Y, 2));
        }
    }
}