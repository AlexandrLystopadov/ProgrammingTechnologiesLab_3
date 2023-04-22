using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ProgrammingTechnologiesLab_3
{
    internal class Class
    {
        private int[] array;
        private int size, a, b;

        
        public Class() { }
        public Class(int size, int a, int b)
        {
            this.size = size;
            this.a = a;
            this.b = b;
        }
        public Class(int[] array)
        {
            this.array = array;
        }

        public int[] generateArray()
        {
            Random random = new Random();
            array = new int[size];

            for(int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(a, b + 1);
            }
            return array;
        }

        public void saveInFile()
        {
            SaveFileDialog save = new SaveFileDialog();
            save.InitialDirectory = @"E:\";
            save.RestoreDirectory = true;
            save.Title = "Save file";
            save.FileName = "Array.xml";
            save.DefaultExt = "xml";
            save.Filter = "XML files(.xml)|.xml|all Files(.)|.*";

            if (save.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(int[]));

                using (FileStream fs = new FileStream("file.xml", FileMode.OpenOrCreate))
                {
                    xmlSerializer.Serialize(fs, array);

                }
            }


        }



    }
}
