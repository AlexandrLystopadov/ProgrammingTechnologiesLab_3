using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ProgrammingTechnologiesLab_3
{
    public partial class Form1 : Form
    {
        //[0...5000], xml, 2,5,11,18
        private int[] array;
        private int size, a, b;


        public Form1()
        {
            InitializeComponent();
        }
        private void generate_Click(object sender, EventArgs e)
        {
            a = (int)aInput.Value;
            b = (int)bInput.Value;
            size = (int)sizeInput.Value;

            array = new int[size];

            grid.RowCount = size;
            grid.ColumnCount = 2;

            Class arr = new Class(size, a, b);
            array = arr.generateArray();

            for (int i = 0; i < array.Length; i++)
            {
                grid.Rows[i].Cells[0].Value = i + 1;
                grid.Rows[i].Cells[1].Value = array[i];
            }

            string arrOutput = string.Join(", ", array);
            output.Text = arrOutput;
        }

        private void SaveInFile_Click(object sender, EventArgs e)
        {
            Class cls = new Class(array);
            cls.saveInFile();


        }

    }
}
