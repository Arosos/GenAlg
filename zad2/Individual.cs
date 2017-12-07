using System;
using System.Collections;

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
            fitness = PopulationInfo.Function(chromosome);
        }

        public override string ToString()
        {
            string s = "Chromosome:\n";
            foreach (int i in chromosome)
                s += i.ToString() + ' ';
            s += "\nFitness: " + fitness;

            return s;
        }
    }
}