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

namespace zad2
{
    public partial class MainWindow : Form
    {
        string filename;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void PickFileButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            DialogResult result = openFileDialog1.ShowDialog();
            filename = openFileDialog1.FileName;
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            PopulationInfo.GetInfo(filename, (int)populationSize.Value, (int)generationNumber.Value, (double)mutation.Value);
            Program.Generate();
        }
    }
}
