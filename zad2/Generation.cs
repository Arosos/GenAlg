using System;
using System.Collections.Generic;

namespace zad2
{
    public class Generation
    {
        public Individual[] population;
        public double sumfitness, average;
        public Individual max, min;
        
        static Random r = new Random();

        public Generation(Individual[] population)
        {
            this.population = population;
            min = max = population[0];
            foreach (Individual i in this.population)
            {
                sumfitness += i.fitness;
                if (i.fitness < min.fitness)
                    min = i;
                if (i.fitness > max.fitness)
                    max = i;
            }
            average = sumfitness / population.Length;
        }

        public static Generation FirstGeneration()
        {
            Individual[] population = new Individual[PopulationInfo.populationSize];

            for (int i = 0; i < population.Length; i++)
            {
                int[] chromosome = RandomSequence();
                population[i] = new Individual(chromosome, null, null);
            }

            return new Generation(population);
        }

        static int[] RandomSequence()
        {
            int[] sequence = new int[PopulationInfo.stringSize];
            List<int> indices = new List<int>();
            for (int i = 0; i < PopulationInfo.stringSize; i++)
                indices.Add(i);

            int j = 0;
            while (indices.Count > 0)
            {
                sequence[j] = indices[r.Next(0, indices.Count)];
                indices.Remove(sequence[j]);
                j++;
            }
            return sequence;
        }

        public override string ToString()
        {
            string s = "";
            foreach (Individual i in population)
                s += i.ToString() + "\n";
            s += "Sumfitness: " + sumfitness;
            s += "\nAverage value: " + average;
            s += "\nMax value: " + max.fitness;
            s += "\nMin value: " + min.fitness;
            s += "\n==============================================================";

            return s;
        }
    }
}