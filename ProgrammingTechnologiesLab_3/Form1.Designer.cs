namespace ProgrammingTechnologiesLab_3
{
    partial class Form1
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
            this.grid = new System.Windows.Forms.DataGridView();
            this.output = new System.Windows.Forms.TextBox();
            this.generate = new System.Windows.Forms.Button();
            this.sizeInput = new System.Windows.Forms.NumericUpDown();
            this.aInput = new System.Windows.Forms.NumericUpDown();
            this.bInput = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SaveInFile = new System.Windows.Forms.Button();
            this.OpenInFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bInput)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(12, 12);
            this.grid.Name = "grid";
            this.grid.RowHeadersWidth = 51;
            this.grid.RowTemplate.Height = 24;
            this.grid.Size = new System.Drawing.Size(341, 426);
            this.grid.TabIndex = 0;
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(359, 80);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(429, 22);
            this.output.TabIndex = 1;
            // 
            // generate
            // 
            this.generate.Location = new System.Drawing.Point(359, 108);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(87, 23);
            this.generate.TabIndex = 2;
            this.generate.Text = "Generate";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // sizeInput
            // 
            this.sizeInput.Location = new System.Drawing.Point(359, 31);
            this.sizeInput.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.sizeInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sizeInput.Name = "sizeInput";
            this.sizeInput.Size = new System.Drawing.Size(120, 22);
            this.sizeInput.TabIndex = 3;
            this.sizeInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // aInput
            // 
            this.aInput.Location = new System.Drawing.Point(514, 31);
            this.aInput.Maximum = new decimal(new int[] {
            4999,
            0,
            0,
            0});
            this.aInput.Name = "aInput";
            this.aInput.Size = new System.Drawing.Size(120, 22);
            this.aInput.TabIndex = 4;
            // 
            // bInput
            // 
            this.bInput.Location = new System.Drawing.Point(668, 31);
            this.bInput.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.bInput.Name = "bInput";
            this.bInput.Size = new System.Drawing.Size(120, 22);
            this.bInput.TabIndex = 5;
            this.bInput.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(401, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(561, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(718, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "B";
            // 
            // SaveInFile
            // 
            this.SaveInFile.Location = new System.Drawing.Point(360, 138);
            this.SaveInFile.Name = "SaveInFile";
            this.SaveInFile.Size = new System.Drawing.Size(75, 23);
            this.SaveInFile.TabIndex = 9;
            this.SaveInFile.Text = "Save In File";
            this.SaveInFile.UseVisualStyleBackColor = true;
            this.SaveInFile.Click += new System.EventHandler(this.SaveInFile_Click);
            // 
            // OpenInFile
            // 
            this.OpenInFile.Location = new System.Drawing.Point(360, 168);
            this.OpenInFile.Name = "OpenInFile";
            this.OpenInFile.Size = new System.Drawing.Size(75, 23);
            this.OpenInFile.TabIndex = 10;
            this.OpenInFile.Text = "Open In File";
            this.OpenInFile.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OpenInFile);
            this.Controls.Add(this.SaveInFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bInput);
            this.Controls.Add(this.aInput);
            this.Controls.Add(this.sizeInput);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.output);
            this.Controls.Add(this.grid);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.NumericUpDown sizeInput;
        private System.Windows.Forms.NumericUpDown aInput;
        private System.Windows.Forms.NumericUpDown bInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SaveInFile;
        private System.Windows.Forms.Button OpenInFile;
    }
}

