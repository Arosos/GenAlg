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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pickFileButton = new System.Windows.Forms.Button();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.populationSize = new System.Windows.Forms.NumericUpDown();
            this.generationNumber = new System.Windows.Forms.NumericUpDown();
            this.mutation = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.populationSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generationNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mutation)).BeginInit();
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
            this.pickFileButton.Size = new System.Drawing.Size(75, 35);
            this.pickFileButton.TabIndex = 0;
            this.pickFileButton.Text = "Wybierz plik z danymi";
            this.pickFileButton.UseVisualStyleBackColor = true;
            this.pickFileButton.Click += new System.EventHandler(this.PickFileButton_Click);
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(95, 13);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(75, 35);
            this.GenerateButton.TabIndex = 1;
            this.GenerateButton.Text = "Generuj";
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
            this.mutation.DecimalPlaces = 2;
            this.mutation.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
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
            65536});
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
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
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
    }
}