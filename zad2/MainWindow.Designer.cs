namespace zad2
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pickFileButton = new System.Windows.Forms.Button();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.populationSize = new System.Windows.Forms.NumericUpDown();
            this.generationNumber = new System.Windows.Forms.NumericUpDown();
            this.mutation = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.shortestPathChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.longestPathChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.AverageChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.MaxChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.MinChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            this.cross = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.populationSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generationNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mutation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shortestPathChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.longestPathChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AverageChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cross)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "TownCoordinates.txt";
            // 
            // pickFileButton
            // 
            this.pickFileButton.Location = new System.Drawing.Point(13, 13);
            this.pickFileButton.Name = "pickFileButton";
            this.pickFileButton.Size = new System.Drawing.Size(299, 35);
            this.pickFileButton.TabIndex = 0;
            this.pickFileButton.Text = "Select data file";
            this.pickFileButton.UseVisualStyleBackColor = true;
            this.pickFileButton.Click += new System.EventHandler(this.PickFileButton_Click);
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(12, 277);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(300, 35);
            this.GenerateButton.TabIndex = 1;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Population size:";
            // 
            // populationSize
            // 
            this.populationSize.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.populationSize.Location = new System.Drawing.Point(95, 56);
            this.populationSize.Name = "populationSize";
            this.populationSize.Size = new System.Drawing.Size(75, 20);
            this.populationSize.TabIndex = 4;
            this.populationSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.populationSize.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // generationNumber
            // 
            this.generationNumber.Location = new System.Drawing.Point(95, 82);
            this.generationNumber.Name = "generationNumber";
            this.generationNumber.Size = new System.Drawing.Size(75, 20);
            this.generationNumber.TabIndex = 5;
            this.generationNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.generationNumber.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // mutation
            // 
            this.mutation.DecimalPlaces = 3;
            this.mutation.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.mutation.Location = new System.Drawing.Point(95, 108);
            this.mutation.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.mutation.Name = "mutation";
            this.mutation.Size = new System.Drawing.Size(75, 20);
            this.mutation.TabIndex = 6;
            this.mutation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mutation.Value = new decimal(new int[] {
            2,
            0,
            0,
            196608});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Generations:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mutation:";
            // 
            // shortestPathChart
            // 
            chartArea1.Name = "ChartArea1";
            this.shortestPathChart.ChartAreas.Add(chartArea1);
            this.shortestPathChart.Location = new System.Drawing.Point(318, 12);
            this.shortestPathChart.Name = "shortestPathChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Red;
            series1.Name = "Path";
            series1.XValueMember = "1";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series1.YValueMembers = "1";
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Color = System.Drawing.Color.Blue;
            series2.Name = "Points";
            this.shortestPathChart.Series.Add(series1);
            this.shortestPathChart.Series.Add(series2);
            this.shortestPathChart.Size = new System.Drawing.Size(300, 300);
            this.shortestPathChart.TabIndex = 9;
            this.shortestPathChart.Text = "chart1";
            title1.Name = "shortestPathTitle";
            title1.Text = "Shortest Path";
            this.shortestPathChart.Titles.Add(title1);
            // 
            // longestPathChart
            // 
            chartArea2.Name = "ChartArea1";
            this.longestPathChart.ChartAreas.Add(chartArea2);
            this.longestPathChart.Location = new System.Drawing.Point(624, 12);
            this.longestPathChart.Name = "longestPathChart";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.Red;
            series3.Name = "Path";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series4.Color = System.Drawing.Color.Blue;
            series4.Name = "Points";
            this.longestPathChart.Series.Add(series3);
            this.longestPathChart.Series.Add(series4);
            this.longestPathChart.Size = new System.Drawing.Size(300, 300);
            this.longestPathChart.TabIndex = 10;
            this.longestPathChart.Text = "chart1";
            title2.Name = "longestPathTitle";
            title2.Text = "Longest Path";
            this.longestPathChart.Titles.Add(title2);
            // 
            // AverageChart
            // 
            chartArea3.Name = "ChartArea1";
            this.AverageChart.ChartAreas.Add(chartArea3);
            this.AverageChart.Location = new System.Drawing.Point(12, 318);
            this.AverageChart.Name = "AverageChart";
            series5.ChartArea = "ChartArea1";
            series5.Name = "Generation";
            this.AverageChart.Series.Add(series5);
            this.AverageChart.Size = new System.Drawing.Size(300, 300);
            this.AverageChart.TabIndex = 11;
            this.AverageChart.Text = "chart1";
            title3.Name = "Title1";
            title3.Text = "Average fitness per generation";
            this.AverageChart.Titles.Add(title3);
            // 
            // MaxChart
            // 
            chartArea4.Name = "ChartArea1";
            this.MaxChart.ChartAreas.Add(chartArea4);
            this.MaxChart.Location = new System.Drawing.Point(318, 318);
            this.MaxChart.Name = "MaxChart";
            series6.ChartArea = "ChartArea1";
            series6.Name = "Generation";
            this.MaxChart.Series.Add(series6);
            this.MaxChart.Size = new System.Drawing.Size(300, 300);
            this.MaxChart.TabIndex = 12;
            this.MaxChart.Text = "chart2";
            title4.Name = "Title1";
            title4.Text = "Maximal fitness";
            this.MaxChart.Titles.Add(title4);
            // 
            // MinChart
            // 
            chartArea5.Name = "ChartArea1";
            this.MinChart.ChartAreas.Add(chartArea5);
            this.MinChart.Location = new System.Drawing.Point(624, 318);
            this.MinChart.Name = "MinChart";
            series7.ChartArea = "ChartArea1";
            series7.Name = "Generation";
            this.MinChart.Series.Add(series7);
            this.MinChart.Size = new System.Drawing.Size(300, 300);
            this.MinChart.TabIndex = 13;
            this.MinChart.Text = "chart3";
            title5.Name = "Title1";
            title5.Text = "Minimal fitness";
            this.MinChart.Titles.Add(title5);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Cross:";
            // 
            // cross
            // 
            this.cross.DecimalPlaces = 2;
            this.cross.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.cross.Location = new System.Drawing.Point(95, 134);
            this.cross.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cross.Name = "cross";
            this.cross.Size = new System.Drawing.Size(75, 20);
            this.cross.TabIndex = 14;
            this.cross.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cross.Value = new decimal(new int[] {
            7,
            0,
            0,
            65536});
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 629);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cross);
            this.Controls.Add(this.MinChart);
            this.Controls.Add(this.MaxChart);
            this.Controls.Add(this.AverageChart);
            this.Controls.Add(this.longestPathChart);
            this.Controls.Add(this.shortestPathChart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mutation);
            this.Controls.Add(this.generationNumber);
            this.Controls.Add(this.populationSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.pickFileButton);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            ((System.ComponentModel.ISupportInitialize)(this.populationSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generationNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mutation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shortestPathChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.longestPathChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AverageChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cross)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button pickFileButton;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown populationSize;
        private System.Windows.Forms.NumericUpDown generationNumber;
        private System.Windows.Forms.NumericUpDown mutation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart shortestPathChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart longestPathChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart AverageChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart MaxChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart MinChart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown cross;
    }
}