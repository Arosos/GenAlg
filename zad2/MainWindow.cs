using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

namespace zad2
{
    public partial class MainWindow : Form
    {
        string filename = @"..\..\..\data\TownCoordinates.txt";

        public static Generation[] generations;
        
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        public static void Generate()
        {
            generations[0] = Generation.FirstGeneration();

            Console.WriteLine(generations[0]);

            for (int i = 1; i < PopulationInfo.generationNumber; i++)
            {
                Generation generation = generations[i - 1];
                Individual[] population = new Individual[PopulationInfo.populationSize];
                for (int j = 0; j < PopulationInfo.populationSize; j += 2)
                {
                    Individual parent1 = Genetics.Select(generation);
                    Individual parent2 = Genetics.Select(generation);
                    Individual child1, child2;
                    Genetics.Crossover(parent1, parent2, out child1, out child2);
                    Genetics.Mutation(child1);
                    Genetics.Mutation(child2);
                    population[j] = child1;
                    population[j + 1] = child2;
                }
                generations[i] = new Generation(population);
            }

            foreach (Generation g in generations)
                Console.WriteLine(g);
        }

        private void PickFileButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Path.Combine(Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName).FullName, "data");
            DialogResult result = openFileDialog1.ShowDialog();
            filename = openFileDialog1.FileName;
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            PopulationInfo.GetInfo(filename, (int)populationSize.Value, (int)generationNumber.Value, (double)mutation.Value, (double)cross.Value);
            generations = new Generation[PopulationInfo.generationNumber];
            Generate();
            SetupSeries(longestPathChart);
            SetupSeries(shortestPathChart);
            Display();
        }

        void Display()
        {
            AverageChart.Series["Generation"].Points.Clear();
            MaxChart.Series["Generation"].Points.Clear();
            MinChart.Series["Generation"].Points.Clear();
            shortestPathChart.Series["Path"].Points.Clear();
            longestPathChart.Series["Path"].Points.Clear();
            
            Series avSeries = AverageChart.Series["Generation"];
            Series maxSeries = MaxChart.Series["Generation"];
            Series minSeries = MinChart.Series["Generation"];

            foreach (Generation g in generations)
            {
                avSeries.Points.Add(g.average);
                maxSeries.Points.Add(g.max.fitness);
                minSeries.Points.Add(g.min.fitness);
            }

            foreach (int i in generations[PopulationInfo.generationNumber - 1].max.chromosome)
                shortestPathChart.Series["Path"].Points.AddXY(PopulationInfo.points[i].X, PopulationInfo.points[i].Y);
            shortestPathChart.Series["Path"].Points.AddXY(PopulationInfo.points[generations[PopulationInfo.generationNumber - 1].max.chromosome[0]].X, PopulationInfo.points[generations[PopulationInfo.generationNumber - 1].max.chromosome[0]].Y);

            foreach (int i in generations[PopulationInfo.generationNumber - 1].min.chromosome)
                longestPathChart.Series["Path"].Points.AddXY(PopulationInfo.points[i].X, PopulationInfo.points[i].Y);
            longestPathChart.Series["Path"].Points.AddXY(PopulationInfo.points[generations[PopulationInfo.generationNumber - 1].min.chromosome[0]].X, PopulationInfo.points[generations[PopulationInfo.generationNumber - 1].min.chromosome[0]].Y);
        }

        void SetupSeries(Chart chart)
        {
            chart.Series["Points"].Points.Clear();
            foreach (Point p in PopulationInfo.points)
                chart.Series["Points"].Points.AddXY(p.X, p.Y);
            chart.ChartAreas[0].AxisX.Interval = 1;
            chart.ChartAreas[0].AxisY.Interval = 1;
        }
    }
}